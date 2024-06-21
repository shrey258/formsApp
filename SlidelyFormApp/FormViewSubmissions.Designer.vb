<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewSubmissions
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithubLink = New System.Windows.Forms.TextBox()
        Me.lblStopwatchTime = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEnableEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(66, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(66, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(66, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(66, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Github " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Link"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(59, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stopwatch " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Time"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(150, 72)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(215, 22)
        Me.txtName.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(150, 123)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(215, 22)
        Me.txtEmail.TabIndex = 6
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtPhone.Location = New System.Drawing.Point(150, 179)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(215, 22)
        Me.txtPhone.TabIndex = 7
        '
        'txtGithubLink
        '
        Me.txtGithubLink.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtGithubLink.Location = New System.Drawing.Point(150, 238)
        Me.txtGithubLink.Multiline = True
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.ReadOnly = True
        Me.txtGithubLink.Size = New System.Drawing.Size(215, 21)
        Me.txtGithubLink.TabIndex = 8
        '
        'lblStopwatchTime
        '
        Me.lblStopwatchTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblStopwatchTime.Location = New System.Drawing.Point(150, 298)
        Me.lblStopwatchTime.Name = "lblStopwatchTime"
        Me.lblStopwatchTime.ReadOnly = True
        Me.lblStopwatchTime.Size = New System.Drawing.Size(215, 22)
        Me.lblStopwatchTime.TabIndex = 9
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnPrevious.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.btnPrevious.Location = New System.Drawing.Point(12, 365)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(148, 25)
        Me.btnPrevious.TabIndex = 10
        Me.btnPrevious.Text = "PREVIOUS (CTRL + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.btnNext.Location = New System.Drawing.Point(269, 365)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(148, 25)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "NEXT (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.btnDelete.Location = New System.Drawing.Point(12, 422)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(148, 25)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "DELETE (CTRL + D)"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEnableEdit
        '
        Me.btnEnableEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnEnableEdit.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.btnEnableEdit.Location = New System.Drawing.Point(269, 422)
        Me.btnEnableEdit.Name = "btnEnableEdit"
        Me.btnEnableEdit.Size = New System.Drawing.Size(148, 25)
        Me.btnEnableEdit.TabIndex = 13
        Me.btnEnableEdit.Text = "EDIT (CTRL + E)"
        Me.btnEnableEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.btnSave.Location = New System.Drawing.Point(293, 422)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 25)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "SAVE (CTRL + S)"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(59, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(306, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Shreyansh Gupta, Slidely Task 2 - View Submissions"
        '
        'FormViewSubmissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(429, 485)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEnableEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblStopwatchTime)
        Me.Controls.Add(Me.txtGithubLink)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Gadugi", 8.25!)
        Me.Name = "FormViewSubmissions"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents lblStopwatchTime As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEnableEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label6 As Label
End Class
