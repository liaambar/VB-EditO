<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnGS = New System.Windows.Forms.Button()
        Me.BtnBiner = New System.Windows.Forms.Button()
        Me.BtnNeg = New System.Windows.Forms.Button()
        Me.BtnThres = New System.Windows.Forms.Button()
        Me.BtnRGB = New System.Windows.Forms.Button()
        Me.BtnBright = New System.Windows.Forms.Button()
        Me.BtnKon1 = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnKon2 = New System.Windows.Forms.Button()
        Me.BtnMove = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TxtHscrol = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox1.Location = New System.Drawing.Point(39, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Location = New System.Drawing.Point(38, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 400)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(124, 23)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(75, 23)
        Me.BtnOpen.TabIndex = 2
        Me.BtnOpen.Text = "Browse"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(263, 19)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnGS
        '
        Me.BtnGS.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGS.Location = New System.Drawing.Point(908, 290)
        Me.BtnGS.Name = "BtnGS"
        Me.BtnGS.Size = New System.Drawing.Size(111, 40)
        Me.BtnGS.TabIndex = 4
        Me.BtnGS.Text = "GrayScale"
        Me.BtnGS.UseVisualStyleBackColor = True
        '
        'BtnBiner
        '
        Me.BtnBiner.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBiner.Location = New System.Drawing.Point(1060, 343)
        Me.BtnBiner.Name = "BtnBiner"
        Me.BtnBiner.Size = New System.Drawing.Size(111, 40)
        Me.BtnBiner.TabIndex = 5
        Me.BtnBiner.Text = "Biner"
        Me.BtnBiner.UseVisualStyleBackColor = True
        '
        'BtnNeg
        '
        Me.BtnNeg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNeg.Location = New System.Drawing.Point(1060, 290)
        Me.BtnNeg.Name = "BtnNeg"
        Me.BtnNeg.Size = New System.Drawing.Size(111, 40)
        Me.BtnNeg.TabIndex = 6
        Me.BtnNeg.Text = "Negatif"
        Me.BtnNeg.UseVisualStyleBackColor = True
        '
        'BtnThres
        '
        Me.BtnThres.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnThres.Location = New System.Drawing.Point(908, 343)
        Me.BtnThres.Name = "BtnThres"
        Me.BtnThres.Size = New System.Drawing.Size(111, 40)
        Me.BtnThres.TabIndex = 7
        Me.BtnThres.Text = "Thresholding"
        Me.BtnThres.UseVisualStyleBackColor = True
        '
        'BtnRGB
        '
        Me.BtnRGB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRGB.Location = New System.Drawing.Point(908, 448)
        Me.BtnRGB.Name = "BtnRGB"
        Me.BtnRGB.Size = New System.Drawing.Size(111, 40)
        Me.BtnRGB.TabIndex = 8
        Me.BtnRGB.Text = "RGB"
        Me.BtnRGB.UseVisualStyleBackColor = True
        '
        'BtnBright
        '
        Me.BtnBright.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBright.Location = New System.Drawing.Point(908, 395)
        Me.BtnBright.Name = "BtnBright"
        Me.BtnBright.Size = New System.Drawing.Size(111, 40)
        Me.BtnBright.TabIndex = 9
        Me.BtnBright.Text = "Brightness"
        Me.BtnBright.UseVisualStyleBackColor = True
        '
        'BtnKon1
        '
        Me.BtnKon1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKon1.Location = New System.Drawing.Point(1060, 395)
        Me.BtnKon1.Name = "BtnKon1"
        Me.BtnKon1.Size = New System.Drawing.Size(111, 40)
        Me.BtnKon1.TabIndex = 10
        Me.BtnKon1.Text = "Kontras 1"
        Me.BtnKon1.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnReset.Location = New System.Drawing.Point(212, 23)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 11
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnKon2
        '
        Me.BtnKon2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKon2.Location = New System.Drawing.Point(1060, 448)
        Me.BtnKon2.Name = "BtnKon2"
        Me.BtnKon2.Size = New System.Drawing.Size(111, 40)
        Me.BtnKon2.TabIndex = 12
        Me.BtnKon2.Text = "Kontras 2"
        Me.BtnKon2.UseVisualStyleBackColor = True
        '
        'BtnMove
        '
        Me.BtnMove.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMove.Location = New System.Drawing.Point(387, 323)
        Me.BtnMove.Name = "BtnMove"
        Me.BtnMove.Size = New System.Drawing.Size(50, 40)
        Me.BtnMove.TabIndex = 13
        Me.BtnMove.Text = "<<"
        Me.BtnMove.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(144, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(144, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(144, 77)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 16
        Me.TextBox3.Visible = False
        '
        'TxtHscrol
        '
        Me.TxtHscrol.Location = New System.Drawing.Point(144, 17)
        Me.TxtHscrol.Name = "TxtHscrol"
        Me.TxtHscrol.Size = New System.Drawing.Size(100, 20)
        Me.TxtHscrol.TabIndex = 17
        Me.TxtHscrol.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtHscrol)
        Me.GroupBox1.Controls.Add(Me.HScrollBar1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(911, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 107)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(12, 47)
        Me.HScrollBar1.Maximum = 255
        Me.HScrollBar1.Minimum = -255
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(232, 17)
        Me.HScrollBar1.TabIndex = 26
        Me.HScrollBar1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(38, 460)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(300, 15)
        Me.ProgressBar1.TabIndex = 26
        Me.ProgressBar1.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(25, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(361, 91)
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.BtnOpen)
        Me.GroupBox2.Controls.Add(Me.BtnReset)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 370)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Image Input"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.ProgressBar1)
        Me.GroupBox3.Controls.Add(Me.BtnSave)
        Me.GroupBox3.Location = New System.Drawing.Point(469, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 493)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Image Output"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnMove)
        Me.Controls.Add(Me.BtnKon2)
        Me.Controls.Add(Me.BtnKon1)
        Me.Controls.Add(Me.BtnBright)
        Me.Controls.Add(Me.BtnRGB)
        Me.Controls.Add(Me.BtnThres)
        Me.Controls.Add(Me.BtnNeg)
        Me.Controls.Add(Me.BtnBiner)
        Me.Controls.Add(Me.BtnGS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "EDITO Application"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnGS As System.Windows.Forms.Button
    Friend WithEvents BtnBiner As System.Windows.Forms.Button
    Friend WithEvents BtnNeg As System.Windows.Forms.Button
    Friend WithEvents BtnThres As System.Windows.Forms.Button
    Friend WithEvents BtnRGB As System.Windows.Forms.Button
    Friend WithEvents BtnBright As System.Windows.Forms.Button
    Friend WithEvents BtnKon1 As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnKon2 As System.Windows.Forms.Button
    Friend WithEvents BtnMove As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtHscrol As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
