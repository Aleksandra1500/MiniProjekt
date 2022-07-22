﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

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
            //// This line of code is generated by Data Source Configuration Wizard
            //// Instantiate a new DBContext
            //MiniProjekt.DAL.DbAdresses dbContext = new MiniProjekt.DAL.DbAdresses();
            //// Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            //dbContext.Adresy.LoadAsync().ContinueWith(loadTask =>
            //{
            //    // Bind data to control when loading complete
            //    FromEnova.DataSource = dbContext.Adresy.Local.ToBindingList();
            //}, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            // This line of code is generated by Data Source Configuration Wizard
            adresyTableAdapter1.Fill(firma_demoDataSet1.Adresy);
        }

        private void ConnectData()
        {
            FromSubiekt.DataSource = DataService.GetAllEmails();
            //FromEnova.DataSource = _adressRepository.GetAllAdresses();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Console.WriteLine("ok");
        }
    }
}