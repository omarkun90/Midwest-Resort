<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindGuest
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
        Me.txtFindGuest = New System.Windows.Forms.TextBox()
        Me.lblPleaseEnterLast = New System.Windows.Forms.Label()
        Me.lblToFind = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFindGuest
        '
        Me.txtFindGuest.Location = New System.Drawing.Point(78, 57)
        Me.txtFindGuest.Name = "txtFindGuest"
        Me.txtFindGuest.Size = New System.Drawing.Size(180, 20)
        Me.txtFindGuest.TabIndex = 0
        '
        'lblPleaseEnterLast
        '
        Me.lblPleaseEnterLast.Location = New System.Drawing.Point(84, 31)
        Me.lblPleaseEnterLast.Name = "lblPleaseEnterLast"
        Me.lblPleaseEnterLast.Size = New System.Drawing.Size(185, 23)
        Me.lblPleaseEnterLast.TabIndex = 1
        Me.lblPleaseEnterLast.Text = "Please Enter Last Name of Guest"
        '
        'lblToFind
        '
        Me.lblToFind.Location = New System.Drawing.Point(136, 13)
        Me.lblToFind.Name = "lblToFind"
        Me.lblToFind.Size = New System.Drawing.Size(100, 18)
        Me.lblToFind.TabIndex = 2
        Me.lblToFind.Text = "To Continue"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(127, 98)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "Enter"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmFindGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(355, 161)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblToFind)
        Me.Controls.Add(Me.lblPleaseEnterLast)
        Me.Controls.Add(Me.txtFindGuest)
        Me.Name = "frmFindGuest"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFindGuest As TextBox
    Friend WithEvents lblPleaseEnterLast As Label
    Friend WithEvents lblToFind As Label
    Friend WithEvents btnOK As Button
End Class
