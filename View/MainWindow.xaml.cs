using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WPFdz0506.Model;
using WPFdz0506.ViewModel;

namespace WPFdz0506
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private BindingList<MyNotes> categories;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModelNotes();
        }

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    categories = new BindingList<MyNotes>()
        //    {
        //        new MyNotes(){Category = "pervaj" , Description = "ghfffjfjfjjf"},
        //        new MyNotes(){Category = "vtoraj" , Description = "stgstdhfj"}
        //    };
        //    Notes.ItemsSource = categories;
        //    categories.ListChanged += Categories_ListChanged;


        //}

        //private void Categories_ListChanged(object sender, ListChangedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
