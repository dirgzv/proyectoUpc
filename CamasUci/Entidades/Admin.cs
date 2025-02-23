using System;

public class Admin
{
    private string _Nombre, _Correo, _Telefono, _Contrasena;
    public Admin()
    {
    }
    public Admin(string Nombre, string Correo, string Telefono, string Contrasena)
    {
        _Nombre = Nombre;
        _Correo = Correo;
        _Telefono = Telefono;
        _Contrasena = Contrasena;
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
}
