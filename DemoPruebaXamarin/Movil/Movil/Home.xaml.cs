using Movil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home(Users us)
        {
            InitializeComponent();
            lblEmailUser.Text = "Your Name: "+us.Name;
            lblNameUser.Text = "You Email: "+us.Email;
        }
    }
}