namespace Prueba1.GUI
{
    partial class Home_Form
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
            this.Lbl_Saludo = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Cbox_Cliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbox_Categoria = new System.Windows.Forms.ComboBox();
            this.Btn_Entrar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_admin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Saludo
            // 
            this.Lbl_Saludo.AutoSize = true;
            this.Lbl_Saludo.Location = new System.Drawing.Point(51, 193);
            this.Lbl_Saludo.Name = "Lbl_Saludo";
            this.Lbl_Saludo.Size = new System.Drawing.Size(63, 13);
            this.Lbl_Saludo.TabIndex = 1;
            this.Lbl_Saludo.Text = "Bienvenido:";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(331, 50);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(100, 13);
            this.Lbl_Nombre.TabIndex = 3;
            this.Lbl_Nombre.Text = "Seleccione Nombre";
            // 
            // Cbox_Cliente
            // 
            this.Cbox_Cliente.FormattingEnabled = true;
            this.Cbox_Cliente.Location = new System.Drawing.Point(334, 66);
            this.Cbox_Cliente.Name = "Cbox_Cliente";
            this.Cbox_Cliente.Size = new System.Drawing.Size(190, 21);
            this.Cbox_Cliente.TabIndex = 4;
            this.Cbox_Cliente.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione Categoria";
            // 
            // Cbox_Categoria
            // 
            this.Cbox_Categoria.FormattingEnabled = true;
            this.Cbox_Categoria.Location = new System.Drawing.Point(334, 111);
            this.Cbox_Categoria.Name = "Cbox_Categoria";
            this.Cbox_Categoria.Size = new System.Drawing.Size(190, 21);
            this.Cbox_Categoria.TabIndex = 6;
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.Location = new System.Drawing.Point(334, 149);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Entrar.TabIndex = 7;
            this.Btn_Entrar.Text = "Entrar";
            this.Btn_Entrar.UseVisualStyleBackColor = true;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(416, 148);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(84, 23);
            this.Btn_Cerrar.TabIndex = 8;
            this.Btn_Cerrar.Text = "Cerrar Sesion";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prueba1.Properties.Resources.Logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(31, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_admin
            // 
            this.Lbl_admin.AutoSize = true;
            this.Lbl_admin.Location = new System.Drawing.Point(121, 193);
            this.Lbl_admin.Name = "Lbl_admin";
            this.Lbl_admin.Size = new System.Drawing.Size(44, 13);
            this.Lbl_admin.TabIndex = 9;
            this.Lbl_admin.Text = "Nombre";
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 231);
            this.Controls.Add(this.Lbl_admin);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_Entrar);
            this.Controls.Add(this.Cbox_Categoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbox_Cliente);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Lbl_Saludo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Form";
            this.Text = "Home_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Saludo;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.ComboBox Cbox_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbox_Categoria;
        private System.Windows.Forms.Button Btn_Entrar;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label Lbl_admin;
    }
}