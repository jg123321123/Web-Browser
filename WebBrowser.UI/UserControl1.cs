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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WebBrowser.UI
{
    public partial class UserControl1 : UserControl
    {
        public static string SetTab = "";


        public UserControl1()
        {


            InitializeComponent();


        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            SetTab = webBrowser1.DocumentTitle;
            if (System.Windows.Forms.Application.OpenForms["MainBrowser"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["MainBrowser"] as MainBrowser).SetTabs();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }


        
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = searchBox.Text;
                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    tabPage1.Text = url;
                    webBrowser1.Navigate(url);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            
            var bookmark = new BookmarksItem();
            bookmark.URL = searchBox.Text;
            bookmark.Title = webBrowser1.DocumentTitle;

            
            var items = BookmarkManager.GetItems();

            
            int count = 0;
            foreach (var item in items)
            {
                if (item.URL.Contains(searchBox.Text))
                {
                    count++;
                }
            }
            if (count == 0)
            {
                
                BookmarkManager.AddItem(bookmark);
            }
            else
            {
                
                MessageBox.Show("ALREADY BOOKMARKED");
            }
        }

        private void webBrowser2_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string url = searchBox.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                tabPage1.Text = url;
                webBrowser2.Navigate(url);
            }
        }

        private void searchBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void webBrowser2_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                
                progressBar.Value = (int)e.CurrentProgress;
                progressBar.Maximum = (int)e.MaximumProgress;
            }
            catch
            {

            }
            
            if (progressBar.Value < e.MaximumProgress)
            {
                statusLbl.Text = "Loading...";
            }
            
            else
            {
                statusLbl.Text = "Complete";
            }
        }


    }
}
