Imports System.Data.SqlClient

Public Class MasterKaryawan
    Sub ambilData()
        Dim perintah = New SqlCommand("select * from karyawan where nama_karyawan like '%" + cariText.Text + "%'", koneksi)
        Dim dataBarang As New DataTable
        Dim adapter = New SqlDataAdapter
        adapter.SelectCommand = perintah
        adapter.Fill(dataBarang)
        DataKaryawan.DataSource = dataBarang
    End Sub

    Private Sub Bsimpan_Click(sender As Object, e As EventArgs) Handles Bsimpan.Click
        Dim perintah = New SqlCommand("insert into karyawan(nama_karyawan,username, password, jabatan)values(@namakaryawan,@username, @password, @jabatan)", koneksi)
        perintah.Parameters.AddWithValue("@namakaryawan", namakaryawanText.Text)
        perintah.Parameters.AddWithValue("@username", namausernameText.Text)
        perintah.Parameters.AddWithValue("@password", "123")
        perintah.Parameters.AddWithValue("@jabatan", jabatanbox.Text)
        perintah.ExecuteNonQuery()
        MsgBox("Data Tersimpan")
        namakaryawanText.Text = ""
        namausernameText.Text = ""
        jabatanbox.Text = ""
        ambilData()
    End Sub

    Private Sub master_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ambilData()
    End Sub

    Private Sub cariText_TextChanged(sender As Object, e As EventArgs) Handles cariText.TextChanged
        ambilData()
    End Sub
End Class