Public Partial Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dt As DataTable
        dt = Session("conducteur")
        cn.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select conducteur.idconducteur,marque,modele,nomassureur,dateass,dateexpiration,DATEDIFF(day,getdate(),dateexpiration) as 'duree restant en jour 'from conducteur,vehicule,assvehicule where conducteur.idconducteur = vehicule.idconducteur and vehicule.immat = assvehicule.immat and conducteur.idconducteur = " & dt.Rows(0)(0) & ""
        cmd.Connection = cn
        dr = cmd.ExecuteReader
        GridView1.DataSource = dr
        GridView1.DataBind()
        cn.Close()
        dr.Close()
    End Sub

End Class