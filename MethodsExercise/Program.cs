namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hey {name}, it's nice to meet you! What is your favorite color?");
            string favColor = Console.ReadLine();

            Console.WriteLine($"{favColor} is an excellent choice. How about your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"What a coincidence! {favAnimal} happens to be one of my favorites as well. so what's your favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine($"           Name: {name}");
            Console.WriteLine($" Favorite color: {favColor}");
            Console.WriteLine($"Favorite Animal: {favAnimal}");
            Console.WriteLine($"  Favorite Band: {favBand}");

            Console.WriteLine($"In a far away place there once lived a magnificent person known to some as {name}.");
            Console.WriteLine($"{name} was a person you could never get tired of spending time with. They just seemed to be so easy to like");
            Console.WriteLine($"They had eyes as {favColor} as any I'd ever seen...or were they blue? Who knows honestly, I wasn't really paying attention.");
            Console.WriteLine($"Although I can say for certain they had a particular fondess for {favAnimal}. Weird,right?");
            Console.WriteLine($"So it was at that point I lost interest and tried to close the conversation by asking their Favorite band,");
            Console.WriteLine($"and unfortunately their answer was {favBand}. I'm telling you..I gotta stop asking people these boring questions..");





            Console.WriteLine("Type a random number.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type a second number and I will add them together");
            int num2 = int.Parse(Console.ReadLine());

            int addition = sum(num1, num2);

            Console.WriteLine($"{num1} plus {num2} = {addition}");

            Console.WriteLine("Okay so now give me any other number that comes to your head!");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Okay so this time around we will multiply! Give me a second number you'd like to multiply to the first.");
            int num4 = int.Parse(Console.ReadLine());

            int multiplication = multiply(num3, num4);

            Console.WriteLine($"{num3} x {num4} is going to be {multiplication}.");














        }
        public static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        
        public static int multiply(int x, int y)
        {
            return x * y;

        }




    
    
    }

}
