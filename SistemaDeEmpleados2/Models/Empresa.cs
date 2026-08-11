namespace SistemaDeEmpleados2.Models;
using System.Linq;
public class Empresa
{
    
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<Empleado> ListaEmpleados { get; set; }

    public  Empresa()
    {
        ListaEmpleados = new List<Empleado>();
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Add(empleado);
    }
    
    public void MostrarTodosLosEmpleados()
    {
        foreach (var empleados in ListaEmpleados)
        {
            empleados.MostrarInformacion();
        }
    }

    public Empleado? BuscarEmpleado(string numeroDeIdentificacion)
    {
        return 
            ListaEmpleados.Where(empleado =>
            empleado.NumeroDeIdentificacion == numeroDeIdentificacion).FirstOrDefault();
    }
    public void EliminarEmpleado(string nombre,  string apellido)
    {
        var empleadoEncontrado = ListaEmpleados
        .Where(empleado => 
            nombre == empleado.Nombre && apellido ==
            empleado.Apellido)
        .FirstOrDefault();
        if (empleadoEncontrado != null)
        {
            ListaEmpleados.Remove(empleadoEncontrado);
        }
        

    }

    public void ActualizarEmpleado(string numeroDeIdentificacion,
        string nombre,
        string apellido,
        byte edad,
        string posicion,
        double salario)
    {
        var empleadoEncontrado = BuscarEmpleado(numeroDeIdentificacion);
        if (empleadoEncontrado != null)
        {
            empleadoEncontrado.Nombre = nombre;
            empleadoEncontrado.Apellido = apellido;
            empleadoEncontrado.Edad = edad;
            empleadoEncontrado.Salario = salario;
            empleadoEncontrado.Posicion = posicion;
        }
    }

    public List<Empleado> MostrarEmpleadosPorCargo(string posicion)
    {
        return ListaEmpleados
            .Where(empleado => empleado.Posicion == posicion)
            .ToList();
    }
    }
    
    
}