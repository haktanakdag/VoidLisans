Public Class Form1
    Private Sub btnLisansOlustur_Click(sender As Object, e As EventArgs) Handles btnLisansOlustur.Click
        If txtSeriNo.Text = "" Then
            MessageBox.Show("Seri No Boş olamaz")
        Else
            Dim serino As String = Decrypt(txtSeriNo.Text, "4524423423523423")
            'MessageBox.Show(serino)
            Dim yeniserino As String = Encrypt(serino, "344342132234543")
            txtLisansNo.Text = yeniserino

        End If
    End Sub
    Function SayilariCikart(lisansseri As String) As String
        Dim lisansarr As Array = lisansseri.ToCharArray()
        Dim karakterler As Integer = 0
        For Each r As Char In lisansarr
            If IsNumeric(r) = True Then
                karakterler = karakterler - Convert.ToInt32(r)
            End If
        Next r
        Return karakterler.ToString
    End Function
    Function SayilariTopla(lisansseri As String) As String
        Dim lisansarr As Array = lisansseri.ToCharArray()
        Dim karakterler As Integer = 0
        For Each r As Char In lisansarr
            If IsNumeric(r) = True Then
                karakterler = karakterler + Convert.ToInt32(r)
            End If
        Next r
        Return karakterler.ToString
    End Function
    Function SayilariBirlestir(lisansseri As String) As String
        Dim lisansarr As Array = lisansseri.ToCharArray()
        Dim sayilar As String = ""
        For Each r As Char In lisansarr
            If IsNumeric(r) = True Then
                sayilar = sayilar & r.ToString
            End If
        Next r

        Return sayilar.ToString
    End Function

    Public Function Encrypt(text As String, password As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Dim hash(31) As Byte
        Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password))
        Array.Copy(temp, 0, hash, 0, 16)
        Array.Copy(temp, 0, hash, 15, 16)
        AES.Key = hash
        AES.Mode = Security.Cryptography.CipherMode.ECB
        Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(text)
        encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Return encrypted
    End Function
    Public Function Decrypt(text As String, password As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Dim hash(31) As Byte
        Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password))
        Array.Copy(temp, 0, hash, 0, 16)
        Array.Copy(temp, 0, hash, 15, 16)
        AES.Key = hash
        AES.Mode = Security.Cryptography.CipherMode.ECB
        Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
        Dim Buffer As Byte() = Convert.FromBase64String(text)
        Dim lisansvar As Boolean = False
        Try
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            lisansvar = True
        Catch ex As Exception
            lisansvar = False
        End Try
        If lisansvar = False Then
            decrypted = "lisansyok"
        End If
        Return decrypted
    End Function

    Private Sub btnYapistir_Click(sender As Object, e As EventArgs) Handles btnYapistir.Click
        txtSeriNo.Text = Clipboard.GetText
    End Sub

    Private Sub btnKopyala_Click(sender As Object, e As EventArgs) Handles btnKopyala.Click
        If txtLisansNo.Text = "" Then
            MessageBox.Show("Lisans Numarası boş lütfen lisans oluşturunuz.")
        Else
            Clipboard.SetText(txtLisansNo.Text)
        End If
    End Sub
End Class
