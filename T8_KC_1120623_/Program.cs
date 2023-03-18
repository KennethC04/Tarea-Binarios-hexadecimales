namespace T8_KC_1120623_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarea Semana 08");
            Console.WriteLine("Alumno: Kenneth Castillo");
            Console.WriteLine("No. Carnet: 1120623");


            //BINARIOS
            Console.WriteLine("Ingrese un número");
            int n = Convert.ToInt32(Console.ReadLine());
            long b = 0;
            long d = 0;

            for (int i = n % 2, j = 0; n > 0; n = n / 2, i = n % 2, j++)
            {
                d = i % 2;
                b = b + d * (long)Math.Pow(10, j);
            }

            Console.WriteLine("EL NÚMERO BINARIO DEL NÚMERO INGRESADO ES: " + b);


            //HEXADECIMALES
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());            
            string hex = numero.ToString("X");        
            Console.WriteLine("El número ingresado es: " + numero);
            Console.WriteLine("Su equivalente en hexadecimal es: " + hex);
        }
    }
}