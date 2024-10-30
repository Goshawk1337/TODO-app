using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO_app
{
    public partial class Form1 : Form
    {
        string page;
        string title;
        string desc;
        public void setPage()
        {
            //changing the label text on the form
            switch (page)
            {
                case "main":
                    pageLabel.Text = "Main page";
                    set_to_deleted.Show();
                    set_to_complete.Show();
                    break;
                case "completed":
                    pageLabel.Text = "Completed tasks";
                    set_to_deleted.Hide();
                    set_to_complete.Hide();
                    break;
                case "deleted":
                    pageLabel.Text = "Deleted tasks";
                    set_to_deleted.Hide();
                    set_to_complete.Hide();
                    break;
                default:
                    pageLabel.Text = "Main page";
                    break;
            }
        }

        public string createTask()
        {
            string msg;
            // checking if everything is alright with the inputs
            if (title_inp.Text.Length < 3)
            {
                msg = "The Title is not long enough.";
                return msg;
            }
            if (desc_input.Text.Length < 3 || desc_input.Text.Length > 300)
            {
                msg = "The description is too short or too long.";
                return msg;
            }

            dt.Rows.Add(title_inp.Text, desc_input.Text);
            msg = "Successfully added a new task.";
            title_inp.Text = "";
            desc_input.Text = "";
            return msg;
        }
        public Form1()
        {
            InitializeComponent();
            //string connectionStr = "Server=localhost;Database=master;Trusted_Connection=True;";
            //SqlConnection con = new SqlConnection(connectionStr);
            //con.Open();
            page = "main";
            todoList.Show();
            deleted_tasks.Hide();
            completed_tasks.Hide();

        }

        private void mainpage_Click(object sender, EventArgs e)
        {
            page = "main";
            todoList.Show();
            deleted_tasks.Hide();
            completed_tasks.Hide();
            setPage();
        }

        private void comptasks_Click(object sender, EventArgs e)
        {
            page = "completed";
            todoList.Hide();
            deleted_tasks.Hide();
            completed_tasks.Show();
            setPage();

        }

        private void deltasks_Click(object sender, EventArgs e)
        {
            page = "deleted";
            todoList.Hide();
            deleted_tasks.Show();
            completed_tasks.Hide();

            setPage();

        }

        private void createtasks_Click(object sender, EventArgs e)
        {
            string task = createTask();
            MessageBox.Show(task);
        }


        DataTable dt = new DataTable();
        DataTable deletedTasks = new DataTable();
        DataTable completedTasks = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            //adding columns
            dt.Columns.Add("Title");
            dt.Columns.Add("Description");
            deletedTasks.Columns.Add("Title");
            deletedTasks.Columns.Add("Description");
            deletedTasks.Columns.Add("Deleted at");
            completedTasks.Columns.Add("Title");
            completedTasks.Columns.Add("Description");
            completedTasks.Columns.Add("Completed at");
            todoList.DataSource = dt;
            deleted_tasks.DataSource = deletedTasks;
            completed_tasks.DataSource = completedTasks;
        }

        private void set_to_complete_Click(object sender, EventArgs e)
        {
            //uploading task to the sql, and moving to deleted tasks.

            DateTime dateTime = DateTime.UtcNow.Date;
            int selected = todoList.CurrentCell.RowIndex;
            title = dt.Rows[selected]["Title"].ToString();
            desc = dt.Rows[selected]["Description"].ToString();
            completedTasks.Rows.Add(title, desc, dateTime.ToString("yyyy/MM/d"));
            //deleting the selected task
            dt.Rows[selected].Delete();

        }

        private void set_to_deleted_Click(object sender, EventArgs e)
        {
            //uploading task to the sql, and moving to deleted tasks.

            DateTime dateTime = DateTime.UtcNow.Date;
            int selected = todoList.CurrentCell.RowIndex;
            title = dt.Rows[selected]["Title"].ToString();
            desc = dt.Rows[selected]["Description"].ToString();
            deletedTasks.Rows.Add(title, desc, dateTime.ToString("yyyy/MM/d"));
            //deleting the selected task
            dt.Rows[selected].Delete();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
