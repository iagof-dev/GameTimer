Public Class Login_Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "n3rdydzn" Then
            If TextBox2.Text = "132490kj" Then
                admin.Show()
                Form1.Hide()
                Me.Close()

            Else
                MsgBox("Erro! User/Senha incorreta!")
            End If
        Else
            MsgBox("Erro! User/Senha incorreta!")
        End If
    End Sub
End Class