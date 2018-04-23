Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Data
Imports System.Drawing
Imports System.Diagnostics
Imports System.Windows.Forms

Imports DevExpress.XtraTab
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.XtraTabbedMdi
Imports DevExpress.XtraEditors

Namespace TabbedMDI
	Public Class Form1
		Inherits System.Windows.Forms.Form

	#Region " Windows Form Designer generated code "
		Private helper As TabbedMdiManagerHelper

		Public Sub New()
			MyBase.New()

			'This call is required by the Windows Form Designer.
			InitializeComponent()
			InitWindows()
			Dim i As Integer = 0
			For i = 0 To 2
				AddNewForm()
			Next i
			InitComboBoxes()

			helper = New TabbedMdiManagerHelper(xtraTabbedMdiManager1)
			AddHandler helper.TabHeaderDoubleClick, AddressOf OnTabHeaderDoubleClick
		End Sub



		'Form overrides dispose to clean up the component list.
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		'Required by the Windows Form Designer
		Private components As System.ComponentModel.IContainer

		'NOTE: The following procedure is required by the Windows Form Designer
		'It can be modified using the Windows Form Designer.  
		'Do not modify it using the code editor.
		Friend repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Friend barMdiChildrenListItem1 As DevExpress.XtraBars.BarMdiChildrenListItem
		Friend barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
		Friend repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Friend WithEvents barEditItem3 As DevExpress.XtraBars.BarEditItem
		Friend barManager1 As DevExpress.XtraBars.BarManager
		Friend bar1 As DevExpress.XtraBars.Bar
		Friend WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Friend bar2 As DevExpress.XtraBars.Bar
		Friend WithEvents barEditItem1 As DevExpress.XtraBars.BarEditItem
		Friend WithEvents barEditItem2 As DevExpress.XtraBars.BarEditItem
		Friend repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Friend WithEvents barEditItem4 As DevExpress.XtraBars.BarEditItem
		Friend repositoryItemImageComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Friend imageList1 As System.Windows.Forms.ImageList
		Friend WithEvents xtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
		Friend barDockControlTop As DevExpress.XtraBars.BarDockControl
		Friend barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Friend barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Friend barDockControlRight As DevExpress.XtraBars.BarDockControl
		Friend PopupMenu1 As DevExpress.XtraBars.PopupMenu
		Friend BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
		<System.Diagnostics.DebuggerStepThrough()> _
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.barMdiChildrenListItem1 = New DevExpress.XtraBars.BarMdiChildrenListItem()
			Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.barEditItem3 = New DevExpress.XtraBars.BarEditItem()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.barEditItem4 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemImageComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.xtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
			Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' repositoryItemImageComboBox3
			' 
			Me.repositoryItemImageComboBox3.AutoHeight = False
			Me.repositoryItemImageComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
			' 
			' barMdiChildrenListItem1
			' 
			Me.barMdiChildrenListItem1.Caption = "Windows"
			Me.barMdiChildrenListItem1.Id = 1
			Me.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1"
			' 
			' barAndDockingController1
			' 
			Me.barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.barAndDockingController1.PropertiesBar.AllowLinkLighting = False
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			' 
			' barEditItem3
			' 
			Me.barEditItem3.Caption = "Page Image Position"
			Me.barEditItem3.Edit = Me.repositoryItemImageComboBox3
			Me.barEditItem3.Id = 7
			Me.barEditItem3.Name = "barEditItem3"
			Me.barEditItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
'			Me.barEditItem3.EditValueChanged += New System.EventHandler(Me.barEditItem3_EditValueChanged);
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2})
			Me.barManager1.Controller = Me.barAndDockingController1
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barMdiChildrenListItem1, Me.barEditItem1, Me.barEditItem2, Me.barEditItem3, Me.barEditItem4, Me.BarButtonItem2})
			Me.barManager1.MaxItemId = 10
			Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3, Me.repositoryItemImageComboBox4})
			' 
			' bar1
			' 
			Me.bar1.BarName = "barWindows"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.FloatLocation = New System.Drawing.Point(42, 179)
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barMdiChildrenListItem1)})
			Me.bar1.Text = "Windows"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "Add New Form"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
'			Me.barButtonItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonItem1_ItemClick);
			' 
			' bar2
			' 
			Me.bar2.BarName = "barOptions"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 1
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.FloatLocation = New System.Drawing.Point(40, 210)
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barEditItem1, "", False, True, True, 85), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barEditItem2, "", False, True, True, 87), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barEditItem3, "", False, True, True, 85), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barEditItem4, "", False, True, True, 81)})
			Me.bar2.Text = "Options"
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Caption = "Header Location"
			Me.barEditItem1.Edit = Me.repositoryItemImageComboBox1
			Me.barEditItem1.Id = 5
			Me.barEditItem1.Name = "barEditItem1"
			Me.barEditItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
'			Me.barEditItem1.EditValueChanged += New System.EventHandler(Me.barEditItem1_EditValueChanged);
			' 
			' barEditItem2
			' 
			Me.barEditItem2.Caption = "Header Orientation"
			Me.barEditItem2.Edit = Me.repositoryItemImageComboBox2
			Me.barEditItem2.Id = 6
			Me.barEditItem2.Name = "barEditItem2"
			Me.barEditItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
'			Me.barEditItem2.EditValueChanged += New System.EventHandler(Me.barEditItem2_EditValueChanged);
			' 
			' repositoryItemImageComboBox2
			' 
			Me.repositoryItemImageComboBox2.AutoHeight = False
			Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
			' 
			' barEditItem4
			' 
			Me.barEditItem4.Caption = "Header AutoFill"
			Me.barEditItem4.Edit = Me.repositoryItemImageComboBox4
			Me.barEditItem4.Id = 8
			Me.barEditItem4.Name = "barEditItem4"
			Me.barEditItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
'			Me.barEditItem4.EditValueChanged += New System.EventHandler(Me.barEditItem4_EditValueChanged);
			' 
			' repositoryItemImageComboBox4
			' 
			Me.repositoryItemImageComboBox4.AutoHeight = False
			Me.repositoryItemImageComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(776, 50)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 310)
			Me.barDockControlBottom.Size = New System.Drawing.Size(776, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 50)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 260)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(776, 50)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 260)
			' 
			' BarButtonItem2
			' 
			Me.BarButtonItem2.Caption = "BarButtonItem2"
			Me.BarButtonItem2.Id = 9
			Me.BarButtonItem2.Name = "BarButtonItem2"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			' 
			' xtraTabbedMdiManager1
			' 
			Me.xtraTabbedMdiManager1.Controller = Me.barAndDockingController1
			Me.xtraTabbedMdiManager1.MdiParent = Me
'			Me.xtraTabbedMdiManager1.PageAdded += New DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(Me.xtraTabbedMdiManager1_PageAdded);

'			Me.xtraTabbedMdiManager1.PageRemoved += New DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(Me.xtraTabbedMdiManager1_PageRemoved);
			' 
			' PopupMenu1
			' 
			Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
			Me.PopupMenu1.Manager = Me.barManager1
			Me.PopupMenu1.Name = "PopupMenu1"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(776, 310)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.IsMdiContainer = True
			Me.Name = "Form1"
			Me.Text = "TabbedMDI (CS code)"
			CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

	#End Region
		'NEW EVENT
		Private Sub OnTabHeaderDoubleClick(ByVal sender As Object, ByVal e As TabHeaderDoubleClickEventArgs)
			XtraMessageBox.Show(e.TabPage.Text)

		End Sub

		Public Sub InitComboBoxes()
			Dim arr As Array = System.Enum.GetValues(GetType(TabHeaderLocation))
			For Each location As TabHeaderLocation In arr
				repositoryItemImageComboBox1.Items.Add(New ImageComboBoxItem(location.ToString(), location, -1))
			Next location
			arr = System.Enum.GetValues(GetType(TabOrientation))

			For Each orientation As TabOrientation In arr
				repositoryItemImageComboBox2.Items.Add(New ImageComboBoxItem(orientation.ToString(), orientation, -1))
			Next orientation
			arr = System.Enum.GetValues(GetType(TabPageImagePosition))

			For Each position As TabPageImagePosition In arr
				repositoryItemImageComboBox3.Items.Add(New ImageComboBoxItem(position.ToString(), position, -1))
			Next position
			arr = System.Enum.GetValues(GetType(DefaultBoolean))

			For Each fill As DefaultBoolean In arr
				repositoryItemImageComboBox4.Items.Add(New ImageComboBoxItem(fill.ToString(), fill, -1))
			Next fill
			barEditItem1.EditValue = xtraTabbedMdiManager1.HeaderLocation
			barEditItem2.EditValue = xtraTabbedMdiManager1.HeaderOrientation
			barEditItem3.EditValue = xtraTabbedMdiManager1.PageImagePosition
			barEditItem4.EditValue = xtraTabbedMdiManager1.HeaderAutoFill

		End Sub

		Private rnd As New Random()
		Private formCount As Integer = 0
		Public Sub AddNewForm()
			Dim frm As New Form()
			formCount += 1
			frm.Text = String.Format("Form {0}", formCount)
			frm.MdiParent = Me
			frm.Show()
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			AddNewForm()
		End Sub

		Public Sub InitWindows()
			barMdiChildrenListItem1.Enabled = xtraTabbedMdiManager1.Pages.Count > 0
		End Sub

		Private Sub xtraTabbedMdiManager1_PageAdded(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles xtraTabbedMdiManager1.PageAdded
			InitWindows()
			e.Page.Image = imageList1.Images(rnd.Next(imageList1.Images.Count - 1))
		End Sub

		Private Sub xtraTabbedMdiManager1_PageRemoved(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles xtraTabbedMdiManager1.PageRemoved
			InitWindows()
		End Sub

		Private Sub barEditItem1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles barEditItem1.EditValueChanged
			xtraTabbedMdiManager1.HeaderLocation = CType(barEditItem1.EditValue, TabHeaderLocation)
		End Sub

		Private Sub barEditItem2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles barEditItem2.EditValueChanged
			xtraTabbedMdiManager1.HeaderOrientation = CType(barEditItem2.EditValue, TabOrientation)
		End Sub

		Private Sub barEditItem3_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles barEditItem3.EditValueChanged
			xtraTabbedMdiManager1.PageImagePosition = CType(barEditItem3.EditValue, TabPageImagePosition)
		End Sub

		Private Sub barEditItem4_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles barEditItem4.EditValueChanged
			xtraTabbedMdiManager1.HeaderAutoFill = CType(barEditItem4.EditValue, DefaultBoolean)
		End Sub

		Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
			MyBase.OnFormClosing(e)
			RemoveHandler helper.TabHeaderDoubleClick, AddressOf OnTabHeaderDoubleClick
		End Sub


		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub



	End Class



End Namespace 'end of root namespace