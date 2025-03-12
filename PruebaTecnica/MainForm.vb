Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports MySql.Data.MySqlClient

Partial Public Class MainForm

#Region "Fields"
    Private session As New UnitOfWork
#End Region

#Region "Methods"
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Try
            Dim connectionString = Environment.GetEnvironmentVariable("PruebaTecnica", EnvironmentVariableTarget.Machine)
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(New MySqlConnection(connectionString), AutoCreateOption.DatabaseAndSchema)
            Me.LoadData()
            Me.ConfigGridViewProgramas()
            Me.ConfigGridViewPersonal()
            Me.ConfigGridViewAccesos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overrides Sub OnClosed(e As EventArgs)
        MyBase.OnClosed(e)
        Me.session.Dispose()
        Me.session = Nothing
    End Sub

    Private Sub LoadData()
        Try
            If Not Me.session.Query(Of Programa).Any() Then
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Nomenclatura"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Tipos de Polizas"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Proveedores"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Clientes"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Activos Fijos"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Transferencia"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Depreciación"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Confirmación de Embarque"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Facturación"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Departamentos"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Usuarios"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Puestos"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Ayuda en Linea"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Accesos y Privilegios"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Pedidos de Clientes"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Libro de Exportaciones"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Pedido de Cliente (Proforma)"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Parámetros"})
                Me.session.Save(New Programa(Me.session) With {.Descripcion = "Póliza de Importación"})
                Me.session.CommitChanges()
            End If

            If Not Me.session.Query(Of Personal).Any() Then
                Me.session.Save(New Personal(Me.session) With {.Usuario = "sergio.deleon", .Apellido1 = "De León", .Apellido2 = "", .Nombre1 = "Sergio", .Nombre2 = "", .Habilitado = False})
                Me.session.Save(New Personal(Me.session) With {.Usuario = "smazariegos", .Apellido1 = "mazariegos", .Apellido2 = "", .Nombre1 = "Susana", .Nombre2 = "", .Habilitado = False})
                Me.session.Save(New Personal(Me.session) With {.Usuario = "evela", .Apellido1 = "Vela", .Apellido2 = "", .Nombre1 = "Emilio", .Nombre2 = "", .Habilitado = True})
                Me.session.CommitChanges()
            End If

            If Not Me.session.Query(Of Acceso).Any() Then
                Me.session.Save(New Acceso(Me.session) With {.Usuario = Me.session.Query(Of Personal).Where(Function(f) f.Usuario = "sergio.deleon").First(),
                                .Programa = Me.session.Query(Of Programa).Where(Function(f) f.Descripcion = "Póliza de Importación").First(),
                                .Insertar = True,
                                .Editar = False,
                                .Borrar = False,
                                .Buscar = False})
                Me.session.Save(New Acceso(Me.session) With {.Usuario = Me.session.Query(Of Personal).Where(Function(f) f.Usuario = "smazariegos").First(),
                                .Programa = Me.session.Query(Of Programa).Where(Function(f) f.Descripcion = "Confirmación de Embarque").First(),
                                .Insertar = False,
                                .Editar = True,
                                .Borrar = False,
                                .Buscar = False})
                Me.session.Save(New Acceso(Me.session) With {.Usuario = Me.session.Query(Of Personal).Where(Function(f) f.Usuario = "evela").First(),
                                .Programa = Me.session.Query(Of Programa).Where(Function(f) f.Descripcion = "Pedido de Cliente (Proforma)").First(),
                                .Insertar = False,
                                .Editar = False,
                                .Borrar = True,
                                .Buscar = False})
                Me.session.CommitChanges()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigDataGridView(ByRef dataGridView As DataGridView)
        Try
            dataGridView.DefaultCellStyle.ForeColor = Color.Blue
            dataGridView.DefaultCellStyle.BackColor = Color.Beige
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Yellow
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.Black
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigGridViewProgramas()
        Try
            Me.GridViewProgramas.DataSource = New XPCollection(Of Programa)(Me.session)
            For Each item As DataGridViewColumn In Me.GridViewProgramas.Columns
                Select Case item.DataPropertyName
                    Case "ProgramaID"
                        item.HeaderText = "ID"
                        item.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Descripcion"
                        item.HeaderText = "Descripción"
                        item.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End Select
            Next
            Me.ConfigDataGridView(Me.GridViewProgramas)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigGridViewPersonal()
        Try
            Me.GridViewPersonal.DataSource = New XPCollection(Of Personal)(Me.session)
            For Each item As DataGridViewColumn In Me.GridViewPersonal.Columns
                Select Case item.DataPropertyName
                    Case "PersonalID"
                        item.HeaderText = "ID"
                        item.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Usuario"
                        item.HeaderText = "Usuario"
                        item.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Apellido1"
                        item.HeaderText = "Apellido 1"
                        item.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Apellido2"
                        item.HeaderText = "Apellido 2"
                        item.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Nombre1"
                        item.HeaderText = "Nombre 1"
                        item.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Nombre2"
                        item.HeaderText = "Nombre 2"
                        item.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Habilitado"
                        item.HeaderText = "Habilitado"
                        item.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End Select
            Next
            Me.ConfigDataGridView(Me.GridViewPersonal)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigGridViewAccesos()
        Try
            Me.GridViewAccesos.AutoGenerateColumns = False
            Me.GridViewAccesos.DataSource = New XPCollection(Of Acceso)(Me.session)

            Me.GridViewAccesos.Columns.Add(New DataGridViewTextBoxColumn() With {
                .HeaderText = "ID",
                .DataPropertyName = "AccesoID",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells})

            Me.GridViewAccesos.Columns.Add(New DataGridViewComboBoxColumn() With {
                .HeaderText = "Usuario (Personal)",
                .DataPropertyName = "Usuario!Key",
                .DataSource = New XPCollection(Of Personal)(Me.session),
                .DisplayMember = "Usuario",
                .ValueMember = "PersonalID",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells})

            Me.GridViewAccesos.Columns.Add(New DataGridViewComboBoxColumn() With {
                .HeaderText = "Programa",
                .DataPropertyName = "Programa!Key",
                .DataSource = New XPCollection(Of Programa)(Me.session),
                .DisplayMember = "Descripcion",
                .ValueMember = "ProgramaID",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells})

            Me.GridViewAccesos.Columns.Add(New DataGridViewCheckBoxColumn() With {
               .HeaderText = "Insertar",
               .DataPropertyName = "Insertar",
               .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells})

            Me.GridViewAccesos.Columns.Add(New DataGridViewCheckBoxColumn() With {
               .HeaderText = "Editar",
               .DataPropertyName = "Editar",
               .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells})

            Me.GridViewAccesos.Columns.Add(New DataGridViewCheckBoxColumn() With {
               .HeaderText = "Borrar",
               .DataPropertyName = "Borrar",
               .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells})

            Me.GridViewAccesos.Columns.Add(New DataGridViewCheckBoxColumn() With {
               .HeaderText = "Buscar",
               .DataPropertyName = "Buscar",
               .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells})

            Me.ConfigDataGridView(Me.GridViewAccesos)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CrearPrograma_Click(sender As Object, e As EventArgs) Handles CrearPrograma.Click
        Try
            Dim dataSource = CType(Me.GridViewProgramas.DataSource, XPCollection(Of Programa))
            dataSource.Add(New Programa(Me.session))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GuardarPrograma_Click(sender As Object, e As EventArgs) Handles GuardarPrograma.Click
        Try
            Me.GridViewProgramas.EndEdit()
            Me.session.CommitChanges()
            MessageBox.Show("Registro guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EliminarPrograma_Click(sender As Object, e As EventArgs) Handles EliminarPrograma.Click
        Try
            Me.GridViewProgramas.EndEdit()
            For Each row As DataGridViewRow In Me.GridViewProgramas.SelectedRows
                Me.session.Delete(row.DataBoundItem)
            Next
            Me.session.CommitChanges()
            MessageBox.Show("Registro eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CrearPersonal_Click(sender As Object, e As EventArgs) Handles CrearPersonal.Click
        Try
            Dim dataSource = CType(Me.GridViewPersonal.DataSource, XPCollection(Of Personal))
            dataSource.Add(New Personal(Me.session))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GuardarPersonal_Click(sender As Object, e As EventArgs) Handles GuardarPersonal.Click
        Try
            Me.GridViewPersonal.EndEdit()
            Me.session.CommitChanges()
            MessageBox.Show("Registro guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EliminarPersonal_Click(sender As Object, e As EventArgs) Handles EliminarPersonal.Click
        Try
            Me.GridViewPersonal.EndEdit()
            For Each row As DataGridViewRow In Me.GridViewPersonal.SelectedRows
                Me.session.Delete(row.DataBoundItem)
            Next
            Me.session.CommitChanges()
            MessageBox.Show("Registro eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CrearAcceso_Click(sender As Object, e As EventArgs) Handles CrearAcceso.Click
        Try
            Dim dataSource = CType(Me.GridViewAccesos.DataSource, XPCollection(Of Acceso))
            dataSource.Add(New Acceso(Me.session))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GuardarAcceso_Click(sender As Object, e As EventArgs) Handles GuardarAcceso.Click
        Try
            Me.GridViewAccesos.EndEdit()
            Me.session.CommitChanges()
            MessageBox.Show("Registro guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EliminarAcceso_Click(sender As Object, e As EventArgs) Handles EliminarAcceso.Click
        Try
            Me.GridViewAccesos.EndEdit()
            For Each row As DataGridViewRow In Me.GridViewAccesos.SelectedRows
                Me.session.Delete(row.DataBoundItem)
            Next
            Me.session.CommitChanges()
            MessageBox.Show("Registro eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

End Class
