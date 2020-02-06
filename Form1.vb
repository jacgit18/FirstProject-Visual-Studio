Option Strict Off

Public Class Form1

    Private Sub xyz(sender As Object, e As EventArgs) Handles btnLoginIn.Click
        Dim Xaxis As Integer = 8
        Dim Yaxis As Integer = 8
        Dim blue As Boolean = True

        For i = 1 To 8
            Xaxis = 8
            If i Mod 2 = 0 Then
                blue = False
            Else
                blue = True
            End If
            For j = 1 To 8
                Dim Lblsquare As Label
                Lblsquare = New System.Windows.Forms.Label()
                If blue = True Then
                    Lblsquare.BackColor = System.Drawing.Color.Aqua
                ElseIf blue = False Then
                    Lblsquare.BackColor = System.Drawing.Color.Black
                End If

                Lblsquare.Location = New System.Drawing.Point(Xaxis, Yaxis)
                Lblsquare.Size = New System.Drawing.Size(15, 15)
                Lblsquare.Size = New System.Drawing.Size(15, 15)

                Me.Controls.Add(Lblsquare)
                Xaxis = Xaxis + 15
                blue = Not blue
            Next
            Yaxis = Yaxis + 15


        Next



    End Sub

End Class
