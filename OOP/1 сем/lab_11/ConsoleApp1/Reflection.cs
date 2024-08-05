using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ConsoleApp1
{
    public static class Reflector<T>
    {
        static Type? type = typeof(T);
      

        public static string GetAssembly()
        {

            Assembly assembly = Assembly.GetAssembly(type);

            return assembly.FullName;
        }
        public static bool IsHasPublicCtors() 
        {

            MethodInfo[] typeMethods = type.GetMethods();

            foreach(MethodInfo method in typeMethods)
            {
                if(method.IsConstructor &&  method.IsPublic)
                {
                    return true;
                }
            }

            return false;
        }
        public static IEnumerable<string> GetPublicMethods()
        {
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            return methods.Select(methos => methos.Name);
        }
        public static (IEnumerable<string>, IEnumerable<string>) GetFieldAndProperty()
        {
            FieldInfo[] field = type.GetFields(); 
            PropertyInfo[] Property = type.GetProperties();
            return (Property.Select(methods=>methods.Name),field.Select(field=>field.Name));
        }
        public static IEnumerable<string> GetInterface()
        {
            Type[] interfaces = type.GetInterfaces();
            return interfaces.Select(iface => iface.Name);
        } 

    }
}
