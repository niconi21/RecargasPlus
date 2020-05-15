namespace RecargaPlus.src.views.frame
{
    partial class Bonificaciones_frame
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
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_monto = new System.Windows.Forms.ComboBox();
            this.cb_compania = new System.Windows.Forms.ComboBox();
            this.txt_bonificacion = new System.Windows.Forms.TextBox();
            this.tabla_bonificaciones = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.bonificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonificacoinesadministradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_bonificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonificacoinesadministradorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(216)))), ((int)(((byte)(124)))));
            this.btn_actualizar.FlatAppearance.BorderSize = 3;
            this.btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(178)))), ((int)(((byte)(75)))));
            this.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(214)))), ((int)(((byte)(122)))));
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_actualizar.Location = new System.Drawing.Point(322, 174);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(142, 30);
            this.btn_actualizar.TabIndex = 34;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(216)))), ((int)(((byte)(124)))));
            this.btn_registrar.FlatAppearance.BorderSize = 3;
            this.btn_registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(178)))), ((int)(((byte)(75)))));
            this.btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(214)))), ((int)(((byte)(122)))));
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(144, 174);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(152, 30);
            this.btn_registrar.TabIndex = 33;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Bonificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Compañia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Monto:";
            // 
            // cb_monto
            // 
            this.cb_monto.FormattingEnabled = true;
            this.cb_monto.Location = new System.Drawing.Point(235, 39);
            this.cb_monto.Name = "cb_monto";
            this.cb_monto.Size = new System.Drawing.Size(140, 21);
            this.cb_monto.TabIndex = 35;
            // 
            // cb_compania
            // 
            this.cb_compania.FormattingEnabled = true;
            this.cb_compania.Location = new System.Drawing.Point(235, 80);
            this.cb_compania.Name = "cb_compania";
            this.cb_compania.Size = new System.Drawing.Size(140, 21);
            this.cb_compania.TabIndex = 36;
            // 
            // txt_bonificacion
            // 
            this.txt_bonificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bonificacion.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.txt_bonificacion.Location = new System.Drawing.Point(235, 123);
            this.txt_bonificacion.Name = "txt_bonificacion";
            this.txt_bonificacion.Size = new System.Drawing.Size(212, 17);
            this.txt_bonificacion.TabIndex = 37;
            // 
            // tabla_bonificaciones
            // 
            this.tabla_bonificaciones.AutoGenerateColumns = false;
            this.tabla_bonificaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(124)))), ((int)(((byte)(45)))));
            this.tabla_bonificaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_bonificaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.tabla_bonificaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(111)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_bonificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_bonificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_bonificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bonificacionDataGridViewTextBoxColumn,
            this.companiaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn});
            this.tabla_bonificaciones.DataSource = this.bonificacoinesadministradorBindingSource;
            this.tabla_bonificaciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabla_bonificaciones.EnableHeadersVisualStyles = false;
            this.tabla_bonificaciones.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabla_bonificaciones.Location = new System.Drawing.Point(0, 253);
            this.tabla_bonificaciones.Name = "tabla_bonificaciones";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(150)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_bonificaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(150)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.tabla_bonificaciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tabla_bonificaciones.Size = new System.Drawing.Size(646, 244);
            this.tabla_bonificaciones.TabIndex = 38;
            this.tabla_bonificaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_bonificaciones_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 24);
            this.label7.TabIndex = 39;
            this.label7.Text = "Bonificaciones";
            // 
            // bonificacionDataGridViewTextBoxColumn
            // 
            this.bonificacionDataGridViewTextBoxColumn.DataPropertyName = "bonificacion";
            this.bonificacionDataGridViewTextBoxColumn.HeaderText = "bonificacion";
            this.bonificacionDataGridViewTextBoxColumn.Name = "bonificacionDataGridViewTextBoxColumn";
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
            // bonificacoinesadministradorBindingSource
            // 
            this.bonificacoinesadministradorBindingSource.DataSource = typeof(RecargaPlus.Moldes.Bonificacoines_administrador);
            // 
            // Bonificaciones_frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabla_bonificaciones);
            this.Controls.Add(this.txt_bonificacion);
            this.Controls.Add(this.cb_compania);
            this.Controls.Add(this.cb_monto);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Bonificaciones_frame";
            this.Size = new System.Drawing.Size(646, 497);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_bonificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonificacoinesadministradorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_monto;
        private System.Windows.Forms.ComboBox cb_compania;
        private System.Windows.Forms.TextBox txt_bonificacion;
        private System.Windows.Forms.DataGridView tabla_bonificaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bonificacoinesadministradorBindingSource;
    }
}
