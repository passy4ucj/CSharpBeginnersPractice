using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    //class to practice list field
    public class MentorsToBePaid
    {
        public List<Mentor> Mentors = new List<Mentor>();
    }
    public class Mentor : Common
    {
        public int YearsOfExperience { get; set; }
        public string Category { get; set; }
    }
    public class Students : Common
    {
        public int RegistrationNo { get; set; }
    }
    public class Common
    {
        public string Name { get; set; }
        public bool RegisteredOnZoom { get; set; }
        public string Location { get; set; }
    }
}
