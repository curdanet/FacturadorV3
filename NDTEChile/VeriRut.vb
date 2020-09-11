Public Class VeriRut
    Private num_rut As String
    Private dig_rut As String

    Sub New() 'constructor de la clase
        num_rut = ""
        dig_rut = ""
    End Sub

    Sub New(ByVal rut As String, digito As String) 'constructor de la clase con las variables
        num_rut = rut
        dig_rut = digito
    End Sub

    Public Shared Function calculo(ByVal rut As String) As String 'recibo un rut con o sin guion para poder trabajarlo
        Dim rutaux As String
        Dim posicion As Integer
        Dim factor, mult As Integer
        Dim valor, suma, dig As Integer
        If rut.IndexOf("-") > 0 Then 'si en el rut ingresado tengo un guion
            rutaux = rut.Substring(0, (rut.LastIndexOf("-"))) 'me quedo solo con el rut sin el guion algo
        Else
            rutaux = rut ' si el rut que ingrese no tiene guion, entonces guardo el rut ingresado en la variable auxiliar
        End If
        posicion = (CInt(rutaux.Length())) - 1 'posicion es el largo del rut que ingrese y con cint lo converti a numero
        factor = 2
        While posicion >= 0 'si el largo del rut es mayor que cero
            valor = CInt(rutaux.Substring(posicion, 1)) 'saco el ultimo numero del rut
            mult = valor * factor 'lo multiplico por el factor (2,3,4,5,6,7,2,3,4,5,etc)
            factor = factor + 1 'le sumo uno al factor
            If factor > 7 Then 'si el factor es 7,entonces comienzo denuevo con factor=2
                factor = 2
            End If
            suma = suma + mult 'voy sumando los resultados de multiplicar cada numero
            posicion = posicion - 1 'le resto uno a la posicion para poder moverme entre los digitos del rut
        End While
        dig = 11 - (suma Mod 11) 'la suma la divido en 11 y guardo el resto
        If dig = 10 Then
            calculo = "k" 'si es 10, devuelvo la "K"
        ElseIf dig = 11 Then
            calculo = "0"
        Else
            calculo = dig.ToString() 'si no es 10, devuelvo el valor que me dio
        End If
    End Function

    Public Shared Function verifica(ByVal rut As String) As Boolean
        verifica = False
        Dim digAux As String
        digAux = rut.Substring((rut.IndexOf("-") + 1), 1)
        If calculo(rut) = digAux.ToLower() Then
            verifica = True
        End If
    End Function
End Class