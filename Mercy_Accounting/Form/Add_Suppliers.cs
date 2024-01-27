using DevExpress.XtraEditors;
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
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using DevExpress.XtraWaitForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Mercy_Accounting.Form
{
    public partial class Add_Suppliers : DevExpress.XtraEditors.XtraForm
    {

        DB_MercyEntities db;
        Mercy_Accounting.Supplier supplier;
        Categoire categoire;
        Supplier sup;
        public int id;
        public string cat_name;
        bool state;

        public Add_Suppliers()
        {
            InitializeComponent();
        }

        private async void btnAddEdit_Click(object sender, EventArgs e)
        {
            db = new DB_MercyEntities();
            
            if (txt_name.Text == "")
            {
                MessageBox.Show("Cells the name empty", "waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Set Data
                    // Check if Add or Edit
                    if (id == 0)
                    {    // Add
                        supplier = db.Suppliers.Where(x => x.Name == txt_name.Text).FirstOrDefault();
                        if (supplier != null)
                        {
                            MessageBox.Show("Data cannot duplicate", "Duplicate data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            categoire = new Categoire();
                            categoire = db.Categoires.Where(x => x.Cat_Name == combo_category.Text).FirstOrDefault();
                            supplier = new Mercy_Accounting.Supplier
                            {

                                Name = txt_name.Text,
                                Email = txt_email.Text,
                                Phone = txt_phone.Text,
                                Address = txt_Address.Text,
                                Detalies = txt_Detalies.Text,
                                Categorie = Convert.ToInt32(categoire.ID),
                                IBAN = txt_IBAN.Text,
                                ALICI_PTT_MUSTERI_NO = txt_Musteri.Text,
                                ALICI_PTT_HESAP_NO = txt_Hesap.Text,

                            };

                        }
                    }
                    // Edit
                    else
                    {
                        categoire = new Categoire();
                        categoire = db.Categoires.Where(x => x.Cat_Name == combo_category.Text).FirstOrDefault();
                        supplier = new Mercy_Accounting.Supplier
                        {
                            Name = txt_name.Text,
                            Email = txt_email.Text,
                            Phone = txt_phone.Text,
                            Address = txt_Address.Text,
                            Detalies = txt_Detalies.Text,
                            Categorie = Convert.ToInt32(categoire.ID),
                            ID = id,
                            IBAN = txt_IBAN.Text,
                            ALICI_PTT_MUSTERI_NO = txt_Musteri.Text,
                            ALICI_PTT_HESAP_NO = txt_Hesap.Text,
                        };
                    }
                    loading.Visible = true;
                    
                    var result = await Task.Run(() => AddOrEdit(supplier));
                    if (result == true)
                    {
                        toastNotificationsManager1.ShowNotification("96616aac-b9fe-45d7-8bb1-5cd04f388f4c");
                    }
                    Close();
                }
                catch 
                {

                    MessageBox.Show("خطأ في الاتصال", "تأكد من الاتصال في السيرفر لطفا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loading.Visible = false;
            }
        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {
            db = new DB_MercyEntities();
            combo_category.DataSource = db.Categoires.Select(x => x.Cat_Name).ToList();
            if (id != 0)
            {
                combo_category.Text = cat_name;
            }
        }

        private bool AddOrEdit(Mercy_Accounting.Supplier Data)
        {
            try
            {
                db = new DB_MercyEntities();
                db.Set<Mercy_Accounting.Supplier>().AddOrUpdate(Data);
                db.SaveChanges();
                state = true;

            }
            catch (Exception)
            {

                state = false; 
            }
          return state;
        }

    }
}