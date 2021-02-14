using Movil.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Movil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private  void btn_RegisRedirect(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new RegistUs());
        }

        private async void btn_Login(object sender,EventArgs e)
        {

            try
            {
                Users u = new Users();
                u.Email = txtEmailLog.Text;
                u.Pass = Encrypt.GetSHA256(txtPassLog.Text);
                string url = "http://192.168.0.13:8088/api/Login/post";

                HttpClient client = new HttpClient();
                string jsonData = JsonConvert.SerializeObject(u);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                var EmpList = JsonConvert.DeserializeObject<List<Users>>(result);
               // Response responseData = JsonConvert.DeserializeObject<Response>(result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                if (EmpList.Count == 1)
                {
                    u = EmpList[0];
                    await Navigation.PushModalAsync(new Home(u));


                }
                else
                {
                    await DisplayAlert("Message", "This acount dosen't exist", "ok");
                    return;
                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("Message", ex.Message.ToString(), "ok");
                return;
            }
            
        }
    }
}
