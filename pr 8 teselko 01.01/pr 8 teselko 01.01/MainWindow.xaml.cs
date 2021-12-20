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

namespace pr_8_teselko_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Pair firstPair = new();
        Pair secondPair = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double fpFirst = Int32.Parse(inputFpFirst.Text);
                double fpSecond = Int32.Parse(inputFpSecond.Text);
                firstPair = new(fpFirst, fpSecond);
                double spFirst = Int32.Parse(inputSpFirst.Text);
                double spSecond = Int32.Parse(inputSpSecond.Text);
                secondPair = new(spFirst, spSecond);
                Pair result = firstPair.Addition(secondPair);
                MessageBox.Show($"В результате сложения получилась пара чисел: {result.First}  {result.Second}");
            }
            catch
            {

                MessageBox.Show("Проверьте введенные значения", "Ошибка");
            }
        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double fpFirst = Int32.Parse(inputFpFirst.Text);
                double fpSecond = Int32.Parse(inputFpSecond.Text);
                firstPair = new(fpFirst, fpSecond);
                double spFirst = Int32.Parse(inputSpFirst.Text);
                double spSecond = Int32.Parse(inputSpSecond.Text);
                secondPair = new(spFirst, spSecond);
                Pair result = firstPair.Subtraction(secondPair);
                MessageBox.Show($"В результате вычитания получилась пара чисел: {result.First}  {result.Second}");
            }
            catch
            {

                MessageBox.Show("Проверьте введенные значения", "Ошибка");
            }
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double fpFirst = Int32.Parse(inputFpFirst.Text);
                double fpSecond = Int32.Parse(inputFpSecond.Text);
                firstPair = new(fpFirst, fpSecond);
                double spFirst = Int32.Parse(inputSpFirst.Text);
                double spSecond = Int32.Parse(inputSpSecond.Text);
                secondPair = new(spFirst, spSecond);
                Pair result = firstPair.Multiplication(secondPair);
                MessageBox.Show($"В результате умножения получилась пара чисел: {result.First}  {result.Second}");
            }
            catch
            {

                MessageBox.Show("Проверьте введенные значения", "Ошибка");
            }
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double fpFirst = Int32.Parse(inputFpFirst.Text);
                double fpSecond = Int32.Parse(inputFpSecond.Text);
                firstPair = new(fpFirst, fpSecond);
                double spFirst = Int32.Parse(inputSpFirst.Text);
                double spSecond = Int32.Parse(inputSpSecond.Text);
                secondPair = new(spFirst, spSecond);
                Pair result = firstPair.Division(secondPair);
                MessageBox.Show($"В результате деления получилась пара чисел: {result.First}  {result.Second}");
            }
            catch
            {

                MessageBox.Show("Проверьте введенные значения", "Ошибка");
            }
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №8\n" +
                "Теселько Максим ИСП-34\n" +
                "Создать интерфейс – арифметические операции (+, -, *, /). Создать класс пара чисел. Класс должен включать конструктор, " +
                "функцию для формирования строки с арифметической операцией. Сравнение производить по парам чисел.", "О программе", MessageBoxButton.OK);
        } 

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void compare_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double fpFirst = Int32.Parse(inputFpFirst.Text);
                double fpSecond = Int32.Parse(inputFpSecond.Text);
                firstPair = new(fpFirst, fpSecond);
                double spFirst = Int32.Parse(inputSpFirst.Text);
                double spSecond = Int32.Parse(inputSpSecond.Text);
                secondPair = new(spFirst, spSecond);
                int compareResult = firstPair.CompareTo(secondPair);
                if (compareResult == 0)
                    MessageBox.Show("Пары чисел равны");
                if (compareResult == 1)
                    MessageBox.Show("Первая пара чисел больше второй");
                if (compareResult == -1)
                    MessageBox.Show("Вторая пара чисел больше первой");
            }
            catch (Exception)
            {

                MessageBox.Show("Проверьте введенные значения", "Ошибка");
            }
            
        }
    }
}
