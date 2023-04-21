using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba1.Model;
using Prueba1.GUI;

namespace Prueba1.GUI
{

    public partial class Basic_Plan : Form
    {

        private Deportista dep = new Deportista();
        readonly Home_Form hform = new Home_Form();

        private double altura;
        private double peso;
        private double total;
        private String mensaje;
        public String Admin;
        private int cantidad;

        public Basic_Plan()
        {
            this.dep = dep;
            InitializeComponent();
            FormatoDtViewDatos();


            Lbl_Saludo.Text = "Bienvenido: ";
            Lbl_Informacion.Text = "Aquí puedes gestionar los datos de: " + dep.JstName;

        }





        private void Btn_Calculo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Peso.Text) || String.IsNullOrEmpty(Txt_Altura.Text))
            {
                MessageBox.Show("Los campos de peso y/o altura se encuentran vacios");
            }
            else
            {
                String valor1 = Txt_Peso.Text;
                String valor2 = Txt_Altura.Text;
                double resultado;

                altura = double.Parse(valor2);
                peso = double.Parse(valor1);

                resultado = altura * altura;

                total = resultado / peso;

                if (total < 18.4)
                {
                    mensaje = "Bajo peso";
                }
                else if (total > 18.5 && total < 24.9)
                {
                    mensaje = "Normopeso";
                }
                else if (total > 25 && total < 29.9)
                {
                    mensaje = "Sobre peso";
                }
                else if (total > 30 && total < 34.9)
                {
                    mensaje = "Obesidad grado I";
                }
                else if (total > 35 && total < 39.9)
                {
                    mensaje = "Obesidad grado II";
                }
                else if (total > 40)
                {
                    mensaje = "Obesidad grado III o sobre peso";
                }
                cantidad += 1;

                DtView_Datos.Rows.Add(cantidad, dep.JstName, total, mensaje);
            }
            
        }


        private void FormatoDtViewDatos()
        {
            DtView_Datos.Columns.Add("N°", "N°");
            DtView_Datos.Columns.Add("Deportista", "Deportista");
            DtView_Datos.Columns.Add("IMC", "IMC");
            DtView_Datos.Columns.Add("Mensaje", "Mensaje");
            DtView_Datos.RowCount = 1;

        }


        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            Hide();
            Home_Form home = new Home_Form();
            home.Show();
        }
    }
}
