Public Class Form2
    Public oriGbr As Bitmap

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnSave.Enabled = False
        BtnGS.Enabled = False
        BtnBiner.Enabled = False
        BtnThres.Enabled = False
        BtnNeg.Enabled = False
        BtnRGB.Enabled = False
        BtnKon1.Enabled = False
        BtnKon2.Enabled = False
        BtnBright.Enabled = False
        BtnReset.Enabled = False
        BtnMove.Enabled = False
    End Sub

    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        OpenFileDialog1.Filter = "Images|*.bmp;*.jpg;*.png;*.jpeg"
        If OpenFileDialog1.ShowDialog() <> System.Windows.Forms.DialogResult.Cancel Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.Width = Convert.ToInt32(PictureBox1.Height * PictureBox1.Image.Width / PictureBox1.Image.Height)
            Me.Text = OpenFileDialog1.FileName & "_" & PictureBox1.Image.Width & "X" & PictureBox1.Image.Height
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = PictureBox1.Image.Width
            oriGbr = New Bitmap(PictureBox1.Image)
            BtnGS.Enabled = True
            BtnBiner.Enabled = True
            BtnThres.Enabled = True
            BtnNeg.Enabled = True
            BtnRGB.Enabled = True
            BtnKon1.Enabled = True
            BtnKon2.Enabled = True
            BtnBright.Enabled = True
            BtnReset.Enabled = True
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            PictureBox2.Image.Save(SaveFileDialog1.FileName + ".jpg")
        End If
    End Sub

    Private Sub BtnMove_Click(sender As Object, e As EventArgs) Handles BtnMove.Click
        PictureBox1.Image = PictureBox2.Image
        PictureBox2.Image = Nothing
        PictureBox2.Invalidate()
        BtnMove.Enabled = False
        BtnSave.Enabled = False
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        PictureBox1.Image = oriGbr
    End Sub

    Private Sub BtnGS_Click(sender As Object, e As EventArgs) Handles BtnGS.Click
        Call Proses()
        Call Grayscl()
    End Sub

    Private Sub BtnBiner_Click(sender As Object, e As EventArgs) Handles BtnBiner.Click
        Call Proses()
        Call Biner()
    End Sub

    Private Sub BtnNeg_Click(sender As Object, e As EventArgs) Handles BtnNeg.Click
        Call Proses()
        Call Negatif()
    End Sub

    Private Sub BtnThres_Click(sender As Object, e As EventArgs) Handles BtnThres.Click
        GroupBox1.Visible = True
        Label1.Visible = True
        Label1.Text = "Nilai Thresholding"
        TextBox1.Visible = True

        If TextBox1.Text = "" Then
            MsgBox("Silahkan masukkan Nilai Thresholding")
            Call NoEnable()
            BtnThres.Enabled = True
        Else
            Call Proses()
            Call Thresholding()
            Call AllEnable()
        End If
    End Sub

    Private Sub BtnBright_Click(sender As Object, e As EventArgs) Handles BtnBright.Click
        GroupBox1.Visible = True
        Label1.Visible = True
        Label1.Text = "Nilai Brightness"
        HScrollBar1.Visible = True
        TxtHscrol.Visible = True

        If TxtHscrol.Text = "" Then
            MsgBox("Silahkan masukkan Nilai Brightness")
            Call NoEnable()
            BtnBright.Enabled = True
        Else
            Call Proses()
            Call Bright()
            Call AllEnable()
        End If
    End Sub

    
    Private Sub BtnRGB_Click(sender As Object, e As EventArgs) Handles BtnRGB.Click
        GroupBox1.Visible = True
        Label1.Visible = True
        Label1.Text = "Nilai Red"
        TextBox1.Visible = True
        Label2.Visible = True
        Label2.Text = "Nilai Green"
        TextBox2.Visible = True
        Label3.Visible = True
        Label3.Text = "Nilai Blue"
        TextBox3.Visible = True

        If TextBox1.Text = "" Then
            MsgBox("Silahkan masukkan Nilai Red")
            Call NoEnable()
            BtnRGB.Enabled = True
        ElseIf TextBox2.Text = "" Then
            MsgBox("Silahkan masukkan Nilai Green")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Silahkan masukkan Nilai Blue")
        Else
            Call Proses()
            Call RGB()
            Call AllEnable()
        End If
    End Sub

    Private Sub BtnKon1_Click(sender As Object, e As EventArgs) Handles BtnKon1.Click
        GroupBox1.Visible = True
        Label1.Visible = True
        Label1.Text = "Koef Penguat Kontras"
        TextBox1.Visible = True
        Label2.Visible = True
        Label2.Text = "Nilai Pusat GraySCale"
        TextBox2.Visible = True

        If TextBox1.Text = "" Then
            MsgBox("Silahkan masukkan Koefisien Penguat Kontras")
            Call NoEnable()
            BtnKon1.Enabled = True
        ElseIf TextBox2.Text = "" Then
            MsgBox("Silahkan masukkan Nilai Pusat GraySCale")
        Else
            Call Proses()
            Call Kontras1()
            Call AllEnable()
        End If
    End Sub

    Private Sub BtnKon2_Click(sender As Object, e As EventArgs) Handles BtnKon2.Click
        Call Proses()
        Call Kontras2()
    End Sub

    Sub Pict2()
        BtnSave.Enabled = True
        BtnMove.Enabled = True
    End Sub

    Sub Proses()
        ProgressBar1.Visible = True
        ProgressBar1.Value = 0
    End Sub

    Sub Grayscl()
        Dim gambar As New Bitmap(PictureBox1.Image) 'Deklarasi variabel bErtipe bitmap
        PictureBox2.Image = gambar 'Meletakkan hasil pengolahan citra
        Dim baris, kolom As Integer 'Variabel Perulangan/looping
        Dim merah, hijau, biru As Integer 'Menampung ntensitas warna RGB
        Dim abu As Integer 'Menampung intensitas warna gray scale
        For baris = 0 To gambar.Width - 1
            For kolom = 0 To gambar.Height - 1
                merah = gambar.GetPixel(baris, kolom).R
                hijau = gambar.GetPixel(baris, kolom).G
                biru = gambar.GetPixel(baris, kolom).B
                abu = Int(merah + hijau + biru) / 3 'rumus GS = (R+G+B)/3
                gambar.SetPixel(baris, kolom, Color.FromArgb(abu, abu, abu))
            Next
            ProgressBar1.Increment(1)
        Next
        PictureBox2.Refresh()
        Call Pict2()
    End Sub

    Sub Biner()
        Dim gambar As New Bitmap(PictureBox1.Image) 'Deklarasi variabel brtipe bitmap
        PictureBox2.Image = gambar 'Meletakkan hasil pengolahan citra
        Dim baris, kolom As Integer 'Variabel Perulangan/looping
        Dim merah, hijau, biru As Integer 'Menampung ntensitas warna RGB
        Dim abu As Integer 'Menampung intensitas warna gray scale

        For baris = 0 To gambar.Width - 1
            For kolom = 0 To gambar.Height - 1
                merah = gambar.GetPixel(baris, kolom).R
                hijau = gambar.GetPixel(baris, kolom).G
                biru = gambar.GetPixel(baris, kolom).B
                abu = Int(merah + hijau + biru) / 3 'rumus GS = (R+G+B)/3
                If abu >= 128 Then
                    abu = 255
                Else
                    abu = 0
                End If
                gambar.SetPixel(baris, kolom, Color.FromArgb(abu, abu, abu))
            Next
            ProgressBar1.Increment(1)
        Next
        PictureBox2.Refresh()
        Call Pict2()
    End Sub

    Sub Negatif()
        Dim gambar As New Bitmap(PictureBox1.Image) 'Deklarasi variabel brtipe bitmap
        PictureBox2.Image = gambar 'Meletakkan hasil pengolahan citra
        Dim baris, kolom As Integer 'Variabel Perulangan/looping
        Dim merah, hijau, biru As Integer 'Menampung ntensitas warna RGB

        For baris = 0 To gambar.Width - 1
            For kolom = 0 To gambar.Height - 1
                merah = 255 - (gambar.GetPixel(baris, kolom).R)
                hijau = 255 - (gambar.GetPixel(baris, kolom).G)
                biru = 255 - (gambar.GetPixel(baris, kolom).B)
                gambar.SetPixel(baris, kolom, Color.FromArgb(merah, hijau, biru))
            Next
            ProgressBar1.Increment(1)
        Next
        PictureBox2.Refresh()
        Call Pict2()
    End Sub

    Sub Thresholding()
        Dim gambar As New Bitmap(PictureBox1.Image) 'Deklarasi variabel brtipe bitmap
        PictureBox2.Image = gambar 'Meletakkan hasil pengolahan citra
        Dim baris, kolom As Integer 'Variabel Perulangan/looping
        Dim merah, hijau, biru As Integer 'Menampung ntensitas warna RGB
        Dim T As Integer
        T = TextBox1.Text


        For baris = 0 To gambar.Width - 1
            For kolom = 0 To gambar.Height - 1
                merah = gambar.GetPixel(baris, kolom).R
                hijau = gambar.GetPixel(baris, kolom).G
                biru = gambar.GetPixel(baris, kolom).B
                If merah >= T Then
                    merah = 255
                Else
                    merah = 0
                End If
                If biru >= T Then
                    biru = 255
                Else
                    biru = 0
                End If
                If hijau >= T Then
                    hijau = 255
                Else
                    hijau = 0
                End If
                gambar.SetPixel(baris, kolom, Color.FromArgb(merah, hijau, biru))
            Next
            ProgressBar1.Increment(1)
        Next
        PictureBox2.Refresh()
        Call Pict2()
        TextBox1.Clear()
        Label1.Visible = False
        TextBox1.Visible = False
        GroupBox1.Visible = False
    End Sub

    Sub RGB()
        Dim gambar As New Bitmap(PictureBox1.Image) 'Deklarasi variabel brtipe bitmap
        PictureBox2.Image = gambar 'Meletakkan hasil pengolahan citra
        Dim baris, kolom As Integer 'Variabel Perulangan/looping
        Dim merah, hijau, biru As Integer 'Menampung ntensitas warna RGB

        For baris = 0 To gambar.Width - 1
            For kolom = 0 To gambar.Height - 1
                merah = gambar.GetPixel(baris, kolom).R + TextBox1.Text
                hijau = gambar.GetPixel(baris, kolom).G + TextBox2.Text
                biru = gambar.GetPixel(baris, kolom).B + TextBox3.Text
                If merah > 255 Then merah = 255
                If biru > 255 Then biru = 255
                If hijau > 255 Then hijau = 255
                If merah < 0 Then merah = 0
                If biru < 0 Then biru = 0
                If hijau < 0 Then hijau = 0
                gambar.SetPixel(baris, kolom, Color.FromArgb(merah, hijau, biru))
            Next
            ProgressBar1.Increment(1)
        Next
        PictureBox2.Refresh()
        Call Pict2()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label1.Visible = False
        TextBox1.Visible = False
        Label2.Visible = False
        TextBox2.Visible = False
        Label3.Visible = False
        TextBox3.Visible = False
        GroupBox1.Visible = False
    End Sub

    Sub Bright()
        Dim gambar As New Bitmap(PictureBox1.Image) 'Deklarasi variabel brtipe bitmap
        PictureBox2.Image = gambar 'Meletakkan hasil pengolahan citra
        Dim baris, kolom As Integer 'Variabel Perulangan/looping
        Dim merah, hijau, biru As Integer 'Menampung ntensitas warna RGB
        Dim b As Integer = TxtHscrol.Text
        For baris = 0 To gambar.Width - 1
            For kolom = 0 To gambar.Height - 1
                merah = gambar.GetPixel(baris, kolom).R + b
                hijau = gambar.GetPixel(baris, kolom).G + b
                biru = gambar.GetPixel(baris, kolom).B + b
                If merah > 255 Then merah = 255
                If biru > 255 Then biru = 255
                If hijau > 255 Then hijau = 255
                If merah < 0 Then merah = 0
                If biru < 0 Then biru = 0
                If hijau < 0 Then hijau = 0
                gambar.SetPixel(baris, kolom, Color.FromArgb(merah, hijau, biru))
            Next
            ProgressBar1.Increment(1)
        Next
        PictureBox2.Refresh()
        Call Pict2()
        TxtHscrol.Clear()
        Label1.Visible = False
        TxtHscrol.Visible = False
        HScrollBar1.Visible = False
        GroupBox1.Visible = False
    End Sub

    Sub Kontras1()
        Dim gambar As New Bitmap(PictureBox1.Image) 'Deklarasi variabel brtipe bitmap
        PictureBox2.Image = gambar 'Meletakkan hasil pengolahan citra
        Dim baris, kolom As Integer 'Variabel Perulangan/looping
        Dim merah, hijau, biru As Integer 'Menampung ntensitas warna RGB
        Dim c, p As Integer
        c = TextBox1.Text
        p = TextBox2.Text


        For baris = 0 To gambar.Width - 1
            For kolom = 0 To gambar.Height - 1
                merah = c * (gambar.GetPixel(baris, kolom).R - p) + p
                hijau = c * (gambar.GetPixel(baris, kolom).G - p) + p
                biru = c * (gambar.GetPixel(baris, kolom).B - p) + p
                If merah > 255 Then merah = 255
                If biru > 255 Then biru = 255
                If hijau > 255 Then hijau = 255
                If merah < 0 Then merah = 0
                If biru < 0 Then biru = 0
                If hijau < 0 Then hijau = 0
                gambar.SetPixel(baris, kolom, Color.FromArgb(merah, hijau, biru))
            Next
            ProgressBar1.Increment(1)
        Next
        PictureBox2.Refresh()
        Call Pict2()
        TextBox1.Clear()
        TextBox2.Clear()
        Label1.Visible = False
        TextBox1.Visible = False
        Label2.Visible = False
        TextBox2.Visible = False

        GroupBox1.Visible = False
    End Sub
    Sub Kontras2()
        Dim gambar As New Bitmap(PictureBox1.Image) 'Deklarasi variabel brtipe bitmap
        PictureBox2.Image = gambar 'Meletakkan hasil pengolahan citra
        Dim baris, kolom As Integer 'Variabel Perulangan/looping
        Dim merah, hijau, biru As Integer 'Menampung ntensitas warna RGB
        Dim max, conm, conh, conb As Integer
        max = 0

        For baris = 0 To gambar.Width - 1
            For kolom = 0 To gambar.Height - 1
                merah = gambar.GetPixel(baris, kolom).R
                hijau = gambar.GetPixel(baris, kolom).G
                biru = gambar.GetPixel(baris, kolom).B
                If merah > max Then
                    max = merah
                ElseIf biru > max Then
                    max = biru
                ElseIf hijau > max Then
                    max = hijau
                End If
            Next
        Next

        For baris = 0 To gambar.Width - 1
            For kolom = 0 To gambar.Height - 1
                merah = gambar.GetPixel(baris, kolom).R
                hijau = gambar.GetPixel(baris, kolom).G
                biru = gambar.GetPixel(baris, kolom).B
                conm = merah + (merah * ((255 - max) / max))
                conh = hijau + (hijau * ((255 - max) / max))
                conb = biru + (biru * ((255 - max) / max))
                gambar.SetPixel(baris, kolom, Color.FromArgb(conm, conh, conb))
            Next
            ProgressBar1.Increment(1)
        Next
        PictureBox2.Refresh()
        Call Pict2()
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        HScrollBar1.Minimum = -255
        HScrollBar1.Maximum = 264
        TxtHscrol.Text = HScrollBar1.Value
    End Sub

    Sub NoEnable()
        BtnGS.Enabled = False
        BtnNeg.Enabled = False
        BtnThres.Enabled = False
        BtnBiner.Enabled = False
        BtnBright.Enabled = False
        BtnKon1.Enabled = False
        BtnRGB.Enabled = False
        BtnKon2.Enabled = False
    End Sub

    Sub AllEnable()
        BtnGS.Enabled = True
        BtnNeg.Enabled = True
        BtnThres.Enabled = True
        BtnBiner.Enabled = True
        BtnBright.Enabled = True
        BtnKon1.Enabled = True
        BtnRGB.Enabled = True
        BtnKon2.Enabled = True
    End Sub

End Class