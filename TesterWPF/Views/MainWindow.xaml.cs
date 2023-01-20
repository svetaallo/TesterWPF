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
using TesterWPF.ViewModels;
using TesterWPF.Models;

namespace TesterWPF.Views
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

        private void Botton_Click(object sender, RoutedEventArgs e)
        {
            var session = new Session();
            TestWindow testWindow = new TestWindow();
            testWindow.Show();
        }
        //private void Add_Click(object sender, RoutedEventArgs e)
        //{
        //    using (ApplicationContext db = new ApplicationContext())
        //    {
        //        // создаем два объекта User
        //        Card newCard = new Card { Question = "?", CorrectAnswer = "!", Theme="прога" };

        //        // добавляем их в бд
        //        db.Cards.Add(newCard);
        //        db.SaveChanges();
        //        Console.WriteLine("Объекты успешно сохранены");

        //        // получаем объекты из бд и выводим на консоль
        //        var cards = db.Cards.ToList();
        //        Console.WriteLine("Список объектов:");
        //        foreach (Card u in cards)
        //        {
        //            Console.WriteLine($"{u.Id}.{u.Question} - {u.CorrectAnswer} - {u.Theme}");
        //        }
        //    }
        //}
    }
}
