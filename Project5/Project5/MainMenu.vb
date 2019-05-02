Imports Oracle.DataAccess.Client

Public Class frmMainMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub cmdBrowseGuest_Click(sender As Object, e As EventArgs) Handles cmdBrowseGuest.Click
        'Show our guest form
        frmGuests.Show()
        Dim oradatabase As String = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" _
            + "(ADDRESS=(PROTOCOL=TCP)(HOST=luboradb.business.uwm.edu)(PORT=1521)))" _
            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl.business.uwm.edu)));" _
            + "USER Id=munozro2;Password=wnmkrm9432P@;"
        'Connect to the database
        Dim conn As New OracleConnection(oradatabase)
        conn.Open()
        'Create a data adapter to define from where to pull the data, in this case all data from guest
        Dim adapter As OracleDataAdapter = New OracleDataAdapter("SELECT * FROM GUEST", conn)
        'Create a dataset to import the retrieved data
        Dim guestTBL As New DataSet()
        'Populate the dataset based on the data adapter's output
        adapter.Fill(guestTBL)
        'Bind the guest data to the datagrid
        frmGuests.dgGuest.DataSource = guestTBL.Tables(0)
        conn.Close()
    End Sub

    Private Sub cmdBrowseReservation_Click(sender As Object, e As EventArgs) Handles cmdBrowseReservation.Click
        frmReservationForm.Show()
        Dim oradatabase As String = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" _
            + "(ADDRESS=(PROTOCOL=TCP)(HOST=luboradb.business.uwm.edu)(PORT=1521)))" _
            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl.business.uwm.edu)));" _
            + "USER Id=munozro2;Password=wnmkrm9432P@;"
        'Connect to the database
        Dim conn As New OracleConnection(oradatabase)
        conn.Open()
        'Create a data adapter to define from where to pull the data - multiple tables including guest and reservation - join needed 
        Dim adapter As OracleDataAdapter = New OracleDataAdapter("SELECT GUEST.LASTNAME, GUEST.FIRSTNAME, GUEST.STRADDR, RESERVATION.RESDATETIME, RESERVATION.CHECKINDATE, RESERVATION.CHECKOUTDATE, RESERVATION.ROOMTYPE, 
       RESERVATION.TOTALCOST FROM RESERVATION INNER JOIN GUEST ON RESERVATION.GUESTID = GUEST.GUESTID", conn)
        'Create a dataset to import the retrieved data
        Dim reservationTBL As New DataSet()
        'Populate the dataset based on the data adapter's output
        adapter.Fill(reservationTBL)
        'Bind the reservation data to the datagrid on the reservationform
        frmReservationForm.dgReservation.DataSource = reservationTBL.Tables(0)
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdBillCharges.Click
        BillAuthentication.Show() 'display the billauthentication form
    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click
        Close() 'Terminate the application
    End Sub
End Class
