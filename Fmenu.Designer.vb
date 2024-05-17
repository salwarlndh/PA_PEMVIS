<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CreateDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataWahanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPaketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDetailPaketToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPengunjungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PrintTiket = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintPengunjung = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.5!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateDataToolStripMenuItem, Me.DataToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(466, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CreateDataToolStripMenuItem
        '
        Me.CreateDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataWahanaToolStripMenuItem, Me.DataPaketToolStripMenuItem, Me.DataDetailPaketToolStripMenuItem1})
        Me.CreateDataToolStripMenuItem.Name = "CreateDataToolStripMenuItem"
        Me.CreateDataToolStripMenuItem.Size = New System.Drawing.Size(95, 21)
        Me.CreateDataToolStripMenuItem.Text = "Input Data"
        '
        'DataWahanaToolStripMenuItem
        '
        Me.DataWahanaToolStripMenuItem.Name = "DataWahanaToolStripMenuItem"
        Me.DataWahanaToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.DataWahanaToolStripMenuItem.Text = "Data Wahana"
        '
        'DataPaketToolStripMenuItem
        '
        Me.DataPaketToolStripMenuItem.Name = "DataPaketToolStripMenuItem"
        Me.DataPaketToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.DataPaketToolStripMenuItem.Text = "Data Paket"
        '
        'DataDetailPaketToolStripMenuItem1
        '
        Me.DataDetailPaketToolStripMenuItem1.Name = "DataDetailPaketToolStripMenuItem1"
        Me.DataDetailPaketToolStripMenuItem1.Size = New System.Drawing.Size(202, 22)
        Me.DataDetailPaketToolStripMenuItem1.Text = "Data Detail Paket"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPengunjungToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(157, 21)
        Me.DataToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'DataPengunjungToolStripMenuItem
        '
        Me.DataPengunjungToolStripMenuItem.Name = "DataPengunjungToolStripMenuItem"
        Me.DataPengunjungToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.DataPengunjungToolStripMenuItem.Text = "Data Pengunjung"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(118, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 199)
        Me.Panel1.TabIndex = 1
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintPengunjung
        '
        '
        'FMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(466, 403)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FMenu"
        Me.Text = "Fmenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPengunjungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Homepage.Show()
        Me.Hide()
    End Sub
    Friend WithEvents CreateDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private Sub CreateDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateDataToolStripMenuItem.Click

    End Sub
    Friend WithEvents DataWahanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private Sub DataWahanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataWahanaToolStripMenuItem.Click
        DataWahana.Show()
    End Sub
    Friend WithEvents PrintTiket As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintPengunjung As System.Drawing.Printing.PrintDocument
    Friend WithEvents DataPaketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataDetailPaketToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem


End Class
