Imports System.Data.OleDb
Public Class frmProductStatus


    Private Sub frmProductStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductDataSet.ProductMaster' table. You can move, or remove it, as needed.
        Me.ProductMasterTableAdapter.Fill(Me.ProductDataSet.ProductMaster)

    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            ProductMasterTableAdapter.Update(ProductDataSet)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------


End Class