using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMeDo {
    class Citizen : Person {
        private string _Job;

        public string Job {
            get { return _Job; }
            set { _Job = value; }
        }
    }
}
