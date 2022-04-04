Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As Integer = Txt1.Text
        Dim str2 As Integer = Txt2.Text

        Label10.Text = str1 + str2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str1 As Integer = Txt1.Text
        Dim str2 As Integer = Txt2.Text

        Label10.Text = str1 - str2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str1 As Integer = Txt1.Text
        Dim str2 As Integer = Txt2.Text

        Label10.Text = str1 * str2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str1 As Integer = Txt1.Text
        Dim str2 As Integer = Txt2.Text

        Label10.Text = str1 / str2

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim myForm As New Form1
        Me.Hide()
        myForm.Show()
    End Sub
End Class