
Imports System.Net

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Dim proxyObject As New WebProxy("http://proxyserver:80/", True)
        Dim req As WebRequest = WebRequest.Create("http://www.contoso.com")
        req.Proxy = proxyObject
    End Sub
End Class
