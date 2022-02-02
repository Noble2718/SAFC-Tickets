
using System;
using System.Net;
using System.Text;
using Wisej.Web;

namespace WisejPWAWebApplication1
{
	public partial class Page1 : Page
	{
        string Capacity = "";
        string Sold = "";
        string Available = "";
        string perSold = "";
        public Page1()
		{
            InitializeComponent();
            if (Capacity != "null")
            {
                listBox1.Items.Add(Capacity);
                listBox1.Items.Add(Sold);
                listBox1.Items.Add(Available);
                listBox1.Items.Add(perSold);
            }
        }

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://developer.mozilla.org/en-US/docs/Web/Progressive_web_apps", "_blank");
		}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Refresh_Tick(object sender, EventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            string json = (new WebClient()).DownloadString("https://safcticketing.azurewebsites.net/api/tickets");
            string[] words = json.Split(',');
            Capacity = words[0];
            Capacity = Capacity.Replace("\"", "");
            Capacity = Capacity.Replace("{", "");
            Capacity = Capacity.Replace("\"", "");
            Capacity = Capacity.Replace("capacity:", "Capacity: ");
            Capacity = Capacity.Replace("{", "");
            Sold = words[1];
            Sold = Sold.Replace("\"", "");
            Sold = Sold.Replace("{", "");
            Sold = Sold.Replace("\"", "");
            Sold = Sold.Replace("sold:", "Sold: ");
            Available = words[2];
            Available = Available.Replace("\"", "");
            Available = Available.Replace("{", "");
            Available = Available.Replace("\"", "");
            Available = Available.Replace("available:", "Available: ");
            perSold = words[3];
            perSold = perSold.Replace("\"", "");
            perSold = perSold.Replace("{", "");
            perSold = perSold.Replace("\"", "");
            perSold = perSold.Replace("percentageSold:", "Percentage Sold: ");
            perSold = perSold.Replace("}", "%");
            listBox1.Items[0] = Capacity;
            listBox1.Items[2] = Sold;
            listBox1.Items[4] = Available;
            listBox1.Items[6] = perSold;
        }
    }
}
