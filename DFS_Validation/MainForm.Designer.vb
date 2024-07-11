<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDirect
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GBSpecControl = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LMeasReceiver = New System.Windows.Forms.Label()
        Me.LPort = New System.Windows.Forms.Label()
        Me.LIP = New System.Windows.Forms.Label()
        Me.TextIP = New System.Windows.Forms.TextBox()
        Me.TextPort = New System.Windows.Forms.TextBox()
        Me.BConnect = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TS_ETH_TX = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSrtxstat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLSeparator = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Statusbarcon = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLTTStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDemoDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.timerScanning = New System.Windows.Forms.Timer(Me.components)
        Me.LFChannel = New System.Windows.Forms.Label()
        Me.CBFChannel = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GBSpecControl.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(971, 518)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GBSpecControl)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(963, 492)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GBSpecControl
        '
        Me.GBSpecControl.Controls.Add(Me.LFChannel)
        Me.GBSpecControl.Controls.Add(Me.CBFChannel)
        Me.GBSpecControl.Location = New System.Drawing.Point(354, 6)
        Me.GBSpecControl.Name = "GBSpecControl"
        Me.GBSpecControl.Size = New System.Drawing.Size(601, 376)
        Me.GBSpecControl.TabIndex = 26
        Me.GBSpecControl.TabStop = False
        Me.GBSpecControl.Text = "Spectrum Control"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LMeasReceiver)
        Me.GroupBox1.Controls.Add(Me.LPort)
        Me.GroupBox1.Controls.Add(Me.LIP)
        Me.GroupBox1.Controls.Add(Me.TextIP)
        Me.GroupBox1.Controls.Add(Me.TextPort)
        Me.GroupBox1.Controls.Add(Me.BConnect)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection Setting"
        '
        'LMeasReceiver
        '
        Me.LMeasReceiver.AutoSize = True
        Me.LMeasReceiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMeasReceiver.Location = New System.Drawing.Point(9, 26)
        Me.LMeasReceiver.Name = "LMeasReceiver"
        Me.LMeasReceiver.Size = New System.Drawing.Size(112, 13)
        Me.LMeasReceiver.TabIndex = 32
        Me.LMeasReceiver.Text = "Spectrum Analyzer"
        '
        'LPort
        '
        Me.LPort.AutoSize = True
        Me.LPort.Location = New System.Drawing.Point(122, 54)
        Me.LPort.Name = "LPort"
        Me.LPort.Size = New System.Drawing.Size(26, 13)
        Me.LPort.TabIndex = 31
        Me.LPort.Text = "Port"
        '
        'LIP
        '
        Me.LIP.AutoSize = True
        Me.LIP.Location = New System.Drawing.Point(122, 27)
        Me.LIP.Name = "LIP"
        Me.LIP.Size = New System.Drawing.Size(17, 13)
        Me.LIP.TabIndex = 30
        Me.LIP.Text = "IP"
        '
        'TextIP
        '
        Me.TextIP.Location = New System.Drawing.Point(153, 25)
        Me.TextIP.Name = "TextIP"
        Me.TextIP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextIP.Size = New System.Drawing.Size(90, 20)
        Me.TextIP.TabIndex = 29
        Me.TextIP.Text = "192.168.10.100"
        '
        'TextPort
        '
        Me.TextPort.Location = New System.Drawing.Point(153, 51)
        Me.TextPort.Name = "TextPort"
        Me.TextPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextPort.Size = New System.Drawing.Size(90, 20)
        Me.TextPort.TabIndex = 28
        Me.TextPort.Text = "5555"
        '
        'BConnect
        '
        Me.BConnect.Location = New System.Drawing.Point(249, 26)
        Me.BConnect.Name = "BConnect"
        Me.BConnect.Size = New System.Drawing.Size(79, 40)
        Me.BConnect.TabIndex = 27
        Me.BConnect.Text = "Connect SPA"
        Me.BConnect.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(963, 492)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AllowItemReorder = True
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_ETH_TX, Me.TSrtxstat, Me.TSSLSeparator, Me.Statusbarcon, Me.ToolStripStatusLabel4, Me.TSSLTTStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 548)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(971, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TS_ETH_TX
        '
        Me.TS_ETH_TX.Name = "TS_ETH_TX"
        Me.TS_ETH_TX.Size = New System.Drawing.Size(93, 17)
        Me.TS_ETH_TX.Text = "Send Command"
        '
        'TSrtxstat
        '
        Me.TSrtxstat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TSrtxstat.Name = "TSrtxstat"
        Me.TSrtxstat.Size = New System.Drawing.Size(134, 17)
        Me.TSrtxstat.Text = "SPA Link Status: Waiting"
        '
        'TSSLSeparator
        '
        Me.TSSLSeparator.Name = "TSSLSeparator"
        Me.TSSLSeparator.Size = New System.Drawing.Size(10, 17)
        Me.TSSLSeparator.Text = "|"
        '
        'Statusbarcon
        '
        Me.Statusbarcon.Name = "Statusbarcon"
        Me.Statusbarcon.Size = New System.Drawing.Size(79, 17)
        Me.Statusbarcon.Text = "Disconnected"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 17)
        '
        'TSSLTTStatus
        '
        Me.TSSLTTStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSSLTTStatus.Name = "TSSLTTStatus"
        Me.TSSLTTStatus.Size = New System.Drawing.Size(151, 17)
        Me.TSSLTTStatus.Text = "                                                "
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.ToolsToolStripMenuItem, Me.TSMAbout})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(971, 24)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveSettingToolStripMenuItem, Me.ExitToolStripMenuItem2})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'SaveSettingToolStripMenuItem
        '
        Me.SaveSettingToolStripMenuItem.Name = "SaveSettingToolStripMenuItem"
        Me.SaveSettingToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SaveSettingToolStripMenuItem.Text = "Save Setting"
        '
        'ExitToolStripMenuItem2
        '
        Me.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        Me.ExitToolStripMenuItem2.Size = New System.Drawing.Size(138, 22)
        Me.ExitToolStripMenuItem2.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadDemoDataToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'LoadDemoDataToolStripMenuItem
        '
        Me.LoadDemoDataToolStripMenuItem.Name = "LoadDemoDataToolStripMenuItem"
        Me.LoadDemoDataToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.LoadDemoDataToolStripMenuItem.Text = "Load Demo data"
        '
        'TSMAbout
        '
        Me.TSMAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem3})
        Me.TSMAbout.Name = "TSMAbout"
        Me.TSMAbout.Size = New System.Drawing.Size(52, 20)
        Me.TSMAbout.Text = "About"
        '
        'AboutToolStripMenuItem3
        '
        Me.AboutToolStripMenuItem3.Name = "AboutToolStripMenuItem3"
        Me.AboutToolStripMenuItem3.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem3.Text = "About"
        '
        'SaveFileDialog1
        '
        '
        'timerScanning
        '
        Me.timerScanning.Interval = 1000
        '
        'LFChannel
        '
        Me.LFChannel.AutoSize = True
        Me.LFChannel.Location = New System.Drawing.Point(7, 26)
        Me.LFChannel.Name = "LFChannel"
        Me.LFChannel.Size = New System.Drawing.Size(99, 13)
        Me.LFChannel.TabIndex = 62
        Me.LFChannel.Text = "Frequency Channel"
        '
        'CBFChannel
        '
        Me.CBFChannel.AllowDrop = True
        Me.CBFChannel.FormattingEnabled = True
        Me.CBFChannel.Items.AddRange(New Object() {"auto", "36 (5180 MHz)", "40 (5200 MHz)", "44 (5220 MHz)", "48 (5240 MHz)", "52 (5260 MHz)", "56 (5280 MHz)", "60 (5300 MHz)", "64 (5320 MHz)", "149 (5745 MHz)", "153 (5765 MHz)", "157 (5785 MHz)", "161 (5805 MHz)", "165 (5825 MHz)"})
        Me.CBFChannel.Location = New System.Drawing.Point(117, 23)
        Me.CBFChannel.Name = "CBFChannel"
        Me.CBFChannel.Size = New System.Drawing.Size(109, 21)
        Me.CBFChannel.TabIndex = 61
        '
        'FormDirect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 570)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormDirect"
        Me.Text = "Dynamic Frequency Selection Software"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GBSpecControl.ResumeLayout(False)
        Me.GBSpecControl.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LMeasReceiver As Label
    Friend WithEvents LPort As Label
    Friend WithEvents LIP As Label
    Friend WithEvents TextIP As TextBox
    Friend WithEvents TextPort As TextBox
    Friend WithEvents BConnect As Button
    Friend WithEvents GBSpecControl As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TS_ETH_TX As ToolStripStatusLabel
    Friend WithEvents TSrtxstat As ToolStripStatusLabel
    Friend WithEvents TSSLSeparator As ToolStripStatusLabel
    Friend WithEvents Statusbarcon As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents TSSLTTStatus As ToolStripStatusLabel
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveSettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadDemoDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMAbout As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents timerScanning As Timer
    Friend WithEvents LFChannel As Label
    Friend WithEvents CBFChannel As ComboBox
End Class
