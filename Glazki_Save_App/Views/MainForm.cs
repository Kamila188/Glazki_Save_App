using Glazki_Save_App.Models;
using Glazki_Save_App.Utils;
using Glazki_Save_App.Views.PartialView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glazki_Save_App
{
    public partial class MainForm : Form
    {
        List<Agent> agents = new List<Agent>();
        public MainForm()
        {
            InitializeComponent();
            agents = DatabaseContext.db.Agent.ToList();
            GenerateAgentCardList(agents);
        }

        private void GenerateAgentCardList(List<Agent> agent)
        {
            foreach (var a in agent)
            {
                AgentCard card = new AgentCard();
                card.GenerateDataToAgentCard(a);
                flowLayoutPanel1.Controls.Add(card);
            }
        }
        private void SortListView()
        {
            flowLayoutPanel1.Controls.Clear();
            var listUpdate =DatabaseContext.db.Agent.ToList();
            if (SortComboBox.Text=="Наименование")
            {
                if(!desccheckBox.Checked)
                {
                    listUpdate = listUpdate.OrderBy(a=>a.Title).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(a => a.Title).ToList();
                }
            }
            if(SortComboBox.Text =="Приоритет")
            {
                if(!desccheckBox.Checked)
                {
                    listUpdate= listUpdate.OrderBy(a=>a.Priority).ToList();
                }
                else
                {
                    listUpdate=(listUpdate.OrderByDescending(a=>a.Priority)).ToList();
                }
            }
            if(FiltrComboBox.Text !="Все типы")
            {
                listUpdate = listUpdate.Where(type => type.AgentType.Title == FiltrComboBox.SelectedItem.ToString()).ToList();
            }
            if(SearchTxtBox.Text !="Введите для поиска")
            {
                listUpdate = listUpdate.Where(p => p.Title.ToLower().Contains(SearchTxtBox.Text.ToLower())
                || p.Phone.Contains(SearchTxtBox.Text)
                || p.Email.Contains(SearchTxtBox.Text.ToLower())).ToList();
            }
            GenerateAgentCardList(listUpdate);
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListView();
        }

        private void desccheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SortListView();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var allType = DatabaseContext.db.AgentType.Select(type => type.Title).ToList();
            allType.Insert(0, "Все типы");
            FiltrComboBox.DataSource = allType;
            SortComboBox.SelectedIndex = 0;
        }

        private void FiltrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListView();
        }

        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            SortListView();
        }
    }
}
