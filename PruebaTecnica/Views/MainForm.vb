Partial Public Class MainForm
    Inherits Form

    Public Sub New()
        Me.InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        TabControl1 = New TabControl()
        TabPrograma = New TabPage()
        GridViewProgramas = New DataGridView()
        ToolStrip1 = New ToolStrip()
        CrearPrograma = New ToolStripButton()
        GuardarPrograma = New ToolStripButton()
        EliminarPrograma = New ToolStripButton()
        toolStripSeparator = New ToolStripSeparator()
        TabPersonal = New TabPage()
        GridViewPersonal = New DataGridView()
        ToolStrip2 = New ToolStrip()
        CrearPersonal = New ToolStripButton()
        GuardarPersonal = New ToolStripButton()
        EliminarPersonal = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        TabAcceso = New TabPage()
        GridViewAccesos = New DataGridView()
        ToolStrip3 = New ToolStrip()
        CrearAcceso = New ToolStripButton()
        GuardarAcceso = New ToolStripButton()
        EliminarAcceso = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        TabControl1.SuspendLayout()
        TabPrograma.SuspendLayout()
        CType(GridViewProgramas, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        TabPersonal.SuspendLayout()
        CType(GridViewPersonal, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip2.SuspendLayout()
        TabAcceso.SuspendLayout()
        CType(GridViewAccesos, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPrograma)
        TabControl1.Controls.Add(TabPersonal)
        TabControl1.Controls.Add(TabAcceso)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1064, 681)
        TabControl1.TabIndex = 1
        ' 
        ' TabPrograma
        ' 
        TabPrograma.Controls.Add(GridViewProgramas)
        TabPrograma.Controls.Add(ToolStrip1)
        TabPrograma.Location = New Point(4, 24)
        TabPrograma.Name = "TabPrograma"
        TabPrograma.Padding = New Padding(3)
        TabPrograma.Size = New Size(1056, 653)
        TabPrograma.TabIndex = 0
        TabPrograma.Text = "Programas"
        TabPrograma.UseVisualStyleBackColor = True
        ' 
        ' GridViewProgramas
        ' 
        GridViewProgramas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        GridViewProgramas.Dock = DockStyle.Fill
        GridViewProgramas.Location = New Point(3, 28)
        GridViewProgramas.Name = "GridViewProgramas"
        GridViewProgramas.Size = New Size(1050, 622)
        GridViewProgramas.TabIndex = 1
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {CrearPrograma, GuardarPrograma, EliminarPrograma, toolStripSeparator})
        ToolStrip1.Location = New Point(3, 3)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1050, 25)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' CrearPrograma
        ' 
        CrearPrograma.DisplayStyle = ToolStripItemDisplayStyle.Image
        CrearPrograma.Image = CType(resources.GetObject("CrearPrograma.Image"), Image)
        CrearPrograma.ImageTransparentColor = Color.Magenta
        CrearPrograma.Name = "CrearPrograma"
        CrearPrograma.Size = New Size(23, 22)
        CrearPrograma.Text = "&Nuevo"
        ' 
        ' GuardarPrograma
        ' 
        GuardarPrograma.DisplayStyle = ToolStripItemDisplayStyle.Image
        GuardarPrograma.Image = CType(resources.GetObject("GuardarPrograma.Image"), Image)
        GuardarPrograma.ImageTransparentColor = Color.Magenta
        GuardarPrograma.Name = "GuardarPrograma"
        GuardarPrograma.Size = New Size(23, 22)
        GuardarPrograma.Text = "&Guardar"
        ' 
        ' EliminarPrograma
        ' 
        EliminarPrograma.DisplayStyle = ToolStripItemDisplayStyle.Image
        EliminarPrograma.Image = CType(resources.GetObject("EliminarPrograma.Image"), Image)
        EliminarPrograma.ImageTransparentColor = Color.Magenta
        EliminarPrograma.Name = "EliminarPrograma"
        EliminarPrograma.Size = New Size(23, 22)
        EliminarPrograma.Text = "&Eliminar"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 25)
        ' 
        ' TabPersonal
        ' 
        TabPersonal.Controls.Add(GridViewPersonal)
        TabPersonal.Controls.Add(ToolStrip2)
        TabPersonal.Location = New Point(4, 24)
        TabPersonal.Name = "TabPersonal"
        TabPersonal.Padding = New Padding(3)
        TabPersonal.Size = New Size(1056, 653)
        TabPersonal.TabIndex = 1
        TabPersonal.Text = "Personal"
        TabPersonal.UseVisualStyleBackColor = True
        ' 
        ' GridViewPersonal
        ' 
        GridViewPersonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        GridViewPersonal.Dock = DockStyle.Fill
        GridViewPersonal.Location = New Point(3, 28)
        GridViewPersonal.Name = "GridViewPersonal"
        GridViewPersonal.Size = New Size(1050, 622)
        GridViewPersonal.TabIndex = 3
        ' 
        ' ToolStrip2
        ' 
        ToolStrip2.Items.AddRange(New ToolStripItem() {CrearPersonal, GuardarPersonal, EliminarPersonal, ToolStripSeparator1})
        ToolStrip2.Location = New Point(3, 3)
        ToolStrip2.Name = "ToolStrip2"
        ToolStrip2.Size = New Size(1050, 25)
        ToolStrip2.TabIndex = 2
        ToolStrip2.Text = "ToolStrip2"
        ' 
        ' CrearPersonal
        ' 
        CrearPersonal.DisplayStyle = ToolStripItemDisplayStyle.Image
        CrearPersonal.Image = CType(resources.GetObject("CrearPersonal.Image"), Image)
        CrearPersonal.ImageTransparentColor = Color.Magenta
        CrearPersonal.Name = "CrearPersonal"
        CrearPersonal.Size = New Size(23, 22)
        CrearPersonal.Text = "&Nuevo"
        ' 
        ' GuardarPersonal
        ' 
        GuardarPersonal.DisplayStyle = ToolStripItemDisplayStyle.Image
        GuardarPersonal.Image = CType(resources.GetObject("GuardarPersonal.Image"), Image)
        GuardarPersonal.ImageTransparentColor = Color.Magenta
        GuardarPersonal.Name = "GuardarPersonal"
        GuardarPersonal.Size = New Size(23, 22)
        GuardarPersonal.Text = "&Guardar"
        ' 
        ' EliminarPersonal
        ' 
        EliminarPersonal.DisplayStyle = ToolStripItemDisplayStyle.Image
        EliminarPersonal.Image = CType(resources.GetObject("EliminarPersonal.Image"), Image)
        EliminarPersonal.ImageTransparentColor = Color.Magenta
        EliminarPersonal.Name = "EliminarPersonal"
        EliminarPersonal.Size = New Size(23, 22)
        EliminarPersonal.Text = "&Eliminar"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' TabAcceso
        ' 
        TabAcceso.Controls.Add(GridViewAccesos)
        TabAcceso.Controls.Add(ToolStrip3)
        TabAcceso.Location = New Point(4, 24)
        TabAcceso.Name = "TabAcceso"
        TabAcceso.Padding = New Padding(3)
        TabAcceso.Size = New Size(1056, 653)
        TabAcceso.TabIndex = 2
        TabAcceso.Text = "Accesos"
        TabAcceso.UseVisualStyleBackColor = True
        ' 
        ' GridViewAccesos
        ' 
        GridViewAccesos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        GridViewAccesos.Dock = DockStyle.Fill
        GridViewAccesos.Location = New Point(3, 28)
        GridViewAccesos.Name = "GridViewAccesos"
        GridViewAccesos.Size = New Size(1050, 622)
        GridViewAccesos.TabIndex = 4
        ' 
        ' ToolStrip3
        ' 
        ToolStrip3.Items.AddRange(New ToolStripItem() {CrearAcceso, GuardarAcceso, EliminarAcceso, ToolStripSeparator2})
        ToolStrip3.Location = New Point(3, 3)
        ToolStrip3.Name = "ToolStrip3"
        ToolStrip3.Size = New Size(1050, 25)
        ToolStrip3.TabIndex = 3
        ToolStrip3.Text = "ToolStrip3"
        ' 
        ' CrearAcceso
        ' 
        CrearAcceso.DisplayStyle = ToolStripItemDisplayStyle.Image
        CrearAcceso.Image = CType(resources.GetObject("CrearAcceso.Image"), Image)
        CrearAcceso.ImageTransparentColor = Color.Magenta
        CrearAcceso.Name = "CrearAcceso"
        CrearAcceso.Size = New Size(23, 22)
        CrearAcceso.Text = "&Nuevo"
        ' 
        ' GuardarAcceso
        ' 
        GuardarAcceso.DisplayStyle = ToolStripItemDisplayStyle.Image
        GuardarAcceso.Image = CType(resources.GetObject("GuardarAcceso.Image"), Image)
        GuardarAcceso.ImageTransparentColor = Color.Magenta
        GuardarAcceso.Name = "GuardarAcceso"
        GuardarAcceso.Size = New Size(23, 22)
        GuardarAcceso.Text = "&Guardar"
        ' 
        ' EliminarAcceso
        ' 
        EliminarAcceso.DisplayStyle = ToolStripItemDisplayStyle.Image
        EliminarAcceso.Image = CType(resources.GetObject("EliminarAcceso.Image"), Image)
        EliminarAcceso.ImageTransparentColor = Color.Magenta
        EliminarAcceso.Name = "EliminarAcceso"
        EliminarAcceso.Size = New Size(23, 22)
        EliminarAcceso.Text = "&Eliminar"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' MainForm
        ' 
        ClientSize = New Size(1064, 681)
        Controls.Add(TabControl1)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Prueba Tecnica"
        TabControl1.ResumeLayout(False)
        TabPrograma.ResumeLayout(False)
        TabPrograma.PerformLayout()
        CType(GridViewProgramas, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        TabPersonal.ResumeLayout(False)
        TabPersonal.PerformLayout()
        CType(GridViewPersonal, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip2.ResumeLayout(False)
        ToolStrip2.PerformLayout()
        TabAcceso.ResumeLayout(False)
        TabAcceso.PerformLayout()
        CType(GridViewAccesos, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip3.ResumeLayout(False)
        ToolStrip3.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPrograma As TabPage
    Friend WithEvents TabPersonal As TabPage
    Friend WithEvents GridViewProgramas As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents CrearPrograma As ToolStripButton
    Friend WithEvents GuardarPrograma As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents EliminarPrograma As ToolStripButton
    Friend WithEvents GridViewPersonal As DataGridView
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents CrearPersonal As ToolStripButton
    Friend WithEvents GuardarPersonal As ToolStripButton
    Friend WithEvents EliminarPersonal As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GridViewAccesos As DataGridView
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents CrearAcceso As ToolStripButton
    Friend WithEvents GuardarAcceso As ToolStripButton
    Friend WithEvents EliminarAcceso As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TabAcceso As TabPage

End Class
