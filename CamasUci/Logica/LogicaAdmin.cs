using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamasUci.Entidades;

namespace CamasUci.Logica
{
    public class LogicaAdmin
    {
        private List<Admin> _Admins;

        public LogicaAdmin()
        {
            _Admins = new List<Admin>();
        }
        public void AgregarAdmin(Admin admin)
        {
            _Admins.Add(admin);
        }
        public void EliminarAdmin(Admin admin)
        {
            _Admins.Remove(admin);
        }
        public List<Admin> ListarAdmins()
        {
            return _Admins;
        }
        public Admin BuscarAdmin(string correo)
        {
            foreach (Admin admin in _Admins)
            {
                if (admin.Correo == correo)
                {
                    return admin;
                }
            }
            return null;
        }
        public bool VerificarAdmin(string correo, string contrasena)
        {
            foreach (Admin admin in _Admins)
            {
                if (admin.Correo == correo && admin.Contrasena == contrasena)
                {
                    return true;
                }
            }
            return false;
        }
        public void ModificarAdmin(Admin admin)
        {
            foreach (Admin a in _Admins)
            {
                if (a.Correo == admin.Correo)
                {
                    a.Nombre = admin.Nombre;
                    a.Telefono = admin.Telefono;
                    a.Contrasena = admin.Contrasena;
                }
            }
        }
    }
}
