namespace RecargaPlus.src.views.frame
{
    partial class Recargas_frame
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_compania = new System.Windows.Forms.ComboBox();
            this.cb_monto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.btn_realizarRecarga = new System.Windows.Forms.Button();
            this.tablaRecargas = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recargaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRecargas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recargaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Realiza una recarga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Compañia:";
            // 
            // cb_compania
            // 
            this.cb_compania.FormattingEnabled = true;
            this.cb_compania.Location = new System.Drawing.Point(168, 80);
            this.cb_compania.Name = "cb_compania";
            this.cb_compania.Size = new System.Drawing.Size(121, 21);
            this.cb_compania.TabIndex = 10;
            // 
            // cb_monto
            // 
            this.cb_monto.FormattingEnabled = true;
            this.cb_monto.Location = new System.Drawing.Point(168, 124);
            this.cb_monto.Name = "cb_monto";
            this.cb_monto.Size = new System.Drawing.Size(121, 21);
            this.cb_monto.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Número:";
            // 
            // txt_numero
            // 
            this.txt_numero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_numero.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.txt_numero.Location = new System.Drawing.Point(168, 172);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(212, 17);
            this.txt_numero.TabIndex = 12;
            // 
            // btn_realizarRecarga
            // 
            this.btn_realizarRecarga.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(216)))), ((int)(((byte)(124)))));
            this.btn_realizarRecarga.FlatAppearance.BorderSize = 3;
            this.btn_realizarRecarga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(178)))), ((int)(((byte)(75)))));
            this.btn_realizarRecarga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(214)))), ((int)(((byte)(122)))));
            this.btn_realizarRecarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_realizarRecarga.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.btn_realizarRecarga.ForeColor = System.Drawing.Color.White;
            this.btn_realizarRecarga.Location = new System.Drawing.Point(418, 165);
            this.btn_realizarRecarga.Name = "btn_realizarRecarga";
            this.btn_realizarRecarga.Size = new System.Drawing.Size(184, 30);
            this.btn_realizarRecarga.TabIndex = 14;
            this.btn_realizarRecarga.Text = "Realizar recarga";
            this.btn_realizarRecarga.UseVisualStyleBackColor = true;
            this.btn_realizarRecarga.Click += new System.EventHandler(this.btn_realizarRecarga_Click);
            // 
            // tablaRecargas
            // 
            this.tablaRecargas.AutoGenerateColumns = false;
            this.tablaRecargas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(124)))), ((int)(((byte)(45)))));
            this.tablaRecargas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaRecargas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.tablaRecargas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(111)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaRecargas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaRecargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRecargas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.companiaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.bonificacionDataGridViewTextBoxColumn});
            this.tablaRecargas.DataSource = this.recargaBindingSource;
            this.tablaRecargas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablaRecargas.EnableHeadersVisualStyles = false;
            this.tablaRecargas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaRecargas.Location = new System.Drawing.Point(0, 253);
            this.tablaRecargas.Name = "tablaRecargas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(150)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaRecargas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(150)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.tablaRecargas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaRecargas.Size = new System.Drawing.Size(646, 244);
            this.tablaRecargas.TabIndex = 15;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // companiaDataGridViewTextBoxColumn
            // 
            this.companiaDataGridViewTextBoxColumn.DataPropertyName = "Compania";
            this.companiaDataGridViewTextBoxColumn.HeaderText = "Compania";
            this.companiaDataGridViewTextBoxColumn.Name = "companiaDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // bonificacionDataGridViewTextBoxColumn
            // 
            this.bonificacionDataGridViewTextBoxColumn.DataPropertyName = "Bonificacion";
            this.bonificacionDataGridViewTextBoxColumn.HeaderText = "Bonificacion";
            this.bonificacionDataGridViewTextBoxColumn.Name = "bonificacionDataGridViewTextBoxColumn";
            // 
            // recargaBindingSource
            // 
            this.recargaBindingSource.DataSource = typeof(Controller.objects.Recarga);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Recargas";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_saldo.ForeColor = System.Drawing.Color.White;
            this.lbl_saldo.Location = new System.Drawing.Point(385, 37);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(104, 24);
            this.lbl_saldo.TabIndex = 17;
            this.lbl_saldo.Text = "Saldo: $";
            // 
            // Recargas_frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tablaRecargas);
            this.Controls.Add(this.btn_realizarRecarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.cb_monto);
            this.Controls.Add(this.cb_compania);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Recargas_frame";
            this.Size = new System.Drawing.Size(646, 497);
            ((System.ComponentModel.ISupportInitialize)(this.tablaRecargas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recargaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_compania;
        private System.Windows.Forms.ComboBox cb_monto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button btn_realizarRecarga;
        private System.Windows.Forms.DataGridView tablaRecargas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recargaBindingSource;
        private System.Windows.Forms.Label lbl_saldo;
    }
}
