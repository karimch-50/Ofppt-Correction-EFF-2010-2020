function F1()
{
    var V1= document.getElementById('S1').value;
    var V2= document.getElementById('S2').value;
    document.getElementById('Tt1').value+=V1+"-"+V2+"\n";
}
function F2()
{
    var sexe="";
    var Nom_Societe="je ne suis pas un societe";
    var Titre_Profil="";
    var Pays_Ville="";
    var Telephone="";
    var Disponibilite="oui";
    var Tarif="";
    if(document.getElementById('radio1').checked)
    {
        sexe="Femme";
    }
    else
    {
        sexe="Homme";
    }

    if(document.getElementById('checkbox').checked)
    {
        Nom_Societe=document.getElementById('T1').value;
    }
    Titre_Profil=document.getElementById('T2').value;
    Pays_Ville=document.getElementById('S').value;
    Telephone=document.getElementById('T3').value;
    if(document.getElementById('checkbox1').checked)
    {
        Disponibilite="A Distance uniquement";
    }
    Tarif=document.getElementById('T4').value;
    var V1= document.getElementById('Tt1').value;

    alert("le sexe est: "+sexe+" le nom de la Societe est: "+Nom_Societe+" titre de profil est: "+Titre_Profil+" Pays/Ville est: "+Pays_Ville+" Telephone est: "+Telephone+" Disponibilite est: "+Disponibilite+" Tarif est: "+Tarif+" Competences maitrisees est: "+V1);
}