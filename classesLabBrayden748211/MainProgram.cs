using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classesLabBrayden748211
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Person ianBrooks = new(1, "Ian", "Brooks", "Red", 30, true);
        
            Person ginaJames = new(2, "Gina", "James", "Green", 18, false);

            Person mikeBriscoe = new(3, "Mike", "Briscoe", "Blue", 45, true);

            Person maryBeals = new(4, "Mary", "Beals", "Yellow", 28, true);

            Console.WriteLine(ginaJames.personId + " " + ginaJames.firstName + " " + ginaJames.lastName + "'s favourite colour is " + ginaJames.favouriteColour);

            Console.WriteLine(mikeBriscoe.ToString());

            ianBrooks.favouriteColour = "White";
            Console.WriteLine(ianBrooks.personId +":" + ianBrooks.firstName + " " + ianBrooks.lastName + "'s favourite colour is: " + ianBrooks.favouriteColour);
            maryBeals.age = maryBeals.age + 10;
            Console.WriteLine(maryBeals.firstName + " " + maryBeals.lastName + " age in 10 years is: " + maryBeals.age);
        }
    }
}
