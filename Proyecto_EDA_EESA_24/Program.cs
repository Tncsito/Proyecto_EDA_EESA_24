namespace Proyecto_EDA_EESA_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Lista.Lista a = new Lista.Lista();
            try
            {
                while (true)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("\tMenú Listas");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("1.- Insertar nodo");          //TERMINADO 
                        Console.WriteLine("2.- Imprimir tamaño");        //TERMINADO
                        Console.WriteLine("3.- Buscar nodo");            //
                        Console.WriteLine("4.- Borrar nodo");            //
                        Console.WriteLine("5.- Modificar nodo");         //
                        Console.WriteLine("6.- Buscar Valor");           //
                        Console.WriteLine("7.- Imprimir Lista");         //TERMINADO
                        Console.WriteLine("8.- Salir");         //TERMINADO
                        Console.WriteLine("-------------------------");
                        Console.Write("Seleccionar Opción => ");
                        int opc = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (opc)
                        {
                            case 1:
                                Console.WriteLine("\tMenú Listas");
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("1.- Insertar nodo");
                                Console.WriteLine("Teclear nodo a insertar:");
                                Console.Write("Valor de nodo: ");
                                int uno = int.Parse(Console.ReadLine());
                                a.Add(uno);
                                break;
                            case 2:
                                Console.WriteLine("\tMenú Listas");
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("1.- Insertar nodo");          //TERMINADO 
                                Console.WriteLine("2.- Imprimir tamaño"); 
                                Console.Write("La lista tiene ");
                                a.Count();
                                Console.Write(" nodos");
                                break;
                            case 3:
                                break;
                            case 4:
                                Console.Write("Dame posición: ");
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            case 7:
                                a.Print();
                                break;
                                case 8:
                                return;
                            default:
                                Console.WriteLine("\nPor favor Seleccione una Opción");
                                break;

                        }



                        Console.Write("\n\n\n\n\n\n\t<Presiona cualquier tecla para continuar>");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nElemento no valido (ENTER para continuar)\n");
                        Console.ReadKey();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
