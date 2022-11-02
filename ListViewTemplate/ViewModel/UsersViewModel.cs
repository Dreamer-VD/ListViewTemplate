using ListViewTemplate.Core;
using ListViewTemplate.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewTemplate.ViewModel
{
    public class UsersViewModel : BaseViewModel
    {
        private ObservableCollection<User> _users;

        public ObservableCollection<User> Users { get => _users; set => SetProperty(ref _users, value); }

        public UsersViewModel()
        {
            Users = new ObservableCollection<User>(UserParse.ParseFile("users3.txt"));
        }
    }

}
