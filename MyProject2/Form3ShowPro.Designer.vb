<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3ShowPro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvShow = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CmbSelectItem = New System.Windows.Forms.ComboBox()
        CType(Me.dgvShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvShow
        '
        Me.dgvShow.AllowUserToAddRows = False
        Me.dgvShow.AllowUserToDeleteRows = False
        Me.dgvShow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShow.Location = New System.Drawing.Point(12, 39)
        Me.dgvShow.Name = "dgvShow"
        Me.dgvShow.ReadOnly = True
        Me.dgvShow.Size = New System.Drawing.Size(776, 150)
        Me.dgvShow.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 90)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CmbSelectItem
        '
        Me.CmbSelectItem.FormattingEnabled = True
        Me.CmbSelectItem.Items.AddRange(New Object() {"Tv", "Mobile", "Refridgerator", "Fan", "Computer", "Mobile"})
        Me.CmbSelectItem.Location = New System.Drawing.Point(12, 12)
        Me.CmbSelectItem.Name = "CmbSelectItem"
        Me.CmbSelectItem.Size = New System.Drawing.Size(121, 21)
        Me.CmbSelectItem.TabIndex = 3
        '
        'Form3ShowPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmbSelectItem)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvShow)
        Me.Name = "Form3ShowPro"
        Me.Text = "Product List Category wise"
        CType(Me.dgvShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvShow As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents CmbSelectItem As ComboBox
End Class
