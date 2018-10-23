Public Class frmMeowmaMeatzaPizza
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrDateTimeSource.Tick
        lblDateTime.Text = DateTime.Now.ToString
    End Sub
End Class
