Public Class Form1
    Private Sub AddSourceControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSourceControlToolStripMenuItem.Click
        'Test question this means need address dialog before doing anything else while show means you can go back to OG window and interact with it
        Source_Control.ShowDialog()
    End Sub

    Private Sub ChangeBackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeBackgroundColorToolStripMenuItem.Click

        Dim ourdialogresult As DialogResult

        ourdialogresult = ColorDialog1.ShowDialog
        If ourdialogresult = DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color



        End If




    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim ourdialogresult As DialogResult

        ourdialogresult = FontDialog1.ShowDialog
        If ourdialogresult = DialogResult.OK Then
            Dim myfont = FontDialog1.Font

            Me.Font = myfont



        End If
    End Sub
End Class
