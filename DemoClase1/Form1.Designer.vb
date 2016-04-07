<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBlanquearFactura = New System.Windows.Forms.Button()
        Me.txbNoFactura = New System.Windows.Forms.TextBox()
        Me.btnGuardarFactura = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxNombreCliente = New System.Windows.Forms.TextBox()
        Me.tbxNombreVendedor = New System.Windows.Forms.TextBox()
        Me.dtpFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbProductos = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxValorVenta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBlanquearFactura
        '
        Me.btnBlanquearFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBlanquearFactura.Location = New System.Drawing.Point(268, 367)
        Me.btnBlanquearFactura.Name = "btnBlanquearFactura"
        Me.btnBlanquearFactura.Size = New System.Drawing.Size(100, 23)
        Me.btnBlanquearFactura.TabIndex = 9
        Me.btnBlanquearFactura.Text = "Blanquear"
        Me.btnBlanquearFactura.UseVisualStyleBackColor = True
        '
        'txbNoFactura
        '
        Me.txbNoFactura.Location = New System.Drawing.Point(248, 13)
        Me.txbNoFactura.Name = "txbNoFactura"
        Me.txbNoFactura.Size = New System.Drawing.Size(231, 20)
        Me.txbNoFactura.TabIndex = 1
        '
        'btnGuardarFactura
        '
        Me.btnGuardarFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarFactura.Location = New System.Drawing.Point(137, 367)
        Me.btnGuardarFactura.Name = "btnGuardarFactura"
        Me.btnGuardarFactura.Size = New System.Drawing.Size(125, 23)
        Me.btnGuardarFactura.TabIndex = 8
        Me.btnGuardarFactura.Text = "Guardar"
        Me.btnGuardarFactura.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Entre el No de Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombres y Apellidos del Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombres y apelidos del Vendedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha de factura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fecha de pago"
        '
        'tbxNombreCliente
        '
        Me.tbxNombreCliente.Location = New System.Drawing.Point(164, 46)
        Me.tbxNombreCliente.Name = "tbxNombreCliente"
        Me.tbxNombreCliente.Size = New System.Drawing.Size(315, 20)
        Me.tbxNombreCliente.TabIndex = 2
        '
        'tbxNombreVendedor
        '
        Me.tbxNombreVendedor.Location = New System.Drawing.Point(184, 76)
        Me.tbxNombreVendedor.Name = "tbxNombreVendedor"
        Me.tbxNombreVendedor.Size = New System.Drawing.Size(295, 20)
        Me.tbxNombreVendedor.TabIndex = 3
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Location = New System.Drawing.Point(107, 103)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(372, 20)
        Me.dtpFechaFactura.TabIndex = 4
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Location = New System.Drawing.Point(107, 133)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(372, 20)
        Me.dtpFechaPago.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Producto"
        '
        'txbProductos
        '
        Me.txbProductos.AcceptsReturn = True
        Me.txbProductos.Location = New System.Drawing.Point(107, 159)
        Me.txbProductos.Multiline = True
        Me.txbProductos.Name = "txbProductos"
        Me.txbProductos.Size = New System.Drawing.Size(368, 103)
        Me.txbProductos.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(408, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Valor venta"
        '
        'tbxValorVenta
        '
        Me.tbxValorVenta.Location = New System.Drawing.Point(107, 284)
        Me.tbxValorVenta.Name = "tbxValorVenta"
        Me.tbxValorVenta.Size = New System.Drawing.Size(368, 20)
        Me.tbxValorVenta.TabIndex = 7
        Me.tbxValorVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 402)
        Me.Controls.Add(Me.tbxValorVenta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txbProductos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpFechaPago)
        Me.Controls.Add(Me.dtpFechaFactura)
        Me.Controls.Add(Me.tbxNombreVendedor)
        Me.Controls.Add(Me.tbxNombreCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardarFactura)
        Me.Controls.Add(Me.txbNoFactura)
        Me.Controls.Add(Me.btnBlanquearFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Venta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBlanquearFactura As System.Windows.Forms.Button
    Friend WithEvents txbNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarFactura As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbxNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents tbxNombreVendedor As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txbProductos As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbxValorVenta As System.Windows.Forms.TextBox

End Class
