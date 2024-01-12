namespace Sort
{
    class Program
    {
        static void Main()
        {
            List<int> listaDeEnteros = new List<int>();
            listaDeEnteros = LlenaArreglo();

            List<int> resultado = OrdenaArreglo(listaDeEnteros);

            Console.WriteLine("Resultado:");
            foreach (int elemento in resultado)
            {
                Console.WriteLine(elemento);
            }
            Console.ReadLine();
        }
        static List<int> OrdenaArreglo(List<int> arreglo)
        {
            arreglo.Sort();
            return arreglo;
        }
        private static List<int> LlenaArreglo()
        {
            int numeroIngresado;
            int longitudArreglo;
            List<int> lista = new List<int>();

            longitudArreglo = PideEntero("Ingrese la longitud del arreglo");

            Console.WriteLine("Comience a ingresar los valores del arreglo");
            for (int i = 0; i < longitudArreglo; i++)
            {
                numeroIngresado = PideEntero($"Ingrese un número entero X[{i}]:");
                lista.Add(numeroIngresado);
            }

            return lista;
        }
        private static int PideEntero(string mensaje)
        {
            int numero;
            Console.WriteLine(mensaje);
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("El número ingresado no es un entero valido! Ingrese un entero válido:");
            }

            return numero;
        }
    }
}