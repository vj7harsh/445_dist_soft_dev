using System;
using System.Text.RegularExpressions;
using System.Web.UI;


namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {  
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            if (Int32.TryParse(TextBox1.Text, out int c)) {
                TextBox2.Text = service.c2f(c).ToString();
            } else {
                TextBox2.Text = "Please enter an Integer";
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            if (Int32.TryParse(TextBox3.Text, out int f)) {
                TextBox4.Text = service.f2c(f).ToString();
            } else {
                TextBox4.Text = "Please enter an Integer";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            TextBox6.Text = service.sort(TextBox5.Text);
        }
    }
 
}