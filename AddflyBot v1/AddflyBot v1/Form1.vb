
Imports System.Net

Public Class Form1
    Dim url As String
    Dim load As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        url = TextBox1.Text

        MessageBox.Show("Nav var set!")



    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.ScriptErrorsSuppressed = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim clsProxy As New IEProxy
        If clsProxy.DisableProxy Then
            MessageBox.Show("Proxy successfully disabled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error disabling proxy.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Start()




    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Public RotateCount = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RotateCount += 1
        TextBox5.Text = RotateCount
        TextBox4.Text = RichTextBox1.Lines(RotateCount)
        Dim clsProxy As New IEProxy
        If clsProxy.SetProxy(TextBox4.Text) Then
            MessageBox.Show("Proxy successfully enabled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error enabling proxy.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        WebBrowser1.Navigate(url)
       
        


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer1.Stop()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Timer2.Start()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        System.Threading.Thread.Sleep(5000)
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Timer2.Start()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Timer2.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim allelement As HtmlElementCollection = WebBrowser1.Document.All
        For Each webpageelement As HtmlElement In allelement
            If webpageelement.GetAttribute("id") = "skip_ad_button" Then
                webpageelement.InvokeMember("click")
            End If
        Next

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = url
    End Sub

    

    
    
 
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        WebBrowser1.Navigate(url)
    End Sub
End Class

