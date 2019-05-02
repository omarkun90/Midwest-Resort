Imports Oracle.DataAccess.Client
Public Class BillAuthentication

    Private Sub cmdViewBill_Click(sender As Object, e As EventArgs) Handles cmdViewBill.Click

        Dim oradatabase As String = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" _
         + "(ADDRESS=(PROTOCOL=TCP)(HOST=luboradb.business.uwm.edu)(PORT=1521)))" _
         + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl.business.uwm.edu)));" _
         + "USER Id=munozro2;Password=wnmkrm9432P@;"
        ' Connect to the database
        Dim conn As New OracleConnection(oradatabase)
        conn.Open()
        'Set up the SQL Command to retrieve the data, including missing parameters
        Dim SQLCommand As String
        If txtFindGuestID.Text <> "" Then
            'SQL Command to gather required data - multiple tables used - required join statements to function
            SQLCommand = "SELECT CHARGES.GUESTID,GUEST.LASTNAME, GUEST.FIRSTNAME, CHARGES.CHARGEID,CHARGETYPE.DESCRIPTION, CHARGES.CHARGEDATETIME, CHARGES.AMOUNT
            FROM CHARGES INNER JOIN GUEST ON CHARGES.GUESTID = GUEST.GUESTID
            INNER JOIN CHARGETYPE ON CHARGES.CHARGEID = CHARGETYPE.CHARGEID WHERE GUEST.GUESTID LIKE '" + txtFindGuestID.Text + "'"
            Me.Close()
            'Show bill charges window upon obtaining data
            frmBillCharges.Show()
            'Create a data adapter to define from where to pull the data
            Dim adapter As OracleDataAdapter = New OracleDataAdapter(SQLCommand, conn)
            'Create a dataset to import the retrieved data
            Dim findChargeTBL As New DataSet()
            'Populate the dataset based on the data adapter's output
            adapter.Fill(findChargeTBL)
            'Bind/connect the charges data to the datagrid
            frmBillCharges.dgBillCharges.DataSource = findChargeTBL.Tables(0)
            'Disconnect from database
            conn.Close()
        Else

            'Error message box if user enters nothing, user can still try again for valid entry - window does not close until then
            MessageBox.Show("Please enter a valid guest ID", "Invalid Entry",
            MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If

    End Sub
End Class