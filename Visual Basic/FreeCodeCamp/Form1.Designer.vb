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
        Me.Input.Location = New System.Drawing.Point(58, 285)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(99, 39)
        Me.Input.TabIndex = 3
        Me.Input.Text = "Input"
        Me.Input.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Input)
        Me.Controls.Add(Me.DataType)
        Me.Controls.Add(Me.btnVar)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents btnVar As Button
    Friend WithEvents DataType As Button
    Friend WithEvents Input As Button
End Class
