using System;

public class EntidadSalud
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
        _NroCamasDisponibles = NroCamasDisponibles;
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
