using System.Globalization; 


namespace MembrosEstaticos
{
    class Program

    {
        static double Pi = 3.14; 
        static void Main(string[] Args)
        {
            
            Console.WriteLine("entre com o vaor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio); 

            Console.WriteLine("Circunfrência: " + circ.ToString("f2", CultureInfo.InvariantCulture));

        }

        static double Circunferencia(double raio)
        {
            return 2 * Pi * raio;
        }
    }
}




