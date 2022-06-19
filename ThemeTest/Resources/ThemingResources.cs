using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ThemeTest.Resources
{
    public static class ThemingResources
    {
        public static readonly Uri SquaredThemeResourcesFileUri = new Uri("pack://application:,,,/MyProject;component/Resources/SquaredTheme.xaml");
        public static readonly Uri RoundThemeResourcesFileUri = new Uri("pack://application:,,,/MyProject;component/Resources/RoundTheme.xaml");

        public static ComponentResourceKey ButtonBackgroundBrushKey = new ComponentResourceKey(typeof(ComponentResourceKey), "ButtonBackgroundBrushKey");
        public static ComponentResourceKey ButtonBackgroundColorKey = new ComponentResourceKey(typeof(ComponentResourceKey), "ButtonBackgroundColorKey");
        public static ComponentResourceKey ButtonCornerRadiusKey = new ComponentResourceKey(typeof(ComponentResourceKey), "ButtonCornerRadiusKey");
    }
}

// Note: CHnaged 'ThemeResourceKeys' to 'ComponentResourceKey'
