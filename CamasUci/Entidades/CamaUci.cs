using System;

public class CamaUci
{
    private string _Id, _Estado, _Ubicacion, _Tìpo;
    private DateTime _FechaOcupacion, _FechaLiberacion;

    public CamaUci()
    {
    }

    public CamaUci(string Id, string Estado, string Ubicacion, string Tìpo, DateTime FechaOcupacion, DateTime FechaLiberacion)
    {
        _Id = Id;
        _Estado = Estado;
        _Ubicacion = Ubicacion;
        _Tìpo = Tìpo;
        _FechaOcupacion = FechaOcupacion;
        _FechaLiberacion = FechaLiberacion;
    }
    public string Id()
    {
        get { return _Id; }
        set { _Id = value; }
    }
    public string Estado() {
        get { return _Estado; }
        set { _Estado = value; }

    }
    public string Ubicacion()
    {
        get { return _Ubicacion; }
        set { _Ubicacion = value; }
    }
    public string Tìpo()
    {
        get { return _Tìpo; }
        set { _Tìpo = value; }
    }
    public DateTime FechaOcupacion()
    {
        get { return _FechaOcupacion; }
        set { _FechaOcupacion = value; }
    }
    public DateTime FechaLiberacion()
    {
        get { return _FechaLiberacion; }
        set { _FechaLiberacion = value; }
    }
}
