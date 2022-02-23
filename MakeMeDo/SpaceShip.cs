using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMeDo {
    class SpaceShip : IFlyable {
        private string _Title;

        public string Title {
            get { return _Title; }
            set { _Title = value; }
        }


        public string Fly() {
            return "Zoom Zoom";
        }

        public string Land() {
            return "Landing gear down";
        }




    }
}
