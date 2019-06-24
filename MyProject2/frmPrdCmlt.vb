Imports System.Data.OleDb
Public Class frmPrdCmlt

    Public adp As OleDbDataAdapter
    Public con As New OleDbConnection
    Public ds As New DataSet

    Private Sub frmPrdCmlt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = H:\Study\Practical\Vb\Database\Product.accdb;")
        con.Open()
        adp = New OleDbDataAdapter("select * from ProductMaster where status = 1 ", con)
        adp.Fill(ds, "AccessDB")
        con.Close()

        With Me.dgvPrdCmlt

            .DataSource = ds
            .DataMember = "AccessDB"
        End With



    End Sub
End Class