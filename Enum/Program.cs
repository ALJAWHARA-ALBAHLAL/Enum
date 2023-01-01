using System;

namespace Enums
{

    public enum Gender //توحيد الفاريبلز // more readable and mantainable
    {
        Female, //value 0 , name Female
        Male // value 1 , name Male
    }//by default the underlying data type is int 0 , 1 but we can costomized
    //store enum to enum must conversion before
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; } // From class enum
    }

    class Program // where is our main
    {
        static void Main(string[] args)
        {
            // we can use methods in Enum class like Enum.GetNames and GetValue  
            int[] values  = (int[])Enum.GetValues(typeof(Gender));
            string[] names = (string[])Enum.GetNames(typeof(Gender));

            foreach(string name in names) { 
            Console.WriteLine(name);
                Console.ReadLine(); 
            }
            foreach (int value in values)
            {
                Console.WriteLine(value);
                Console.ReadLine(); // to go to a new line 
            }

            Employee[] employees = new Employee[2]; // instance of class employee
            employees[0] = new Employee
            {
                Name = "Aljawhara",
                Gender = Gender.Female
            };
            employees[1] = new Employee
            {
                Name = "Saud",
                Gender = Gender.Male
            };

            foreach (Employee e in employees)
            {
                Console.WriteLine(e.Name);
                Console.WriteLine(getGender(e.Gender));
            }
        }

        public static string getGender(Gender gender) // switch to send the gender that been called in foreach
        {
            switch (gender)
            {
                case Gender.Female:
                    return "Female";
                case Gender.Male:
                    return "Male";
                default:
                    return "Invalid data";
            }
    }
    }
}


