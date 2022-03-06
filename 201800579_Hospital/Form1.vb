Public Class Form1
    'vaalidamos que solo se ingresesn valores numericos en el textbox para dias
    Private Sub TBDias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDias.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'vaalidamos que solo se ingresesn valores numericos en el textbox para los honorarios
    Private Sub TBHonorarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBHonorarios.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'vaalidamos que solo se ingresesn valores numericos en el textbox para el NIT
    Private Sub TBNIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNIT.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TSAgregar_Click(sender As Object, e As EventArgs) Handles TSAgregar.Click
        'verificamos que se llenen los campos soolicitados y si no se hace mostramos un mensaje
        If TBNombre.Text = "" Then
            MsgBox("Pofavor Ingrese un nombre para el Paciente", MsgBoxStyle.Information, "Advertencia")
            TBNombre.Focus()
        Else
            If TBNIT.Text = 0 Then
                MsgBox("Pofavor Ingrese el NIT para el Paciente", MsgBoxStyle.Information, "Advertencia")
                TBNIT.Focus()
            Else
                If TBDias.Text = 0 Then
                    MsgBox("Pofavor Ingrese los dias Hospitalizados que estubo el Paciente", MsgBoxStyle.Information, "Advertencia")
                    TBDias.Focus()
                Else
                    If TBHonorarios.Text = 0 Then
                        MsgBox("Pofavor Ingrese los honorarios del medico", MsgBoxStyle.Information, "Advertencia")
                        TBHonorarios.Focus()
                    Else
                        'verfificamos que se selecciones tipo de habitacion y si no se hace mostramos un mensaje
                        If ((RBPrivada.Checked = True) Or (RBsemi.Checked = True) Or (RBNopriv.Checked = True)) Then
                            'verificamos que se seleccione un servicio y si no se hace mostramos un mensaje
                            If ((CHEncamamiento.Checked = True) Or (CHOperacion.Checked = True) Or (CHMaternidad.Checked = True)) Then
                                'verificamos que se seleccione la forma de Pago y si no se hace mostramos un mensaje
                                If ((RBEfectivo.Checked = True) Or (RBCheque.Checked = True) Or (RBcredito.Checked = True) Or (RBDebito.Checked = True)) Then
                                    Agregar()
                                Else
                                    MsgBox("Pofavor Seleccione el Tipo de Pago", MsgBoxStyle.Information, "Advertencia")
                                End If
                            Else
                                MsgBox("Pofavor Seleccione el Tipo de Servicio", MsgBoxStyle.Information, "Advertencia")
                            End If
                        Else
                            MsgBox("Pofavor Seleccione el Tipo de Habitacion", MsgBoxStyle.Information, "Advertencia")

                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TSMostrar_Click(sender As Object, e As EventArgs) Handles TSMostrar.Click
        'llamamos el metodo
        Mostrar()
    End Sub

    Private Sub TSLentradas_Click(sender As Object, e As EventArgs) Handles TSLentradas.Click
        'llamamos el metodo
        LimpiezaEntradas()
    End Sub

    Private Sub TSLBox_Click(sender As Object, e As EventArgs) Handles TSLBox.Click
        'llamamos el metodo
        LimpiezaVectores()
    End Sub

    Private Sub TSSalir_Click(sender As Object, e As EventArgs) Handles TSSalir.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Close()
        Else
            LimpiezaEntradas()
            LimpiezaVectores()
        End If
    End Sub
End Class
