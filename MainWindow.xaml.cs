using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mispisit_wpf;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void myButton_Click(object sender, RoutedEventArgs e)
    {
        TextBox textBox = (TextBox)this.FindName("number")!;
        int numb = System.Convert.ToInt16(textBox.Text);
        MessageBox.Show($"Ваше число в 10 степени {Math.Pow(numb, 10)}");
    }

    private void text_updater(object sender, RoutedEventArgs e)
    {
        TextBox textBox = (TextBox)this.FindName("number")!;
        Label myLabel = (Label)this.FindName("myLabel")!;
        myLabel.Content = $"Вы ввели {textBox.Text}";
    }
}