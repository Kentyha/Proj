using System;
using System.IO;
using System.Runtime.Serialization.XmlObjectSerializer;

namespace Proj
{
    class Program
    {
        string jsonPath;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            jsonPath = @"..\..\Students.json";
            List<Student> ls = new List<Student>();
            Student p1 = new Student()
            {
                Name = "Taras",
                Age = 12
            };
            ls.Add(p1);
            StreamWriter ms = new StreamWriter(jsonPath);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Student>));
            ser.WriteObject(ms, ls);
        }
    }
    [DataContract]
    class Student
    {
        [DataMember]
        public string Name {get;set;}
        [DataMember]
        public int Age {get;set;}
    }
}
