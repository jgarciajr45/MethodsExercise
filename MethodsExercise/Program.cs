namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            MadLib();
           
            Console.WriteLine(Add(10, 5));
            Console.WriteLine(Subtract(5, 10));
            Console.WriteLine(Multiply(5, 10));
            Console.WriteLine(Divide(10, 5));
            Console.WriteLine(Modulus(12, 7));
                
        }


        public static void MadLib()
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What's your favorite color");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine($"There's a student by the name of {name}.\nTheir favorite color is {color}.\n" +
                $"Their favorite animal is a {animal} because it's the album art for the cover of their favorite band {band}.");

           

        }

        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public static int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
        public static int Modulus(int number1, int number2)
        {
            return number1 % number2;
        }


    }



}
