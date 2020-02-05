Option Strict Off

Public Class Form1

    Private Sub xyz(sender As Object, e As EventArgs) Handles btnLoginIn.Click
        Dim Xaxis As Integer = 8
        Dim y As Integer = 8
        Dim blue As Boolean = True

        For i = 1 To 8
            x = 8
            If i Mod 2 = 0 Then
                blue = False
            Else
                blue = True
            End If
            For j = 1 To 8
                Dim newlabel As Label
                newlabel = New System.Windows.Forms.Label()
                If blue = True Then
                    newlabel.BackColor = System.Drawing.Color.Aqua
                ElseIf blue = False Then
                    newlabel.BackColor = System.Drawing.Color.Black
                End If

                newlabel.Location = New System.Drawing.Point(Xaxis, Yaxis)
                newlabel.Size = New System.Drawing.Size(30, 30)
                newlabel.Size = New System.Drawing.Size(30, 30)

                Me.Controls.Add(newlabel)
                Xaxis = Xaxis + 30
                blue = Not blue
            Next
            Yaxis = Yaxis + 30


        Next



    End Sub

End Class
