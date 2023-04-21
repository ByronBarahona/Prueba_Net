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

namespace Prueba1.GUI
{
    public partial class Home_Form : Form
    {
         Atributos atr = new Atributos();
         Administrador adm = new Administrador();
         Deportista dep = new Deportista();       


        public Home_Form()
        {
            InitializeComponent();
            CargaDatos();
            Lbl_Saludo.Text = "Bienvenido: ";

        }


        public void CargaDatos()
        {
            for (int i = 0; i < atr.Cliente.Count; i++)
            {
                Cbox_Cliente.Items.Add(atr.Cliente[i]);
                Cbox_Cliente.SelectedIndex = 0;
            }
            for (int i = 0;i < atr.Categoria.Count;i++)
            {
                Cbox_Categoria.Items.Add(atr.Categoria[i]);
                Cbox_Categoria.SelectedIndex = 0;
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Hide();
            Login_Form lg = new Login_Form();
            lg.Show();
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            Hide(); // ocultar ventana



            if (Cbox_Categoria.SelectedItem.Equals(atr.Categoria[0]) || Cbox_Cliente.SelectedItem.Equals(atr.Cliente[0]))
            {

                MessageBox.Show("Favor de completar los datos de Nombre y/o Categoria");

                Home_Form hom = new Home_Form();
                hom.Show();

            }
            else
            {
                if (Cbox_Categoria.SelectedItem.Equals(atr.Categoria[1]))
                {

                    dep.JstName = Cbox_Cliente.SelectedItem.ToString();
                    Basic_Plan bsc = new Basic_Plan();
                    bsc.Show();
                }
                else
                {
                    dep.JstName = Cbox_Cliente.SelectedItem.ToString();
                    Plan_Premium prm = new Plan_Premium();
                    prm.Show();
                }

                Lbl_admin.Text = adm.Nombre;
                }
            }
        }
    }

