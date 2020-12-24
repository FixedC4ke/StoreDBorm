using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace laba10subd
{
    public partial class EditProduct : Form
    {
        public Product Result;
        private Product edprod;
        public EditProduct(Product edprod)
        {
            this.edprod = edprod;
            InitializeComponent();
        }
        public EditProduct()
        {
            this.edprod = null;
            InitializeComponent();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            var db = new OnlineStoreEntities();
            comboBox1.DataSource = db.Supplier.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox2.DataSource = db.ProductType.ToList();
            comboBox2.DisplayMember = "Category";
            comboBox2.ValueMember = "ID";
            if (this.edprod != null)
            {
                textBox1.Text = edprod.Name;
                comboBox1.SelectedValue = edprod.SupplierID;
                comboBox2.SelectedValue = edprod.ProductTypeID;
                textBox2.Text = edprod.Measure;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = new Product() { Name = textBox1.Text, SupplierID = (int)comboBox1.SelectedValue, ProductTypeID = (int)comboBox2.SelectedValue, Measure = textBox2.Text };
        }
    }
}
