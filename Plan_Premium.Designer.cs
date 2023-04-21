namespace Prueba1.GUI
{
    partial class Plan_Premium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plan_Premium));
            this.Lbl_Saludo = new System.Windows.Forms.Label();
            this.Gbox_Detalle = new System.Windows.Forms.GroupBox();
            this.Lbl_Repeticiones = new System.Windows.Forms.Label();
            this.CBox_Ejercicio = new System.Windows.Forms.ComboBox();
            this.Lbl_Ejercicio = new System.Windows.Forms.Label();
            this.Btn_Reducir = new System.Windows.Forms.Button();
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.Lbl_Metas = new System.Windows.Forms.Label();
            this.Cbox_Metas = new System.Windows.Forms.ComboBox();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Txt_Repeticiones = new System.Windows.Forms.TextBox();
            this.Gbox_Detalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Saludo
            // 
            this.Lbl_Saludo.AutoSize = true;
            this.Lbl_Saludo.Location = new System.Drawing.Point(28, 13);
            this.Lbl_Saludo.Name = "Lbl_Saludo";
            this.Lbl_Saludo.Size = new System.Drawing.Size(106, 13);
            this.Lbl_Saludo.TabIndex = 0;
            this.Lbl_Saludo.Text = "Bienvenido Premium:";
            // 
            // Gbox_Detalle
            // 
            this.Gbox_Detalle.Controls.Add(this.Txt_Repeticiones);
            this.Gbox_Detalle.Controls.Add(this.Lbl_Repeticiones);
            this.Gbox_Detalle.Controls.Add(this.CBox_Ejercicio);
            this.Gbox_Detalle.Controls.Add(this.Lbl_Ejercicio);
            this.Gbox_Detalle.Location = new System.Drawing.Point(31, 56);
            this.Gbox_Detalle.Name = "Gbox_Detalle";
            this.Gbox_Detalle.Size = new System.Drawing.Size(236, 159);
            this.Gbox_Detalle.TabIndex = 1;
            this.Gbox_Detalle.TabStop = false;
            this.Gbox_Detalle.Text = "Detalle";
            // 
            // Lbl_Repeticiones
            // 
            this.Lbl_Repeticiones.AutoSize = true;
            this.Lbl_Repeticiones.Location = new System.Drawing.Point(21, 95);
            this.Lbl_Repeticiones.Name = "Lbl_Repeticiones";
            this.Lbl_Repeticiones.Size = new System.Drawing.Size(69, 13);
            this.Lbl_Repeticiones.TabIndex = 2;
            this.Lbl_Repeticiones.Text = "Repeticiones";
            // 
            // CBox_Ejercicio
            // 
            this.CBox_Ejercicio.FormattingEnabled = true;
            this.CBox_Ejercicio.Location = new System.Drawing.Point(21, 55);
            this.CBox_Ejercicio.Name = "CBox_Ejercicio";
            this.CBox_Ejercicio.Size = new System.Drawing.Size(160, 21);
            this.CBox_Ejercicio.TabIndex = 1;
            // 
            // Lbl_Ejercicio
            // 
            this.Lbl_Ejercicio.AutoSize = true;
            this.Lbl_Ejercicio.Location = new System.Drawing.Point(18, 29);
            this.Lbl_Ejercicio.Name = "Lbl_Ejercicio";
            this.Lbl_Ejercicio.Size = new System.Drawing.Size(47, 13);
            this.Lbl_Ejercicio.TabIndex = 0;
            this.Lbl_Ejercicio.Text = "Ejercicio";
            // 
            // Btn_Reducir
            // 
            this.Btn_Reducir.Location = new System.Drawing.Point(52, 236);
            this.Btn_Reducir.Name = "Btn_Reducir";
            this.Btn_Reducir.Size = new System.Drawing.Size(93, 23);
            this.Btn_Reducir.TabIndex = 2;
            this.Btn_Reducir.Text = "Reducir Calorias";
            this.Btn_Reducir.UseVisualStyleBackColor = true;
            this.Btn_Reducir.Click += new System.EventHandler(this.Btn_Reducir_Click);
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.Location = new System.Drawing.Point(164, 235);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(95, 23);
            this.Btn_Volver.TabIndex = 3;
            this.Btn_Volver.Text = "Volver al menú";
            this.Btn_Volver.UseVisualStyleBackColor = true;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // Lbl_Metas
            // 
            this.Lbl_Metas.AutoSize = true;
            this.Lbl_Metas.Location = new System.Drawing.Point(320, 71);
            this.Lbl_Metas.Name = "Lbl_Metas";
            this.Lbl_Metas.Size = new System.Drawing.Size(36, 13);
            this.Lbl_Metas.TabIndex = 4;
            this.Lbl_Metas.Text = "Metas";
            // 
            // Cbox_Metas
            // 
            this.Cbox_Metas.FormattingEnabled = true;
            this.Cbox_Metas.Location = new System.Drawing.Point(323, 88);
            this.Cbox_Metas.Name = "Cbox_Metas";
            this.Cbox_Metas.Size = new System.Drawing.Size(147, 21);
            this.Cbox_Metas.TabIndex = 5;
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Location = new System.Drawing.Point(360, 151);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(55, 13);
            this.Lbl_Resultado.TabIndex = 6;
            this.Lbl_Resultado.Text = "Resultado";
            // 
            // Txt_Repeticiones
            // 
            this.Txt_Repeticiones.Enabled = false;
            this.Txt_Repeticiones.Location = new System.Drawing.Point(24, 123);
            this.Txt_Repeticiones.Name = "Txt_Repeticiones";
            this.Txt_Repeticiones.Size = new System.Drawing.Size(157, 20);
            this.Txt_Repeticiones.TabIndex = 3;
            // 
            // Plan_Premium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 294);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Cbox_Metas);
            this.Controls.Add(this.Lbl_Metas);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.Btn_Reducir);
            this.Controls.Add(this.Gbox_Detalle);
            this.Controls.Add(this.Lbl_Saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Plan_Premium";
            this.Text = "Plan_Premium";
            this.Gbox_Detalle.ResumeLayout(false);
            this.Gbox_Detalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Saludo;
        private System.Windows.Forms.GroupBox Gbox_Detalle;
        private System.Windows.Forms.Label Lbl_Repeticiones;
        private System.Windows.Forms.ComboBox CBox_Ejercicio;
        private System.Windows.Forms.Label Lbl_Ejercicio;
        private System.Windows.Forms.Button Btn_Reducir;
        private System.Windows.Forms.Button Btn_Volver;
        private System.Windows.Forms.Label Lbl_Metas;
        private System.Windows.Forms.ComboBox Cbox_Metas;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.TextBox Txt_Repeticiones;
    }
}