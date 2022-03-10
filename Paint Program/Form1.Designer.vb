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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.clearbutton = New System.Windows.Forms.Button()
        Me.savebutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(671, 130)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(567, 390)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(607, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(607, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkOrange
        Me.Button3.Location = New System.Drawing.Point(647, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 32)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(687, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(34, 32)
        Me.Button4.TabIndex = 5
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Purple
        Me.Button5.Location = New System.Drawing.Point(727, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(34, 32)
        Me.Button5.TabIndex = 6
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Fuchsia
        Me.Button6.Location = New System.Drawing.Point(607, 50)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(34, 32)
        Me.Button6.TabIndex = 7
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Lime
        Me.Button7.Location = New System.Drawing.Point(647, 50)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(34, 32)
        Me.Button7.TabIndex = 8
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkGreen
        Me.Button8.Location = New System.Drawing.Point(687, 50)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(34, 32)
        Me.Button8.TabIndex = 9
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Blue
        Me.Button9.Location = New System.Drawing.Point(727, 50)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(34, 32)
        Me.Button9.TabIndex = 10
        Me.Button9.UseVisualStyleBackColor = False
        '
        'clearbutton
        '
        Me.clearbutton.Location = New System.Drawing.Point(607, 202)
        Me.clearbutton.Name = "clearbutton"
        Me.clearbutton.Size = New System.Drawing.Size(75, 23)
        Me.clearbutton.TabIndex = 11
        Me.clearbutton.Text = "CLEAR"
        Me.clearbutton.UseVisualStyleBackColor = True
        '
        'savebutton
        '
        Me.savebutton.Location = New System.Drawing.Point(607, 231)
        Me.savebutton.Name = "savebutton"
        Me.savebutton.Size = New System.Drawing.Size(75, 23)
        Me.savebutton.TabIndex = 12
        Me.savebutton.Text = "SAVE"
        Me.savebutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(668, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Width:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(602, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Color:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.savebutton)
        Me.Controls.Add(Me.clearbutton)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents clearbutton As Button
    Friend WithEvents savebutton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
