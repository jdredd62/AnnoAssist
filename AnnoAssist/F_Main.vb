Public Class F_Main

    ' Deklaration der Variablen
    ' - die Konfigurations-Variablen:
    '
    Public Shared Dir_Anno As String = String.Empty
    Public Shared Dir_Anno_exe As String = String.Empty
    Public Shared Dir_Mods As String = String.Empty
    Public Shared Dir_ModLoader As String = String.Empty
    Public Shared Dir_Original As String = String.Empty

    Public Shared Dir_Backup_saves As String = String.Empty
    Public Shared Dir_Backup_mods As String = String.Empty

    Public Shared Dir_ModTool As String = String.Empty
    Public Shared Dir_MapEditor As String = String.Empty
    Public Shared Dir_AssetViewer As String = String.Empty
    Public Shared Dir_AnnoDesigner As String = String.Empty
    Public Shared Dir_Ex_ModManager As String = String.Empty

    ' - Mod-Listen
    '
    Public Shared Modlist_01 As String = String.Empty
    Public Shared Modlist_02 As String = String.Empty
    Public Shared Modlist_03 As String = String.Empty
    Public Shared Modlist_04 As String = String.Empty
    Public Shared Modlist_05 As String = String.Empty

    ' - die Link-Variablen
    '
    Public Shared Link_01 As String = String.Empty
    Public Shared Link_02 As String = String.Empty
    Public Shared Link_03 As String = String.Empty
    Public Shared Link_04 As String = String.Empty
    Public Shared Link_05 As String = String.Empty
    Public Shared Link_06 As String = String.Empty
    Public Shared Link_07 As String = String.Empty
    Public Shared Link_08 As String = String.Empty
    Public Shared Link_09 As String = String.Empty
    Public Shared Link_10 As String = String.Empty


    Private Sub TaludasCollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaludasCollectionToolStripMenuItem.Click
        Process.Start("https://github.com/Taludas")
    End Sub

    Private Sub NexusModsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NexusModsToolStripMenuItem.Click
        Process.Start("https://www.nexusmods.com/anno1800")
    End Sub

    Private Sub JakobToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JakobToolStripMenuItem.Click
        Process.Start("https://github.com/jakobharder")
    End Sub

    Private Sub FishbossToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FishbossToolStripMenuItem.Click
        Process.Start("https://github.com/anno-mods/Fishboss-Mods")
    End Sub

    Private Sub ÜberAnnoAssistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜberAnnoAssistToolStripMenuItem.Click
        Ueber.ShowDialog()
    End Sub
End Class
