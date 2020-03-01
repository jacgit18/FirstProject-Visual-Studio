Option Strict Off

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mybtn_Click(sender As Object, e As EventArgs) Handles mybtn.Click
        MessageBox.Show("hey")

        MessageBox.Show("hey", "whatsup") ' message, dialogbox title
        MessageBox.Show("hey", "whatsup", MessageBoxButtons.YesNoCancel)
        MessageBox.Show("hey", "whatsup", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error)
        MsgBox("hey") 'otherway    End Sub
End Class
