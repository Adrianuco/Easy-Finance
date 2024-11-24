namespace EasyFinance
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblSelect1 = new System.Windows.Forms.Label();
            this.cmbCategoría2 = new System.Windows.Forms.ComboBox();
            this.lblSelect2 = new System.Windows.Forms.Label();
            this.prgGasto1 = new System.Windows.Forms.ProgressBar();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblSelect3 = new System.Windows.Forms.Label();
            this.txtLimite1 = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegresar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcono
            // 
            this.picIcono.BackColor = System.Drawing.Color.Transparent;
            this.picIcono.Image = ((System.Drawing.Image)(resources.GetObject("picIcono.Image")));
            this.picIcono.Location = new System.Drawing.Point(335, 12);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(66, 61);
            this.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcono.TabIndex = 0;
            this.picIcono.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(407, 21);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(160, 43);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Navy;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(35, 84);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(84, 21);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Categorías";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Navy;
            this.lblDesc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(35, 105);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(734, 21);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Seleccione una categoría para su calculo de porcentaje de gasto y asigne un presu" +
    "puesto para los gastos.";
            // 
            // lblSelect1
            // 
            this.lblSelect1.AutoSize = true;
            this.lblSelect1.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect1.ForeColor = System.Drawing.Color.White;
            this.lblSelect1.Location = new System.Drawing.Point(234, 170);
            this.lblSelect1.Name = "lblSelect1";
            this.lblSelect1.Size = new System.Drawing.Size(154, 18);
            this.lblSelect1.TabIndex = 4;
            this.lblSelect1.Text = "Seleccione la Categoría:";
            // 
            // cmbCategoría2
            // 
            this.cmbCategoría2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoría2.FormattingEnabled = true;
            this.cmbCategoría2.Location = new System.Drawing.Point(431, 167);
            this.cmbCategoría2.Name = "cmbCategoría2";
            this.cmbCategoría2.Size = new System.Drawing.Size(237, 26);
            this.cmbCategoría2.TabIndex = 5;
            // 
            // lblSelect2
            // 
            this.lblSelect2.AutoSize = true;
            this.lblSelect2.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect2.ForeColor = System.Drawing.Color.White;
            this.lblSelect2.Location = new System.Drawing.Point(308, 278);
            this.lblSelect2.Name = "lblSelect2";
            this.lblSelect2.Size = new System.Drawing.Size(80, 18);
            this.lblSelect2.TabIndex = 6;
            this.lblSelect2.Text = "Categoría 1:";
            // 
            // prgGasto1
            // 
            this.prgGasto1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.prgGasto1.Location = new System.Drawing.Point(431, 273);
            this.prgGasto1.Name = "prgGasto1";
            this.prgGasto1.Size = new System.Drawing.Size(170, 23);
            this.prgGasto1.TabIndex = 7;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentaje.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.White;
            this.lblPorcentaje.Location = new System.Drawing.Point(607, 273);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(40, 21);
            this.lblPorcentaje.TabIndex = 8;
            this.lblPorcentaje.Text = "87%";
            // 
            // lblSelect3
            // 
            this.lblSelect3.AutoSize = true;
            this.lblSelect3.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect3.ForeColor = System.Drawing.Color.White;
            this.lblSelect3.Location = new System.Drawing.Point(206, 375);
            this.lblSelect3.Name = "lblSelect3";
            this.lblSelect3.Size = new System.Drawing.Size(182, 18);
            this.lblSelect3.TabIndex = 9;
            this.lblSelect3.Text = "Limite de Gasto Establecido:";
            // 
            // txtLimite1
            // 
            this.txtLimite1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimite1.Location = new System.Drawing.Point(431, 372);
            this.txtLimite1.Name = "txtLimite1";
            this.txtLimite1.Size = new System.Drawing.Size(170, 26);
            this.txtLimite1.TabIndex = 10;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(237, 495);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(196, 46);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar Limite de Gasto";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegresar2
            // 
            this.btnRegresar2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar2.Location = new System.Drawing.Point(459, 495);
            this.btnRegresar2.Name = "btnRegresar2";
            this.btnRegresar2.Size = new System.Drawing.Size(196, 46);
            this.btnRegresar2.TabIndex = 12;
            this.btnRegresar2.Text = "Regresar al Menu";
            this.btnRegresar2.UseVisualStyleBackColor = true;
            this.btnRegresar2.Click += new System.EventHandler(this.btnRegresar2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 553);
            this.Controls.Add(this.btnRegresar2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtLimite1);
            this.Controls.Add(this.lblSelect3);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.prgGasto1);
            this.Controls.Add(this.lblSelect2);
            this.Controls.Add(this.cmbCategoría2);
            this.Controls.Add(this.lblSelect1);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picIcono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyFinance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegresarMenu2);
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcono;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblSelect1;
        private System.Windows.Forms.ComboBox cmbCategoría2;
        private System.Windows.Forms.Label lblSelect2;
        private System.Windows.Forms.ProgressBar prgGasto1;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblSelect3;
        private System.Windows.Forms.TextBox txtLimite1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegresar2;
    }
}