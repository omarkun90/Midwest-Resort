Public Class frmReservationForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdFindReservation.Click
        'Show window for entering room type
        frmRoomTypeEnter.Show()
    End Sub

    Private Sub btnCloseReserv_Click(sender As Object, e As EventArgs) Handles btnCloseReserv.Click
        'close reservation window
        Close()
    End Sub
End Class