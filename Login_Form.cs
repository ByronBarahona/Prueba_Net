using Prueba1.GUI;
using Prueba1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class Login_Form : Form
    {
        readonly Administrador admin = new Administrador();
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Btn_Ini_Sesion_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Txt_Usr.Text) || String.IsNullOrEmpty(Txt_Pass.Text))
            {
                MessageBox.Show("Los campos se encuentran vacios");
            }
            else
            {
                if(Txt_Usr.Text != admin.Login && Txt_Pass.Text != admin.Pass)
                {
                    MessageBox.Show("Usuario o contraseña invalidos");
                }
                else
                {
                    if (Txt_Usr.Text.Equals(admin.Login) && Txt_Pass.Text.Equals(admin.Pass))
                    {
                        Hide();
                        Home_Form home = new Home_Form();
                        home.Show();
                    }
                }

            }
            
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
