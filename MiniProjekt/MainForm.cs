using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjekt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PrepareData();
        }

        private void PrepareData()
        {
            DataTable dt = new DataTable();

            //Adding columns in DataTable
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("Something", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));

            //Adding Data in DataTable
            dt.Rows.Add(new object[] { "Ola", 20, "abc", Convert.ToDateTime("15-01-02") });
            dt.Rows.Add(new object[] { "Szymuś", 21, "xyz", Convert.ToDateTime("04-12-00") });
            dt.Rows.Add(new object[] { "Marlenka", 20, "sth", Convert.ToDateTime("21-04-02") });

            //Binf the DataTable in grid
            gridControl.DataSource = dt;
        }
    }
}
