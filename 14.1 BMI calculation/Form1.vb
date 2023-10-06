Imports System.Drawing.Text

Public Class Form1
    Private Function BMI(Height As Single, Weight As Single) As Double
        BMI = Weight / Height ^ 2

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim H As Single, W As Single
        H = Val(TextBox1.Text)
        W = Val(TextBox2.Text)

        TextBox3.Text = Format(BMI(H, W), "0.00")





    End Sub


End Class
