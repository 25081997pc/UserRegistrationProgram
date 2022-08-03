namespace UserRegistration_Program
{
    public class Program
    {
        //In this Program validating user input with the regular expression.
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Program");
            UserRegister userRegister = new UserRegister();
            Console.WriteLine("Enter the First Name: ");
            string firstname = Console.ReadLine();

            if (userRegister.validateFirstName(firstname))
            {
                Console.WriteLine("Pattern Match");
            }
            else
            {
                Console.WriteLine("Pattern not Match");
            }
        }
    }
}