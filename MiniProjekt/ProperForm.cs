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
    using MiniProjekt.DAL;

    public partial class ProperForm : Form
    {
        public ProperForm()
        {
            InitializeComponent();
            ConnectData();
        }

        private void ConnectData()
        {
            FromSubiekt.DataSource = DataService.GetAllEmails();
            //FromEnova.DataSource = DbAdresses.GetAllAdresses();
        }

        private void DeleteS_Click(object sender, EventArgs e)
        {
            DataService.DeleteRow();
            Console.WriteLine("Something happened");
        }
    }
}