namespace MethodsDemoCSharp_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Use the method in the main (calling the method)
            GreetPerson("Seth");
            GreetPerson("Mack");

            int twoPlusTwo = Add(2, 2);
            Console.WriteLine(twoPlusTwo);

            GreetByName();           
        }


        //Method definition (creating a method)
        //Parts of a method
        //Disregard the keyword "static" until we get to that lesson
        //Methods use Pascal casing for the naming
        //Access modifier - Return type - Name - Parameter list - Scope (body)
        public static void GreetPerson(string name)
        {
            Console.WriteLine($"Hey, {name}!");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void GreetByName()
        {
            Console.WriteLine("Give me your name:");

            string name = Console.ReadLine();

            Console.WriteLine($"Hey, {name}!");
        }
      
    }
}