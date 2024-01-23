<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frndashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frndashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssusername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssrole = New System.Windows.Forms.ToolStripStatusLabel()
        Me.POSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MToolStripMenuItem, Me.TransactionsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(980, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MToolStripMenuItem
        '
        Me.MToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.MToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MToolStripMenuItem.Name = "MToolStripMenuItem"
        Me.MToolStripMenuItem.Size = New System.Drawing.Size(62, 21)
        Me.MToolStripMenuItem.Text = "Manage"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.POSToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(95, 21)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(67, 21)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.LogOutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(70, 21)
        Me.LogOutToolStripMenuItem.Text = "Log-Out"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tssusername, Me.ToolStripStatusLabel3, Me.tssrole})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 485)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(980, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(110, 17)
        Me.ToolStripStatusLabel1.Text = "Employee Name:"
        '
        'tssusername
        '
        Me.tssusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.tssusername.Name = "tssusername"
        Me.tssusername.Size = New System.Drawing.Size(119, 17)
        Me.tssusername.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(60, 17)
        Me.ToolStripStatusLabel3.Text = "Position:"
        '
        'tssrole
        '
        Me.tssrole.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.tssrole.Name = "tssrole"
        Me.tssrole.Size = New System.Drawing.Size(119, 17)
        Me.tssrole.Text = "ToolStripStatusLabel4"
        '
        'POSToolStripMenuItem
        '
        Me.POSToolStripMenuItem.Name = "POSToolStripMenuItem"
        Me.POSToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.POSToolStripMenuItem.Text = "POS"
        '
        'frndashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(980, 507)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frndashboard"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frndashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tssusername As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents tssrole As ToolStripStatusLabel
    Friend WithEvents POSToolStripMenuItem As ToolStripMenuItem
End Class
