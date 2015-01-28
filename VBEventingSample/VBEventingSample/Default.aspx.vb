Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblPageLastRefreshed.Text = String.Format("I am a label on the main page. I was last refreshed by Page_Load at {0}", DateTime.Now.ToLongTimeString())
    End Sub

    ' Handle the standard event fired by the usercontrol.
    ' Reset the colour in case the custom event was fired previously.
    Private Sub myUserControl_RefreshParentCommand(ByVal source As Object, e As EventArgs) Handles myUserControl.RefreshParentCommand
        lblPageLastRefreshed.Text = String.Format("I am a label on the main page. I was last refreshed by the embedded user control at {0}", DateTime.Now.ToLongTimeString())
        lblPageLastRefreshed.ForeColor = Drawing.Color.Gray
    End Sub

    ' Handle the custom event fired by the usercontrol whose EventArgs include a colour.
    Private Sub myUserControl_RefreshParentWithColourCommand(ByVal source As Object, e As RefreshParentWithColourEventArgs) Handles myUserControl.RefreshParentWithColourCommand
        lblPageLastRefreshed.Text = String.Format("I am a label on the main page. I was last refreshed by the embedded user control at {0}", DateTime.Now.ToLongTimeString())
        lblPageLastRefreshed.ForeColor = e.Colour
    End Sub
End Class
