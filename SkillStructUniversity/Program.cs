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

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(college) || string.IsNullOrEmpty(message) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(phonenumber)) 
                {
                    Console.WriteLine("There is an issue with your application, please ensure all fields are correctly filled out...");
                    numberOfAttempts++;

                    //Extract to a function
                    //Can you change this so we use a SkillStructUniversityMember class? Can you refactor?
                    //Switch case Do you want to answer a Survey
                }

                else
                {
                    Console.WriteLine("Congratulations your membership to the SkillStruct University Network has been accepted! Your application will now be processed.");
                    success = true;
                }

            }
        }
    }
}






  private static bool isAgeValid(string age)
        {
            int ageParsed;
            bool result;
            result = int.TryParse(age, out ageParsed);

            if (result && ageParsed >= 18)
            {
                return true;
            }

            else
            {
                return false;
            }
        }