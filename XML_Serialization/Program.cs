using System;
using System.IO;
using System.Xml.Serialization;

namespace XML_Serialization
{
    [Serializable]
    public class Xml_Serialize
    {
        public int id;
        public string name;

        public Xml_Serialize()
        {

        }

        public Xml_Serialize(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        static void Main(string[] args)
        {

            //Xml_Serialize emp = new Xml_Serialize(2,"Peaky girl");

            string path = @"C:\Users\abdev\source\repos\Main\xml.txt";
            //// 
            //XmlSerializer x1 = new XmlSerializer(typeof(Xml_Serialize));

            //TextWriter w = new StreamWriter(path);
            //x1.Serialize(w, emp);
            //w.Close();
            //Console.WriteLine("Suck it");


            XmlSerializer x2 = new XmlSerializer(typeof(Xml_Serialize));

            TextReader r = new StreamReader(path);

            Xml_Serialize emp1 = (Xml_Serialize)x2.Deserialize(r);
            r.Close();
            Console.WriteLine("id = {0}\nName = {1}",emp1.id, emp1.name);
            Console.WriteLine("idris peaky boy.");
            Console.ReadKey();
        }
    }
}
