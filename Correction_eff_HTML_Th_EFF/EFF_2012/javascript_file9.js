function f1()
{
    var jour = document.getElementById('TT1').value;
    var mois = document.getElementById('TT2').value;
    var annee = document.getElementById('TT3').value;
    var Nom = document.getElementById('T1').value;
    var Prenom = document.getElementById('T2').value;
    var Mdp = document.getElementById('T3').value;
    var CofirmMdp = document.getElementById('T4').value;

    if(jour=="" || mois=="" || annee=="" || Nom=="" || Prenom=="" || Mdp=="" || CofirmMdp=="")
        alert('Remplire tout les champs SVP!!');
    else
    {
        if(jour>31 || jour<1)
        {
            alert('jour doit etre entre 1 et 31!!');
            return;
        }
        if(mois>12 || mois<1)
        {
            alert('mois doit etre entre 1 et 12!!');
            return;
        }
        if(annee<1900)
        {
            alert('annee doit etre >= 1900!!');
            return;
        }
        if(Mdp!=CofirmMdp)
        {
            alert('pas le meme mot de passe!!');
            return;
        }
    }  

}
function f2() 
{
    if(document.getElementById('CK1').checked==true)
        document.getElementById('B1').disabled = false;  
    if(document.getElementById('CK1').checked==false)
        document.getElementById('B1').disabled = true;
}