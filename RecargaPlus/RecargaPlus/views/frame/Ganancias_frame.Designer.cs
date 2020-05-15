namespace RecargaPlus.src.views.frame
{
    partial class Ganancias_frame
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaGanancias = new System.Windows.Forms.DataGridView();
            this.graficaGanancias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGanancias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficaGanancias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ganancias";
            // 
            // tablaGanancias
            // 
            this.tablaGanancias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(124)))), ((int)(((byte)(45)))));
            this.tablaGanancias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaGanancias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.tablaGanancias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(111)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaGanancias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaGanancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaGanancias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablaGanancias.EnableHeadersVisualStyles = false;
            this.tablaGanancias.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaGanancias.Location = new System.Drawing.Point(0, 253);
            this.tablaGanancias.Name = "tablaGanancias";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(150)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaGanancias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(150)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.tablaGanancias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaGanancias.Size = new System.Drawing.Size(646, 244);
            this.tablaGanancias.TabIndex = 16;
            // 
            // graficaGanancias
            // 
            this.graficaGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(202)))), ((int)(((byte)(133)))));
            this.graficaGanancias.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent20;
            chartArea1.Name = "ChartArea1";
            this.graficaGanancias.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficaGanancias.Legends.Add(legend1);
            this.graficaGanancias.Location = new System.Drawing.Point(7, 52);
            this.graficaGanancias.Name = "graficaGanancias";
            this.graficaGanancias.Size = new System.Drawing.Size(636, 179);
            this.graficaGanancias.TabIndex = 17;
            this.graficaGanancias.Text = "chart1";
            // 
            // Ganancias_frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.graficaGanancias);
            this.Controls.Add(this.tablaGanancias);
            this.Controls.Add(this.label1);
            this.Name = "Ganancias_frame";
            this.Size = new System.Drawing.Size(646, 497);
            ((System.ComponentModel.ISupportInitialize)(this.tablaGanancias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficaGanancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaGanancias;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficaGanancias;
    }
}
