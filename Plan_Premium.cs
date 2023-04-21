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

namespace Prueba1.GUI
{
    public partial class Plan_Premium : Form
    {
        
        Atributos atr = new Atributos();
        Deportista dep = new Deportista();
        public Plan_Premium()
        {
            InitializeComponent();
            CargarInfo();
        }

        public void CargarInfo()
        {
            for(int i = 0; i < atr.Ejercicio.Count; i++)
            {
                CBox_Ejercicio.Items.Add(atr.Ejercicio[i]);
                CBox_Ejercicio.SelectedIndex = 0;
            }
            for(int i = 0; i < atr.Metas.Count; i++)
            {
                Cbox_Metas.Items.Add(atr.Metas[i]);
                Cbox_Metas.SelectedIndex = 0;
            }
            
            Cbox_Repeticiones.Text = (String)atr.Repeticiones[0];
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            Hide();
            Home_Form home = new Home_Form();
            home.Show();
        }

        private void Btn_Reducir_Click(object sender, EventArgs e)
        {
            String ejercicio = CBox_Ejercicio.Text.ToString();
            String meta = Cbox_Metas.Text.ToString();

            if (ejercicio.Equals("Running") && meta.Equals("Bajar de peso y reducir grasa corporal"))
            {
                Cbox_Repeticiones.Text = (string)atr.Repeticiones[2];
                int resultado = dep.Peso - 2;
                Lbl_Resultado.Text = "Total de peso reducido:  2kg\n total: " + resultado + "kg";
            }
            else if (ejercicio.Equals("Levantamiento de pesas") && meta.Equals("Aumentar la masa corporal del individuo"))
            {
                Cbox_Repeticiones.Text = (string)atr.Repeticiones[3];
                int resultado = dep.Peso + 5;
                Lbl_Resultado.Text = "Total de peso ganado:  5kg\n total: " + resultado + "kg";
            }
            else
            {
                MessageBox.Show("ejercicio no viable para cumplir meta");
            }
        }
    }
}
