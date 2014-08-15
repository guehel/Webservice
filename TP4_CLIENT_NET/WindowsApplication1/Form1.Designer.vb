<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHotel
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LbChambres = New System.Windows.Forms.ListBox()
        Me.TitreSectionChambre = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.cbReservations = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblDepart = New System.Windows.Forms.Label()
        Me.lblArrive = New System.Windows.Forms.Label()
        Me.lblCreation = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumReservation = New System.Windows.Forms.Label()
        Me.lblReservation = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtNumClient = New System.Windows.Forms.TextBox()
        Me.lblPrenomClient = New System.Windows.Forms.Label()
        Me.cbClient = New System.Windows.Forms.ComboBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblNumeroClient = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.btnAjouter = New System.Windows.Forms.Label()
        Me.btnAnnuler = New System.Windows.Forms.Label()
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar()
        Me.ObtenirListeChambreResponseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObtenirReservationsResponseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ObtenirListeChambreResponseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObtenirReservationsResponseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.LbChambres)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TitreSectionChambre)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(878, 687)
        Me.SplitContainer1.SplitterDistance = 423
        Me.SplitContainer1.TabIndex = 0
        '
        'LbChambres
        '
        Me.LbChambres.FormattingEnabled = True
        Me.LbChambres.Location = New System.Drawing.Point(43, 57)
        Me.LbChambres.Name = "LbChambres"
        Me.LbChambres.Size = New System.Drawing.Size(331, 524)
        Me.LbChambres.Sorted = True
        Me.LbChambres.TabIndex = 3
        Me.LbChambres.ValueMember = "ServiceHotel.ChambreDTO"
        '
        'TitreSectionChambre
        '
        Me.TitreSectionChambre.AutoSize = True
        Me.TitreSectionChambre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitreSectionChambre.Location = New System.Drawing.Point(13, 13)
        Me.TitreSectionChambre.Name = "TitreSectionChambre"
        Me.TitreSectionChambre.Size = New System.Drawing.Size(139, 31)
        Me.TitreSectionChambre.TabIndex = 0
        Me.TitreSectionChambre.Text = "Chambres"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbReservations)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DateTimePicker3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblDepart)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblArrive)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblCreation)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtNumero)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblNumReservation)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblReservation)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtNom)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtPrenom)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtNumClient)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblPrenomClient)
        Me.SplitContainer2.Panel2.Controls.Add(Me.cbClient)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblNom)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblNumeroClient)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblClient)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnAjouter)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnAnnuler)
        Me.SplitContainer2.Panel2.Controls.Add(Me.VScrollBar2)
        Me.SplitContainer2.Size = New System.Drawing.Size(444, 681)
        Me.SplitContainer2.SplitterDistance = 348
        Me.SplitContainer2.TabIndex = 1
        '
        'cbReservations
        '
        Me.cbReservations.DataSource = Me.ObtenirReservationsResponseBindingSource
        Me.cbReservations.FormattingEnabled = True
        Me.cbReservations.Location = New System.Drawing.Point(221, 117)
        Me.cbReservations.Name = "cbReservations"
        Me.cbReservations.Size = New System.Drawing.Size(138, 21)
        Me.cbReservations.TabIndex = 13
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(168, 217)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker3.TabIndex = 12
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(168, 260)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(168, 174)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'lblDepart
        '
        Me.lblDepart.AutoSize = True
        Me.lblDepart.Location = New System.Drawing.Point(31, 266)
        Me.lblDepart.Name = "lblDepart"
        Me.lblDepart.Size = New System.Drawing.Size(39, 13)
        Me.lblDepart.TabIndex = 7
        Me.lblDepart.Text = "Depart"
        '
        'lblArrive
        '
        Me.lblArrive.AutoSize = True
        Me.lblArrive.Location = New System.Drawing.Point(31, 224)
        Me.lblArrive.Name = "lblArrive"
        Me.lblArrive.Size = New System.Drawing.Size(34, 13)
        Me.lblArrive.TabIndex = 6
        Me.lblArrive.Text = "Arrivé"
        '
        'lblCreation
        '
        Me.lblCreation.AutoSize = True
        Me.lblCreation.Location = New System.Drawing.Point(31, 181)
        Me.lblCreation.Name = "lblCreation"
        Me.lblCreation.Size = New System.Drawing.Size(46, 13)
        Me.lblCreation.TabIndex = 5
        Me.lblCreation.Text = "Creation"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(221, 62)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 4
        '
        'lblNumReservation
        '
        Me.lblNumReservation.AutoSize = True
        Me.lblNumReservation.Location = New System.Drawing.Point(31, 62)
        Me.lblNumReservation.Name = "lblNumReservation"
        Me.lblNumReservation.Size = New System.Drawing.Size(44, 13)
        Me.lblNumReservation.TabIndex = 3
        Me.lblNumReservation.Text = "Numero"
        '
        'lblReservation
        '
        Me.lblReservation.AutoSize = True
        Me.lblReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservation.Location = New System.Drawing.Point(17, 101)
        Me.lblReservation.Name = "lblReservation"
        Me.lblReservation.Size = New System.Drawing.Size(185, 37)
        Me.lblReservation.TabIndex = 2
        Me.lblReservation.Text = "Reservation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Détails Chambre"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(181, 112)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(158, 20)
        Me.txtNom.TabIndex = 13
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(181, 169)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(158, 20)
        Me.txtPrenom.TabIndex = 12
        '
        'txtNumClient
        '
        Me.txtNumClient.Location = New System.Drawing.Point(181, 56)
        Me.txtNumClient.Name = "txtNumClient"
        Me.txtNumClient.Size = New System.Drawing.Size(158, 20)
        Me.txtNumClient.TabIndex = 11
        '
        'lblPrenomClient
        '
        Me.lblPrenomClient.AutoSize = True
        Me.lblPrenomClient.Location = New System.Drawing.Point(36, 176)
        Me.lblPrenomClient.Name = "lblPrenomClient"
        Me.lblPrenomClient.Size = New System.Drawing.Size(72, 13)
        Me.lblPrenomClient.TabIndex = 7
        Me.lblPrenomClient.Text = "Prenom Client"
        '
        'cbClient
        '
        Me.cbClient.FormattingEnabled = True
        Me.cbClient.Location = New System.Drawing.Point(183, 21)
        Me.cbClient.Name = "cbClient"
        Me.cbClient.Size = New System.Drawing.Size(138, 21)
        Me.cbClient.TabIndex = 9
        Me.cbClient.ValueMember = "ServiceHotel.ClientDTO"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(35, 119)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(58, 13)
        Me.lblNom.TabIndex = 6
        Me.lblNom.Text = "Nom Client"
        '
        'lblNumeroClient
        '
        Me.lblNumeroClient.AutoSize = True
        Me.lblNumeroClient.Location = New System.Drawing.Point(35, 63)
        Me.lblNumeroClient.Name = "lblNumeroClient"
        Me.lblNumeroClient.Size = New System.Drawing.Size(73, 13)
        Me.lblNumeroClient.TabIndex = 5
        Me.lblNumeroClient.Text = "Numero Client"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.Location = New System.Drawing.Point(28, 21)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(98, 37)
        Me.lblClient.TabIndex = 4
        Me.lblClient.Text = "Client"
        '
        'btnAjouter
        '
        Me.btnAjouter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjouter.AutoSize = True
        Me.btnAjouter.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAjouter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAjouter.Location = New System.Drawing.Point(221, 277)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Padding = New System.Windows.Forms.Padding(4)
        Me.btnAjouter.Size = New System.Drawing.Size(184, 34)
        Me.btnAjouter.TabIndex = 3
        Me.btnAjouter.Text = "Ajouter Réservation"
        '
        'btnAnnuler
        '
        Me.btnAnnuler.AutoSize = True
        Me.btnAnnuler.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAnnuler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAnnuler.Location = New System.Drawing.Point(21, 277)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Padding = New System.Windows.Forms.Padding(4)
        Me.btnAnnuler.Size = New System.Drawing.Size(191, 34)
        Me.btnAnnuler.TabIndex = 2
        Me.btnAnnuler.Text = "Annuler Réservation"
        '
        'VScrollBar2
        '
        Me.VScrollBar2.Location = New System.Drawing.Point(417, 4)
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(21, 257)
        Me.VScrollBar2.TabIndex = 1
        '
        'ObtenirListeChambreResponseBindingSource
        '
        Me.ObtenirListeChambreResponseBindingSource.DataSource = GetType(WindowsApplication1.ServiceHotel.obtenirListeChambreResponse)
        '
        'ObtenirReservationsResponseBindingSource
        '
        Me.ObtenirReservationsResponseBindingSource.DataSource = GetType(WindowsApplication1.ServiceHotel.obtenirReservationsResponse)
        '
        'FormHotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 687)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormHotel"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ObtenirListeChambreResponseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObtenirReservationsResponseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TitreSectionChambre As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblReservation As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VScrollBar2 As System.Windows.Forms.VScrollBar
    Friend WithEvents btnAjouter As System.Windows.Forms.Label
    Friend WithEvents btnAnnuler As System.Windows.Forms.Label
    Friend WithEvents LbChambres As System.Windows.Forms.ListBox
    Friend WithEvents lblNumReservation As System.Windows.Forms.Label
    Friend WithEvents lblCreation As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents cbClient As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepart As System.Windows.Forms.Label
    Friend WithEvents lblArrive As System.Windows.Forms.Label
    Friend WithEvents lblClient As System.Windows.Forms.Label
    Friend WithEvents lblPrenomClient As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblNumeroClient As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents txtNumClient As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbReservations As System.Windows.Forms.ComboBox
    Friend WithEvents ObtenirReservationsResponseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ObtenirListeChambreResponseBindingSource As System.Windows.Forms.BindingSource

End Class
