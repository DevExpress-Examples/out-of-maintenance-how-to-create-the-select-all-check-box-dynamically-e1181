Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web

Namespace WebApplication3

	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Private check As New SelectAllCheckbox()
		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			ASPxGridView1.DataSource = AccessDataSource1
			ASPxGridView1.DataBind()

		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If ASPxGridView1.Columns("Command") Is Nothing Then
				AddColumn(ASPxGridView1, 0)
			Else
				ASPxGridView1.Columns("Command").HeaderCaptionTemplate = check
			End If
		End Sub

		Private Sub AddColumn(ByVal grid As ASPxGridView, ByVal index As Integer)
			Dim col As New GridViewCommandColumn()
			col.Name = "Command"
			col.ShowSelectCheckbox = True
			col.HeaderCaptionTemplate = check
			col.VisibleIndex = index

			grid.Columns.Insert(index,col)

		End Sub

		Protected Sub ASPxGridView1_CustomCallback(ByVal sender As Object, ByVal e As ASPxGridViewCustomCallbackEventArgs)
			Dim isSelected As Boolean = Convert.ToBoolean(e.Parameters)
			If isSelected Then
				CType(sender, ASPxGridView).Selection.SelectAll()
			Else
				CType(sender, ASPxGridView).Selection.UnselectAll()
			End If
			check.IsSelected = isSelected
		End Sub



	End Class

	Friend Class SelectAllCheckbox
		Implements ITemplate
		Private _isSelected As Boolean
		Public Property IsSelected() As Boolean
			Get
				Return _isSelected
			End Get
			Set(ByVal value As Boolean)
				_isSelected = value
			End Set
		End Property
		Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
			Dim box As New ASPxCheckBox()
			box.ID = "ASPxCheckBox1"
			box.Checked = _isSelected
			box.ClientSideEvents.CheckedChanged = "function(s,e){grid.PerformCallback(s.GetChecked());}"
			container.Controls.Add(box)
		End Sub
	End Class




End Namespace



