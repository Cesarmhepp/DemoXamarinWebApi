using Movil.Models;
using Movil.Servicio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Movil.ViewModel
{
    public class UsersViewModel:Users
    {
        public ObservableCollection<Users> Users { get; set; }
        UsersService service = new UsersService();
        Users model;
        public UsersViewModel()
        {
            Users = service.Consult();
        }

        public Command SaveCommand { get; set; }
        public Command ModifyCommand { get; set; }
        public Command DeleteCommand { get; set; }
        public Command CleanCommand { get; set; }

       
    }
}
