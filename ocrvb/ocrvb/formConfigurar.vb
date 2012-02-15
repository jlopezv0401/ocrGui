Public Class formConfigurar
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case ComboBox1.SelectedIndex
            Case 0
                selRutaBase(0)
                normAlto = 35
                normAncho = 25
                patxClase = 3
                nClases = 80
            Case 1
                selRutaBase(1)
                normAlto = 40
                normAncho = 29
                patxClase = 3
                nClases = 80
            Case 2
                selRutaBase(2)
                normAlto = 35
                normAncho = 25
                patxClase = 3
                nClases = 80
            Case 3
                selRutaBase(3)
                normAlto = 40
                normAncho = 29
                patxClase = 3
                nClases = 80
            Case 4
                selRutaBase(4)
                normAlto = 30
                normAncho = 21
                patxClase = 6
                nClases = 80
            Case 5
                selRutaBase(5)
                normAlto = 35
                normAncho = 25
                patxClase = 6
                nClases = 80
            Case 6
                selRutaBase(6)
                normAlto = 40
                normAncho = 29
                patxClase = 6
                nClases = 80
            Case 7
                selRutaBase(7)
                normAlto = 35
                normAncho = 25
                patxClase = 6
                nClases = 80
            Case 8
                selRutaBase(8)
                normAlto = 35
                normAncho = 25
                patxClase = 3
                nClases = 90
        End Select

        relacion = NumericUpDown1.Value
        umbralInc = NumericUpDown4.Value
        altoInc = NumericUpDown5.Value

        Me.Close()

    End Sub

    Private Sub formConfigurar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courier35x25.csv" Then
            ComboBox1.SelectedIndex = 0
            normAlto = 35
            normAncho = 25
            patxClase = 3
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courier40x29.csv" Then
            ComboBox1.SelectedIndex = 1
            normAlto = 40
            normAncho = 29
            patxClase = 3
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\arial35x25.csv" Then
            ComboBox1.SelectedIndex = 2
            normAlto = 35
            normAncho = 25
            patxClase = 3
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\arial40x29.csv" Then
            ComboBox1.SelectedIndex = 3
            normAlto = 40
            normAncho = 29
            patxClase = 3
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courierarial30x21.csv" Then
            ComboBox1.SelectedIndex = 4
            normAlto = 30
            normAncho = 21
            patxClase = 6
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courierarial35x25.csv" Then
            ComboBox1.SelectedIndex = 5
            normAlto = 35
            normAncho = 25
            patxClase = 6
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courierarial40x29.csv" Then
            ComboBox1.SelectedIndex = 6
            normAlto = 40
            normAncho = 29
            patxClase = 6
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courier6x35x25.csv" Then
            ComboBox1.SelectedIndex = 7
            normAlto = 35
            normAncho = 25
            patxClase = 6
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courier35x2590.csv" Then
            ComboBox1.SelectedIndex = 8
            normAlto = 35
            normAncho = 25
            patxClase = 3
            nClases = 90
        End If

        NumericUpDown1.Value = relacion
        NumericUpDown2.Value = patxClase
        NumericUpDown3.Value = nClases
        NumericUpDown4.Value = umbralInc
        NumericUpDown5.Value = altoInc

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                NumericUpDown2.Value = 3
                NumericUpDown3.Value = 80
            Case 1
                NumericUpDown2.Value = 3
                NumericUpDown3.Value = 80
            Case 2
                NumericUpDown2.Value = 3
                NumericUpDown3.Value = 80
            Case 3
                NumericUpDown2.Value = 3
                NumericUpDown3.Value = 80
            Case 4
                NumericUpDown2.Value = 6
                NumericUpDown3.Value = 80
            Case 5
                NumericUpDown2.Value = 6
                NumericUpDown3.Value = 80
            Case 6
                NumericUpDown2.Value = 6
                NumericUpDown3.Value = 80
            Case 7
                NumericUpDown2.Value = 6
                NumericUpDown3.Value = 80
            Case 8
                NumericUpDown2.Value = 3
                NumericUpDown3.Value = 90
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courier35x25.csv" Then
            ComboBox1.SelectedIndex = 0
            normAlto = 35
            normAncho = 25
            patxClase = 3
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courier40x29.csv" Then
            ComboBox1.SelectedIndex = 1
            normAlto = 40
            normAncho = 29
            patxClase = 3
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\arial35x25.csv" Then
            ComboBox1.SelectedIndex = 2
            normAlto = 35
            normAncho = 25
            patxClase = 3
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\arial40x29.csv" Then
            ComboBox1.SelectedIndex = 3
            normAlto = 40
            normAncho = 29
            patxClase = 3
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courierarial30x21.csv" Then
            ComboBox1.SelectedIndex = 4
            normAlto = 30
            normAncho = 21
            patxClase = 6
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courierarial35x25.csv" Then
            ComboBox1.SelectedIndex = 5
            normAlto = 35
            normAncho = 25
            patxClase = 6
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courierarial40x29.csv" Then
            ComboBox1.SelectedIndex = 6
            normAlto = 40
            normAncho = 29
            patxClase = 6
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courier6x35x25.csv" Then
            ComboBox1.SelectedIndex = 7
            normAlto = 35
            normAncho = 25
            patxClase = 6
            nClases = 80
        ElseIf rutaBase = My.Computer.FileSystem.CurrentDirectory & "\bases\courier35x2590.csv" Then
            ComboBox1.SelectedIndex = 8
            normAlto = 35
            normAncho = 25
            patxClase = 3
            nClases = 90
        End If

        NumericUpDown1.Value = relacion
        NumericUpDown2.Value = patxClase
        NumericUpDown3.Value = nClases
        NumericUpDown4.Value = umbralInc
        NumericUpDown5.Value = altoInc

        Me.Close()

    End Sub

End Class