<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.cmdBrowseGuest = New System.Windows.Forms.Button()
        Me.cmdBrowseReservation = New System.Windows.Forms.Button()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdBillCharges = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBrowseGuest
        '
        Me.cmdBrowseGuest.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdBrowseGuest.Image = CType(resources.GetObject("cmdBrowseGuest.Image"), System.Drawing.Image)
        Me.cmdBrowseGuest.Location = New System.Drawing.Point(340, 395)
        Me.cmdBrowseGuest.Name = "cmdBrowseGuest"
        Me.cmdBrowseGuest.Size = New System.Drawing.Size(326, 101)
        Me.cmdBrowseGuest.TabIndex = 5
        Me.cmdBrowseGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBrowseGuest.UseVisualStyleBackColor = False
        '
        'cmdBrowseReservation
        '
        Me.cmdBrowseReservation.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdBrowseReservation.Image = CType(resources.GetObject("cmdBrowseReservation.Image"), System.Drawing.Image)
        Me.cmdBrowseReservation.Location = New System.Drawing.Point(746, 395)
        Me.cmdBrowseReservation.Name = "cmdBrowseReservation"
        Me.cmdBrowseReservation.Size = New System.Drawing.Size(326, 101)
        Me.cmdBrowseReservation.TabIndex = 7
        Me.cmdBrowseReservation.UseVisualStyleBackColor = False
        '
        'cmdDone
        '
        Me.cmdDone.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cmdDone.Image = CType(resources.GetObject("cmdDone.Image"), System.Drawing.Image)
        Me.cmdDone.Location = New System.Drawing.Point(635, 668)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(156, 58)
        Me.cmdDone.TabIndex = 10
        Me.cmdDone.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(273, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(891, 285)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(434, 745)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(557, 159)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(421, 345)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 35)
        Me.Label1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(815, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 35)
        Me.Label2.TabIndex = 14
        '
        'cmdBillCharges
        '
        Me.cmdBillCharges.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdBillCharges.Image = CType(resources.GetObject("cmdBillCharges.Image"), System.Drawing.Image)
        Me.cmdBillCharges.Location = New System.Drawing.Point(555, 561)
        Me.cmdBillCharges.Name = "cmdBillCharges"
        Me.cmdBillCharges.Size = New System.Drawing.Size(326, 101)
        Me.cmdBillCharges.TabIndex = 15
        Me.cmdBillCharges.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(692, 524)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(632, 524)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 35)
        Me.Label4.TabIndex = 17
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(1190, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(102, 13)
        Me.lblName.TabIndex = 18
        Me.lblName.Text = "Omar Munoz-Rocha"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Location = New System.Drawing.Point(1190, 49)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(99, 13)
        Me.lblDateTime.TabIndex = 19
        Me.lblDateTime.Text = "4/23/2019 6:33PM"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1537, 929)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdBillCharges)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.cmdBrowseReservation)
        Me.Controls.Add(Me.cmdBrowseGuest)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmMainMenu"
        Me.Text = "Midwest Report Guest Management"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBrowseGuest As Button
    Friend WithEvents cmdBrowseReservation As Button
    Friend WithEvents cmdDone As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdBillCharges As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblDateTime As Label
End Class
