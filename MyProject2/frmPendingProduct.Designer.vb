<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPendingProduct
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
        Me.dgvAllProduct = New System.Windows.Forms.DataGridView()
        Me.SnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateIssueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReturnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PendingProList = New MyProject2.PendingProList()
        Me.ProductMasterTableAdapter = New MyProject2.PendingProListTableAdapters.ProductMasterTableAdapter()
        CType(Me.dgvAllProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PendingProList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAllProduct
        '
        Me.dgvAllProduct.AllowUserToAddRows = False
        Me.dgvAllProduct.AllowUserToDeleteRows = False
        Me.dgvAllProduct.AutoGenerateColumns = False
        Me.dgvAllProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvAllProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvAllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAllProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SnDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.DateIssueDataGridViewTextBoxColumn, Me.DateReturnDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn, Me.UidDataGridViewTextBoxColumn})
        Me.dgvAllProduct.DataSource = Me.ProductMasterBindingSource
        Me.dgvAllProduct.Location = New System.Drawing.Point(12, 39)
        Me.dgvAllProduct.Name = "dgvAllProduct"
        Me.dgvAllProduct.ReadOnly = True
        Me.dgvAllProduct.Size = New System.Drawing.Size(784, 278)
        Me.dgvAllProduct.TabIndex = 0
        '
        'SnDataGridViewTextBoxColumn
        '
        Me.SnDataGridViewTextBoxColumn.DataPropertyName = "sn"
        Me.SnDataGridViewTextBoxColumn.HeaderText = "sn"
        Me.SnDataGridViewTextBoxColumn.Name = "SnDataGridViewTextBoxColumn"
        Me.SnDataGridViewTextBoxColumn.ReadOnly = True
        Me.SnDataGridViewTextBoxColumn.Width = 43
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryDataGridViewTextBoxColumn.Width = 73
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 48
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 83
        '
        'DateIssueDataGridViewTextBoxColumn
        '
        Me.DateIssueDataGridViewTextBoxColumn.DataPropertyName = "dateIssue"
        Me.DateIssueDataGridViewTextBoxColumn.HeaderText = "dateIssue"
        Me.DateIssueDataGridViewTextBoxColumn.Name = "DateIssueDataGridViewTextBoxColumn"
        Me.DateIssueDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateIssueDataGridViewTextBoxColumn.Width = 78
        '
        'DateReturnDataGridViewTextBoxColumn
        '
        Me.DateReturnDataGridViewTextBoxColumn.DataPropertyName = "dateReturn"
        Me.DateReturnDataGridViewTextBoxColumn.HeaderText = "dateReturn"
        Me.DateReturnDataGridViewTextBoxColumn.Name = "DateReturnDataGridViewTextBoxColumn"
        Me.DateReturnDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateReturnDataGridViewTextBoxColumn.Width = 85
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        Me.CostDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostDataGridViewTextBoxColumn.Width = 52
        '
        'UidDataGridViewTextBoxColumn
        '
        Me.UidDataGridViewTextBoxColumn.DataPropertyName = "uid"
        Me.UidDataGridViewTextBoxColumn.HeaderText = "uid"
        Me.UidDataGridViewTextBoxColumn.Name = "UidDataGridViewTextBoxColumn"
        Me.UidDataGridViewTextBoxColumn.ReadOnly = True
        Me.UidDataGridViewTextBoxColumn.Width = 46
        '
        'ProductMasterBindingSource
        '
        Me.ProductMasterBindingSource.DataMember = "ProductMaster"
        Me.ProductMasterBindingSource.DataSource = Me.PendingProList
        '
        'PendingProList
        '
        Me.PendingProList.DataSetName = "PendingProList"
        Me.PendingProList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductMasterTableAdapter
        '
        Me.ProductMasterTableAdapter.ClearBeforeFill = True
        '
        'frmPendingProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(808, 450)
        Me.Controls.Add(Me.dgvAllProduct)
        Me.Name = "frmPendingProduct"
        Me.Text = "Pending Product"
        CType(Me.dgvAllProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PendingProList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAllProduct As DataGridView
    Friend WithEvents PendingProList As PendingProList
    Friend WithEvents ProductMasterBindingSource As BindingSource
    Friend WithEvents ProductMasterTableAdapter As PendingProListTableAdapters.ProductMasterTableAdapter
    Friend WithEvents SnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateIssueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateReturnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
