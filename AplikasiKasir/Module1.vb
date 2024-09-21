Imports System.Data.SqlClient


Module Module1
    Public jabatan As String
    Public namaKaryawan As String
    Public idKaryawan As String

    Public koneksi As New SqlConnection("Server=RPL1-19\SQLEXPRESS;Database=db.kasir;Integrated Security=true")

    Sub konek()
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
    End Sub
End Module
