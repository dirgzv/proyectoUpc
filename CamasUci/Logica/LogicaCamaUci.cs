using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamasUci.Entidades;

namespace CamasUci.Logica
{
    public class LogicaCamaUci
    {
        private List<CamaUci> _CamasUci;
        public LogicaCamaUci()
        {
            _CamasUci = new List<CamaUci>();
        }
        public void AgregarCamaUci(CamaUci camaUci)
        {
            _CamasUci.Add(camaUci);
        }
        public void EliminarCamaUci(CamaUci camaUci)
        {
            _CamasUci.Remove(camaUci);
        }
        public List<CamaUci> ListarCamasUci()
        {
            return _CamasUci;
        }
        public CamaUci BuscarCamaUci(string id)
        {
            foreach (CamaUci camaUci in _CamasUci)
            {
                if (camaUci.Id == id)
                {
                    return camaUci;
                }
            }
            return null;
        }
        public void ModificarCamaUci(CamaUci camaUci)
        {
            foreach (CamaUci c in _CamasUci)
            {
                if (c.Id == camaUci.Id)
                {
                    c.Estado = camaUci.Estado;
                    c.Ubicacion = camaUci.Ubicacion;
                    c.Tìpo = camaUci.Tìpo;
                    c.FechaOcupacion = camaUci.FechaOcupacion;
                    c.FechaLiberacion = camaUci.FechaLiberacion;
                    if (c.Estado == "Ocupada")
                    {
                        c.FechaOcupacion = DateTime.Now;
                    }
                    else
                    {
                        c.FechaLiberacion = DateTime.Now;
                    }
                }
            }
        }
        public void LiberarCamaUci(CamaUci camaUci)
        {
            foreach (CamaUci c in _CamasUci)
            {
                if (c.Id == camaUci.Id)
                {
                    c.Estado = "Libre";
                    c.FechaLiberacion = DateTime.Now;
                }
            }
        }
        public void OcuparCamaUci(CamaUci camaUci)
        {
            foreach (CamaUci c in _CamasUci)
            {
                if (c.Id == camaUci.Id)
                {
                    c.Estado = "Ocupada";
                    c.FechaOcupacion = DateTime.Now;
                }
            }
        }
    }
}