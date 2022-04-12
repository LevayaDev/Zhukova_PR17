using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using System.Collections.Specialized;

namespace Zhukova_PR17
{
    public partial class MainPage : ContentPage
    {
        string url = "http://numbersapi.com/";
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(eNumber.Text);

                if (num > 0)
                {
                    using (WebClient webClient = new WebClient()) 
                    {
                        lFact.Text = webClient.DownloadString(url + eNumber.Text);
                    }
                }
                else
                {
                    lFact.Text = "Введите число больше нуля! >:с";
                }
            }
            catch
            {
                lFact.Text = "Но... Это же не число... :с";
            }
        }
    }
}
