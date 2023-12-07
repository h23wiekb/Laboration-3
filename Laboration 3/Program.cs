namespace Laboration_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
           
         
                Gender gender = Gender.Man;
                Hair hair = new Hair{ Haircolur = "Blond", Hairlength = "Kortklippt" };
                string eyecolor = "Blå";
                DateTime birthday = new DateTime (2002, 5, 1);


                Person person = new Person(gender, hair, eyecolor, birthday);

            Console.WriteLine(person.ToString());

        }
    }
}