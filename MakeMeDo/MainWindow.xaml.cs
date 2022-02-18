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


            IFlyable canFly = sup;

            MessageBox.Show(canFly.Fly());

            List<IFlyable> flyables = new List<IFlyable>();
            flyables.Add(sup);
            flyables.Add(new Villian());
            flyables.Add(new SpaceShip());

            

        }
    }
}
