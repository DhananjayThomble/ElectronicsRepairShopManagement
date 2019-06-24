Imports System.Data.OleDb
Public Class frmUserRegist
    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Dim adp As New OleDbDataAdapter
    Private Sub frmUserRegist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= H:\Study\Practical\Vb\Database\login2.accdb;"
        cn.Open()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            cmd = New OleDbCommand("insert into LoginTable values('" & txtUsrnm.Text & "','" & txtPass.Text & "' ) ", cn)
            cmd.ExecuteNonQuery()
            MsgBox("inserted.")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class