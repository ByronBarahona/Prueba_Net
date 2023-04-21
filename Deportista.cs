using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1.Model
{
    internal class Deportista
    {
        private String jstName;
        private int peso;
        private int altura;
        private int imc;
        private String clasificacion;



        public Deportista(string jstName, int peso, int altura, int imc, string clasificacion)
        {
            this.JstName = jstName;
            this.Peso = peso;
            this.Altura = altura;
            this.Imc = imc;
            this.Clasificacion = clasificacion;
        }



        public Deportista()
        {
            Peso = 80;
        }



        public string JstName { get => jstName; set => jstName = value; }
        public int Peso { get => peso; set => peso = value; }
        public int Altura { get => altura; set => altura = value; }
        public int Imc { get => imc; set => imc = value; }
        public string Clasificacion { get => clasificacion; set => clasificacion = value; }

    }
}
