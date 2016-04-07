Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Data
    Dim cn As New SqlClient.SqlConnection
    Sub New()
        cn.ConnectionString = "Data Source=SERVIDOR;Initial Catalog=Transaccionla;Securitu Integrated=True"
    End Sub

    Protected Overrides Sub finalize()

    End Sub
End Class
