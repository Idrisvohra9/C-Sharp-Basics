using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelu13demo
{
   public interface shap
    {
        void draw();
    }
   public class Rectagle : shap
   {
       public void draw()
       {
           Console.WriteLine("object of Rectangle.");
       }
   }
   public class Square : shap
   {
       public void draw()
       {
           Console.WriteLine("object of Square.");
       }
   }
   public class Circle : shap
   {
       public void draw()
       {
           Console.WriteLine("object of Circle.");
       }
   }
   public class ShapeFactory
   {
       public shap getshap(string s_type)
       {
           if (s_type == "circle")
           {
               return new Circle();

           }
           else if (s_type == "rectangle")
           {
               return new Rectagle();
           }
           else if (s_type == "square")
           {
               return new Square();
           }
           return null;
       }





       //public shap getShape(String s_type)
       //{
       //    if (s_type == "CIRCLE")
       //    {
       //        return new Circle();
       //    }
       //    else if (s_type == "RECTANGLE")
       //    {
       //        return new Rectagle();
       //    }
       //   else if (s_type == "SQUARE")
       //    {
       //        return new Square();
       //    }
       //    return null;
       //}
   }
   class factorydesign
   {
       static void Main(string[] args)
       {
           ShapeFactory sf = new ShapeFactory();
          shap s= sf.getshap("circle");
          s.draw();
          shap s1 = sf.getshap("rectangle");
          s1.draw();
          Console.ReadKey();





         //  ShapeFactory sf = new ShapeFactory();
         //shap s1=sf.getShape("CIRCLE");
         //s1.draw();

         //shap s2 = sf.getShape("RECTANGLE");
         //s2.draw();

         //shap s3 = sf.getShape("SQUARE");
         //s3.draw();
         //Console.ReadKey();
       }
   }
}