
namespace MiniProjekt
{
    partial class ProperForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FromSubiekt = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FromEnova = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHostType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTyp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresKodPocztowy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresZagranicznyKodPocztowy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresPoczta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresMiejscowosc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresGmina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresPowiat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresWojewodztwo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresKraj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresKodKraju = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresUlica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresNrDomu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresNrLokalu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresNietypowaLokalizacja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresFaks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentyfikacjaAdresuGLN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStamp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProperFormlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.FromSubiektitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.FromEnovaitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromSubiekt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromEnova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProperFormlayoutControl1ConvertedLayout)).BeginInit();
            this.ProperFormlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromSubiektitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromEnovaitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.FromSubiekt;
            this.gridView3.Name = "gridView3";
            // 
            // FromSubiekt
            // 
            this.FromSubiekt.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.FromSubiekt.DataSource = typeof(MiniProjekt.Models.sl_GrupaTw);
            this.FromSubiekt.Location = new System.Drawing.Point(12, 12);
            this.FromSubiekt.MainView = this.gridView1;
            this.FromSubiekt.Name = "FromSubiekt";
            this.FromSubiekt.Size = new System.Drawing.Size(312, 542);
            this.FromSubiekt.TabIndex = 0;
            this.FromSubiekt.UseEmbeddedNavigator = true;
            this.FromSubiekt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3});
            this.FromSubiekt.Click += new System.EventHandler(this.FromSubiekt_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.FromSubiekt;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Add new row";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // FromEnova
            // 
            this.FromEnova.DataMember = "Adresy";
            this.FromEnova.Location = new System.Drawing.Point(375, 12);
            this.FromEnova.MainView = this.gridView2;
            this.FromEnova.Name = "FromEnova";
            this.FromEnova.Size = new System.Drawing.Size(824, 542);
            this.FromEnova.TabIndex = 3;
            this.FromEnova.UseEmbeddedNavigator = true;
            this.FromEnova.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colHost,
            this.colHostType,
            this.colTyp,
            this.colAdresKodPocztowy,
            this.colAdresZagranicznyKodPocztowy,
            this.colAdresPoczta,
            this.colAdresMiejscowosc,
            this.colAdresGmina,
            this.colAdresPowiat,
            this.colAdresWojewodztwo,
            this.colAdresKraj,
            this.colAdresKodKraju,
            this.colAdresUlica,
            this.colAdresNrDomu,
            this.colAdresNrLokalu,
            this.colAdresNietypowaLokalizacja,
            this.colAdresTelefon,
            this.colAdresFaks,
            this.colIdentyfikacjaAdresuGLN,
            this.colStamp});
            this.gridView2.GridControl = this.FromEnova;
            this.gridView2.Name = "gridView2";
            this.gridView2.NewItemRowText = "Add new row";
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colHost
            // 
            this.colHost.FieldName = "Host";
            this.colHost.MinWidth = 25;
            this.colHost.Name = "colHost";
            this.colHost.Visible = true;
            this.colHost.VisibleIndex = 1;
            this.colHost.Width = 94;
            // 
            // colHostType
            // 
            this.colHostType.FieldName = "HostType";
            this.colHostType.MinWidth = 25;
            this.colHostType.Name = "colHostType";
            this.colHostType.Visible = true;
            this.colHostType.VisibleIndex = 2;
            this.colHostType.Width = 94;
            // 
            // colTyp
            // 
            this.colTyp.FieldName = "Typ";
            this.colTyp.MinWidth = 25;
            this.colTyp.Name = "colTyp";
            this.colTyp.Visible = true;
            this.colTyp.VisibleIndex = 3;
            this.colTyp.Width = 94;
            // 
            // colAdresKodPocztowy
            // 
            this.colAdresKodPocztowy.FieldName = "AdresKodPocztowy";
            this.colAdresKodPocztowy.MinWidth = 25;
            this.colAdresKodPocztowy.Name = "colAdresKodPocztowy";
            this.colAdresKodPocztowy.Visible = true;
            this.colAdresKodPocztowy.VisibleIndex = 4;
            this.colAdresKodPocztowy.Width = 94;
            // 
            // colAdresZagranicznyKodPocztowy
            // 
            this.colAdresZagranicznyKodPocztowy.FieldName = "AdresZagranicznyKodPocztowy";
            this.colAdresZagranicznyKodPocztowy.MinWidth = 25;
            this.colAdresZagranicznyKodPocztowy.Name = "colAdresZagranicznyKodPocztowy";
            this.colAdresZagranicznyKodPocztowy.Visible = true;
            this.colAdresZagranicznyKodPocztowy.VisibleIndex = 5;
            this.colAdresZagranicznyKodPocztowy.Width = 94;
            // 
            // colAdresPoczta
            // 
            this.colAdresPoczta.FieldName = "AdresPoczta";
            this.colAdresPoczta.MinWidth = 25;
            this.colAdresPoczta.Name = "colAdresPoczta";
            this.colAdresPoczta.Visible = true;
            this.colAdresPoczta.VisibleIndex = 6;
            this.colAdresPoczta.Width = 94;
            // 
            // colAdresMiejscowosc
            // 
            this.colAdresMiejscowosc.FieldName = "AdresMiejscowosc";
            this.colAdresMiejscowosc.MinWidth = 25;
            this.colAdresMiejscowosc.Name = "colAdresMiejscowosc";
            this.colAdresMiejscowosc.Visible = true;
            this.colAdresMiejscowosc.VisibleIndex = 7;
            this.colAdresMiejscowosc.Width = 94;
            // 
            // colAdresGmina
            // 
            this.colAdresGmina.FieldName = "AdresGmina";
            this.colAdresGmina.MinWidth = 25;
            this.colAdresGmina.Name = "colAdresGmina";
            this.colAdresGmina.Visible = true;
            this.colAdresGmina.VisibleIndex = 8;
            this.colAdresGmina.Width = 94;
            // 
            // colAdresPowiat
            // 
            this.colAdresPowiat.FieldName = "AdresPowiat";
            this.colAdresPowiat.MinWidth = 25;
            this.colAdresPowiat.Name = "colAdresPowiat";
            this.colAdresPowiat.Visible = true;
            this.colAdresPowiat.VisibleIndex = 9;
            this.colAdresPowiat.Width = 94;
            // 
            // colAdresWojewodztwo
            // 
            this.colAdresWojewodztwo.FieldName = "AdresWojewodztwo";
            this.colAdresWojewodztwo.MinWidth = 25;
            this.colAdresWojewodztwo.Name = "colAdresWojewodztwo";
            this.colAdresWojewodztwo.Visible = true;
            this.colAdresWojewodztwo.VisibleIndex = 10;
            this.colAdresWojewodztwo.Width = 94;
            // 
            // colAdresKraj
            // 
            this.colAdresKraj.FieldName = "AdresKraj";
            this.colAdresKraj.MinWidth = 25;
            this.colAdresKraj.Name = "colAdresKraj";
            this.colAdresKraj.Visible = true;
            this.colAdresKraj.VisibleIndex = 11;
            this.colAdresKraj.Width = 94;
            // 
            // colAdresKodKraju
            // 
            this.colAdresKodKraju.FieldName = "AdresKodKraju";
            this.colAdresKodKraju.MinWidth = 25;
            this.colAdresKodKraju.Name = "colAdresKodKraju";
            this.colAdresKodKraju.Visible = true;
            this.colAdresKodKraju.VisibleIndex = 12;
            this.colAdresKodKraju.Width = 94;
            // 
            // colAdresUlica
            // 
            this.colAdresUlica.FieldName = "AdresUlica";
            this.colAdresUlica.MinWidth = 25;
            this.colAdresUlica.Name = "colAdresUlica";
            this.colAdresUlica.Visible = true;
            this.colAdresUlica.VisibleIndex = 13;
            this.colAdresUlica.Width = 94;
            // 
            // colAdresNrDomu
            // 
            this.colAdresNrDomu.FieldName = "AdresNrDomu";
            this.colAdresNrDomu.MinWidth = 25;
            this.colAdresNrDomu.Name = "colAdresNrDomu";
            this.colAdresNrDomu.Visible = true;
            this.colAdresNrDomu.VisibleIndex = 14;
            this.colAdresNrDomu.Width = 94;
            // 
            // colAdresNrLokalu
            // 
            this.colAdresNrLokalu.FieldName = "AdresNrLokalu";
            this.colAdresNrLokalu.MinWidth = 25;
            this.colAdresNrLokalu.Name = "colAdresNrLokalu";
            this.colAdresNrLokalu.Visible = true;
            this.colAdresNrLokalu.VisibleIndex = 15;
            this.colAdresNrLokalu.Width = 94;
            // 
            // colAdresNietypowaLokalizacja
            // 
            this.colAdresNietypowaLokalizacja.FieldName = "AdresNietypowaLokalizacja";
            this.colAdresNietypowaLokalizacja.MinWidth = 25;
            this.colAdresNietypowaLokalizacja.Name = "colAdresNietypowaLokalizacja";
            this.colAdresNietypowaLokalizacja.Visible = true;
            this.colAdresNietypowaLokalizacja.VisibleIndex = 16;
            this.colAdresNietypowaLokalizacja.Width = 94;
            // 
            // colAdresTelefon
            // 
            this.colAdresTelefon.FieldName = "AdresTelefon";
            this.colAdresTelefon.MinWidth = 25;
            this.colAdresTelefon.Name = "colAdresTelefon";
            this.colAdresTelefon.Visible = true;
            this.colAdresTelefon.VisibleIndex = 17;
            this.colAdresTelefon.Width = 94;
            // 
            // colAdresFaks
            // 
            this.colAdresFaks.FieldName = "AdresFaks";
            this.colAdresFaks.MinWidth = 25;
            this.colAdresFaks.Name = "colAdresFaks";
            this.colAdresFaks.Visible = true;
            this.colAdresFaks.VisibleIndex = 18;
            this.colAdresFaks.Width = 94;
            // 
            // colIdentyfikacjaAdresuGLN
            // 
            this.colIdentyfikacjaAdresuGLN.FieldName = "IdentyfikacjaAdresuGLN";
            this.colIdentyfikacjaAdresuGLN.MinWidth = 25;
            this.colIdentyfikacjaAdresuGLN.Name = "colIdentyfikacjaAdresuGLN";
            this.colIdentyfikacjaAdresuGLN.Visible = true;
            this.colIdentyfikacjaAdresuGLN.VisibleIndex = 19;
            this.colIdentyfikacjaAdresuGLN.Width = 94;
            // 
            // colStamp
            // 
            this.colStamp.FieldName = "Stamp";
            this.colStamp.MinWidth = 25;
            this.colStamp.Name = "colStamp";
            this.colStamp.Visible = true;
            this.colStamp.VisibleIndex = 20;
            this.colStamp.Width = 94;
            // 
            // ProperFormlayoutControl1ConvertedLayout
            // 
            this.ProperFormlayoutControl1ConvertedLayout.Controls.Add(this.simpleButton3);
            this.ProperFormlayoutControl1ConvertedLayout.Controls.Add(this.simpleButton2);
            this.ProperFormlayoutControl1ConvertedLayout.Controls.Add(this.simpleButton1);
            this.ProperFormlayoutControl1ConvertedLayout.Controls.Add(this.FromSubiekt);
            this.ProperFormlayoutControl1ConvertedLayout.Controls.Add(this.FromEnova);
            this.ProperFormlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProperFormlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.ProperFormlayoutControl1ConvertedLayout.Name = "ProperFormlayoutControl1ConvertedLayout";
            this.ProperFormlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.ProperFormlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(1211, 566);
            this.ProperFormlayoutControl1ConvertedLayout.TabIndex = 3;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(328, 43);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(43, 27);
            this.simpleButton3.StyleController = this.ProperFormlayoutControl1ConvertedLayout;
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Delete";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(328, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(43, 27);
            this.simpleButton2.StyleController = this.ProperFormlayoutControl1ConvertedLayout;
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Edit";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(328, 74);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(43, 27);
            this.simpleButton1.StyleController = this.ProperFormlayoutControl1ConvertedLayout;
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Add";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.FromSubiektitem,
            this.FromEnovaitem,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1211, 566);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // FromSubiektitem
            // 
            this.FromSubiektitem.Control = this.FromSubiekt;
            this.FromSubiektitem.Location = new System.Drawing.Point(0, 0);
            this.FromSubiektitem.Name = "FromSubiektitem";
            this.FromSubiektitem.Size = new System.Drawing.Size(316, 546);
            this.FromSubiektitem.TextSize = new System.Drawing.Size(0, 0);
            this.FromSubiektitem.TextVisible = false;
            // 
            // FromEnovaitem
            // 
            this.FromEnovaitem.Control = this.FromEnova;
            this.FromEnovaitem.Location = new System.Drawing.Point(363, 0);
            this.FromEnovaitem.Name = "FromEnovaitem";
            this.FromEnovaitem.Size = new System.Drawing.Size(828, 546);
            this.FromEnovaitem.TextSize = new System.Drawing.Size(0, 0);
            this.FromEnovaitem.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(316, 62);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(47, 484);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton2;
            this.layoutControlItem2.Location = new System.Drawing.Point(316, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(47, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton3;
            this.layoutControlItem3.Location = new System.Drawing.Point(316, 31);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(47, 31);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // ProperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 566);
            this.Controls.Add(this.ProperFormlayoutControl1ConvertedLayout);
            this.Name = "ProperForm";
            this.Text = "ProperForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromSubiekt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromEnova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProperFormlayoutControl1ConvertedLayout)).EndInit();
            this.ProperFormlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromSubiektitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromEnovaitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl FromEnova;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl FromSubiekt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl ProperFormlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem FromSubiektitem;
        private DevExpress.XtraLayout.LayoutControlItem FromEnovaitem;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colHost;
        private DevExpress.XtraGrid.Columns.GridColumn colHostType;
        private DevExpress.XtraGrid.Columns.GridColumn colTyp;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresKodPocztowy;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresZagranicznyKodPocztowy;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresPoczta;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresMiejscowosc;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresGmina;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresPowiat;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresWojewodztwo;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresKraj;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresKodKraju;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresUlica;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresNrDomu;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresNrLokalu;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresNietypowaLokalizacja;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresFaks;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentyfikacjaAdresuGLN;
        private DevExpress.XtraGrid.Columns.GridColumn colStamp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}