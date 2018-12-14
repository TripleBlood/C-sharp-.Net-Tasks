using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTasks
{
    class DBConnection
    {
        private string con = "Data Source=LAPTOP-77SQ07N0;Initial Catalog=Spell_task_db;Integrated Security=True";

        public string Con
        {
            get
            {
                return con;
            }
        }
    }
}
