Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Net.Security
Imports System.Security.Cryptography
Imports System.Security.Cryptography.Pkcs
Imports System.Security.Cryptography.X509Certificates

Public Class Form1

    Dim keyPath As String = "key.p12"
    Dim keyPass As String = "b2buat"

    Public Function AcceptAllCertifications(ByVal sender As Object, ByVal certification As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxRequest.Text = "<PaymentInfoMessage>"
        TextBoxRequest.Text = TextBoxRequest.Text & vbCrLf & "<PaymentInfoRequest>"
        TextBoxRequest.Text = TextBoxRequest.Text & vbCrLf & "<BankCode>RIBLSARI</BankCode>"
        TextBoxRequest.Text = TextBoxRequest.Text & vbCrLf & "<CompanyCode>IJARAH</CompanyCode>"
        TextBoxRequest.Text = TextBoxRequest.Text & vbCrLf & "<StartDate>" & Format(System.DateTime.Now, "yyyy-MM-dd") & "T00:00:00</StartDate>"
        TextBoxRequest.Text = TextBoxRequest.Text & vbCrLf & "<EndDate>" & Format(System.DateTime.Now, "yyyy-MM-dd") & "T00:00:00</EndDate>"
        TextBoxRequest.Text = TextBoxRequest.Text & vbCrLf & "<TransactionType>940</TransactionType>"
        TextBoxRequest.Text = TextBoxRequest.Text & vbCrLf & "</PaymentInfoRequest>"
        TextBoxRequest.Text = TextBoxRequest.Text & vbCrLf & "</PaymentInfoMessage>"
    End Sub

    Private Sub ButtonPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPost.Click
        Try
            Dim encoding As New UTF8Encoding
            Dim bytesToWrite As Byte() = encoding.GetBytes(TextBoxRequest.Text)

            Dim url As String = "https://rbb2btest.riyadbank.com/b2b/epay2"
            Dim request As HttpWebRequest = DirectCast(HttpWebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.ContentLength = bytesToWrite.Length
            request.ContentType = "text/xml; charset=utf-8"
            ' request.ClientCertificates.Add(New X509Certificate2(@"C:\ijarahcert\key.p12", "b2buat"))
            request.ClientCertificates.Add(New X509Certificate2("C:\ijarahcert\key.p12", "b2buat"))
            'request.ClientCertificates.Add(New X509Certificate2(keyPath, keyPass))

            ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications

            Dim newStream As Stream = request.GetRequestStream()
            newStream.Write(bytesToWrite, 0, bytesToWrite.Length)
            newStream.Close()

            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            responseFromServer = Replace(responseFromServer, "><", ">" & vbCrLf & "<")

            TextBoxResult.Text = responseFromServer
        Catch ex As Exception
            TextBoxResult.Text = ex.Message
        End Try
    End Sub

End Class
