using System;
using System.Collections.Generic;
using System.IO;
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
using UploadImage.Entities;

namespace UploadImage
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ImportImage();
        }

        private void ImportImage()
        {
            var images = Directory.GetFiles(@"C:\Users\user\Source\Repos\image");
            var image = COMP_FIRMEntities.GetContext().ComponentsImage.ToArray();


            try
            {
                for (int i = 0; i < image.Length; i++)
                {
                    image[i].Image = File.ReadAllBytes(images.FirstOrDefault(p => p.Contains(image[0].id.ToString())));
                    COMP_FIRMEntities.GetContext().SaveChanges();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
