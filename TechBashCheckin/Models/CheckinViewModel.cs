using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechBashCheckin.Models
{
    public class CheckinViewModel
    {
        public List<PersonLocation> PersonLocations { get; set; }

        public List<string> Locations { get; set; }

        public CheckinViewModel()
        {
            PersonLocations = new List<PersonLocation>();
            Locations = new List<string>();
        }
    }

    public class PersonLocation
    {
        public Person Person { get; set; }
        public string Location { get; set; }
    }

    public class Person
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        public Person()
        {
        }
    }
}
