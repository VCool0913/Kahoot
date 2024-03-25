<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.Red
        Me.Btn1.Location = New System.Drawing.Point(87, 293)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(131, 226)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Button1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(1049, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 226)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(340, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 167)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button3.Location = New System.Drawing.Point(851, 402)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 167)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BackgroundImage = Global.Kahoot.My.Resources.Resources.Screenshot_2024_03_25_094244
        Me.ClientSize = New System.Drawing.Size(1236, 677)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Form1"
        Me.Text = "卡胡特"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
