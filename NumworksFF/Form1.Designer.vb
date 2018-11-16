<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.flash_button = New System.Windows.Forms.Button()
        Me.BGWflash = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StaTextBox = New System.Windows.Forms.TextBox()
        Me.Process1 = New System.Diagnostics.Process()
        Me.OpenFileDialogBin = New System.Windows.Forms.OpenFileDialog()
        Me.SelectFile = New System.Windows.Forms.Button()
        Me.labelName = New System.Windows.Forms.Label()
        Me.Clabel = New System.Windows.Forms.Label()
        Me.DfuUtilTextBox = New System.Windows.Forms.TextBox()
        Me.CheckDevice = New System.Windows.Forms.Button()
        Me.UserMsgLabel = New System.Windows.Forms.Label()
        Me.CalcStateLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ClearTemp = New System.Windows.Forms.CheckBox()
        Me.FwNameLabel = New System.Windows.Forms.Label()
        Me.DeviceModePictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DriverInstallButton = New System.Windows.Forms.Button()
        Me.BGWdriverInstall = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeviceModePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flash_button
        '
        Me.flash_button.Location = New System.Drawing.Point(180, 144)
        Me.flash_button.Name = "flash_button"
        Me.flash_button.Size = New System.Drawing.Size(135, 23)
        Me.flash_button.TabIndex = 2
        Me.flash_button.Text = "Flasher"
        Me.flash_button.UseVisualStyleBackColor = True
        '
        'BGWflash
        '
        Me.BGWflash.WorkerReportsProgress = True
        Me.BGWflash.WorkerSupportsCancellation = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'StaTextBox
        '
        Me.StaTextBox.Location = New System.Drawing.Point(12, 173)
        Me.StaTextBox.Multiline = True
        Me.StaTextBox.Name = "StaTextBox"
        Me.StaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.StaTextBox.ShortcutsEnabled = False
        Me.StaTextBox.Size = New System.Drawing.Size(470, 134)
        Me.StaTextBox.TabIndex = 2
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'OpenFileDialogBin
        '
        Me.OpenFileDialogBin.FileName = "OpenFileDialog1"
        Me.OpenFileDialogBin.Title = "Ouvrir un fichier binaire à flasher"
        '
        'SelectFile
        '
        Me.SelectFile.Location = New System.Drawing.Point(12, 144)
        Me.SelectFile.Name = "SelectFile"
        Me.SelectFile.Size = New System.Drawing.Size(135, 23)
        Me.SelectFile.TabIndex = 1
        Me.SelectFile.Text = "Ouvrir un firmware"
        Me.SelectFile.UseVisualStyleBackColor = True
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelName.Location = New System.Drawing.Point(95, 4)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(252, 24)
        Me.labelName.TabIndex = 4
        Me.labelName.Text = "Numworks Firmware Flasher"
        '
        'Clabel
        '
        Me.Clabel.AutoSize = True
        Me.Clabel.Location = New System.Drawing.Point(12, 351)
        Me.Clabel.Name = "Clabel"
        Me.Clabel.Size = New System.Drawing.Size(113, 13)
        Me.Clabel.TabIndex = 4
        Me.Clabel.Text = "v__ par Turion 64 Guy"
        '
        'DfuUtilTextBox
        '
        Me.DfuUtilTextBox.Location = New System.Drawing.Point(12, 313)
        Me.DfuUtilTextBox.Multiline = True
        Me.DfuUtilTextBox.Name = "DfuUtilTextBox"
        Me.DfuUtilTextBox.ReadOnly = True
        Me.DfuUtilTextBox.ShortcutsEnabled = False
        Me.DfuUtilTextBox.Size = New System.Drawing.Size(470, 30)
        Me.DfuUtilTextBox.TabIndex = 6
        '
        'CheckDevice
        '
        Me.CheckDevice.Location = New System.Drawing.Point(347, 144)
        Me.CheckDevice.Name = "CheckDevice"
        Me.CheckDevice.Size = New System.Drawing.Size(135, 23)
        Me.CheckDevice.TabIndex = 3
        Me.CheckDevice.Text = "Vérifier état calculatrice"
        Me.CheckDevice.UseVisualStyleBackColor = True
        '
        'UserMsgLabel
        '
        Me.UserMsgLabel.AutoSize = True
        Me.UserMsgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserMsgLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserMsgLabel.Location = New System.Drawing.Point(13, 69)
        Me.UserMsgLabel.Name = "UserMsgLabel"
        Me.UserMsgLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UserMsgLabel.Size = New System.Drawing.Size(0, 24)
        Me.UserMsgLabel.TabIndex = 8
        '
        'CalcStateLabel
        '
        Me.CalcStateLabel.AutoSize = True
        Me.CalcStateLabel.Location = New System.Drawing.Point(83, 56)
        Me.CalcStateLabel.Name = "CalcStateLabel"
        Me.CalcStateLabel.Size = New System.Drawing.Size(88, 13)
        Me.CalcStateLabel.TabIndex = 9
        Me.CalcStateLabel.Text = "état calculatrice :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NumworksFF.My.Resources.Resources.numworksfirmwareflasher_logo1
        Me.PictureBox1.InitialImage = Global.NumworksFF.My.Resources.Resources.numworksfirmwareflasher_logo1
        Me.PictureBox1.Location = New System.Drawing.Point(412, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 69)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'ClearTemp
        '
        Me.ClearTemp.AutoSize = True
        Me.ClearTemp.Location = New System.Drawing.Point(268, 349)
        Me.ClearTemp.Name = "ClearTemp"
        Me.ClearTemp.Size = New System.Drawing.Size(214, 17)
        Me.ClearTemp.TabIndex = 6
        Me.ClearTemp.Text = "Supprimer dossier temporaire en quittant"
        Me.ClearTemp.UseVisualStyleBackColor = True
        '
        'FwNameLabel
        '
        Me.FwNameLabel.AutoSize = True
        Me.FwNameLabel.Location = New System.Drawing.Point(30, 124)
        Me.FwNameLabel.Name = "FwNameLabel"
        Me.FwNameLabel.Size = New System.Drawing.Size(25, 13)
        Me.FwNameLabel.TabIndex = 12
        Me.FwNameLabel.Text = "      "
        '
        'DeviceModePictureBox
        '
        Me.DeviceModePictureBox.ErrorImage = Nothing
        Me.DeviceModePictureBox.Image = Global.NumworksFF.My.Resources.Resources.numwork_base
        Me.DeviceModePictureBox.InitialImage = Global.NumworksFF.My.Resources.Resources.numwork_base
        Me.DeviceModePictureBox.Location = New System.Drawing.Point(8, 11)
        Me.DeviceModePictureBox.Name = "DeviceModePictureBox"
        Me.DeviceModePictureBox.Size = New System.Drawing.Size(69, 69)
        Me.DeviceModePictureBox.TabIndex = 13
        Me.DeviceModePictureBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DeviceModePictureBox)
        Me.Panel1.Controls.Add(Me.CalcStateLabel)
        Me.Panel1.Location = New System.Drawing.Point(12, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 83)
        Me.Panel1.TabIndex = 14
        '
        'DriverInstallButton
        '
        Me.DriverInstallButton.Location = New System.Drawing.Point(176, 348)
        Me.DriverInstallButton.Name = "DriverInstallButton"
        Me.DriverInstallButton.Size = New System.Drawing.Size(84, 19)
        Me.DriverInstallButton.TabIndex = 5
        Me.DriverInstallButton.Text = "Installer driver"
        Me.DriverInstallButton.UseVisualStyleBackColor = True
        '
        'BGWdriverInstall
        '
        Me.BGWdriverInstall.WorkerReportsProgress = True
        Me.BGWdriverInstall.WorkerSupportsCancellation = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 370)
        Me.Controls.Add(Me.DriverInstallButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FwNameLabel)
        Me.Controls.Add(Me.ClearTemp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UserMsgLabel)
        Me.Controls.Add(Me.CheckDevice)
        Me.Controls.Add(Me.DfuUtilTextBox)
        Me.Controls.Add(Me.Clabel)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.SelectFile)
        Me.Controls.Add(Me.StaTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.flash_button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Numwoks Firmware Flasher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeviceModePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents flash_button As System.Windows.Forms.Button
    Friend WithEvents BGWflash As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents OpenFileDialogBin As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SelectFile As System.Windows.Forms.Button
    Friend WithEvents labelName As System.Windows.Forms.Label
    Friend WithEvents Clabel As System.Windows.Forms.Label
    Friend WithEvents DfuUtilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckDevice As System.Windows.Forms.Button
    Friend WithEvents UserMsgLabel As System.Windows.Forms.Label
    Friend WithEvents CalcStateLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ClearTemp As System.Windows.Forms.CheckBox
    Friend WithEvents FwNameLabel As System.Windows.Forms.Label
    Friend WithEvents DeviceModePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DriverInstallButton As System.Windows.Forms.Button
    Friend WithEvents BGWdriverInstall As System.ComponentModel.BackgroundWorker

End Class
