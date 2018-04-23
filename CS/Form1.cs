using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.XtraTab;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.XtraTabbedMdi;
using DevExpress.XtraEditors;

namespace TabbedMDI
{
	public class Form1 : System.Windows.Forms.Form
	{

	#region  Windows Form Designer generated code 
        TabbedMdiManagerHelper helper;

		public Form1() : base()
		{

			//This call is required by the Windows Form Designer.
			InitializeComponent();
			InitWindows();
			int i = 0;
			for (i = 0; i <= 2; i++)
			{
				AddNewForm();
			}
			InitComboBoxes();

            helper = new TabbedMdiManagerHelper(xtraTabbedMdiManager1);
            helper.TabHeaderDoubleClick += OnTabHeaderDoubleClick;
		}

    

		//Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		internal DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
		internal DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
		internal DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
		internal DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
		internal DevExpress.XtraBars.BarEditItem barEditItem3;
		internal DevExpress.XtraBars.BarManager barManager1;
		internal DevExpress.XtraBars.Bar bar1;
		internal DevExpress.XtraBars.BarButtonItem barButtonItem1;
		internal DevExpress.XtraBars.Bar bar2;
		internal DevExpress.XtraBars.BarEditItem barEditItem1;
		internal DevExpress.XtraBars.BarEditItem barEditItem2;
		internal DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
		internal DevExpress.XtraBars.BarEditItem barEditItem4;
		internal DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
		internal System.Windows.Forms.ImageList imageList1;
		internal DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.PopupMenu PopupMenu1;
		internal DevExpress.XtraBars.BarButtonItem BarButtonItem2;
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BarButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.PopupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AutoHeight = false;
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "Windows";
            this.barMdiChildrenListItem1.Id = 1;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "Page Image Position";
            this.barEditItem3.Edit = this.repositoryItemImageComboBox3;
            this.barEditItem3.Id = 7;
            this.barEditItem3.Name = "barEditItem3";
            this.barEditItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.barEditItem3.EditValueChanged += new System.EventHandler(this.barEditItem3_EditValueChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.Controller = this.barAndDockingController1;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barMdiChildrenListItem1,
            this.barEditItem1,
            this.barEditItem2,
            this.barEditItem3,
            this.barEditItem4,
            this.BarButtonItem2});
            this.barManager1.MaxItemId = 10;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3,
            this.repositoryItemImageComboBox4});
            // 
            // bar1
            // 
            this.bar1.BarName = "barWindows";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(42, 179);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barMdiChildrenListItem1)});
            this.bar1.Text = "Windows";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add New Form";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "barOptions";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(40, 210);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.barEditItem1, "", false, true, true, 85),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.barEditItem2, "", false, true, true, 87),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.barEditItem3, "", false, true, true, 85),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.barEditItem4, "", false, true, true, 81)});
            this.bar2.Text = "Options";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Header Location";
            this.barEditItem1.Edit = this.repositoryItemImageComboBox1;
            this.barEditItem1.Id = 5;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.barEditItem1.EditValueChanged += new System.EventHandler(this.barEditItem1_EditValueChanged);
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "Header Orientation";
            this.barEditItem2.Edit = this.repositoryItemImageComboBox2;
            this.barEditItem2.Id = 6;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.barEditItem2.EditValueChanged += new System.EventHandler(this.barEditItem2_EditValueChanged);
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "Header AutoFill";
            this.barEditItem4.Edit = this.repositoryItemImageComboBox4;
            this.barEditItem4.Id = 8;
            this.barEditItem4.Name = "barEditItem4";
            this.barEditItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.barEditItem4.EditValueChanged += new System.EventHandler(this.barEditItem4_EditValueChanged);
            // 
            // repositoryItemImageComboBox4
            // 
            this.repositoryItemImageComboBox4.AutoHeight = false;
            this.repositoryItemImageComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(776, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 310);
            this.barDockControlBottom.Size = new System.Drawing.Size(776, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 260);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(776, 50);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 260);
            // 
            // BarButtonItem2
            // 
            this.BarButtonItem2.Caption = "BarButtonItem2";
            this.BarButtonItem2.Id = 9;
            this.BarButtonItem2.Name = "BarButtonItem2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.Controller = this.barAndDockingController1;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.PageAdded += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabbedMdiManager1_PageAdded);
            
            this.xtraTabbedMdiManager1.PageRemoved += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabbedMdiManager1_PageRemoved);
            // 
            // PopupMenu1
            // 
            this.PopupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarButtonItem2)});
            this.PopupMenu1.Manager = this.barManager1;
            this.PopupMenu1.Name = "PopupMenu1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(776, 310);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "TabbedMDI (CS code)";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu1)).EndInit();
            this.ResumeLayout(false);

		}

	#endregion
        //NEW EVENT
        void OnTabHeaderDoubleClick(object sender, TabHeaderDoubleClickEventArgs e)
        {
            XtraMessageBox.Show(e.TabPage.Text);

        }

		public void InitComboBoxes()
		{
			Array arr = System.Enum.GetValues(typeof(TabHeaderLocation));
			foreach (TabHeaderLocation location in arr)
			{
				repositoryItemImageComboBox1.Items.Add(new ImageComboBoxItem(location.ToString(), location, -1));
			}
			arr = System.Enum.GetValues(typeof(TabOrientation));

			foreach (TabOrientation orientation in arr)
			{
				repositoryItemImageComboBox2.Items.Add(new ImageComboBoxItem(orientation.ToString(), orientation, -1));
			}
			arr = System.Enum.GetValues(typeof(TabPageImagePosition));

			foreach (TabPageImagePosition position in arr)
			{
				repositoryItemImageComboBox3.Items.Add(new ImageComboBoxItem(position.ToString(), position, -1));
			}
			arr = System.Enum.GetValues(typeof(DefaultBoolean));

			foreach (DefaultBoolean fill in arr)
			{
				repositoryItemImageComboBox4.Items.Add(new ImageComboBoxItem(fill.ToString(), fill, -1));
			}
			barEditItem1.EditValue = xtraTabbedMdiManager1.HeaderLocation;
			barEditItem2.EditValue = xtraTabbedMdiManager1.HeaderOrientation;
			barEditItem3.EditValue = xtraTabbedMdiManager1.PageImagePosition;
			barEditItem4.EditValue = xtraTabbedMdiManager1.HeaderAutoFill;
            
		}

		private Random rnd = new Random();
		private int formCount = 0;
		public void AddNewForm()
		{
			Form frm = new Form();
			formCount += 1;
			frm.Text = string.Format("Form {0}", formCount);
			frm.MdiParent = this;
			frm.Show();
		}

		private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			AddNewForm();
		}

		public void InitWindows()
		{
			barMdiChildrenListItem1.Enabled = xtraTabbedMdiManager1.Pages.Count > 0;
		}

		private void xtraTabbedMdiManager1_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
		{
			InitWindows();
			e.Page.Image = imageList1.Images[rnd.Next(imageList1.Images.Count - 1)];
		}

		private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
		{
			InitWindows();
		}

		private void barEditItem1_EditValueChanged(object sender, System.EventArgs e)
		{
			xtraTabbedMdiManager1.HeaderLocation = (TabHeaderLocation)barEditItem1.EditValue;
		}

		private void barEditItem2_EditValueChanged(object sender, System.EventArgs e)
		{
			xtraTabbedMdiManager1.HeaderOrientation = (TabOrientation)barEditItem2.EditValue;
		}

		private void barEditItem3_EditValueChanged(object sender, System.EventArgs e)
		{
			xtraTabbedMdiManager1.PageImagePosition = (TabPageImagePosition)barEditItem3.EditValue;
		}

		private void barEditItem4_EditValueChanged(object sender, System.EventArgs e)
		{
			xtraTabbedMdiManager1.HeaderAutoFill = (DefaultBoolean)barEditItem4.EditValue;
		}

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            helper.TabHeaderDoubleClick -= OnTabHeaderDoubleClick;
        }


		[STAThread]
		static void Main()
		{
			Application.Run(new Form1());
		}

     
     
	}

 

} //end of root namespace