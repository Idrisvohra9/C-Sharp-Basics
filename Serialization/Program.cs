using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Binary_Serialization
{
[Serializable]
    class Serialization
    {
        public int id;
        public string name;

        public Serialization(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        static void Main(string[] args)
        {
            Serialization s1 = new Serialization(1,"Peaky Boy");
            string path = @"C:\Users\abdev\source\repos\Main\Serial.txt";
            FileStream f1 = new FileStream(path, FileMode.Create);
            
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f1, s1);
            Console.WriteLine("Serialization Success..");
            f1.Close();

            // Deserialization:
            FileStream f2 = new FileStream(path, FileMode.Open);
            BinaryFormatter bff = new BinaryFormatter();
            Serialization s2 = (Serialization)bff.Deserialize(f2);

            Console.WriteLine(" id = {0}\n name = {1}",s2.id,s2.name);
            Console.WriteLine("Deserialization Success..");
            f2.Close();
        }
    }
}
