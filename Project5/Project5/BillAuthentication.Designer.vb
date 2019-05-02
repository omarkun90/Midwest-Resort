<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillAuthentication
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblViewBill = New System.Windows.Forms.Label()
        Me.lblViewBillEnter = New System.Windows.Forms.Label()
        Me.txtFindGuestID = New System.Windows.Forms.TextBox()
        Me.cmdViewBill = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblViewBill
        '
        Me.lblViewBill.Location = New System.Drawing.Point(197, 47)
        Me.lblViewBill.Name = "lblViewBill"
        Me.lblViewBill.Size = New System.Drawing.Size(100, 23)
        Me.lblViewBill.TabIndex = 0
        Me.lblViewBill.Text = "To View Bill"
        '
        'lblViewBillEnter
        '
        Me.lblViewBillEnter.Location = New System.Drawing.Point(164, 70)
        Me.lblViewBillEnter.Name = "lblViewBillEnter"
        Me.lblViewBillEnter.Size = New System.Drawing.Size(133, 23)
        Me.lblViewBillEnter.TabIndex = 1
        Me.lblViewBillEnter.Text = "Please enter the Guest ID"
        '
        'txtFindGuestID
        '
        Me.txtFindGuestID.Location = New System.Drawing.Point(132, 96)
        Me.txtFindGuestID.Name = "txtFindGuestID"
        Me.txtFindGuestID.Size = New System.Drawing.Size(203, 20)
        Me.txtFindGuestID.TabIndex = 2
        '
        'cmdViewBill
        '
        Me.cmdViewBill.Location = New System.Drawing.Point(200, 132)
        Me.cmdViewBill.Name = "cmdViewBill"
        Me.cmdViewBill.Size = New System.Drawing.Size(75, 23)
        Me.cmdViewBill.TabIndex = 3
        Me.cmdViewBill.Text = "Enter"
        Me.cmdViewBill.UseVisualStyleBackColor = True
        '
        'BillAuthentication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(501, 211)
        Me.Controls.Add(Me.cmdViewBill)
        Me.Controls.Add(Me.txtFindGuestID)
        Me.Controls.Add(Me.lblViewBillEnter)
        Me.Controls.Add(Me.lblViewBill)
        Me.Name = "BillAuthentication"
        Me.Text = "Bill Authentication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblViewBill As Label
    Friend WithEvents lblViewBillEnter As Label
    Friend WithEvents txtFindGuestID As TextBox
    Friend WithEvents cmdViewBill As Button
End Class
