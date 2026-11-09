namespace Parcial_3___Parte_1
{
    // 1. CLASE ABSTRACTA
    public abstract class Figura
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }

    // 2. CLASES DERIVADAS
    public class Rectangulo : Figura
    {
        public double Base { get; }
        public double Altura { get; }

        public Rectangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }

    public class Cuadrado : Figura
    {
        public double Lado { get; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }

    public class Triangulo : Figura
    {
        public double LadoA { get; }
        public double LadoB { get; }
        public double LadoC { get; }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        // Área mediante la fórmula de Herón
        public override double CalcularArea()
        {
            double s = CalcularPerimetro() / 2;
            return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
        }

        public override double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }
    }

    // Clase principal
    public class Program
    {
        public static void Main(string[] args)
        {
            // 3. ARREGLO UNIDIMENSIONAL de tipo padre (Figura[]):
            Figura[] figuras = new Figura[]
            {
                new Rectangulo(5, 3),
                new Cuadrado(4),
                new Triangulo(3, 4, 5),
                new Rectangulo(10, 2.5),
                new Cuadrado(7)
            };

            Console.WriteLine("=== FIGURAS GEOMÉTRICAS (POLIMORFISMO) ===\n");

            // 4. RECORRIDO POLIMÓRFICO
            for (int i = 0; i < figuras.Length; i++)
            {
                Figura f = figuras[i];
                Console.WriteLine($"Figura #{i + 1}");
                Console.WriteLine($"  Clase:     {f.GetType().Name}");
                Console.WriteLine($"  Área:      {f.CalcularArea():F2}");
                Console.WriteLine($"  Perímetro: {f.CalcularPerimetro():F2}");
                Console.WriteLine();
            }

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
