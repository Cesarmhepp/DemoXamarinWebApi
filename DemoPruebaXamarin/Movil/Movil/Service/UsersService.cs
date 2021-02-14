using Movil.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Movil.Servicio
{
    public class UsersService
    {
        public ObservableCollection<Users> users { get; set; }

        public UsersService()
        {
            if (users == null)
            {
                users = new ObservableCollection<Users>();
            }
        }

        public ObservableCollection<Users> Consult()
        {
            return users;
        }

        public void Save(Users model)
        {
            users.Add(model);
        }

        public void Modify(Users model)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].CUSTOMER_ID==model.CUSTOMER_ID)
                {
                    users[i] = model;
                }
            }
        }

        public void Delete(int idModel)
        {
            Users model = users.FirstOrDefault(p => p.CUSTOMER_ID == idModel);
            users.Remove(model);
        }

    }

    
}
