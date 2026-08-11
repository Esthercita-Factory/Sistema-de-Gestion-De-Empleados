namespace SistemaDeEmpleados2.Models;

public class Empleado
{
    public Guid Id  { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NumeroDeIdentificacion { get; set; }
    public byte Edad { get; set; }
    public string Posicion { get; set; }
    public double Salario { get; set; }


    private double CalcularBonificacion()
    {
        return Salario *  10 / 100;
    }
    
   

    public void MostrarInformacion()
    {
        Console.WriteLine("Id." + Id);
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Apellido: " + Apellido);
        Console.WriteLine("Numero de indentificacion: " + NumeroDeIdentificacion);
        Console.WriteLine("Edad: " + Edad);
        Console.WriteLine("Posicion:" + Posicion);
        Console.WriteLine("Salario: " + (Salario + CalcularBonificacion()));
        
    }
    
}