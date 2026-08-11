// See https://aka.ms/new-console-template for more information
using SistemaDeEmpleados2.Models;
Console.WriteLine("Hello, World!");

Empleado empleado = new Empleado
{
    Id =  Guid.NewGuid(),
    Nombre = "juan",
    Apellido = "Alvarez",
    NumeroDeIdentificacion = "1001010",
    Edad = 25,
    Posicion = "desarrollador",
    Salario = 3000000
};
