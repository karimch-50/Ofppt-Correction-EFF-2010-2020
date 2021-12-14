var random1=Math.floor(Math.random()*10+1);
var random2=Math.floor(Math.random()*10+1);
function F1()
{
    document.getElementById('label').innerHTML="Quel est le resultat de l'expression :"+random1+"-"+random2;
}
function F2()
{
    var sexe;
    if(document.getElementById('R1').checked)
    {
        sexe="Madame";
    }
    if(document.getElementById('R2').checked)
    {
        sexe="Mademoseille";
    }
    if(document.getElementById('R3').checked)
    {
        sexe="Monseur";
    }
    var Nom=document.getElementById('T1').value;
    var Prenom=document.getElementById('T2').value;
    var tele=document.getElementById('T3').value;
    var Ville=document.getElementById('S1').value;
    var intitblague=document.getElementById('T4').value;
    var blague=document.getElementById('S2').value;
    if(document.getElementById('T5').value==(random1-random2))
    {
        alert(" sexe: "+sexe+" Nom: "+Nom+" Prenom: "+Prenom+" tele: "+tele+" Ville: "+Ville+" intitblague: "+intitblague+" blague: "+blague);
    }
    else
    {
        alert("try again");
    }
}