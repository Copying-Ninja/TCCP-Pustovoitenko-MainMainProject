using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBEntity
{
    public partial class Form1 : Form
    {
        Contact model = new Contact();
        public Form1()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            contTypeIdTextBox.Text = contValTextBox.Text = personIdTextBox.Text = "";
            saveButton.Text = "Save";
            delButton.Enabled = false;
            model.contact_id = 0;
        }
        bool isInt(string str)
        {
            try
            {
                int i = Convert.ToInt32(str);
                if(i > 0)
                return true;
                
            }
            catch
            {
                
            }
            return false;
        }


        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if( !isInt(contTypeIdTextBox.Text) || !isInt(personIdTextBox.Text)  )
            {
                MessageBox.Show("Id fields should be positive integer number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            model.contact_type_id = contTypeIdTextBox.Text.Trim();
            model.person_id = personIdTextBox.Text.Trim();
            model.contact_value = contValTextBox.Text.Trim();


            using (DBEntities db = new DBEntities())
            {
                if (model.contact_id == 0)
                {
                    db.Contact.Add(model);
                }
                else
                {
                    db.Entry(model).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Added Successfully");
        }

        void PopulateDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dataGridView.DataSource = db.Contact.ToList<Contact>();
            }
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
         
                if (dataGridView.CurrentRow.Index != -1)
                {
                    model.contact_id = Convert.ToInt32(dataGridView.CurrentRow.Cells["id_contact"].Value);
                    using (DBEntities db = new DBEntities())
                    {
                        model = db.Contact.Where(x => x.contact_id == model.contact_id).FirstOrDefault();
                        contTypeIdTextBox.Text = model.contact_type_id;
                        personIdTextBox.Text = model.person_id;
                        contValTextBox.Text = model.contact_value;
                    }
                    saveButton.Text = "Update";
                    delButton.Enabled = true;
                }
         

        }

        private void delButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Contact.Attach(model);
                    }
                    db.Contact.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Delete succsessfully!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Зміни_1");
            Console.WriteLine("Зміни_2");
        }
    }
}
