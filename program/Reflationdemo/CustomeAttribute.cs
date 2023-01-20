using System;
using System.Reflection;
namespace Reflationdemo
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class sampleAttribute : Attribute
    {
        string action;
        string name;
        public string Action
        {
            get
            {
                return action;
            }

        }
        public string Name
        {
            get
            {
                return name;
            }

        }
        public sampleAttribute(string action, string nm)
        {
            this.action = action;
            this.name = nm;

        }
        public sampleAttribute()
        {

        }
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Methods of class {0}", classType.Name);
            MethodInfo[] methods = classType.GetMethods();
            foreach (var item in methods)
            {
                object[] attributesArray = item.GetCustomAttributes(true);
                foreach (Attribute A in attributesArray)
                {
                    if (A is sampleAttribute)
                    {

                        // Display the fields of the NewAttribute
                        sampleAttribute attributeObject = (sampleAttribute)A;
                        Console.WriteLine("{0} - {1}, {2} ", item.Name,
                         attributeObject.Action, attributeObject.name);
                    }
                }
            }
        }
    }

    class myclass
    {
        private int rollNo;
        private string stuName;
        private double marks;
        [sampleAttribute("Modifier", "Assigns the Student Details")]
        public void setDetails(int r, string sn, double m)
        {
            rollNo = r;
            stuName = sn;
            marks = m;
        }
        [sampleAttribute("Accessor", "Returns Value of rollNo")]
        public int getRollNo()
        {
            return rollNo;
        }
        [sampleAttribute("Accessor", "Returns Value of stuName")]
        public string getStuName()
        {
            return stuName;
        }


    }
        class CustomeAttribute
        {
            static void Main(string[] args)
            {

                myclass s = new myclass();
                s.setDetails(1, "kajal", 12.3);
                Console.WriteLine(s.getRollNo());
                Console.WriteLine(s.getStuName());
                sampleAttribute.AttributeDisplay(typeof(myclass));
                Console.ReadKey();
            }
        }
    }
