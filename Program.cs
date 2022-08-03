namespace UserRegistration_Program
{
    public class Program
    {
        //In this Program validating user input with the regular expression.
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Program");
            UserRegister userRegister = new UserRegister();
            //Validating Last Name
            Console.WriteLine("Enter the Last Name: ");
            string lastname = Console.ReadLine();

            if (userRegister.validateLastName(lastname))
            {
                Console.WriteLine("LastName is valid");
            }
            else
            {
                Console.WriteLine("LastName is not valid");
            }
        }
    }
}