Imports Oracle.DataAccess.Client

Public Class frmFindGuest
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Set up a connection
        Dim oradatabase As String = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" _
            + "(ADDRESS=(PROTOCOL=TCP)(HOST=luboradb.business.uwm.edu)(PORT=1521)))" _
            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl.business.uwm.edu)));" _
            + "USER Id=munozro2;Password=wnmkrm9432P@;"
        ' Connect to the database
        Dim conn As New OracleConnection(oradatabase)
        conn.Open()
        'Set up the SQL Command to retrieve the data, including missing parameters
        Dim SQLCommand As String

        'if/else statement to determine userinput and compare it to the sqlcommand - error message if nothing is typed & entered
        If txtFindGuest.Text <> "" Then
            SQLCommand = "SELECT * FROM GUEST WHERE LASTNAME LIKE '" + txtFindGuest.Text.ToUpper + "'"
            Me.Close() 'close find guest form upon succesfully finding or not finding inputed user text to database value
            'Create a data adapter to define from where to pull the data
            Dim adapter As OracleDataAdapter = New OracleDataAdapter(SQLCommand, conn)
            'Create a dataset to import the retrieved data
            Dim guestFindTBL As New DataSet()
            'Populate the dataset based on the data adapter's output
            adapter.Fill(guestFindTBL)
            'Bind the guest data to the datagrid
            frmGuests.dgGuest.DataSource = guestFindTBL.Tables(0)
            'Disconnect from database
            conn.Close()
        Else

            'Error message for invalid blank entry, user can still try again - window does not close
            MessageBox.Show("Please enter a valid last name", "Invalid Entry",
            MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If


    End Sub
End Class