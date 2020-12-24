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
    public partial class EditProductType : Form
    {
        public ProductType Result;
        private ProductType ed;
        public EditProductType(ProductType ed)
        {
            this.ed = ed;
            InitializeComponent();
        }

        public EditProductType()
        {
            this.ed = null;
            InitializeComponent();
        }

        private void EditProductType_Load(object sender, EventArgs e)
        {
            if (ed != null)
            {
                textBox1.Text = ed.Category;
                textBox2.Text = ed.Description;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = new ProductType() { Category = textBox1.Text, Description = textBox2.Text };
        }
    }
}
