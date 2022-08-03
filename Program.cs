namespace UserRegistration_Program
{
    public class Program
    {
        //In this Program validating user input with the regular expression.
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Program");
            UserRegister userRegister = new UserRegister();
            //Validating PhoneNumber
            Console.WriteLine("Enter the Phone number: ");
            string phone = Console.ReadLine();

            if (userRegister.validatePhoneNum(phone))
            {
                Console.WriteLine("PhoneNumber is valid");
            }
            else
            {
                Console.WriteLine("PhoneNumber is not valid");
            }
        }
    }
}