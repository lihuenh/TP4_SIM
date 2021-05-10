using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using System.Threading;

namespace TP4_SIM
{
    public partial class TestMontecarlo : Form
    {
        public TestMontecarlo()
        {
            InitializeComponent();
        }
        NumberFormatInfo formato = new CultureInfo("es-AR").NumberFormat;
        NumberFormatInfo formato2 = new CultureInfo("es-AR").NumberFormat;

        private void btn_generar_simulacion_Click(object sender, EventArgs e)
        {
            int cantidad_iteraciones = int.Parse(txt_cantidad_iteraciones.Text);
            int iteracion_desde = int.Parse(txt_desde.Text);
            int iteracion_hasta = int.Parse(txt_hasta.Text);
            double media = float.Parse(txt_media.Text);

            formato.CurrencyGroupSeparator = ".";
            formato.NumberDecimalSeparator = ",";
            formato.NumberDecimalDigits = 4;

            if (GenerarSimulacion(cantidad_iteraciones, iteracion_desde, iteracion_hasta, media, out DataTable simulacion_desde_hasta, out double produccion_total))
            {
                dgv_resultados.DataSource = simulacion_desde_hasta;
                txt_toneladas_totales.Text = produccion_total.ToString("N",formato);
            }
            else
            {
                // Lanzar evento error en ventana
            }
        }

        private bool GenerarSimulacion(int iteraciones, int desde, int hasta, double media_exp, out DataTable simulacion_desde_hasta, out double produccion_total)
        {
            Stopwatch timeMeasure = new();

            int cantidad_iteraciones = iteraciones;
            int iteracion_desde = desde;
            int iteracion_hasta = hasta;
            double media = media_exp;

            formato.CurrencyGroupSeparator = ".";
            formato.NumberDecimalSeparator = ",";
            formato.NumberDecimalDigits = 4;

            formato2.CurrencyGroupSeparator = ".";
            formato2.NumberDecimalSeparator = ",";
            formato2.NumberDecimalDigits = 0;

            DataTable resultado = new();
            resultado.Columns.Add("Dia");
            resultado.Columns.Add("RND Fertilizante");
            resultado.Columns.Add("Llegada fertilizante (días)");
            resultado.Columns.Add("RND Clima");
            resultado.Columns.Add("Clima");
            resultado.Columns.Add("Sol");
            resultado.Columns.Add("Lluvia");
            resultado.Columns.Add("Nublado");
            resultado.Columns.Add("Prob Sol");
            resultado.Columns.Add("Prob Lluvia");
            resultado.Columns.Add("Prob Nublado");
            resultado.Columns.Add("Produccion (Toneladas)");

            double random_fertilizante = 0, llegada_fertilizante = 0, random_clima, produccion_ayer = 0, produccion_hoy = 0;

            int num_clima_ayer = 0; // 0 para el calculo del primer clima, 1 Sol - 2 Lluvia - 3 Nublado
            int num_clima_hoy; // 1 Sol - 2 Lluvia - 3 Nublado

            // Contadores, pos 0 (sol) pos 1 (lluvia) pos 2 (nublado)
            int[] contador_climas = { 0, 0, 0 };

            // Acumulador probabilidades climas, pos 0 (sol) pos 1 (lluvia) pos 2 (nublado)
            double[] acumulador_prob_climas = { 0.0, 0.0, 0.0 };

            // Arreglo muldimensional de la probabilida de los climas
            // pos 0 para el primer día, pos 1 (sol) pos 2 (lluvia) pos 3 (nublado)
            double[][] probabilidades_clima =
            {
                new double[] { 0.333, 0.667, 1.0 },
                new double [] { 0.80, 0.90, 1.00 },
                new double[] { 0.40, 0.80, 1.00 },
                new double [] { 0.60, 0.70, 1.00 }
            };

            Random rnd = new();
            random_clima = Math.Truncate(rnd.NextDouble() * 10000) / 10000;

            num_clima_ayer = DeterminarClima(random_clima, num_clima_ayer, probabilidades_clima);

            // Iniciamos el reloj
            timeMeasure.Start();

            for (int i = 1; i < cantidad_iteraciones + 1; i++)
            {
                // Obtengo randoms para fertilizante (cada 10 días)
                if ((i - 1) % 10 == 0)
                {
                    random_fertilizante = Math.Truncate(rnd.NextDouble() * 10000) / 10000;
                    llegada_fertilizante = Math.Truncate(CanlcularLlegadaFertilizante(media, random_fertilizante) * 10000) / 10000;
                }

                // Obtengo el clima de hoy en base al día anterior
                random_clima = Math.Truncate(rnd.NextDouble() * 10000) / 10000;
                num_clima_hoy = DeterminarClima(random_clima, num_clima_ayer, probabilidades_clima);

                // Sumo contador de climas
                contador_climas[num_clima_hoy - 1]++;

                // Calculo probabilidad acumulada de climas
                acumulador_prob_climas[0] = Math.Truncate(((double)contador_climas[0] / i) * 10000) / 10000;
                acumulador_prob_climas[1] = Math.Truncate(((double)contador_climas[1] / i) * 10000) / 10000;
                acumulador_prob_climas[2] = Math.Truncate(((double)contador_climas[2] / i) * 10000) / 10000;

                produccion_hoy = Math.Truncate(((3350 + 250 * acumulador_prob_climas[0] + 390 * acumulador_prob_climas[1] - 150 * acumulador_prob_climas[2] - 600 * llegada_fertilizante) + produccion_ayer) * 10000) / 10000;

                if (i >= iteracion_desde && i <= iteracion_hasta || i == cantidad_iteraciones)
                {
                    string clima = ObtenerClima(num_clima_hoy);
                    resultado.Rows.Add(i.ToString("N",formato2), random_fertilizante, llegada_fertilizante,
                                                    random_clima, clima, contador_climas[0],
                                                    contador_climas[1], contador_climas[2],
                                                    acumulador_prob_climas[0],
                                                    acumulador_prob_climas[1],
                                                    acumulador_prob_climas[2],
                                                    produccion_hoy.ToString("N", formato));
                }

                num_clima_ayer = num_clima_hoy;
                contador_climas[0] = 0;
                contador_climas[1] = 0;
                contador_climas[2] = 0;
                produccion_ayer = produccion_hoy;
            }

            //Paramos el reloj
            timeMeasure.Stop();
            Debug.WriteLine($"Tiempo for: {timeMeasure.Elapsed.TotalSeconds} s");

            simulacion_desde_hasta = resultado;
            produccion_total = produccion_hoy;
            return true;
        }

        private static double CanlcularLlegadaFertilizante(double media, double random_fertilizante)
        {
            return Math.Truncate(-media * Math.Log(1 - random_fertilizante) * 10000) / 10000;
        }

        private static int DeterminarClima(double random_clima, int num_clima_ayer, double[][] probabilidades_clima)
        {
            if (random_clima < probabilidades_clima[num_clima_ayer][0]) return 1;
            if (random_clima < probabilidades_clima[num_clima_ayer][1]) return 2;
            return 3;
        }

        private static string ObtenerClima(int num_clima)
        {
            if (num_clima - 1 == 0) return "Sol";
            if (num_clima - 1 == 1) return "Lluvia";
            return "Nublado";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            dgv_resultados.DataSource = null;
            txt_cantidad_iteraciones.Clear();
            txt_desde.Clear();
            txt_hasta.Clear();
            txt_media.Clear();
            txt_toneladas_totales.Clear();
        }
    }
}
