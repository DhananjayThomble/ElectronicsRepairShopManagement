Imports System.Data.OleDb
Public Class frmAddCustomer
    Public dbProvider As String
    Public dbSource As String
    Public myDocumentsFolder As String
    Public theDatabase As String
    Public fullDatabasePath As String

    Public sql As String
    Public da As OleDbDataAdapter
    Public ds As New DataSet
    Public con As New OleDbConnection
    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader
    Public dt As DataTable
    Public uid As Integer



    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles richTxtAddress.TextChanged

    End Sub

    Private Sub ContactNo_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtMobno.MaskInputRejected

    End Sub

    Private Sub frmAddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductDataSet1.Customer' table. You can move, or remove it, as needed.

        LoadCustomerDB()
        cmd = New OleDbCommand("select uid from Customer", con)

        dr = cmd.ExecuteReader
        While dr.Read
            cmbUid.Items.Add(dr(0).ToString)
        End While
        dr.Close()

    End Sub

    '-------------------------------------------------------DAta---------------------------
    ' Load cus DB
    Public Sub LoadCustomerDB()

        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"  '15.0
        fullDatabasePath = "H:\Study\Practical\Vb\Database\Product.accdb"

        dbSource = "Data Source = " & fullDatabasePath

        con.ConnectionString = dbProvider & dbSource
        con.Open()

    End Sub
    'Close cus DB
    Public Sub CloseCustomerDB()
        con.Close()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            cmd = New OleDbCommand("insert into Customer(name,mobileNo,email,address) values( '" & txtName.Text & "' , " & txtMobno.Text & " , '" & txtEmail.Text & "' , '" & richTxtAddress.Text & "'  ) ", con)
            cmd.ExecuteNonQuery()
            MsgBox("inserted")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        cmd = New OleDbCommand("update Customer set name = '" & txtName.Text & "' where uid =  " & cmbUid.Text & " ", con)
        cmd.ExecuteNonQuery()

        cmd = New OleDbCommand("update Customer set address = '" & richTxtAddress.Text & "' where uid =  " & cmbUid.Text & " ", con)
        cmd.ExecuteNonQuery()

        cmd = New OleDbCommand("update Customer set mobileNo = " & txtMobno.Text & " where uid =  " & cmbUid.Text & " ", con)
        cmd.ExecuteNonQuery()

        cmd = New OleDbCommand("update Customer set email = '" & txtEmail.Text & "' where uid =  " & cmbUid.Text & " ", con)
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub btnGetdata_Click(sender As Object, e As EventArgs) Handles btnGetdata.Click

        'cmd = New OleDbCommand("select uid from Customer ")

        cmd = New OleDbCommand("select * from customer where uid = " & cmbUid.Text & " ", con)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            txtName.Text = dr.Item(1)   ' table column - roll , name   - 0 , 1 = name
            txtMobno.Text = dr.Item(2)
            txtEmail.Text = dr.Item(3)
            richTxtAddress.Text = dr.Item(4)
        End If

        dr.Close()
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        cmd = New OleDbCommand("delete from Customer where uid = " & cmbUid.Text & "  ", con)
        cmd.ExecuteNonQuery()
    End Sub
End Class