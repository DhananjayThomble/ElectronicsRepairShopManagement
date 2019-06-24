Imports System.Data.OleDb

'' Table name :- ProductMaster
''Database name :- Product


Public Class FrmNewProduct
    '' Var for DB
    Public dbProvider As String
    Public dbSource As String
    Public myDocumentsFolder As String
    Public theDatabase As String
    Public fullDatabasePath As String

    Public sql As String
    Public da As OleDb.OleDbDataAdapter
    Public ds As New DataSet
    Public con As New OleDb.OleDbConnection
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDbDataReader


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dateToday.Value = Today
        DisableControl()
    End Sub

    Private Sub DisableControl()
        If txtSn.Text = "" Then
            'Disable all
            For Each ctl As Control In Controls
                ctl.Enabled = False
            Next

        End If
        txtSn.Enabled = True
    End Sub
    Private Sub EnableControl()
        For Each ctl As Control In Controls
            ctl.Enabled = True
        Next
    End Sub

    Private Sub btnAddData_Click(sender As Object, e As EventArgs) Handles btnAddData.Click

        'MsgBox(dateToday.Value.ToString("dd-MM-yyyy"))
        Dim uid As Integer
        LoadCustomerDB()
        uid = InsertCustomer(txtName.Text, txtMobileno.Text, txtEmail.Text, RichtxtAddress.Text)

        CloseCustomerDB()


        LoadProductDB()
        InsertProduct(txtSn.Text, cmbCategory.Text, txtTitle.Text, txtDesc.Text, dateToday.Value.ToString("dd-MM-yyyy"), DateReturn.Value.ToString("dd-MM-yyyy"),
                mTxtCost.Text, uid)

        CloseProductDB()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form3ShowPro.Show()
    End Sub

    Private Sub txtSnChanged(sender As Object, e As EventArgs)

        ' Verify SN in DB
        verifySn(txtSn.Text)

        MsgBox("Changed")
    End Sub

    Private Sub cateChanged(sender As Object, e As EventArgs) Handles cmbCategory.Leave

        If cmbCategory.Text = "Mobile" Then
            lblUniueID.Text = "IMEI"
        End If

    End Sub

    '-----------------------------------------------------------DataBase Part--------------------------------------------------

    Public Sub verifySn(sn As String)

        Dim uid As Integer
        LoadProductDB()
        cmd = New OleDbCommand("select * from ProductMaster where sn = '" & sn & "'  ", con)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            'txtName.Text = dr.Item(1)   ' table column - roll , name   - 0 , 1 = name
            txtSn.Text = dr.Item(0)
            cmbCategory.Text = dr.Item(1)
            txtTitle.Text = dr.Item(2)
            txtDesc.Text = dr.Item(3)
            dateToday.Value = dr.Item(4)
            DateReturn.Value = dr.Item(5)
            mTxtCost.Text = dr.Item(6)
            uid = dr.Item(7)

            CloseProductDB()

            LoadCustomerDB()
            cmd = New OleDbCommand("select * from Customer where uid = " & uid & "  ", con)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()

                txtName.Text = dr.Item(1)
                txtMobileno.Text = dr.Item(2)
                txtEmail.Text = dr.Item(3)
                RichtxtAddress.Text = dr.Item(4)

                CloseCustomerDB()
                MsgBox("loading success")
                btnAddData.Enabled = False

            End If

            'txtName.Text = dr.Item(1)   ' table column - roll , name   - 0 , 1 = name
        End If



        CloseProductDB()

    End Sub

    ''
    '' Load DB
    Public Sub LoadProductDB()
        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"  '15.0
        fullDatabasePath = "H:\Study\Practical\Vb\Database\Product.accdb"

        dbSource = "Data Source = " & fullDatabasePath

        con.ConnectionString = dbProvider & dbSource
        con.Open()

    End Sub



    '' Insert product
    Public Sub InsertProduct(sn As String, category As String, title As String, description As String,
                             dateIssue As String, dateReturn As String, cost As Integer, uid As Integer)
        Try
            cmd = New OleDbCommand("insert into ProductMaster values ( '" & sn & "','" & category & "', '" & title & "','" & description & "','" & dateIssue & "' , '" & dateReturn & "' ," & cost & "," & uid & ", 0 ) ", con)

            MsgBox("Values inserted")
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    'Close Product Db
    Public Sub CloseProductDB()
        con.Close()
    End Sub

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

    'Insert cus DB
    Public Function InsertCustomer(nm As String, mob As String, email As String, add As String) As Integer
        Dim uid As Integer
        Try
            cmd = New OleDbCommand("insert into Customer(name,mobileNo,email,address) values('" & nm & "'," & mob & ",'" & email & "','" & add & "' ) ", con)
            cmd.ExecuteNonQuery()
            MsgBox("inserted.")

            cmd = New OleDbCommand("select max(uid) from Customer", con)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                uid = dr.Item(0)   ' table column - roll , name   - 0 , 1 = name
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return uid
    End Function


    Private Sub txtSn_Click(sender As Object, e As EventArgs) Handles txtSn.Click
        EnableControl()
    End Sub

    Private Sub txtSn_Leave(sender As Object, e As EventArgs) Handles txtSn.Leave
        If txtSn.Text = "" Then
            DisableControl()
        End If
    End Sub

    Private Sub txtSn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSn.KeyPress
        EnableControl()
    End Sub
End Class
