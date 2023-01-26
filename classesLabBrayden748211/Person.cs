using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesLabBrayden748211
{
    class Person
    {
        // Fields
        public int personId;
        public string firstName;
        public string lastName;
        public string favouriteColour;
        public int age;
        public bool isWorking;

        public Person(int argPersonId, string argFirstName, string argLastName, string argFavouriteColour, int argAge, bool argIsWorking) 
        {
            this.personId = argPersonId;
            this.firstName = argFirstName;
            this.lastName = argLastName;
            this.favouriteColour = argFavouriteColour;
            this.age = argAge;
            this.isWorking = argIsWorking;
        }
        public override string ToString()
        {
            return string.Format("PersonId : {0} \nFirstName : {1} \nLastName : {2} \nFavoriteColour : {3} \nAge : {4} \nIsWorking : {5}", personId, firstName, lastName, favouriteColour, age, isWorking);
        }
    }
}
