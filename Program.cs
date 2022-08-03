namespace UserRegistration_Program
{
    public class Program
    {
        //In this Program validating user input with the regular expression.
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Program");
            UserRegister userRegister = new UserRegister();
            //Validating Email
            Console.WriteLine("Enter the Email: ");
            string email = Console.ReadLine();

            if (userRegister.validateEmail(email))
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Email is not valid");
            }
        }
    }
}