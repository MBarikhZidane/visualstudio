Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = namaKaryawan
        Label2.Text = jabatan

        If jabatan = "kasir" Then
            MasterToolStripMenuItem.Visible = False
            LaporanToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
        Login.Username.Text = ""
        Login.Password.Text = ""
        Login.Show()
    End Sub

    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click

    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        master_barang.Show()
    End Sub

    Private Sub PegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegawaiToolStripMenuItem.Click
        MasterKaryawan.Show()
    End Sub
End Class
