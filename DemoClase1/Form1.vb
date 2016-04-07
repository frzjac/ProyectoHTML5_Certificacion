Public Class Form1
    Dim facturas As New Factura



    Private Sub btnBlanquearFactura_Click(sender As Object, e As EventArgs) Handles btnBlanquearFactura.Click
        Call Blanquear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Function Validarfactura() As Boolean
        Validarfactura = True
        If Len(Trim(Me.txbNoFactura.Text)) = 0 Then Validarfactura = False
        If Len(Trim(Me.txbProductos.Text)) = 0 Then Validarfactura = False
        If Len(Trim(Me.tbxNombreCliente.Text)) = 0 Then Validarfactura = False
        If Len(Trim(Me.tbxNombreVendedor.Text)) = 0 Then Validarfactura = False
        If Len(Trim(Me.tbxValorVenta.Text)) = 0 Then Validarfactura = False
    End Function

    Private Sub Blanquear()
        Me.tbxNombreCliente.Clear()
        Me.txbNoFactura.Clear()
        Me.txbProductos.Clear()
        Me.tbxNombreVendedor.Clear()
        Me.tbxValorVenta.Clear()
        Me.dtpFechaFactura.Value = Today
        Me.dtpFechaPago.Value = Today
        Me.tbxValorVenta.Text = Format(0, "$ ##,##00.00")
        Me.tbxValorVenta.TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub btnGuardarFactura_Click(sender As Object, e As EventArgs) Handles btnGuardarFactura.Click
        If Validarfactura() Then
            MessageBox.Show("Dattos Correctos")
            Call Blanquear()
        Else
            MessageBox.Show("error")
        End If
    End Sub

    Private Sub tbxValorVenta_Validated(sender As Object, e As EventArgs) Handles tbxValorVenta.Validated
        If IsNumeric(Me.tbxValorVenta.Text) Then
            tbxValorVenta.Text = Format(CDec(tbxValorVenta.Text), "$ ##,##0.00")

        Else
            tbxValorVenta.Text = Format(0, "$ ##,##0.00")
        End If
        tbxValorVenta.TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call Blanquear()
    End Sub
End Class
