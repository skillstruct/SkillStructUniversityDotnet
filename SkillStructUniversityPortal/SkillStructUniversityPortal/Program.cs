using System;
using System.Collections.Generic;
using System.Linq;
namespace SkillStructUniversityPortal
{
    class Program
    {
        static void Main(string[] args)
        {

            SkillStructUniversityDatabase skillStructUniversityDatabase = new SkillStructUniversityDatabase();

            List<SkillStructUniversityMember> skillStructUniversityMembers = new List<SkillStructUniversityMember>();

            IEnumerable<SkillStructUniversityMember> skillStructUniversityMembersAgeFiltered = new List<SkillStructUniversityMember>();

            try
            {


                Console.WriteLine("Welcome to the SkillStruct University! Please enter your credentials...");

                bool userSuccess = false;
                bool userPasswordSuccess = false;

                string email = GetUserEmail();
                string password = GetPassword();

                userSuccess = VerifyUsername(email);


                userPasswordSuccess = VerifyPassword(password);

                if (userSuccess == true && userPasswordSuccess == true)
                {

                    Console.WriteLine("\n*****Welcome User: " + email + " to the SkillStruct platform****\n");

                    skillStructUniversityMembers = skillStructUniversityDatabase.GetSkillStructUniversityMembers();

                    skillStructUniversityMembersAgeFiltered = skillStructUniversityMembers.Where(su => su.Age < 30);

                    foreach (SkillStructUniversityMember skillStructUniversityMember in skillStructUniversityMembersAgeFiltered)
                    {
                        Console.WriteLine(skillStructUniversityMember.Username + " " + skillStructUniversityMember.Age);
                    }

                }

                else
                {
                    Console.WriteLine("There was an issue with your crendentials, please try again...");
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine("There has been this error " + ex.Message);
            }

        }

        static string GetUserEmail()
        {
            Console.WriteLine("Please write below your Email: ");
            string email = Console.ReadLine();
            return email;
        }

        static string GetPassword()
        {
            Console.WriteLine("Please write below your Password: ");
            string password = Console.ReadLine();
            return password;
        }

        static bool VerifyUsername(string email)
        {
            SkillStructUniversityDatabase skillStructUniversityDatabase = new SkillStructUniversityDatabase();

            var members = skillStructUniversityDatabase.GetSkillStructUniversityMembers();

            return members.Any(c => c.Email == email);
        }

        static bool VerifyPassword(string password)
        {
            SkillStructUniversityDatabase skillStructUniversityDatabase = new SkillStructUniversityDatabase();

            var members = skillStructUniversityDatabase.GetSkillStructUniversityMembers();

            return members.Any(c => c.Password == password);
        }

    }
}