using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MakeMeDo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Superhero sup = new Superhero();
            sup.FirstName = "Mark";
            sup.Identity = "Timmy";


            IFlyable canFly = sup;

            //MessageBox.Show(canFly.Fly());

            List<IFlyable> flyables = new List<IFlyable>();
            flyables.Add(new SpaceShip());
            flyables.Add(sup);
            flyables.Add(new Villian() {FirstName = "Dave" });
            flyables.Add(new Villian() {FirstName = "Hal" });
            flyables.Add(new Villian() {FirstName = "Josey" });
            flyables.Add(new Superhero() {FirstName = "Wanda" });
            flyables.Add(new SpaceShip() {Title = "The Enterprise"});
            //flyables.Add(new Citizen() { FirstName = "Harry" });
            //flyables.Add(new Broom());


            double val1 = 1234.0;

            int val2 = (int)val1;



            string data = "";

            foreach (IFlyable ifly in flyables) {

                Type flyType = ifly.GetType();

                //data += ifly + " says ";
                if (flyType == typeof(Superhero)) {
                    Superhero supHero = (Superhero)ifly;
                    data += supHero.Identity + " yells ";
                }else if (flyType == typeof(Villian)) {
                    Person badGuy = (Villian)ifly;
                    data += badGuy.FirstName + " whisper ";
                } else {
                    data += ((SpaceShip)ifly).Title;
                    data += " says ";
                }
                data += ifly.Fly() + " | " + ifly.Land() + "\n";

            }
            tbOutput.Text = data;



        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            int a = 2 + 2;

            Superhero sup = new Superhero();
            sup.FirstName = "Bruce";

            Citizen cit = new Citizen();
            cit.FirstName = "Carl";

            int b = 2 + 2;

            // shallow
            // deep

            Superhero sup2 = sup + cit;
            Citizen kane = new Citizen();
            kane.FirstName = "Rosebud";
            Superhero sup3 = kane + sup;

            tbOutput.Text = sup.FirstName + " | "
                            + cit.FirstName + " = "
                            + sup2.FirstName + " | "
                            + sup2.Identity;



        }
    }
}
