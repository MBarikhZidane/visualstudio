Imports System.Data.SqlClient

Public Class master_barang
    Sub ambilData()
        Dim perintah = New SqlCommand("select * from barang where nama_barang like '%" + cariText.Text + "%'", koneksi)
        Dim dataBarang As New DataTable
        Dim adapter = New SqlDataAdapter
        adapter.SelectCommand = perintah
        adapter.Fill(dataBarang)
        DataBarangGrid.DataSource = dataBarang
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Bsimpan_Click(sender As Object, e As EventArgs) Handles Bsimpan.Click
        If namabarangText.Text = "" Then
            MsgBox("Isi Nama Barang")
        ElseIf hargabarangText.Text = "" Then
            MsgBox("Isi Harga Barang")
        Else
            Dim perintah = New SqlCommand("insert into barang(nama_barang,harga_barang)values(@namabarang,@hargabarang)", koneksi)
            perintah.Parameters.AddWithValue("@namabarang", namabarangText.Text)
            perintah.Parameters.AddWithValue("@hargabarang", hargabarangText.Text)
            perintah.ExecuteNonQuery()
            MsgBox("Data Tersimpan")
            hargabarangText.Text = ""
            namabarangText.Text = ""
            ambilData()
        End If
    End Sub

    Private Sub master_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ambilData()
    End Sub

    Private Sub cariText_TextChanged(sender As Object, e As EventArgs) Handles cariText.TextChanged
        ambilData()
    End Sub
End Class