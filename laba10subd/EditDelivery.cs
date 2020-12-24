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
    public partial class EditDelivery : Form
    {
        public Delivery Result;
        private Delivery ed;
        public EditDelivery(Delivery ed)
        {

            this.ed = ed;
            InitializeComponent();
        }
        public EditDelivery()
        {
            this.ed = null;
            InitializeComponent();
        }

        private void EditDelivery_Load(object sender, EventArgs e)
        {
            if (ed != null)
            {
                textBox1.Text = ed.Name;
                textBox2.Text = ed.Phonenumber;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = new Delivery() { Name = textBox1.Text, Phonenumber = textBox2.Text };
        }
    }
}
