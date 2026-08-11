// using SistemaDeEmpleados2.Models;
//
// Empleado empleado = new Empleado
// {
//     Id = Guid.NewGuid(),
//     Nombre = "juan",
//     Apellido = "Alvarez",
//     NumeroDeIdentificacion = "1001010",
//     Edad = 25,
//     Posicion = "desarrollador",
//     Salario = 3000000
// };
//
// Empresa empresa = new Empresa();
//
// empresa.AgregarEmpleado(empleado);

bool continuar = true;
Empresa empresa = new Empresa();

while (continuar)
{
    Console.Clear();
    Console.WriteLine("--- SISTEMA DE EMPLEADOS ---");
    Console.WriteLine("1. Agregar Empleado");
    Console.WriteLine("2. Salir");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Ingrese la edad:");
            string entradaEdad = Console.ReadLine();
            byte edad;

            if (byte.TryParse(entradaEdad, out edad))
            {
                Console.WriteLine("Edad registrada correctamente. Presione ENTER.");
            }
            else
            {
                Console.WriteLine("Error: La edad debe ser un número entero. Presione ENTER.");
            }
            Console.ReadLine();
            break;

        case "2":
            continuar = false;
            break;

        default:
            Console.WriteLine("Opción no válida. Presione ENTER.");
            Console.ReadLine();
            break;
    }
}