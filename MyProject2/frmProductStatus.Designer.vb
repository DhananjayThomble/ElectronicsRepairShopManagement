<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductStatus
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateIssueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReturnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductDataSet = New MyProject2.ProductDataSet()
        Me.ProductMasterTableAdapter = New MyProject2.ProductDataSetTableAdapters.ProductMasterTableAdapter()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SnDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.DateIssueDataGridViewTextBoxColumn, Me.DateReturnDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn, Me.UidDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductMasterBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(890, 206)
        Me.DataGridView1.TabIndex = 0
        '
        'SnDataGridViewTextBoxColumn
        '
        Me.SnDataGridViewTextBoxColumn.DataPropertyName = "sn"
        Me.SnDataGridViewTextBoxColumn.HeaderText = "sn"
        Me.SnDataGridViewTextBoxColumn.Name = "SnDataGridViewTextBoxColumn"
        Me.SnDataGridViewTextBoxColumn.Width = 43
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.Width = 73
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.Width = 48
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Width = 83
        '
        'DateIssueDataGridViewTextBoxColumn
        '
        Me.DateIssueDataGridViewTextBoxColumn.DataPropertyName = "dateIssue"
        Me.DateIssueDataGridViewTextBoxColumn.HeaderText = "dateIssue"
        Me.DateIssueDataGridViewTextBoxColumn.Name = "DateIssueDataGridViewTextBoxColumn"
        Me.DateIssueDataGridViewTextBoxColumn.Width = 78
        '
        'DateReturnDataGridViewTextBoxColumn
        '
        Me.DateReturnDataGridViewTextBoxColumn.DataPropertyName = "dateReturn"
        Me.DateReturnDataGridViewTextBoxColumn.HeaderText = "dateReturn"
        Me.DateReturnDataGridViewTextBoxColumn.Name = "DateReturnDataGridViewTextBoxColumn"
        Me.DateReturnDataGridViewTextBoxColumn.Width = 85
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        Me.CostDataGridViewTextBoxColumn.Width = 52
        '
        'UidDataGridViewTextBoxColumn
        '
        Me.UidDataGridViewTextBoxColumn.DataPropertyName = "uid"
        Me.UidDataGridViewTextBoxColumn.HeaderText = "uid"
        Me.UidDataGridViewTextBoxColumn.Name = "UidDataGridViewTextBoxColumn"
        Me.UidDataGridViewTextBoxColumn.Width = 46
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Width = 60
        '
        'ProductMasterBindingSource
        '
        Me.ProductMasterBindingSource.DataMember = "ProductMaster"
        Me.ProductMasterBindingSource.DataSource = Me.ProductDataSetBindingSource
        '
        'ProductDataSetBindingSource
        '
        Me.ProductDataSetBindingSource.DataSource = Me.ProductDataSet
        Me.ProductDataSetBindingSource.Position = 0
        '
        'ProductDataSet
        '
        Me.ProductDataSet.DataSetName = "ProductDataSet"
        Me.ProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductMasterTableAdapter
        '
        Me.ProductMasterTableAdapter.ClearBeforeFill = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(804, 121)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 110)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmProductStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(929, 450)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmProductStatus"
        Me.Text = "ProductStatus Set"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProductDataSetBindingSource As BindingSource
    Friend WithEvents ProductDataSet As ProductDataSet
    Friend WithEvents ProductMasterBindingSource As BindingSource
    Friend WithEvents ProductMasterTableAdapter As ProductDataSetTableAdapters.ProductMasterTableAdapter
    Friend WithEvents SnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateIssueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateReturnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As Button
End Class
