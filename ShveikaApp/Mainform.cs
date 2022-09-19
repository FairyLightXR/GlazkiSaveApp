using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShveikaApp.Model;
using ShveikaApp.Utils;
namespace ShveikaApp
{
    public partial class MainForm : Form
    {
        public static List<Agent> agents = new List<Agent>();
        public MainForm()
        {
            InitializeComponent();
            agents = DbContext.Model.Agent.ToList();
        }
        private void GenerateAgentsCards(List<Agent> agent)
        {
            foreach (var agentCard in agent)
            {
                AgentCard card = new AgentCard();
                card.GenerateAgentCard(agentCard);
                flowLayoutPanel1.Controls.Add(card);

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GenerateAgentsCards(agents);
        }

        public void SearchFilterSorting()
        {

        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
