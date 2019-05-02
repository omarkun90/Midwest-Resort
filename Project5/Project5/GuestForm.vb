Imports Oracle.DataAccess.Client
Public Class frmGuests
    Private Sub cmdFindGuest_Click(sender As Object, e As EventArgs) Handles cmdFindGuest.Click
        'Show window for finding guest
        frmFindGuest.Show()

    End Sub

    Private Sub btnCloseGuestWin_Click(sender As Object, e As EventArgs) Handles btnCloseGuestWin.Click
        'close main guest window
        Close()
    End Sub
End Class