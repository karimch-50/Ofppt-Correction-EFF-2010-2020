function f1()
{
    var S1 = document.getElementById('S2').value;
    var S2 = document.getElementById('S3').value;
    document.getElementById('textarea1').value+=S1+"\n" +S2+"\n";
}

function f2()
{
    var sexe="";
    var Nom_Societe = document.getElementById('T1').value;
    var Titre_Profil = document.getElementById('T2').value;
    var Pays_Ville = document.getElementById('S1').value;
    var Telephone = document.getElementById('T3').value;
    var Tarif =document.getElementById('S2').value;
    var Liste_competences =document.getElementById('textarea1').value;
    var Message="";
    
    if(document.getElementById('R1').checked)
        sexe="Femme";
    if(document.getElementById('R2').checked)
        sexe="Homme";
    if(document.getElementById('checkbox1').checked)
    {
        if(document.getElementById('R3').checked)
        Message="sexe:"+sexe+"\n Nom de Societe: "+Nom_Societe+"\n Titre de Profil:"+Titre_Profil+"\n Pays_Ville:"+Pays_Ville+"\n Telephone:"+Telephone+"\n Disponibilite: A Distance uniquement \n Tarif:"+Tarif+"\n Liste de competences:\n"+Liste_competences;
        else
        Message="sexe:"+sexe+"\n Nom de Societe: "+Nom_Societe+"\n Titre de Profil:"+Titre_Profil+"\n Pays_Ville:"+Pays_Ville+"\n Telephone:"+Telephone+"\n Disponibilite: null \n Tarif:"+Tarif+"\n Liste de competences:\n"+Liste_competences;
    }
    else
    {
        if(document.getElementById('R3').checked)
        Message="sexe:"+sexe+"\n Nom de Societe: "+Nom_Societe+"\n Titre de Profil:"+Titre_Profil+"\n Pays_Ville:"+Pays_Ville+"\n Telephone:"+Telephone+"\n Disponibilite: A Distance uniquement \n Tarif:"+Tarif+"\n Liste de competences:\n"+Liste_competences;
        else
        Message="sexe:"+sexe+"\n Nom de Societe: null \n Titre de Profil:"+Titre_Profil+"\n Pays_Ville:"+Pays_Ville+"\n Telephone:"+Telephone+"\n Disponibilite: null \n Tarif:"+Tarif+"\n Liste de competences:\n"+Liste_competences;
    }
    alert(""+Message);
}


