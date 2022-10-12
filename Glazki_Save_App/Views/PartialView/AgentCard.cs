using Glazki_Save_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glazki_Save_App.Views.PartialView
{
    public partial class AgentCard : UserControl
    {
        public AgentCard()
        {
            InitializeComponent();
        }
        public void GenerateDataToAgentCard(Agent agent)
        {
            string path = null;
            if (!string.IsNullOrWhiteSpace(agent.Logo))
            {
                path = agent.Logo.Remove(0, 1);
            }
            int qty = 0;
            decimal sum = 0;
            pictureBox1.ImageLocation = path;
            NameTypeAgentLbl.Text = agent.AgentType.Title + "|" + agent.Title;
            foreach(ProductSale sale in agent.ProductSale)
            {
                qty += sale.ProductCount;
                sum += qty * sale.Product.MinCostForAgent; 
            }
            SaleYearLbl.Text = qty + " продаж за год";
            PhoneLbl.Text = agent.Phone;
            PriorityLbl.Text= "Приоритетность: " + agent.Priority;
            if(sum < 10000)
            {
                PercentLbl.Text = "0%";
            }
            else if (sum >=10000 && sum < 50000)
            {
                PercentLbl.Text = "5%";
            }
            else if (sum >= 50000 && sum < 150000)
            {
                PercentLbl.Text = "10%";
            }
            else if (sum >= 150000 && sum < 500000)
            {
                PercentLbl.Text = "20%";
            }
            else
            {
                PercentLbl.Text = "25%";
            }
        }

        private void AgentCard_Load(object sender, EventArgs e)
        {

        }
    }
}
