using System.Collections.Generic;

namespace UsefulMethods
{
    public class Data
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Genders Gender { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }
        public double Experience { get; set; }

        public List<Data> GetData()
        {
            return new List<Data>
            {
                new Data{Name="Samir", Age=25, Gender = Genders.Male, Profession = "developer", Salary= 35000,  Experience=5},
                new Data{Name="Jan", Age=30, Gender = Genders.Male, Profession = "Designer", Salary= 38000,Experience=8},
                new Data{Name="Hanna", Age=23, Gender = Genders.Female, Profession = "Tester", Salary= 32000, Experience=4},
                new Data{Name="David", Age=29, Gender = Genders.Male, Profession = "developer", Salary= 36000, Experience=6},
                new Data{Name="Mike", Age=25, Gender = Genders.Male, Profession = "Designer", Salary= 35000, Experience=5},
                new Data{Name="Ali", Age=34, Gender = Genders.Male, Profession = "Tester", Salary= 40000, Experience=9},
                new Data{Name="Musse", Age=44, Gender = Genders.Male, Profession = "Manager", Salary= 45000,Experience=14},
                new Data{Name="Emma", Age=37, Gender = Genders.Female, Profession = "Designer", Salary= 38000, Experience=8},
                new Data{Name="Angela", Age=32, Gender = Genders.Female, Profession = "Scrum master", Salary= 48000, Experience=15},
            };

        }

        public enum Genders
        {
            Male,
            Female
        }
    }
}
