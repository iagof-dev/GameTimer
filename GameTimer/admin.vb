Public Class admin
    Dim TempoSegundos As String
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Usuario: N3rdyDzn"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TempoSegundos = NumericUpDown1.Value
        Label4.Text = "Valor setado: " & TempoSegundos
        Form1.Timer1.Start()
        Form1.Timer2.Start()
        Form1.Label2.Text = NumericUpDown1.Value
        Form1.Label4.Visible = False
        Form1.Label2.Visible = True
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.bloqueio.Start()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1.bloqueio.Stop()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Timer2.Stop()
        Form1.Label2.Text = NumericUpDown1.Value
        Form1.Timer2.Start()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Timer1.Stop()
        Form1.Timer2.Stop()
        Form1.Label4.Visible = False
        NumericUpDown1.Value = Form1.Label2.Text
        Form1.Timer1.Start()
        Form1.Timer2.Start()
        Form1.Label2.Visible = True
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("explorer.exe")
    End Sub
End Class