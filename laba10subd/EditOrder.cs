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
    public partial class EditOrder : Form
    {
        public Order Result;
        private Order ed;
        public EditOrder(Order ed)
        {
            this.ed = ed;
            InitializeComponent();
        }
        public EditOrder()
        {
            this.ed = null;
            InitializeComponent();
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {
            var db = new OnlineStoreEntities();
            comboBox1.DataSource = db.Client.ToList();
            comboBox1.DisplayMember = "Fullname";
            comboBox1.ValueMember = "ID";
            comboBox2.DataSource = db.Product.ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "ID";
            comboBox3.DataSource = db.Delivery.ToList();
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "ID";
            if (ed != null)
            {
                comboBox1.SelectedValue = ed.ClientID;
                dateTimePicker1.Value = (DateTime)ed.Date;
                textBox1.Text = ed.Amount.ToString();
                comboBox2.SelectedValue = ed.ProductID;
                comboBox3.SelectedValue = ed.DeliveryID;
            }
            db.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = new Order() { ClientID = (int)comboBox1.SelectedValue, Date = dateTimePicker1.Value, Amount = Int32.Parse(textBox1.Text), ProductID = (int)comboBox2.SelectedValue, DeliveryID = (int)comboBox3.SelectedValue };
        }
    }
}
