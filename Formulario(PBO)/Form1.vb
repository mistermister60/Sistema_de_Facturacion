Public Class Form1
    Public Agreg_Producto As Integer
    Public Nombre As String
    Public Acumultotal As Long
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdocumento.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub


    Private Sub txtnumero_TextChanged(sender As Object, e As EventArgs) Handles txtnumero.TextChanged


    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        txtnumero.Clear()
        txtnombrecliente.Clear()
        txtNombrefac.Clear()
        txtrtnodni.Clear()
        txtNumDniFact.Clear()

        cmbdocumento.SelectedIndex = 0
        Refresh()
    End Sub


    Public Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbproducto.SelectedIndexChanged
        If (cmbcategoria.SelectedIndex = 1) Then
            Select Case (cmbproducto.SelectedIndex)
                Case 0
                    txtprecio.Text = 0.0 & " Lps."
                Case 1
                    txtprecio.Text = 81 & " Lps."
                Case 2
                    txtprecio.Text = 6 & " Lps."
                Case 3
                    txtprecio.Text = 400 & " Lps."
                Case 4
                    txtprecio.Text = 144 & " Lps."
                Case 5
                    txtprecio.Text = 94 & " Lps."
            End Select
        End If
        If (cmbcategoria.SelectedIndex = 2) Then
            Select Case (cmbproducto.SelectedIndex)
                Case 0
                    txtprecio.Text = 0.0 & " Lps."
                Case 1
                    txtprecio.Text = 261 & " Lps."
                Case 2
                    txtprecio.Text = 273 & " Lps."
                Case 3
                    txtprecio.Text = 53 & " Lps."
                Case 4
                    txtprecio.Text = 156 & " Lps."
                Case 5
                    txtprecio.Text = 557 & " Lps."
            End Select
        End If
        If (cmbcategoria.SelectedIndex = 3) Then
            Select Case (cmbproducto.SelectedIndex)
                Case 0
                    txtprecio.Text = 0.0 & " Lps."
                Case 1
                    txtprecio.Text = 111 & " Lps."
                Case 2
                    txtprecio.Text = 312 & " Lps."
                Case 3
                    txtprecio.Text = 175 & " Lps."
                Case 4
                    txtprecio.Text = 227 & " Lps."
                Case 5
                    txtprecio.Text = 290 & " Lps."
            End Select
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim impuesto As Double = Val(txtprecio.Text) * Val(txtcantidad.Text) * 0.15
        lbxcontproducto.Items.Remove(Agreg_Producto)
        lbxnombproducto.Items.Remove(cmbproducto.SelectedItem.ToString)
        lbxcantidad.Items.Remove(txtcantidad.Text)
        lbxPrecio.Items.Remove(txtprecio.Text & "Lps.")
        lbxsubtotal.Items.Remove(Val(txtprecio.Text) * Val(txtcantidad.Text) & " Lps.")
        lbximpuesto.Items.Remove(Math.Round(impuesto, MidpointRounding.AwayFromZero).ToString() & " Lps.")
        Acumultotal -= Val(txtprecio.Text) * Val(txtcantidad.Text) * 0.15 + Val(txtprecio.Text) * Val(txtcantidad.Text)
        Refresh()
        Agreg_Producto -= 1
        If (Agreg_Producto < 0) Then
            Agreg_Producto = 0
        End If
        If (Acumultotal < 0) Then
            Acumultotal = 0
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub


    Public Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategoria.SelectedIndexChanged
        Select Case (cmbcategoria.SelectedIndex)
            Case 0
                cmbproducto.Items.Clear()
            Case 1
                cmbproducto.Items.Clear()
                cmbproducto.Items.Add("Seleccionar")
                cmbproducto.Items.Add("Alergil") '81.92
                cmbproducto.Items.Add("Sudagrip") ' 6.38
                cmbproducto.Items.Add("Abrilar Jarabe") ' 400.61
                cmbproducto.Items.Add("Vick Vaporub") '144.59
                cmbproducto.Items.Add("Tag Balsamico") '94.94
            Case 2
                cmbproducto.Items.Clear()
                cmbproducto.Items.Add("Seleccionar")
                cmbproducto.Items.Add("Ibuprofeno") ' 261.3
                cmbproducto.Items.Add("Cataflam") ' 273.04
                cmbproducto.Items.Add("Panadol") ' 53.33
                cmbproducto.Items.Add("Rocefort") ' 156.66
                cmbproducto.Items.Add("Paracetamol") ' 557.31
            Case 3
                cmbproducto.Items.Clear()
                cmbproducto.Items.Add("Seleccionar")
                cmbproducto.Items.Add("Betaderm") '111.97
                cmbproducto.Items.Add("Trigentax") '312.83
                cmbproducto.Items.Add("Fungifar") '175.84
                cmbproducto.Items.Add("Beclogen Trio") '227.05
                cmbproducto.Items.Add("Betasola Trio") '290.12
        End Select
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Categoria, producto As Integer
        Categoria = cmbcategoria.SelectedIndex
        producto = cmbcategoria.SelectedIndex
        If Not IsNumeric(txtcantidad.Text) Then
            txtcantidad.Text = 0
            MessageBox.Show("Ingrese solo numeros porfavor.")
        End If
        If (txtcantidad.Text.Contains(".") Or txtcantidad.Text.Contains(",")) Then
            txtcantidad.Text = 0
            MessageBox.Show("La cantidad NO puede ser decimal.")
        End If
        If (txtcantidad.Text = "") Then
            txtcantidad.Text = 0
        End If
        If (txtcantidad.Text > 0 And cmbcategoria.SelectedIndex > 0 And cmbproducto.SelectedIndex > 0) Then
            Acumultotal += Val(txtprecio.Text) * Val(txtcantidad.Text) * 0.15 + Val(txtprecio.Text) * Val(txtcantidad.Text)
            Agreg_Producto += 1
            lbxcontproducto.Items.Add(Agreg_Producto)
            lbxnombproducto.Items.Add(cmbproducto.SelectedItem.ToString)
            lbxcantidad.Items.Add(txtcantidad.Text)
            lbxPrecio.Items.Add(txtprecio.Text & "Lps.")
            lbxsubtotal.Items.Add(Val(txtprecio.Text) * Val(txtcantidad.Text) & " Lps.")
            Dim impuesto As Double = Val(txtprecio.Text) * Val(txtcantidad.Text) * 0.15
            lbximpuesto.Items.Add(Math.Round(impuesto, MidpointRounding.AwayFromZero).ToString() & " Lps.")
        End If
        If (txtcantidad.Text < 0) Then
            txtcantidad.Text = 0
        End If
    End Sub

    Private Sub lbxcontproducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxcontproducto.SelectedIndexChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub lbxcantidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxcantidad.SelectedIndexChanged

    End Sub


    Public Sub txtnombrecliente_TextChanged(sender As Object, e As EventArgs) Handles txtnombrecliente.TextChanged
        Nombre = txtnombrecliente.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If txtnumero.Text <> "" AndAlso Not IsNumeric(txtnumero.Text) Then
            MessageBox.Show("El numero del DNI deben ser numeros")
            txtnumero.Text = ""
        End If
        If IsNumeric(txtnombrecliente.Text) Then
            MessageBox.Show("El Nombre del cliente no deben ser numeros")
            txtnombrecliente.Text = ""
        End If
        If (cmbdocumento.SelectedIndex = 0) Then
            txtrtnodni.Text = ""
            txtNombrefac.Text = ""
            txtNumDniFact.Text = ""
        End If
        If (cmbdocumento.SelectedIndex = 0) Then
            MessageBox.Show("Porfavor eliga un tipo de documento.")
        End If
        If (cmbdocumento.SelectedIndex > 0) Then
            txtNombrefac.Text = Nombre
            txtrtnodni.Text = cmbdocumento.SelectedItem.ToString
            txtNumDniFact.Text = txtnumero.Text
        End If
    End Sub


    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txttotalapagar.TextChanged

    End Sub

    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles btntotalneto.Click
        txttotalapagar.Text = Acumultotal & " Lps."
    End Sub

    Private Sub lbxsubtotal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxsubtotal.SelectedIndexChanged

    End Sub

    Private Sub lbxnombproducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxnombproducto.SelectedIndexChanged

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Public Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        lbxcantidad.Items.Clear()
        lbxcontproducto.Items.Clear()
        lbximpuesto.Items.Clear()
        lbxnombproducto.Items.Clear()
        lbxPrecio.Items.Clear()
        lbxsubtotal.Items.Clear()
        Acumultotal = 0
        txttotalapagar.Text = ""
        txtNombrefac.Clear()
        txtrtnodni.Clear()
        txtNumDniFact.Clear()
        Agreg_Producto -= 1
        If (Agreg_Producto < 0) Then
            Agreg_Producto = 0
        End If
        If (Agreg_Producto > 0) Then
            Agreg_Producto = 0
        End If
        If (Acumultotal < 0) Then
            Acumultotal = 0
        End If
        Refresh()
    End Sub

    Private Sub lbximpuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbximpuesto.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfecha.Text = DateTime.Today.ToString("dd/MM/yyyy")
    End Sub
End Class
