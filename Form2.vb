Public Class Form2
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        BackColor = ColorDialog1.Color

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strName As String = txtName.Text
        Dim strNumber As String = txtNumber.Text
        Dim strOutput As String = "My Name Is " + strName + " I am ,  " + strNumber + " years old ."

        lblOutput.Text = strOutput

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myForm As New Form3
        Me.Hide()
        myForm.Show()

    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim myForm As New Form1
        Me.Hide()
        myForm.Show()
    End Sub
End Class