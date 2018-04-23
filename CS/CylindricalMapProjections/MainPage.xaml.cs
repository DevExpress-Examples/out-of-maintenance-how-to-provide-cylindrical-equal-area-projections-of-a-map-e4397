

using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Map;

namespace CylindricalMapProjections {
    public partial class MainPage : UserControl {

        public class ProjectionRatios {
            public const double Lambert = 3.14;
            public const double Behrmann = 2.36;
            public const double Edwards = 2.0;
            public const double GallPeters = 1.57;
            public const double Balthasart = 1.3;
        }

        public double imageTileWidth = 330;

        public MainPage() {
            InitializeComponent();
            rbDefault.IsChecked = true;
        }

        public void RadioButton_Default(object sender, RoutedEventArgs e) {
            vectorlayer.InitialMapSize = new Size(imageTileWidth, imageTileWidth);
        }

        public void RadioButton_Lambert(object sender, RoutedEventArgs e) {
            vectorlayer.InitialMapSize = new Size(imageTileWidth * ProjectionRatios.Lambert, imageTileWidth);
        }

        public void RadioButton_Behrmann(object sender, RoutedEventArgs e) {
            vectorlayer.InitialMapSize = new Size(imageTileWidth * ProjectionRatios.Behrmann, imageTileWidth);
        }

        public void RadioButton_Tristan(object sender, RoutedEventArgs e) {
            vectorlayer.InitialMapSize = new Size(imageTileWidth * ProjectionRatios.Edwards, imageTileWidth);
        }

        public void RadioButton_Peters(object sender, RoutedEventArgs e) {
            vectorlayer.InitialMapSize = new Size(imageTileWidth * ProjectionRatios.GallPeters, imageTileWidth);
        }


        public void RadioButton_Balthasart(object sender, RoutedEventArgs e) {
            vectorlayer.InitialMapSize = new Size(imageTileWidth * ProjectionRatios.Balthasart, imageTileWidth);
        }
    }
}
