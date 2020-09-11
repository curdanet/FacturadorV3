Imports System.IO
Imports System.Xml
Imports System.Web
Imports System.Text.RegularExpressions

Public Class ValidadorXml




    Public Function FormateaXML(XML As String)
        XML = CodificarXml(XML)
        XML = RemplazarTilde(XML)
        XML = DesglosaXml(XML)



        Return XML

    End Function

    Public Function CodificarXml(XML As String)

        'caracteres = caracteres.Replace("<", "@")
        'caracteres = caracteres.Replace(">", "*")
        'MsgBox(caracteres)
        ' Dim caracteresIso As String = HttpUtility.HtmlEncode(XML)
        'XML = XML.Replace("&lt;", "<")
        'XML = XML.Replace("&gt;", ">")
        'XML = XML.Replace("&quot;", Chr(34))
        XML = Regex.Replace(XML, "[°´'|¬!#?¡¨~[^{}]`]", String.Empty) ' reemplazamos los caracteres especialex        
        XML = XML.Replace("'", "")
        XML = XML.Replace("`", "")
        XML = XML.Replace("‘", String.Empty)
        Return XML
    End Function
    Public Function DesglosaXml(XML As String)


        Dim MiDocXML As XmlDocument
        MiDocXML = New XmlDocument()
        MiDocXML.PreserveWhitespace = True
        MiDocXML.LoadXml(XML)




            If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RznSoc") IsNot Nothing) Then
            Dim RznSoc As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RznSoc").InnerText
            If Len(RznSoc) > 100 Then
                RznSoc = Microsoft.VisualBasic.Left(RznSoc, 100)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/RznSoc").InnerText = RznSoc
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/GiroEmis") IsNot Nothing) Then
            Dim GiroEmis As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/GiroEmis").InnerText
            If Len(GiroEmis) > 80 Then
                GiroEmis = Microsoft.VisualBasic.Left(GiroEmis, 80)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/GiroEmis").InnerText = GiroEmis
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/CorreoEmisor") IsNot Nothing) Then
            Dim CorreoEmisor As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/CorreoEmisor").InnerText
            If Len(CorreoEmisor) > 80 Then
                CorreoEmisor = Microsoft.VisualBasic.Left(CorreoEmisor, 80)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/CorreoEmisor").InnerText = CorreoEmisor
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/Sucursal") IsNot Nothing) Then
            Dim Sucursal As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/Sucursal").InnerText
            If Len(Sucursal) > 20 Then
                Sucursal = Microsoft.VisualBasic.Left(Sucursal, 20)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/Sucursal").InnerText = Sucursal
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/DirOrigen") IsNot Nothing) Then
            Dim DirOrigen As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/DirOrigen").InnerText
            If Len(DirOrigen) > 60 Then
                DirOrigen = Microsoft.VisualBasic.Left(DirOrigen, 60)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/DirOrigen").InnerText = DirOrigen
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/CmnaOrigen") IsNot Nothing) Then
            Dim CmnaOrigen As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/CmnaOrigen").InnerText
            If Len(CmnaOrigen) > 20 Then
                CmnaOrigen = Microsoft.VisualBasic.Left(CmnaOrigen, 20)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/CmnaOrigen").InnerText = CmnaOrigen
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/CiudadOrigen") IsNot Nothing) Then
            Dim CiudadOrigen As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/CiudadOrigen").InnerText
            If Len(CiudadOrigen) > 20 Then
                CiudadOrigen = Microsoft.VisualBasic.Left(CiudadOrigen, 20)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Emisor/CiudadOrigen").InnerText = CiudadOrigen
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/RznSocRecep") IsNot Nothing) Then
            Dim RznSocRecep As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/RznSocRecep").InnerText
            If Len(RznSocRecep) > 100 Then
                RznSocRecep = Microsoft.VisualBasic.Left(RznSocRecep, 100)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/RznSocRecep").InnerText = RznSocRecep
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/GiroRecep") IsNot Nothing) Then
            Dim GiroRecep As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/GiroRecep").InnerText
            If Len(GiroRecep) > 40 Then
                GiroRecep = Microsoft.VisualBasic.Left(GiroRecep, 40)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/GiroRecep").InnerText = GiroRecep
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/Contacto") IsNot Nothing) Then
            Dim Contacto As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/Contacto").InnerText
            If Len(Contacto) > 80 Then
                Contacto = Microsoft.VisualBasic.Left(Contacto, 80)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/Contacto").InnerText = Contacto
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/CorreoRecep") IsNot Nothing) Then
            Dim CorreoRecep As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/CorreoRecep").InnerText
            If Len(CorreoRecep) > 80 Then
                CorreoRecep = Microsoft.VisualBasic.Left(CorreoRecep, 80)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/CorreoRecep").InnerText = CorreoRecep
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/DirRecep") IsNot Nothing) Then
            Dim DirRecep As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/DirRecep").InnerText
            If Len(DirRecep) > 70 Then
                DirRecep = Microsoft.VisualBasic.Left(DirRecep, 70)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/DirRecep").InnerText = DirRecep
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/CmnaRecep") IsNot Nothing) Then
            Dim CmnaRecep As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/CmnaRecep").InnerText
            If Len(CmnaRecep) > 20 Then
                CmnaRecep = Microsoft.VisualBasic.Left(CmnaRecep, 20)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/CmnaRecep").InnerText = CmnaRecep
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/CiudadRecep") IsNot Nothing) Then
            Dim CiudadRecep As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/CiudadRecep").InnerText
            If Len(CiudadRecep) > 20 Then
                CiudadRecep = Microsoft.VisualBasic.Left(CiudadRecep, 20)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/CiudadRecep").InnerText = CiudadRecep
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Transporte/NombreChofer") IsNot Nothing) Then
            Dim NombreChofer As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Transporte/NombreChofer").InnerText
            If Len(NombreChofer) > 30 Then
                NombreChofer = Microsoft.VisualBasic.Left(NombreChofer, 30)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Transporte/NombreChofer").InnerText = NombreChofer
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Transporte/DirDest") IsNot Nothing) Then
            Dim DirDest As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Transporte/DirDest").InnerText
            If Len(DirDest) > 70 Then
                DirDest = Microsoft.VisualBasic.Left(DirDest, 70)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Transporte/DirDest").InnerText = DirDest
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Transporte/CmnaDest") IsNot Nothing) Then
            Dim CmnaDest As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Transporte/CmnaDest").InnerText
            If Len(CmnaDest) > 20 Then
                CmnaDest = Microsoft.VisualBasic.Left(CmnaDest, 20)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Transporte/CmnaDest").InnerText = CmnaDest
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Transporte/CiudadDest") IsNot Nothing) Then
            Dim CiudadDest As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Transporte/CiudadDest").InnerText
            If Len(CiudadDest) > 20 Then
                CiudadDest = Microsoft.VisualBasic.Left(CiudadDest, 20)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Transporte/CiudadDest").InnerText = CiudadDest
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/OtraMoneda/TpoMoneda") IsNot Nothing) Then
            Dim TpoMoneda As String = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/OtraMoneda/TpoMoneda").InnerText
            If Len(TpoMoneda) > 15 Then
                TpoMoneda = Microsoft.VisualBasic.Left(TpoMoneda, 15)
                MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/OtraMoneda/TpoMoneda").InnerText = TpoMoneda
            End If
        End If

        If (MiDocXML.SelectSingleNode("//DTE/Documento/Detalle") IsNot Nothing) Then

            Dim nodeList As XmlNodeList
            nodeList = MiDocXML.SelectNodes("//DTE/Documento/Detalle")

            'Recorremos los detalles de item
            Dim cont As Integer = 0
            For Each node As XmlElement In nodeList
                cont = cont + 1




                'NmbItem
                If (node.SelectSingleNode("NmbItem") IsNot Nothing) Then
                    Dim NmbItem As String = node.SelectSingleNode("NmbItem").InnerText
                    If Len(NmbItem) > 80 Then
                        
                        NmbItem = Microsoft.VisualBasic.Left(NmbItem, 80)
                        node.SelectSingleNode("NmbItem").InnerText = NmbItem
                    End If
                End If
                'DscItem
                If (node.SelectSingleNode("DscItem") IsNot Nothing) Then
                    Dim DscItem As String = node.SelectSingleNode("DscItem").InnerText
                    If Len(DscItem) > 1000 Then
                        DscItem = Microsoft.VisualBasic.Left(DscItem, 1000)
                        node.SelectSingleNode("DscItem").InnerText = DscItem
                    End If
                End If
                'DscItem
                If (node.SelectSingleNode("UnmdItem") IsNot Nothing) Then
                    Dim UnmdItem As String = node.SelectSingleNode("UnmdItem").InnerText
                    If Len(UnmdItem) > 4 Then
                        UnmdItem = Microsoft.VisualBasic.Left(UnmdItem, 4)
                        node.SelectSingleNode("UnmdItem").InnerText = UnmdItem
                    End If
                End If
            Next
        End If

        ' corregir tpovalor en dscrcgglobal

        If (MiDocXML.SelectSingleNode("//DTE/Documento/DscRcgGlobal/TpoValor") IsNot Nothing) Then
            If MiDocXML.SelectSingleNode("//DTE/Documento/DscRcgGlobal/TpoValor").InnerText = " " Then
                MiDocXML.SelectSingleNode("//DTE/Documento/DscRcgGlobal/TpoValor").InnerText = "%"
            End If
        End If

        ' Eliminar nodo contacto ,  Se comenta debido a la solicitud de agregar nodo contacto por el sii
        If (MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/Contacto") IsNot Nothing) Then
            Dim node As XmlNode = MiDocXML.SelectSingleNode("//DTE/Documento/Encabezado/Receptor/Contacto")



            node.ParentNode.RemoveChild(node)
        End If

        Dim sw As StringWriter = New StringWriter()
        Dim xw As XmlTextWriter = New XmlTextWriter(sw)
        MiDocXML.WriteTo(xw)
        Dim XmlString As String = sw.ToString()

        Return XmlString

    End Function


    Public Function RemplazarTilde(XML As String) As String
        Dim toReplace() As Char = "àèìòùÀÈÌÒÙ äëïöüÄËÏÖÜ âêîôûÂÊÎÔÛ áéíóúÁÉÍÓÚðÐýÝ ãñõÃÑÕšŠžŽçÇåÅøØ &".ToCharArray
        Dim replaceChars() As Char = "aeiouAEIOU aeiouAEIOU aeiouAEIOU aeiouAEIOUdDyY anoANOsSzZcCaAoO Y".ToCharArray
        For index As Integer = 0 To toReplace.GetUpperBound(0)
            XML = XML.Replace(toReplace(index), replaceChars(index))
        Next
        Return XML

    End Function





End Class
