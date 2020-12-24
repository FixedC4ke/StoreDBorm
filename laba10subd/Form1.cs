using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba10subd
{
    public partial class Form1 : Form
    {
        private OnlineStoreEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new OnlineStoreEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in db.Database.SqlQuery<string>("SELECT name FROM sys.tables ORDER BY name").ToList())
            {
                if (s == "sysdiagrams") continue;
                ToolStripMenuItem mitem = new ToolStripMenuItem(s);
                mitem.Click += ShowTable;
                tablesToolStripMenuItem.DropDownItems.Add(mitem) ;
            }
        }
        
        private void ShowTable(object sender, EventArgs e)
        {
            ViewTable vt = new ViewTable(((ToolStripMenuItem)sender).Text);
            vt.MdiParent = this;
            vt.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
