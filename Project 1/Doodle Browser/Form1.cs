using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doodle_Browser
{
    public partial class Doodle : Form
    {
        public Doodle()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(searchBar.Text);
        }

        private void getStockPrice_Click(object sender, EventArgs e)
        {
            // initialising Stock Service Client
            StockServiceReference.ServiceClient stockService = new StockServiceReference.ServiceClient();
            // Checking for empty or null Stock name
            if (String.IsNullOrEmpty(stockName.Text)) {
                stockPrice.Text = "Please enter a valid Stock Name";
            } else {
                try
                {
                    // Calling the Stock Service to get the Stock price
                    stockPrice.Text = stockService.getStockquote(stockName.Text.ToUpper());
                }
                catch (Exception ex)
                {
                    // Showing the error message if any
                    stockPrice.Text = ex.Message;
                }
            }
        }

        private void getRandomString_Click(object sender, EventArgs e)
        {
            RandomStringService.ServiceClient stringService = new RandomStringService.ServiceClient();

            try {
                // Checking for string length 
                if (string.IsNullOrEmpty(length.Text))
                {
                    // If no size is mentioned calling the default Random String Generator
                    randomString.Text = stringService.GetRandomString0().ToString();
                }
                else
                {
                    // Validating the length given is a valid integer
                    if (int.TryParse(length.Text, out int len))
                    {
                        // Calling Random String Generator with given length
                        randomString.Text = stringService.GetRandomString(length.Text).ToString();
                    }
                    else
                    {
                        // Sending error message if the given input is not an integer
                        randomString.Text = "Please enter a valid string size";
                    }
                }
            } catch (Exception ex) {
                // Sending the error message if any
                randomString.Text = ex.Message;
            }
        }
    }
}
