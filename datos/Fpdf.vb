Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO


Public Class Fpdf
    Public fg As New Fgeneral
    Public dt As DataTable



    Public Sub iniciarPdf(ByVal tipoInforme As String, ByVal seleccion As String, Optional ByVal codConsultaMedica As String = "", Optional ByVal fechaInicial As String = "", Optional ByVal fechaFinal As String = "", Optional ByVal cedulaMedico As String = "", Optional ByVal cedulaPaciente As String = "")
        If tipoInforme = "Alumno" Then
            Select Case seleccion
                Case "Todos"
                    dt = CType(fg.infAlumnoTodos(), DataTable)
                    crearPdf(dt, seleccion, tipoInforme)
                    'Case "Una"
                    'dt = CType(fg.infHistoriaMedicaUna(cedulaPaciente), DataTable)
                    'crearPdf(dt, seleccion, tipoInforme)
            End Select
        ElseIf tipoInforme = "Representante" Then
            Select Case seleccion
                Case "Todos"
                    dt = CType(fg.infRepresentanteTodos(), DataTable)
                    crearPdf(dt, seleccion, tipoInforme)
                    'Case "Una"
                    '    dt = CType(fg.infConsultaMedicaUna(codConsultaMedica), DataTable)
                    '    crearPdf(dt, seleccion, tipoInforme)
                    'Case "Fechas"
                    '    dt = CType(fg.infConsultaMedicaFechas(fechaInicial, fechaFinal), DataTable)
                    '    crearPdf(dt, seleccion, tipoInforme)
                    'Case "Medico"
                    '    dt = CType(fg.infConsultaMedicaMedico(cedulaMedico), DataTable)
                    '    crearPdf(dt, seleccion, tipoInforme)
                    'Case "Paciente"
                    '    dt = CType(fg.infConsultaMedicaPaciente(cedulaPaciente), DataTable)
                    '    crearPdf(dt, seleccion, tipoInforme)
            End Select
        ElseIf tipoInforme = "Inscripciones" Then
            Select Case seleccion
                Case "Todos"
                    dt = CType(fg.infInscripcionesTodos(), DataTable)
                    crearPdf(dt, seleccion, tipoInforme)
                    'Case "Una"
                    '    dt = CType(fg.infMedicoUno(cedulaPaciente), DataTable)
                    '    crearPdf(dt, seleccion, tipoInforme)
            End Select
            'ElseIf tipoInforme = "Paciente" Then
            '    Select Case seleccion
            '        Case "Todos"
            '            dt = CType(fg.infPacienteTodos(), DataTable)
            '            crearPdf(dt, seleccion, tipoInforme)
            '            'Case "Una"
            '            '    dt = CType(fg.infPacienteUno(cedulaPaciente), DataTable)
            '            '    crearPdf(dt, seleccion, tipoInforme)
            '    End Select
        End If
    End Sub



    Public Sub crearPdf(ByVal dt As DataTable, ByVal seleccion As String, ByVal tipoInforme As String)
        Try
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString & "\Informe.pdf", FileMode.Create))

            Dim font8hel As New Font(FontFactory.GetFont(FontFactory.TIMES, 8, iTextSharp.text.Font.NORMAL))
            Dim fontB8hel As New Font(FontFactory.GetFont(FontFactory.TIMES, 8, iTextSharp.text.Font.BOLD))
            Dim font12times As New Font(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD))
            Dim cVacio As PdfPCell = New PdfPCell(New Phrase(""))
            cVacio.Border = 0

            pdfDoc.Open()


            Dim col1 As PdfPCell
            Dim col2 As PdfPCell
            Dim col3 As PdfPCell
            Dim col4 As PdfPCell
            Dim col5 As PdfPCell
            Dim col6 As PdfPCell
            Dim col7 As PdfPCell
            Dim col8 As PdfPCell
            Dim col9 As PdfPCell
            Dim col10 As PdfPCell
            Dim titulo As String = ""


            If tipoInforme = "Alumno" Then
                Select Case seleccion
                    Case "Todos"
                        titulo = "Reporte de los Alumnos registrados"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, tipoInforme)
                        tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, dt, tipoInforme)
                        'Case "Una"
                        '    titulo = "Reporte de la historia médica de un paciente"
                        '    encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        '    headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, tipoInforme)
                        '    tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, dt, tipoInforme)
                End Select
            ElseIf tipoInforme = "Representante" Then
                Select Case seleccion
                    Case "Todos"
                        titulo = "Reporte de los Representantes registrados"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, tipoInforme)
                        tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, dt, tipoInforme)
                        'Case "Una"
                        '    titulo = "Reporte de una consulta médica"
                        '    encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        '    headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, tipoInforme)
                        '    tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, dt, tipoInforme)
                        'Case "Fechas"
                        '    titulo = "Reporte de consultas médicas por fechas"
                        '    encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        '    headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, tipoInforme)
                        '    tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, dt, tipoInforme)
                        'Case "Medico"
                        '    titulo = "Reporte de consultas médicas hechas por un médico"
                        '    encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        '    headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, tipoInforme)
                        '    tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, dt, tipoInforme)
                        'Case "Paciente"
                        '    titulo = "Reporte de consultas médicas hechas por un paciente"
                        '    encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        '    headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, tipoInforme)
                        '    tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, dt, tipoInforme)
                End Select
            ElseIf tipoInforme = "Inscripciones" Then
                Select Case seleccion
                    Case "Todos"
                        titulo = "Reporte de las Inscripciones realizadas"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, tipoInforme)
                        tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, dt, tipoInforme)
                        'Case "Una"
                        '    titulo = "Reporte de un médico"
                        '    encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        '    headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, tipoInforme)
                        '    tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, dt, tipoInforme)
                End Select
                'ElseIf tipoInforme = "Paciente" Then
                '    Select Case seleccion
                '        Case "Todos"
                '            titulo = "Reporte de todos los pacientes"
                '            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                '            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, tipoInforme)
                '            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, dt, tipoInforme)
                '        Case "Una"
                '            titulo = "Reporte de un paciente"
                '            encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                '            headers(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, tipoInforme)
                '            tabla(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, font8hel, fontB8hel, font12times, dt, tipoInforme)
                'End Select
            End If

            pdfDoc.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub encabezado(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal titulo As String)
        ' --------------------------------------------- ENCABEZADO ---------------------------------------------
        Dim table1 As PdfPTable = New PdfPTable(3)
        table1.WidthPercentage = 95
        Dim widths As Single() = New Single() {6.0F, 6.0F, 5.0F}
        table1.SetWidths(widths)
        'Dim imagenURL As String = "logo.png"
        'Dim imagenBMP As iTextSharp.text.Image
        'imagenBMP = iTextSharp.text.Image.GetInstance(imagenURL)
        'imagenBMP.ScaleToFit(60.0F, 80.0F)
        'imagenBMP.SpacingBefore = 20.0F
        'imagenBMP.SpacingAfter = 10.0F
        'imagenBMP.SetAbsolutePosition(40, 770)
        'pdfDoc.Add(imagenBMP)

        cVacio.Rowspan = 5
        table1.AddCell(cVacio)


        col1 = New PdfPCell(New Phrase(titulo, font8times))
        col1.VerticalAlignment = Element.ALIGN_MIDDLE
        col1.Border = 0
        col1.Rowspan = 5
        table1.AddCell(col1)
        col1 = New PdfPCell(New Phrase("U.E.P 'San Ignacio de Loyola'", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_RIGHT
        col1.Border = 0
        table1.AddCell(col1)
        col2 = New PdfPCell(New Phrase("Guanta, Las Palmas, Calle A", font8hel))
        col2.HorizontalAlignment = Element.ALIGN_RIGHT
        col2.Border = 0
        table1.AddCell(col2)
        col3 = New PdfPCell(New Phrase("Anzoátegui - Anzoátegui - Anzoátegui", font8hel))
        col3.HorizontalAlignment = Element.ALIGN_RIGHT
        col3.Border = 0
        table1.AddCell(col3)
        col4 = New PdfPCell(New Phrase("(+58) 281-2682420", font8hel))
        col4.HorizontalAlignment = Element.ALIGN_RIGHT
        col4.Border = 0
        table1.AddCell(col4)
        col5 = New PdfPCell(New Phrase("", font8hel))
        col5.HorizontalAlignment = Element.ALIGN_RIGHT
        col5.Border = 0
        table1.AddCell(col5)

        cVacio.Colspan = 5
        cVacio.Border = 1
        cVacio.Rowspan = 1
        table1.AddCell(cVacio)

        pdfDoc.Add(table1)
        ' -----------------------------------------------------------------------------------------------------

    End Sub
    Public Sub headers(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal col8 As PdfPCell, ByVal col9 As PdfPCell, ByVal col10 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal tipoInforme As String)
        Dim table3 As PdfPTable
        Dim widths3 As Single()

        If tipoInforme = "Alumno" Then
            table3 = New PdfPTable(8)
            widths3 = New Single() {1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F}

            table3.SpacingBefore = 20.0F
            table3.WidthPercentage = 95
            table3.SetWidths(widths3)

            col1 = New PdfPCell(New Phrase("Cedula del Alumno", fontB8hel))
            col1.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col1)

            col2 = New PdfPCell(New Phrase("Nombre", fontB8hel))
            col2.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col2)

            col3 = New PdfPCell(New Phrase("Segundo Nombre", fontB8hel))
            col3.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col3)

            col4 = New PdfPCell(New Phrase("Apellido", fontB8hel))
            col4.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col4)


            col5 = New PdfPCell(New Phrase("Segundo Apellido", fontB8hel))
            col5.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col5)

            col6 = New PdfPCell(New Phrase("Sexo", fontB8hel))
            col6.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col6)

            col7 = New PdfPCell(New Phrase("Cédula del Representante", fontB8hel))
            col7.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col7)

            col8 = New PdfPCell(New Phrase("Fecha de Nacimiento", fontB8hel))
            col8.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col8)

        ElseIf tipoInforme = "Representante" Then
            table3 = New PdfPTable(9)
            widths3 = New Single() {2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 3.0F, 1.0F, 1.0F, 3.0F}

            table3.SpacingBefore = 20.0F
            table3.WidthPercentage = 95
            table3.SetWidths(widths3)

            col1 = New PdfPCell(New Phrase("Cédula del Representante", fontB8hel))
            col1.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col1)

            col2 = New PdfPCell(New Phrase("Nombre", fontB8hel))
            col2.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col2)

            col3 = New PdfPCell(New Phrase("Segundo Nombre", fontB8hel))
            col3.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col3)

            col4 = New PdfPCell(New Phrase("Apellido", fontB8hel))
            col4.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col4)

            col5 = New PdfPCell(New Phrase("Segundo Apellido", fontB8hel))
            col5.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col5)

            col6 = New PdfPCell(New Phrase("Fecha de Nacimiento", fontB8hel))
            col6.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col6)

            col7 = New PdfPCell(New Phrase("Sexo", fontB8hel))
            col7.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col7)

            col8 = New PdfPCell(New Phrase("Teléfono", fontB8hel))
            col8.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col8)

            col9 = New PdfPCell(New Phrase("Dirección", fontB8hel))
            col9.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col9)
        ElseIf tipoInforme = "Inscripciones" Then
            table3 = New PdfPTable(6)
            widths3 = New Single() {1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F}

            table3.SpacingBefore = 20.0F
            table3.WidthPercentage = 95
            table3.SetWidths(widths3)

            col1 = New PdfPCell(New Phrase("Id de la inscripción", fontB8hel))
            col1.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col1)

            col2 = New PdfPCell(New Phrase("Cédula del alumno", fontB8hel))
            col2.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col2)

            col3 = New PdfPCell(New Phrase("Fecha de inscripción", fontB8hel))
            col3.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col3)

            col4 = New PdfPCell(New Phrase("Grado", fontB8hel))
            col4.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col4)

            col5 = New PdfPCell(New Phrase("Sección", fontB8hel))
            col5.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col5)

            col6 = New PdfPCell(New Phrase("Periodo Escolar", fontB8hel))
            col6.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col6)

            'ElseIf tipoInforme = "Paciente" Then
            '    table3 = New PdfPTable(8)
            '    widths3 = New Single() {2.0F, 2.0F, 2.0F, 3.0F, 1.0F, 1.0F, 1.0F, 3.0F}

            '    table3.SpacingBefore = 20.0F
            '    table3.WidthPercentage = 95
            '    table3.SetWidths(widths3)

            '    col1 = New PdfPCell(New Phrase("Cédula del paciente", fontB8hel))
            '    col1.HorizontalAlignment = Element.ALIGN_LEFT
            '    table3.AddCell(col1)

            '    col2 = New PdfPCell(New Phrase("Nombre", fontB8hel))
            '    col2.HorizontalAlignment = Element.ALIGN_LEFT
            '    table3.AddCell(col2)

            '    col3 = New PdfPCell(New Phrase("Apellido", fontB8hel))
            '    col3.HorizontalAlignment = Element.ALIGN_LEFT
            '    table3.AddCell(col3)

            '    col4 = New PdfPCell(New Phrase("Teléfono", fontB8hel))
            '    col4.HorizontalAlignment = Element.ALIGN_LEFT
            '    table3.AddCell(col4)

            '    col5 = New PdfPCell(New Phrase("Email", fontB8hel))
            '    col5.HorizontalAlignment = Element.ALIGN_LEFT
            '    table3.AddCell(col5)

            '    col6 = New PdfPCell(New Phrase("Edad", fontB8hel))
            '    col6.HorizontalAlignment = Element.ALIGN_LEFT
            '    table3.AddCell(col6)

            '    col7 = New PdfPCell(New Phrase("Sexo", fontB8hel))
            '    col7.HorizontalAlignment = Element.ALIGN_LEFT
            '    table3.AddCell(col7)

            '    col8 = New PdfPCell(New Phrase("Residencia", fontB8hel))
            '    col8.HorizontalAlignment = Element.ALIGN_LEFT
            '    table3.AddCell(col8)
        End If

        pdfDoc.Add(table3)
    End Sub
    Public Sub tabla(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal col8 As PdfPCell, ByVal col9 As PdfPCell, ByVal col10 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal dt As DataTable, ByVal tipoInforme As String)
        Dim table4 As PdfPTable
        Dim widths4 As Single()

        If tipoInforme = "Alumno" Then
            table4 = New PdfPTable(8)
            widths4 = New Single() {1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F}

            table4.WidthPercentage = 95
            table4.SetWidths(widths4)
            Dim i As Integer

            For i = 0 To (dt.Rows.Count - 1)
                col1 = New PdfPCell(New Phrase(dt(i)("CIAlumno").ToString, font8hel))
                col1.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col1)

                col2 = New PdfPCell(New Phrase(dt(i)("Nombre").ToString, font8hel))
                col2.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col2)

                col3 = New PdfPCell(New Phrase(dt(i)("SNombre").ToString, font8hel))
                col3.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col3)

                col4 = New PdfPCell(New Phrase(dt(i)("Apellido").ToString, font8hel))
                col4.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col4)


                'Dim hoy As Date = Date.Today
                'Dim anoHoy As Integer = hoy.Year

                'Dim nacimiento As Date
                'Dim anoNacimiento As Integer
                'nacimiento = CDate(dt(i)("FechaDeNacimiento"))
                'anoNacimiento = nacimiento.Year

                'Dim haceXanos As Date

                'Dim diferenciaNacimientoHoy As Integer = anoHoy - anoNacimiento
                'haceXanos = hoy.AddYears(-diferenciaNacimientoHoy)

                'Dim esAntesFechaHoy As Integer

                'esAntesFechaHoy = Date.Compare(nacimiento, haceXanos)
                'If esAntesFechaHoy = 1 Then

                'Else
                '    haceXanos = haceXanos.AddYears(1)
                'End If
                'Dim anos As Integer = haceXanos.Year
                'Dim edad As Integer = anoHoy - anos

                col5 = New PdfPCell(New Phrase(dt(i)("SApellido").ToString, font8hel))
                col5.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col5)


                col6 = New PdfPCell(New Phrase(dt(i)("Sexo").ToString, font8hel))
                col6.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col6)

                col7 = New PdfPCell(New Phrase(dt(i)("CIRepresentante").ToString, font8hel))
                col7.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col7)

                col8 = New PdfPCell(New Phrase(dt(i)("FechaNacimiento").ToString, font8hel))
                col8.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col8)

            Next
        ElseIf tipoInforme = "Representante" Then
            table4 = New PdfPTable(9)
            widths4 = New Single() {2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 3.0F, 1.0F, 1.0F, 3.0F}

            table4.WidthPercentage = 95
            table4.SetWidths(widths4)
            Dim i As Integer

            For i = 0 To (dt.Rows.Count - 1)
                col1 = New PdfPCell(New Phrase(dt(i)("CIRepresentante").ToString, font8hel))
                col1.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col1)

                col2 = New PdfPCell(New Phrase(dt(i)("Nombre").ToString, font8hel))
                col2.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col2)

                col3 = New PdfPCell(New Phrase(dt(i)("SNombre").ToString, font8hel))
                col3.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col3)

                col4 = New PdfPCell(New Phrase(dt(i)("Apellido").ToString, font8hel))
                col4.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col4)

                col5 = New PdfPCell(New Phrase(dt(i)("SApellido").ToString, font8hel))
                col5.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col5)

                col6 = New PdfPCell(New Phrase(dt(i)("FechaNacimiento").ToString, font8hel))
                col6.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col6)

                col7 = New PdfPCell(New Phrase(dt(i)("Sexo").ToString, font8hel))
                col7.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col7)

                col8 = New PdfPCell(New Phrase(dt(i)("Telefono").ToString, font8hel))
                col8.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col8)

                col9 = New PdfPCell(New Phrase(dt(i)("Dirreccion").ToString, font8hel))
                col9.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col9)
            Next

        ElseIf tipoInforme = "Inscripciones" Then
            table4 = New PdfPTable(6)
            widths4 = New Single() {1.0F, 1.0F, 1.0F, 1.0F, 1.0F, 1.0F}

            table4.WidthPercentage = 95
            table4.SetWidths(widths4)
            Dim i As Integer

            For i = 0 To (dt.Rows.Count - 1)
                col1 = New PdfPCell(New Phrase(dt(i)("IdInscripcion").ToString, font8hel))
                col1.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col1)

                col2 = New PdfPCell(New Phrase(dt(i)("CIAlumno").ToString, font8hel))
                col2.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col2)

                col3 = New PdfPCell(New Phrase(dt(i)("Fecha").ToString, font8hel))
                col3.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col3)

                col4 = New PdfPCell(New Phrase(dt(i)("Grado").ToString, font8hel))
                col4.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col4)

                col5 = New PdfPCell(New Phrase(dt(i)("Seccion").ToString, font8hel))
                col5.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col5)

                'Dim hoy As Date = Date.Today
                'Dim anoHoy As Integer = hoy.Year

                'Dim nacimiento As Date
                'Dim anoNacimiento As Integer
                'nacimiento = CDate(dt(i)("FechaDeNacimiento"))
                'anoNacimiento = nacimiento.Year

                'Dim haceXanos As Date

                'Dim diferenciaNacimientoHoy As Integer = anoHoy - anoNacimiento
                'haceXanos = hoy.AddYears(-diferenciaNacimientoHoy)

                'Dim esAntesFechaHoy As Integer

                'esAntesFechaHoy = Date.Compare(nacimiento, haceXanos)
                'If esAntesFechaHoy = 1 Then

                'Else
                '    haceXanos = haceXanos.AddYears(1)
                'End If
                'Dim anos As Integer = haceXanos.Year
                'Dim edad As Integer = anoHoy - anos

                col6 = New PdfPCell(New Phrase(dt(i)("PeriodoEscolar").ToString, font8hel))
                col6.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col6)

            Next

            'ElseIf tipoInforme = "Paciente" Then
            '    table4 = New PdfPTable(8)
            '    widths4 = New Single() {2.0F, 2.0F, 2.0F, 3.0F, 1.0F, 1.0F, 1.0F, 3.0F}

            '    table4.WidthPercentage = 95
            '    table4.SetWidths(widths4)
            '    Dim i As Integer

            '    For i = 0 To (dt.Rows.Count - 1)
            '        col1 = New PdfPCell(New Phrase(dt(i)("CedulaPaciente").ToString, font8hel))
            '        col1.HorizontalAlignment = Element.ALIGN_LEFT
            '        table4.AddCell(col1)

            '        col2 = New PdfPCell(New Phrase(dt(i)("Nombre").ToString, font8hel))
            '        col2.HorizontalAlignment = Element.ALIGN_LEFT
            '        table4.AddCell(col2)

            '        col3 = New PdfPCell(New Phrase(dt(i)("Apellido").ToString, font8hel))
            '        col3.HorizontalAlignment = Element.ALIGN_LEFT
            '        table4.AddCell(col3)

            '        col4 = New PdfPCell(New Phrase(dt(i)("Telefono").ToString, font8hel))
            '        col4.HorizontalAlignment = Element.ALIGN_LEFT
            '        table4.AddCell(col4)

            '        col5 = New PdfPCell(New Phrase(dt(i)("Email").ToString, font8hel))
            '        col5.HorizontalAlignment = Element.ALIGN_LEFT
            '        table4.AddCell(col5)

            '        Dim hoy As Date = Date.Today
            '        Dim anoHoy As Integer = hoy.Year

            '        Dim nacimiento As Date
            '        Dim anoNacimiento As Integer
            '        nacimiento = CDate(dt(i)("FechaDeNacimiento"))
            '        anoNacimiento = nacimiento.Year

            '        Dim haceXanos As Date

            '        Dim diferenciaNacimientoHoy As Integer = anoHoy - anoNacimiento
            '        haceXanos = hoy.AddYears(-diferenciaNacimientoHoy)

            '        Dim esAntesFechaHoy As Integer

            '        esAntesFechaHoy = Date.Compare(nacimiento, haceXanos)
            '        If esAntesFechaHoy = 1 Then

            '        Else
            '            haceXanos = haceXanos.AddYears(1)
            '        End If
            '        Dim anos As Integer = haceXanos.Year
            '        Dim edad As Integer = anoHoy - anos

            '        col6 = New PdfPCell(New Phrase(edad.ToString, font8hel))
            '        col6.HorizontalAlignment = Element.ALIGN_LEFT
            '        table4.AddCell(col6)


            '        col7 = New PdfPCell(New Phrase(dt(i)("Sexo").ToString, font8hel))
            '        col7.HorizontalAlignment = Element.ALIGN_LEFT
            '        table4.AddCell(col7)

            '        col8 = New PdfPCell(New Phrase(dt(i)("Residencia").ToString, font8hel))
            '        col8.HorizontalAlignment = Element.ALIGN_LEFT
            '        table4.AddCell(col8)
            '    Next
        End If

        pdfDoc.Add(table4)
    End Sub
End Class
