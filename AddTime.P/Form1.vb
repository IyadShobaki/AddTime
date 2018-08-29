Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myTime As Date = DateTime.Now()
        Label1.Text = myTime


    End Sub

    Private Sub btnAddSeconds_Click(sender As Object, e As EventArgs) Handles btnAddSeconds.Click
        Label1.Text = DateAdd(DateInterval.Second, 5, CDate(Label1.Text))
    End Sub

    Private Sub btnAddminutes_Click(sender As Object, e As EventArgs) Handles btnAddminutes.Click
        Label1.Text = DateAdd(DateInterval.Minute, 5, CDate(Label1.Text))
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If Label1.Text = lblCurrentTime.Text Then
            MessageBox.Show("Yippie")
        End If
    End Sub
End Class
