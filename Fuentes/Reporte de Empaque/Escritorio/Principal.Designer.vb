﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim EnhancedScrollBarRenderer5 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim EnhancedScrollBarRenderer6 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Dim EnhancedScrollBarRenderer1 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim EnhancedScrollBarRenderer2 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.pnlCuerpo = New System.Windows.Forms.Panel()
        Me.spParaClonar = New FarPoint.Win.Spread.FpSpread()
        Me.spParaClonar_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbtnTarimas = New System.Windows.Forms.RadioButton()
        Me.rbtnCajas = New System.Windows.Forms.RadioButton()
        Me.gbTamano = New System.Windows.Forms.GroupBox()
        Me.rbtnDetallado = New System.Windows.Forms.RadioButton()
        Me.rbtnSimple = New System.Windows.Forms.RadioButton()
        Me.btnMostrarOcultar = New System.Windows.Forms.Button()
        Me.gbFechas = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.cbVariedades = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbTamanos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbEtiquetas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEnvases = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbProductos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbProductores = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.spReporte = New FarPoint.Win.Spread.FpSpread()
        Me.spReporte_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.pnlPie = New System.Windows.Forms.Panel()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnExportarPdf = New System.Windows.Forms.Button()
        Me.lblLeyendaParcial = New System.Windows.Forms.Label()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblDescripcionTooltip = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.pbMarca = New System.Windows.Forms.PictureBox()
        Me.lblEncabezadoArea = New System.Windows.Forms.Label()
        Me.lblEncabezadoUsuario = New System.Windows.Forms.Label()
        Me.lblEncabezadoEmpresa = New System.Windows.Forms.Label()
        Me.lblEncabezadoPrograma = New System.Windows.Forms.Label()
        Me.temporizador = New System.Windows.Forms.Timer(Me.components)
        Me.impresor = New System.Windows.Forms.PrintDialog()
        Me.pnlContenido.SuspendLayout()
        Me.pnlCuerpo.SuspendLayout()
        CType(Me.spParaClonar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spParaClonar_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFiltros.SuspendLayout()
        Me.gbTipo.SuspendLayout()
        Me.gbTamano.SuspendLayout()
        Me.gbFechas.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        CType(Me.spReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spReporte_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPie.SuspendLayout()
        Me.pnlEncabezado.SuspendLayout()
        CType(Me.pbMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContenido
        '
        Me.pnlContenido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContenido.BackColor = System.Drawing.Color.DarkSlateGray
        Me.pnlContenido.BackgroundImage = Global.EYEReporteEmpaque.My.Resources.Resources.Logo3
        Me.pnlContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlContenido.Controls.Add(Me.pnlCuerpo)
        Me.pnlContenido.Controls.Add(Me.pnlPie)
        Me.pnlContenido.Controls.Add(Me.pnlEncabezado)
        Me.pnlContenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlContenido.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(1039, 661)
        Me.pnlContenido.TabIndex = 2
        '
        'pnlCuerpo
        '
        Me.pnlCuerpo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCuerpo.AutoScroll = True
        Me.pnlCuerpo.BackColor = System.Drawing.Color.Transparent
        Me.pnlCuerpo.Controls.Add(Me.spParaClonar)
        Me.pnlCuerpo.Controls.Add(Me.pnlFiltros)
        Me.pnlCuerpo.Controls.Add(Me.spReporte)
        Me.pnlCuerpo.Location = New System.Drawing.Point(0, 77)
        Me.pnlCuerpo.Name = "pnlCuerpo"
        Me.pnlCuerpo.Size = New System.Drawing.Size(1039, 521)
        Me.pnlCuerpo.TabIndex = 9
        '
        'spParaClonar
        '
        Me.spParaClonar.AccessibleDescription = ""
        Me.spParaClonar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spParaClonar.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.spParaClonar.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer5.ArrowColor = System.Drawing.Color.DarkSlateGray
        EnhancedScrollBarRenderer5.ArrowHoveredColor = System.Drawing.Color.DarkSlateGray
        EnhancedScrollBarRenderer5.ArrowSelectedColor = System.Drawing.Color.DarkSlateGray
        EnhancedScrollBarRenderer5.ButtonBackgroundColor = System.Drawing.Color.CadetBlue
        EnhancedScrollBarRenderer5.ButtonBorderColor = System.Drawing.Color.SlateGray
        EnhancedScrollBarRenderer5.ButtonHoveredBackgroundColor = System.Drawing.Color.SlateGray
        EnhancedScrollBarRenderer5.ButtonHoveredBorderColor = System.Drawing.Color.DarkGray
        EnhancedScrollBarRenderer5.ButtonSelectedBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedScrollBarRenderer5.ButtonSelectedBorderColor = System.Drawing.Color.CadetBlue
        EnhancedScrollBarRenderer5.TrackBarBackgroundColor = System.Drawing.Color.CadetBlue
        EnhancedScrollBarRenderer5.TrackBarSelectedBackgroundColor = System.Drawing.Color.SlateGray
        Me.spParaClonar.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer5
        Me.spParaClonar.HorizontalScrollBar.TabIndex = 2
        Me.spParaClonar.Location = New System.Drawing.Point(395, 400)
        Me.spParaClonar.Name = "spParaClonar"
        Me.spParaClonar.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.spParaClonar_Sheet1})
        Me.spParaClonar.Size = New System.Drawing.Size(152, 121)
        Me.spParaClonar.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Seashell
        Me.spParaClonar.TabIndex = 33
        Me.spParaClonar.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.spParaClonar.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer6.ArrowColor = System.Drawing.Color.DarkSlateGray
        EnhancedScrollBarRenderer6.ArrowHoveredColor = System.Drawing.Color.DarkSlateGray
        EnhancedScrollBarRenderer6.ArrowSelectedColor = System.Drawing.Color.DarkSlateGray
        EnhancedScrollBarRenderer6.ButtonBackgroundColor = System.Drawing.Color.CadetBlue
        EnhancedScrollBarRenderer6.ButtonBorderColor = System.Drawing.Color.SlateGray
        EnhancedScrollBarRenderer6.ButtonHoveredBackgroundColor = System.Drawing.Color.SlateGray
        EnhancedScrollBarRenderer6.ButtonHoveredBorderColor = System.Drawing.Color.DarkGray
        EnhancedScrollBarRenderer6.ButtonSelectedBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedScrollBarRenderer6.ButtonSelectedBorderColor = System.Drawing.Color.CadetBlue
        EnhancedScrollBarRenderer6.TrackBarBackgroundColor = System.Drawing.Color.CadetBlue
        EnhancedScrollBarRenderer6.TrackBarSelectedBackgroundColor = System.Drawing.Color.SlateGray
        Me.spParaClonar.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer6
        Me.spParaClonar.VerticalScrollBar.TabIndex = 3
        Me.spParaClonar.Visible = False
        '
        'spParaClonar_Sheet1
        '
        Me.spParaClonar_Sheet1.Reset()
        spParaClonar_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.spParaClonar_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.spParaClonar_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.spParaClonar_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnHeaderSeashell"
        Me.spParaClonar_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.spParaClonar_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerSeashell"
        Me.spParaClonar_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.spParaClonar_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderSeashell"
        Me.spParaClonar_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.spParaClonar_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderSeashell"
        Me.spParaClonar_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.spParaClonar_Sheet1.SheetCornerStyle.Parent = "CornerSeashell"
        Me.spParaClonar_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'pnlFiltros
        '
        Me.pnlFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlFiltros.AutoScroll = True
        Me.pnlFiltros.BackColor = System.Drawing.Color.White
        Me.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFiltros.Controls.Add(Me.gbTipo)
        Me.pnlFiltros.Controls.Add(Me.gbTamano)
        Me.pnlFiltros.Controls.Add(Me.btnMostrarOcultar)
        Me.pnlFiltros.Controls.Add(Me.gbFechas)
        Me.pnlFiltros.Controls.Add(Me.gbOpciones)
        Me.pnlFiltros.Controls.Add(Me.btnGenerar)
        Me.pnlFiltros.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(395, 521)
        Me.pnlFiltros.TabIndex = 22
        '
        'gbTipo
        '
        Me.gbTipo.BackColor = System.Drawing.Color.Transparent
        Me.gbTipo.Controls.Add(Me.rbtnTarimas)
        Me.gbTipo.Controls.Add(Me.rbtnCajas)
        Me.gbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipo.ForeColor = System.Drawing.Color.Black
        Me.gbTipo.Location = New System.Drawing.Point(4, 294)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(345, 84)
        Me.gbTipo.TabIndex = 81
        Me.gbTipo.TabStop = False
        Me.gbTipo.Text = "TIPO"
        '
        'rbtnTarimas
        '
        Me.rbtnTarimas.AutoSize = True
        Me.rbtnTarimas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnTarimas.Location = New System.Drawing.Point(91, 52)
        Me.rbtnTarimas.Name = "rbtnTarimas"
        Me.rbtnTarimas.Size = New System.Drawing.Size(80, 17)
        Me.rbtnTarimas.TabIndex = 3
        Me.rbtnTarimas.Text = "TARIMAS"
        Me.rbtnTarimas.UseVisualStyleBackColor = True
        '
        'rbtnCajas
        '
        Me.rbtnCajas.AutoSize = True
        Me.rbtnCajas.Checked = True
        Me.rbtnCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCajas.Location = New System.Drawing.Point(91, 29)
        Me.rbtnCajas.Name = "rbtnCajas"
        Me.rbtnCajas.Size = New System.Drawing.Size(63, 17)
        Me.rbtnCajas.TabIndex = 2
        Me.rbtnCajas.TabStop = True
        Me.rbtnCajas.Text = "CAJAS"
        Me.rbtnCajas.UseVisualStyleBackColor = True
        '
        'gbTamano
        '
        Me.gbTamano.BackColor = System.Drawing.Color.Transparent
        Me.gbTamano.Controls.Add(Me.rbtnDetallado)
        Me.gbTamano.Controls.Add(Me.rbtnSimple)
        Me.gbTamano.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTamano.ForeColor = System.Drawing.Color.Black
        Me.gbTamano.Location = New System.Drawing.Point(4, 384)
        Me.gbTamano.Name = "gbTamano"
        Me.gbTamano.Size = New System.Drawing.Size(345, 84)
        Me.gbTamano.TabIndex = 80
        Me.gbTamano.TabStop = False
        Me.gbTamano.Text = "TAMAÑO"
        '
        'rbtnDetallado
        '
        Me.rbtnDetallado.AutoSize = True
        Me.rbtnDetallado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDetallado.Location = New System.Drawing.Point(91, 53)
        Me.rbtnDetallado.Name = "rbtnDetallado"
        Me.rbtnDetallado.Size = New System.Drawing.Size(98, 17)
        Me.rbtnDetallado.TabIndex = 3
        Me.rbtnDetallado.Text = "DETALLADO"
        Me.rbtnDetallado.UseVisualStyleBackColor = True
        '
        'rbtnSimple
        '
        Me.rbtnSimple.AutoSize = True
        Me.rbtnSimple.Checked = True
        Me.rbtnSimple.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSimple.Location = New System.Drawing.Point(91, 30)
        Me.rbtnSimple.Name = "rbtnSimple"
        Me.rbtnSimple.Size = New System.Drawing.Size(70, 17)
        Me.rbtnSimple.TabIndex = 2
        Me.rbtnSimple.TabStop = True
        Me.rbtnSimple.Text = "SIMPLE"
        Me.rbtnSimple.UseVisualStyleBackColor = True
        '
        'btnMostrarOcultar
        '
        Me.btnMostrarOcultar.BackColor = System.Drawing.Color.Transparent
        Me.btnMostrarOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMostrarOcultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMostrarOcultar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnMostrarOcultar.FlatAppearance.BorderSize = 0
        Me.btnMostrarOcultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnMostrarOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarOcultar.ForeColor = System.Drawing.Color.Black
        Me.btnMostrarOcultar.Image = CType(resources.GetObject("btnMostrarOcultar.Image"), System.Drawing.Image)
        Me.btnMostrarOcultar.Location = New System.Drawing.Point(353, 0)
        Me.btnMostrarOcultar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMostrarOcultar.Name = "btnMostrarOcultar"
        Me.btnMostrarOcultar.Size = New System.Drawing.Size(40, 38)
        Me.btnMostrarOcultar.TabIndex = 79
        Me.btnMostrarOcultar.UseVisualStyleBackColor = False
        '
        'gbFechas
        '
        Me.gbFechas.BackColor = System.Drawing.Color.Transparent
        Me.gbFechas.Controls.Add(Me.Label6)
        Me.gbFechas.Controls.Add(Me.chkFecha)
        Me.gbFechas.Controls.Add(Me.dtpFechaFinal)
        Me.gbFechas.Controls.Add(Me.dtpFecha)
        Me.gbFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFechas.ForeColor = System.Drawing.Color.Black
        Me.gbFechas.Location = New System.Drawing.Point(4, 3)
        Me.gbFechas.Name = "gbFechas"
        Me.gbFechas.Size = New System.Drawing.Size(345, 64)
        Me.gbFechas.TabIndex = 17
        Me.gbFechas.TabStop = False
        Me.gbFechas.Text = "RANGO DE FECHAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(252, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Aplicar?"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'chkFecha
        '
        Me.chkFecha.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkFecha.Checked = True
        Me.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkFecha.FlatAppearance.BorderSize = 2
        Me.chkFecha.FlatAppearance.CheckedBackColor = System.Drawing.Color.Turquoise
        Me.chkFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.chkFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFecha.ForeColor = System.Drawing.Color.Black
        Me.chkFecha.Location = New System.Drawing.Point(255, 27)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(45, 25)
        Me.chkFecha.TabIndex = 20
        Me.chkFecha.Text = "SI"
        Me.chkFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(146, 28)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(102, 20)
        Me.dtpFechaFinal.TabIndex = 17
        '
        'dtpFecha
        '
        Me.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(39, 28)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'gbOpciones
        '
        Me.gbOpciones.BackColor = System.Drawing.Color.Transparent
        Me.gbOpciones.Controls.Add(Me.cbVariedades)
        Me.gbOpciones.Controls.Add(Me.Label7)
        Me.gbOpciones.Controls.Add(Me.cbTamanos)
        Me.gbOpciones.Controls.Add(Me.Label5)
        Me.gbOpciones.Controls.Add(Me.cbEtiquetas)
        Me.gbOpciones.Controls.Add(Me.Label4)
        Me.gbOpciones.Controls.Add(Me.cbEnvases)
        Me.gbOpciones.Controls.Add(Me.Label2)
        Me.gbOpciones.Controls.Add(Me.cbProductos)
        Me.gbOpciones.Controls.Add(Me.Label1)
        Me.gbOpciones.Controls.Add(Me.cbProductores)
        Me.gbOpciones.Controls.Add(Me.Label3)
        Me.gbOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOpciones.ForeColor = System.Drawing.Color.Black
        Me.gbOpciones.Location = New System.Drawing.Point(4, 73)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(345, 215)
        Me.gbOpciones.TabIndex = 15
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "OPCIONES"
        '
        'cbVariedades
        '
        Me.cbVariedades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbVariedades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbVariedades.BackColor = System.Drawing.Color.White
        Me.cbVariedades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbVariedades.Enabled = False
        Me.cbVariedades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVariedades.ForeColor = System.Drawing.Color.Black
        Me.cbVariedades.FormattingEnabled = True
        Me.cbVariedades.Location = New System.Drawing.Point(91, 91)
        Me.cbVariedades.Name = "cbVariedades"
        Me.cbVariedades.Size = New System.Drawing.Size(250, 21)
        Me.cbVariedades.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(0, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "VARIEDAD:"
        '
        'cbTamanos
        '
        Me.cbTamanos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTamanos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTamanos.BackColor = System.Drawing.Color.White
        Me.cbTamanos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbTamanos.Enabled = False
        Me.cbTamanos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTamanos.ForeColor = System.Drawing.Color.Black
        Me.cbTamanos.FormattingEnabled = True
        Me.cbTamanos.Location = New System.Drawing.Point(91, 145)
        Me.cbTamanos.Name = "cbTamanos"
        Me.cbTamanos.Size = New System.Drawing.Size(250, 21)
        Me.cbTamanos.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "TAMAÑO:"
        '
        'cbEtiquetas
        '
        Me.cbEtiquetas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEtiquetas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEtiquetas.BackColor = System.Drawing.Color.White
        Me.cbEtiquetas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbEtiquetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEtiquetas.ForeColor = System.Drawing.Color.Black
        Me.cbEtiquetas.FormattingEnabled = True
        Me.cbEtiquetas.Location = New System.Drawing.Point(91, 172)
        Me.cbEtiquetas.Name = "cbEtiquetas"
        Me.cbEtiquetas.Size = New System.Drawing.Size(250, 21)
        Me.cbEtiquetas.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "ETIQUETA:"
        '
        'cbEnvases
        '
        Me.cbEnvases.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEnvases.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEnvases.BackColor = System.Drawing.Color.White
        Me.cbEnvases.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbEnvases.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEnvases.ForeColor = System.Drawing.Color.Black
        Me.cbEnvases.FormattingEnabled = True
        Me.cbEnvases.Location = New System.Drawing.Point(91, 118)
        Me.cbEnvases.Name = "cbEnvases"
        Me.cbEnvases.Size = New System.Drawing.Size(250, 21)
        Me.cbEnvases.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "ENVASE:"
        '
        'cbProductos
        '
        Me.cbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProductos.BackColor = System.Drawing.Color.White
        Me.cbProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProductos.ForeColor = System.Drawing.Color.Black
        Me.cbProductos.FormattingEnabled = True
        Me.cbProductos.Location = New System.Drawing.Point(91, 64)
        Me.cbProductos.Name = "cbProductos"
        Me.cbProductos.Size = New System.Drawing.Size(250, 21)
        Me.cbProductos.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "PRODUCTO:"
        '
        'cbProductores
        '
        Me.cbProductores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProductores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProductores.BackColor = System.Drawing.Color.White
        Me.cbProductores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbProductores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProductores.ForeColor = System.Drawing.Color.Black
        Me.cbProductores.FormattingEnabled = True
        Me.cbProductores.Location = New System.Drawing.Point(91, 37)
        Me.cbProductores.Name = "cbProductores"
        Me.cbProductores.Size = New System.Drawing.Size(250, 21)
        Me.cbProductores.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "PRODUCTOR:"
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGenerar.FlatAppearance.BorderSize = 3
        Me.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.ForeColor = System.Drawing.Color.Black
        Me.btnGenerar.Location = New System.Drawing.Point(4, 474)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(345, 40)
        Me.btnGenerar.TabIndex = 10
        Me.btnGenerar.Text = "GENERAR"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'spReporte
        '
        Me.spReporte.AccessibleDescription = ""
        Me.spReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spReporte.BackColor = System.Drawing.Color.White
        Me.spReporte.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.spReporte.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer1.ArrowColor = System.Drawing.Color.DarkSlateGray
        EnhancedScrollBarRenderer1.ArrowHoveredColor = System.Drawing.Color.DarkSlateGray
        EnhancedScrollBarRenderer1.ArrowSelectedColor = System.Drawing.Color.DarkSlateGray
        EnhancedScrollBarRenderer1.ButtonBackgroundColor = System.Drawing.Color.CadetBlue
        EnhancedScrollBarRenderer1.ButtonBorderColor = System.Drawing.Color.SlateGray
        EnhancedScrollBarRenderer1.ButtonHoveredBackgroundColor = System.Drawing.Color.SlateGray
        EnhancedScrollBarRenderer1.ButtonHoveredBorderColor = System.Drawing.Color.DarkGray
        EnhancedScrollBarRenderer1.ButtonSelectedBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedScrollBarRenderer1.ButtonSelectedBorderColor = System.Drawing.Color.CadetBlue
        EnhancedScrollBarRenderer1.TrackBarBackgroundColor = System.Drawing.Color.CadetBlue
        EnhancedScrollBarRenderer1.TrackBarSelectedBackgroundColor = System.Drawing.Color.SlateGray
        Me.spReporte.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer1
        Me.spReporte.HorizontalScrollBar.TabIndex = 0
        Me.spReporte.Location = New System.Drawing.Point(395, 0)
        Me.spReporte.Name = "spReporte"
        Me.spReporte.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.spReporte_Sheet1})
        Me.spReporte.Size = New System.Drawing.Size(644, 521)
        Me.spReporte.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Seashell
        Me.spReporte.TabIndex = 3
        Me.spReporte.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.spReporte.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer2.ArrowColor = System.Drawing.Color.DarkSlateGray
        EnhancedScrollBarRenderer2.ArrowHoveredColor = System.Drawing.Color.DarkSlateGray
        EnhancedScrollBarRenderer2.ArrowSelectedColor = System.Drawing.Color.DarkSlateGray
        EnhancedScrollBarRenderer2.ButtonBackgroundColor = System.Drawing.Color.CadetBlue
        EnhancedScrollBarRenderer2.ButtonBorderColor = System.Drawing.Color.SlateGray
        EnhancedScrollBarRenderer2.ButtonHoveredBackgroundColor = System.Drawing.Color.SlateGray
        EnhancedScrollBarRenderer2.ButtonHoveredBorderColor = System.Drawing.Color.DarkGray
        EnhancedScrollBarRenderer2.ButtonSelectedBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedScrollBarRenderer2.ButtonSelectedBorderColor = System.Drawing.Color.CadetBlue
        EnhancedScrollBarRenderer2.TrackBarBackgroundColor = System.Drawing.Color.CadetBlue
        EnhancedScrollBarRenderer2.TrackBarSelectedBackgroundColor = System.Drawing.Color.SlateGray
        Me.spReporte.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer2
        Me.spReporte.VerticalScrollBar.TabIndex = 1
        Me.spReporte.Visible = False
        '
        'spReporte_Sheet1
        '
        Me.spReporte_Sheet1.Reset()
        spReporte_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.spReporte_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.spReporte_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.spReporte_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnHeaderSeashell"
        Me.spReporte_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.spReporte_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerSeashell"
        Me.spReporte_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.spReporte_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderSeashell"
        Me.spReporte_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.spReporte_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderSeashell"
        Me.spReporte_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.spReporte_Sheet1.SheetCornerStyle.Parent = "CornerSeashell"
        Me.spReporte_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'pnlPie
        '
        Me.pnlPie.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPie.BackColor = System.Drawing.Color.White
        Me.pnlPie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPie.Controls.Add(Me.btnAyuda)
        Me.pnlPie.Controls.Add(Me.btnExportarPdf)
        Me.pnlPie.Controls.Add(Me.lblLeyendaParcial)
        Me.pnlPie.Controls.Add(Me.btnExportarExcel)
        Me.pnlPie.Controls.Add(Me.btnImprimir)
        Me.pnlPie.Controls.Add(Me.lblDescripcionTooltip)
        Me.pnlPie.Controls.Add(Me.btnSalir)
        Me.pnlPie.ForeColor = System.Drawing.Color.Black
        Me.pnlPie.Location = New System.Drawing.Point(0, 600)
        Me.pnlPie.Name = "pnlPie"
        Me.pnlPie.Size = New System.Drawing.Size(1039, 60)
        Me.pnlPie.TabIndex = 8
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAyuda.FlatAppearance.BorderSize = 3
        Me.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.ForeColor = System.Drawing.Color.Black
        Me.btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), System.Drawing.Image)
        Me.btnAyuda.Location = New System.Drawing.Point(0, 0)
        Me.btnAyuda.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(60, 60)
        Me.btnAyuda.TabIndex = 54
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'btnExportarPdf
        '
        Me.btnExportarPdf.BackColor = System.Drawing.Color.White
        Me.btnExportarPdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportarPdf.Enabled = False
        Me.btnExportarPdf.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExportarPdf.FlatAppearance.BorderSize = 3
        Me.btnExportarPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnExportarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarPdf.Image = CType(resources.GetObject("btnExportarPdf.Image"), System.Drawing.Image)
        Me.btnExportarPdf.Location = New System.Drawing.Point(188, 0)
        Me.btnExportarPdf.Name = "btnExportarPdf"
        Me.btnExportarPdf.Size = New System.Drawing.Size(60, 60)
        Me.btnExportarPdf.TabIndex = 53
        Me.btnExportarPdf.UseVisualStyleBackColor = False
        '
        'lblLeyendaParcial
        '
        Me.lblLeyendaParcial.AutoSize = True
        Me.lblLeyendaParcial.BackColor = System.Drawing.Color.White
        Me.lblLeyendaParcial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLeyendaParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLeyendaParcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeyendaParcial.ForeColor = System.Drawing.Color.White
        Me.lblLeyendaParcial.Location = New System.Drawing.Point(218, 15)
        Me.lblLeyendaParcial.Name = "lblLeyendaParcial"
        Me.lblLeyendaParcial.Size = New System.Drawing.Size(0, 20)
        Me.lblLeyendaParcial.TabIndex = 52
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.BackColor = System.Drawing.Color.White
        Me.btnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportarExcel.Enabled = False
        Me.btnExportarExcel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExportarExcel.FlatAppearance.BorderSize = 3
        Me.btnExportarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarExcel.Image = CType(resources.GetObject("btnExportarExcel.Image"), System.Drawing.Image)
        Me.btnExportarExcel.Location = New System.Drawing.Point(126, 0)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(60, 60)
        Me.btnExportarExcel.TabIndex = 50
        Me.btnExportarExcel.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.White
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnImprimir.FlatAppearance.BorderSize = 3
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(64, 0)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(60, 60)
        Me.btnImprimir.TabIndex = 51
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'lblDescripcionTooltip
        '
        Me.lblDescripcionTooltip.AutoSize = True
        Me.lblDescripcionTooltip.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblDescripcionTooltip.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescripcionTooltip.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionTooltip.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcionTooltip.Location = New System.Drawing.Point(280, 13)
        Me.lblDescripcionTooltip.Name = "lblDescripcionTooltip"
        Me.lblDescripcionTooltip.Size = New System.Drawing.Size(0, 31)
        Me.lblDescripcionTooltip.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSalir.FlatAppearance.BorderSize = 3
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(977, 0)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(60, 60)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEncabezado.Controls.Add(Me.pbMarca)
        Me.pnlEncabezado.Controls.Add(Me.lblEncabezadoArea)
        Me.pnlEncabezado.Controls.Add(Me.lblEncabezadoUsuario)
        Me.pnlEncabezado.Controls.Add(Me.lblEncabezadoEmpresa)
        Me.pnlEncabezado.Controls.Add(Me.lblEncabezadoPrograma)
        Me.pnlEncabezado.ForeColor = System.Drawing.Color.White
        Me.pnlEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(1039, 75)
        Me.pnlEncabezado.TabIndex = 7
        '
        'pbMarca
        '
        Me.pbMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMarca.BackColor = System.Drawing.Color.Transparent
        Me.pbMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbMarca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbMarca.Image = Global.EYEReporteEmpaque.My.Resources.Resources.Producido_por
        Me.pbMarca.ImageLocation = ""
        Me.pbMarca.Location = New System.Drawing.Point(962, 0)
        Me.pbMarca.Name = "pbMarca"
        Me.pbMarca.Size = New System.Drawing.Size(75, 75)
        Me.pbMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMarca.TabIndex = 4
        Me.pbMarca.TabStop = False
        '
        'lblEncabezadoArea
        '
        Me.lblEncabezadoArea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEncabezadoArea.AutoSize = True
        Me.lblEncabezadoArea.BackColor = System.Drawing.Color.Transparent
        Me.lblEncabezadoArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezadoArea.ForeColor = System.Drawing.Color.White
        Me.lblEncabezadoArea.Location = New System.Drawing.Point(604, 0)
        Me.lblEncabezadoArea.Name = "lblEncabezadoArea"
        Me.lblEncabezadoArea.Size = New System.Drawing.Size(0, 33)
        Me.lblEncabezadoArea.TabIndex = 3
        '
        'lblEncabezadoUsuario
        '
        Me.lblEncabezadoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEncabezadoUsuario.AutoSize = True
        Me.lblEncabezadoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezadoUsuario.ForeColor = System.Drawing.Color.White
        Me.lblEncabezadoUsuario.Location = New System.Drawing.Point(604, 35)
        Me.lblEncabezadoUsuario.Name = "lblEncabezadoUsuario"
        Me.lblEncabezadoUsuario.Size = New System.Drawing.Size(0, 33)
        Me.lblEncabezadoUsuario.TabIndex = 2
        '
        'lblEncabezadoEmpresa
        '
        Me.lblEncabezadoEmpresa.AutoSize = True
        Me.lblEncabezadoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezadoEmpresa.ForeColor = System.Drawing.Color.White
        Me.lblEncabezadoEmpresa.Location = New System.Drawing.Point(12, 35)
        Me.lblEncabezadoEmpresa.Name = "lblEncabezadoEmpresa"
        Me.lblEncabezadoEmpresa.Size = New System.Drawing.Size(0, 33)
        Me.lblEncabezadoEmpresa.TabIndex = 1
        '
        'lblEncabezadoPrograma
        '
        Me.lblEncabezadoPrograma.AutoSize = True
        Me.lblEncabezadoPrograma.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezadoPrograma.ForeColor = System.Drawing.Color.White
        Me.lblEncabezadoPrograma.Location = New System.Drawing.Point(12, 0)
        Me.lblEncabezadoPrograma.Name = "lblEncabezadoPrograma"
        Me.lblEncabezadoPrograma.Size = New System.Drawing.Size(0, 33)
        Me.lblEncabezadoPrograma.TabIndex = 0
        '
        'temporizador
        '
        Me.temporizador.Interval = 1
        '
        'impresor
        '
        Me.impresor.UseEXDialog = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1039, 661)
        Me.Controls.Add(Me.pnlContenido)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal"
        Me.Text = "Empaque y Embarques - Reporte de Empaque"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlCuerpo.ResumeLayout(False)
        CType(Me.spParaClonar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spParaClonar_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFiltros.ResumeLayout(False)
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        Me.gbTamano.ResumeLayout(False)
        Me.gbTamano.PerformLayout()
        Me.gbFechas.ResumeLayout(False)
        Me.gbFechas.PerformLayout()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbOpciones.PerformLayout()
        CType(Me.spReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spReporte_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPie.ResumeLayout(False)
        Me.pnlPie.PerformLayout()
        Me.pnlEncabezado.ResumeLayout(False)
        Me.pnlEncabezado.PerformLayout()
        CType(Me.pbMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlContenido As System.Windows.Forms.Panel
    Private WithEvents pnlCuerpo As System.Windows.Forms.Panel
    Private WithEvents pnlPie As System.Windows.Forms.Panel
    Private WithEvents btnSalir As System.Windows.Forms.Button
    Private WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Private WithEvents lblEncabezadoEmpresa As System.Windows.Forms.Label
    Private WithEvents lblEncabezadoPrograma As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionTooltip As System.Windows.Forms.Label
    Private WithEvents lblEncabezadoUsuario As System.Windows.Forms.Label
    Private WithEvents lblEncabezadoArea As System.Windows.Forms.Label
    Friend WithEvents spReporte As FarPoint.Win.Spread.FpSpread
    Friend WithEvents spReporte_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents pnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents gbFechas As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents temporizador As System.Windows.Forms.Timer
    Friend WithEvents btnExportarPdf As System.Windows.Forms.Button
    Friend WithEvents lblLeyendaParcial As System.Windows.Forms.Label
    Friend WithEvents btnExportarExcel As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents impresor As System.Windows.Forms.PrintDialog
    Friend WithEvents spParaClonar As FarPoint.Win.Spread.FpSpread
    Friend WithEvents spParaClonar_Sheet1 As FarPoint.Win.Spread.SheetView
    Private WithEvents btnAyuda As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbProductores As System.Windows.Forms.ComboBox
    Private WithEvents btnMostrarOcultar As System.Windows.Forms.Button
    Friend WithEvents pbMarca As System.Windows.Forms.PictureBox
    Friend WithEvents gbTamano As System.Windows.Forms.GroupBox
    Friend WithEvents cbVariedades As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbTamanos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbEtiquetas As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbEnvases As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbtnDetallado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSimple As System.Windows.Forms.RadioButton
    Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnTarimas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCajas As System.Windows.Forms.RadioButton
End Class
