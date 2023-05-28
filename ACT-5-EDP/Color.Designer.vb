<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Color
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
        Me.TextDogColor = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextDogID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.Button1.Location = New System.Drawing.Point(154, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 32)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(204, 120)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(93, 36)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "Delete Record"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextDogColor)
        Me.Panel2.Location = New System.Drawing.Point(94, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 32)
        Me.Panel2.TabIndex = 26
        '
        'TextDogColor
        '
        Me.TextDogColor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextDogColor.Location = New System.Drawing.Point(19, 9)
        Me.TextDogColor.Margin = New System.Windows.Forms.Padding(2)
        Me.TextDogColor.Name = "TextDogColor"
        Me.TextDogColor.Size = New System.Drawing.Size(152, 13)
        Me.TextDogColor.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextDogID)
        Me.Panel1.Location = New System.Drawing.Point(94, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 32)
        Me.Panel1.TabIndex = 25
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
        Me.Label1.Location = New System.Drawing.Point(16, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Cat Color"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(30, 37)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(44, 16)
        Me.lblUsername.TabIndex = 23
        Me.lblUsername.Text = "Cat ID"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(94, 120)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 36)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(94, 161)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(91, 36)
        Me.btnImport.TabIndex = 29
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(204, 161)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(93, 36)
        Me.btnExport.TabIndex = 30
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(349, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(281, 307)
        Me.DataGridView1.TabIndex = 31
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
        Me.btnPrint.Location = New System.Drawing.Point(94, 202)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(203, 36)
        Me.btnPrint.TabIndex = 37
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "the Add and Delete Button"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Note: You need to Fill up the text boxes before clicking "
        '
        'Color
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
        Me.MaximizeBox = False
        Me.Name = "Color"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color"
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
    Friend WithEvents TextDogColor As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextDogID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
