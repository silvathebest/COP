using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP
{
    public partial class ControlCheckedListBox : UserControl
    {
        public ControlCheckedListBox()
        {
            InitializeComponent();
        }
        [Category("Спецификация")]
        [Description("Событие выбора элемента из списка")]
        public event EventHandler SelectedIndexChanged
        {
            add
            {
                checkedListBox.SelectedIndexChanged += value;
            }
            remove
            {
                checkedListBox.SelectedIndexChanged -= value;
            }
        }
        private void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox.CheckedItems.Count > 0)
            {
                checkedListBox.ItemCheck -= new ItemCheckEventHandler(CheckedListBox_ItemCheck);
                checkedListBox.SetItemChecked(checkedListBox.CheckedIndices[0], false);
                checkedListBox.ItemCheck += new ItemCheckEventHandler(CheckedListBox_ItemCheck);
            }
        }

        [Category("Спецификация")]
        [Description("Выбранные элементы")]
        public string SelectedItem
        {
            get => checkedListBox.CheckedItems.Count > 0 ? checkedListBox.CheckedItems[0].ToString() : String.Empty;
            set
            {
                if (!string.IsNullOrEmpty(value) && checkedListBox.Items.Contains(value))
                {
                    checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf(value), true);
                }
            }
        }

        public void AddItems(List<string> items)
        {
            foreach (string item in items)
            {
                checkedListBox.Items.Add(item);
            }
        }

        public void Clear()
        {
            checkedListBox.Items.Clear();
        }

    }
}
