namespace OLTasks
{
    public class Tasks
    {

        // ---Task #1
        public void Login()
        {
            string expectedUsername = "myUsername";
            string expectedPassword = "myPassword";
            int maxAttempts = 5;
            int attemptCount = 0;

            while (attemptCount < maxAttempts)
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (username == expectedUsername && password == expectedPassword)
                {
                    Console.WriteLine("Login successful. Welcome, {0}!", username);
                }
                else
                {
                    Console.WriteLine("Invalid username or password. Please try again.");
                    attemptCount++;
                }
            }

            Console.WriteLine("Maximum login attempts reached. Please contact support.");
        }


        //--- Task #2
        public void NumberToBinery()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine() ??
                throw new ArgumentNullException("Incorrect number"));

            string binary = Convert.ToString(number, 2);

            Console.WriteLine("Binary format: {0}", binary);
        }


        // --- Task#3 

        // Calculate Area
        public void Calculate(double length, double width)
        {
            var area = length * width;
            Console.WriteLine($"Area={area}");
        }
        // Calculate Volume
        public void Calculate(double length, double width, double height)
        {
            var volume = length * width * height;
            Console.WriteLine($"Volume={volume}");
        }
    }
}
