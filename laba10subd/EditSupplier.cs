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
    public partial class EditSupplier : Form
    {
        public Supplier Result;
        private Supplier ed;
        public EditSupplier(Supplier ed)
        {
            this.ed = ed;
            InitializeComponent();
        }
        public EditSupplier()
        {
            ed = null;
            InitializeComponent();
        }

        private void EditSupplier_Load(object sender, EventArgs e)
        {
            if (ed != null)
            {
                textBox1.Text = ed.Name;
                textBox2.Text = ed.Address;
                textBox3.Text = ed.City;
                textBox4.Text = ed.Phonenumber;
                textBox5.Text = ed.Email;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = new Supplier() { Name = textBox1.Text, Address = textBox2.Text, City = textBox3.Text, Phonenumber = textBox4.Text, Email = textBox5.Text };
        }
    }
}
