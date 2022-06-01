Imports System.Data.SqlClient
Imports SAPbouiCOM
Public Class LogWriter

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
End Class
