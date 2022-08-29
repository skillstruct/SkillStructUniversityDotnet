using System;

namespace SkillStructUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string message;
            string email;
            string college;
            string age;
            string phonenumber;
            int numberOfAttempts = 0;
            bool success = false;

            Console.WriteLine("Welcome to the SkillStruct University Sign-up Console");

            while (numberOfAttempts <= 3 && !success)
            {
                Console.WriteLine("Please enter your username");
                username = Console.ReadLine();

                Console.WriteLine("Please enter your email");
                email = Console.ReadLine();

                Console.WriteLine("Please enter your college");
                college = Console.ReadLine();

                Console.WriteLine("Please enter your message");
                message = Console.ReadLine();

                Console.WriteLine("Please enter your age");
                age = Console.ReadLine();

                Console.WriteLine("Please enter your phonenumber");
                phonenumber = Console.ReadLine();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(college) || string.IsNullOrEmpty(message) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(phonenumber) || IsAgeValid(age) == false)
                {
                    Console.WriteLine("There is an issue with your application, please ensure all fields are filled out correctly...");
                    numberOfAttempts++;
                    
                }


                else
                {
                    Console.WriteLine("Congrats, you are now a member of the SkillStruct University Network. Your application will now be processed!");
                    success = true;
                }
                

            }
        }

        static bool IsAgeValid(string age)
        {
            int ageParsed;
            bool result;

            result = int.TryParse(age, out ageParsed);

            if (result && ageParsed >=18)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}
