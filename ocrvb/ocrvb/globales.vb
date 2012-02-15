Module globales

    Public rutaImagen As String
    Public relacion As String
    Public rutaBase As String
    Public patxClase As String
    Public nClases As String
    Public umbralInc As String
    Public altoInc As String
    Public normAlto As String
    Public normAncho As String

    Public Sub selRutaBase(ByRef valor As Integer)
        If valor = 0 Then
            rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courier35x25.csv"
        ElseIf valor = 1 Then
            rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courier40x29.csv"
        ElseIf valor = 2 Then
            rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\arial35x25.csv"
        ElseIf valor = 3 Then
            rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\arial40x29.csv"
        ElseIf valor = 4 Then
            rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courierarial30x21.csv"
        ElseIf valor = 5 Then
            rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courierarial35x25.csv"
        ElseIf valor = 6 Then
            rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courierarial40x29.csv"
        ElseIf valor = 7 Then
            rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courier6x35x25.csv"
        ElseIf valor = 8 Then
            rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courier35x2590.csv"
        End If
    End Sub

End Module
