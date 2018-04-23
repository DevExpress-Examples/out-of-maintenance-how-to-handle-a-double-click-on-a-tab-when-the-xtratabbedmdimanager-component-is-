Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTab

Namespace TabbedMDI
	Public Class TabHeaderDoubleClickEventArgs
		Inherits EventArgs
		Public Sub New(ByVal tabPage As IXtraTabPage)
			_TabPage = tabPage
		End Sub

		' Fields...
		Private _TabPage As IXtraTabPage

		Public ReadOnly Property TabPage() As IXtraTabPage
			Get
				Return _TabPage
			End Get
		End Property
	End Class
End Namespace