<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Name
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextDogID = New System.Windows.Forms.TextBox()
        Me.TextDogName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(70, 195)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 36)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(22, 45)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(49, 16)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Dog ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dog Name"
        '
        'TextDogID
        '
        Me.TextDogID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextDogID.Location = New System.Drawing.Point(20, 9)
        Me.TextDogID.Margin = New System.Windows.Forms.Padding(2)
        Me.TextDogID.Name = "TextDogID"
        Me.TextDogID.Size = New System.Drawing.Size(151, 13)
        Me.TextDogID.TabIndex = 3
        '
        'TextDogName
        '
        Me.TextDogName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextDogName.Location = New System.Drawing.Point(19, 9)
        Me.TextDogName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextDogName.Name = "TextDogName"
        Me.TextDogName.Size = New System.Drawing.Size(152, 13)
        Me.TextDogName.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextDogID)
        Me.Panel1.Location = New System.Drawing.Point(86, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 32)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextDogName)
        Me.Panel2.Location = New System.Drawing.Point(86, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 32)
        Me.Panel2.TabIndex = 6
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Transparent
        Me.btnDel.Location = New System.Drawing.Point(180, 195)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(106, 36)
        Me.btnDel.TabIndex = 7
        Me.btnDel.Text = "Delete Record"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Location = New System.Drawing.Point(134, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 31)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Back to Home"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(180, 236)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(106, 36)
        Me.btnExport.TabIndex = 32
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(70, 236)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(106, 36)
        Me.btnImport.TabIndex = 31
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(347, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(281, 308)
        Me.DataGridView1.TabIndex = 33
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnRefresh.Location = New System.Drawing.Point(579, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 34
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(70, 277)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(216, 36)
        Me.btnPrint.TabIndex = 37
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Note: You need to Fill up the text boxes before clicking "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "the Add and Delete Button"
        '
        'Name
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 387)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnAdd)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Name"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Name"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextDogID As TextBox
    Friend WithEvents TextDogName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
