Imports System.IO
Public Class Form1
    Dim DfuutilExe As String
    Dim NFFver As String = "0.1b"
    Dim UserBinFile As String
    Dim TempPath As String
    Dim BinPath As String = "0"
    Dim DevicePresent As Boolean = False
    Dim DeviceMode As String
    Dim Aborted As Boolean

    Sub StatusWrite(ByVal text As String)
        StaTextBox.AppendText(text & vbNewLine)
    End Sub
    Sub StatusWriteLn(ByVal text As String)
        StaTextBox.AppendText(text)
    End Sub
    Sub ErrorWrite(ByVal text As String)
        StaTextBox.AppendText("-----------[ERR/DFU]---------" & vbNewLine & text & "---------------------------------------" & vbNewLine)
    End Sub
    Public Function ExecDfuutil()
        Process1.StartInfo.FileName = DfuutilExe
        Process1.StartInfo.WorkingDirectory = TempPath
        Process1.StartInfo.Arguments = "-i 0 -a 0 -s 0x08000000:leave -D firmware.bin"
        Process1.StartInfo.UseShellExecute = False
        Process1.StartInfo.RedirectStandardOutput = True
        Process1.StartInfo.RedirectStandardError = True
        Process1.StartInfo.CreateNoWindow = False
        Process1.StartInfo.WindowStyle = ProcessWindowStyle.Maximized


        Process1.Start()

        While Process1.Responding
            DfuUtilTextBox.AppendText(vbNewLine & Process1.StandardOutput.ReadLine)
            'StatusWrite(Process1.StandardError.ReadLine)
        End While
        ErrorWrite(Process1.StandardError.ReadToEnd)
        Process1.WaitForExit()

        Return 1
    End Function
    Public Function TestForDev()
        Dim output As String
        Process1.StartInfo.FileName = DfuutilExe
        Process1.StartInfo.WorkingDirectory = TempPath
        Process1.StartInfo.Arguments = "-l"
        Process1.StartInfo.UseShellExecute = False
        Process1.StartInfo.RedirectStandardOutput = True
        Process1.StartInfo.RedirectStandardError = True
        Process1.StartInfo.CreateNoWindow = True

        Process1.Start()

        'ErrorWrite(Process1.StandardError.ReadToEnd)
        output = Process1.StandardOutput.ReadToEnd
        DevicePresent = output.Contains("Flash")
        Label1.Text = DevicePresent

        CalcStateLabel.Text = "Calculatrice non branchée ou reconnue"
        If DevicePresent Then
            StatusWrite("Calculatrice branchée")
        End If
        If output.Contains("@Flash") Then
            DeviceMode = "ramdisk"
            StatusWrite("Calculatrice allumée")
            CalcStateLabel.Text = "Calculatrice branchée et allumée"
        ElseIf output.Contains("@Internal Flash") Then
            StatusWrite("Calculatrice en mode DFU (écran éteint)")
            CalcStateLabel.Text = "Calculatrice en mode DFU (écran éteint)"
            DeviceMode = "DFU"
        End If

        Label1.Text = DeviceMode

        Return DevicePresent
    End Function
    Public Function GotoDFU()
        Dim isok As Boolean = False
        TestForDev()
        If DeviceMode = vbNullString Then
            If MessageBox.Show("Veuillez brancher ou re-brancher la calculatrice au PC", "Info", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                Aborted = True
            End If
            isok = False
        Else
            Select Case DeviceMode
                Case "ramdisk"
                    If MessageBox.Show("Laissez la calculatrice branchée et appuyez sur le bouton RESET à l'arrière de la calculatrice", "Info", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                        Aborted = True
                    End If
                    isok = False
                Case "DFU"
                    If MessageBox.Show("Une fenêtre noire va apparaitre, veuillez ne pas la fermer, jusqu'a ce que votre calculatrice se rallume", "Info", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                        Aborted = True
                    End If
                    isok = True
            End Select
        End If

        Return isok
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StatusWrite("#### Numworks Firmware Flasher v" & NFFver)
        Clabel.Text = "v" & NFFver & " par Turion 64 Guy // 2018"
        StaTextBox.ReadOnly = True
        TempPath = My.Computer.FileSystem.SpecialDirectories.Temp & "\NumworksFF\"
        DfuutilExe = TempPath & "dfu-util.exe"
        OpenFileDialogBin.Filter = "Fichier Firware (.bin) |*.bin"
        Me.TopMost = True
        If System.Environment.Is64BitOperatingSystem Then
            StatusWrite("Windows 64bits")
        Else
            StatusWrite("Windows 32bits")
        End If

        If Not System.IO.Directory.Exists(TempPath) Then
            System.IO.Directory.CreateDirectory(TempPath)
            StatusWrite("Dossier temporaire créé")
        End If

        StatusWrite("Dossier temporaire : " & TempPath)
        Label1.Text = DfuutilExe

        Using sCreateMSIFile As New FileStream(DfuutilExe, FileMode.Create)
            sCreateMSIFile.Write(My.Resources.dfu_util, 0, My.Resources.dfu_util.Length)
            StatusWrite("dfu-util.exe copié")
        End Using
        TestForDev()

    End Sub

    Private Sub flash_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flash_button.Click
        If UserBinFile = "OpenFileDialog1" Or UserBinFile = vbNullString Then
            MessageBox.Show("Vous devez choisir un fichier")
        Else
            While Not GotoDFU()
                If Aborted Then
                    Exit While
                End If
            End While
            If Not Aborted Then
                ExecDfuutil()
                StatusWrite("Démarrage du flash, veuillez patienter")
            End If
            Aborted = False
        End If
        'StatusWrite("loli")
        'StatusWrite("loli2")
    End Sub

    Private Sub SelectFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectFile.Click
        OpenFileDialogBin.Reset()
        OpenFileDialogBin.Filter = "Fichier Firmware (.bin) |*.bin"
        'UserBinFile = "OpenFileDialog1"
        OpenFileDialogBin.ShowDialog()
        UserBinFile = OpenFileDialogBin.FileName
        BinPath = TempPath & "firmware.bin"
        Label1.Text = UserBinFile
        If UserBinFile = "OpenFileDialog1" Or UserBinFile = vbNullString Then
            MessageBox.Show("Vous devez choisir un fichier")
            FwNameLabel.Text = "Firmware séléctionné : " & "aucun"
        Else
            StatusWrite("Fichier : " & UserBinFile)
            StatusWriteLn("Copie du firmware dans le dossier temporaire...")
            If System.IO.File.Exists(BinPath) Then
                System.IO.File.Delete(BinPath)
                'StatusWriteLn("suppression...")
            End If
            System.IO.File.Copy(UserBinFile, BinPath)
            If System.IO.File.Exists(BinPath) Then
                StatusWrite("copié !")
                FwNameLabel.Text = "Firmware séléctionné : " & UserBinFile
            End If
        End If
    End Sub

    Private Sub CheckDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckDevice.Click
        TestForDev()
        If DevicePresent Then

        End If
    End Sub
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        BinPath = TempPath & "firmware.bin"
        If System.IO.File.Exists(BinPath) Then
            System.IO.File.Delete(BinPath)
        End If
        If ClearTemp.Checked Then
            If System.IO.File.Exists(DfuutilExe) Then
                System.IO.File.Delete(DfuutilExe)
            End If
            If System.IO.Directory.Exists(TempPath) Then
                System.IO.Directory.Delete(TempPath)
            End If
        End If
    End Sub

    Private Sub Clabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clabel.Click
        MessageBox.Show("Version " & NFFver & vbNewLine & "VB Master Race :)" & vbNewLine & "Utilisant le logiciel libre dfu-util (v0.9)")
    End Sub

End Class
