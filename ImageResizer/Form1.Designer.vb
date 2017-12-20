<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResize
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAllFiles = New System.Windows.Forms.RadioButton()
        Me.rbSingleFile = New System.Windows.Forms.RadioButton()
        Me.btnDestination = New System.Windows.Forms.Button()
        Me.btnSource = New System.Windows.Forms.Button()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.numMaxWidth = New System.Windows.Forms.NumericUpDown()
        Me.numMaxHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxMaxWidth = New System.Windows.Forms.CheckBox()
        Me.cbxMaxHeight = New System.Windows.Forms.CheckBox()
        Me.cbxFormat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.folderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.sourceDialog = New System.Windows.Forms.OpenFileDialog()
        Me.destinationDialog = New System.Windows.Forms.SaveFileDialog()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblBusyWithFile = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pgFolderCount = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numMaxWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMaxHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Image Resizer 2.0"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAllFiles)
        Me.GroupBox1.Controls.Add(Me.rbSingleFile)
        Me.GroupBox1.Controls.Add(Me.btnDestination)
        Me.GroupBox1.Controls.Add(Me.btnSource)
        Me.GroupBox1.Controls.Add(Me.txtDestination)
        Me.GroupBox1.Controls.Add(Me.lblDestination)
        Me.GroupBox1.Controls.Add(Me.txtSource)
        Me.GroupBox1.Controls.Add(Me.lblSource)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mapgegevens"
        '
        'rbAllFiles
        '
        Me.rbAllFiles.AutoSize = True
        Me.rbAllFiles.Checked = True
        Me.rbAllFiles.Location = New System.Drawing.Point(135, 20)
        Me.rbAllFiles.Name = "rbAllFiles"
        Me.rbAllFiles.Size = New System.Drawing.Size(219, 17)
        Me.rbAllFiles.TabIndex = 7
        Me.rbAllFiles.TabStop = True
        Me.rbAllFiles.Text = "Alle bestanden in opgegeven map"
        Me.rbAllFiles.UseVisualStyleBackColor = True
        '
        'rbSingleFile
        '
        Me.rbSingleFile.AutoSize = True
        Me.rbSingleFile.Location = New System.Drawing.Point(9, 20)
        Me.rbSingleFile.Name = "rbSingleFile"
        Me.rbSingleFile.Size = New System.Drawing.Size(105, 17)
        Me.rbSingleFile.TabIndex = 6
        Me.rbSingleFile.TabStop = True
        Me.rbSingleFile.Text = "Enkel bestand"
        Me.rbSingleFile.UseVisualStyleBackColor = True
        '
        'btnDestination
        '
        Me.btnDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDestination.Location = New System.Drawing.Point(320, 70)
        Me.btnDestination.Name = "btnDestination"
        Me.btnDestination.Size = New System.Drawing.Size(34, 21)
        Me.btnDestination.TabIndex = 5
        Me.btnDestination.Text = "..."
        Me.btnDestination.UseVisualStyleBackColor = True
        '
        'btnSource
        '
        Me.btnSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSource.Location = New System.Drawing.Point(320, 42)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(34, 21)
        Me.btnSource.TabIndex = 4
        Me.btnSource.Text = "..."
        Me.btnSource.UseVisualStyleBackColor = True
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(91, 70)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.ReadOnly = True
        Me.txtDestination.Size = New System.Drawing.Size(223, 21)
        Me.txtDestination.TabIndex = 3
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Location = New System.Drawing.Point(6, 73)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(58, 13)
        Me.lblDestination.TabIndex = 2
        Me.lblDestination.Text = "Doelmap"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(91, 43)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.ReadOnly = True
        Me.txtSource.Size = New System.Drawing.Size(223, 21)
        Me.txtSource.TabIndex = 1
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(6, 46)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(59, 13)
        Me.lblSource.TabIndex = 0
        Me.lblSource.Text = "Bronmap"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.numMaxWidth)
        Me.GroupBox2.Controls.Add(Me.numMaxHeight)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cbxMaxWidth)
        Me.GroupBox2.Controls.Add(Me.cbxMaxHeight)
        Me.GroupBox2.Controls.Add(Me.cbxFormat)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 103)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resize gegevens"
        '
        'numMaxWidth
        '
        Me.numMaxWidth.Enabled = False
        Me.numMaxWidth.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.numMaxWidth.Location = New System.Drawing.Point(185, 75)
        Me.numMaxWidth.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.numMaxWidth.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numMaxWidth.Name = "numMaxWidth"
        Me.numMaxWidth.Size = New System.Drawing.Size(83, 21)
        Me.numMaxWidth.TabIndex = 10
        Me.numMaxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numMaxWidth.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'numMaxHeight
        '
        Me.numMaxHeight.Enabled = False
        Me.numMaxHeight.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.numMaxHeight.Location = New System.Drawing.Point(185, 48)
        Me.numMaxHeight.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.numMaxHeight.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numMaxHeight.Name = "numMaxHeight"
        Me.numMaxHeight.Size = New System.Drawing.Size(83, 21)
        Me.numMaxHeight.TabIndex = 9
        Me.numMaxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numMaxHeight.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(274, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "pixels"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(274, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "pixels"
        '
        'cbxMaxWidth
        '
        Me.cbxMaxWidth.AutoSize = True
        Me.cbxMaxWidth.Location = New System.Drawing.Point(9, 76)
        Me.cbxMaxWidth.Name = "cbxMaxWidth"
        Me.cbxMaxWidth.Size = New System.Drawing.Size(170, 17)
        Me.cbxMaxWidth.TabIndex = 3
        Me.cbxMaxWidth.Text = "Specificeer max. breedte"
        Me.cbxMaxWidth.UseVisualStyleBackColor = True
        '
        'cbxMaxHeight
        '
        Me.cbxMaxHeight.AutoSize = True
        Me.cbxMaxHeight.Location = New System.Drawing.Point(9, 49)
        Me.cbxMaxHeight.Name = "cbxMaxHeight"
        Me.cbxMaxHeight.Size = New System.Drawing.Size(165, 17)
        Me.cbxMaxHeight.TabIndex = 2
        Me.cbxMaxHeight.Text = "Specificeer max. hoogte"
        Me.cbxMaxHeight.UseVisualStyleBackColor = True
        '
        'cbxFormat
        '
        Me.cbxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxFormat.FormattingEnabled = True
        Me.cbxFormat.Location = New System.Drawing.Point(66, 20)
        Me.cbxFormat.Name = "cbxFormat"
        Me.cbxFormat.Size = New System.Drawing.Size(248, 21)
        Me.cbxFormat.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Formaat"
        '
        'sourceDialog
        '
        Me.sourceDialog.FileName = "OpenFileDialog1"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(166, 425)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 23)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(272, 425)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Sluit programma"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblBusyWithFile
        '
        Me.lblBusyWithFile.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusyWithFile.Location = New System.Drawing.Point(9, 351)
        Me.lblBusyWithFile.Name = "lblBusyWithFile"
        Me.lblBusyWithFile.Size = New System.Drawing.Size(363, 14)
        Me.lblBusyWithFile.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(400, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'pgFolderCount
        '
        Me.pgFolderCount.Location = New System.Drawing.Point(12, 382)
        Me.pgFolderCount.Name = "pgFolderCount"
        Me.pgFolderCount.Size = New System.Drawing.Size(360, 23)
        Me.pgFolderCount.TabIndex = 8
        Me.pgFolderCount.Visible = False
        '
        'BackgroundWorker1
        '
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(176, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Copyright © 2016"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ImageResizer.My.Resources.Resources.site_logo
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(176, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frmResize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 462)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pgFolderCount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblBusyWithFile)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmResize"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Image Resizer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numMaxWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMaxHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDestination As System.Windows.Forms.Button
    Friend WithEvents btnSource As System.Windows.Forms.Button
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents lblDestination As System.Windows.Forms.Label
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxMaxWidth As System.Windows.Forms.CheckBox
    Friend WithEvents cbxMaxHeight As System.Windows.Forms.CheckBox
    Friend WithEvents cbxFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbAllFiles As System.Windows.Forms.RadioButton
    Friend WithEvents rbSingleFile As System.Windows.Forms.RadioButton
    Friend WithEvents folderDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents sourceDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents destinationDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents numMaxHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents numMaxWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblBusyWithFile As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pgFolderCount As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
