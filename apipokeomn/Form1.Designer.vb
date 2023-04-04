<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtNombrePokemon = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblNombrePokemon = New System.Windows.Forms.Label()
        Me.lblTipoPokemon = New System.Windows.Forms.Label()
        Me.lblAtaquePokemon = New System.Windows.Forms.Label()
        Me.lblDefensaPokemon = New System.Windows.Forms.Label()
        Me.lblVelocidadPokemon = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNombrePokemon
        '
        Me.txtNombrePokemon.Location = New System.Drawing.Point(25, 41)
        Me.txtNombrePokemon.Name = "txtNombrePokemon"
        Me.txtNombrePokemon.Size = New System.Drawing.Size(100, 23)
        Me.txtNombrePokemon.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(146, 45)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblNombrePokemon
        '
        Me.lblNombrePokemon.AutoSize = True
        Me.lblNombrePokemon.Location = New System.Drawing.Point(22, 110)
        Me.lblNombrePokemon.Name = "lblNombrePokemon"
        Me.lblNombrePokemon.Size = New System.Drawing.Size(49, 15)
        Me.lblNombrePokemon.TabIndex = 2
        Me.lblNombrePokemon.Text = "nombre"
        '
        'lblTipoPokemon
        '
        Me.lblTipoPokemon.AutoSize = True
        Me.lblTipoPokemon.Location = New System.Drawing.Point(146, 110)
        Me.lblTipoPokemon.Name = "lblTipoPokemon"
        Me.lblTipoPokemon.Size = New System.Drawing.Size(28, 15)
        Me.lblTipoPokemon.TabIndex = 3
        Me.lblTipoPokemon.Text = "tipo"
        '
        'lblAtaquePokemon
        '
        Me.lblAtaquePokemon.AutoSize = True
        Me.lblAtaquePokemon.Location = New System.Drawing.Point(263, 110)
        Me.lblAtaquePokemon.Name = "lblAtaquePokemon"
        Me.lblAtaquePokemon.Size = New System.Drawing.Size(43, 15)
        Me.lblAtaquePokemon.TabIndex = 4
        Me.lblAtaquePokemon.Text = "ataque"
        '
        'lblDefensaPokemon
        '
        Me.lblDefensaPokemon.AutoSize = True
        Me.lblDefensaPokemon.Location = New System.Drawing.Point(422, 110)
        Me.lblDefensaPokemon.Name = "lblDefensaPokemon"
        Me.lblDefensaPokemon.Size = New System.Drawing.Size(48, 15)
        Me.lblDefensaPokemon.TabIndex = 5
        Me.lblDefensaPokemon.Text = "defensa"
        '
        'lblVelocidadPokemon
        '
        Me.lblVelocidadPokemon.AutoSize = True
        Me.lblVelocidadPokemon.Location = New System.Drawing.Point(527, 110)
        Me.lblVelocidadPokemon.Name = "lblVelocidadPokemon"
        Me.lblVelocidadPokemon.Size = New System.Drawing.Size(58, 15)
        Me.lblVelocidadPokemon.TabIndex = 6
        Me.lblVelocidadPokemon.Text = "velocidad"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblVelocidadPokemon)
        Me.Controls.Add(Me.lblDefensaPokemon)
        Me.Controls.Add(Me.lblAtaquePokemon)
        Me.Controls.Add(Me.lblTipoPokemon)
        Me.Controls.Add(Me.lblNombrePokemon)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtNombrePokemon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombrePokemon As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblNombrePokemon As Label
    Friend WithEvents lblTipoPokemon As Label
    Friend WithEvents lblAtaquePokemon As Label
    Friend WithEvents lblDefensaPokemon As Label
    Friend WithEvents lblVelocidadPokemon As Label
End Class
