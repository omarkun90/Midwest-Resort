<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRoomTypeEnter
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
        Me.lblToContReser = New System.Windows.Forms.Label()
        Me.txtFindRoomType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdEnterRoomType = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblToContReser
        '
        Me.lblToContReser.Location = New System.Drawing.Point(132, 41)
        Me.lblToContReser.Name = "lblToContReser"
        Me.lblToContReser.Size = New System.Drawing.Size(137, 43)
        Me.lblToContReser.TabIndex = 0
        Me.lblToContReser.Text = "To Continue"
        '
        'txtFindRoomType
        '
        Me.txtFindRoomType.Location = New System.Drawing.Point(71, 74)
        Me.txtFindRoomType.Name = "txtFindRoomType"
        Me.txtFindRoomType.Size = New System.Drawing.Size(187, 20)
        Me.txtFindRoomType.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please enter a roomtype"
        '
        'cmdEnterRoomType
        '
        Me.cmdEnterRoomType.Location = New System.Drawing.Point(121, 118)
        Me.cmdEnterRoomType.Name = "cmdEnterRoomType"
        Me.cmdEnterRoomType.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnterRoomType.TabIndex = 3
        Me.cmdEnterRoomType.Text = "Enter"
        Me.cmdEnterRoomType.UseVisualStyleBackColor = True
        '
        'frmRoomTypeEnter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(320, 180)
        Me.Controls.Add(Me.cmdEnterRoomType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFindRoomType)
        Me.Controls.Add(Me.lblToContReser)
        Me.Name = "frmRoomTypeEnter"
        Me.Text = "Enter Room Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblToContReser As Label
    Friend WithEvents txtFindRoomType As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdEnterRoomType As Button
End Class
