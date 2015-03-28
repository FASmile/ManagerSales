using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectNhom.Class;
using ProjectNhom.DAO;
using System.IO;

namespace ProjectNhom
{
    public partial class FManagerEmployees : Form
    {
        DataGridView dataGridView;
        ManagerEmployees mEmp;

        public FManagerEmployees()
        {
            mEmp = new ManagerEmployees();
            InitializeComponent();

            dataGridView = new DataGridView();
            dataGridView.Width = dataGridView1.Width;
            dataGridView.Height = dataGridView1.Height;
            dataGridView.Left = dataGridView1.Left;
            dataGridView.Top = dataGridView1.Top;
            dataGridView.ColumnCount = 14;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoGenerateColumns = false;

            dataGridView.Columns[0].Name = "empid";
            dataGridView.Columns[1].Name = "lastname";
            dataGridView.Columns[2].Name = "firstname";
            dataGridView.Columns[3].Name = "title";
            dataGridView.Columns[4].Name = "titleofcourtesy";
            dataGridView.Columns[5].Name = "birthdate";
            dataGridView.Columns[6].Name = "hiredate";
            dataGridView.Columns[7].Name = "address";
            dataGridView.Columns[8].Name = "city";
            dataGridView.Columns[9].Name = "region";
            dataGridView.Columns[10].Name = "postalcode";
            dataGridView.Columns[11].Name = "country";
            dataGridView.Columns[12].Name = "phone";
            dataGridView.Columns[13].Name = "mgrid";

            this.Controls.Add(dataGridView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tSQLFundamentals2008DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.tSQLFundamentals2008DataSet.Employees);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        bool searching = false;

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            if (cbTypeSearch.Text != "" && txtSearch.Text != "")
            {
                if (!searching)
                {
                    searching = true;
                    btnSearch.Text = "Cancel";
                    dataGridView1.Visible = false;
                    dataGridView.Visible = true;

                    List<Object> obje;
                    if (cbTypeSearch.Text.Contains("Id"))
                        obje = mEmp.search(int.Parse(txtSearch.Text));
                    else
                        obje = mEmp.search(txtSearch.Text);

                    foreach(Object empl in obje){
                        dataGridView.Rows.Add(((Employees)empl).getEmpid(),((Employees)empl).getLastName()
                      , ((Employees)empl).getFirstName()
                      , ((Employees)empl).getTitle()
                      , ((Employees)empl).getTitleOfCourtesy()
                      , ((Employees)empl).getBirthday()
                      , ((Employees)empl).getHiredate()
                      , ((Employees)empl).getAddress()
                      , ((Employees)empl).getCity()
                      , ((Employees)empl).getRegion()
                      , ((Employees)empl).getPostcode()
                      , ((Employees)empl).getCountry()
                      , ((Employees)empl).getPhone());
                    }
                }
                else
                {

                    btnSearch.Text = "Search";
                    dataGridView1.Visible = true;
                    dataGridView.Visible = false;
                    searching = false;
                }
            }
            
        }

        private List<object> search(string p)
        {
            throw new NotImplementedException();
        }

        private List<object> search(int p)
        {
            throw new NotImplementedException();
        }

        private void haiToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.Hai(this.tSQLFundamentals2008DataSet.Employees);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void haiToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.Hai(this.tSQLFundamentals2008DataSet.Employees);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fASToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.FAS(this.tSQLFundamentals2008DataSet.Employees);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void clean()
        {

            txtLastName.Text = "";
            lblId.Text = "0";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtTitle.Text = "";
            txtTitleOfCourtesy.Text = "";
            dtpBirthdate.Value = DateTime.Today;
            dtpHiredate.Value = DateTime.Today;
            txtAddress.Text = "";
            txtRegion.Text = "";
            txtPhone.Text = "";
            txtPostalCode.Text = "";
            cbCountry.Text = "";
            txtPhone.Text = "";
            //txtMgrid.Text = "";
            updateDataGridView();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            clean();
        }

        private Employees getEmp()
        {
            Employees emp = new Employees();
            try
            {
                emp.setId(int.Parse(lblId.Text));
                emp.setLastName(txtLastName.Text);
                emp.setFirstName(txtFirstName.Text);
                emp.setTitle(txtTitle.Text);
                emp.setTitleOfCourtesy(txtTitleOfCourtesy.Text);

                emp.setBirthday(dtpBirthdate.Value.ToShortDateString().ToString());
                emp.setHiredate(dtpBirthdate.Value.ToShortDateString().ToString());

                emp.setAddress(txtAddress.Text);
                emp.setCity(txtRegion.Text);
                emp.setRegion(cbCity.Text);
                emp.setPostcode(txtPostalCode.Text);
                emp.setCountry(cbCountry.Text);
                emp.setPhone(txtPhone.Text);
            }
            catch (Exception ex)
            {
                return null;
            }

            return emp;
        }

        private void updateDataGridView()
        {
            //update Data table
            this.employeesTableAdapter.Fill(this.tSQLFundamentals2008DataSet.Employees);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mEmp.add(getEmp());
            updateDataGridView();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    DataGridViewRow r = dataGridView1.SelectedRows[i];
                    mEmp.delete(int.Parse(r.Cells[0].Value.ToString()));
                }
                updateDataGridView();
            }


        }

        bool startUpdate = false;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!startUpdate)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dataGridView1.CurrentRow;

                    lblId.Text = r.Cells[0].Value.ToString();
                    txtLastName.Text = r.Cells[1].Value.ToString();
                    txtFirstName.Text = r.Cells[2].Value.ToString();
                    txtTitle.Text = r.Cells[3].Value.ToString();
                    txtTitleOfCourtesy.Text = r.Cells[4].Value.ToString();
                    dtpBirthdate.Value = DateTime.Parse(r.Cells[5].Value.ToString());
                    dtpHiredate.Value = DateTime.Parse(r.Cells[6].Value.ToString());
                    txtAddress.Text = r.Cells[7].Value.ToString();
                    cbCity.Text = r.Cells[8].Value.ToString();
                    txtRegion.Text = r.Cells[9].Value.ToString();
                    txtPostalCode.Text = r.Cells[10].Value.ToString();
                    cbCountry.Text = r.Cells[11].Value.ToString();
                    txtPhone.Text = r.Cells[12].Value.ToString();

                    btnUpdate.Text = "Cancel";
                    startUpdate = true;
                    btnAdd.Enabled = !startUpdate;
                    btnDel.Enabled = !startUpdate;
                    btnNew.Enabled = !startUpdate;
                    btnSearch.Enabled = !startUpdate;
                }
            }
            else
            {
                btnUpdate.Text = "Update";
                mEmp.update(getEmp());
                updateDataGridView();
                startUpdate = false;
                btnAdd.Enabled = !startUpdate;
                btnDel.Enabled = !startUpdate;
                btnNew.Enabled = !startUpdate;
                btnSearch.Enabled = !startUpdate;
                clean();

            }
        }

    }
}
