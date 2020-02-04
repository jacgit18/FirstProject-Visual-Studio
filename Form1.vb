Option Strict Off

Public Class Form1
    Private Sub xyz(sender As Object, e As EventArgs) Handles btnLoginIn.Click, Label1.Click

        If txtUsername.Text.ToLower = txtPassword.Text.ToLower Then
            lblMessage.Text = "success"
        Else
            lblMessage.Text = "not success"
        End If

        ' Responsible for deleting buttons
        For j = Me.Controls.Count - 1 To 0 Step -1
            If Me.Controls(j).Name.Length > 10 AndAlso Me.Controls(j).Name.Substring(0, 10) = "New Button" Then
                Me.Controls.RemoveAt(j)
            End If
        Next
        'Runtime code
        For i = 1 To Integer.Parse(txtnum.Text)
            'MessageBox.Show("making button " + i.ToString)
            Dim nextbutton As Button
            nextbutton = New System.Windows.Forms.Button()
            nextbutton.BackColor = System.Drawing.Color.DarkBlue
            nextbutton.ForeColor = System.Drawing.SystemColors.HighlightText
            nextbutton.Location = New System.Drawing.Point(116, 140 + (i * 45))
            nextbutton.Name = "New Button " + i.ToString
            nextbutton.Size = New System.Drawing.Size(75, 40)
            nextbutton.Text = "Button " + i.ToString
            AddHandler nextbutton.Click, AddressOf newbuttonclick
            Me.Controls.Add(nextbutton)
        Next
        Me.Size = New System.Drawing.Size(Me.Size.Width, 245 + (Integer.Parse(txtnum.Text) * 45))
    End Sub
    Private Sub newbuttonclick(sender As Object, e As EventArgs)
        '  MessageBox.Show("a button was clicked")
        Dim clickbutton As Button
        ' casting
        clickbutton = CType(sender, Button)
        ' MessageBox.Show(clickbutton.Name)
        Dim number As Integer
        number = clickbutton.Name.Substring(11)
        txtsum.Text = txtsum.Text + number

    End Sub

End Class
