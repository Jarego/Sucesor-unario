Public Class Form2
    Dim res As String
    Dim cont = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text += " "
        q0()


    End Sub



    Sub q0()
        If TextBox1.Text(cont) = "0" Then

            Timer1.Enabled = True
            res += "0"
            cont += 1
            Label1.Text = res
            PictureBox1.Image = ImageList1.Images(1)
            MsgBox("Se encuentra 0, se cambia a 0, y se mueve a la derecha")
            q0()

        ElseIf TextBox1.Text(cont) = " " Then
            q1()
        ElseIf TextBox1.Text(cont) = "1" Then
            MsgBox("NO SE ACEPTA LA CADENA")
            Label1.Text = ""
            TextBox1.Text = ""
            res = ""
            cont = 0
        End If

    End Sub

    Sub q1()
        res += "0"
        Label1.Text = res
        PictureBox1.Image = ImageList1.Images(2)
        MsgBox("Se encuentra b, se cambia a 0")

        MsgBox("Estado Final")
        Button1.Enabled = False
        Button2.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = ""
        TextBox1.Text = ""
        res = ""
        cont = 0
        Button1.Enabled = True
        Button2.Enabled = False
        PictureBox1.Image = ImageList1.Images(0)
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
