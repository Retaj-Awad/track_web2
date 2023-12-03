Public Class Admin_Master
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsNothing(Session("admin")) = True Then
            Response.Redirect("~/View/Home/Home_Page.aspx")
        End If
    End Sub

End Class