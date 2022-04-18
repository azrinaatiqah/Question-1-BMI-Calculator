Public Class Form1
    Private Function BMI(Height As Single, weight As Single) As Double
        BMI = weight / Height ^ 2
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tinggi As Single, berat As Single
        tinggi = Val(TextBox1.Text)
        berat = Val(TextBox2.Text)
        lbloutput.Text = BMI(tinggi, berat)
    End Sub
End Class
