using Personf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Police
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly ass = Assembly.LoadFrom(@"C:\Users\Клюкинк\Documents\Visual Studio 2015\GeneratorName.dll");

            Type ts = ass.GetTypes()[2];
            Object exFromAsObj = Activator.CreateInstance(ts);

            MethodInfo GenerateDefault = exFromAsObj.GetType().GetMethod("GenerateDefault");
            object gender = null;
            var enumtype = GenerateDefault.GetParameters()[0];
             if (GenerateDefault.GetParameters()[0].ParameterType.IsEnum)
            {
                gender = Enum.ToObject(GenerateDefault.GetParameters()[0].ParameterType, 0);
            }
            string result = GenerateDefault.Invoke(exFromAsObj, new object[] { gender }).ToString();
           
             result = result.Replace("<center><b><font size=7>", "").Replace("</font></b></center>", "").Replace("\n", "").Substring(1);
            Console.WriteLine(result);

            //foreach (Type item in ts)
            //{
            //    if (item.IsClass && item.Name == "Generator")
            //    {
            //        Console.WriteLine("Name :{0}, ({1})",item.Name,item.FullName);

            //        Object exFromAsObj = Activator.CreateInstance(item);
            //        foreach (MethodInfo m in exFromAsObj.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance))
            //        {
            //            Console.WriteLine(" -> {0} ({1})", m.Name, m.ReturnType);
            //            foreach (ParameterInfo p in m.GetParameters())
            //            {
            //                Console.WriteLine("   |--> {0} ({1})", p.Name, p.ParameterType.BaseType);
            //            }
            //        }


            //        MethodInfo mtDisplay = exFromAsObj.GetType().GetMethod("GenerateDefault");
            //        var result = mtDisplay.Invoke(exFromAsObj, new object[] { });

            //        //MethodInfo mtDoB = exFromAsObj.GetType().GetMethod("DoB");
            //        //object dob = DateTime.Now;
            //        //var result1 = mtDoB.Invoke(exFromAsObj, new object[] { dob });

            //    }
            //}


            //Type myType = typeof(Person);
            //Person p = new Person();
            //p.Age = 22;
            //p.name = "Lon";

            //Type myType2 = p.GetType();
            //Type myType3 = Type.GetType("Police.Person", false, true);

            //foreach (MemberInfo item in myType.GetMembers())
            //{
            //    Console.WriteLine(item.DeclaringType + " " + item.MemberType + " " + item.Name);
            //}
        }
    }

}
