using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamasUci.Entidades
{
    public class Admin
    {
        private string _Nombre, _Correo, _Telefono, _Contrasena;
        private EntidadSalud _EntidadSalud;
        public Admin(string Nombre, string Correo, string Telefono, string Contrasena, Entidades.EntidadSalud EntidadSalud)
        {
            _Nombre = Nombre;
            _Correo = Correo;
            _Telefono = Telefono;
            _Contrasena = Contrasena;
            _EntidadSalud = EntidadSalud;
        }
        public Admin()
        {
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        public string Contrasena
        {
            get { return _Contrasena; }
            set { _Contrasena = value; }
        }
        public Entidades.EntidadSalud EntidadSalud
        {
            get { return _EntidadSalud; }
            set { _EntidadSalud = value; }
        }
    }
}
