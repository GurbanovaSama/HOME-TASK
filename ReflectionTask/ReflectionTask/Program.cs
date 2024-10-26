using ReflectionTask.Models;
using System.Reflection;

namespace ReflectionTask

{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            User user = new(5, "Sama", "Gurbanova"); 
            Type userType = typeof(User);

            FieldInfo idField = userType.GetField("id", BindingFlags.Instance | BindingFlags.NonPublic);
            idField.SetValue(user, 5);

            FieldInfo nameField = userType.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance);
            nameField.SetValue(user, "Sama");

            FieldInfo surnameField = userType.GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance);
            surnameField.SetValue(user, "Gurbanova");


            user.GetFullName();

            User.ChangeAge(19);
            Console.WriteLine($"Age: {User.GetAge()}");

            User.ChangeAge(20);
            Console.WriteLine($"Modified Age: {User.GetAge()}");

            Console.WriteLine(user.ToString());

 
        }
    }
}
