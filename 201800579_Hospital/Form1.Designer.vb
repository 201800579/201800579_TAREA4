<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LBNombrePaciente = New System.Windows.Forms.Label()
        Me.GRPPaciente = New System.Windows.Forms.GroupBox()
        Me.TBDias = New System.Windows.Forms.TextBox()
        Me.LBDias = New System.Windows.Forms.Label()
        Me.LBNIT = New System.Windows.Forms.Label()
        Me.TBNIT = New System.Windows.Forms.TextBox()
        Me.GRPHonorarios = New System.Windows.Forms.GroupBox()
        Me.LBHonorarios = New System.Windows.Forms.Label()
        Me.TBHonorarios = New System.Windows.Forms.TextBox()
        Me.GRPHabitacion = New System.Windows.Forms.GroupBox()
        Me.RBNopriv = New System.Windows.Forms.RadioButton()
        Me.RBsemi = New System.Windows.Forms.RadioButton()
        Me.RBPrivada = New System.Windows.Forms.RadioButton()
        Me.GRPPago = New System.Windows.Forms.GroupBox()
        Me.RBDebito = New System.Windows.Forms.RadioButton()
        Me.RBcredito = New System.Windows.Forms.RadioButton()
        Me.RBCheque = New System.Windows.Forms.RadioButton()
        Me.RBEfectivo = New System.Windows.Forms.RadioButton()
        Me.GRPServicio = New System.Windows.Forms.GroupBox()
        Me.CHMaternidad = New System.Windows.Forms.CheckBox()
        Me.CHOperacion = New System.Windows.Forms.CheckBox()
        Me.CHEncamamiento = New System.Windows.Forms.CheckBox()
        Me.LISTPaciente = New System.Windows.Forms.ListBox()
        Me.LBInfo = New System.Windows.Forms.Label()
        Me.LISTSub = New System.Windows.Forms.ListBox()
        Me.LISTDes = New System.Windows.Forms.ListBox()
        Me.LISTTotal = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSAgregar = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMostrar = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSLentradas = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSLBox = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSSalir = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.GRPPaciente.SuspendLayout()
        Me.GRPHonorarios.SuspendLayout()
        Me.GRPHabitacion.SuspendLayout()
        Me.GRPPago.SuspendLayout()
        Me.GRPServicio.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(189, 53)
        Me.TBNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(288, 25)
        Me.TBNombre.TabIndex = 0
        '
        'LBNombrePaciente
        '
        Me.LBNombrePaciente.AutoSize = True
        Me.LBNombrePaciente.Font = New System.Drawing.Font("HP Simplified Hans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LBNombrePaciente.Location = New System.Drawing.Point(19, 56)
        Me.LBNombrePaciente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBNombrePaciente.Name = "LBNombrePaciente"
        Me.LBNombrePaciente.Size = New System.Drawing.Size(162, 17)
        Me.LBNombrePaciente.TabIndex = 1
        Me.LBNombrePaciente.Text = "Nombre del Paciente"
        '
        'GRPPaciente
        '
        Me.GRPPaciente.Controls.Add(Me.TBDias)
        Me.GRPPaciente.Controls.Add(Me.LBDias)
        Me.GRPPaciente.Controls.Add(Me.LBNIT)
        Me.GRPPaciente.Controls.Add(Me.TBNIT)
        Me.GRPPaciente.Controls.Add(Me.LBNombrePaciente)
        Me.GRPPaciente.Controls.Add(Me.TBNombre)
        Me.GRPPaciente.Location = New System.Drawing.Point(25, 63)
        Me.GRPPaciente.Name = "GRPPaciente"
        Me.GRPPaciente.Size = New System.Drawing.Size(493, 173)
        Me.GRPPaciente.TabIndex = 2
        Me.GRPPaciente.TabStop = False
        Me.GRPPaciente.Text = "Datos del Paciente"
        '
        'TBDias
        '
        Me.TBDias.Location = New System.Drawing.Point(189, 128)
        Me.TBDias.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDias.Name = "TBDias"
        Me.TBDias.Size = New System.Drawing.Size(288, 25)
        Me.TBDias.TabIndex = 5
        Me.TBDias.Text = "0"
        '
        'LBDias
        '
        Me.LBDias.AutoSize = True
        Me.LBDias.Font = New System.Drawing.Font("HP Simplified Hans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LBDias.Location = New System.Drawing.Point(36, 128)
        Me.LBDias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBDias.Name = "LBDias"
        Me.LBDias.Size = New System.Drawing.Size(145, 17)
        Me.LBDias.TabIndex = 4
        Me.LBDias.Text = "Dias Hospitalizado"
        '
        'LBNIT
        '
        Me.LBNIT.AutoSize = True
        Me.LBNIT.Font = New System.Drawing.Font("HP Simplified Hans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LBNIT.Location = New System.Drawing.Point(52, 94)
        Me.LBNIT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBNIT.Name = "LBNIT"
        Me.LBNIT.Size = New System.Drawing.Size(129, 17)
        Me.LBNIT.TabIndex = 3
        Me.LBNIT.Text = "NIT del Paciente"
        '
        'TBNIT
        '
        Me.TBNIT.Location = New System.Drawing.Point(189, 91)
        Me.TBNIT.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNIT.Name = "TBNIT"
        Me.TBNIT.Size = New System.Drawing.Size(288, 25)
        Me.TBNIT.TabIndex = 2
        Me.TBNIT.Text = "0"
        '
        'GRPHonorarios
        '
        Me.GRPHonorarios.Controls.Add(Me.LBHonorarios)
        Me.GRPHonorarios.Controls.Add(Me.TBHonorarios)
        Me.GRPHonorarios.Location = New System.Drawing.Point(539, 105)
        Me.GRPHonorarios.Name = "GRPHonorarios"
        Me.GRPHonorarios.Size = New System.Drawing.Size(366, 93)
        Me.GRPHonorarios.TabIndex = 6
        Me.GRPHonorarios.TabStop = False
        Me.GRPHonorarios.Text = "Honorarios"
        '
        'LBHonorarios
        '
        Me.LBHonorarios.AutoSize = True
        Me.LBHonorarios.Font = New System.Drawing.Font("HP Simplified Hans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LBHonorarios.Location = New System.Drawing.Point(19, 56)
        Me.LBHonorarios.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBHonorarios.Name = "LBHonorarios"
        Me.LBHonorarios.Size = New System.Drawing.Size(144, 17)
        Me.LBHonorarios.TabIndex = 1
        Me.LBHonorarios.Text = "Honorarios Medico"
        '
        'TBHonorarios
        '
        Me.TBHonorarios.Location = New System.Drawing.Point(189, 53)
        Me.TBHonorarios.Margin = New System.Windows.Forms.Padding(4)
        Me.TBHonorarios.Name = "TBHonorarios"
        Me.TBHonorarios.Size = New System.Drawing.Size(157, 25)
        Me.TBHonorarios.TabIndex = 0
        Me.TBHonorarios.Text = "0"
        '
        'GRPHabitacion
        '
        Me.GRPHabitacion.Controls.Add(Me.RBNopriv)
        Me.GRPHabitacion.Controls.Add(Me.RBsemi)
        Me.GRPHabitacion.Controls.Add(Me.RBPrivada)
        Me.GRPHabitacion.Location = New System.Drawing.Point(147, 257)
        Me.GRPHabitacion.Name = "GRPHabitacion"
        Me.GRPHabitacion.Size = New System.Drawing.Size(181, 135)
        Me.GRPHabitacion.TabIndex = 7
        Me.GRPHabitacion.TabStop = False
        Me.GRPHabitacion.Text = "Tipo de Habitacion"
        '
        'RBNopriv
        '
        Me.RBNopriv.AutoSize = True
        Me.RBNopriv.Location = New System.Drawing.Point(22, 78)
        Me.RBNopriv.Name = "RBNopriv"
        Me.RBNopriv.Size = New System.Drawing.Size(106, 21)
        Me.RBNopriv.TabIndex = 2
        Me.RBNopriv.Text = "No Privada"
        Me.RBNopriv.UseVisualStyleBackColor = True
        '
        'RBsemi
        '
        Me.RBsemi.AutoSize = True
        Me.RBsemi.Location = New System.Drawing.Point(22, 51)
        Me.RBsemi.Name = "RBsemi"
        Me.RBsemi.Size = New System.Drawing.Size(123, 21)
        Me.RBsemi.TabIndex = 1
        Me.RBsemi.Text = "Semi Privada"
        Me.RBsemi.UseVisualStyleBackColor = True
        '
        'RBPrivada
        '
        Me.RBPrivada.AutoSize = True
        Me.RBPrivada.Location = New System.Drawing.Point(22, 24)
        Me.RBPrivada.Name = "RBPrivada"
        Me.RBPrivada.Size = New System.Drawing.Size(82, 21)
        Me.RBPrivada.TabIndex = 0
        Me.RBPrivada.Text = "Privada"
        Me.RBPrivada.UseVisualStyleBackColor = True
        '
        'GRPPago
        '
        Me.GRPPago.Controls.Add(Me.RBDebito)
        Me.GRPPago.Controls.Add(Me.RBcredito)
        Me.GRPPago.Controls.Add(Me.RBCheque)
        Me.GRPPago.Controls.Add(Me.RBEfectivo)
        Me.GRPPago.Location = New System.Drawing.Point(604, 257)
        Me.GRPPago.Name = "GRPPago"
        Me.GRPPago.Size = New System.Drawing.Size(181, 135)
        Me.GRPPago.TabIndex = 8
        Me.GRPPago.TabStop = False
        Me.GRPPago.Text = "Tipo de Pago"
        '
        'RBDebito
        '
        Me.RBDebito.AutoSize = True
        Me.RBDebito.Location = New System.Drawing.Point(22, 105)
        Me.RBDebito.Name = "RBDebito"
        Me.RBDebito.Size = New System.Drawing.Size(153, 21)
        Me.RBDebito.TabIndex = 3
        Me.RBDebito.TabStop = True
        Me.RBDebito.Text = "Tarjeta de Debito"
        Me.RBDebito.UseVisualStyleBackColor = True
        '
        'RBcredito
        '
        Me.RBcredito.AutoSize = True
        Me.RBcredito.Location = New System.Drawing.Point(22, 78)
        Me.RBcredito.Name = "RBcredito"
        Me.RBcredito.Size = New System.Drawing.Size(158, 21)
        Me.RBcredito.TabIndex = 2
        Me.RBcredito.TabStop = True
        Me.RBcredito.Text = "Tarjeta de Credito"
        Me.RBcredito.UseVisualStyleBackColor = True
        '
        'RBCheque
        '
        Me.RBCheque.AutoSize = True
        Me.RBCheque.Location = New System.Drawing.Point(22, 51)
        Me.RBCheque.Name = "RBCheque"
        Me.RBCheque.Size = New System.Drawing.Size(80, 21)
        Me.RBCheque.TabIndex = 1
        Me.RBCheque.TabStop = True
        Me.RBCheque.Text = "Cheque"
        Me.RBCheque.UseVisualStyleBackColor = True
        '
        'RBEfectivo
        '
        Me.RBEfectivo.AutoSize = True
        Me.RBEfectivo.Location = New System.Drawing.Point(22, 24)
        Me.RBEfectivo.Name = "RBEfectivo"
        Me.RBEfectivo.Size = New System.Drawing.Size(86, 21)
        Me.RBEfectivo.TabIndex = 0
        Me.RBEfectivo.TabStop = True
        Me.RBEfectivo.Text = "Efectivo"
        Me.RBEfectivo.UseVisualStyleBackColor = True
        '
        'GRPServicio
        '
        Me.GRPServicio.Controls.Add(Me.CHMaternidad)
        Me.GRPServicio.Controls.Add(Me.CHOperacion)
        Me.GRPServicio.Controls.Add(Me.CHEncamamiento)
        Me.GRPServicio.Location = New System.Drawing.Point(378, 257)
        Me.GRPServicio.Name = "GRPServicio"
        Me.GRPServicio.Size = New System.Drawing.Size(181, 135)
        Me.GRPServicio.TabIndex = 8
        Me.GRPServicio.TabStop = False
        Me.GRPServicio.Text = "Servicio"
        '
        'CHMaternidad
        '
        Me.CHMaternidad.AutoSize = True
        Me.CHMaternidad.Location = New System.Drawing.Point(26, 78)
        Me.CHMaternidad.Name = "CHMaternidad"
        Me.CHMaternidad.Size = New System.Drawing.Size(110, 21)
        Me.CHMaternidad.TabIndex = 2
        Me.CHMaternidad.Text = "Maternidad"
        Me.CHMaternidad.UseVisualStyleBackColor = True
        '
        'CHOperacion
        '
        Me.CHOperacion.AutoSize = True
        Me.CHOperacion.Location = New System.Drawing.Point(26, 52)
        Me.CHOperacion.Name = "CHOperacion"
        Me.CHOperacion.Size = New System.Drawing.Size(102, 21)
        Me.CHOperacion.TabIndex = 1
        Me.CHOperacion.Text = "Operacion"
        Me.CHOperacion.UseVisualStyleBackColor = True
        '
        'CHEncamamiento
        '
        Me.CHEncamamiento.AutoSize = True
        Me.CHEncamamiento.Location = New System.Drawing.Point(26, 25)
        Me.CHEncamamiento.Name = "CHEncamamiento"
        Me.CHEncamamiento.Size = New System.Drawing.Size(141, 21)
        Me.CHEncamamiento.TabIndex = 0
        Me.CHEncamamiento.Text = "Encamamiento "
        Me.CHEncamamiento.UseVisualStyleBackColor = True
        '
        'LISTPaciente
        '
        Me.LISTPaciente.Enabled = False
        Me.LISTPaciente.FormattingEnabled = True
        Me.LISTPaciente.ItemHeight = 17
        Me.LISTPaciente.Location = New System.Drawing.Point(15, 443)
        Me.LISTPaciente.Name = "LISTPaciente"
        Me.LISTPaciente.Size = New System.Drawing.Size(470, 123)
        Me.LISTPaciente.TabIndex = 13
        '
        'LBInfo
        '
        Me.LBInfo.AutoSize = True
        Me.LBInfo.Font = New System.Drawing.Font("HP Simplified Hans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LBInfo.Location = New System.Drawing.Point(22, 423)
        Me.LBInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBInfo.Name = "LBInfo"
        Me.LBInfo.Size = New System.Drawing.Size(158, 17)
        Me.LBInfo.TabIndex = 6
        Me.LBInfo.Text = "Informacion General"
        '
        'LISTSub
        '
        Me.LISTSub.Enabled = False
        Me.LISTSub.FormattingEnabled = True
        Me.LISTSub.ItemHeight = 17
        Me.LISTSub.Location = New System.Drawing.Point(491, 443)
        Me.LISTSub.Name = "LISTSub"
        Me.LISTSub.Size = New System.Drawing.Size(134, 123)
        Me.LISTSub.TabIndex = 14
        '
        'LISTDes
        '
        Me.LISTDes.Enabled = False
        Me.LISTDes.FormattingEnabled = True
        Me.LISTDes.ItemHeight = 17
        Me.LISTDes.Location = New System.Drawing.Point(631, 443)
        Me.LISTDes.Name = "LISTDes"
        Me.LISTDes.Size = New System.Drawing.Size(134, 123)
        Me.LISTDes.TabIndex = 15
        '
        'LISTTotal
        '
        Me.LISTTotal.Enabled = False
        Me.LISTTotal.FormattingEnabled = True
        Me.LISTTotal.ItemHeight = 17
        Me.LISTTotal.Location = New System.Drawing.Point(788, 443)
        Me.LISTTotal.Name = "LISTTotal"
        Me.LISTTotal.Size = New System.Drawing.Size(134, 123)
        Me.LISTTotal.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(501, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(615, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Descuento O Recargo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(785, 423)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Total"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSAgregar, Me.ToolStripSeparator1, Me.TSMostrar, Me.ToolStripSeparator2, Me.TSLentradas, Me.ToolStripSeparator3, Me.TSLBox, Me.ToolStripSeparator4, Me.TSSalir, Me.ToolStripSeparator5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(933, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSAgregar
        '
        Me.TSAgregar.Name = "TSAgregar"
        Me.TSAgregar.Size = New System.Drawing.Size(49, 22)
        Me.TSAgregar.Text = "Agregar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TSMostrar
        '
        Me.TSMostrar.Name = "TSMostrar"
        Me.TSMostrar.Size = New System.Drawing.Size(48, 22)
        Me.TSMostrar.Text = "Mostrar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TSLentradas
        '
        Me.TSLentradas.Name = "TSLentradas"
        Me.TSLentradas.Size = New System.Drawing.Size(95, 22)
        Me.TSLentradas.Text = "Limpiar Entradas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'TSLBox
        '
        Me.TSLBox.Name = "TSLBox"
        Me.TSLBox.Size = New System.Drawing.Size(88, 22)
        Me.TSLBox.Text = "Limpiar ListBox"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'TSSalir
        '
        Me.TSSalir.ActiveLinkColor = System.Drawing.Color.Firebrick
        Me.TSSalir.BackColor = System.Drawing.Color.DeepPink
        Me.TSSalir.ForeColor = System.Drawing.Color.Black
        Me.TSSalir.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TSSalir.Name = "TSSalir"
        Me.TSSalir.Size = New System.Drawing.Size(29, 22)
        Me.TSSalir.Text = "Salir"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(933, 583)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LISTTotal)
        Me.Controls.Add(Me.LISTDes)
        Me.Controls.Add(Me.LISTSub)
        Me.Controls.Add(Me.LBInfo)
        Me.Controls.Add(Me.LISTPaciente)
        Me.Controls.Add(Me.GRPServicio)
        Me.Controls.Add(Me.GRPPago)
        Me.Controls.Add(Me.GRPHabitacion)
        Me.Controls.Add(Me.GRPHonorarios)
        Me.Controls.Add(Me.GRPPaciente)
        Me.Font = New System.Drawing.Font("HP Simplified Hans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Hospital 201800579"
        Me.GRPPaciente.ResumeLayout(False)
        Me.GRPPaciente.PerformLayout()
        Me.GRPHonorarios.ResumeLayout(False)
        Me.GRPHonorarios.PerformLayout()
        Me.GRPHabitacion.ResumeLayout(False)
        Me.GRPHabitacion.PerformLayout()
        Me.GRPPago.ResumeLayout(False)
        Me.GRPPago.PerformLayout()
        Me.GRPServicio.ResumeLayout(False)
        Me.GRPServicio.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LBNombrePaciente As Label
    Friend WithEvents GRPPaciente As GroupBox
    Friend WithEvents LBDias As Label
    Friend WithEvents LBNIT As Label
    Friend WithEvents TBNIT As TextBox
    Friend WithEvents TBDias As TextBox
    Friend WithEvents GRPHonorarios As GroupBox
    Friend WithEvents LBHonorarios As Label
    Friend WithEvents TBHonorarios As TextBox
    Friend WithEvents GRPHabitacion As GroupBox
    Friend WithEvents RBNopriv As RadioButton
    Friend WithEvents RBsemi As RadioButton
    Friend WithEvents RBPrivada As RadioButton
    Friend WithEvents GRPPago As GroupBox
    Friend WithEvents RBDebito As RadioButton
    Friend WithEvents RBcredito As RadioButton
    Friend WithEvents RBCheque As RadioButton
    Friend WithEvents RBEfectivo As RadioButton
    Friend WithEvents GRPServicio As GroupBox
    Friend WithEvents CHMaternidad As CheckBox
    Friend WithEvents CHOperacion As CheckBox
    Friend WithEvents CHEncamamiento As CheckBox
    Friend WithEvents LISTPaciente As ListBox
    Friend WithEvents LBInfo As Label
    Friend WithEvents LISTSub As ListBox
    Friend WithEvents LISTDes As ListBox
    Friend WithEvents LISTTotal As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSAgregar As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TSMostrar As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TSLentradas As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TSLBox As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents TSSalir As ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
End Class
