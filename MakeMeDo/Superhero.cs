using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMeDo {
    class Superhero : Person, IFlyable {

        private string _Identity;

        public string Identity {
            get { return _Identity; }
            set { _Identity = value; }
        }

        public override string Shout() {
            return "Yay";
        }

        public override string ToString() {
            return "Super " + base.ToString();
        }

        public string Fly() {
            return "Up up and Away";
        }

        public string Land() {
            return "I hits the ground";
        }

        public static Superhero operator +(Superhero h, Citizen c) {
            // shallow copy
            h.Identity = c.FirstName;
            return h;
        }

        public static Superhero operator +( Citizen c , Superhero h) {
            // deep copy -- cloning
            Superhero newSup = new Superhero();
            newSup.FirstName = h.FirstName;
            newSup.LastName = h.LastName;
            newSup.DateOfBirth = h.DateOfBirth;
            newSup.FavoriteFood = h.FavoriteFood;
            newSup.Identity = c.FirstName;

            return newSup;
        }
    }
}
