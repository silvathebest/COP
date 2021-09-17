using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COP;

namespace COPTest
{
    public partial class Form1 : Form
    {
        private List<string> listboxData;
        public Form1()
        {
            InitializeComponent();
            listboxData = new List<string>() { "Москва", "Питер", "Владивосток", "ТОКИО" };
            controlDateTimePicker.MinDate = new DateTime(2020, 12, 12);
            controlDateTimePicker.MaxDate = new DateTime(2021, 12, 12);
            controlTree.LoadConfig(new Queue<string>(new List<string> { "City", "Email", "Id" }));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            controlCheckedListBox.AddItems(listboxData);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            controlCheckedListBox.Clear();
        }

        private void controlCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox.Text = "Выбранный индекс: " + ((CheckedListBox)sender).SelectedIndex;
        }

        private void buttonSet_Click(object sender, EventArgs e)
        { 
            controlCheckedListBox.SelectedItem = textBox.Text;
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            if (controlCheckedListBox.SelectedItem == null) return;

            textBox.Text = "Выбранное значение: " + controlCheckedListBox.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = "Дата: " + controlDateTimePicker.Value;
        }

        private void buttonAddToTree_Click(object sender, EventArgs e)
        {
            controlTree.AddItems(new List<Order>()
            {
                new Order { City = "City1", Email = "qw@qw.da", Id = "1" },
                new Order { City = "City1", Email = "qw2@qw.da", Id = "2" },
                new Order { City = "City2", Email = "qw3@qw.da", Id = "3" },
                new Order { City = "City2", Email = "qw3@qw.da", Id = "4" },
                new Order { City = "City2", Email = "qw3@qw.da", Id = "4" }
            });
        }

        private void buttonGetFromTree_Click(object sender, EventArgs e)
        {
            if (controlTree.GetSelectedObject<Order>()?.ToString() == null) return;

            textBox.Text = controlTree.GetSelectedObject<Order>().ToString();
        }

        private void buttonGetIdFromTree_Click(object sender, EventArgs e)
        {
            if (controlTree.SelectedBranchIndex.ToString() == null) return;

            textBox.Text = controlTree.SelectedBranchIndex.ToString();
        }

        private void buttonSetIdForTree_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "") return;

            controlTree.SelectedBranchIndex = Convert.ToInt32(textBox.Text);
        }
    }
}
