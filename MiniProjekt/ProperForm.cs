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
using System.Data.Entity;

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
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            MiniProjekt.Models.OlaEntities dbContext = new MiniProjekt.Models.OlaEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.sl_GrupaTw.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                FromSubiekt.DataSource = dbContext.sl_GrupaTw.Local.ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void ConnectData()
        {
            //FromSubiekt.DataSource = DataService.GetAllEmails();
            FromEnova.DataSource = _adressRepository.GetAllAdresses();
            //FromEnova.DataSource = 
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Console.WriteLine("ok");
        }
    }
}