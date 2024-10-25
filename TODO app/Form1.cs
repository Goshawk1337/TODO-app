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
        public void setPage()
        {
            //changing the label text on the form
            switch (page)
            {
                case "main":
                    pageLabel.Text = "Main page";
                    break;
                case "completed":
                    pageLabel.Text = "Completed tasks";
                    break;
                case "deleted":
                    pageLabel.Text = "Deleted tasks";
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
        }

        private void mainpage_Click(object sender, EventArgs e)
        {
            page = "main";
            todoList.Show();
            deleted_tasks.Hide();

            setPage();
        }

        private void comptasks_Click(object sender, EventArgs e)
        {
            page = "completed";
            todoList.Hide();
            deleted_tasks.Hide();

            setPage();

        }

        private void deltasks_Click(object sender, EventArgs e)
        {
            page = "deleted";
            todoList.Hide();
            deleted_tasks.Show();
            setPage();

        }

        private void createtasks_Click(object sender, EventArgs e)
        {
            string task = createTask();
            MessageBox.Show(task);
        }


        DataTable dt = new DataTable();
        DataTable deletedTasks = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            //adding columns
            dt.Columns.Add("Title");
            dt.Columns.Add("Description");
            deletedTasks.Columns.Add("Title");
            deletedTasks.Columns.Add("Description");
            deletedTasks.Columns.Add("Deleted at");

            todoList.DataSource = dt;
            deleted_tasks.DataSource = deletedTasks;
        }

        private void set_to_complete_Click(object sender, EventArgs e)
        {
            //deleting the selected task

            //moving to completed.

        }

        private void set_to_deleted_Click(object sender, EventArgs e)
        {
            //uploading task to the sql, and moving to deleted tasks.

            string title;
            string desc;
            DateTime dateTime = DateTime.UtcNow.Date;
            int selected = todoList.CurrentCell.RowIndex;
            title = dt.Rows[selected]["Title"].ToString();
            desc = dt.Rows[selected]["Description"].ToString();

            //deleting the selected task
            dt.Rows[selected].Delete();

        }
    }
}
