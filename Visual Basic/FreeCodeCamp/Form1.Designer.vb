<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnVar = New System.Windows.Forms.Button()
        Me.DataType = New System.Windows.Forms.Button()
        Me.Input = New System.Windows.Forms.Button()
        Me.txtFirtsName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lstOccupation = New System.Windows.Forms.ListBox()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGo.Location = New System.Drawing.Point(58, 51)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(99, 49)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'btnVar
        '
        Me.btnVar.Location = New System.Drawing.Point(183, 51)
        Me.btnVar.Name = "btnVar"
        Me.btnVar.Size = New System.Drawing.Size(99, 49)
        Me.btnVar.TabIndex = 1
        Me.btnVar.Text = "Variable"
        Me.btnVar.UseVisualStyleBackColor = True
        '
        'DataType
        '
        Me.DataType.Location = New System.Drawing.Point(314, 51)
        Me.DataType.Name = "DataType"
        Me.DataType.Size = New System.Drawing.Size(99, 49)
        Me.DataType.TabIndex = 2
        Me.DataType.Text = "Data Type"
        Me.DataType.UseVisualStyleBackColor = True
        '
        'Input
        '
        Me.Input.Location = New System.Drawing.Point(58, 127)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(99, 39)
        Me.Input.TabIndex = 3
        Me.Input.Text = "Input"
        Me.Input.UseVisualStyleBackColor = True
        '
        'txtFirtsName
        '
        Me.txtFirtsName.Location = New System.Drawing.Point(314, 199)
        Me.txtFirtsName.Name = "txtFirtsName"
        Me.txtFirtsName.Size = New System.Drawing.Size(267, 22)
        Me.txtFirtsName.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(209, 202)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(72, 16)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(314, 244)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(267, 22)
        Me.txtLastName.TabIndex = 6
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(209, 246)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(72, 16)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Last Name"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(314, 290)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(267, 22)
        Me.txtGender.TabIndex = 8
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(209, 293)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(52, 16)
        Me.lblGender.TabIndex = 9
        Me.lblGender.Text = "Gender"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(480, 348)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(101, 33)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lstOccupation
        '
        Me.lstOccupation.FormattingEnabled = True
        Me.lstOccupation.ItemHeight = 16
        Me.lstOccupation.Items.AddRange(New Object() {"Doctor", "Programmer", "Teacher", "Student", "Banker", "Businessman"})
        Me.lstOccupation.Location = New System.Drawing.Point(617, 170)
        Me.lstOccupation.Name = "lstOccupation"
        Me.lstOccupation.Size = New System.Drawing.Size(139, 228)
        Me.lstOccupation.TabIndex = 11
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Location = New System.Drawing.Point(614, 138)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(94, 20)
        Me.lblOccupation.TabIndex = 12
        Me.lblOccupation.Text = "Occupation"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOccupation)
        Me.Controls.Add(Me.lstOccupation)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirtsName)
        Me.Controls.Add(Me.Input)
        Me.Controls.Add(Me.DataType)
        Me.Controls.Add(Me.btnVar)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents btnVar As Button
    Friend WithEvents DataType As Button
    Friend WithEvents Input As Button
    Friend WithEvents txtFirtsName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label
End Class
