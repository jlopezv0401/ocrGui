
Public Class Form1
    Public ocrCom As New ocr.ocrMain

    Dim imagenBmp As Bitmap

    Dim altoImagen As Integer
    Dim anchoImagen As Integer

    Dim reconocedor1 As New reconocerdor

    Dim textoReconocido As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        relacion = "1.3"
        selRutaBase(6)
        patxClase = "6"
        nClases = "80"
        umbralInc = "17"
        altoInc = "8"
        normAlto = "40"
        normAncho = "29"
        ToolStripStatusLabel1.Text = "Listo"

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click

        With OpenFileDialog1
            .Title = "OCR"
            .FileName = ""
            .Filter = "|*.bmp"
            Try
                .ShowDialog()
                rutaImagen = .FileName
                imagenBmp = DirectCast(Bitmap.FromFile(rutaImagen), Bitmap)
                PictureBox1.Image = imagenBmp

                Dim minScroll As System.Drawing.Size
                minScroll = PictureBox1.Image.Size
                Panel1.AutoScrollMinSize = minScroll
            Catch ex As Exception
                Exit Sub
            End Try
        End With

    End Sub

    Private Sub ReconocerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconocerToolStripMenuItem.Click

        If rutaImagen <> "" Then

            ocrCom.ruta = rutaImagen
            ocrCom.relacion = relacion
            ocrCom.base = rutaBase
            ocrCom.patxclase = patxClase
            ocrCom.nclases = nClases
            ocrCom.umbralinc = umbralInc
            ocrCom.altoinc = altoInc
            ocrCom.normalto = normAlto
            ocrCom.normancho = normAncho

            ToolStripStatusLabel1.Text = "Reconociendo"
            ocrCom.ocr(0, 0)
            textoReconocido = ocrCom.texto

            RichTextBox1.Text = textoReconocido.Replace("**+**", Environment.NewLine)
            If RichTextBox1.Text <> "" Then
                guardarBoton.Enabled = True
            End If

        End If
        ToolStripStatusLabel1.Text = "Listo"


        'ToolStripStatusLabel1.Text = "Reconociendo"
        'Dim hilo As New System.Threading.Thread(AddressOf reconocedor1.Reconociendo)
        'AddHandler reconocedor1.terminaReconocer, AddressOf terminaReconocerEventHandler
        'hilo.Start()

        'textoReconocido = reconocedor1.ocrCom.texto

    End Sub
    Sub terminaReconocerEventHandler(ByVal salida As String)

        textoReconocido = salida

        'RichTextBox1.Text = textoReconocido.Replace("**+**", Environment.NewLine)
        'If RichTextBox1.Text <> "" Then
        '    guardarBoton.Enabled = True
        'End If
        'hilo.Suspend()
        MsgBox(textoReconocido)
    End Sub

    Private Sub CargarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarToolStripMenuItem.Click

        imagenBmp = DirectCast(Bitmap.FromFile(rutaImagen), Bitmap)
        PictureBox1.Image = imagenBmp

        Dim minScroll As System.Drawing.Size
        minScroll = PictureBox1.Image.Size
        Panel1.AutoScrollMinSize = minScroll

    End Sub

    Private Sub ZoomInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomInToolStripMenuItem.Click

        Dim factorEsc As Single = 1.2

        altoImagen = PictureBox1.Height
        anchoImagen = PictureBox1.Width
        Dim nuevoTam As New System.Drawing.Size(altoImagen * factorEsc, anchoImagen * factorEsc)
        PictureBox1.Size = nuevoTam

        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize

        Dim origenBmp As New Bitmap(PictureBox1.Image)
        ' Bitmap escalado
        Dim destinoBmp As New Bitmap(CInt(origenBmp.Width * factorEsc), CInt(origenBmp.Height * factorEsc))
        ' Grafico del Bitmap destino
        Dim destinoGraph As Graphics = Graphics.FromImage(destinoBmp)
        ' Copiar el Bmp origen al Bmp destino ya escalado
        destinoGraph.DrawImage(origenBmp, 0, 0, destinoBmp.Width, destinoBmp.Height)
        PictureBox1.Image = destinoBmp
        'origenBmp.Dispose()
        'destinoBmp.Dispose()

        PictureBox1.Refresh()

        Dim minScroll As System.Drawing.Size
        minScroll = PictureBox1.Size
        Panel1.AutoScrollMinSize = minScroll

    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomOutToolStripMenuItem.Click
        Dim factorEsc As Single = 1.2

        altoImagen = PictureBox1.Height
        anchoImagen = PictureBox1.Width
        Dim nuevoTam As New System.Drawing.Size(altoImagen / factorEsc, anchoImagen / factorEsc)
        PictureBox1.Size = nuevoTam

        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize

        Dim origenBmp As New Bitmap(PictureBox1.Image)
        ' Bitmap escalado
        Dim destinoBmp As New Bitmap(CInt(origenBmp.Width / factorEsc), CInt(origenBmp.Height / factorEsc))
        ' Grafico del Bitmap destino
        Dim destinoGraph As Graphics = Graphics.FromImage(destinoBmp)
        ' Copiar el Bmp origen al Bmp destino ya escalado
        destinoGraph.DrawImage(origenBmp, 0, 0, destinoBmp.Width, destinoBmp.Height)
        PictureBox1.Image = destinoBmp
        'origenBmp.Dispose()
        'destinoBmp.Dispose()

        PictureBox1.Refresh()

        Dim minScroll As System.Drawing.Size
        minScroll = PictureBox1.Size
        Panel1.AutoScrollMinSize = minScroll
    End Sub

    Private Sub abrirBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abrirBoton.Click
        AbrirToolStripMenuItem_Click(abrirBoton, Nothing)
    End Sub

    Private Sub originalBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles originalBoton.Click
        CargarToolStripMenuItem_Click(originalBoton, Nothing)
    End Sub

    Private Sub zoomInBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zoomInBoton.Click
        ZoomInToolStripMenuItem_Click(zoomInBoton, Nothing)
    End Sub

    Private Sub zoomOutBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zoomOutBoton.Click
        ZoomOutToolStripMenuItem_Click(zoomOutBoton, Nothing)
    End Sub

    Private Sub reconocerBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reconocerBoton.Click
        ReconocerToolStripMenuItem_Click(reconocerBoton, Nothing)
    End Sub

    Private Sub salirBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirBoton.Click
        End
    End Sub

    Private Sub ConfigurarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigurarToolStripMenuItem.Click
        formConfigurar.Visible = True
    End Sub

    Private Sub guardarBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarBoton.Click
        Dim salida As String
        Dim texto As String
        salida = My.Computer.FileSystem.CurrentDirectory & "\comparar\salida.txt"
        texto = textoReconocido.Replace("**+**", Environment.NewLine)
        My.Computer.FileSystem.WriteAllText(salida, texto, False)
        ToolStripStatusLabel1.Text = "Guardado"
    End Sub
End Class
