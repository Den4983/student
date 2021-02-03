using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
{
    public partial class Form1 : Form
    {
        //static int max;
        StDbContext db;
            SqlConnection connection;
            DataSet set = null;
            SqlDataAdapter adapter = null;
        public Form1()
        {
            db = new StDbContext();
           // max = db.Groups.LastOrDefault().id;
            string conString = ConfigurationManager
                .ConnectionStrings["defaultConnection"]
                .ConnectionString;
            connection = new SqlConnection(conString);
            set = new DataSet();
            
            InitializeComponent();
        }
        private void delFu()
        {
            
            SqlCommand cmd = new SqlCommand("delF", connection);

            adapter.UpdateCommand = cmd;
            adapter.InsertCommand = cmd;
            adapter.DeleteCommand = cmd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 
        }

        private void btnGetSt_Click(object sender, EventArgs e)
        {
            
            try
            { 
                adapter = new SqlDataAdapter("select * from Students", connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
                delFu();
                set.Tables.Clear();
                adapter.Fill(set, "bufer");
                dgvMain.DataSource = set.Tables["bufer"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
            
        }

        private void btnGetGr_Click(object sender, EventArgs e)
        {
            try
            {
                adapter = new SqlDataAdapter("select * from Groups", connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
                delFu();
                set.Tables.Clear();
                adapter.Fill(set, "bufer");
                dgvMain.DataSource = set.Tables["bufer"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
            
        }

        private void btnInsSt_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(/*max*/);
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.Cancel)
                return;
            Student student = new Student()
            {
                Name = f.txtName.Text,
                Email = f.txtEmail.Text,
                GroupId = (int)f.numericUpDown1.Value
            };
            db.Students.Add(student);
            db.SaveChanges();
        }

        private void UpdSt_Click(object sender, EventArgs e)
        {
            if(dgvMain.SelectedRows.Count>0)
            {
              int rowI = dgvMain.SelectedRows[0].Index;
              int id = (int)dgvMain[0, rowI].Value;
                Student student = db.Students.Find(id);
                Form2 f = new Form2();
                f.txtEmail.Text = student.Email;
                f.txtName.Text = student.Name;
                if (student.GroupId == null)
                    student.GroupId = 0;
                    f.numericUpDown1.Value = (decimal)student.GroupId;
             

                  DialogResult res = f.ShowDialog();
                if (res == DialogResult.Cancel)
                    return;
                
                student.Name = f.txtName.Text;
                student.Email = f.txtEmail.Text;
                student.GroupId = (int)f.numericUpDown1.Value;
               
                db.SaveChanges();
                
            }
        }

        private void btnDelSt_Click(object sender, EventArgs e)
        {
            int rowI = dgvMain.SelectedRows[0].Index;
            int id = (int)dgvMain[0, rowI].Value;
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
        }

        private void btnInsGr_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.Cancel)
                return;

            //SqlCommand cmd = new SqlCommand("InsGr", connection)
            //{ CommandType = CommandType.StoredProcedure };

            //cmd.Parameters.Add("@title", SqlDbType.NVarChar, 50).Value=f.txtTitle.Text;

            //adapter.InsertCommand = cmd;

            //adapter.Update(set, "bufer");
            SqlCommand cmd = new SqlCommand("InsGr", connection)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.Add("@title", SqlDbType.NVarChar, 50).Value=f.txtTitle.Text;
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);

            //set.Tables.Clear();
            adapter.Fill(set, "bufer");
            //dgvMain.DataSource = set.Tables["bufer"];
            //dgvMain.Refresh();
        }

        private void btnUpdGr_Click(object sender, EventArgs e)
        {
            int rowI = dgvMain.SelectedRows[0].Index;
            int id = (int)dgvMain[0, rowI].Value;

            Form3 f = new Form3();

            DialogResult res = f.ShowDialog();
            if (res == DialogResult.Cancel)
                return;

            SqlCommand cmd = new SqlCommand("UpdGr", connection)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.Add("@title", SqlDbType.NVarChar, 50).Value = f.txtTitle.Text;
            cmd.Parameters.Add("@_id", SqlDbType.Int, 0).Value = id;
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
            adapter.Fill(set, "bufer");
        }

        private void btnDelGr_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.Cancel)
                return;
            SqlCommand cmd = new SqlCommand("DelGr", connection)
            { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.Add("@title", SqlDbType.NVarChar, 50).Value = f.txtTitle.Text;
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
            adapter.Fill(set, "bufer");
        }
    }
}
