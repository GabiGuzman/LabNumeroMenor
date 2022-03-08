Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = TextBox1.Text
        Dim d As Integer = TextBox2.Text
        Dim c As Integer = TextBox3.Text
        Dim b As Integer
        If a < d And a < c Then
            b = a
        ElseIf d < a And d < c Then
            b = d
        ElseIf c < a And c < d Then
            b = c
        End If
        TextBox4.Text = b

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
