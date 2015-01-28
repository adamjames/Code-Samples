Public Class SimpleUserControl
    Inherits System.Web.UI.UserControl

    ' Declare the event to fire and delegate to which the handling method will be attatched. The type of the delegate must match the type of the event.
    ' If we just want to notify the parent page that an event has occurred, we can use the standard System.EventArgs class.
    Public Delegate Sub EventHandler(ByVal sender As Object, ByVal e As EventArgs)
    Public Event RefreshParentCommand As EventHandler

    ' If we want to pass information along with our event within the "e" variable, we need to declare a custom Event and EventArgs type instead.
    Public Delegate Sub RefreshParentWithColourEventHandler(ByVal sender As Object, ByVal e As RefreshParentWithColourEventArgs)
    Public Event RefreshParentWithColourCommand As RefreshParentWithColourEventHandler

    ' Page_Load doesn't do anything.
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Protected Sub btnRefreshParentPage_Click() Handles btnRefreshParentPage.Click
        ' When we click the button, fire the event. 
        RaiseEvent RefreshParentCommand(Me, New EventArgs)
    End Sub

    Protected Sub btnRefreshParentPageWithRedLabel_Click() Handles btnRefreshParentPageWithRedLabel.Click
        ' When we click the button, fire the event. Pass the colour red in an instance of our custom EventArgs type.
        RaiseEvent RefreshParentWithColourCommand(Me, New RefreshParentWithColourEventArgs(System.Drawing.Color.Red))
    End Sub

    Protected Sub btnRefreshParentPageWithOrangeLabel_Click() Handles btnRefreshParentPageWithOrangeLabel.Click
        ' When we click the button, fire the event. Pass the colour orange in an instance of our custom EventArgs type.
        RaiseEvent RefreshParentWithColourCommand(Me, New RefreshParentWithColourEventArgs(System.Drawing.Color.Orange))
    End Sub
End Class

' Define our custom EventArgs class. It allows us to specify a colour when we fire the RefreshParentWithColour event.
Public Class RefreshParentWithColourEventArgs
    Inherits System.EventArgs
    Private _colour As System.Drawing.Color = Drawing.Color.Black

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal colour As System.Drawing.Color)
        Me.New()
        _colour = colour
    End Sub

    Public ReadOnly Property Colour As System.Drawing.Color
        Get
            Return _colour
        End Get
    End Property
End Class