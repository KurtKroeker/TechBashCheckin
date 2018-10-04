using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBashCheckin.Models;

namespace TechBashCheckin.Storage
{
    public sealed class CheckinStorage
    {
        private static CheckinStorage instance = null;
        private static readonly object padlock = new object();

        public List<PersonLocation> PersonLocations { get; set; }
        public List<string> Locations { get; set; }

        CheckinStorage()
        {
            PersonLocations = new List<PersonLocation> {
                    new PersonLocation { Person = new Person { ID = 1, FullName = "Kurt Kroeker" }, Location = "Other" },
                    new PersonLocation { Person = new Person { ID = 2, FullName = "Vance Hensler" }, Location = "Other" },
                    new PersonLocation { Person = new Person { ID = 3, FullName = "David Ulmer" }, Location = "Other" },
                    new PersonLocation { Person = new Person { ID = 4, FullName = "Chris Houdeshell" }, Location = "Other" },
                    new PersonLocation { Person = new Person { ID = 5, FullName = "Tim Schafer" }, Location = "Other" },
                    new PersonLocation { Person = new Person { ID = 6, FullName = "Raja Janagama" }, Location = "Other" },
                    new PersonLocation { Person = new Person { ID = 7, FullName = "Samata Prabhu" }, Location = "Other" },
                    new PersonLocation { Person = new Person { ID = 8, FullName = "Tim Marte" }, Location = "Other" },
                    new PersonLocation { Person = new Person { ID = 9, FullName = "Stephen Clewell" }, Location = "Other" },
                    new PersonLocation { Person = new Person { ID = 10, FullName = "Jared Gibson" }, Location = "Other" },
                    new PersonLocation { Person = new Person { ID = 11, FullName = "Luke Fraenza" }, Location = "Other" },
                    new PersonLocation { Person = new Person { ID = 12, FullName = "Zac O'Donnell" }, Location = "Other" },
                };

            Locations = new List<string> {
                "Salon E",
                "Ironwood",
                "Rosewood",
                "River Rooms",
                "Water Park",
                "Other"
            };
        }

        public static CheckinStorage Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new CheckinStorage();
                    }
                    return instance;
                }
            }
        }
    }
}
