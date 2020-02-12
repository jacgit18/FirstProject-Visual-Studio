Option Strict Off

Public Class Form1
    Private Sub xyz_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim mygraphics As Graphics
        mygraphics = e.Graphics
        Dim x, y, ssize As Integer
        x = 100 : y = 100
        ssize = 40
        Dim mybrush = New SolidBrush(Drawing.Color.Red)
        mygraphics.FillRectangle(mybrush, 100, 100, 8 * ssize, 8 * ssize)
        mybrush = New SolidBrush(Drawing.Color.DeepSkyBlue)
        For i = 1 To 8
            If i Mod 2 = 1 Then x = x + ssize
            For j = 1 To 4
                mygraphics.FillRectangle(mybrush, x, y, ssize, ssize)
                x = x + (2 * ssize)
            Next
            y = y + ssize
            x = 100
        Next
        mybrush = New SolidBrush(Drawing.Color.Green)
        mygraphics.FillEllipse(mybrush, 200, 200, 180, 80)
        Dim mypen = New Pen(Drawing.Color.Yellow)
        mypen.Width = 4
        Dim myfont = New Font("Arial", 16)
        mygraphics.DrawString("Hello", myfont, mybrush, 10, 10)
        mybrush = New SolidBrush(Drawing.Color.Yellow)
        mygraphics.FillPie(mybrush, 200, 200, 50, 50, 180, 180)

        mygraphics.FillPie(mybrush, 300, 300, 50, 50, 0, 40)



    End Sub


End Class
