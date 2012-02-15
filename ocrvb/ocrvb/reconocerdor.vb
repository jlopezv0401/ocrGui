Public Class reconocerdor
    Public ocrCom As New ocr.ocrMain
    Public Event terminaReconocer(ByVal salida As String)
    Public Sub Reconociendo()
        Dim textoReconocido As String
        ocrCom.ruta = My.Computer.FileSystem.CurrentDirectory & "\linea.bmp"
        ocrCom.relacion = "1.3"
        ocrCom.base = My.Computer.FileSystem.CurrentDirectory & "\courierarial40x29.csv"
        ocrCom.patxclase = "6"
        ocrCom.nclases = "80"
        ocrCom.umbralinc = "17"
        ocrCom.altoinc = "8"
        ocrCom.normalto = "40"
        ocrCom.normancho = "29"
        ocrCom.ocr(0, 0)
        textoReconocido = ocrCom.exto
        RaiseEvent terminaReconocer(textoReconocido)
    End Sub

End Class
