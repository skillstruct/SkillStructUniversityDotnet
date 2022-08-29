using System;
using System.Collections.Generic;
using System.Text;

namespace SkillStructUniversityPortal
{
    class SkillStructUniversityDatabase
    {
        SkillStructUniversityMember skillStructUniversityMember1 = new SkillStructUniversityMember()
        {
            Username = "John Doe", Age = 20, College = "Smith College", Message = "I want to be a SU Member to ensure I have the best chance to success",
            Email = "jd@outlook.com", Phonenumber = "012939030303", Password = "sumember1"
        };
        SkillStructUniversityMember skillStructUniversityMember2 = new SkillStructUniversityMember()
        { 
          Username = "Jane Doe", Age= 30, College="Forrest Gate College", Email ="janed@outlook.com", Message = "I want to join the SU Network to get an opportunity to be mentored by the best in industry",
          Phonenumber = "0239995939493", Password = "sumember2"
        };

        public List<SkillStructUniversityMember> GetSkillStructUniversityMembers()
        {
            List<SkillStructUniversityMember> skillStructUniversityMembers = new List<SkillStructUniversityMember>();

            skillStructUniversityMembers.Add(skillStructUniversityMember1);
            skillStructUniversityMembers.Add(skillStructUniversityMember2);

            return skillStructUniversityMembers;
        }
    }
}
