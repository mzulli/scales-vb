<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.grpBase = New System.Windows.Forms.GroupBox()
        Me.radB = New System.Windows.Forms.RadioButton()
        Me.radC = New System.Windows.Forms.RadioButton()
        Me.radD = New System.Windows.Forms.RadioButton()
        Me.radE = New System.Windows.Forms.RadioButton()
        Me.radF = New System.Windows.Forms.RadioButton()
        Me.radG = New System.Windows.Forms.RadioButton()
        Me.radA = New System.Windows.Forms.RadioButton()
        Me.txtMajorScale = New System.Windows.Forms.TextBox()
        Me.lblProgressions = New System.Windows.Forms.Label()
        Me.lblScales = New System.Windows.Forms.Label()
        Me.txtMajorProgs = New System.Windows.Forms.TextBox()
        Me.grpAccidental = New System.Windows.Forms.GroupBox()
        Me.radNatural = New System.Windows.Forms.RadioButton()
        Me.radFlat = New System.Windows.Forms.RadioButton()
        Me.radSharp = New System.Windows.Forms.RadioButton()
        Me.grpBase.SuspendLayout()
        Me.grpAccidental.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(343, 400)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 35)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblKey
        '
        Me.lblKey.BackColor = System.Drawing.SystemColors.Window
        Me.lblKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKey.Location = New System.Drawing.Point(350, 29)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(79, 89)
        Me.lblKey.TabIndex = 0
        Me.lblKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(333, 128)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(112, 35)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "&Set Key"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'grpBase
        '
        Me.grpBase.Controls.Add(Me.radB)
        Me.grpBase.Controls.Add(Me.radC)
        Me.grpBase.Controls.Add(Me.radD)
        Me.grpBase.Controls.Add(Me.radE)
        Me.grpBase.Controls.Add(Me.radF)
        Me.grpBase.Controls.Add(Me.radG)
        Me.grpBase.Controls.Add(Me.radA)
        Me.grpBase.Location = New System.Drawing.Point(12, 12)
        Me.grpBase.Name = "grpBase"
        Me.grpBase.Size = New System.Drawing.Size(158, 151)
        Me.grpBase.TabIndex = 2
        Me.grpBase.TabStop = False
        Me.grpBase.Text = "Select Base Note"
        '
        'radB
        '
        Me.radB.AutoSize = True
        Me.radB.Location = New System.Drawing.Point(10, 58)
        Me.radB.Name = "radB"
        Me.radB.Size = New System.Drawing.Size(38, 24)
        Me.radB.TabIndex = 1
        Me.radB.TabStop = True
        Me.radB.Text = "&B"
        Me.radB.UseVisualStyleBackColor = True
        '
        'radC
        '
        Me.radC.AutoSize = True
        Me.radC.Location = New System.Drawing.Point(10, 82)
        Me.radC.Name = "radC"
        Me.radC.Size = New System.Drawing.Size(38, 24)
        Me.radC.TabIndex = 2
        Me.radC.TabStop = True
        Me.radC.Text = "&C"
        Me.radC.UseVisualStyleBackColor = True
        '
        'radD
        '
        Me.radD.AutoSize = True
        Me.radD.Location = New System.Drawing.Point(10, 106)
        Me.radD.Name = "radD"
        Me.radD.Size = New System.Drawing.Size(39, 24)
        Me.radD.TabIndex = 3
        Me.radD.TabStop = True
        Me.radD.Text = "&D"
        Me.radD.UseVisualStyleBackColor = True
        '
        'radE
        '
        Me.radE.AutoSize = True
        Me.radE.Location = New System.Drawing.Point(54, 34)
        Me.radE.Name = "radE"
        Me.radE.Size = New System.Drawing.Size(38, 24)
        Me.radE.TabIndex = 4
        Me.radE.TabStop = True
        Me.radE.Text = "&E"
        Me.radE.UseVisualStyleBackColor = True
        '
        'radF
        '
        Me.radF.AutoSize = True
        Me.radF.Location = New System.Drawing.Point(54, 58)
        Me.radF.Name = "radF"
        Me.radF.Size = New System.Drawing.Size(37, 24)
        Me.radF.TabIndex = 5
        Me.radF.TabStop = True
        Me.radF.Text = "&F"
        Me.radF.UseVisualStyleBackColor = True
        '
        'radG
        '
        Me.radG.AutoSize = True
        Me.radG.Location = New System.Drawing.Point(54, 82)
        Me.radG.Name = "radG"
        Me.radG.Size = New System.Drawing.Size(40, 24)
        Me.radG.TabIndex = 6
        Me.radG.TabStop = True
        Me.radG.Text = "&G"
        Me.radG.UseVisualStyleBackColor = True
        '
        'radA
        '
        Me.radA.AutoSize = True
        Me.radA.Location = New System.Drawing.Point(10, 34)
        Me.radA.Name = "radA"
        Me.radA.Size = New System.Drawing.Size(38, 24)
        Me.radA.TabIndex = 0
        Me.radA.TabStop = True
        Me.radA.Text = "&A"
        Me.radA.UseVisualStyleBackColor = True
        '
        'txtMajorScale
        '
        Me.txtMajorScale.Location = New System.Drawing.Point(22, 208)
        Me.txtMajorScale.Name = "txtMajorScale"
        Me.txtMajorScale.Size = New System.Drawing.Size(433, 26)
        Me.txtMajorScale.TabIndex = 6
        '
        'lblProgressions
        '
        Me.lblProgressions.AutoSize = True
        Me.lblProgressions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgressions.Location = New System.Drawing.Point(18, 267)
        Me.lblProgressions.Name = "lblProgressions"
        Me.lblProgressions.Size = New System.Drawing.Size(241, 20)
        Me.lblProgressions.TabIndex = 9
        Me.lblProgressions.Text = "Common Chord Progressions"
        '
        'lblScales
        '
        Me.lblScales.AutoSize = True
        Me.lblScales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScales.Location = New System.Drawing.Point(18, 185)
        Me.lblScales.Name = "lblScales"
        Me.lblScales.Size = New System.Drawing.Size(103, 20)
        Me.lblScales.TabIndex = 4
        Me.lblScales.Text = "Major Scale"
        '
        'txtMajorProgs
        '
        Me.txtMajorProgs.Location = New System.Drawing.Point(22, 290)
        Me.txtMajorProgs.Multiline = True
        Me.txtMajorProgs.Name = "txtMajorProgs"
        Me.txtMajorProgs.Size = New System.Drawing.Size(293, 145)
        Me.txtMajorProgs.TabIndex = 11
        '
        'grpAccidental
        '
        Me.grpAccidental.Controls.Add(Me.radSharp)
        Me.grpAccidental.Controls.Add(Me.radFlat)
        Me.grpAccidental.Controls.Add(Me.radNatural)
        Me.grpAccidental.Location = New System.Drawing.Point(188, 12)
        Me.grpAccidental.Name = "grpAccidental"
        Me.grpAccidental.Size = New System.Drawing.Size(127, 150)
        Me.grpAccidental.TabIndex = 3
        Me.grpAccidental.TabStop = False
        Me.grpAccidental.Text = "Accidental?"
        '
        'radNatural
        '
        Me.radNatural.AutoSize = True
        Me.radNatural.Location = New System.Drawing.Point(6, 34)
        Me.radNatural.Name = "radNatural"
        Me.radNatural.Size = New System.Drawing.Size(78, 24)
        Me.radNatural.TabIndex = 0
        Me.radNatural.TabStop = True
        Me.radNatural.Text = "&Natural"
        Me.radNatural.UseVisualStyleBackColor = True
        '
        'radFlat
        '
        Me.radFlat.AutoSize = True
        Me.radFlat.Location = New System.Drawing.Point(6, 58)
        Me.radFlat.Name = "radFlat"
        Me.radFlat.Size = New System.Drawing.Size(77, 24)
        Me.radFlat.TabIndex = 1
        Me.radFlat.TabStop = True
        Me.radFlat.Text = "F&lat (b)"
        Me.radFlat.UseVisualStyleBackColor = True
        '
        'radSharp
        '
        Me.radSharp.AutoSize = True
        Me.radSharp.Location = New System.Drawing.Point(6, 82)
        Me.radSharp.Name = "radSharp"
        Me.radSharp.Size = New System.Drawing.Size(93, 24)
        Me.radSharp.TabIndex = 2
        Me.radSharp.TabStop = True
        Me.radSharp.Text = "Sharp (&#)"
        Me.radSharp.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 474)
        Me.Controls.Add(Me.grpAccidental)
        Me.Controls.Add(Me.txtMajorProgs)
        Me.Controls.Add(Me.lblScales)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.lblProgressions)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtMajorScale)
        Me.Controls.Add(Me.grpBase)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "Songwriter's Assistant"
        Me.grpBase.ResumeLayout(False)
        Me.grpBase.PerformLayout()
        Me.grpAccidental.ResumeLayout(False)
        Me.grpAccidental.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents grpBase As System.Windows.Forms.GroupBox
    Friend WithEvents radA As System.Windows.Forms.RadioButton
    Friend WithEvents radB As System.Windows.Forms.RadioButton
    Friend WithEvents radC As System.Windows.Forms.RadioButton
    Friend WithEvents radD As System.Windows.Forms.RadioButton
    Friend WithEvents radE As System.Windows.Forms.RadioButton
    Friend WithEvents radF As System.Windows.Forms.RadioButton
    Friend WithEvents radG As System.Windows.Forms.RadioButton
    Friend WithEvents txtMajorScale As System.Windows.Forms.TextBox
    Friend WithEvents lblProgressions As System.Windows.Forms.Label
    Friend WithEvents lblScales As System.Windows.Forms.Label
    Friend WithEvents txtMajorProgs As System.Windows.Forms.TextBox
    Friend WithEvents grpAccidental As System.Windows.Forms.GroupBox
    Friend WithEvents radSharp As System.Windows.Forms.RadioButton
    Friend WithEvents radFlat As System.Windows.Forms.RadioButton
    Friend WithEvents radNatural As System.Windows.Forms.RadioButton

End Class
