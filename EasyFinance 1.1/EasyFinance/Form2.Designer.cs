namespace EasyFinance
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDesc1 = new System.Windows.Forms.Label();
            this.lblDesc2 = new System.Windows.Forms.Label();
            this.lblSelect1 = new System.Windows.Forms.Label();
            this.lblSelect2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSelect3 = new System.Windows.Forms.Label();
            this.radGastos = new System.Windows.Forms.RadioButton();
            this.radIngresos = new System.Windows.Forms.RadioButton();
            this.lblSelect4 = new System.Windows.Forms.Label();
            this.cmbCategoría1 = new System.Windows.Forms.ComboBox();
            this.lblSelect5 = new System.Windows.Forms.Label();
            this.lblSelect6 = new System.Windows.Forms.Label();
            this.txtTransacción1 = new System.Windows.Forms.TextBox();
            this.txtMonto1 = new System.Windows.Forms.TextBox();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.btnRegresar1 = new System.Windows.Forms.Button();
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
            this.lblTitulo.Size = new System.Drawing.Size(136, 21);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Registro de Datos";
            // 
            // lblDesc1
            // 
            this.lblDesc1.AutoSize = true;
            this.lblDesc1.BackColor = System.Drawing.Color.Navy;
            this.lblDesc1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc1.ForeColor = System.Drawing.Color.White;
            this.lblDesc1.Location = new System.Drawing.Point(35, 105);
            this.lblDesc1.Name = "lblDesc1";
            this.lblDesc1.Size = new System.Drawing.Size(753, 21);
            this.lblDesc1.TabIndex = 3;
            this.lblDesc1.Text = "Digite todos los ingresos y gastos que realizo en una fecha determinada para que " +
    "estos sea guardados en la";
            // 
            // lblDesc2
            // 
            this.lblDesc2.AutoSize = true;
            this.lblDesc2.BackColor = System.Drawing.Color.Navy;
            this.lblDesc2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc2.ForeColor = System.Drawing.Color.White;
            this.lblDesc2.Location = new System.Drawing.Point(35, 126);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(83, 21);
            this.lblDesc2.TabIndex = 4;
            this.lblDesc2.Text = "aplicación.";
            // 
            // lblSelect1
            // 
            this.lblSelect1.AutoSize = true;
            this.lblSelect1.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect1.ForeColor = System.Drawing.Color.White;
            this.lblSelect1.Location = new System.Drawing.Point(97, 168);
            this.lblSelect1.Name = "lblSelect1";
            this.lblSelect1.Size = new System.Drawing.Size(254, 18);
            this.lblSelect1.TabIndex = 5;
            this.lblSelect1.Text = "Seleccione la fecha en que se realizaron";
            // 
            // lblSelect2
            // 
            this.lblSelect2.AutoSize = true;
            this.lblSelect2.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect2.ForeColor = System.Drawing.Color.White;
            this.lblSelect2.Location = new System.Drawing.Point(234, 186);
            this.lblSelect2.Name = "lblSelect2";
            this.lblSelect2.Size = new System.Drawing.Size(138, 18);
            this.lblSelect2.TabIndex = 6;
            this.lblSelect2.Text = "los gastos o ingresos:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(431, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(303, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblSelect3
            // 
            this.lblSelect3.AutoSize = true;
            this.lblSelect3.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect3.ForeColor = System.Drawing.Color.White;
            this.lblSelect3.Location = new System.Drawing.Point(235, 245);
            this.lblSelect3.Name = "lblSelect3";
            this.lblSelect3.Size = new System.Drawing.Size(137, 18);
            this.lblSelect3.TabIndex = 8;
            this.lblSelect3.Text = "Cuál desea registrar?";
            // 
            // radGastos
            // 
            this.radGastos.AutoSize = true;
            this.radGastos.BackColor = System.Drawing.Color.Transparent;
            this.radGastos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGastos.ForeColor = System.Drawing.Color.White;
            this.radGastos.Location = new System.Drawing.Point(431, 241);
            this.radGastos.Name = "radGastos";
            this.radGastos.Size = new System.Drawing.Size(79, 25);
            this.radGastos.TabIndex = 9;
            this.radGastos.TabStop = true;
            this.radGastos.Text = "Gastos";
            this.radGastos.UseVisualStyleBackColor = false;
            // 
            // radIngresos
            // 
            this.radIngresos.AutoSize = true;
            this.radIngresos.BackColor = System.Drawing.Color.Transparent;
            this.radIngresos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIngresos.ForeColor = System.Drawing.Color.White;
            this.radIngresos.Location = new System.Drawing.Point(536, 241);
            this.radIngresos.Name = "radIngresos";
            this.radIngresos.Size = new System.Drawing.Size(91, 25);
            this.radIngresos.TabIndex = 10;
            this.radIngresos.TabStop = true;
            this.radIngresos.Text = "Ingresos";
            this.radIngresos.UseVisualStyleBackColor = false;
            // 
            // lblSelect4
            // 
            this.lblSelect4.AutoSize = true;
            this.lblSelect4.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect4.ForeColor = System.Drawing.Color.White;
            this.lblSelect4.Location = new System.Drawing.Point(218, 306);
            this.lblSelect4.Name = "lblSelect4";
            this.lblSelect4.Size = new System.Drawing.Size(154, 18);
            this.lblSelect4.TabIndex = 11;
            this.lblSelect4.Text = "Seleccione la Categoría:";
            // 
            // cmbCategoría1
            // 
            this.cmbCategoría1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoría1.FormattingEnabled = true;
            this.cmbCategoría1.Location = new System.Drawing.Point(431, 303);
            this.cmbCategoría1.Name = "cmbCategoría1";
            this.cmbCategoría1.Size = new System.Drawing.Size(254, 26);
            this.cmbCategoría1.TabIndex = 12;
            // 
            // lblSelect5
            // 
            this.lblSelect5.AutoSize = true;
            this.lblSelect5.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect5.ForeColor = System.Drawing.Color.White;
            this.lblSelect5.Location = new System.Drawing.Point(216, 365);
            this.lblSelect5.Name = "lblSelect5";
            this.lblSelect5.Size = new System.Drawing.Size(156, 18);
            this.lblSelect5.TabIndex = 13;
            this.lblSelect5.Text = "Nombre de Transacción:";
            // 
            // lblSelect6
            // 
            this.lblSelect6.AutoSize = true;
            this.lblSelect6.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect6.ForeColor = System.Drawing.Color.White;
            this.lblSelect6.Location = new System.Drawing.Point(533, 365);
            this.lblSelect6.Name = "lblSelect6";
            this.lblSelect6.Size = new System.Drawing.Size(53, 18);
            this.lblSelect6.TabIndex = 14;
            this.lblSelect6.Text = "Monto:";
            // 
            // txtTransacción1
            // 
            this.txtTransacción1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransacción1.Location = new System.Drawing.Point(185, 386);
            this.txtTransacción1.Name = "txtTransacción1";
            this.txtTransacción1.Size = new System.Drawing.Size(233, 26);
            this.txtTransacción1.TabIndex = 15;
            // 
            // txtMonto1
            // 
            this.txtMonto1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto1.Location = new System.Drawing.Point(470, 386);
            this.txtMonto1.Name = "txtMonto1";
            this.txtMonto1.Size = new System.Drawing.Size(185, 26);
            this.txtMonto1.TabIndex = 16;
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar1.Location = new System.Drawing.Point(237, 487);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(196, 46);
            this.btnGuardar1.TabIndex = 17;
            this.btnGuardar1.Text = "Guardar Datos";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            // 
            // btnRegresar1
            // 
            this.btnRegresar1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar1.Location = new System.Drawing.Point(459, 487);
            this.btnRegresar1.Name = "btnRegresar1";
            this.btnRegresar1.Size = new System.Drawing.Size(196, 46);
            this.btnRegresar1.TabIndex = 18;
            this.btnRegresar1.Text = "Regresar al Menu";
            this.btnRegresar1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 553);
            this.Controls.Add(this.btnRegresar1);
            this.Controls.Add(this.btnGuardar1);
            this.Controls.Add(this.txtMonto1);
            this.Controls.Add(this.txtTransacción1);
            this.Controls.Add(this.lblSelect6);
            this.Controls.Add(this.lblSelect5);
            this.Controls.Add(this.cmbCategoría1);
            this.Controls.Add(this.lblSelect4);
            this.Controls.Add(this.radIngresos);
            this.Controls.Add(this.radGastos);
            this.Controls.Add(this.lblSelect3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSelect2);
            this.Controls.Add(this.lblSelect1);
            this.Controls.Add(this.lblDesc2);
            this.Controls.Add(this.lblDesc1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picIcono);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "EasyFinance";
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcono;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDesc1;
        private System.Windows.Forms.Label lblDesc2;
        private System.Windows.Forms.Label lblSelect1;
        private System.Windows.Forms.Label lblSelect2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSelect3;
        private System.Windows.Forms.RadioButton radGastos;
        private System.Windows.Forms.RadioButton radIngresos;
        private System.Windows.Forms.Label lblSelect4;
        private System.Windows.Forms.ComboBox cmbCategoría1;
        private System.Windows.Forms.Label lblSelect5;
        private System.Windows.Forms.Label lblSelect6;
        private System.Windows.Forms.TextBox txtTransacción1;
        private System.Windows.Forms.TextBox txtMonto1;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.Button btnRegresar1;
    }
}