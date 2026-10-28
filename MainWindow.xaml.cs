using System;
using System.Windows;
using System.Windows.Media;

namespace prak6_Vysotskiy;

public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
    }

    private void ChangeTheme_Click(object sender, RoutedEventArgs e)
    {
        ThemeManager.Toggle();
       
    }

}
