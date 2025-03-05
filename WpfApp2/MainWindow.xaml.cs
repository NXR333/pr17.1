/* Реализовать расчет задачи: 
• Даны два неотрицательных числа а и в. Найти их среднее геометрическое, то есть квадратный корень из их произведения. 
Дано трехзначное число. Вывести число */


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

namespace WpfApp2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ExitBtn(object sender, RoutedEventArgs e)
    {
        MessageBoxResult result = MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
        if (result == MessageBoxResult.Yes)
        {
            Application.Current.Shutdown();
        }

    }

    private void CalculateBtn(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(ZnA.Text, out double numA) && double.TryParse(ZnB.Text, out double numB))
        {
            double GeometricMean = Math.Sqrt(numA * numB);
            Rez.Text = GeometricMean.ToString();
            ZnA.Text = null;
            ZnB.Text = null;
        }
    }

    private void AboutDevBtn(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Селезнев Никита Денисович\n"+
                        "Группа ИСП-22", "Разработчик");
    }

    private void AboutExBtn(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Условие задачи №1:\n" +
                        "Даны два неотрицательных числа а и в. " +
                        "Найти их среднее геометрическое, то есть квадратный корень из их произведения." +
                        " \r\nДано трехзначное число. Вывести число",
                        "Задача №1", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}