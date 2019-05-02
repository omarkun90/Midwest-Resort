<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservationForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgReservation = New System.Windows.Forms.DataGridView()
        Me.cmdFindReservation = New System.Windows.Forms.Button()
        Me.blbToFindReserv = New System.Windows.Forms.Label()
        Me.btnCloseReserv = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgReservation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(157, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(767, 239)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'dgReservation
        '
        Me.dgReservation.AllowUserToAddRows = False
        Me.dgReservation.AllowUserToDeleteRows = False
        Me.dgReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReservation.Location = New System.Drawing.Point(103, 308)
        Me.dgReservation.Name = "dgReservation"
        Me.dgReservation.ReadOnly = True
        Me.dgReservation.Size = New System.Drawing.Size(864, 211)
        Me.dgReservation.TabIndex = 1
        '
        'cmdFindReservation
        '
        Me.cmdFindReservation.Location = New System.Drawing.Point(421, 576)
        Me.cmdFindReservation.Name = "cmdFindReservation"
        Me.cmdFindReservation.Size = New System.Drawing.Size(214, 23)
        Me.cmdFindReservation.TabIndex = 2
        Me.cmdFindReservation.Text = "Find Reservation"
        Me.cmdFindReservation.UseVisualStyleBackColor = True
        '
        'blbToFindReserv
        '
        Me.blbToFindReserv.Location = New System.Drawing.Point(396, 535)
        Me.blbToFindReserv.Name = "blbToFindReserv"
        Me.blbToFindReserv.Size = New System.Drawing.Size(267, 23)
        Me.blbToFindReserv.TabIndex = 3
        Me.blbToFindReserv.Text = "To find reservation of specified room type, click below"
        '
        'btnCloseReserv
        '
        Me.btnCloseReserv.Location = New System.Drawing.Point(463, 633)
        Me.btnCloseReserv.Name = "btnCloseReserv"
        Me.btnCloseReserv.Size = New System.Drawing.Size(132, 23)
        Me.btnCloseReserv.TabIndex = 4
        Me.btnCloseReserv.Text = "Close Window"
        Me.btnCloseReserv.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(327, 550)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "These include: Single King Standard, Double Queen Strandard, King Whirlpool, King" &
    " Suite"
        '
        'frmReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1123, 668)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCloseReserv)
        Me.Controls.Add(Me.blbToFindReserv)
        Me.Controls.Add(Me.cmdFindReservation)
        Me.Controls.Add(Me.dgReservation)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmReservationForm"
        Me.Text = "Reservations"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgReservation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgReservation As DataGridView
    Friend WithEvents cmdFindReservation As Button
    Friend WithEvents blbToFindReserv As Label
    Friend WithEvents btnCloseReserv As Button
    Friend WithEvents Label1 As Label
End Class
