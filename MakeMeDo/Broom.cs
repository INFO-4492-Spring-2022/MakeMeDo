using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMeDo {
    class Broom : IFlyable {
        public string Fly() {
            return "Swoosh";
        }

        public string Land() {
            return "Screeeeech";
        }
    }
}
