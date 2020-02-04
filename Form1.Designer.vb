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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.greeting = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLoginIn = New System.Windows.Forms.Button()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.txtsum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Khaki
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(57, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'greeting
        '
        Me.greeting.AutoSize = True
        Me.greeting.BackColor = System.Drawing.Color.Khaki
        Me.greeting.ForeColor = System.Drawing.SystemColors.Highlight
        Me.greeting.Location = New System.Drawing.Point(57, 5)
        Me.greeting.Name = "greeting"
        Me.greeting.Size = New System.Drawing.Size(52, 13)
        Me.greeting.TabIndex = 0
        Me.greeting.Text = "Greetings"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(140, 35)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(140, 79)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Khaki
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(57, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'btnLoginIn
        '
        Me.btnLoginIn.BackColor = System.Drawing.Color.DarkBlue
        Me.btnLoginIn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnLoginIn.Location = New System.Drawing.Point(116, 140)
        Me.btnLoginIn.Name = "btnLoginIn"
        Me.btnLoginIn.Size = New System.Drawing.Size(75, 40)
        Me.btnLoginIn.TabIndex = 4
        Me.btnLoginIn.Text = "Generate Buttons"
        Me.btnLoginIn.UseVisualStyleBackColor = False
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(215, 151)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(56, 20)
        Me.txtnum.TabIndex = 6
        '
        'txtsum
        '
        Me.txtsum.Location = New System.Drawing.Point(381, 151)
        Me.txtsum.Name = "txtsum"
        Me.txtsum.Size = New System.Drawing.Size(100, 20)
        Me.txtsum.TabIndex = 7
        Me.txtsum.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(661, 209)
        Me.Controls.Add(Me.txtsum)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.btnLoginIn)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.greeting)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents greeting As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLoginIn As Button
    Friend WithEvents txtnum As TextBox
    Friend WithEvents txtsum As TextBox
End Class
