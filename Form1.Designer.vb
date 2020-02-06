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
        Me.btnLoginIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLoginIn
        '
        Me.btnLoginIn.BackColor = System.Drawing.Color.DarkBlue
        Me.btnLoginIn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnLoginIn.Location = New System.Drawing.Point(50, 279)
        Me.btnLoginIn.Name = "btnLoginIn"
        Me.btnLoginIn.Size = New System.Drawing.Size(75, 40)
        Me.btnLoginIn.TabIndex = 4
        Me.btnLoginIn.Text = "Generate Buttons"
        Me.btnLoginIn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(913, 350)
        Me.Controls.Add(Me.btnLoginIn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoginIn As Button
End Class
