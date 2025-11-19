using  ConsoleApp4;


            Calculator calculator = new Calculator();
            Console.WriteLine("Sum Example:");
            Console.WriteLine($"5 + 7 = {calculator.Sum(5, 7)}");

            Console.WriteLine("\nLogin Example:");
            Console.Write("Enter User ID: ");
            string uid = Console.ReadLine();

            Console.Write("Enter Password: ");
            string pwd = Console.ReadLine();

            bool loginSuccess = AuthService.Login(uid, pwd);

            Console.WriteLine(loginSuccess ? "Login Successful" : "Login Failed");


            Console.ReadLine();
 