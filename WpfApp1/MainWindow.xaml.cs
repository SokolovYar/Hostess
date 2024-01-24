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
//using System.Windows.Shapes;
using System.Windows.Xps.Packaging;
using System.Windows.Markup;

namespace WpfApp1
{
    


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            /*
            // сохранение в XAML рецепта
            try
            {
                // Создание XamlWriter для сериализации FlowDocument в XAML
                string xamlString = XamlWriter.Save(flowDocReader.Document);

                // Сохранение XAML в файл
                File.WriteAllText("C:\\2.xaml", xamlString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных в файл: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            */

            //загрузить из файла
            try
            {
                // Чтение XAML из файла
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Recipe");
                filePath += (listRecipes.SelectedIndex).ToString() + ".xaml";
                string xamlString = File.ReadAllText(filePath);

                // Загрузка XAML в FlowDocument
                FlowDocument ? flowDocument = XamlReader.Parse(xamlString) as FlowDocument;

                // Установка загруженного FlowDocument в FlowDocumentReader
                flowDocReader.Document = flowDocument;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных из файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }





  



}
