﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.tvwArtister = New System.Windows.Forms.TreeView()
        Me.pnlKnappar = New System.Windows.Forms.Panel()
        Me.btnRedigeraArtist = New System.Windows.Forms.Button()
        Me.btnNyLat = New System.Windows.Forms.Button()
        Me.btnNyttAlbum = New System.Windows.Forms.Button()
        Me.btnNyArtist = New System.Windows.Forms.Button()
        Me.lblNodTag = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdDetalj = New System.Windows.Forms.DataGridView()
        Me.pnlKnappar.SuspendLayout()
        CType(Me.grdDetalj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tvwArtister
        '
        Me.tvwArtister.Dock = System.Windows.Forms.DockStyle.Left
        Me.tvwArtister.Location = New System.Drawing.Point(0, 0)
        Me.tvwArtister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tvwArtister.Name = "tvwArtister"
        Me.tvwArtister.Size = New System.Drawing.Size(196, 369)
        Me.tvwArtister.TabIndex = 0
        '
        'pnlKnappar
        '
        Me.pnlKnappar.Controls.Add(Me.btnRedigeraArtist)
        Me.pnlKnappar.Controls.Add(Me.btnNyLat)
        Me.pnlKnappar.Controls.Add(Me.btnNyttAlbum)
        Me.pnlKnappar.Controls.Add(Me.btnNyArtist)
        Me.pnlKnappar.Controls.Add(Me.lblNodTag)
        Me.pnlKnappar.Controls.Add(Me.Label1)
        Me.pnlKnappar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlKnappar.Location = New System.Drawing.Point(196, 282)
        Me.pnlKnappar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlKnappar.Name = "pnlKnappar"
        Me.pnlKnappar.Size = New System.Drawing.Size(507, 87)
        Me.pnlKnappar.TabIndex = 3
        '
        'btnRedigeraArtist
        '
        Me.btnRedigeraArtist.Location = New System.Drawing.Point(159, 52)
        Me.btnRedigeraArtist.Name = "btnRedigeraArtist"
        Me.btnRedigeraArtist.Size = New System.Drawing.Size(94, 23)
        Me.btnRedigeraArtist.TabIndex = 8
        Me.btnRedigeraArtist.Text = "Ändra Aktivitet"
        Me.btnRedigeraArtist.UseVisualStyleBackColor = True
        '
        'btnNyLat
        '
        Me.btnNyLat.Enabled = False
        Me.btnNyLat.Location = New System.Drawing.Point(21, 52)
        Me.btnNyLat.Name = "btnNyLat"
        Me.btnNyLat.Size = New System.Drawing.Size(117, 23)
        Me.btnNyLat.TabIndex = 7
        Me.btnNyLat.Text = "Ändra Anteckning"
        Me.btnNyLat.UseVisualStyleBackColor = True
        '
        'btnNyttAlbum
        '
        Me.btnNyttAlbum.Location = New System.Drawing.Point(21, 15)
        Me.btnNyttAlbum.Name = "btnNyttAlbum"
        Me.btnNyttAlbum.Size = New System.Drawing.Size(117, 23)
        Me.btnNyttAlbum.TabIndex = 6
        Me.btnNyttAlbum.Text = "Ny anteckning"
        Me.btnNyttAlbum.UseVisualStyleBackColor = True
        '
        'btnNyArtist
        '
        Me.btnNyArtist.Location = New System.Drawing.Point(159, 15)
        Me.btnNyArtist.Name = "btnNyArtist"
        Me.btnNyArtist.Size = New System.Drawing.Size(94, 23)
        Me.btnNyArtist.TabIndex = 5
        Me.btnNyArtist.Text = "Ny Aktivitet"
        Me.btnNyArtist.UseVisualStyleBackColor = True
        '
        'lblNodTag
        '
        Me.lblNodTag.AutoSize = True
        Me.lblNodTag.Location = New System.Drawing.Point(431, 8)
        Me.lblNodTag.Name = "lblNodTag"
        Me.lblNodTag.Size = New System.Drawing.Size(61, 15)
        Me.lblNodTag.TabIndex = 4
        Me.lblNodTag.Text = "lblNodTag"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(348, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nodens tag:"
        '
        'grdDetalj
        '
        Me.grdDetalj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalj.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetalj.Location = New System.Drawing.Point(196, 0)
        Me.grdDetalj.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grdDetalj.Name = "grdDetalj"
        Me.grdDetalj.RowHeadersWidth = 51
        Me.grdDetalj.RowTemplate.Height = 29
        Me.grdDetalj.Size = New System.Drawing.Size(507, 282)
        Me.grdDetalj.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 369)
        Me.Controls.Add(Me.grdDetalj)
        Me.Controls.Add(Me.pnlKnappar)
        Me.Controls.Add(Me.tvwArtister)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlKnappar.ResumeLayout(False)
        Me.pnlKnappar.PerformLayout()
        CType(Me.grdDetalj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvwArtister As TreeView
    Friend WithEvents pnlKnappar As Panel
    Friend WithEvents lblNodTag As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grdDetalj As DataGridView
    Friend WithEvents btnNyArtist As Button
    Friend WithEvents btnNyttAlbum As Button
    Friend WithEvents btnNyLat As Button
    Friend WithEvents btnRedigeraArtist As Button
End Class
