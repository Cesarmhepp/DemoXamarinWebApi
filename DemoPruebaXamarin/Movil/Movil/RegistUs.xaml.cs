using Movil.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistUs : ContentPage
    {

        public RegistUs()
        {
            InitializeComponent();
        }

        async void GetUserInfo()
        {
            try
            {
                string url = "https://localhost:44326/api/users";
                HttpClient client = new HttpClient();
                var result = await client.GetStringAsync(url);

                var EmpList = JsonConvert.DeserializeObject<List<Users>>(result);

               // UList.ItemsSource = null;
                //UList.ItemsSource = new ObservableCollection<User>(EmpList);
            }
            catch (Exception ex)
            {

                await DisplayAlert("Input Error", ex.Message, "OK");
                return;
            }
        }

        public async void btn_ClikedRegis(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    await DisplayAlert("Input Error", "Name is Required", "OK");
                    return;
                }
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    await DisplayAlert("Input Error", "Email is Required", "OK");
                    return;
                }
                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    await DisplayAlert("Input Error", "Password is Required", "OK");
                    return;
                }
                bool bEmail;
                bEmail = Regex.IsMatch(txtEmail.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (bEmail == false)
                {
                    await DisplayAlert("Input Error", "Invalid Email Address.", "OK");
                    return;
                }
                bool bEmailCon;
                bEmailCon = Regex.IsMatch(txtEmailConfirm.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (bEmail == false)
                {
                    await DisplayAlert("Input Error", "Invalid Email Address.", "OK");
                    return;
                }

                bool bPass;
                bPass = Regex.IsMatch(txtPass.Text, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
                if (bPass==false)
                {
                    await DisplayAlert("Input Error", "Password needs minimum 8 characters at least 1 Alphabet and 1 Number", "OK");
                    return;
                }

                bool Con = Regex.IsMatch(txtPassConfirm.Text, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
                if (bPass == false)
                {
                    await DisplayAlert("Input Error", "Password needs minimum 8 characters at least 1 Alphabet and 1 Number", "OK");
                    return;
                }


                if (txtEmail.Text!=txtEmail.Text)
                {
                    await DisplayAlert("Input Error", "The field 'Email' and 'Confirm Email' are not equal", "OK");
                    return;
                }
                if (txtPass.Text != txtPassConfirm.Text)
                {
                    await DisplayAlert("Input Error", "The field 'Password' and 'Confirm Password' are not equal", "OK");
                    return;
                }
                /*   var input = txtPass.Text;
                   var hasNumber = new Regex(@"[0-9]+");
                   var hasUpperChar = new Regex(@"[A-Z]+");
                   var hasMinimum8Chars = new Regex(@".{8,}");
                   var isValidated = hasNumber.IsMatch(input) && hasUpperChar.IsMatch(input) && hasMinimum8Chars.IsMatch(input);
                   if (isValidated)
                   {
                       await DisplayAlert("Input Error", "The password need a Number, MAyus Characters and numbers", "OK");
                       return;
                   }
                */
                Users user = new Users();
                user.Name = txtName.Text;
                user.Email = txtEmail.Text;
                user.Pass = Encrypt.GetSHA256(txtPass.Text);

                string url = "http://192.168.0.13:8088/api/users/post";

                HttpClient client = new HttpClient();
                string jsonData = JsonConvert.SerializeObject(user);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                Response responseData = JsonConvert.DeserializeObject<Response>(result,new JsonSerializerSettings {NullValueHandling=NullValueHandling.Ignore });
                if (responseData.Status == 2 )
                {
                    await DisplayAlert("Message", responseData.Message, "ok");
                    await Navigation.PushModalAsync(new MainPage());
                    btnRegis.IsEnabled = true;

                }
                else if( responseData.Status == 1)
                {
                    await DisplayAlert("Message", responseData.Message, "ok");
                    btnRegis.IsEnabled = true;
                    return;
                }
                else if (responseData.Status == 0)
                {
                    await DisplayAlert("Message", responseData.Message, "ok");
                    btnRegis.IsEnabled = true;
                    return;
                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("Message", ex.Message.ToString(), "ok");
                btnRegis.IsEnabled = true;
                return; 
            }
           

        }

        
    }
}