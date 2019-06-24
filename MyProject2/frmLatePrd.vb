Imports System.Data.OleDb
Public Class frmLatePrd

    Public cmd As New OleDbCommand
    Public con As New OleDbConnection
    Public adp As OleDbDataAdapter
    Public ds As New DataSet

    Private Sub frmLatePrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=H:\Study\Practical\Vb\Database\Product.accdb;")
        con.Open()
        Dim d As Date
        d = Today


        adp = New OleDbDataAdapter("select * from ProductMaster where dateReturn < #" & d.ToString("MM-dd-yyyy") & "# and status = 0 ", con)

        adp.Fill(ds, "AccessData")
        con.Close()

        With Me.dgvLatePrd
            .DataSource = ds
            'Here we control which table the DataGridView should display.
            .DataMember = "AccessData"
        End With

        ds = Nothing
        adp.Dispose()
        con = Nothing



    End Sub
End Class