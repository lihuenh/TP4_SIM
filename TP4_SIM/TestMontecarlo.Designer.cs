
namespace TP4_SIM_vLihuen
{
    partial class TestMontecarlo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_parametros = new System.Windows.Forms.GroupBox();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.btn_generar_simulacion = new System.Windows.Forms.Button();
            this.txt_media = new System.Windows.Forms.TextBox();
            this.lbl_media = new System.Windows.Forms.Label();
            this.txt_cantidad_iteraciones = new System.Windows.Forms.TextBox();
            this.lbl_cantidad_iteraciones = new System.Windows.Forms.Label();
            this.grp_datos = new System.Windows.Forms.GroupBox();
            this.dgv_resultados = new System.Windows.Forms.DataGridView();
            this.grp_resultados = new System.Windows.Forms.GroupBox();
            this.txt_toneladas_totales = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.grp_parametros.SuspendLayout();
            this.grp_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultados)).BeginInit();
            this.grp_resultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_parametros
            // 
            this.grp_parametros.Controls.Add(this.lbl_desde);
            this.grp_parametros.Controls.Add(this.lbl_hasta);
            this.grp_parametros.Controls.Add(this.btn_limpiar);
            this.grp_parametros.Controls.Add(this.txt_desde);
            this.grp_parametros.Controls.Add(this.txt_hasta);
            this.grp_parametros.Controls.Add(this.btn_generar_simulacion);
            this.grp_parametros.Controls.Add(this.txt_media);
            this.grp_parametros.Controls.Add(this.lbl_media);
            this.grp_parametros.Controls.Add(this.txt_cantidad_iteraciones);
            this.grp_parametros.Controls.Add(this.lbl_cantidad_iteraciones);
            this.grp_parametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grp_parametros.Location = new System.Drawing.Point(12, 12);
            this.grp_parametros.Name = "grp_parametros";
            this.grp_parametros.Size = new System.Drawing.Size(1121, 109);
            this.grp_parametros.TabIndex = 0;
            this.grp_parametros.TabStop = false;
            this.grp_parametros.Text = "Parámetros";
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Location = new System.Drawing.Point(109, 75);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(56, 20);
            this.lbl_desde.TabIndex = 2;
            this.lbl_desde.Text = "Desde";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Location = new System.Drawing.Point(399, 72);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(52, 20);
            this.lbl_hasta.TabIndex = 4;
            this.lbl_hasta.Text = "Hasta";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(911, 25);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(193, 72);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(171, 69);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(200, 26);
            this.txt_desde.TabIndex = 3;
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(457, 69);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(200, 26);
            this.txt_hasta.TabIndex = 4;
            // 
            // btn_generar_simulacion
            // 
            this.btn_generar_simulacion.Location = new System.Drawing.Point(694, 25);
            this.btn_generar_simulacion.Name = "btn_generar_simulacion";
            this.btn_generar_simulacion.Size = new System.Drawing.Size(189, 72);
            this.btn_generar_simulacion.TabIndex = 5;
            this.btn_generar_simulacion.Text = "Generar Simulación";
            this.btn_generar_simulacion.UseVisualStyleBackColor = true;
            this.btn_generar_simulacion.Click += new System.EventHandler(this.btn_generar_simulacion_Click);
            // 
            // txt_media
            // 
            this.txt_media.Location = new System.Drawing.Point(457, 28);
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(200, 26);
            this.txt_media.TabIndex = 2;
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Location = new System.Drawing.Point(399, 31);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(52, 20);
            this.lbl_media.TabIndex = 6;
            this.lbl_media.Text = "Media";
            // 
            // txt_cantidad_iteraciones
            // 
            this.txt_cantidad_iteraciones.Location = new System.Drawing.Point(171, 28);
            this.txt_cantidad_iteraciones.Name = "txt_cantidad_iteraciones";
            this.txt_cantidad_iteraciones.Size = new System.Drawing.Size(200, 26);
            this.txt_cantidad_iteraciones.TabIndex = 1;
            // 
            // lbl_cantidad_iteraciones
            // 
            this.lbl_cantidad_iteraciones.AutoSize = true;
            this.lbl_cantidad_iteraciones.Location = new System.Drawing.Point(14, 31);
            this.lbl_cantidad_iteraciones.Name = "lbl_cantidad_iteraciones";
            this.lbl_cantidad_iteraciones.Size = new System.Drawing.Size(156, 20);
            this.lbl_cantidad_iteraciones.TabIndex = 0;
            this.lbl_cantidad_iteraciones.Text = "Cantidad Iteraciones";
            // 
            // grp_datos
            // 
            this.grp_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_datos.AutoSize = true;
            this.grp_datos.Controls.Add(this.dgv_resultados);
            this.grp_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grp_datos.Location = new System.Drawing.Point(12, 127);
            this.grp_datos.Name = "grp_datos";
            this.grp_datos.Size = new System.Drawing.Size(1121, 431);
            this.grp_datos.TabIndex = 1;
            this.grp_datos.TabStop = false;
            this.grp_datos.Text = "Resultados iteración desde - hasta";
            // 
            // dgv_resultados
            // 
            this.dgv_resultados.AllowUserToAddRows = false;
            this.dgv_resultados.AllowUserToDeleteRows = false;
            this.dgv_resultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_resultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_resultados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_resultados.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgv_resultados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultados.Location = new System.Drawing.Point(18, 25);
            this.dgv_resultados.Name = "dgv_resultados";
            this.dgv_resultados.ReadOnly = true;
            this.dgv_resultados.RowHeadersWidth = 30;
            this.dgv_resultados.RowTemplate.Height = 25;
            this.dgv_resultados.Size = new System.Drawing.Size(1086, 388);
            this.dgv_resultados.TabIndex = 0;
            // 
            // grp_resultados
            // 
            this.grp_resultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_resultados.AutoSize = true;
            this.grp_resultados.Controls.Add(this.txt_toneladas_totales);
            this.grp_resultados.Controls.Add(this.lbl_resultado);
            this.grp_resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grp_resultados.Location = new System.Drawing.Point(12, 564);
            this.grp_resultados.Name = "grp_resultados";
            this.grp_resultados.Size = new System.Drawing.Size(1121, 89);
            this.grp_resultados.TabIndex = 2;
            this.grp_resultados.TabStop = false;
            this.grp_resultados.Text = "Resultados";
            // 
            // txt_toneladas_totales
            // 
            this.txt_toneladas_totales.Enabled = false;
            this.txt_toneladas_totales.Location = new System.Drawing.Point(377, 38);
            this.txt_toneladas_totales.Name = "txt_toneladas_totales";
            this.txt_toneladas_totales.Size = new System.Drawing.Size(466, 26);
            this.txt_toneladas_totales.TabIndex = 1;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(232, 44);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(139, 20);
            this.lbl_resultado.TabIndex = 0;
            this.lbl_resultado.Text = "Toneladas Totales";
            // 
            // TestMontecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 663);
            this.Controls.Add(this.grp_resultados);
            this.Controls.Add(this.grp_datos);
            this.Controls.Add(this.grp_parametros);
            this.Name = "TestMontecarlo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP4 - Simulación de Montecarlo";
            this.grp_parametros.ResumeLayout(false);
            this.grp_parametros.PerformLayout();
            this.grp_datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultados)).EndInit();
            this.grp_resultados.ResumeLayout(false);
            this.grp_resultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_parametros;
        private System.Windows.Forms.Label lbl_cantidad_iteraciones;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.GroupBox grp_datos;
        private System.Windows.Forms.GroupBox grp_resultados;
        private System.Windows.Forms.TextBox txt_media;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.Button btn_generar_simulacion;
        private System.Windows.Forms.DataGridView dgv_resultados;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox txt_toneladas_totales;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.TextBox txt_cantidad_iteraciones;
    }
}

