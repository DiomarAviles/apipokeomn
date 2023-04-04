Imports System.Net.Http
Imports Newtonsoft.Json






Public Class Form1
    Private Async Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Try
        Dim nombrePokemon As String = txtNombrePokemon.Text.ToLower()
            Dim url As String = "https://pokeapi.co/api/v2/pokemon/" + nombrePokemon
            Dim Client As New HttpClient()
            Dim json As String = Client.GetStringAsync(url).Result

        MostrarPokemon(json)
        'Catch ex As Exception
        '    MessageBox.Show("Error al buscar el Pokémon.")
        'End Try
    End Sub

    Private Sub MostrarPokemon(json As String)
        lblNombrePokemon.Text = json
        ''picImagenPokemon.ImageLocation = pokemon.Imagen
        'lblTipoPokemon.Text = String.Join(", ", pokemon.Tipos)
        'lblAtaquePokemon.Text = pokemon.Ataque.ToString()
        'lblDefensaPokemon.Text = pokemon.Defensa.ToString()
        'lblVelocidadPokemon.Text = pokemon.Velocidad.ToString()
    End Sub


    'Public Class Pokemon
    '    Public Property Nombre As String
    '    'Public Property Imagen As String
    '    Public Property Tipos As String()
    '    Public Property Ataque As Integer
    '    Public Property Defensa As Integer
    '    Public Property Velocidad As Integer

    'End Class


End Class
