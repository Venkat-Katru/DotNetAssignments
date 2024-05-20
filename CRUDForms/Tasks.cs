using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDForms
{
    public class TaskItem
    {
        private int Id;
        private string Task;
        private string Description;


        public TaskItem() { }

        public TaskItem(int id, string task, string description)
        {
            this.Id = id;
            this.Task = task;
            this.Description = description;
        }

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string task
        {

            get { return Task; }
            set { Task = value; }
        }

        public string description
        {
            get { return Description; }
            set { Description = value; }

        }
    }
}
