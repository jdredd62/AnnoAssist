Imports Microsoft.Win32

Public Class F_Config
    Private Sub F_Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Installationspfad von Anno lesen (wenn
        Dim Verz_Anno As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Ubisoft\Anno 1800", "InstallDir", Nothing)
        'Dim Verz_Anno As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 916440 ", "InstallLocation", Nothing)

        If Verz_Anno = Nothing Then
            Using RegTyp As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
                Dim Key As RegistryKey = RegTyp.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 916440", False)
                If Key Is Nothing Then
                    L_Ver_Anno.Text = "Weder mit Ubisoft-Connect noch mit Steam installiert"
                Else
                    Verz_Anno = CStr(Key.GetValue("InstallLocation"))
                    L_Ver_Anno.Text = Verz_Anno
                End If
            End Using
        Else
            Verz_Anno = Replace(Verz_Anno, "/", "\")
            L_Ver_Anno.Text = Verz_Anno
        End If


    End Sub

End Class