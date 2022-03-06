'llamamos a nuestra libreria
Imports System.Math

Module Module1

    Dim Contador = 0
    Dim NombrePaciente(6) As String
    Dim NITPaciente(6) As String
    Dim DiasPaciente(6) As String
    Dim Honorarios(6) As String
    Dim Precio(6) As String
    Dim Descuento(6) As String
    Dim Subtotal(6)
    Dim Total(6) As String
    Dim Rebaja(6) As String



    Public Sub Agregar()
        'Mandamos los datos ingresados a cada uno de los vectores asignados 

        'nombre
        NombrePaciente(Contador) = Form1.TBNombre.Text
        'NIt
        NITPaciente(Contador) = Form1.TBNIT.Text
        'Dias
        DiasPaciente(Contador) = Form1.TBDias.Text
        'Honoraios
        Honorarios(Contador) = Form1.TBHonorarios.Text

        'Procederemos a calcular y guardar los datos en vectores
        'precedimiento cuando solo es un tipo de cama
        'calculos para cuando es una habitacion privada
        If Form1.RBPrivada.Checked = True And Form1.CHEncamamiento.Checked = True Then
            Precio(Contador) = 350
        Else
            If Form1.RBPrivada.Checked = True And Form1.CHOperacion.Checked = True Then
                Precio(Contador) = 550
            Else
                If Form1.RBPrivada.Checked = True And Form1.CHMaternidad.Checked = True Then
                    Precio(Contador) = 450
                End If
            End If
        End If
        'calculos para cuando es una habitacion semi privada
        If Form1.RBsemi.Checked = True And Form1.CHEncamamiento.Checked = True Then
            Precio(Contador) = 250
        Else
            If Form1.RBsemi.Checked = True And Form1.CHOperacion.Checked = True Then
                Precio(Contador) = 400
            Else
                If Form1.RBsemi.Checked = True And Form1.CHMaternidad.Checked = True Then
                    Precio(Contador) = 350
                End If
            End If
        End If
        'calculos para cuando es una habitacion no privada
        If Form1.RBNopriv.Checked = True And Form1.CHEncamamiento.Checked = True Then
            Precio(Contador) = 150
        Else
            If Form1.RBNopriv.Checked = True And Form1.CHOperacion.Checked = True Then
                Precio(Contador) = 300
            Else
                If Form1.RBNopriv.Checked = True And Form1.CHMaternidad.Checked = True Then
                    Precio(Contador) = 250
                End If
            End If
        End If


        'precedimiento cuando solo es un tipo de cama y dos servicios
        'calculos para cuando es una habitacion privada
        If Form1.RBPrivada.Checked = True And Form1.CHEncamamiento.Checked = True And Form1.CHOperacion.Checked = True Then
            Precio(Contador) = 350 + 550
        Else
            If Form1.RBPrivada.Checked = True And Form1.CHOperacion.Checked = True And Form1.CHMaternidad.Checked = True Then
                Precio(Contador) = 550 + 450
            Else
                If Form1.RBPrivada.Checked = True And Form1.CHMaternidad.Checked = True And Form1.CHEncamamiento.Checked = True Then
                    Precio(Contador) = 450 + 350
                End If
            End If
        End If
        'calculos para cuando es una habitacion semi privada
        If Form1.RBsemi.Checked = True And Form1.CHEncamamiento.Checked = True And Form1.CHOperacion.Checked = True Then
            Precio(Contador) = 250 + 400
        Else
            If Form1.RBsemi.Checked = True And Form1.CHOperacion.Checked = True And Form1.CHMaternidad.Checked = True Then
                Precio(Contador) = 400 + 350
            Else
                If Form1.RBsemi.Checked = True And Form1.CHMaternidad.Checked = True And Form1.CHEncamamiento.Checked = True Then
                    Precio(Contador) = 350 + 250
                End If
            End If
        End If
        'calculos para cuando es una habitacion no privada
        If Form1.RBNopriv.Checked = True And Form1.CHEncamamiento.Checked = True And Form1.CHOperacion.Checked = True Then
            Precio(Contador) = 150 + 300
        Else
            If Form1.RBNopriv.Checked = True And Form1.CHOperacion.Checked = True And Form1.CHMaternidad.Checked = True Then
                Precio(Contador) = 300 + 250
            Else
                If Form1.RBNopriv.Checked = True And Form1.CHMaternidad.Checked = True And Form1.CHEncamamiento.Checked = True Then
                    Precio(Contador) = 250 + 150
                End If
            End If
        End If

        'precedimiento cuando solo es un tipo de cama y tres servicios
        'calculos para cuando es una habitacion privada
        If Form1.RBPrivada.Checked = True And Form1.CHEncamamiento.Checked = True And Form1.CHOperacion.Checked = True And Form1.CHMaternidad.Checked = True Then
            Precio(Contador) = 350 + 550 + 450
        End If
        'calculos para cuando es una habitacion semi privada
        If Form1.RBsemi.Checked = True And Form1.CHEncamamiento.Checked = True And Form1.CHOperacion.Checked = True And Form1.CHMaternidad.Checked = True Then
            Precio(Contador) = 250 + 400 + 350
        End If
        'calculos para cuando es una habitacion no privada
        If Form1.RBNopriv.Checked = True And Form1.CHEncamamiento.Checked = True And Form1.CHOperacion.Checked = True And Form1.CHMaternidad.Checked = True Then
            Precio(Contador) = 150 + 300 + 250
        End If

        'procederemos a guardar el descuento para cada paciente
        If Form1.RBEfectivo.Checked = True Or Form1.RBCheque.Checked = True Then
            Descuento(Contador) = 0.15
            'hacemos las operaciones para subtotal
            Subtotal(Contador) = Precio(Contador) * DiasPaciente(Contador)
            Rebaja(Contador) = Subtotal(Contador) * Descuento(Contador)
            'hacemos el total
            Total(Contador) = Subtotal(Contador) - Rebaja(Contador)
        Else
            If Form1.RBcredito.Checked = True Then
                Descuento(Contador) = 0.05
                'hacemos las operaciones para subtotal
                Subtotal(Contador) = Precio(Contador) * DiasPaciente(Contador)
                Rebaja(Contador) = Subtotal(Contador) * Descuento(Contador)
                'hacemos el total
                Total(Contador) = Subtotal(Contador) + Rebaja(Contador)

            Else
                If Form1.RBDebito.Checked = True Then
                    Descuento(Contador) = 0.08
                    'hacemos las operaciones para subtotal
                    Subtotal(Contador) = Precio(Contador) * DiasPaciente(Contador)
                    Rebaja(Contador) = Subtotal(Contador) * Descuento(Contador)
                    'hacemos el total
                    Total(Contador) = Subtotal(Contador) - Rebaja(Contador)
                End If

            End If

        End If



        'creamos un fi dondde se validara que el contador sea igual o menor a 6
        If Contador = 6 Then
            MsgBox("Llego al limite de usuarios registrados  ", MsgBoxStyle.Information, "ADVERTENCIA")
        Else
            Contador = Contador + 1
            Form1.TBNombre.Clear()
            Form1.TBNIT.Clear()
            Form1.TBDias.Clear()
            Form1.TBHonorarios.Clear()

            Form1.RBPrivada.Checked = 0
            Form1.RBsemi.Checked = 0
            Form1.RBNopriv.Checked = 0

            Form1.CHOperacion.Checked = 0
            Form1.CHEncamamiento.Checked = 0
            Form1.CHMaternidad.Checked = 0

            Form1.RBCheque.Checked = 0
            Form1.RBEfectivo.Checked = 0
            Form1.RBcredito.Checked = 0
            Form1.RBDebito.Checked = 0

        End If


    End Sub

    Public Sub Mostrar()
        Dim i = 0
        'con la ayuda de un ciclo while procederemos a mostras los datos del paciente, subtota, descuento, total
        While ((i <= (Contador - 1)))
                Form1.LISTPaciente.Items.Add("PACIENTE: " + NombrePaciente(i) + " NIT: " + NITPaciente(i) + " HOSPITALIZADO: " + DiasPaciente(i) + " dias")
                Form1.LISTSub.Items.Add(Subtotal(i))
                Form1.LISTDes.Items.Add(Rebaja(i))
                Form1.LISTTotal.Items.Add(Total(i))
                i += 1

            End While





    End Sub

    Public Sub LimpiezaEntradas()
        Form1.TBNombre.Clear()
        Form1.TBNIT.Clear()
        Form1.TBDias.Clear()
        Form1.TBHonorarios.Clear()

        Form1.LISTDes.Items.Clear()
        Form1.LISTPaciente.Items.Clear()
        Form1.LISTSub.Items.Clear()
        Form1.LISTTotal.Items.Clear()

        Form1.RBPrivada.Checked = 0
        Form1.RBsemi.Checked = 0
        Form1.RBNopriv.Checked = 0

        Form1.CHOperacion.Checked = 0
        Form1.CHEncamamiento.Checked = 0
        Form1.CHMaternidad.Checked = 0

        Form1.RBCheque.Checked = 0
        Form1.RBEfectivo.Checked = 0
        Form1.RBcredito.Checked = 0
        Form1.RBDebito.Checked = 0
    End Sub

    Public Sub LimpiezaVectores()
        For Contador = 0 To 6
            'se le asigna Nothing a cada posición del vector
            NombrePaciente(Contador) = Nothing
            NITPaciente(Contador) = Nothing
            DiasPaciente(Contador) = Nothing
            Precio(Contador) = Nothing
            Descuento(Contador) = Nothing
            Subtotal(Contador) = Nothing
            Total(Contador) = Nothing
            Rebaja(Contador) = Nothing
        Next Contador
    End Sub

End Module
