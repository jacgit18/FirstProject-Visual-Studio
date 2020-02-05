Option Strict Off

Public Class Form1
    Private Sub xyz(sender As Object, e As EventArgs) Handles btnLoginIn.Click

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

Private Sub allButtons(ByVal sender As System.Object,
            ByVal e As System.EventArgs) _
            Handles Button1.Click, Button2.Click, Button3.Click,
            Button4.Click, Button5.Click, Button6.Click


    ' This is just a big array of points
    ' (Used in create onscreen cells)
    '
    Dim points() As Point = {
New Point(0, 0), New Point(0, 1), New Point(0, 2), New Point(0, 3),
New Point(1, 0), New Point(2, 1), New Point(3, 0),
New Point(4, 0), New Point(4, 1), New Point(4, 2), New Point(4, 3)}

    Select Case sender.name

        Case "Button1"

            ' Create On Screen Cells
            '
            Graphicgrid1.setCell(points, Color.Red)

            ' Off screen (Use Resize button to see them)
            '
            Graphicgrid1.setCell(New Point(9, 15), Color.White)
            Graphicgrid1.setCell(New Point(10, 15), Color.Green)
            Graphicgrid1.setCell(New Point(11, 15), Color.Yellow)
            Graphicgrid1.setCell(New Point(12, 15), Color.Gold)

        Case "Button2"

            ' Toggle the grid
            '
            Graphicgrid1.ShowGrid = Not Graphicgrid1.ShowGrid

        Case "Button3"

            ' Toggle Big or small size
            '
            If Graphicgrid1.Cells.Equals(New Size(20, 20)) Then
                Graphicgrid1.Cells = New Size(10, 10)
            Else
                Graphicgrid1.Cells = New Size(20, 20)
            End If

        Case "Button4"

            ' Remove a cell
            '
            Graphicgrid1.removeCell(New Point(2, 1))

        Case "Button5"

            ' Clear all the cells
            '
            Graphicgrid1.clearCells()

    End Select
End Sub