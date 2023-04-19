<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmartHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSmartHome))
        Me.picSmartHome = New System.Windows.Forms.PictureBox()
        Me.lblSmartHome = New System.Windows.Forms.Label()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.lblSavingsMonthly = New System.Windows.Forms.Label()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.lblSavingsAverage = New System.Windows.Forms.Label()
        Me.lblSavingsBest = New System.Windows.Forms.Label()
        CType(Me.picSmartHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSmartHome
        '
        Me.picSmartHome.Image = CType(resources.GetObject("picSmartHome.Image"), System.Drawing.Image)
        Me.picSmartHome.Location = New System.Drawing.Point(-1, -1)
        Me.picSmartHome.Name = "picSmartHome"
        Me.picSmartHome.Size = New System.Drawing.Size(392, 384)
        Me.picSmartHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmartHome.TabIndex = 0
        Me.picSmartHome.TabStop = False
        '
        'lblSmartHome
        '
        Me.lblSmartHome.Font = New System.Drawing.Font("Elephant", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmartHome.Location = New System.Drawing.Point(397, 74)
        Me.lblSmartHome.Name = "lblSmartHome"
        Me.lblSmartHome.Size = New System.Drawing.Size(369, 94)
        Me.lblSmartHome.TabIndex = 1
        Me.lblSmartHome.Text = "Smart Home Electric Savings"
        Me.lblSmartHome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboMonths
        '
        Me.cboMonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(521, 185)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(121, 28)
        Me.cboMonths.TabIndex = 2
        '
        'lblSavingsMonthly
        '
        Me.lblSavingsMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavingsMonthly.Location = New System.Drawing.Point(53, 460)
        Me.lblSavingsMonthly.Name = "lblSavingsMonthly"
        Me.lblSavingsMonthly.Size = New System.Drawing.Size(681, 38)
        Me.lblSavingsMonthly.TabIndex = 3
        Me.lblSavingsMonthly.Text = "lblSavingsMonthly"
        Me.lblSavingsMonthly.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnStats
        '
        Me.btnStats.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStats.ForeColor = System.Drawing.SystemColors.Window
        Me.btnStats.Location = New System.Drawing.Point(242, 533)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(300, 50)
        Me.btnStats.TabIndex = 4
        Me.btnStats.Text = "Display Statistics"
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'lblSavingsAverage
        '
        Me.lblSavingsAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavingsAverage.Location = New System.Drawing.Point(58, 609)
        Me.lblSavingsAverage.Name = "lblSavingsAverage"
        Me.lblSavingsAverage.Size = New System.Drawing.Size(676, 32)
        Me.lblSavingsAverage.TabIndex = 5
        Me.lblSavingsAverage.Text = "lblSavingsAverage"
        Me.lblSavingsAverage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSavingsBest
        '
        Me.lblSavingsBest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavingsBest.Location = New System.Drawing.Point(58, 664)
        Me.lblSavingsBest.Name = "lblSavingsBest"
        Me.lblSavingsBest.Size = New System.Drawing.Size(676, 26)
        Me.lblSavingsBest.TabIndex = 6
        Me.lblSavingsBest.Text = "lblSavingsBest"
        Me.lblSavingsBest.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmSmartHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(778, 744)
        Me.Controls.Add(Me.lblSavingsBest)
        Me.Controls.Add(Me.lblSavingsAverage)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.lblSavingsMonthly)
        Me.Controls.Add(Me.cboMonths)
        Me.Controls.Add(Me.lblSmartHome)
        Me.Controls.Add(Me.picSmartHome)
        Me.Name = "frmSmartHome"
        Me.Text = "Smart Home Application"
        CType(Me.picSmartHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picSmartHome As PictureBox
    Friend WithEvents lblSmartHome As Label
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents lblSavingsMonthly As Label
    Friend WithEvents btnStats As Button
    Friend WithEvents lblSavingsAverage As Label
    Friend WithEvents lblSavingsBest As Label
End Class
