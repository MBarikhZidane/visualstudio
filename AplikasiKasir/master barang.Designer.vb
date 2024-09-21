<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class master_barang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.Bbatal = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hargabarangText = New System.Windows.Forms.TextBox()
        Me.namabarangText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idbarangText = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Bedit = New System.Windows.Forms.Button()
        Me.cariText = New System.Windows.Forms.TextBox()
        Me.Bhapus = New System.Windows.Forms.Button()
        Me.Btambah = New System.Windows.Forms.Button()
        Me.DataBarangGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataBarangGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Bsimpan)
        Me.GroupBox1.Controls.Add(Me.Bbatal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.hargabarangText)
        Me.GroupBox1.Controls.Add(Me.namabarangText)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.idbarangText)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 351)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form"
        '
        'Bsimpan
        '
        Me.Bsimpan.BackColor = System.Drawing.Color.DarkGreen
        Me.Bsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsimpan.ForeColor = System.Drawing.Color.Cornsilk
        Me.Bsimpan.Location = New System.Drawing.Point(96, 312)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(84, 33)
        Me.Bsimpan.TabIndex = 6
        Me.Bsimpan.Text = "Simpan"
        Me.Bsimpan.UseVisualStyleBackColor = False
        '
        'Bbatal
        '
        Me.Bbatal.BackColor = System.Drawing.Color.Red
        Me.Bbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bbatal.ForeColor = System.Drawing.Color.Cornsilk
        Me.Bbatal.Location = New System.Drawing.Point(9, 312)
        Me.Bbatal.Name = "Bbatal"
        Me.Bbatal.Size = New System.Drawing.Size(84, 33)
        Me.Bbatal.TabIndex = 5
        Me.Bbatal.Text = "Batal"
        Me.Bbatal.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Harga Barang"
        '
        'hargabarangText
        '
        Me.hargabarangText.Location = New System.Drawing.Point(6, 145)
        Me.hargabarangText.Name = "hargabarangText"
        Me.hargabarangText.Size = New System.Drawing.Size(174, 20)
        Me.hargabarangText.TabIndex = 3
        '
        'namabarangText
        '
        Me.namabarangText.Location = New System.Drawing.Point(6, 87)
        Me.namabarangText.Name = "namabarangText"
        Me.namabarangText.Size = New System.Drawing.Size(174, 20)
        Me.namabarangText.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Barang"
        '
        'idbarangText
        '
        Me.idbarangText.Location = New System.Drawing.Point(12, 48)
        Me.idbarangText.Name = "idbarangText"
        Me.idbarangText.ReadOnly = True
        Me.idbarangText.Size = New System.Drawing.Size(174, 20)
        Me.idbarangText.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Bedit)
        Me.GroupBox2.Controls.Add(Me.cariText)
        Me.GroupBox2.Controls.Add(Me.Bhapus)
        Me.GroupBox2.Controls.Add(Me.Btambah)
        Me.GroupBox2.Controls.Add(Me.DataBarangGrid)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(570, 351)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cari"
        '
        'Bedit
        '
        Me.Bedit.BackColor = System.Drawing.Color.Blue
        Me.Bedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bedit.ForeColor = System.Drawing.Color.Cornsilk
        Me.Bedit.Location = New System.Drawing.Point(390, 20)
        Me.Bedit.Name = "Bedit"
        Me.Bedit.Size = New System.Drawing.Size(84, 29)
        Me.Bedit.TabIndex = 8
        Me.Bedit.Text = "Edit"
        Me.Bedit.UseVisualStyleBackColor = False
        '
        'cariText
        '
        Me.cariText.Location = New System.Drawing.Point(37, 25)
        Me.cariText.Name = "cariText"
        Me.cariText.Size = New System.Drawing.Size(174, 20)
        Me.cariText.TabIndex = 7
        '
        'Bhapus
        '
        Me.Bhapus.BackColor = System.Drawing.Color.Red
        Me.Bhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bhapus.ForeColor = System.Drawing.Color.Cornsilk
        Me.Bhapus.Location = New System.Drawing.Point(300, 20)
        Me.Bhapus.Name = "Bhapus"
        Me.Bhapus.Size = New System.Drawing.Size(84, 29)
        Me.Bhapus.TabIndex = 7
        Me.Bhapus.Text = "Hapus"
        Me.Bhapus.UseVisualStyleBackColor = False
        '
        'Btambah
        '
        Me.Btambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btambah.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btambah.Location = New System.Drawing.Point(480, 20)
        Me.Btambah.Name = "Btambah"
        Me.Btambah.Size = New System.Drawing.Size(84, 29)
        Me.Btambah.TabIndex = 7
        Me.Btambah.Text = "Tambah"
        Me.Btambah.UseVisualStyleBackColor = False
        '
        'DataBarangGrid
        '
        Me.DataBarangGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataBarangGrid.Location = New System.Drawing.Point(6, 58)
        Me.DataBarangGrid.Name = "DataBarangGrid"
        Me.DataBarangGrid.Size = New System.Drawing.Size(558, 286)
        Me.DataBarangGrid.TabIndex = 0
        '
        'master_barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 368)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "master_barang"
        Me.Text = "master_barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataBarangGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents idbarangText As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents namabarangText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents hargabarangText As TextBox
    Friend WithEvents Bbatal As Button
    Friend WithEvents Bsimpan As Button
    Friend WithEvents DataBarangGrid As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Bedit As Button
    Friend WithEvents cariText As TextBox
    Friend WithEvents Bhapus As Button
    Friend WithEvents Btambah As Button
End Class
