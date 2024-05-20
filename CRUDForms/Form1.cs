using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUDForms
{
    public partial class Form1 : Form
    {
        List<TaskItem> taskList = new List<TaskItem>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                DataPropertyName = "id",
                HeaderText = "ID"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Task",
                DataPropertyName = "task",
                HeaderText = "Task"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                DataPropertyName = "description",
                HeaderText = "Description"
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string task = textBox2.Text;
            string description = textBox3.Text;

            TaskItem t = new TaskItem(id, task, description);
            taskList.Add(t);
            MessageBox.Show("Added Succesfully");

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string task = textBox2.Text;
            string description = textBox3.Text;

            
            TaskItem taskToUpdate = taskList.Find(t => t.id == id);

            if (taskToUpdate != null)
            {
                
                taskToUpdate.task = task;
                taskToUpdate.description = description;

                
                MessageBox.Show("Task updated successfully.");
            }
            else
            {
                
                MessageBox.Show("Task not found.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            
            TaskItem taskToDelete = taskList.Find(t => t.id == id);

            if (taskToDelete != null)
            {
                
                taskList.Remove(taskToDelete);

                
                MessageBox.Show("Task deleted successfully.");
            }
            else
            {
                
                MessageBox.Show("Task not found.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = taskList;
        }
    }
}
