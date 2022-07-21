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
        private AdressRepository _adressRepository;
        public ProperForm()
        {
            InitializeComponent();
            _adressRepository = new AdressRepository();
            ConnectData();

            WindowState = FormWindowState.Maximized;
        }

        private void ConnectData()
        {
            FromSubiekt.DataSource = DataService.GetAllEmails();
            FromEnova.DataSource = _adressRepository.GetAllAdresses();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Console.WriteLine("ok");
        }
    }
}