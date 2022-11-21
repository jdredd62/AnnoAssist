<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ueber
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ueber))
        Me.P_Ueber = New System.Windows.Forms.PictureBox()
        Me.B_Ueber_close = New System.Windows.Forms.Button()
        Me.L_Ueber = New System.Windows.Forms.Label()
        Me.L_Ueber_Link = New System.Windows.Forms.LinkLabel()
        Me.L_Ueber_Ideen = New System.Windows.Forms.Label()
        CType(Me.P_Ueber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_Ueber
        '
        Me.P_Ueber.Image = Global.AnnoAssist.My.Resources.Resources.Titel_Bild1
        Me.P_Ueber.InitialImage = Global.AnnoAssist.My.Resources.Resources.Titel_Bild1
        Me.P_Ueber.Location = New System.Drawing.Point(12, 12)
        Me.P_Ueber.Name = "P_Ueber"
        Me.P_Ueber.Size = New System.Drawing.Size(442, 119)
        Me.P_Ueber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P_Ueber.TabIndex = 0
        Me.P_Ueber.TabStop = False
        '
        'B_Ueber_close
        '
        Me.B_Ueber_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Ueber_close.Location = New System.Drawing.Point(165, 643)
        Me.B_Ueber_close.Name = "B_Ueber_close"
        Me.B_Ueber_close.Size = New System.Drawing.Size(135, 42)
        Me.B_Ueber_close.TabIndex = 1
        Me.B_Ueber_close.Text = "Schließen"
        Me.B_Ueber_close.UseVisualStyleBackColor = True
        '
        'L_Ueber
        '
        Me.L_Ueber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.L_Ueber.Location = New System.Drawing.Point(12, 294)
        Me.L_Ueber.Name = "L_Ueber"
        Me.L_Ueber.Size = New System.Drawing.Size(442, 160)
        Me.L_Ueber.TabIndex = 2
        Me.L_Ueber.Text = "AnnoAssist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(c) 2022 by JDredd62 (Michael Zeiler)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Entwickelt von: Debbischkl" &
    "oppa u. JDredd62" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ideen-Geber:"
        Me.L_Ueber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'L_Ueber_Link
        '
        Me.L_Ueber_Link.AutoSize = True
        Me.L_Ueber_Link.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Ueber_Link.Location = New System.Drawing.Point(73, 149)
        Me.L_Ueber_Link.Name = "L_Ueber_Link"
        Me.L_Ueber_Link.Size = New System.Drawing.Size(355, 25)
        Me.L_Ueber_Link.TabIndex = 3
        Me.L_Ueber_Link.TabStop = True
        Me.L_Ueber_Link.Text = "https://github.com/jdredd62/AnnoAssist"
        '
        'L_Ueber_Ideen
        '
        Me.L_Ueber_Ideen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Ueber_Ideen.ForeColor = System.Drawing.Color.ForestGreen
        Me.L_Ueber_Ideen.Location = New System.Drawing.Point(113, 454)
        Me.L_Ueber_Ideen.Name = "L_Ueber_Ideen"
        Me.L_Ueber_Ideen.Size = New System.Drawing.Size(236, 71)
        Me.L_Ueber_Ideen.TabIndex = 4
        Me.L_Ueber_Ideen.Text = "Lady Meridonia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kessie2004" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ionovia"
        Me.L_Ueber_Ideen.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Ueber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 699)
        Me.Controls.Add(Me.L_Ueber_Ideen)
        Me.Controls.Add(Me.L_Ueber_Link)
        Me.Controls.Add(Me.L_Ueber)
        Me.Controls.Add(Me.B_Ueber_close)
        Me.Controls.Add(Me.P_Ueber)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ueber"
        Me.Text = "Ueber"
        CType(Me.P_Ueber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents P_Ueber As PictureBox
    Friend WithEvents B_Ueber_close As Button
    Friend WithEvents L_Ueber As Label
    Friend WithEvents L_Ueber_Link As LinkLabel
    Friend WithEvents L_Ueber_Ideen As Label
End Class
