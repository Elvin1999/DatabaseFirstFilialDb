using DataBaseFirstWpf.Entities;
using DataBaseFirstWpf.ViewModels;
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

namespace DataBaseFirstWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count=0;
        public void SetNoOfFilials()
        {
            var count = FilialViewModel.AllFilials.Count;
            for (int i = 0,i2=1; i <count; i++,i2++)
            {
                
                FilialViewModel.AllFilials[i].No = i2;
            }
        }
        public FilialViewModel FilialViewModel { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            FilialViewModel = new FilialViewModel();
            using(FilialDbEntities dbcontext=new FilialDbEntities())
            {
                FilialViewModel.AllFilials = new ObservableCollection<Filials>(dbcontext.Filials.ToList());

                //dbcontext.SaveChanges();
            }
            SetNoOfFilials();
            DataContext = FilialViewModel;
        }
    }
}
