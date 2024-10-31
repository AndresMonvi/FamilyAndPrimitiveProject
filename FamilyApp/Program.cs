using FamilyApp.Entities;

namespace FamilyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            int modify;
            Son Son = new();
            bool stopProgram = false;
            do
            {
                Console.WriteLine("Escoja su opcion: \n" +
                "1. Mostrar valores \n" +
                "2. Modificar valores \n" +
                "3. Salir");

                bool CorectFormat = int.TryParse(Console.ReadLine(), out option);
                if (CorectFormat)
                {
                    switch (option)
                    {
                        case 1:
                            Son.MostrarInfo();
                            stopProgram = false;
                            break;
                        case 2:
                            string input;
                            do
                            {
                                Console.WriteLine("Escoja su opcion: \n" +
                                    "1. Modificar el nombre \n" +
                                    "2. Modificar la edad \n" +
                                    "3. Modificar el dni \n" +
                                    "4. Modificar el car \n" +
                                    "5. Modificar la profesion \n" +
                                    "6. Modificar el numero de hijos \n" +
                                    "7. Modificar la mascota \n" +
                                    "8. Modificar la altura \n" +
                                    "9. Modificar el peso \n" +
                                    "0. Salir");

                                modify = int.Parse(Console.ReadLine());

                                switch (modify)
                                {
                                    case 1:
                                        Console.WriteLine("Introduzca el nombre: ");
                                        Son.Name = Console.ReadLine();
                                        break;
                                    case 2:
                                        Console.WriteLine("Introduzca la edad: ");
                                        Son.SetAge(int.Parse(Console.ReadLine()));
                                        break;
                                    case 3:
                                        Console.WriteLine("Introduzca el dni: ");
                                        Son.SetDni(Console.ReadLine());
                                        break;
                                    case 4:
                                        Console.WriteLine("Introduzca el nuevo coche: ");
                                        Son.Car = Console.ReadLine();
                                        break;
                                    case 5:
                                        Console.WriteLine("Introduzca la nueva profesion");
                                        Son.SetProfession(Console.ReadLine());
                                        break;
                                    case 6:
                                        Console.WriteLine("Introduzca el numero de hijos: ");
                                        Son.SetChildren(int.Parse(Console.ReadLine()));
                                        break;
                                    case 7:
                                        Son.Pet = Console.ReadLine();
                                        break;
                                    case 8:
                                        Console.WriteLine("Introduzca la altura: ");
                                        Son.SetHeight(Console.ReadLine());
                                        break;
                                    case 9:
                                        Son.SetWeight(Console.ReadLine());
                                        break;
                                    default:
                                        Console.WriteLine("Introduce a number between 0 and 9");
                                        break;

                                }
                            } while (modify != 0);
                            break;
                        case 3:
                            Console.WriteLine("Have a good day!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Introduzca una opcion valida");
                    stopProgram = true;
                }
            } while (option != 3 && stopProgram);
        }
    }
}
