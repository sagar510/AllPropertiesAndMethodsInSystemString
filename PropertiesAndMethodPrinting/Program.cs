using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethodPrinting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Class Name");
            // Give Input as System.String
            string classname = Console.ReadLine();

            Type type = Type.GetType(classname);

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
                Console.WriteLine(property.PropertyType.Name);
            }


            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                String para = null;
                ParameterInfo[] parameters = method.GetParameters();

                foreach (ParameterInfo param in parameters)
                {
                    para = param.ParameterType+" "+param.Name ;
                }

                Console.WriteLine(method.ReturnType + " "+method.Name+" "+"("+para+")");
            }

            Console.ReadLine();    

        }
    }
}
