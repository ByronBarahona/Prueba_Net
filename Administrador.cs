using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1.Model
{
    internal class Administrador
    {
        protected string login;
        protected string nombre;
        protected string pass;
        protected int id_admin;

        public Administrador()
        {
            nombre = "Byron";
            login = "stomas";
            Pass = "123";
            Id_admin = 1;
        }

        public Administrador(string login, string nombre, string pass, int id_admin)
        {
            this.login = login;
            this.nombre = nombre;
            this.pass = pass;
            this.id_admin = id_admin;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Login { get => login; set => login = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Id_admin { get => id_admin; set => id_admin = value; }

        public override bool Equals(object obj)
        {
            return obj is Administrador administrador &&
                id_admin == administrador.id_admin &&
                nombre == administrador.nombre &&
                login == administrador.login &&
                pass == administrador.pass &&
                Id_admin == administrador.Id_admin &&
                Nombre == administrador.Nombre &&
                Login == administrador.Login &&
                Pass == administrador.Pass;
        }

    }


}
