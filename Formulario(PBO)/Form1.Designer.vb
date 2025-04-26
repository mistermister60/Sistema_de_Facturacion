<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbdocumento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        Me.gbxdatosdecliente = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbcategoria = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbproducto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txttotalapagar = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbximpuesto = New System.Windows.Forms.ListBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbxsubtotal = New System.Windows.Forms.ListBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNumDniFact = New System.Windows.Forms.TextBox()
        Me.txtrtnodni = New System.Windows.Forms.TextBox()
        Me.txtNombrefac = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbxPrecio = New System.Windows.Forms.ListBox()
        Me.lbxcantidad = New System.Windows.Forms.ListBox()
        Me.lbxnombproducto = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbxcontproducto = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btntotalneto = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.gbxdatosdecliente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightCyan
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(23, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 81)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de Documentacion"
        '
        'cmbdocumento
        '
        Me.cmbdocumento.BackColor = System.Drawing.SystemColors.Menu
        Me.cmbdocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdocumento.FormattingEnabled = True
        Me.cmbdocumento.Items.AddRange(New Object() {"Seleccionar", "DNI:", "RTN:"})
        Me.cmbdocumento.Location = New System.Drawing.Point(174, 39)
        Me.cmbdocumento.Name = "cmbdocumento"
        Me.cmbdocumento.Size = New System.Drawing.Size(121, 26)
        Me.cmbdocumento.TabIndex = 3
        Me.cmbdocumento.Text = "Seleccionar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Numero"
        '
        'txtnumero
        '
        Me.txtnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.Location = New System.Drawing.Point(380, 41)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(161, 26)
        Me.txtnumero.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre del Cliente"
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombrecliente.Location = New System.Drawing.Point(174, 89)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.Size = New System.Drawing.Size(179, 26)
        Me.txtnombrecliente.TabIndex = 7
        '
        'gbxdatosdecliente
        '
        Me.gbxdatosdecliente.Controls.Add(Me.Button3)
        Me.gbxdatosdecliente.Controls.Add(Me.Label7)
        Me.gbxdatosdecliente.Controls.Add(Me.btneliminar)
        Me.gbxdatosdecliente.Controls.Add(Me.Label2)
        Me.gbxdatosdecliente.Controls.Add(Me.txtnombrecliente)
        Me.gbxdatosdecliente.Controls.Add(Me.cmbdocumento)
        Me.gbxdatosdecliente.Controls.Add(Me.Label4)
        Me.gbxdatosdecliente.Controls.Add(Me.Label3)
        Me.gbxdatosdecliente.Controls.Add(Me.txtnumero)
        Me.gbxdatosdecliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxdatosdecliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbxdatosdecliente.Location = New System.Drawing.Point(14, 132)
        Me.gbxdatosdecliente.Name = "gbxdatosdecliente"
        Me.gbxdatosdecliente.Size = New System.Drawing.Size(548, 162)
        Me.gbxdatosdecliente.TabIndex = 8
        Me.gbxdatosdecliente.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SpringGreen
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(369, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 67)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Agregar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label7.Location = New System.Drawing.Point(6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 22)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Datos del Cliente"
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.Tomato
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btneliminar.Location = New System.Drawing.Point(458, 89)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(83, 67)
        Me.btneliminar.TabIndex = 8
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbcategoria)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbproducto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 316)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 165)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'cmbcategoria
        '
        Me.cmbcategoria.BackColor = System.Drawing.SystemColors.Menu
        Me.cmbcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcategoria.FormattingEnabled = True
        Me.cmbcategoria.Items.AddRange(New Object() {"Seleccionar", "Gripe, Alergia y tos", "Dolor y Fiebre", "Dermatologicos"})
        Me.cmbcategoria.Location = New System.Drawing.Point(109, 36)
        Me.cmbcategoria.Name = "cmbcategoria"
        Me.cmbcategoria.Size = New System.Drawing.Size(121, 26)
        Me.cmbcategoria.TabIndex = 15
        Me.cmbcategoria.Text = "Seleccionar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Categoria"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightCoral
        Me.Label8.Location = New System.Drawing.Point(5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 22)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Datos del Producto"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SpringGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(318, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 67)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Agregar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(407, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 67)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Eliminar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(390, 35)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(121, 26)
        Me.txtcantidad.TabIndex = 12
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(307, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cantidad"
        '
        'txtprecio
        '
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(109, 117)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.ReadOnly = True
        Me.txtprecio.Size = New System.Drawing.Size(121, 26)
        Me.txtprecio.TabIndex = 9
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Precio"
        '
        'cmbproducto
        '
        Me.cmbproducto.BackColor = System.Drawing.SystemColors.Menu
        Me.cmbproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbproducto.FormattingEnabled = True
        Me.cmbproducto.Items.AddRange(New Object() {"Seleccionar"})
        Me.cmbproducto.Location = New System.Drawing.Point(109, 77)
        Me.cmbproducto.Name = "cmbproducto"
        Me.cmbproducto.Size = New System.Drawing.Size(121, 26)
        Me.cmbproducto.TabIndex = 9
        Me.cmbproducto.Text = "Seleccionar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Producto"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.txtfecha)
        Me.Panel2.Controls.Add(Me.txttotalapagar)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.lbximpuesto)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.lbxsubtotal)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtNumDniFact)
        Me.Panel2.Controls.Add(Me.txtrtnodni)
        Me.Panel2.Controls.Add(Me.txtNombrefac)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.lbxPrecio)
        Me.Panel2.Controls.Add(Me.lbxcantidad)
        Me.Panel2.Controls.Add(Me.lbxnombproducto)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.lbxcontproducto)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel2.Location = New System.Drawing.Point(589, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(387, 555)
        Me.Panel2.TabIndex = 10
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.LightCoral
        Me.Label24.Location = New System.Drawing.Point(256, 100)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 17)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "Fecha:"
        '
        'txtfecha
        '
        Me.txtfecha.BackColor = System.Drawing.Color.PaleGreen
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.Location = New System.Drawing.Point(311, 97)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.ReadOnly = True
        Me.txtfecha.Size = New System.Drawing.Size(69, 20)
        Me.txtfecha.TabIndex = 33
        '
        'txttotalapagar
        '
        Me.txttotalapagar.BackColor = System.Drawing.Color.PaleGreen
        Me.txttotalapagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalapagar.Location = New System.Drawing.Point(135, 507)
        Me.txttotalapagar.Name = "txttotalapagar"
        Me.txttotalapagar.ReadOnly = True
        Me.txttotalapagar.Size = New System.Drawing.Size(161, 26)
        Me.txttotalapagar.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightCoral
        Me.Label19.Location = New System.Drawing.Point(39, 513)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 16)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Total a pagar:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LightCoral
        Me.Label18.Location = New System.Drawing.Point(249, 190)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 14)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "ISV/15%"
        '
        'lbximpuesto
        '
        Me.lbximpuesto.BackColor = System.Drawing.Color.PaleGreen
        Me.lbximpuesto.FormattingEnabled = True
        Me.lbximpuesto.ItemHeight = 16
        Me.lbximpuesto.Location = New System.Drawing.Point(252, 208)
        Me.lbximpuesto.Name = "lbximpuesto"
        Me.lbximpuesto.Size = New System.Drawing.Size(44, 276)
        Me.lbximpuesto.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LightCoral
        Me.Label17.Location = New System.Drawing.Point(304, 189)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 15)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Sub-total"
        '
        'lbxsubtotal
        '
        Me.lbxsubtotal.BackColor = System.Drawing.Color.PaleGreen
        Me.lbxsubtotal.FormattingEnabled = True
        Me.lbxsubtotal.ItemHeight = 16
        Me.lbxsubtotal.Location = New System.Drawing.Point(302, 208)
        Me.lbxsubtotal.Name = "lbxsubtotal"
        Me.lbxsubtotal.Size = New System.Drawing.Size(65, 276)
        Me.lbxsubtotal.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightCoral
        Me.Label16.Location = New System.Drawing.Point(178, 189)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 15)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Precio Uni"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightCoral
        Me.Label15.Location = New System.Drawing.Point(144, 188)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 16)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Cant"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightCoral
        Me.Label14.Location = New System.Drawing.Point(39, 188)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 15)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Nombre Producto"
        '
        'txtNumDniFact
        '
        Me.txtNumDniFact.BackColor = System.Drawing.Color.PaleGreen
        Me.txtNumDniFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDniFact.Location = New System.Drawing.Point(85, 137)
        Me.txtNumDniFact.Name = "txtNumDniFact"
        Me.txtNumDniFact.ReadOnly = True
        Me.txtNumDniFact.Size = New System.Drawing.Size(161, 26)
        Me.txtNumDniFact.TabIndex = 23
        '
        'txtrtnodni
        '
        Me.txtrtnodni.BackColor = System.Drawing.Color.PaleGreen
        Me.txtrtnodni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrtnodni.Location = New System.Drawing.Point(18, 137)
        Me.txtrtnodni.Name = "txtrtnodni"
        Me.txtrtnodni.ReadOnly = True
        Me.txtrtnodni.Size = New System.Drawing.Size(47, 26)
        Me.txtrtnodni.TabIndex = 22
        '
        'txtNombrefac
        '
        Me.txtNombrefac.BackColor = System.Drawing.Color.PaleGreen
        Me.txtNombrefac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrefac.Location = New System.Drawing.Point(85, 95)
        Me.txtNombrefac.Name = "txtNombrefac"
        Me.txtNombrefac.ReadOnly = True
        Me.txtNombrefac.Size = New System.Drawing.Size(161, 26)
        Me.txtNombrefac.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightCoral
        Me.Label13.Location = New System.Drawing.Point(15, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 17)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Nombre:"
        '
        'lbxPrecio
        '
        Me.lbxPrecio.BackColor = System.Drawing.Color.PaleGreen
        Me.lbxPrecio.FormattingEnabled = True
        Me.lbxPrecio.ItemHeight = 16
        Me.lbxPrecio.Location = New System.Drawing.Point(181, 206)
        Me.lbxPrecio.Name = "lbxPrecio"
        Me.lbxPrecio.Size = New System.Drawing.Size(65, 276)
        Me.lbxPrecio.TabIndex = 20
        '
        'lbxcantidad
        '
        Me.lbxcantidad.BackColor = System.Drawing.Color.PaleGreen
        Me.lbxcantidad.FormattingEnabled = True
        Me.lbxcantidad.ItemHeight = 16
        Me.lbxcantidad.Location = New System.Drawing.Point(144, 206)
        Me.lbxcantidad.Name = "lbxcantidad"
        Me.lbxcantidad.Size = New System.Drawing.Size(31, 276)
        Me.lbxcantidad.TabIndex = 19
        '
        'lbxnombproducto
        '
        Me.lbxnombproducto.BackColor = System.Drawing.Color.PaleGreen
        Me.lbxnombproducto.FormattingEnabled = True
        Me.lbxnombproducto.ItemHeight = 16
        Me.lbxnombproducto.Location = New System.Drawing.Point(42, 206)
        Me.lbxnombproducto.Name = "lbxnombproducto"
        Me.lbxnombproducto.Size = New System.Drawing.Size(96, 276)
        Me.lbxnombproducto.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightCoral
        Me.Label12.Location = New System.Drawing.Point(14, 185)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 18)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "nº"
        '
        'lbxcontproducto
        '
        Me.lbxcontproducto.BackColor = System.Drawing.Color.PaleGreen
        Me.lbxcontproducto.FormattingEnabled = True
        Me.lbxcontproducto.ItemHeight = 16
        Me.lbxcontproducto.Location = New System.Drawing.Point(11, 206)
        Me.lbxcontproducto.Name = "lbxcontproducto"
        Me.lbxcontproducto.Size = New System.Drawing.Size(25, 276)
        Me.lbxcontproducto.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(38, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(294, 19)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Formulario de Facturacion al contado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Salmon
        Me.Label10.Location = New System.Drawing.Point(129, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 25)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Farmacias Siman"
        '
        'btntotalneto
        '
        Me.btntotalneto.BackColor = System.Drawing.Color.SpringGreen
        Me.btntotalneto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntotalneto.Image = CType(resources.GetObject("btntotalneto.Image"), System.Drawing.Image)
        Me.btntotalneto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btntotalneto.Location = New System.Drawing.Point(589, 586)
        Me.btntotalneto.Name = "btntotalneto"
        Me.btntotalneto.Size = New System.Drawing.Size(83, 77)
        Me.btntotalneto.TabIndex = 16
        Me.btntotalneto.Text = "Total neto"
        Me.btntotalneto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btntotalneto.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Location = New System.Drawing.Point(23, 520)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(532, 143)
        Me.Panel3.TabIndex = 17
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.OliveDrab
        Me.Label23.Location = New System.Drawing.Point(140, 38)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(0, 21)
        Me.Label23.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label22.Location = New System.Drawing.Point(111, 96)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(309, 21)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Clase de Progamacion Estructurada"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label21.Location = New System.Drawing.Point(152, 66)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(230, 21)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Hecho por: Carlos Fuentes"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label20.Location = New System.Drawing.Point(96, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(324, 21)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Formulario de Facturacion al contado"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Tomato
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(873, 586)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 77)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Salir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(736, 586)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(83, 77)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Limpiar Lista"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(981, 699)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btntotalneto)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxdatosdecliente)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Formulario de Factura"
        Me.gbxdatosdecliente.ResumeLayout(False)
        Me.gbxdatosdecliente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbdocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnombrecliente As System.Windows.Forms.TextBox
    Friend WithEvents gbxdatosdecliente As System.Windows.Forms.GroupBox
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbproducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbcategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbxcontproducto As System.Windows.Forms.ListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbxnombproducto As System.Windows.Forms.ListBox
    Friend WithEvents lbxcantidad As System.Windows.Forms.ListBox
    Friend WithEvents lbxPrecio As System.Windows.Forms.ListBox
    Friend WithEvents txtNombrefac As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtrtnodni As System.Windows.Forms.TextBox
    Friend WithEvents txtNumDniFact As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lbxsubtotal As System.Windows.Forms.ListBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbximpuesto As System.Windows.Forms.ListBox
    Friend WithEvents txttotalapagar As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btntotalneto As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label

End Class
