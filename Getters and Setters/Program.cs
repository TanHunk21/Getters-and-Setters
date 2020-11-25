using System;

namespace Getters_and_Setters
{
    class Program
    {
        class person
        {
             string name;
             int age;
             string gender;
             string idCode;

            public person(string _name, string _gender, int _age, string _idCode)
            {
                name = _name;
                Gender = _gender;
                age = _age;
                idCode = _idCode;
            }
            public string Name
            {
                get { return name; }
                
                
                    
                
            }
            public string Gender
            {
                get { return gender; }
                set
                {
                    if(value =="Male"|| value == "Female")
                    {
                        gender = value;
                    }else
                    {
                        gender = "underfined thing";
                    }
                }
            }
            
            public string IdCode
        {
            get { return idCode; }
            set
            {
                if(value.Length == 11)
                {
                    idCode = value;
                }else
                {
                    idCode = "underfined (yours truly Mr.Knuckles)";
                }
            }
        }
            public void ChangeName(string newName)
            {
                name = newName;
            }

        }
        

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            person newPerson = new person("Flap Jack","Table",25,"35467893213456");
            Console.WriteLine(newPerson.Name);
            Console.WriteLine(newPerson.Gender);
            Console.WriteLine(newPerson.IdCode);

            newPerson.ChangeName("Scooby");
            Console.WriteLine(newPerson.Name);
            //Console.WriteLine(newPerson.age);
            //newPerson.name = "Mr.krabs";
            //newPerson.gender = "Helicopter";
            //newPerson.age = 25;
            //Console.WriteLine(newPerson.name);
            //Console.WriteLine(newPerson.age);
            //Console.WriteLine(newPerson.gender);
            //Console.WriteLine(newPerson.Gender);


        }
    }
}
