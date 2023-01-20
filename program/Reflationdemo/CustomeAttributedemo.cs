using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class|AttributeTargets.Method,AllowMultiple=true)]
public class myclass :Attribute
{
    public string Action;
    public string dec;
    public myclass(string action, string desc)
    {
        Action = action;
        dec = desc;
    }
    public string Action_1 {
        get
        {
            return Action;
        }
    }
    public string desc_1
    {
        get
        {
            return dec;
        }
    }
    public myclass()
    {

    }
    public static void  Attributeset(Type t)
    {
        Console.WriteLine(t.Name);
        MethodInfo[] method = t.GetMethods();
        foreach (var item in method)
        {
           object [] attribute= item.GetCustomAttributes(true);
           foreach (Attribute A in attribute)
           {
               if (A is myclass)
               {

                   myclass mc =(myclass) A;
                   Console.WriteLine("Method name : " + item.Name);
                   Console.WriteLine("Action Msg  : " +mc.Action);
                   Console.WriteLine("decription Msg : " + mc.dec);
                   Console.WriteLine();
                   Console.WriteLine();
               }
           }
            Console.WriteLine("MEthod = "+item);
        }
    }   
}

class student
{
    public int rno;
    public string name;
   [myclass("Modifier","set student rno and name")]
    public void setdetail(int r, string n)
    {
        rno = r;
        name = n;
    }
    [myclass("Accesser","get student rno")]
    public int  getrno()
    {
        return (rno);
    }
    [myclass("Accesser", "get student Name")]
    public string getname()
    {
        return (name);
    }
}
[myclass]
public class CustomeAttributedemo
{
    
    static void Main(string[] args)
    {
        student s = new student();
        s.setdetail(101, "kajal");
        Console.WriteLine(s.getrno());
        Console.WriteLine(s.getname());
        myclass.Attributeset(typeof(student));
        
        Console.ReadKey();
    }
}