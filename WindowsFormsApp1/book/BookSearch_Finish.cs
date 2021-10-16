using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.book
{
    public partial class BookSearch_Finish : Form
    {
        public BookSearch_Finish()
        {
            InitializeComponent();
        }
        private static string SQL_Code;
       
        private void UpdateSqlForDataGrid()
        {
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.DataSource = new MSql().SelectDataSource(SQL_Code);
        }
        public void Get_SQL_Code(string _SQL_Code) { SQL_Code = _SQL_Code; }

        private void BookSearch_Finish_Load(object sender, EventArgs e)
        {
            UpdateSqlForDataGrid();
        }
    }
}
