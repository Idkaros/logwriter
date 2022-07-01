Imports System.Data.SqlClient
Imports SAPbouiCOM
Public Class LogWriter
    'BEGIN: grupo #1
    Public Shared Sub WriteLog(ByVal pMensaje As String)
        Try
            Microsoft.VisualBasic.FileIO.FileSystem.WriteAllText(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Exxis_log_" & Today.ToString("yyyyMM") & ".txt",
                                                                 pMensaje,
                                                                 True)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteLog(ByVal pMensaje As String, ByRef pStatusBar As SAPbouiCOM.StatusBar)
        Try
            WriteLog(pMensaje)
            pStatusBar.SetText(pMensaje, BoMessageTime.bmt_Medium, BoStatusBarMessageType.smt_Warning)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteLog(ByVal pMensaje As String, ByRef pStatusBar As SAPbouiCOM.StatusBar, ByVal pMessageTime As BoMessageTime)
        Try
            WriteLog(pMensaje)
            pStatusBar.SetText(pMensaje, pMessageTime, BoStatusBarMessageType.smt_Warning)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteLog(ByVal pMensaje As String, ByRef pStatusBar As SAPbouiCOM.StatusBar, ByVal pMessageTime As BoMessageTime, ByVal pStatusMessageType As BoStatusBarMessageType)
        Try
            WriteLog(pMensaje)
            pStatusBar.SetText(pMensaje, pMessageTime, pStatusMessageType)
        Catch ex As Exception

        End Try
    End Sub
    'END:

    'BEGIN: grupo #2
    Public Shared Sub WriteLog(ByVal e As Excepcion)
        Try
            WriteLog(e.Message())
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteLog(ByVal e As Excepcion, ByRef pStatusBar As SAPbouiCOM.StatusBar)
        Try
            WriteLog(e.Message())
            pStatusBar.SetText(e.Message(), BoMessageTime.bmt_Medium, BoStatusBarMessageType.smt_Warning)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteLog(ByVal e As Excepcion, ByRef pStatusBar As SAPbouiCOM.StatusBar, ByVal pMessageTime As BoMessageTime)
        Try
            WriteLog(e.Message())
            pStatusBar.SetText(e.Message(), pMessageTime, BoStatusBarMessageType.smt_Warning)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteLog(ByVal e As Excepcion, ByRef pStatusBar As SAPbouiCOM.StatusBar, ByVal pMessageTime As BoMessageTime, ByVal pStatusMessageType As BoStatusBarMessageType)
        Try
            WriteLog(e.Message())
            pStatusBar.SetText(e.Message(), pMessageTime, pStatusMessageType)
        Catch ex As Exception

        End Try
    End Sub
    'END:

    'BEGIN: grupo #3
    Public Shared Sub WriteLog(ByVal e As Exception)
        Try
            WriteLog(e.StackTrace())
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteLog(ByVal e As Exception, ByRef pStatusBar As SAPbouiCOM.StatusBar)
        Try
            WriteLog(e.StackTrace())
            pStatusBar.SetText(e.StackTrace(), BoMessageTime.bmt_Medium, BoStatusBarMessageType.smt_Warning)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteLog(ByVal e As Exception, ByRef pStatusBar As SAPbouiCOM.StatusBar, ByVal pMessageTime As BoMessageTime)
        Try
            WriteLog(e.StackTrace())
            pStatusBar.SetText(e.StackTrace(), pMessageTime, BoStatusBarMessageType.smt_Warning)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteLog(ByVal e As Exception, ByRef pStatusBar As SAPbouiCOM.StatusBar, ByVal pMessageTime As BoMessageTime, ByVal pStatusMessageType As BoStatusBarMessageType)
        Try
            WriteLog(e.StackTrace())
            pStatusBar.SetText(e.StackTrace(), pMessageTime, pStatusMessageType)
        Catch ex As Exception

        End Try
    End Sub
    'END:

    'BEGIN: grupo #4
    Public Shared Sub WriteLog(ByVal e As SqlException)
        Try
            WriteLog(e.StackTrace())
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteLog(ByVal e As SqlException, ByRef pStatusBar As SAPbouiCOM.StatusBar)
        Try
            WriteLog(e.StackTrace())
            pStatusBar.SetText(e.StackTrace(), BoMessageTime.bmt_Medium, BoStatusBarMessageType.smt_Warning)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteLog(ByVal e As SqlException, ByRef pStatusBar As SAPbouiCOM.StatusBar, ByVal pMessageTime As BoMessageTime)
        Try
            WriteLog(e.StackTrace())
            pStatusBar.SetText(e.StackTrace(), pMessageTime, BoStatusBarMessageType.smt_Warning)
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub WriteLog(ByVal e As SqlException, ByRef pStatusBar As SAPbouiCOM.StatusBar, ByVal pMessageTime As BoMessageTime, ByVal pStatusMessageType As BoStatusBarMessageType)
        Try
            WriteLog(e.StackTrace())
            pStatusBar.SetText(e.StackTrace(), pMessageTime, pStatusMessageType)
        Catch ex As Exception

        End Try
    End Sub
    'END:
End Class
