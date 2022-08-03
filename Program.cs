namespace UserRegistration_Program
{
    public class Program
    {
        //In this Program validating user input with the regular expression.
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Program");
            UserRegister userRegister = new UserRegister();

            //Validating Password 
            Console.WriteLine("Enter the Password: ");
            string password = Console.ReadLine();

            if (userRegister.validatePassword(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is not valid");
            }
        }
    }
}