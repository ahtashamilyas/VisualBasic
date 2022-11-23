Public Class Form1
    Dim a, b As Decimal
    Dim op As Char

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox1.Text = TextBox1.Text + btn1.Text
        a = TextBox1.Text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TextBox1.Text = TextBox1.Text + btn2.Text
        a = TextBox1.Text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TextBox1.Text = TextBox1.Text + btn3.Text
        a = TextBox1.Text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox1.Text = TextBox1.Text + btn4.Text
        a = TextBox1.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TextBox1.Text = TextBox1.Text + btn5.Text
        a = TextBox1.Text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        TextBox1.Text = TextBox1.Text + btn6.Text
        a = TextBox1.Text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TextBox1.Text = TextBox1.Text + btn7.Text
        a = TextBox1.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        TextBox1.Text = TextBox1.Text + btn8.Text
        a = TextBox1.Text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        TextBox1.Text = TextBox1.Text + btn9.Text
        a = TextBox1.Text
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        TextBox1.Text = TextBox1.Text + btn10.Text
        a = TextBox1.Text
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        TextBox1.Text = TextBox1.Text + btn11.Text
        a = TextBox1.Text
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        TextBox1.Clear()

    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        op = "+"
        b = TextBox1.Text
        TextBox1.Clear()

    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        op = "-"
        b = TextBox1.Text
        TextBox1.Clear()
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        op = "*"
        b = TextBox1.Text
        TextBox1.Clear()
    End Sub
    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        op = "/"
        b = TextBox1.Text
        TextBox1.Clear()
    End Sub

    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        If op = "+" Then
            TextBox1.Text = a + b
        ElseIf op = "-" Then
            TextBox1.Text = a - b
        ElseIf op = "*" Then
            TextBox1.Text = a * b
        ElseIf op = "/" Then
            TextBox1.Text = a / b
        Else
            TextBox1.Text = TextBox1.Text


        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
