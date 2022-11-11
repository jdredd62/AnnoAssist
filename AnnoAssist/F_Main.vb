Public Class F_Main
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
End Class
