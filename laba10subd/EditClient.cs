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
    public partial class EditClient : Form
    {
        public Client Result;
        private Client ed;
        public EditClient(Client ed)
        {
            this.ed = ed;
            InitializeComponent();
        }
        public EditClient()
        {
            this.ed = null;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = new Client() { Fullname = textBox1.Text, Address = textBox2.Text, City = textBox3.Text, Country = textBox4.Text, Phonenumber = textBox5.Text };
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            if (ed != null)
            {
                textBox1.Text = ed.Fullname;
                textBox2.Text = ed.Address;
                textBox3.Text = ed.City;
                textBox4.Text = ed.Country;
                textBox5.Text = ed.Phonenumber;
            }
        }
    }
}
