using System.ComponentModel.DataAnnotations;
using CustomValidator;
using Validator = CustomValidator.Validator;



namespace Executable


{
    public class Program
    {
        public static void Main(string[] args)
        {
            Validator validator = new CustomValidator.Validator();
            Person newPerson = new Person();


            Console.WriteLine("Enter the username ");
            newPerson.UserName = Console.ReadLine();
            Console.WriteLine("Enter the password ");
            newPerson.Password = Console.ReadLine();
            Console.WriteLine("Enter the name ");
            newPerson.Name = Console.ReadLine();
            Console.WriteLine("Enter the surname ");
            newPerson.Surname = Console.ReadLine();
            Console.WriteLine("Enter the age ");
            newPerson.Age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter the birthday ");
            newPerson.Birthday = DateTime.Parse(Console.ReadLine());    


            if (validator.ValidateUserName(newPerson.UserName) &&
                validator.ValidatePassword(newPerson.Password) &&
                validator.ValidateName(newPerson.Name) &&
                validator.ValidateSurname(newPerson.Surname) &&
                validator.ValidateAge(newPerson.Age) &&
                validator.ValidateBirthday(newPerson.Birthday))
            {
                Console.WriteLine("Every information is correct");
            }
            else
            {
                Console.WriteLine("The information is incorrect");
            }



        }
    }
}
