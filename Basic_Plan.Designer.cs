namespace Prueba1.GUI
{
    partial class Basic_Plan
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
            this.Lbl_Informacion = new System.Windows.Forms.Label();
            this.DtView_Datos = new System.Windows.Forms.DataGridView();
            this.Gbox_Detalle = new System.Windows.Forms.GroupBox();
            this.Txt_Altura = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Peso = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Altura = new System.Windows.Forms.Label();
            this.Lbl_peso = new System.Windows.Forms.Label();
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.Btn_Calculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtView_Datos)).BeginInit();
            this.Gbox_Detalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Saludo
            // 
            this.Lbl_Saludo.AutoSize = true;
            this.Lbl_Saludo.Location = new System.Drawing.Point(13, 13);
            this.Lbl_Saludo.Name = "Lbl_Saludo";
            this.Lbl_Saludo.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Saludo.TabIndex = 0;
            // 
            // Lbl_Informacion
            // 
            this.Lbl_Informacion.AutoSize = true;
            this.Lbl_Informacion.Location = new System.Drawing.Point(16, 30);
            this.Lbl_Informacion.Name = "Lbl_Informacion";
            this.Lbl_Informacion.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Informacion.TabIndex = 2;
            // 
            // DtView_Datos
            // 
            this.DtView_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtView_Datos.Location = new System.Drawing.Point(12, 59);
            this.DtView_Datos.Name = "DtView_Datos";
            this.DtView_Datos.Size = new System.Drawing.Size(461, 150);
            this.DtView_Datos.TabIndex = 4;
            // 
            // Gbox_Detalle
            // 
            this.Gbox_Detalle.Controls.Add(this.Txt_Altura);
            this.Gbox_Detalle.Controls.Add(this.Txt_Peso);
            this.Gbox_Detalle.Controls.Add(this.Lbl_Altura);
            this.Gbox_Detalle.Controls.Add(this.Lbl_peso);
            this.Gbox_Detalle.Controls.Add(this.Btn_Volver);
            this.Gbox_Detalle.Controls.Add(this.Btn_Calculo);
            this.Gbox_Detalle.Location = new System.Drawing.Point(12, 226);
            this.Gbox_Detalle.Name = "Gbox_Detalle";
            this.Gbox_Detalle.Size = new System.Drawing.Size(441, 100);
            this.Gbox_Detalle.TabIndex = 5;
            this.Gbox_Detalle.TabStop = false;
            this.Gbox_Detalle.Text = "Detalle";
            // 
            // Txt_Altura
            // 
            this.Txt_Altura.Location = new System.Drawing.Point(215, 53);
            this.Txt_Altura.Mask = "9.99";
            this.Txt_Altura.Name = "Txt_Altura";
            this.Txt_Altura.Size = new System.Drawing.Size(39, 20);
            this.Txt_Altura.TabIndex = 7;
            // 
            // Txt_Peso
            // 
            this.Txt_Peso.Location = new System.Drawing.Point(215, 27);
            this.Txt_Peso.Mask = "999";
            this.Txt_Peso.Name = "Txt_Peso";
            this.Txt_Peso.Size = new System.Drawing.Size(39, 20);
            this.Txt_Peso.TabIndex = 6;
            this.Txt_Peso.ValidatingType = typeof(int);
            // 
            // Lbl_Altura
            // 
            this.Lbl_Altura.AutoSize = true;
            this.Lbl_Altura.Location = new System.Drawing.Point(178, 60);
            this.Lbl_Altura.Name = "Lbl_Altura";
            this.Lbl_Altura.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Altura.TabIndex = 3;
            this.Lbl_Altura.Text = "Altura";
            // 
            // Lbl_peso
            // 
            this.Lbl_peso.AutoEllipsis = true;
            this.Lbl_peso.AutoSize = true;
            this.Lbl_peso.Location = new System.Drawing.Point(178, 30);
            this.Lbl_peso.Name = "Lbl_peso";
            this.Lbl_peso.Size = new System.Drawing.Size(31, 13);
            this.Lbl_peso.TabIndex = 2;
            this.Lbl_peso.Text = "Peso";
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.Location = new System.Drawing.Point(21, 60);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(94, 23);
            this.Btn_Volver.TabIndex = 1;
            this.Btn_Volver.Text = "Volver al menú";
            this.Btn_Volver.UseVisualStyleBackColor = true;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // Btn_Calculo
            // 
            this.Btn_Calculo.Location = new System.Drawing.Point(21, 20);
            this.Btn_Calculo.Name = "Btn_Calculo";
            this.Btn_Calculo.Size = new System.Drawing.Size(94, 23);
            this.Btn_Calculo.TabIndex = 0;
            this.Btn_Calculo.Text = "Calcular IMC";
            this.Btn_Calculo.UseVisualStyleBackColor = true;
            this.Btn_Calculo.Click += new System.EventHandler(this.Btn_Calculo_Click);
            // 
            // Basic_Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 332);
            this.Controls.Add(this.Gbox_Detalle);
            this.Controls.Add(this.DtView_Datos);
            this.Controls.Add(this.Lbl_Informacion);
            this.Controls.Add(this.Lbl_Saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Basic_Plan";
            this.Text = "Basic_Plan";
            ((System.ComponentModel.ISupportInitialize)(this.DtView_Datos)).EndInit();
            this.Gbox_Detalle.ResumeLayout(false);
            this.Gbox_Detalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Saludo;
        private System.Windows.Forms.Label Lbl_Informacion;
        private System.Windows.Forms.DataGridView DtView_Datos;
        private System.Windows.Forms.GroupBox Gbox_Detalle;
        private System.Windows.Forms.Label Lbl_Altura;
        private System.Windows.Forms.Label Lbl_peso;
        private System.Windows.Forms.Button Btn_Volver;
        private System.Windows.Forms.Button Btn_Calculo;
        private System.Windows.Forms.MaskedTextBox Txt_Peso;
        private System.Windows.Forms.MaskedTextBox Txt_Altura;
    }
}