<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNyArtist
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
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.btnAngra = New System.Windows.Forms.Button()
        Me.lblArtistid = New System.Windows.Forms.Label()
        Me.btnRadera = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(152, 75)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(100, 23)
        Me.txtArtist.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Artist"
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(80, 155)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(77, 38)
        Me.btnSpara.TabIndex = 2
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'btnAngra
        '
        Me.btnAngra.Location = New System.Drawing.Point(163, 155)
        Me.btnAngra.Name = "btnAngra"
        Me.btnAngra.Size = New System.Drawing.Size(77, 38)
        Me.btnAngra.TabIndex = 3
        Me.btnAngra.Text = "Ångra"
        Me.btnAngra.UseVisualStyleBackColor = True
        '
        'lblArtistid
        '
        Me.lblArtistid.AutoSize = True
        Me.lblArtistid.Location = New System.Drawing.Point(152, 32)
        Me.lblArtistid.Name = "lblArtistid"
        Me.lblArtistid.Size = New System.Drawing.Size(48, 15)
        Me.lblArtistid.TabIndex = 4
        Me.lblArtistid.Text = "lblArtist"
        '
        'btnRadera
        '
        Me.btnRadera.Location = New System.Drawing.Point(246, 155)
        Me.btnRadera.Name = "btnRadera"
        Me.btnRadera.Size = New System.Drawing.Size(77, 38)
        Me.btnRadera.TabIndex = 5
        Me.btnRadera.Text = "Radera"
        Me.btnRadera.UseVisualStyleBackColor = True
        '
        'frmNyArtist
        '
        Me.AcceptButton = Me.btnSpara
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAngra
        Me.ClientSize = New System.Drawing.Size(383, 244)
        Me.Controls.Add(Me.btnRadera)
        Me.Controls.Add(Me.lblArtistid)
        Me.Controls.Add(Me.btnAngra)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtArtist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNyArtist"
        Me.Text = "Ny Artist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtArtist As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSpara As Button
    Friend WithEvents btnAngra As Button
    Friend WithEvents lblArtistid As Label
    Friend WithEvents btnRadera As Button
End Class
