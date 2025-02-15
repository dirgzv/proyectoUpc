using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Admin
{
    private string _Password, _Nombre, _Correo;

    public Admin(string Nombre, string Correo, string Password)
    {
        _Nombre = Nombre;
        _Correo = Correo;
        _Password = Password;
    }

    public Admin()
    {
    }

    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
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
}

class EntidadSalud
{
    private string _Nombre, _Direccion, _Telefono, _Correo, _NroCamas, _Tipo, _NroCamasDisponibles, _NroCamasOcupadas;
    public EntidadSalud(string Nombre, string Direccion, string Telefono, string Correo, string NroCamas, string Tipo, string NroCamasDisponibles, string NroCamasOcupadas)
    {
        _Nombre = Nombre;
        _Direccion = Direccion;
        _Telefono = Telefono;
        _Correo = Correo;
        _NroCamas = NroCamas;
        _Tipo = Tipo;
        _NroCamasDisponibles= NroCamasDisponibles;
        _NroCamasOcupadas = NroCamasOcupadas;
    }
    public EntidadSalud()
    {
    }
    public string Nombre
    {
        get { return _Nombre; }
        set { _Nombre = value; }
    }
    public string Direccion
    {
        get { return _Direccion; }
        set { _Direccion = value; }
    }
    public string Telefono
    {
        get { return _Telefono; }
        set { _Telefono = value; }
    }
    public string Correo
    {
        get { return _Correo; }
        set { _Correo = value; }
    }
    public string NroCamas
    {
        get { return _NroCamas; }
        set { _NroCamas = value; }
    }
    public string Tipo
    {
        get { return _Tipo; }
        set { _Tipo = value; }
    }
    public string NroCamasDisponibles
    {
        get { return _NroCamasDisponibles; }
        set { _NroCamasDisponibles = value; }
    }
    public string NroCamasNoDisponibles
    {
        get { return _NroCamasOcupadas; }
        set { _NroCamasOcupadas = value; }
    }
}

public abstract class CamasUci
{
    private string _Id, _Estado, _Ubicacion;
    private DateTime _FechaOcupacion, _FechaLiberacion;

    public CamasUci(string Id, string Estado, string Ubicacion, DateTime FechaOcupacion, DateTime FechaLiberacion)
    {
        _Id = Id;
        _Estado = Estado;
        _Ubicacion = Ubicacion;
        _FechaOcupacion = FechaOcupacion;
        _FechaLiberacion = FechaLiberacion;
    }

    public CamasUci()
    {
    }

    public string Id
    {
        get { return _Id; }
        set { _Id = value; }
    }
    public string Estado
    {
        get { return _Estado; }
        set { _Estado = value; }
    }
    public string Ubicacion
    {
        get { return _Ubicacion; }
        set { _Ubicacion = value; }
    }
    public DateTime FechaOcupacion
    {
        get { return _FechaOcupacion; }
        set { _FechaOcupacion = value; }
    }
    public DateTime FechaLiberacion
    {
        get { return _FechaLiberacion; }
        set { _FechaLiberacion = value; }
    }
}

