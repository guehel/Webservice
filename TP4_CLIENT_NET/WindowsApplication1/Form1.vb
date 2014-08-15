Public Class FormHotel
    Dim dicChambre = New Dictionary(Of String, ServiceHotel.ReservationDTO())
    Dim serviceWeb As New ServiceHotel.FacadeServiceWebClient

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim action As Integer = 1
        creerUnFormulaire(action)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'get liste chambres
        Dim listeChambres As ServiceHotel.ChambreDTO()
        listeChambres = serviceWeb.obtenirListeChambre()
        With LbChambres
            .DataSource = listeChambres
            .DisplayMember = .DataSource.Current("numeroChambre")

        End With


        'charcher la liste des tableau
        Dim listeClients As ServiceHotel.ClientDTO()
        listeClients = serviceWeb.obtenirListeClients()
        With cbClient
            .DataSource = listeClients
            .DisplayMember = .DataSource.Current("nom")

        End With

      


    End Sub

    Private Sub detailsReservations(reservation As ServiceHotel.ReservationDTO)

        'Dim numeroReservation As Int16
        'Dim reservant As String
        'Dim chambre As ServiceHotel.ChambreDTO
        'Dim creation As String
        'Dim arrive As String
        'Dim depart As String


    End Sub




    Private Sub LbChambres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbChambres.SelectedIndexChanged
        Dim chambreSelection As ServiceHotel.ChambreDTO
        chambreSelection = LbChambres.SelectedItem
        Dim numChambre As Integer = chambreSelection.numeroChambre
        numChambre = numChambre + 900

        afficherLesReservations(numChambre)

    End Sub

   

   


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged

    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Dim action As Integer = 0
        creerUnFormulaire(action)

    End Sub

    Private Sub addReservations(resaChambre As ServiceHotel.ReservationDTO())
        For Each reservationDTO As ServiceHotel.ReservationDTO In resaChambre
            cbReservations.Items.Add(reservationDTO.idReservation)

        Next

    End Sub

    Private Sub afficherReservations(resaChambre As ServiceHotel.ReservationDTO)
        Dim numeroReservation As Int16
        Dim reservant As String
        Dim chambre As ServiceHotel.ChambreDTO
        Dim creation As String
        Dim arrive As String
        Dim depart As String
        'modifier les date et le client

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClient.SelectedIndexChanged
        Dim clientDto As ServiceHotel.ClientDTO
        clientDto = cbClient.SelectedItem
        afficherClient(clientDto)
        afficherLesReservations(clientDto.id)

    End Sub

    Private Sub afficherClient(clientDto As ServiceHotel.ClientDTO)
        Dim nom As String
        nom = clientDto.nom

        Dim prenom As String
        prenom = clientDto.prenom

        Dim numeroClient As Integer
        numeroClient = clientDto.id

        txtNom.Text = nom
        txtPrenom.Text = prenom
        txtNumClient.Text = numeroClient





    End Sub

    Private Sub afficherLesReservations(numero As Integer)
        Dim resaChambre As ServiceHotel.ReservationDTO()
        resaChambre = serviceWeb.obtenirReservations(numero)
        With cbReservations
            .DataSource = resaChambre
            '.DisplayMember = .DataSource.Current("numeroChambre")
        End With

    End Sub

  

    Private Sub creerUnFormulaire(action As Integer)
        Dim numeroReservation As Int16
        Dim reservant As String
        Dim chambre As ServiceHotel.ChambreDTO
        Dim creation As String
        Dim arrive As String
        Dim depart As String
        Dim formulaire As New ServiceHotel.Formulaire
        formulaire.modifiant = reservant
        formulaire.dateModification = creation
        formulaire.type = action


        serviceWeb.update(formulaire)


        Throw New NotImplementedException
    End Sub

End Class
