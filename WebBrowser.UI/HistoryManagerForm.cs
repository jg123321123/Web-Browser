using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;


namespace WebBrowser.UI
{
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            
            var items = HistoryManager.GetItems();
            foreach (var item in items)
            {
                
                listBox1.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }
        }

        private void histSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void histSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                histSearchBtn_Click(sender, e);
            }
        }


        private void histSearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void histDeleteBtn_Click(object sender, EventArgs e)
        {
            /
            try
            {
                string item = listBox1.GetItemText(listBox1.SelectedItem);
                HistoryManager.DeleteHistory(item);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

            catch
            {
                MessageBox.Show("Error: Nothing was selected to delete.");
            }
        }

        private void histClearBtn_Click(object sender, EventArgs e)
        {
            DialogResult dlog = MessageBox.Show("Are you sure you want to clear your entire history? This is permanent and cannot be undone.",
                "Clear History", MessageBoxButtons.YesNo);
            if (dlog == DialogResult.Yes)
            {
                
                HistoryManager.ClearHistory();
                listBox1.Items.Clear();
            }
            else if (dlog == DialogResult.No)
            {
                
            }

        }
    }
}
