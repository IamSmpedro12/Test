// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Personas persona = new Personas(); 
persona.Id = 1;
persona.Nombre = "Juan Perez";
persona.Estatura = 1.75m;
persona.Vive = false;
persona.Fecha = DateTime.Now;

persona.Estado = new Estados() { Id = 1, Nombre = "Viudo" };

public class Estados
{
    public int Id;
    public string? Nombre;
}
public class Personas
{
    public int Id;
    public string? Nombre;
    public decimal Estatura;
    public bool Vive;
    public DateTime Fecha;
    public Estados? Estado;
}

public class Estudiantes : Personas
{
    public string? Carnet;
    public int Semestre;
}