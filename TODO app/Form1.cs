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
            switch(page)
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
                case "create":
                    pageLabel.Text = "Create new task";
                    break;
                default:
                    pageLabel.Text = "Main page";
                    break;
            }
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
            setPage();
        }

        private void comptasks_Click(object sender, EventArgs e)
        {
            page = "completed";
            setPage();

        }

        private void deltasks_Click(object sender, EventArgs e)
        {
            page = "deleted";
            setPage();

        }

        private void createtasks_Click(object sender, EventArgs e)
        {
            page = "create";
            setPage();
        }
    }
}
