<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btnNyAktivitet = New System.Windows.Forms.Button()
        Me.lblNodTag = New System.Windows.Forms.Label()
        Me.lsvAnteckning = New System.Windows.Forms.ListView()
        Me.ColAnteckningar = New System.Windows.Forms.ColumnHeader()
        Me.grdDetalj = New System.Windows.Forms.DataGridView()
        Me.btnNyAnteckning = New System.Windows.Forms.Button()
        Me.btnÄndraAktivitet = New System.Windows.Forms.Button()
        Me.btnÄndraAnteckning = New System.Windows.Forms.Button()
        CType(Me.grdDetalj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNyAktivitet
        '
        Me.btnNyAktivitet.Location = New System.Drawing.Point(250, 377)
        Me.btnNyAktivitet.Name = "btnNyAktivitet"
        Me.btnNyAktivitet.Size = New System.Drawing.Size(92, 33)
        Me.btnNyAktivitet.TabIndex = 2
        Me.btnNyAktivitet.Text = "Ny Aktivitet"
        Me.btnNyAktivitet.UseVisualStyleBackColor = True
        '
        'lblNodTag
        '
        Me.lblNodTag.AutoSize = True
        Me.lblNodTag.Location = New System.Drawing.Point(693, 386)
        Me.lblNodTag.Name = "lblNodTag"
        Me.lblNodTag.Size = New System.Drawing.Size(61, 15)
        Me.lblNodTag.TabIndex = 3
        Me.lblNodTag.Text = "lblNodTag"
        '
        'lsvAnteckning
        '
        Me.lsvAnteckning.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.lsvAnteckning.AutoArrange = False
        Me.lsvAnteckning.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColAnteckningar})
        Me.lsvAnteckning.Location = New System.Drawing.Point(-2, -1)
        Me.lsvAnteckning.Name = "lsvAnteckning"
        Me.lsvAnteckning.Size = New System.Drawing.Size(196, 372)
        Me.lsvAnteckning.TabIndex = 5
        Me.lsvAnteckning.UseCompatibleStateImageBehavior = False
        Me.lsvAnteckning.View = System.Windows.Forms.View.Details
        '
        'ColAnteckningar
        '
        Me.ColAnteckningar.Text = "Anteckningar"
        Me.ColAnteckningar.Width = 150
        '
        'grdDetalj
        '
        Me.grdDetalj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalj.Location = New System.Drawing.Point(200, -1)
        Me.grdDetalj.Name = "grdDetalj"
        Me.grdDetalj.RowTemplate.Height = 25
        Me.grdDetalj.Size = New System.Drawing.Size(601, 372)
        Me.grdDetalj.TabIndex = 6
        '
        'btnNyAnteckning
        '
        Me.btnNyAnteckning.Location = New System.Drawing.Point(362, 377)
        Me.btnNyAnteckning.Name = "btnNyAnteckning"
        Me.btnNyAnteckning.Size = New System.Drawing.Size(103, 32)
        Me.btnNyAnteckning.TabIndex = 7
        Me.btnNyAnteckning.Text = "Ny Anteckning"
        Me.btnNyAnteckning.UseVisualStyleBackColor = True
        '
        'btnÄndraAktivitet
        '
        Me.btnÄndraAktivitet.Location = New System.Drawing.Point(127, 378)
        Me.btnÄndraAktivitet.Name = "btnÄndraAktivitet"
        Me.btnÄndraAktivitet.Size = New System.Drawing.Size(117, 33)
        Me.btnÄndraAktivitet.TabIndex = 8
        Me.btnÄndraAktivitet.Text = "Ändra Aktivitet"
        Me.btnÄndraAktivitet.UseVisualStyleBackColor = True
        '
        'btnÄndraAnteckning
        '
        Me.btnÄndraAnteckning.Location = New System.Drawing.Point(471, 376)
        Me.btnÄndraAnteckning.Name = "btnÄndraAnteckning"
        Me.btnÄndraAnteckning.Size = New System.Drawing.Size(117, 33)
        Me.btnÄndraAnteckning.TabIndex = 9
        Me.btnÄndraAnteckning.Text = "Ändra Anteckning"
        Me.btnÄndraAnteckning.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnÄndraAnteckning)
        Me.Controls.Add(Me.btnÄndraAktivitet)
        Me.Controls.Add(Me.btnNyAnteckning)
        Me.Controls.Add(Me.grdDetalj)
        Me.Controls.Add(Me.lsvAnteckning)
        Me.Controls.Add(Me.lblNodTag)
        Me.Controls.Add(Me.btnNyAktivitet)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grdDetalj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNyAktivitet As Button
    Friend WithEvents lblNodTag As Label
    Friend WithEvents lsvAnteckning As ListView
    Friend WithEvents grdDetalj As DataGridView
    Friend WithEvents ColAnteckningar As ColumnHeader
    Friend WithEvents btnNyAnteckning As Button
    Friend WithEvents btnÄndraAktivitet As Button
    Friend WithEvents btnÄndraAnteckning As Button
End Class
