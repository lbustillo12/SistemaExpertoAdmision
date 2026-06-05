namespace SistemaExpertoAdmision
{
    partial class Form1
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
            this.labeltitulo = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelmatematicas = new System.Windows.Forms.Label();
            this.labelpsicologia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMatematicas = new System.Windows.Forms.TextBox();
            this.txtPsicologia = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.dgvresultado = new System.Windows.Forms.DataGridView();
            this.Btnregistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresultado)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.Location = new System.Drawing.Point(387, 37);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(339, 31);
            this.labeltitulo.TabIndex = 1;
            this.labeltitulo.Text = "SISTEMA EXPERTO-ADMISIÓN";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.Location = new System.Drawing.Point(37, 107);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(67, 20);
            this.labelnombre.TabIndex = 2;
            this.labelnombre.Text = "Nombre:";
            // 
            // labelmatematicas
            // 
            this.labelmatematicas.AutoSize = true;
            this.labelmatematicas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmatematicas.Location = new System.Drawing.Point(37, 164);
            this.labelmatematicas.Name = "labelmatematicas";
            this.labelmatematicas.Size = new System.Drawing.Size(134, 20);
            this.labelmatematicas.TabIndex = 3;
            this.labelmatematicas.Text = "Nota Matemáticas:";
            // 
            // labelpsicologia
            // 
            this.labelpsicologia.AutoSize = true;
            this.labelpsicologia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpsicologia.Location = new System.Drawing.Point(37, 220);
            this.labelpsicologia.Name = "labelpsicologia";
            this.labelpsicologia.Size = new System.Drawing.Size(121, 20);
            this.labelpsicologia.TabIndex = 4;
            this.labelpsicologia.Text = "Nota Psicología :";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(182, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(267, 27);
            this.txtNombre.TabIndex = 5;
            // 
            // txtMatematicas
            // 
            this.txtMatematicas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatematicas.Location = new System.Drawing.Point(182, 157);
            this.txtMatematicas.Name = "txtMatematicas";
            this.txtMatematicas.Size = new System.Drawing.Size(267, 27);
            this.txtMatematicas.TabIndex = 6;
            // 
            // txtPsicologia
            // 
            this.txtPsicologia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPsicologia.Location = new System.Drawing.Point(182, 213);
            this.txtPsicologia.Name = "txtPsicologia";
            this.txtPsicologia.Size = new System.Drawing.Size(265, 27);
            this.txtPsicologia.TabIndex = 7;
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(37, 407);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(119, 20);
            this.lblConta.TabIndex = 8;
            this.lblConta.Text = "Aspirantes:  0/10";
            // 
            // dgvresultado
            // 
            this.dgvresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvresultado.Location = new System.Drawing.Point(498, 100);
            this.dgvresultado.Name = "dgvresultado";
            this.dgvresultado.RowHeadersWidth = 51;
            this.dgvresultado.RowTemplate.Height = 24;
            this.dgvresultado.Size = new System.Drawing.Size(576, 327);
            this.dgvresultado.TabIndex = 9;
            this.dgvresultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvresultado_CellContentClick);
            // 
            // Btnregistro
            // 
            this.Btnregistro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btnregistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnregistro.Image = global::SistemaExpertoAdmision.Properties.Resources.icono_guardar1;
            this.Btnregistro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnregistro.Location = new System.Drawing.Point(149, 269);
            this.Btnregistro.Name = "Btnregistro";
            this.Btnregistro.Padding = new System.Windows.Forms.Padding(5);
            this.Btnregistro.Size = new System.Drawing.Size(203, 49);
            this.Btnregistro.TabIndex = 0;
            this.Btnregistro.TabStop = false;
            this.Btnregistro.Text = "Registrar Aspirante";
            this.Btnregistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnregistro.UseVisualStyleBackColor = true;
            this.Btnregistro.Click += new System.EventHandler(this.Btnregistro_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1122, 476);
            this.Controls.Add(this.dgvresultado);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.txtPsicologia);
            this.Controls.Add(this.txtMatematicas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelpsicologia);
            this.Controls.Add(this.labelmatematicas);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.Btnregistro);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvresultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnregistro;
        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelmatematicas;
        private System.Windows.Forms.Label labelpsicologia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMatematicas;
        private System.Windows.Forms.TextBox txtPsicologia;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.DataGridView dgvresultado;
    }
}

