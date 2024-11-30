Imports System.DirectoryServices
Imports System.IO
Imports System.Numerics
Imports System.Windows.Markup

Public Class Form1

    Dim commands As New commands()
    Dim receiptpath As String
    Dim folderBrowser As New FolderBrowserDialog()
    Dim n As String = Environment.NewLine

    'date and time
    Private Sub PizzaOrder_Load(sender As Object, e As EventArgs) Handles Me.Load

        clearall()

        'value of time and date lables
        lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy")

        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")

        'starts timer to update the date and time constantly
        Timer1.Start()

    End Sub

    'update time
    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")

    End Sub

    'sizes ====================================================================================================================

    Private Sub rbRegular_CheckedChanged(sender As Object, e As EventArgs) Handles rbRegular.CheckedChanged

        If rbRegular.Checked Then

            commands.pizzaprice += 80
            commands.size = "Regular"

        Else

            commands.pizzaprice -= 80

        End If

        pizzaprice()

    End Sub

    Private Sub rbLarge_CheckedChanged(sender As Object, e As EventArgs) Handles rbLarge.CheckedChanged

        If rbLarge.Checked Then

            commands.pizzaprice += 100
            commands.size = "Large"

        Else

            commands.pizzaprice -= 100

        End If

        pizzaprice()

    End Sub

    Private Sub rbFamily_CheckedChanged(sender As Object, e As EventArgs) Handles rbFamily.CheckedChanged

        If rbFamily.Checked Then

            commands.pizzaprice += 150
            commands.size = "Family"

        Else

            commands.pizzaprice -= 150

        End If

        pizzaprice()

    End Sub

    'crust ==================================================================================================================

    Private Sub rbThin_CheckedChanged(sender As Object, e As EventArgs) Handles rbThin.CheckedChanged

        If rbThin.Checked Then

            commands.pizzaprice += 0
            commands.crust = "Thin Crust"

        Else

            commands.pizzaprice -= 0

        End If

        pizzaprice()

    End Sub

    Private Sub rbThick_CheckedChanged(sender As Object, e As EventArgs) Handles rbThick.CheckedChanged

        If rbThick.Checked Then

            commands.pizzaprice += 20
            commands.crust = "Thick Crust"

        Else

            commands.pizzaprice -= 20

        End If

        pizzaprice()

    End Sub

    Private Sub rbStuffed_CheckedChanged(sender As Object, e As EventArgs) Handles rbStuffed.CheckedChanged

        If rbStuffed.Checked Then

            commands.pizzaprice += 40
            commands.crust = "Stuffed Crust"

        Else

            commands.pizzaprice -= 40

        End If

        pizzaprice()

    End Sub

    'drinks =====================================================================================================================

    Private Sub rbTea_CheckedChanged(sender As Object, e As EventArgs) Handles rbTea.CheckedChanged

        If rbTea.Checked Then

            commands.drinkprice += 40
            commands.drink = "Iced Tea"

        Else

            commands.drinkprice -= 40

        End If

        drinkspls()

    End Sub

    Private Sub rbSoft_CheckedChanged(sender As Object, e As EventArgs) Handles rbSoft.CheckedChanged

        If rbSoft.Checked Then

            commands.drinkprice += 60
            commands.drink = "Soft Drink"

        Else

            commands.drinkprice -= 60

        End If

        drinkspls()

    End Sub

    Private Sub rbShake_CheckedChanged(sender As Object, e As EventArgs) Handles rbShake.CheckedChanged

        If rbShake.Checked Then

            commands.drinkprice = 100
            commands.drink = "Milk Shake"

        Else

            commands.drinkprice -= 100

        End If

        drinkspls()

    End Sub

    'cheese ====================================================================================================================

    Private Sub rbParm_CheckedChanged(sender As Object, e As EventArgs) Handles rbParm.CheckedChanged

        If rbParm.Checked Then

            commands.pizzaprice += 40
            commands.cheese = "Parmesan Cheese"

        Else

            commands.pizzaprice -= 40

        End If

        pizzaprice()

    End Sub

    Private Sub rbMoz_CheckedChanged(sender As Object, e As EventArgs) Handles rbMoz.CheckedChanged

        If rbMoz.Checked Then

            commands.pizzaprice += 60
            commands.cheese = "Mozzarela Cheese"

        Else

            commands.pizzaprice -= 60

        End If

        pizzaprice()

    End Sub

    Private Sub rbChed_CheckedChanged(sender As Object, e As EventArgs) Handles rbChed.CheckedChanged

        If rbChed.Checked Then

            commands.pizzaprice += 20
            commands.cheese = "Cheddar Cheese"

        Else

            commands.pizzaprice -= 20

        End If

        pizzaprice()

    End Sub

    'toppings ====================================================================================================

    Private Sub cboxPepperoni_CheckedChanged(sender As Object, e As EventArgs) Handles cboxPepperoni.CheckedChanged

        If cboxPepperoni.Checked Then

            commands.toppingsprice += 10
            commands.toppings.Add("Pepperoni")

        Else

            commands.toppingsprice -= 10
            commands.toppings.Remove("Pepperoni")

        End If

        toppingsyea()

    End Sub

    Private Sub cboxHam_CheckedChanged(sender As Object, e As EventArgs) Handles cboxHam.CheckedChanged

        If cboxHam.Checked Then

            commands.toppingsprice += 10
            commands.toppings.Add("Ham")

        Else

            commands.toppingsprice -= 10
            commands.toppings.Remove("Ham")

        End If

        toppingsyea()

    End Sub

    Private Sub cboxChicken_CheckedChanged(sender As Object, e As EventArgs) Handles cboxChicken.CheckedChanged

        If cboxChicken.Checked Then

            commands.toppingsprice += 20
            commands.toppings.Add("Chicken")

        Else

            commands.toppingsprice -= 20
            commands.toppings.Remove("Chicken")

        End If

        toppingsyea()

    End Sub

    Private Sub cboxSausage_CheckedChanged(sender As Object, e As EventArgs) Handles cboxSausage.CheckedChanged

        If cboxSausage.Checked Then

            commands.toppingsprice += 20
            commands.toppings.Add("Sausage")

        Else

            commands.toppingsprice -= 20
            commands.toppings.Remove("Sausage")

        End If

        toppingsyea()

    End Sub

    Private Sub cboxSalami_CheckedChanged(sender As Object, e As EventArgs) Handles cboxSalami.CheckedChanged

        If cboxSalami.Checked Then

            commands.toppingsprice += 10
            commands.toppings.Add("Salami")

        Else

            commands.toppingsprice -= 10
            commands.toppings.Remove("Salami")

        End If

        toppingsyea()

    End Sub

    Private Sub cboxTruffle_CheckedChanged(sender As Object, e As EventArgs) Handles cboxTruffle.CheckedChanged

        If cboxTruffle.Checked Then

            commands.toppingsprice += 30
            commands.toppings.Add("Truffle")

        Else

            commands.toppingsprice -= 30
            commands.toppings.Remove("Truffle")

        End If

        toppingsyea()

    End Sub

    Private Sub cboxShrooms_CheckedChanged(sender As Object, e As EventArgs) Handles cboxShrooms.CheckedChanged

        If cboxShrooms.Checked Then

            commands.toppingsprice += 10
            commands.toppings.Add("Mushrooms")

        Else

            commands.toppingsprice -= 10
            commands.toppings.Remove("Mushrooms")

        End If

        toppingsyea()

    End Sub

    Private Sub cboxOlives_CheckedChanged(sender As Object, e As EventArgs) Handles cboxOlives.CheckedChanged

        If cboxOlives.Checked Then

            commands.toppingsprice += 10
            commands.toppings.Add("Olives")

        Else

            commands.toppingsprice -= 10
            commands.toppings.Remove("Olives")

        End If

        toppingsyea()

    End Sub

    Private Sub cboxSpinach_CheckedChanged(sender As Object, e As EventArgs) Handles cboxSpinach.CheckedChanged

        If cboxSpinach.Checked Then

            commands.toppingsprice += 20
            commands.toppings.Add("Spinach")

        Else

            commands.toppingsprice -= 20
            commands.toppings.Remove("Spinach")

        End If

        toppingsyea()

    End Sub

    Private Sub cboxPine_CheckedChanged(sender As Object, e As EventArgs) Handles cboxPine.CheckedChanged

        If cboxPine.Checked Then

            commands.toppingsprice += 20
            commands.toppings.Add("Pineapple")

        Else

            commands.toppingsprice -= 20
            commands.toppings.Remove("Pineapple")

        End If

        toppingsyea()

    End Sub

    Private Sub rbDinein_CheckedChanged(sender As Object, e As EventArgs) Handles rbDinein.CheckedChanged

        If rbDinein.Checked Then

            commands.service = "Dine in"

        Else

        End If

    End Sub

    Private Sub rbTakeout_CheckedChanged(sender As Object, e As EventArgs) Handles rbTakeout.CheckedChanged

        If rbTakeout.Checked Then

            commands.service = "Take Out"

        Else

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        clearall()

    End Sub

    Sub clearall()

        rbDinein.Checked = False
        rbTakeout.Checked = False

        rbDummy.Checked = True

        rbRegular.Checked = False
        rbLarge.Checked = False
        rbFamily.Checked = False

        rbThin.Checked = False
        rbThick.Checked = False
        rbStuffed.Checked = False

        rbSoft.Checked = False
        rbTea.Checked = False
        rbShake.Checked = False

        rbParm.Checked = False
        rbMoz.Checked = False
        rbChed.Checked = False

        cboxPepperoni.Checked = False
        cboxHam.Checked = False
        cboxChicken.Checked = False
        cboxSausage.Checked = False
        cboxSalami.Checked = False
        cboxTruffle.Checked = False
        cboxShrooms.Checked = False
        cboxOlives.Checked = False
        cboxSpinach.Checked = False
        cboxPine.Checked = False

        commands.totalprice()

        txtToppings.Text = commands.toppingsprice
        txtPizza.Text = commands.pizzaprice
        txtDrinks.Text = commands.drinkprice
        txtTotal.Text = commands.total

    End Sub

    Private Sub btnBuild_Click(sender As Object, e As EventArgs) Handles btnBuild.Click

        If commands.pizzaprice = Nothing Or commands.total = Nothing Or commands.drinkprice = Nothing Or commands.toppingsprice = Nothing Or commands.service = Nothing Then

            MessageBox.Show("Please select all options", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Exit Sub

        Else

            Dim ordering As DialogResult = MessageBox.Show("Your order is:" & n &
                            n & "Size: " & commands.size & n &
                            n & "Crust: " & commands.crust & n &
                            n & "Drink: " & commands.drink & n &
                            n & "Toppings: " & String.Join(", ", commands.toppings) & n &
                            n & "Cheese: " & commands.cheese & n &
                            n & "Service: " & commands.service & n &
                            n & "Your Price: " & commands.total & " Php", "Receipt", MessageBoxButtons.YesNo)

            Select Case ordering

                Case DialogResult.Yes

                    Dim receipt As DialogResult = MessageBox.Show("Do you want your receipt?", "Order Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    Select Case receipt

                        Case DialogResult.Yes

                            MessageBox.Show("Please pick a location to store your receipt")

                            directorypick()
                            Createnewfile()
                            write()

                        Case DialogResult.No

                    End Select

                    MessageBox.Show("Thank you for ordering at Chucky Cheese", "Thank you!")

                    clearall()

                Case DialogResult.No

                    MessageBox.Show("Please switch out and confirm your items")

            End Select

        End If

    End Sub

    Sub pizzaprice()

        commands.totalprice()

        txtPizza.Text = commands.pizzaprice
        txtTotal.Text = commands.total

    End Sub

    Sub toppingsyea()

        commands.totalprice()

        txtToppings.Text = commands.toppingsprice
        txtTotal.Text = commands.total

    End Sub
    Sub drinkspls()

        commands.totalprice()

        txtDrinks.Text = commands.drinkprice
        txtTotal.Text = commands.total

    End Sub
    Sub Createnewfile()

        Try
            'creates a new file at filepath
            Using fs As FileStream = File.Create(receiptpath)

            End Using

            'catches the error if the location is unauthorized
        Catch ex As UnauthorizedAccessException

            MessageBox.Show("This location is Unauthorized. Please pick another location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Sub directorypick()

        'if a folder selection has been made
        If folderBrowser.ShowDialog() = DialogResult.OK Then

            'converts selectedPath into the folder selected, along with the file name
            receiptpath = folderBrowser.SelectedPath & "\Chucky Cheese Receipt.txt"

            'tells the user that the selected folder has been made
            MessageBox.Show("Selected Folder: " & receiptpath, "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

        End If

    End Sub

    Sub write()

        Try

            ' Use StreamWriter to write to the file
            Using writer As New StreamWriter(receiptpath, append:=True)

                writer.WriteLine("Your Receipt" & n &
                            n & "Your order is:" & n &
                            n & "Size: " & commands.size & n &
                            n & "Crust: " & commands.crust & n &
                            n & "Drink: " & commands.drink & n &
                            n & "Toppings: " & String.Join(", ", commands.toppings) & n &
                            n & "Cheese: " & commands.cheese & n &
                            n & "Service: " & commands.service & n &
                            n & "Your Price: " & commands.total & " Php")

            End Using

            MessageBox.Show("Receipt saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

        Catch ex As Exception

            ' Catch any errors (e.g., access denied) and display a message
            MessageBox.Show("Error saving the file:  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

        End Try


    End Sub

End Class
