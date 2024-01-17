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
        Me.myItem = New System.Windows.Forms.Button()
        Me.myItem2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'myItem
        '
        Me.myItem.BackColor = System.Drawing.Color.Yellow
        Me.myItem.Location = New System.Drawing.Point(82, 231)
        Me.myItem.Name = "myItem"
        Me.myItem.Size = New System.Drawing.Size(98, 38)
        Me.myItem.TabIndex = 0
        Me.myItem.Text = "Add"
        Me.myItem.UseVisualStyleBackColor = False
        '
        'myItem2
        '
        Me.myItem2.BackColor = System.Drawing.Color.Lime
        Me.myItem2.Location = New System.Drawing.Point(222, 234)
        Me.myItem2.Name = "myItem2"
        Me.myItem2.Size = New System.Drawing.Size(103, 35)
        Me.myItem2.TabIndex = 1
        Me.myItem2.Text = "Remove"
        Me.myItem2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Cyan
        Me.Button3.Location = New System.Drawing.Point(388, 231)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 38)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Remove Selected"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Blue
        Me.Button4.Location = New System.Drawing.Point(544, 231)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 38)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Iphone", "Samsung", "Huawei"})
        Me.ComboBox1.Location = New System.Drawing.Point(287, 78)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.myItem2)
        Me.Controls.Add(Me.myItem)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents myItem As Button
    Friend WithEvents myItem2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
