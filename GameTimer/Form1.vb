Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = "5000"
        ' Timer1.Start()
        ' Timer2.Start()
        Label2.Visible = False

        Label2.Text = "0"
        Label4.Visible = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Label5.Text =
        Dim red, blue, green, yellow As String
        red = Int(Rnd() * 255)
        blue = Int(Rnd() * 255)
        green = Int(Rnd() * 255)
        yellow = Int(Rnd() * 255)
        Label2.ForeColor = Color.FromArgb(red, blue, green, yellow)
        Button1.ForeColor = Color.FromArgb(red, blue, green, yellow)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login_Admin.Show()
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label2.Text = "0" Then
            MsgBox("Acabou o tempo!")
            System.Diagnostics.Process.Start("shutdown", "-r -f -t 1")
        Else
            Label2.Text = Val(Label2.Text) - 1
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub bloqueio_Tick(sender As Object, e As EventArgs) Handles bloqueio.Tick
        Dim p() As Process
        p = Process.GetProcessesByName("opera")
        Dim p2() As Process
        p2 = Process.GetProcessesByName("Discord")
        Dim p3() As Process
        p3 = Process.GetProcessesByName("Spotify")
        Dim p4() As Process
        p4 = Process.GetProcessesByName("explorer")

        'Matar processo
        If p.Count > 0 Then
            System.Diagnostics.Process.Start("taskkill", "/f /im opera.exe")
        Else
            If p2.Count > 0 Then
                System.Diagnostics.Process.Start("taskkill", "/f /im Discord.exe")
            Else
                If p4.Count > 0 Then
                    System.Diagnostics.Process.Start("taskkill", "/f /im explorer.exe")
                Else

                End If
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        bloqueio.Start()
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MsgBox("Erro!", MsgBoxStyle.Critical)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub
End Class
