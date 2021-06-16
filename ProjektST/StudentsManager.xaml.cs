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
using System.Windows.Shapes;

namespace ProjektST
{
    /// <summary>
    /// Interaction logic for StudentsManager.xaml
    /// </summary>
    public partial class StudentsManager : Window
    {
        public StudentsManager()
        {
            InitializeComponent();
        }

        private void ButtonTestowy_Click(object sender, RoutedEventArgs e)
        {
            using (var ctx = new StudentsContext())
            {
                var stud = new Student()
                {
                    StudentId = 1,
                    StudentFirstName = "Krzysztof",
                    StudentLastName = "Bazylak",
                    PhoneNumber = "123456789",
                    DateOfBirth = new DateTime(1991, 1, 1),
                    Gender = 'm',
                    Adress = "Sikorskiego",
                    AdressNumber = 379,
                    Email = "test@gmail.com",
                    LastLogin = DateTime.Today
                };
                ctx.Students.Add(stud);
                int gowno = ctx.SaveChanges();
                //TestowyTextBoX.Text = ctx.Students.ToString();
                TestowyTextBoX.Text = gowno.ToString();
            }
        }
    }
}
