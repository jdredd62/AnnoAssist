<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Config
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Config))
        Me.F_Config_Panel_1 = New System.Windows.Forms.Panel()
        Me.L_Ver_Anno = New System.Windows.Forms.Label()
        Me.F_Config_Panel_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'F_Config_Panel_1
        '
        Me.F_Config_Panel_1.BackColor = System.Drawing.SystemColors.Info
        Me.F_Config_Panel_1.Controls.Add(Me.L_Ver_Anno)
        Me.F_Config_Panel_1.Location = New System.Drawing.Point(15, 15)
        Me.F_Config_Panel_1.Margin = New System.Windows.Forms.Padding(4)
        Me.F_Config_Panel_1.Name = "F_Config_Panel_1"
        Me.F_Config_Panel_1.Size = New System.Drawing.Size(1213, 370)
        Me.F_Config_Panel_1.TabIndex = 0
        '
        'L_Ver_Anno
        '
        Me.L_Ver_Anno.AutoSize = True
        Me.L_Ver_Anno.Location = New System.Drawing.Point(91, 58)
        Me.L_Ver_Anno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Ver_Anno.Name = "L_Ver_Anno"
        Me.L_Ver_Anno.Size = New System.Drawing.Size(59, 20)
        Me.L_Ver_Anno.TabIndex = 0
        Me.L_Ver_Anno.Text = "Label1"
        '
        'F_Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 718)
        Me.Controls.Add(Me.F_Config_Panel_1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "F_Config"
        Me.Text = "Konfiguration"
        Me.F_Config_Panel_1.ResumeLayout(False)
        Me.F_Config_Panel_1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents F_Config_Panel_1 As Panel
    Friend WithEvents L_Ver_Anno As Label
End Class
