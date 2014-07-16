'
' Erstellt mit SharpDevelop.
' Benutzer: mcwea
' Datum: 30.07.2013
' Zeit: 11:43
' 
' Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.checkBox1 = New System.Windows.Forms.CheckBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.textBox3 = New System.Windows.Forms.TextBox()
		Me.textBox4 = New System.Windows.Forms.TextBox()
		Me.button3 = New System.Windows.Forms.Button()
		Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
		Me.textBox5 = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.button4 = New System.Windows.Forms.Button()
		Me.groupBox1.SuspendLayout
		Me.SuspendLayout
		'
		'textBox1
		'
		Me.textBox1.Enabled = false
		Me.textBox1.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.Location = New System.Drawing.Point(14, 26)
		Me.textBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(279, 21)
		Me.textBox1.TabIndex = 0
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Image = CType(resources.GetObject("button1.Image"),System.Drawing.Image)
		Me.button1.Location = New System.Drawing.Point(312, 11)
		Me.button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(41, 36)
		Me.button1.TabIndex = 1
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'button2
		'
		Me.button2.Image = CType(resources.GetObject("button2.Image"),System.Drawing.Image)
		Me.button2.Location = New System.Drawing.Point(312, 55)
		Me.button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(41, 36)
		Me.button2.TabIndex = 2
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'checkBox1
		'
		Me.checkBox1.Location = New System.Drawing.Point(14, 102)
		Me.checkBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.checkBox1.Name = "checkBox1"
		Me.checkBox1.Size = New System.Drawing.Size(135, 20)
		Me.checkBox1.TabIndex = 3
		Me.checkBox1.Text = "Extended SFX dialog"
		Me.checkBox1.UseVisualStyleBackColor = true
		AddHandler Me.checkBox1.CheckedChanged, AddressOf Me.CheckBox1CheckedChanged
		'
		'textBox2
		'
		Me.textBox2.Enabled = false
		Me.textBox2.Location = New System.Drawing.Point(105, 25)
		Me.textBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(234, 19)
		Me.textBox2.TabIndex = 4
		'
		'textBox3
		'
		Me.textBox3.Enabled = false
		Me.textBox3.Location = New System.Drawing.Point(105, 59)
		Me.textBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.textBox3.Multiline = true
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(235, 47)
		Me.textBox3.TabIndex = 5
		'
		'textBox4
		'
		Me.textBox4.Enabled = false
		Me.textBox4.Location = New System.Drawing.Point(15, 137)
		Me.textBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.textBox4.Name = "textBox4"
		Me.textBox4.Size = New System.Drawing.Size(250, 19)
		Me.textBox4.TabIndex = 6
		'
		'button3
		'
		Me.button3.Enabled = false
		Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button3.Image = CType(resources.GetObject("button3.Image"),System.Drawing.Image)
		Me.button3.Location = New System.Drawing.Point(298, 120)
		Me.button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(41, 36)
		Me.button3.TabIndex = 7
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'folderBrowserDialog1
		'
		Me.folderBrowserDialog1.Description = "Please select folder / directory"
		Me.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
		'
		'textBox5
		'
		Me.textBox5.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox5.Location = New System.Drawing.Point(104, 55)
		Me.textBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.textBox5.Name = "textBox5"
		Me.textBox5.Size = New System.Drawing.Size(189, 21)
		Me.textBox5.TabIndex = 8
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(14, 6)
		Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(182, 17)
		Me.label1.TabIndex = 9
		Me.label1.Text = "Folder / directory to ZIP"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(14, 58)
		Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(89, 21)
		Me.label2.TabIndex = 10
		Me.label2.Text = "Name of ZIP file"
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(15, 28)
		Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(89, 21)
		Me.label3.TabIndex = 11
		Me.label3.Text = "Title for SFX"
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(15, 62)
		Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(89, 35)
		Me.label4.TabIndex = 12
		Me.label4.Text = "Description for SFX"
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(15, 114)
		Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(162, 21)
		Me.label5.TabIndex = 13
		Me.label5.Text = "Folder / directory for extract to"
		'
		'groupBox1
		'
		Me.groupBox1.BackColor = System.Drawing.SystemColors.Control
		Me.groupBox1.Controls.Add(Me.button4)
		Me.groupBox1.Controls.Add(Me.textBox3)
		Me.groupBox1.Controls.Add(Me.label5)
		Me.groupBox1.Controls.Add(Me.textBox2)
		Me.groupBox1.Controls.Add(Me.label4)
		Me.groupBox1.Controls.Add(Me.textBox4)
		Me.groupBox1.Controls.Add(Me.label3)
		Me.groupBox1.Controls.Add(Me.button3)
		Me.groupBox1.Enabled = false
		Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox1.Location = New System.Drawing.Point(14, 126)
		Me.groupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.groupBox1.Size = New System.Drawing.Size(356, 209)
		Me.groupBox1.TabIndex = 14
		Me.groupBox1.TabStop = false
		'
		'button4
		'
		Me.button4.Image = CType(resources.GetObject("button4.Image"),System.Drawing.Image)
		Me.button4.Location = New System.Drawing.Point(298, 160)
		Me.button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(41, 36)
		Me.button4.TabIndex = 15
		Me.button4.UseVisualStyleBackColor = true
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LightGreen
		Me.ClientSize = New System.Drawing.Size(385, 355)
		Me.Controls.Add(Me.checkBox1)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.textBox5)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.textBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "MainForm"
		Me.Text = "SFXmaker (7zip)"
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private button4 As System.Windows.Forms.Button
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private textBox5 As System.Windows.Forms.TextBox
	Private folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
	Private button3 As System.Windows.Forms.Button
	Private textBox4 As System.Windows.Forms.TextBox
	Private textBox3 As System.Windows.Forms.TextBox
	Private textBox2 As System.Windows.Forms.TextBox
	Private checkBox1 As System.Windows.Forms.CheckBox
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private textBox1 As System.Windows.Forms.TextBox
End Class
