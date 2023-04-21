using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1.Model
{
    internal class Atributos
    {
        ArrayList cliente = new ArrayList();
        ArrayList categoria = new ArrayList();
        ArrayList metas = new ArrayList();
        ArrayList ejercicios = new ArrayList();
        ArrayList repeticiones = new ArrayList();

        public Atributos()
        {
            Cliente.Add("Seleccionar");
            Cliente.Add("Javiera");
            Cliente.Add("Mario");
            Cliente.Add("Pepe");

            categoria.Add("Seleccionar");
            Categoria.Add("Basico");
            Categoria.Add("Premium");

            Metas.Add("Seleccione una Meta");
            Metas.Add("Bajar de peso y reducir grasa corporal");
            Metas.Add("Aumentar la masa corporal del individuo");

            Ejercicio.Add("Seleccione un Ejercicio");
            Ejercicio.Add("Running");
            Ejercicio.Add("Levantamiento de pesas");

            Repeticiones.Add("Seleccione una Meta y un Ejercicio");
            Repeticiones.Add("Ejercicio no viable para cumplir meta");
            Repeticiones.Add("1 Hora y 30 minutos");
            Repeticiones.Add("5 series de 20 repeticiones");


        }


        public Atributos(ArrayList cliente, ArrayList categoria)
        {
            this.Cliente = cliente;
            this.Categoria = categoria;
            this.Repeticiones = repeticiones;
            this.Metas = metas;
            this.Ejercicio = ejercicios;
        }

        public ArrayList Cliente { get => cliente; set => cliente = value;}
        public ArrayList Categoria { get => categoria; set => categoria = value; }
        public ArrayList Metas { get => metas; set => metas = value; }
        public ArrayList Ejercicio { get => ejercicios; set => ejercicios = value; }
        public ArrayList Repeticiones { get => repeticiones; set => repeticiones = value; }
    }
}
