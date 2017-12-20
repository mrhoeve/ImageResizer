Imports System.IO
Imports System.Threading

Public Class frmResize

    Public _sourceFile As String = ""
    Public _destinationFile As String = ""
    Public _sourceFolder As String = ""
    Public _destinationFolder As String = ""
    Public _maxHeight As Integer = 0
    Public _maxWidth As Integer = 0
    Public _srcf As String
    Public _dstf As String
    Public _mxHeight As Integer
    Public _mxWidth As Integer
    Dim _counter As Integer = 0
    Dim _tsrcf As String = ""
    Dim _tdstf As String = ""

    Public Event raiseCounter()

    Private Sub loadForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With Me.cbxFormat
            With .Items
                .Clear()
                .Add("Webformaat")
                .Add("Aangepast")
            End With
            .SelectedIndex = 0
        End With
    End Sub
    Private Sub closeFormQuestion(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.BackgroundWorker1.IsBusy Then
            MsgBox("U kunt het programma niet sluiten als er een opdracht wordt uitgevoerd. Annuleer eerst de opdracht.", MsgBoxStyle.Critical, "FOUT")
            e.Cancel = True
            Exit Sub
        End If
        If MsgBox("Wilt u het programma afsluiten?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Afsluiten") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub closeForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If Me.btnClose.Text = "Sluit programma" Then
            Me.Close()
        Else
            If MsgBox("Wilt u de opdracht annuleren?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Annuleren") = MsgBoxResult.Yes Then
                Me.BackgroundWorker1.CancelAsync()
            End If
        End If
    End Sub
    Private Sub SingleOrAllFiles(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSingleFile.CheckedChanged, rbAllFiles.CheckedChanged
        With Me
            If .rbSingleFile.Checked = True Then
                .lblSource.Text = "Bronbestand"
                .lblDestination.Text = "Doelbestand"
                .txtSource.Text = _sourceFile
                .txtDestination.Text = _destinationFile
            Else
                .lblSource.Text = "Bronmap"
                .lblDestination.Text = "Doelmap"
                .txtSource.Text = _sourceFolder
                .txtDestination.Text = _destinationFolder
            End If
        End With
    End Sub
    Private Sub selectSource(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSource.DoubleClick, btnSource.Click
        With Me
            If .rbSingleFile.Checked = True Then
                'Selecteer een bronbestand
                With .sourceDialog
                    .CheckFileExists = True
                    .CheckPathExists = True
                    .Multiselect = False
                    .RestoreDirectory = False
                    .Title = "Selecteer het bronbestand"
                    .Filter = "JPG bestanden (*.jpg)|*.jpg"
                    .FileName = _sourceFile
                End With
                If .sourceDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                    _sourceFile = .sourceDialog.FileName
                    .txtSource.Text = _sourceFile
                End If
                .sourceDialog.Dispose()
            Else
                'Selecteer een bronmap
                With .folderDialog
                    .Description = "Selecteer een bronmap"
                    .ShowNewFolderButton = False
                End With
                If .folderDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                    _sourceFolder = .folderDialog.SelectedPath
                    .txtSource.Text = _sourceFolder
                End If
                .folderDialog.Dispose()
            End If
        End With
    End Sub
    Private Sub selectDestination(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDestination.DoubleClick, btnDestination.Click
        With Me
            If .rbSingleFile.Checked = True Then
                'Selecteer een doelbestand
                With .destinationDialog
                    .CreatePrompt = False
                    .DefaultExt = ".jpg"
                    .OverwritePrompt = True
                    .CheckFileExists = False
                    .CheckPathExists = True
                    .RestoreDirectory = False
                    .Title = "Geef een doelbestand"
                    .Filter = "JPG bestanden (*.jpg)|*.jpg;*.jpeg"
                    .FileName = _destinationFile
                End With
                If .destinationDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                    _destinationFile = .destinationDialog.FileName
                    .txtDestination.Text = _destinationFile
                End If
                .destinationDialog.Dispose()
            Else
                'Selecteer een doelmap
                With .folderDialog
                    .Description = "Selecteer een doelmap"
                    .ShowNewFolderButton = True
                End With
                If .folderDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                    _destinationFolder = .folderDialog.SelectedPath
                    .txtDestination.Text = _destinationFolder
                End If
                .folderDialog.Dispose()
            End If
        End With
    End Sub
    Private Sub changeSelectedFormat(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxFormat.SelectedIndexChanged
        With Me
            Select Case .cbxFormat.SelectedIndex
                Case 0
                    .cbxMaxHeight.Checked = True
                    .cbxMaxHeight.Enabled = False
                    .numMaxHeight.Value = 300
                    .numMaxHeight.Enabled = False
                    .cbxMaxWidth.Checked = True
                    .cbxMaxWidth.Enabled = False
                    .numMaxWidth.Value = 300
                    .numMaxWidth.Enabled = False
                Case Else
                    .cbxMaxHeight.Checked = False
                    .cbxMaxHeight.Enabled = True
                    .numMaxHeight.Value = 500
                    .cbxMaxWidth.Checked = False
                    .cbxMaxWidth.Enabled = True
                    .numMaxWidth.Value = 500
            End Select
        End With
    End Sub
    Private Sub HeightWidthCheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMaxHeight.CheckedChanged, cbxMaxWidth.CheckedChanged
        Dim _temp As Object
        Select Case sender.Name.ToString
            Case "cbxMaxHeight"
                _temp = Me.numMaxHeight
            Case Else
                _temp = Me.numMaxWidth
        End Select
        _temp.Enabled = sender.Checked
        _temp = Nothing
    End Sub
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        With Me
            'Controleer eerst of de bron en het doel bekend is
            If .rbSingleFile.Checked = True Then
                If Trim(_sourceFile) = "" Or File.Exists(_sourceFile) = False Then
                    MsgBox("Er is geen geldig bronbestand opgegeven.", MsgBoxStyle.Critical, "FOUT")
                    .txtSource.Focus()
                    Exit Sub
                End If
                If Trim(_destinationFile) = "" Or Directory.Exists(Path.GetDirectoryName(_sourceFile)) = False Then
                    MsgBox("Er is geen geldig doelbestand opgegeven.", MsgBoxStyle.Critical, "FOUT")
                    .txtDestination.Focus()
                    Exit Sub
                End If
                If _sourceFile = _destinationFile Then
                    MsgBox("Bronbestand en doelbestand mogen niet gelijk aan elkaar zijn.", MsgBoxStyle.Critical, "FOUT")
                    Exit Sub
                End If
            Else
                If Trim(_sourceFolder) = "" Or Directory.Exists(_sourceFolder) = False Then
                    MsgBox("Er is geen geldige bronmap opgegeven.", MsgBoxStyle.Critical, "FOUT")
                    .txtSource.Focus()
                    Exit Sub
                End If
                If Trim(_destinationFolder) = "" Or Directory.Exists(_destinationFolder) = False Then
                    MsgBox("Er is geen geldige doelmap opgegeven.", MsgBoxStyle.Critical, "FOUT")
                    .txtDestination.Focus()
                    Exit Sub
                End If
                If _destinationFolder = _sourceFolder Then
                    MsgBox("Bronmap en doelmap mogen niet gelijk aan elkaar zijn.", MsgBoxStyle.Critical, "FOUT")
                    Exit Sub
                End If
            End If
            'So far, so good
            'Nu controleren wij of de maximale hoogte en/of breedte is opgegeven
            If .cbxMaxHeight.Checked = False And .cbxMaxWidth.Checked = False Then
                MsgBox("Er is geen maximale hoogte of breedte opgegeven.", MsgBoxStyle.Critical, "FOUT")
                Exit Sub
            End If
            If .cbxMaxHeight.Checked = True Then
                _maxHeight = .numMaxHeight.Value
            Else
                _maxHeight = 0
            End If
            If .cbxMaxWidth.Checked = True Then
                _maxWidth = .numMaxWidth.Value
            Else
                _maxWidth = 0
            End If
            If .rbSingleFile.Checked = True Then
                _srcf = _sourceFile
                _dstf = _destinationFile
                _mxHeight = _maxHeight
                _mxWidth = _maxWidth
                Me.lblBusyWithFile.Text = String.Format("Bezig met converteren van {0}...", Path.GetFileName(_srcf))
                convertImage()
                ciDone()
            Else
                Me.pgFolderCount.Maximum = 100
                Me.pgFolderCount.Visible = True
                btnStart.Visible = False
                btnClose.Text = "Annuleer"
                Me.BackgroundWorker1.WorkerReportsProgress = True
                Me.BackgroundWorker1.WorkerSupportsCancellation = True
                Me.BackgroundWorker1.RunWorkerAsync()
            End If
        End With
    End Sub
    Public Sub ciDone()
        Me.lblBusyWithFile.Text = ""
        If Me.pgFolderCount.Visible = True Then Me.pgFolderCount.Visible = False
        MsgBox("Opdracht is uitgevoerd.", MsgBoxStyle.Information, "Bericht")
    End Sub

    Public Sub bgwMain(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim maxCount As Integer = Directory.GetFiles(_sourceFolder, "*.jpg", SearchOption.TopDirectoryOnly).Length
        Dim _counter = 0
        For Each _tsrcf In Directory.GetFiles(_sourceFolder, "*.jpg", SearchOption.TopDirectoryOnly)
            If BackgroundWorker1.CancellationPending = True Then
                Exit For
            End If
            _counter = _counter + 1
            _tdstf = _destinationFolder
            If _tdstf.EndsWith("\") = False Then _tdstf = _tdstf & "\"
            _tdstf = _tdstf & Path.GetFileName(_tsrcf)
            _srcf = _tsrcf
            _dstf = _tdstf
            _mxHeight = _maxHeight
            _mxWidth = _maxWidth
            BackgroundWorker1.ReportProgress((_counter / (maxCount / 100)), String.Format("Bezig met converteren van {0}...", Path.GetFileName(_srcf)))
            Dim threadCI As New System.Threading.Thread(AddressOf convertImage)
            threadCI.Start()
            While threadCI.ThreadState = ThreadState.Running
                Application.DoEvents()
            End While
        Next
    End Sub

    Public Sub convertImage()
        Dim _image As Image = Nothing
        Dim _imgCurHeight As Integer = 0
        Dim _imgNewHeight As Integer = 0
        Dim _imgCurWidth As Integer = 0
        Dim _imgNewWidth As Integer = 0
        Dim _tmaxHeight As Integer = _mxHeight
        Dim _tmaxWidth As Integer = _mxWidth
        'Laad de image
        If File.Exists(_srcf) = False Then
            MsgBox("Bronbestand """ & _srcf & """ bestaat niet.", MsgBoxStyle.Critical, "FOUT")
            Exit Sub
        End If
        If My.Computer.FileSystem.GetFileInfo(_srcf).Length = 0 Then
            MsgBox("Bronbestand """ & _srcf & """ is 0 bytes groot.", MsgBoxStyle.Critical, "FOUT")
            Exit Sub
        End If
        Try
            _image = Image.FromFile(_srcf)
        Catch ex As Exception
            MsgBox("Fout bij het laden van de bron """ & _srcf & """.", MsgBoxStyle.Critical, "FOUT")
            Exit Sub
        End Try
        _image = Image.FromFile(_srcf)
        'Bepaal de huidige hoogte en breedte
        _imgCurHeight = _image.Height
        _imgCurWidth = _image.Width
        'Bepaal de nieuwe hoogte en breedte
        If _mxHeight <> 0 And _mxWidth <> 0 Then
            _tmaxWidth = 0
        End If
        If _tmaxHeight <> 0 And _tmaxWidth = 0 Then
            'Bereken de hoogte en breedte als alleen de maximale hoogte is opgegeven
            If _imgCurHeight > _tmaxHeight Then
                _imgNewHeight = _tmaxHeight
                _imgNewWidth = _imgCurWidth * (_tmaxHeight / _imgCurHeight)
            Else
                _imgNewHeight = _imgCurHeight
                _imgNewWidth = _imgCurWidth
            End If
        End If
        If _mxHeight <> 0 And _mxWidth <> 0 Then
            _tmaxHeight = 0
            _tmaxWidth = _mxWidth
            _imgCurHeight = _imgNewHeight
            _imgCurWidth = _imgNewWidth
        End If
        If _tmaxHeight = 0 And _tmaxWidth <> 0 Then
            'Bereken de hoogte en breedte als alleen de maximale breedte is opgegeven
            If _imgCurWidth > _tmaxWidth Then
                _imgNewWidth = _tmaxWidth
                _imgNewHeight = _imgCurHeight * (_tmaxWidth / _imgCurWidth)
            Else
                _imgNewWidth = _imgCurWidth
                _imgNewHeight = _imgCurHeight
            End If
        End If
        'Als alles goed ging zijn _imgNewHeight en _imgNewWidth nu voorzien van een waarde
        If _imgNewHeight = 0 Or _imgNewWidth = 0 Then
            MsgBox("Delingsfout! Kan de opdracht niet voltooien.", MsgBoxStyle.Critical, "FOUT")
            Exit Sub
        End If
        _image = New Bitmap(_image, New Size(_imgNewWidth, _imgNewHeight))
        Try
            If File.Exists(_dstf) = True Then File.Delete(_dstf)
            _image.Save(_dstf, System.Drawing.Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            MsgBox("Er is een fout opgetreden bij het opslaan van het bestand.", MsgBoxStyle.Critical, "FOUT")
            Exit Sub
        End Try
        '_image = Nothing
        _image.Dispose()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.pgFolderCount.Value = e.ProgressPercentage
        Me.lblBusyWithFile.Text = e.UserState
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.btnClose.Text = "Sluit programma"
        Me.btnStart.Visible = True
        ciDone()
    End Sub


End Class
