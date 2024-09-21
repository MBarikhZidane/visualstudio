Imports System.Data.SqlClient

Public Class Login
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        konek()

        Dim user As New DataTable

        Dim Perintah As New SqlCommand("select * from karyawan where username=@username and password=@password", koneksi)
        Perintah.Parameters.AddWithValue("@username", Username.Text)
        Perintah.Parameters.AddWithValue("@password", Password.Text)

        Dim dataKaryawan As New SqlDataAdapter()
        dataKaryawan.SelectCommand = Perintah

        dataKaryawan.Fill(user)

        If user.Rows.Count = 0 Then
            MsgBox("Username atau Passwords Salah")
            Exit Sub
        End If

        jabatan = user.Rows(0).Item("jabatan").ToString
        namaKaryawan = user.Rows(0).Item("nama_karyawan").ToString
        idKaryawan = user.Rows(0).Item("id_karyawan").ToString

        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Show" Then
            Password.UseSystemPasswordChar = False
            Button2.Text = "Hide"
        Else
            Password.UseSystemPasswordChar = True
            Button2.Text = "Show"
        End If
    End Sub
End Class