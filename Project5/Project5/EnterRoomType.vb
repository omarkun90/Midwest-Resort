Imports Oracle.DataAccess.Client
Public Class frmRoomTypeEnter
    Private Sub cmdEnterRoomType_Click(sender As Object, e As EventArgs) Handles cmdEnterRoomType.Click
        Dim oradatabase As String = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" _
            + "(ADDRESS=(PROTOCOL=TCP)(HOST=luboradb.business.uwm.edu)(PORT=1521)))" _
            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl.business.uwm.edu)));" _
            + "USER Id=munozro2;Password=wnmkrm9432P@;"
        ' Connect to the database
        Dim conn As New OracleConnection(oradatabase)
        conn.Open()
        'Set up the SQL Command to retrieve the data, including missing parameters
        Dim SQLCommand As String
        If txtFindRoomType.Text <> "" Then
            SQLCommand = "SELECT GUEST.LASTNAME, GUEST.FIRSTNAME, GUEST.STRADDR, RESERVATION.RESDATETIME, RESERVATION.CHECKINDATE, RESERVATION.CHECKOUTDATE, RESERVATION.ROOMTYPE, 
            RESERVATION.TOTALCOST FROM RESERVATION INNER JOIN GUEST ON RESERVATION.GUESTID = GUEST.GUESTID WHERE RESERVATION.ROOMTYPE LIKE '" + txtFindRoomType.Text.ToUpper + "'"
            Me.Close()
            'Create a data adapter to define from where to pull the data
            Dim adapter As OracleDataAdapter = New OracleDataAdapter(SQLCommand, conn)
            'Create a dataset to import the retrieved data
            Dim reserveFindTBL As New DataSet()
            'Populate the dataset based on the data adapter's output
            adapter.Fill(reserveFindTBL)
            'Bind the reservation data to the datagrid
            frmReservationForm.dgReservation.DataSource = reserveFindTBL.Tables(0)
            'Disconnect from database
            conn.Close()

        Else
            'Error message box upon no userinput, user can still try again - windows does not close here
            MessageBox.Show("Please enter a valid last name", "Invalid Entry",
            MessageBoxButtons.OK, MessageBoxIcon.Error)

            conn.Close()

        End If

    End Sub
End Class