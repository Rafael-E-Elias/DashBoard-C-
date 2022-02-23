namespace DashBoard
{
    partial class DashBoard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.EmpresasxDocumentos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasxDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpresasxDocumentos
            // 
            chartArea2.Name = "ChartArea1";
            this.EmpresasxDocumentos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.EmpresasxDocumentos.Legends.Add(legend2);
            this.EmpresasxDocumentos.Location = new System.Drawing.Point(432, 85);
            this.EmpresasxDocumentos.Name = "EmpresasxDocumentos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.EmpresasxDocumentos.Series.Add(series2);
            this.EmpresasxDocumentos.Size = new System.Drawing.Size(300, 300);
            this.EmpresasxDocumentos.TabIndex = 0;
            this.EmpresasxDocumentos.Text = "chart1";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.EmpresasxDocumentos);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasxDocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart EmpresasxDocumentos;
    }
}

