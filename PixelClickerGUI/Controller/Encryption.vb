Imports System.IO
Imports System.Runtime.Serialization
Imports System.Security.Cryptography
Imports System.Text

Namespace Controller
    Public Class AESEncryption
        Private ReadOnly fKey As Byte()
        Private ReadOnly fIV As Byte()
        Private ReadOnly fBitSize As Integer
        Private Shared ReadOnly fKeySizes As List(Of Integer)
        Private Shared ReadOnly fBlockSizes As List(Of Integer)

        Shared Sub New()
            Using aes = New AesCryptoServiceProvider()
                Dim temp = New List(Of Integer)()
                For Each keysize As KeySizes In aes.LegalKeySizes
                    Dim i As Integer = keysize.MinSize
                    While i <= keysize.MaxSize
                        If Not temp.Contains(i) Then temp.Add(i)
                        If i = keysize.MaxSize Then Exit While
                        i += keysize.SkipSize
                    End While
                Next
                fKeySizes = temp

                temp = New List(Of Integer)()
                For Each keysize As KeySizes In aes.LegalBlockSizes
                    Dim i As Integer = keysize.MinSize
                    While i <= keysize.MaxSize
                        If Not temp.Contains(i) Then temp.Add(i)
                        If i = keysize.MaxSize Then Exit While
                        i += keysize.SkipSize
                    End While
                Next
                fBlockSizes = temp
            End Using
        End Sub

        Public Sub New(ByVal Key As Byte(), ByVal InitializationVector As Byte())
            Try
                Dim keySizes As String = fKeySizes.Aggregate("", Function(current, i) String.Format("{0}{1}, ", current, i))
                keySizes = keySizes.Remove(keySizes.Length - 3)

                Dim blockSizes As String = fBlockSizes.Aggregate("", Function(current, i) String.Format("{0}, ", current, i))
                blockSizes = blockSizes.Remove(blockSizes.Length - 3)

                fKey = Key
                fIV = InitializationVector
                fBitSize = fKey.Length * 8
            Catch ex As ArgumentException
                Throw New EncryptionException(ex.Message, ex)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub New(ByVal Key As String, ByVal BitSize As Integer)
            Try
                Dim keySizes As String = fKeySizes.Aggregate("", Function(current, i) String.Format("{0}{1}, ", current, i))
                keySizes = keySizes.Remove(keySizes.Length - 3)

                Dim entropy As Byte() = Encoding.UTF32.GetBytes(Key)
                Using hmacsha512 = New HMACSHA512(Convert.FromBase64String("i88NEiez3c50bHqr3YGasDc4p8jRrxJAaiRiqixpvp4XNAStP5YNoC2fXnWkURtkha6M8yY901Gj07IRVIRyGL==")) With {.ProduceLegacyHmacValues = True}
                    hmacsha512.Initialize()
                    For i As Integer = 0 To 999
                        entropy = hmacsha512.ComputeHash(entropy)
                    Next
                End Using

                Dim keylen As Integer = BitSize / 8
                fKey = New Byte(keylen - 1) {}
                Buffer.BlockCopy(entropy, 0, fKey, 0, keylen)
                fIV = New Byte(fBlockSizes(0) / 8 - 1) {}

                Buffer.BlockCopy(entropy, entropy.Length - fIV.Length - 1, fIV, 0, fIV.Length)
                fBitSize = BitSize
            Catch ex As ArgumentException
                Throw New EncryptionException(ex.Message, ex)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub New(ByVal Key As String)
            Me.New(Key, fKeySizes.Max())
        End Sub

        Public Function Encrypt(ByVal Data As Object) As Byte()
            Try
                Dim m_encrypted As Byte()
                Using aesCryptoServiceProvider = New AesCryptoServiceProvider() With {.KeySize = fBitSize, .Mode = CipherMode.CBC}
                    Using cryptoTransform = aesCryptoServiceProvider.CreateEncryptor(fKey, fIV)
                        Using memoryStream = New MemoryStream()
                            Using cryptoStream = New CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write)
                                Using swStream = New StreamWriter(cryptoStream)
                                    swStream.Write(Data)
                                End Using
                            End Using
                            m_encrypted = memoryStream.ToArray()
                        End Using
                    End Using
                End Using
                Return m_encrypted
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function Decrypt(ByVal Data As Byte()) As Object
            Try
                Dim m_decrypted As Object = Nothing
                Using aesCryptoServiceProvider = New AesCryptoServiceProvider() With {.KeySize = fBitSize, .Mode = CipherMode.CBC}
                    Using cryptoTransform = aesCryptoServiceProvider.CreateDecryptor(fKey, fIV)
                        Using memoryStream = New MemoryStream(Data)
                            Using cryptoStream = New CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read)
                                Using srStream = New StreamReader(cryptoStream)
                                    m_decrypted = srStream.ReadToEnd()
                                End Using
                            End Using
                        End Using
                    End Using
                End Using
                Return m_decrypted
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
    End Class

    Public NotInheritable Class EncryptionException
        Inherits Exception
        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub

        Public Sub New(ByVal message As String, ByVal inner As Exception)
            MyBase.New(message, inner)
        End Sub

        Private Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            MyBase.New(info, context)
        End Sub

        <Conditional("DEBUG")> _
        Public Shared Sub Assert(ByVal isOk As Boolean, Optional ByVal message As String = "")
            If Not isOk Then
                If String.IsNullOrEmpty(message) Then
                    Throw New EncryptionException()
                Else
                    Throw New EncryptionException(message)
                End If
            End If
        End Sub
    End Class
End Namespace