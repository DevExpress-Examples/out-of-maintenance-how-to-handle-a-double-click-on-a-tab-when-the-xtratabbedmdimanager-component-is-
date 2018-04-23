Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTab
Imports DevExpress.XtraTabbedMdi
Imports System.Drawing
Imports System.Collections

Namespace TabbedMDI
	Public Class TabbedMdiManagerHelper
		Private manager As XtraTabbedMdiManager
		Private clickTick As Integer = -1
		Private previousPage As IXtraTabPage

		Public Delegate Sub TabHeaderDoubleClickEventHandler(ByVal sender As Object, ByVal e As TabHeaderDoubleClickEventArgs)
		Public Event TabHeaderDoubleClick As TabHeaderDoubleClickEventHandler

		Public Sub New(ByVal manager As XtraTabbedMdiManager)
			Me.manager = manager
			AddHandler manager.MouseDown, AddressOf OnXtraTabbedMdiManagerMouseDown
		End Sub

		Private Sub OnXtraTabbedMdiManagerMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
			Dim hi As DevExpress.XtraTab.ViewInfo.BaseTabHitInfo = manager.CalcHitInfo(New Point(e.X, e.Y))
			If hi.HitTest = DevExpress.XtraTab.ViewInfo.XtraTabHitTest.PageHeader Then
				If clickTick = -1 Then
					clickTick = System.Environment.TickCount
					previousPage = hi.Page
				Else
					If System.Environment.TickCount - clickTick < SystemInformation.DoubleClickTime AndAlso hi.Page Is previousPage Then
						Dim args As New TabHeaderDoubleClickEventArgs(hi.Page)
						RaiseTabHeaderDoubleClick(args)
					End If
					clickTick = -1
				End If
			End If
		End Sub

		Private Sub RaiseTabHeaderDoubleClick(ByVal e As TabHeaderDoubleClickEventArgs)
			RaiseEvent TabHeaderDoubleClick(manager, e)
		End Sub
	End Class
End Namespace
