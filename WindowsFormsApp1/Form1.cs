using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TodoList : Form
    {
        public TodoList()
        {
            InitializeComponent();
        }
        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            // Point our datagridview to our datasource
            toDoListView.DataSource = todoList;

        }

     

      

        private void button1_Click(object sender, EventArgs e)
        {
            TITLE.Text = "";
            Description.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // Fill text fields with data from table
            TITLE.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            Description.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void SAVEBUTT_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = TITLE.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = Description.Text;
            }
            else
            {
                todoList.Rows.Add(TITLE.Text, Description.Text);
            }
            // Clear fields
            TITLE.Text = "";
            Description.Text = "";
            isEditing = false;
        }
        private void DELETBUTT_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

      
    }
}