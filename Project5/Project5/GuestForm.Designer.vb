<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGuests
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuests))
        Me.dgGuest = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdFindGuest = New System.Windows.Forms.Button()
        Me.btnCloseGuestWin = New System.Windows.Forms.Button()
        Me.lblFindGuest = New System.Windows.Forms.Label()
        CType(Me.dgGuest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgGuest
        '
        Me.dgGuest.AllowUserToAddRows = False
        Me.dgGuest.AllowUserToDeleteRows = False
        Me.dgGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGuest.Location = New System.Drawing.Point(96, 336)
        Me.dgGuest.Name = "dgGuest"
        Me.dgGuest.ReadOnly = True
        Me.dgGuest.Size = New System.Drawing.Size(1087, 223)
        Me.dgGuest.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(267, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(786, 295)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'cmdFindGuest
        '
        Me.cmdFindGuest.Location = New System.Drawing.Point(508, 604)
        Me.cmdFindGuest.Name = "cmdFindGuest"
        Me.cmdFindGuest.Size = New System.Drawing.Size(198, 23)
        Me.cmdFindGuest.TabIndex = 2
        Me.cmdFindGuest.Text = "Find Guest"
        Me.cmdFindGuest.UseVisualStyleBackColor = True
        '
        'btnCloseGuestWin
        '
        Me.btnCloseGuestWin.Location = New System.Drawing.Point(541, 664)
        Me.btnCloseGuestWin.Name = "btnCloseGuestWin"
        Me.btnCloseGuestWin.Size = New System.Drawing.Size(131, 23)
        Me.btnCloseGuestWin.TabIndex = 4
        Me.btnCloseGuestWin.Text = "Close Window"
        Me.btnCloseGuestWin.UseVisualStyleBackColor = True
        '
        'lblFindGuest
        '
        Me.lblFindGuest.AutoSize = True
        Me.lblFindGuest.Location = New System.Drawing.Point(505, 588)
        Me.lblFindGuest.Name = "lblFindGuest"
        Me.lblFindGuest.Size = New System.Drawing.Size(213, 13)
        Me.lblFindGuest.TabIndex = 5
        Me.lblFindGuest.Text = "To find and view specific guest, click below"
        '
        'frmGuests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1317, 699)
        Me.Controls.Add(Me.lblFindGuest)
        Me.Controls.Add(Me.btnCloseGuestWin)
        Me.Controls.Add(Me.cmdFindGuest)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgGuest)
        Me.Name = "frmGuests"
        Me.Text = "GUESTS"
        CType(Me.dgGuest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgGuest As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdFindGuest As Button
    Friend WithEvents btnCloseGuestWin As Button
    Friend WithEvents lblFindGuest As Label
End Class
