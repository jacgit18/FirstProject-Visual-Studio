Option Strict Off

Public Class Form1
    Private Sub xyz_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim mygraphics As Graphics
        mygraphics = e.Graphics

        Dim mygraphics1 As Graphics
        mygraphics1 = e.Graphics

        Dim x, y, ssize As Integer

        x = 100 : y = 100

        ssize = 40

        Dim mybrush = New SolidBrush(Drawing.Color.DarkSeaGreen)
        mygraphics.FillRectangle(mybrush, 100, 100, 8 * ssize, 8 * ssize)
        mybrush = New SolidBrush(Drawing.Color.Crimson)

        For i = 1 To 8

            If i Mod 2 = 1 Then x = x + ssize


            For j = 1 To 4

                mygraphics.FillRectangle(mybrush, x, y, ssize, ssize)
                x = x + (2 * ssize)


            Next
            y = y + ssize
            x = 100


        Next



    End Sub


End Class
