Public Class Factura
    Dim oNoFactura As Integer
    Dim oNombreCliente As String
    Dim oNombreVendedor As String
    Dim oFechafactura As Date
    Dim oFechapago As Date
    Dim oProducto As String

    Property NoFactura As Integer
        Get
            Return oNoFactura
        End Get
        Set(value As Integer)
            oNoFactura = value
        End Set
    End Property

    Property NombreCliente As String
        Get
            Return oNombreCliente
        End Get
        Set(value As String)
            oNombreCliente = value
        End Set
    End Property

    Property NombreVendedor As String
        Get
            Return oNombreVendedor
        End Get
        Set(value As String)
            oNombreVendedor = value
        End Set
    End Property

    Property Fechafactura As Date
        Get
            Return oFechafactura
        End Get
        Set(value As Date)
            oFechafactura = value
        End Set
    End Property

    Property FechaPago As Date
        Get
            Return oFechapago
        End Get
        Set(value As Date)
            oFechapago = value

        End Set
    End Property

    Property Producto As String
        Get
            Return oProducto
        End Get
        Set(value As String)
            oProducto = value
        End Set
    End Property
End Class
