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

namespace Mercy_Accounting.Form
{
    public partial class Add_Expansess : DevExpress.XtraEditors.XtraForm
    {
        //init
        DB_MercyEntities db;
        TB_Expensse _Expensse;
        Mercy_Accounting.Supplier supplier;
        Class.Method ma = new Class.Method();
        public int id = 0;

        public Add_Expansess()
        {
            InitializeComponent();
        }
        private void btnAddEdit_Click(object sender, EventArgs e)
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
                    if (id == 0)
                    {
                        _Expensse = new TB_Expensse();
                        pictureEdit1.Image.Save(ma.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                        _Expensse.Image = ma.convert_byte();
                        _Expensse.Abut_Month = txt_Abut.Text;
                        _Expensse.Name = txt_name.Text;
                        _Expensse.Position = txt_Pos.Text;
                        _Expensse.Amount = Convert.ToDouble(txt_amount.Text);
                        _Expensse.Project = txt_project.Text;
                        _Expensse.date = txt_date.Value;
                        _Expensse.detatils = txt_note.Text;
                        _Expensse.Tybe = txt_type.Text;
                        db.TB_Expensse.Add(_Expensse);
                        db.SaveChanges();
                    }
                    else
                    {
                        _Expensse = new TB_Expensse();
                        pictureEdit1.Image.Save(ma.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                        _Expensse.Image = ma.convert_byte();
                        _Expensse.Abut_Month = txt_Abut.Text;
                        _Expensse.Name = txt_name.Text;
                        _Expensse.Position = txt_Pos.Text;
                        _Expensse.Amount = Convert.ToDouble(txt_amount.Text);
                        _Expensse.Project = txt_project.Text;
                        _Expensse.date = txt_date.Value;
                        _Expensse.ID = id;
                        _Expensse.detatils = txt_note.Text;
                        _Expensse.Tybe = txt_type.Text;
                        db.Entry(_Expensse).State = EntityState.Modified;
                        db.SaveChanges();
                        Close();
                      
                    }
                }
                catch
                {

                    MessageBox.Show("Error in connication Data base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Add_Expansess_Load(object sender, EventArgs e)
        {
            db = new DB_MercyEntities();
            
            if (id == 0)
            {
                txt_name.DataSource = db.Suppliers.Select(x => x.Name).ToList();
                txt_project.DataSource = db.TB_Project.Select(x => x.Pro_Name).ToList();
                txt_type.DataSource = db.Categoires.Select(x => x.Cat_Name).ToList();
            }
        }

        private void txt_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new DB_MercyEntities();
            supplier = new Mercy_Accounting.Supplier();
            Categoire categoire = new Categoire();
            supplier = db.Suppliers.Where(x => x.Name == txt_name.Text).FirstOrDefault();
            categoire = db.Categoires.Where(x => x.ID == supplier.Categorie).FirstOrDefault();
            txt_type.Text = categoire.Cat_Name; 
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.SelectedIndex = 0;
            txt_Pos.SelectedIndex = 0;
            txt_Pos.SelectedIndex = 0;
            txt_type.SelectedIndex = 0;
            txt_amount.Text = "0";
            txt_note.Text = "";
        }
    }
}