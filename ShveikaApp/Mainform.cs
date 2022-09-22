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
            var AllTypes = DbContext.Model.AgentType.Select(type => type.Title).ToList();
            AllTypes.Insert(0, "Все типы");
            FilterCmb.DataSource = AllTypes;
            FilterCmb.SelectedIndex = 0;
            SortCmb.SelectedIndex = 0;
        }

        public void SearchFilterSorting()
        {
            var ListUpdate = DbContext.Model.Agent.ToList();


            #region Filtering
            if (FilterCmb.SelectedIndex > 0)
            {
                ListUpdate = ListUpdate.Where(a => a.AgentType.Title == FilterCmb.SelectedItem.ToString()).ToList();
            }
            #endregion

            #region Sorting
            if (SortCmb.Text == "Наименование")
            {
                if (!DescChkBox.Checked)
                {
                    ListUpdate = ListUpdate.OrderBy(a => a.Title).ToList();
                }
                else
                {
                    ListUpdate = ListUpdate.OrderByDescending(a => a.Title).ToList();
                }
            }
            if (SortCmb.Text == "Приоритет")
            {
                if (!DescChkBox.Checked)
                {
                    ListUpdate = ListUpdate.OrderBy(b => b.Priority).ToList();
                }
                else
                {
                    ListUpdate = ListUpdate.OrderByDescending(b => b.Priority).ToList();

                }
            }
            #endregion

            #region Searching
            if (SearchTxt.Text != "Введите для поиска" && !string.IsNullOrEmpty(SearchTxt.Text))
            {
                ListUpdate = ListUpdate.Where(p => p.Title.ToLower().Contains(SearchTxt.Text.ToLower())
                || p.Phone.ToString().Contains(SearchTxt.Text)
                || p.Email.ToLower().Contains(SearchTxt.Text.ToLower())).ToList();
            }
            #endregion 

            flowLayoutPanel1.Controls.Clear();
            GenerateAgentsCards(ListUpdate);

        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            SearchFilterSorting();
        }

        private void FilterCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SearchFilterSorting();
        }

        private void SortCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SearchFilterSorting();
        }

        private void DescChkBox_CheckedChanged(object sender, EventArgs e)
        {
            
            SearchFilterSorting();
        }

        private void SearchTxt_MouseClick(object sender, MouseEventArgs e)
        {
            SearchTxt.Text = "";
        }
    }
}
