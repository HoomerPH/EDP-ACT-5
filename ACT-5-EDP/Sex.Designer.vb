<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sex
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextDogSex = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextDogID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(147, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 31)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Back to Home"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(193, 195)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(106, 36)
        Me.btnDel.TabIndex = 20
        Me.btnDel.Text = "Delete Record"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextDogSex)
        Me.Panel2.Location = New System.Drawing.Point(95, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 32)
        Me.Panel2.TabIndex = 19
        '
        'TextDogSex
        '
        Me.TextDogSex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextDogSex.Location = New System.Drawing.Point(19, 9)
        Me.TextDogSex.Margin = New System.Windows.Forms.Padding(2)
        Me.TextDogSex.Name = "TextDogSex"
        Me.TextDogSex.Size = New System.Drawing.Size(152, 13)
        Me.TextDogSex.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextDogID)
        Me.Panel1.Location = New System.Drawing.Point(95, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 32)
        Me.Panel1.TabIndex = 18
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Dog Sex"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(31, 34)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(49, 16)
        Me.lblUsername.TabIndex = 16
        Me.lblUsername.Text = "Dog ID"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(81, 195)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 36)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(353, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(281, 309)
        Me.DataGridView1.TabIndex = 32
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(193, 236)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(106, 36)
        Me.btnExport.TabIndex = 34
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(81, 236)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(106, 36)
        Me.btnImport.TabIndex = 33
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRefresh.Location = New System.Drawing.Point(584, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 36
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(81, 277)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(218, 36)
        Me.btnPrint.TabIndex = 37
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "the Add and Delete Button"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Note: You need to Fill up the text boxes before clicking "
        '
        'Sex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 387)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnAdd)
        Me.MaximizeBox = False
        Me.Name = "Sex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sex"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextDogSex As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextDogID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnExport As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
