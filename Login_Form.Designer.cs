namespace Prueba1
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Usr = new System.Windows.Forms.Label();
            this.Txt_Usr = new System.Windows.Forms.TextBox();
            this.Lbl_Pass = new System.Windows.Forms.Label();
            this.Txt_Pass = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Ini_Sesion = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Gbox_descripción = new System.Windows.Forms.GroupBox();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Gbox_descripción.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prueba1.Properties.Resources.Logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_Usr
            // 
            this.Lbl_Usr.AutoSize = true;
            this.Lbl_Usr.Location = new System.Drawing.Point(49, 171);
            this.Lbl_Usr.Name = "Lbl_Usr";
            this.Lbl_Usr.Size = new System.Drawing.Size(83, 13);
            this.Lbl_Usr.TabIndex = 1;
            this.Lbl_Usr.Text = "Nombre Usuario";
            // 
            // Txt_Usr
            // 
            this.Txt_Usr.Location = new System.Drawing.Point(52, 187);
            this.Txt_Usr.Name = "Txt_Usr";
            this.Txt_Usr.Size = new System.Drawing.Size(171, 20);
            this.Txt_Usr.TabIndex = 2;
            // 
            // Lbl_Pass
            // 
            this.Lbl_Pass.AutoSize = true;
            this.Lbl_Pass.Location = new System.Drawing.Point(52, 214);
            this.Lbl_Pass.Name = "Lbl_Pass";
            this.Lbl_Pass.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Pass.TabIndex = 3;
            this.Lbl_Pass.Text = "Contraseña";
            // 
            // Txt_Pass
            // 
            this.Txt_Pass.Location = new System.Drawing.Point(52, 231);
            this.Txt_Pass.Name = "Txt_Pass";
            this.Txt_Pass.PasswordChar = '*';
            this.Txt_Pass.Size = new System.Drawing.Size(171, 20);
            this.Txt_Pass.TabIndex = 4;
            // 
            // Btn_Ini_Sesion
            // 
            this.Btn_Ini_Sesion.Location = new System.Drawing.Point(55, 270);
            this.Btn_Ini_Sesion.Name = "Btn_Ini_Sesion";
            this.Btn_Ini_Sesion.Size = new System.Drawing.Size(86, 23);
            this.Btn_Ini_Sesion.TabIndex = 5;
            this.Btn_Ini_Sesion.Text = "Iniciar Sesión";
            this.Btn_Ini_Sesion.UseVisualStyleBackColor = true;
            this.Btn_Ini_Sesion.Click += new System.EventHandler(this.Btn_Ini_Sesion_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(148, 269);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cerrar.TabIndex = 6;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(300, 28);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(313, 42);
            this.Lbl_Titulo.TabIndex = 7;
            this.Lbl_Titulo.Text = "WGP Kickboxing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(334, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Desarrollamos tu capacidad";
            // 
            // Gbox_descripción
            // 
            this.Gbox_descripción.Controls.Add(this.Lbl_Descripcion);
            this.Gbox_descripción.Location = new System.Drawing.Point(307, 171);
            this.Gbox_descripción.Name = "Gbox_descripción";
            this.Gbox_descripción.Size = new System.Drawing.Size(316, 121);
            this.Gbox_descripción.TabIndex = 9;
            this.Gbox_descripción.TabStop = false;
            this.Gbox_descripción.Text = "Descripción";
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descripcion.Location = new System.Drawing.Point(7, 20);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(298, 72);
            this.Lbl_Descripcion.TabIndex = 0;
            this.Lbl_Descripcion.Text = "Bienvenido a Kickboxing app donde podrá\r\nacceder y gestionar según su categoria v" +
    "a a\r\ntener acceso a diversas opciones que usted\r\nle permitirán mejorar su rendim" +
    "iento fisico";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 319);
            this.Controls.Add(this.Gbox_descripción);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_Ini_Sesion);
            this.Controls.Add(this.Txt_Pass);
            this.Controls.Add(this.Lbl_Pass);
            this.Controls.Add(this.Txt_Usr);
            this.Controls.Add(this.Lbl_Usr);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Gbox_descripción.ResumeLayout(false);
            this.Gbox_descripción.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Usr;
        private System.Windows.Forms.TextBox Txt_Usr;
        private System.Windows.Forms.Label Lbl_Pass;
        private System.Windows.Forms.MaskedTextBox Txt_Pass;
        private System.Windows.Forms.Button Btn_Ini_Sesion;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gbox_descripción;
        private System.Windows.Forms.Label Lbl_Descripcion;
    }
}

