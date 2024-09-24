using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class Human
    {

        //acceso tipoDato nombreDato {get; set;}
        public string Name;//{ get; set; }
        public string LastName;//{ get; set; }
        public int Age;//{ get; set; }
        public int Height { get; set; }
        public ICollection<Pet> Pets { get; set; }
        public ICollection<Humans_Nationalities> Nationalities { get; set; }

        //Constructor Vacío
        public Human()
        {
        }

        //Constructor Completo o por Parámetros
        public Human(string name, string lastName, int age, int height)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Height = height;
        }

    }

}

