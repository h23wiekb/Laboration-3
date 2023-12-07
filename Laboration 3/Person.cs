using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_3
{
    public class Person
    {
        //Properties för de olika klasserna
        public Gender TheGender{ get; private set; }
        public Hair HairStyle { get; private set; }
        public string Eyecolor { get; private set; }
        public DateTime Birthday { get; private set; }

        // Constructor
        public Person(Gender gender,Hair hair,string eyecolor, DateTime birthday)
        { 
      
           TheGender = gender;
           HairStyle = hair;
           Birthday = birthday;
           Eyecolor = eyecolor;

        }

        //Overide ToString Metod
        public override string ToString() 
        {
            return $"\nGender: {TheGender}" +
                $"\nHair: {HairStyle.Hairlength} {HairStyle.Haircolur}" +
                $"\nBirthday: {Birthday:yyyy/MM/dd}" +
                $"\nEyecolor: {Eyecolor}";
            






        }
        
    }
}
