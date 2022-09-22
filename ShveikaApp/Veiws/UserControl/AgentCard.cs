using ShveikaApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShveikaApp
{
    public partial class AgentCard : UserControl
    {
        public AgentCard()
        {
            InitializeComponent();
        }

        public void GenerateAgentCard(Agent agent)
        {
            string path = null;
            if (!string.IsNullOrWhiteSpace(agent.Logo))
            {
                path = agent.Logo.Remove(0, 1);
            }
            PhotoBox.ImageLocation = path;
            TypeAndTitleLbl.Text = agent.AgentType.Title + " | " + agent.Title;
            PhoneLbl.Text = agent.Phone;
            IDLbl.Text = Convert.ToString(agent.ID);
            int qty = 0;
            int qtyAllPeriod = 0;
            decimal SaleSumm = 0;
            foreach(ProductSale sale in agent.ProductSale)
            {
                
                if (sale.SaleDate.Year == 2019)
                {
                    qty += sale.ProductCount;
                   
                }
                qtyAllPeriod += sale.ProductCount;
                SaleSumm += qtyAllPeriod * sale.Product.MinCostForAgent;



            }
            qtyLbl.Text = qty + " Продаж за год";
            PriorityLbl.Text = agent.Priority.ToString();
            if (SaleSumm < 10000)
            {
                DiscountLbl.Text = "0%";
            }
            else if (SaleSumm >= 10000 && SaleSumm <= 50000)
            {
                DiscountLbl.Text = "5%";
            }
            else if (SaleSumm > 50000 && SaleSumm <= 150000)
            {
                DiscountLbl.Text = "10%";
            }
            else if (SaleSumm > 150000 && SaleSumm <= 500000)
            {
                DiscountLbl.Text = "20%";
            }
            else
            {
                DiscountLbl.Text = "25%";
            }
            if ( Int32.Parse(DiscountLbl.Text.Remove(DiscountLbl.Text.Length - 1)) >=5)
            {
               TypeAndTitleLbl.ForeColor = Color.LightGreen;
                DiscountLbl.ForeColor = Color.LightGreen;
            }
        }
    }
}
