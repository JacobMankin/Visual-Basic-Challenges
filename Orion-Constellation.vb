Public Class OrionConstellation
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close current form
        Me.Close()
    End Sub


    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'shows names of stars when clicked
        lblSaiph.Visible = True
        lblRigel.Visible = True
        lblMintaka.Visible = True
        lblMeissa.Visible = True
        lblBetelgeuse.Visible = True
        lblAlnitak.Visible = True
        lblAlnilam.Visible = True
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        'make star names hidden when clicked
        lblAlnilam.Visible = False
        lblAlnitak.Visible = False
        lblBetelgeuse.Visible = False
        lblMintaka.Visible = False
        lblRigel.Visible = False
        lblMeissa.Visible = False
        lblSaiph.Visible = False
    End Sub
End Class
