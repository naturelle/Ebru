using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesislerDairesi.Models
{
    public class Joke
    {
        //metod prop tab tab
        public int Id  { get; set; }

        public string JokeQuestion { get; set; }

        public string JokeAnswer { get; set; }

        //constructor, ctor ta tab
        public Joke()
        {

        }
    }
}
