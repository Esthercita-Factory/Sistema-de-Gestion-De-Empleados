namespace SistemaDeEmpleados2.Models;

public class Empresa
{
    
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<Empleado> ListaEmpleados { get; set; }

    public  Empresa()
    {
        ListaEmpleados = new List<Empleado>();
    }
    
    
    
    
}