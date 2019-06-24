Imports System.Data.OleDb
Public Class Form3ShowPro

    Public dbProvider As String
    Public dbSource As String
    Public theDatabase As String
    Public fullDatabasePath As String

    Public sql As String
    Public da As OleDbDataAdapter
    Public ds As New DataSet
    Public con As New OleDbConnection
    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader

    Private Sub Form3ShowPro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"  '15.0
        fullDatabasePath = "H:\Study\Practical\Vb\Database\Product.accdb;"

        dbSource = "Data Source = " & fullDatabasePath

        con.ConnectionString = dbProvider & dbSource
        con.Open()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ds.Clear()
        da = New OleDbDataAdapter("select * from ProductMaster where category = '" & CmbSelectItem.SelectedItem & "'", con)
        da.Fill(ds)
        dgvShow.DataSource = ds.Tables(0)

    End Sub


End Class