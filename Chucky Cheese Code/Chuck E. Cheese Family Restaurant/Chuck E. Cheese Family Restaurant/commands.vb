Public Class commands

    'Integers

    Public drinkprice As Integer
    Public toppingsprice As Integer
    Public pizzaprice As Integer
    Public total As Integer

    Public Sub totalprice()

        total = drinkprice + toppingsprice + pizzaprice

    End Sub

    'Strings

    Public size As String
    Public crust As String
    Public drink As String
    Public toppings As New List(Of String)
    Public cheese As String
    Public eatwhere As String
    Public service As String

End Class
