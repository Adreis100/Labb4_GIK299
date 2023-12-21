using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    public class Person
    {
        //Egenskaper 
        public Gender Gender { get; private set; }
        public Hair Hair { get; private set; }
        public string Birthday { get; private set; }
        public string Eyecolor { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public List<string> person { get; private set; }



        // Constructor 

        public Person(Gender gender, Hair hair, string birthday, string eyecolor, string firstname, string lastname)
        {
            Gender = gender;
            Hair = hair;
            Birthday = birthday;
            Eyecolor = eyecolor;
            Firstname = firstname;
            Lastname = lastname;
        }

        public override string ToString()
        {
            return
            $"\nGender: {Gender} " +
            $"\nHair: {Hair.HairLenght}, {Hair.HairColor}" +
            $"\nBirthday: {Birthday:yyyy/MM/dd} " +
            $"\nEyecolor: {Eyecolor} " +
            $"\nFirstname: {Firstname} " +
            $"\nLastname: {Lastname}";


        }
    }
}

