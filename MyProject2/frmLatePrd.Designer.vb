<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLatePrd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvLatePrd = New System.Windows.Forms.DataGridView()
        Me.ProductDataSet = New MyProject2.ProductDataSet()
        Me.ProductMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductMasterTableAdapter = New MyProject2.ProductDataSetTableAdapters.ProductMasterTableAdapter()
        CType(Me.dgvLatePrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLatePrd
        '
        Me.dgvLatePrd.AllowUserToAddRows = False
        Me.dgvLatePrd.AllowUserToDeleteRows = False
        Me.dgvLatePrd.AllowUserToOrderColumns = True
        Me.dgvLatePrd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLatePrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLatePrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvLatePrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLatePrd.Location = New System.Drawing.Point(12, 12)
        Me.dgvLatePrd.Name = "dgvLatePrd"
        Me.dgvLatePrd.ReadOnly = True
        Me.dgvLatePrd.Size = New System.Drawing.Size(776, 206)
        Me.dgvLatePrd.TabIndex = 0
        '
        'ProductDataSet
        '
        Me.ProductDataSet.DataSetName = "ProductDataSet"
        Me.ProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductMasterBindingSource
        '
        Me.ProductMasterBindingSource.DataMember = "ProductMaster"
        Me.ProductMasterBindingSource.DataSource = Me.ProductDataSet
        '
        'ProductMasterTableAdapter
        '
        Me.ProductMasterTableAdapter.ClearBeforeFill = True
        '
        'frmLatePrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvLatePrd)
        Me.Name = "frmLatePrd"
        Me.Text = "frmLatePrd"
        CType(Me.dgvLatePrd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvLatePrd As DataGridView
    Friend WithEvents ProductDataSet As ProductDataSet
    Friend WithEvents ProductMasterBindingSource As BindingSource
    Friend WithEvents ProductMasterTableAdapter As ProductDataSetTableAdapters.ProductMasterTableAdapter
End Class
