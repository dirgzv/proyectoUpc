using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamasUci.Entidades;

namespace CamasUci.Logica
    {
    public class LogicaEntidadSalud
    {
        private List<EntidadSalud> _EntidadesSalud;
        public LogicaEntidadSalud()
        {
            _EntidadesSalud = new List<EntidadSalud>();
        }
        public void AgregarEntidadSalud(EntidadSalud entidadSalud)
        {
            _EntidadesSalud.Add(entidadSalud);
        }
        public void EliminarEntidadSalud(EntidadSalud entidadSalud)
        {
            _EntidadesSalud.Remove(entidadSalud);
        }
        public List<EntidadSalud> ListarEntidadesSalud()
        {
            return _EntidadesSalud;
        }
        public EntidadSalud BuscarEntidadSalud(string correo)
        {
            foreach (EntidadSalud entidadSalud in _EntidadesSalud)
            {
                if (entidadSalud.Correo == correo)
                {
                    return entidadSalud;
                }
            }
            return null;
        }
        public void ModificarEntidadSalud(EntidadSalud entidadSalud)
        {
            foreach (EntidadSalud e in _EntidadesSalud)
            {
                if (e.Correo == entidadSalud.Correo)
                {
                    e.Nombre = entidadSalud.Nombre;
                    e.Direccion = entidadSalud.Direccion;
                    e.Telefono = entidadSalud.Telefono;
                    e.Correo = entidadSalud.Correo;
                    e.NroCamas = entidadSalud.NroCamas;
                    e.Tipo = entidadSalud.Tipo;
                    e.NroCamasDisponibles = entidadSalud.NroCamasDisponibles;
                    e.NroCamasOcupadas = entidadSalud.NroCamasOcupadas;
                }
            }
        }
    }
}
