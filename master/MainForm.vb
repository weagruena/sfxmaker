'
' Erstellt mit SharpDevelop.
' Benutzer: mcwea
' Datum: 30.07.2013
' Zeit: 11:43
' 
' Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
'
Imports System.IO

Public Partial Class MainForm
	Dim cmd1 As String
	Dim cmd2 As String
	Dim cmd3 As String
	Dim path2zip As String
	Dim path2ext As String
	Dim sfxtitle As String
	Dim sfxdescr As String	
	Dim zipname As String
	Dim zipexe As String
	Dim special As Boolean = False
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		zipexe = My.Settings("exe7za")
		cmd1 = My.Settings("cmd1")
		cmd2 = My.Settings("cmd2")
		cmd3 = My.Settings("cmd3")
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Dim res As DialogResult
		Dim msg As String
		zipname = Me.textBox5.Text
		msg = "Folder to zip:" & vbTab & path2zip & vbCrLf & "Archive / SFX:" & vbTab & zipname & vbCrLf
		res = MessageBox.Show(msg, "SFXmaker", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
		If res = DialogResult.OK Then
			makeSFX()
		End If
	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		Dim res As DialogResult
		Dim msg As String		
		zipname = Me.textBox5.Text
		msg = "Folder to zip:" & vbTab & path2zip & vbCrLf & "Archive / SFX:" & vbTab & zipname & vbCrLf
		If special Then		
			If path2ext Is Nothing Then
				MessageBox.Show("Folder for extract to is missing !!!", "SFXmaker", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Exit Sub
			End If
			sfxtitle = Me.textBox2.Text
			sfxdescr = Me.textBox3.Text
			msg = msg & "Folder to extract:" & vbTab & path2ext & vbCrLf	
			msg = msg & "Title for SFX:" & vbTab & sfxtitle & vbCrLf
			msg = msg & "Description:" & vbTab & sfxdescr & vbCrLf
		End If
		res = MessageBox.Show(msg, "SFXmaker", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
		If res = DialogResult.OK Then
			makeSFX()
		End If
	End Sub
	
	Sub CheckBox1CheckedChanged(sender As Object, e As EventArgs)
		If Me.checkBox1.Checked Then
			Me.groupBox1.Enabled = True
			Me.textBox2.Enabled = True
			Me.textBox3.Enabled = True
			Me.button3.Enabled = True
			Me.button2.Enabled = False
			Me.button4.Enabled = True
			special = True
		Else
			Me.groupBox1.Enabled = False	
			Me.textBox2.Enabled = False
			Me.textBox3.Enabled = False
			Me.button3.Enabled = False
			Me.button2.Enabled = True
			Me.button4.Enabled = False
			special = False
		End If		
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		Dim path() As String
		If Me.checkBox2.Checked Then			
			Me.openFileDialog1.ShowDialog
			path2zip = Chr(34) & Me.openFileDialog1.FileName & Chr(34)			
			Me.textBox1.Text = path2zip			
			Dim fname As New FileInfo(Me.openFileDialog1.FileName) 
			Dim zname As String = fname.Name.Replace(" ", "_")
			zipname = "c:\temp\" & zname & ".exe"
			
		ElseIf Me.checkBox3.Checked Then
			
			Me.folderBrowserDialog1.ShowDialog
			path2zip = Chr(34) & Me.folderBrowserDialog1.SelectedPath & Chr(34)
			Me.textBox1.Text = path2zip
			path = Me.folderBrowserDialog1.SelectedPath.Split("\")
			Dim chunk As Integer = path.Length
			zipname = "c:\temp\" & path(chunk - 1) & ".exe"
				
		End If
		Me.textBox5.Text = zipname
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		Me.folderBrowserDialog1.ShowDialog
		path2ext = Me.folderBrowserDialog1.SelectedPath
		If path2ext Is Nothing Then
			path2ext = "c:\temp"
		End If
		Me.textBox4.Text = path2ext
	End Sub
	
	Sub makeSFX()
		Dim cmd As String
		Dim objCFG As StreamWriter		
		Dim zip As New System.Diagnostics.Process()
		
		If special Then
			objCFG = New StreamWriter("c:\temp\config.txt")
			objCFG.WriteLine(";!@Install@!UTF-8!")
			objCFG.WriteLine("GUIMode=" & Chr(34) & "1" & Chr(34))
			objCFG.WriteLine("GUIFlags=" & Chr(34) & "73" & Chr(34))
			objCFG.WriteLine("Title=" & Chr(34) & sfxtitle & Chr(34))
			objCFG.WriteLine("InstallPath=" & Chr(34) & path2ext & Chr(34))
			objCFG.WriteLine("BeginPrompt=" & Chr(34) & sfxdescr & Chr(34))
			objCFG.WriteLine(";!@InstallEnd@!")
			objCFG.Close
			objCFG = Nothing
			'cmd1 = " a c:\temp\temp.7z " & path2zip
			cmd = cmd1 & path2zip
			zip.StartInfo.FileName = zipexe
			zip.StartInfo.Arguments = cmd
			zip.Start()
			zip.WaitForExit()
			Dim path As String = Directory.GetCurrentDirectory
			Dim sfxf As String = path & "\7zsd.sfx"
			zip.StartInfo.FileName = "cmd.exe"
			zip.StartInfo.Arguments = cmd3 & sfxf & " + c:\temp\config.txt + c:\temp\temp.7z " & zipname
			zip.Start()
			zip.WaitForExit()
			System.IO.File.Delete("c:\temp\config.txt")
			System.IO.File.Delete("c:\temp\temp.7z")
		Else
			'cmd2 = " a -sfx7z.sfx " & zipname & " " & path2zip
			cmd = cmd2 & zipname & " " & path2zip
			zip.StartInfo.FileName = zipexe
			zip.StartInfo.Arguments = cmd
			zip.Start()
			zip.WaitForExit()
		End If	
		MessageBox.Show("Archive (SFX) created: " & zipname , "SFXmaker", MessageBoxButtons.OK, MessageBoxIcon.Information)
		System.Environment.Exit(0)
	End Sub
		
	Sub CheckBox2Click(sender As Object, e As EventArgs)
		Me.checkBox3.Checked = False
		Me.checkBox2.Checked = True
		Me.label1.Text = "File to ZIP"
	End Sub
	
	Sub CheckBox3Click(sender As Object, e As EventArgs)
		Me.checkBox2.Checked = False
		Me.checkBox3.Checked = True
		Me.label1.Text = "Folder to ZIP"
	End Sub
	
End Class
