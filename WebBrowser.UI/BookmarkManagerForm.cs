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
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            
            var items = BookmarkManager.GetItems();
            foreach (var item in items)
            {
                
                listBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var items = BookmarkManager.GetItems();
            listBox1.Items.Clear();
            foreach (var item in items)
            {
                bool result = item.Title.IndexOf(searchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                bool result2 = item.URL.IndexOf(searchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                if (result == true || result2 == true)
                {
                    listBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                string item = listBox1.GetItemText(listBox1.SelectedItem);
                BookmarkManager.DeleteBookmark(item);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Error: Nothing was selected to delete.");
            }

        }

    }
}
