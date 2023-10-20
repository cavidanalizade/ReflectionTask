using System;
using System.Reflection;

namespace ReflectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Type userType = typeof(User);
            object userInstance = Activator.CreateInstance(userType);
            FieldInfo nameProperty = userType.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance );
            nameProperty.SetValue(userInstance, "Javidan");
            FieldInfo surnameProperty = userType.GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance);
            surnameProperty.SetValue(userInstance, "Alizada");
            FieldInfo ageField = userType.GetField("age", BindingFlags.NonPublic | BindingFlags.Static);
            ageField.SetValue(userInstance, 19);

            string userName = (string)nameProperty.GetValue(userInstance);
            string userSurname = (string)surnameProperty.GetValue(userInstance);
            int userAge = (int)ageField.GetValue(userInstance);


             
            Console.WriteLine("Name: " + userName);
            Console.WriteLine("Surname: " + userSurname);
            Console.WriteLine("Age: "+ userAge);

            MethodInfo AgeMethodInfo = userType.GetMethod("ChangeAge", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = new object[] {(byte)35 };

            AgeMethodInfo.Invoke(userInstance, parameters);

















        }
    }
}
