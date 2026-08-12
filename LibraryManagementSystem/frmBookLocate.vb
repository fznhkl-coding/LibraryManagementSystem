Public Class frmBookLocate
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub frmBookLocate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbBiography.Hide()
        pbDictionary.Hide()
        pbEncyclopedia.Hide()
        pbLanguage.Hide()
        pbMagazine.Hide()
        pbNovel.Hide()
    End Sub

    Private Sub btnNovel_Click(sender As Object, e As EventArgs) Handles btnNovel.Click
        pbBiography.Hide()
        pbDictionary.Hide()
        pbEncyclopedia.Hide()
        pbLanguage.Hide()
        pbMagazine.Hide()
        pbNovel.Show()
    End Sub

    Private Sub btnLanguage_Click(sender As Object, e As EventArgs) Handles btnLanguage.Click
        pbBiography.Hide()
        pbDictionary.Hide()
        pbEncyclopedia.Hide()
        pbLanguage.Show()
        pbMagazine.Hide()
        pbNovel.Hide()
    End Sub

    Private Sub btnMagazine_Click(sender As Object, e As EventArgs) Handles btnMagazine.Click
        pbBiography.Hide()
        pbDictionary.Hide()
        pbEncyclopedia.Hide()
        pbLanguage.Hide()
        pbMagazine.Show()
        pbNovel.Hide()
    End Sub

    Private Sub btnDictionary_Click(sender As Object, e As EventArgs) Handles btnDictionary.Click
        pbBiography.Hide()
        pbDictionary.Show()
        pbEncyclopedia.Hide()
        pbLanguage.Hide()
        pbMagazine.Hide()
        pbNovel.Hide()
    End Sub

    Private Sub btnBiography_Click(sender As Object, e As EventArgs) Handles btnBiography.Click
        pbBiography.Show()
        pbDictionary.Hide()
        pbEncyclopedia.Hide()
        pbLanguage.Hide()
        pbMagazine.Hide()
        pbNovel.Hide()
    End Sub

    Private Sub btnEncyclopedia_Click(sender As Object, e As EventArgs) Handles btnEncyclopedia.Click
        pbBiography.Hide()
        pbDictionary.Hide()
        pbEncyclopedia.Show()
        pbLanguage.Hide()
        pbMagazine.Hide()
        pbNovel.Hide()
    End Sub
End Class