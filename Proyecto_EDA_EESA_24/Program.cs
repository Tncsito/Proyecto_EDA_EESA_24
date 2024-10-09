namespace Proyecto_EDA_EESA_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            try
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\tMenú Listas");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("1.-Insertar nodo");
                    Console.WriteLine("2.-Imprimir tamaño");
                    Console.WriteLine("3.-Buscar nodo");
                    Console.WriteLine("4.-Borrar nodo");
                    Console.WriteLine("5.-Modificar nodo");
                    Console.WriteLine("6.-Buscar Valor");
                    Console.WriteLine("7.-Imprimir Lista");
                    Console.WriteLine("-------------------------");
                    Console.Write("Imprimir tamaño =>");






                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
