Imports System.Data.OleDb
Public Class frmLogin
    Public dbProvider As String
    Public dbSource As String
    Public myDocumentsFolder As String
    Public theDatabase As String
    Public fullDatabasePath As String
    Public sql As String

    Public con As New OleDbConnection
    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader

    ' Load database

    Private Sub LoadDB()
        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"  '15.0
        fullDatabasePath = "H:\Study\Practical\Vb\Database\login2.accdb"

        dbSource = "Data Source = " & fullDatabasePath

        con.ConnectionString = dbProvider & dbSource
        con.Open()
    End Sub

    Public Sub verify()

        cmd = New OleDbCommand("select * from LoginTable where username= '" & txtUser.Text & "' and password = '" & txtPass.Text & "' ", con)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then

        Else
            MsgBox("Invalid Password or Username", MsgBoxStyle.Critical)
            End
            'txtName.Text = dr.Item(1)   ' table column - roll , name   - 0 , 1 = name
        End If


        con.Close()

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        LoadDB()
        verify()

        frmDashboard.Show()
        Me.Hide()
    End Sub

End Class