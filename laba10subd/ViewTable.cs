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
    public partial class ViewTable : Form
    {
        private string tablename;
        private OnlineStoreEntities db;
        private BindingSource bs;
        public ViewTable(string tablename)
        {
            this.tablename = tablename;
            this.db = new OnlineStoreEntities();
            bs = new BindingSource();
            InitializeComponent();
        }

        private void ViewTable_Load(object sender, EventArgs e)
        {
            this.Text = tablename;
            UpdateTable();
        }


        private void UpdateTable()
        {
            switch (tablename)
            {
                case "ProductType":
                    db.ProductTypeView.Load();
                    bs.DataSource = db.ProductTypeView.Local.ToBindingList();
                    break;
                case "Client":
                    db.ClientView.Load();
                    bs.DataSource = db.ClientView.Local.ToBindingList();
                    break;
                case "Order":
                    db.OrderView.Load();
                    bs.DataSource = db.OrderView.Local.ToBindingList();
                    break;
                case "Delivery":
                    db.DeliveryView.Load();
                    bs.DataSource = db.DeliveryView.Local.ToBindingList();
                    break;
                case "Supplier":
                    db.SupplierView.Load();
                    bs.DataSource = db.SupplierView.Local.ToBindingList();
                    break;
                case "Product":
                    db.ProductView.Load();
                    bs.DataSource = db.ProductView.Local.ToBindingList();
                    break;
            }
            dataGridView1.DataSource = bs;
            dataGridView1.Columns[0].Visible = false;
            bindingNavigator1.BindingSource = bs;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            switch (tablename)
            {
                case "ProductType":
                    EditProductType editpt = new EditProductType();
                    if (editpt.ShowDialog() == DialogResult.OK) db.ProductType.Add(editpt.Result);
                    db.SaveChanges();
                    break;
                case "Client":
                    EditClient editc = new EditClient();
                    if (editc.ShowDialog() == DialogResult.OK) db.Client.Add(editc.Result);
                    db.SaveChanges();
                    break;
                case "Order":
                    EditOrder edito = new EditOrder();
                    if (edito.ShowDialog() == DialogResult.OK) db.Order.Add(edito.Result);
                    db.SaveChanges();
                    break;
                case "Delivery":
                    EditDelivery editd = new EditDelivery();
                    if (editd.ShowDialog() == DialogResult.OK) db.Delivery.Add(editd.Result);
                    db.SaveChanges();
                    break;
                case "Supplier":
                    EditSupplier edits = new EditSupplier();
                    if (edits.ShowDialog() == DialogResult.OK) db.Supplier.Add(edits.Result);
                    db.SaveChanges();
                    break;
                case "Product":
                    EditProduct editp = new EditProduct();
                    if (editp.ShowDialog() == DialogResult.OK) db.Product.Add(editp.Result);
                    db.SaveChanges();
                    break;
            }
            db.Dispose();
            db = new OnlineStoreEntities();
            UpdateTable();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            switch (tablename)
            {
                case "ProductType":
                    ProductType rempt = db.ProductType.Find(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    db.ProductType.Remove(rempt);
                    db.SaveChanges();
                    break;
                case "Client":
                    Client remc = db.Client.Find(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    db.Client.Remove(remc);
                    db.SaveChanges();
                    break;
                case "Order":
                    Order remo = db.Order.Find(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    db.Order.Remove(remo);
                    db.SaveChanges();
                    break;
                case "Delivery":
                    Delivery remd = db.Delivery.Find(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    db.Delivery.Remove(remd);
                    db.SaveChanges();
                    break;
                case "Supplier":
                    Supplier rems = db.Supplier.Find(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    db.Supplier.Remove(rems);
                    db.SaveChanges();
                    break;
                case "Product":
                    Product remp = db.Product.Find(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    db.Product.Remove(remp);
                    db.SaveChanges();
                    break;
            }

            db.Dispose();
            db = new OnlineStoreEntities();
            UpdateTable();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            switch (tablename)
            {
                case "ProductType":
                    ProductType rempt = db.ProductType.Find(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    EditProductType editpt = new EditProductType(rempt);
                    if (editpt.ShowDialog() == DialogResult.OK)
                    {
                        rempt.Category = editpt.Result.Category;
                        rempt.Description = editpt.Result.Description;
                        db.SaveChanges();

                    }
                    break;
                case "Client":
                    Client remc = db.Client.Find(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    EditClient editc = new EditClient(remc);
                    if (editc.ShowDialog() == DialogResult.OK)
                    {
                        remc.Fullname = editc.Result.Fullname;
                        remc.Address = editc.Result.Address;
                        remc.City = editc.Result.City;
                        remc.Country = editc.Result.Country;
                        remc.Phonenumber = editc.Result.Phonenumber;
                        db.SaveChanges();
                    }
                    break;
                case "Order":
                    Order remo = db.Order.Find(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    EditOrder edito = new EditOrder(remo);
                    if (edito.ShowDialog() == DialogResult.OK)
                    {
                        remo.ClientID = edito.Result.ClientID;
                        remo.Date = edito.Result.Date;
                        remo.Amount = edito.Result.Amount;
                        remo.ProductID = edito.Result.ProductID;
                        remo.DeliveryID = edito.Result.DeliveryID;
                        db.SaveChanges();
                    }
                    break;
                case "Delivery":
                    Delivery remd = db.Delivery.Find(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    EditDelivery editd = new EditDelivery(remd);
                    if (editd.ShowDialog() == DialogResult.OK)
                    {
                        remd.Name = editd.Result.Name;
                        remd.Phonenumber = editd.Result.Phonenumber;
                        db.SaveChanges();
                    }
                    break;
                case "Supplier":
                    Supplier rems = db.Supplier.Find(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    EditSupplier edits = new EditSupplier(rems);
                    if (edits.ShowDialog() == DialogResult.OK)
                    {
                        rems.Name = edits.Result.Name;
                        rems.Address = edits.Result.Address;
                        rems.City = edits.Result.City;
                        rems.Phonenumber = edits.Result.Phonenumber;
                        rems.Email = edits.Result.Email;
                        db.SaveChanges();
                    }
                    break;
                case "Product":
                    Product rem = db.Product.Find(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    EditProduct editform = new EditProduct(rem);
                    if (editform.ShowDialog() == DialogResult.OK)
                    {
                        rem.Name = editform.Result.Name;
                        rem.ProductTypeID = editform.Result.ProductTypeID;
                        rem.SupplierID = editform.Result.SupplierID;
                        rem.Measure = editform.Result.Measure;
                        db.SaveChanges();
                    }
                    break;
            }
            db.Dispose();
            db = new OnlineStoreEntities();
            UpdateTable();
        }

        private void ViewTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }
    }
}
