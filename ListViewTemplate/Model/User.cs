using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ListViewTemplate.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BornDate { get; set; }
        public double Salary { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public BitmapImage Image { get; set; }
        
        public User()
        {
            Id = default(int);
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            BornDate = default(DateTime);
            Salary = default(double);
            Login = string.Empty;
            Password = string.Empty;
            Role = string.Empty;
            Image = new BitmapImage();
        }

        public User(int id, string firstName, string middleName, string lastName, DateTime bornDate, double salary, string login, string password, string role, string image)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BornDate = bornDate;
            Salary = salary;
            Login = login;
            Password = password;
            Role = role;
            Image =new BitmapImage(new Uri("pack://application,,,/Assets/Images/" + image));
        }
    }
}
