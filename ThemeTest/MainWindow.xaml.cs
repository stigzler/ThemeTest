using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using ThemeTest.Resources;

namespace ThemeTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

  

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Collection<ResourceDictionary> mergedApplicationDictionaries = Application.Current.Resources.MergedDictionaries;
            for (int resourceIndex = 0; resourceIndex < mergedApplicationDictionaries.Count; resourceIndex++)
            {
                ResourceDictionary resourceDictionary = mergedApplicationDictionaries[resourceIndex];

                // Identify the current active theme file (resource dictionary)
                if (resourceDictionary.Source == ThemingResources.SquaredThemeResourcesFileUri)
                {
                    // Remove the current active theme file (resource dictionary)...
                    mergedApplicationDictionaries.RemoveAt(resourceIndex);

                    // ... to replace it with the one for the rounded theme
                    var roundThemeDictionary = new ResourceDictionary() { Source = ThemingResources.RoundThemeResourcesFileUri };
                    mergedApplicationDictionaries.Add(roundThemeDictionary);

                    return;
                }
            }
        }
    }
}
