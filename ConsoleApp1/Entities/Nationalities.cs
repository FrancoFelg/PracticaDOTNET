using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class Nationalities
    {
        public int Id { get; set; }
        public String Nationality { get; set; }
        public ICollection<Humans_Nationalities> Humans { get; set; }
    }
}
