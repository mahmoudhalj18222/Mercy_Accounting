using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Mercy_Accounting.Form_2
{
    public partial class Export_Excel : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        DB_MercyEntities db;
        TB_Project _project;
        Mercy_Accounting.Supplier sup;
        TB_Monthly_Report Report;
        public Export_Excel()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel (*.xlsx)|*.xlsx";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = ofd.FileName;
            }
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txt_path.Text + ";Extended Properties='Excel 12.0;HDR=NO';");
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from[" + txt_sheet.Text + "$]", conn);
                dt.Clear();
                da.Fill(dt);
                gridControl1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Please check the page name", "Error in data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_import_Excel_to_sql_Click(object sender, EventArgs e)
        {
            string tabel_name = comboBoxEdit1.Text;
            if (tabel_name == "Supplier")
            {
                int index = dt.Columns.Count;
                foreach (DataRow row in dt.Rows)
                {
                    try
                    {
                        db = new DB_MercyEntities();
                        string name_supplier = row[0].ToString();
                        sup = db.Suppliers.Where(x => x.Name == name_supplier).FirstOrDefault();
                        if (sup == null)
                        {
                            sup = new Mercy_Accounting.Supplier();
                            Categoire cat = new Categoire();
                            sup.Name = row[0].ToString();
                            if (index > 1)
                            {
                                sup.Address = row[1].ToString();
                            }
                            if (index > 2)
                            {
                                sup.Detalies = row[2].ToString();
                            }
                            if (index > 3)
                            {
                                sup.Phone = row[3].ToString();
                            }
                            if (index > 4)
                            {
                                    sup.Categorie = 9;
                                
                               
                            }
                            if (index > 5)
                            {
                                sup.Email = row[5].ToString();
                            }
                            if (index > 6)
                            {
                                sup.IBAN = row[6].ToString();
                            }
                            if (index > 7)
                            {
                                sup.ALICI_PTT_HESAP_NO = row[7].ToString();
                            }
                            if (index > 8)
                            {
                                sup.ALICI_PTT_MUSTERI_NO = row[8].ToString();
                            }
                            db.Suppliers.Add(sup);
                            db.SaveChanges();
                        }

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Incorrect data", "Error in data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (tabel_name == "Report")
            {
                int index = dt.Columns.Count;
                int indexRow = dt.Rows.Count;
                double debet;
                foreach (DataRow row in dt.Rows)
                {
                    if (row[1].ToString()== "QB")
                    { continue;
                    }
                    DateTime d1;
                    MessageBox.Show(row[0].ToString());
                    db = new DB_MercyEntities();
                    Report = new TB_Monthly_Report();
                    Report.SN = row[0].ToString();
                    Report.QB = row[1].ToString();
                    if (DateTime.TryParse(row[2].ToString(), out d1))
                        { Report.Date = Convert.ToDateTime(row[2].ToString()); }
                    
                    Report.Name = row[3].ToString();
                    if (Double.TryParse(row[4].ToString(), out debet)) { Report.Debit = Convert.ToDouble(row[4].ToString()); }
                    if (Double.TryParse(row[5].ToString(), out debet)) { Report.Credit = Convert.ToDouble(row[5].ToString()); }
                    Report.Postion = row[6].ToString();
                    Report.Project = row[7].ToString();
                    Report.Caught = row[8].ToString();
                    Report.Type = row[9].ToString();
                    if (!string.IsNullOrEmpty(row[10].ToString()))
                    { Report.Zoho = Convert.ToInt16(row[10].ToString()); }
                    
                    Report.Payroll = row[11].ToString();
                    Report.Monthly = row[12].ToString();
                    Report.Annual = row[13].ToString();
                    Report.Link = row[14].ToString();
                    Report.Note = row[15].ToString();
                    db.TB_Monthly_Report.Add(Report);
                    db.SaveChanges();

                }
            }
        }
    
    
    }
}