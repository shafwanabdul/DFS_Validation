Option Explicit On
Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Text
Imports System.Math
Imports System.IO.Ports
Imports System.Net.Sockets
Imports System.Drawing
Imports System.Drawing.Graphics
Imports System.Globalization
Imports nethackrf
Imports nethackrf.HackRFStream
Imports nethackrf.NetHackrf
Imports System.Threading

Public Class FormDirect
    Dim clientSocket As New System.Net.Sockets.TcpClient
    Dim serverStream As NetworkStream
    Dim colors() As Color = {Color.SandyBrown, Color.SandyBrown, Color.SandyBrown, Color.SandyBrown, Color.SandyBrown, Color.SandyBrown, Color.SandyBrown, Color.SandyBrown}
    Dim outStream() As Byte
    Dim result As String = ""
    Dim Xaxmin, Xaxmax, Yaxmax, Yaxmin, FCval As Double
    Dim TCPconnected, TTconneced, dataexist, testingenable As Boolean
    Dim bmp As New Bitmap(410, 410)
    Dim RegisteredSPA As String = "DSA8E261100012"
    Private Sub FormDirect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TCPconnected = False
    End Sub

    Private Function SendTCP(ByVal CMD As String)
        TS_ETH_TX.Text = CMD
        If clientSocket.Connected = True Then
            clientSocket.ReceiveBufferSize = 64000
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream() As Byte = System.Text.Encoding.ASCII.GetBytes(CMD & vbCrLf)
            Dim inStream(clientSocket.ReceiveBufferSize) As Byte
            Dim StrList(65535) As String
            Dim returndata As String = ""
            serverStream.ReadTimeout = 1000
            serverStream.Write(outStream, 0, outStream.Length)
            returndata = ""
            Threading.Thread.Sleep(100)
            While serverStream.DataAvailable
                serverStream.Read(inStream, 0, inStream.GetUpperBound(0))
                returndata = returndata & String.Concat(returndata, Encoding.ASCII.GetString(inStream))
            End While
            StrList = returndata.Split(CChar(","))
            If StrList.Length = 601 Then
                dataexist = True
                TSrtxstat.Text = "SPA Link Status: OK"
            Else
                TSrtxstat.Text = "SPA Link Status: truncated"
            End If
            Return StrList
        Else
            dataexist = False
            TSrtxstat.Text = "SPA Link Status: Fail"
        End If
        Return 0
    End Function

    Private Sub BConnect_Click(sender As Object, e As EventArgs) Handles BConnect.Click
        If Not clientSocket.Connected Then
            clientSocket.Connect(TextIP.Text, CInt(Val(Val(TextPort.Text))))
            If CheckSN(1) < 1 Then
                MsgBox("License not Valid" & vbCrLf & "Licensed to RIGOL DSA-875-TG" & vbCrLf & RegisteredSPA)
                End
            End If
            SendcommandTCP("*RST")
            BConnect.Enabled = False
            If clientSocket.Connected Then
                TCPconnected = True
            End If
        End If
    End Sub

    Private Function SendcommandTCP(ByVal CMD As String)
        TS_ETH_TX.Text = CMD
        Dim serverStream As NetworkStream = clientSocket.GetStream()
        Dim inStream2(clientSocket.ReceiveBufferSize) As Byte
        outStream = System.Text.Encoding.ASCII.GetBytes(CMD & vbCrLf)
        serverStream.Write(outStream, 0, outStream.Length)
        While serverStream.DataAvailable
            serverStream.Read(inStream2, 0, CInt(Val(clientSocket.ReceiveBufferSize)))
        End While
        Threading.Thread.Sleep(750)
        Return 0
    End Function
    Private Function CheckSN(void) As Integer
        TS_ETH_TX.Text = "*IDN?"
        If clientSocket.Connected = True Then
            clientSocket.ReceiveBufferSize = 64000
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream() As Byte = System.Text.Encoding.ASCII.GetBytes("*IDN?" & vbCrLf)
            Dim inStream(clientSocket.ReceiveBufferSize) As Byte
            Dim StrList(65535) As String
            Dim StatusLic As Integer
            Dim returndata As String = ""
            StatusLic = 0
            serverStream.ReadTimeout = 1000
            serverStream.Write(outStream, 0, outStream.Length)
            returndata = ""
            Threading.Thread.Sleep(100)
            While serverStream.DataAvailable
                serverStream.Read(inStream, 0, inStream.GetUpperBound(0))
                returndata = returndata & String.Concat(returndata, Encoding.ASCII.GetString(inStream))
            End While
            StatusLic = InStr(returndata, RegisteredSPA)
            If StatusLic = 0 Then Return 0
            Return 1
        End If
    End Function

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LBDFFCenter_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbFrequency_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub GBSpecControl_Enter(sender As Object, e As EventArgs) Handles GBSpecControl.Enter

    End Sub

    Private Sub CBTGLvl_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CBTGLvl.SelectedIndexChanged

    End Sub

    Private Sub ButtonStartDFS_Click(sender As Object, e As EventArgs) Handles ButtonStartDFS.Click

    End Sub

    Private Sub ZedFAF_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub LTGLvl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CBTGLvl_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TBFCent_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

End Class