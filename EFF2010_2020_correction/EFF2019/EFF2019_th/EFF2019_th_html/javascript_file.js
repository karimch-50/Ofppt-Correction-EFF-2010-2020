const { get } = require("jquery");

function F1()
{
    var DateNow= new Date();
    var DatePe = document.getElementById('T4').value.substring(0,4);
    // alert(""+DateNow.getFullYear());
    // alert(""+DatePe);

    // if((DateNow.getFullYear()-parseInt(DatePe))<9)
    // {
    //     alert("Ereur");
    // }
    var cin= document.getElementById('T1').value;
    var nom= document.getElementById('T2').value;
    var prenom= document.getElementById('T3').value;
    var date= document.getElementById('T4').value;
    var sexe="";
    var cinAcco="";
    var lienFam="";
    var groups=document.getElementById('S3').value;
    var maladies=document.getElementById('TXA1').value;
    if(document.getElementById('R1').checked)
    {
        sexe="H";
    }
    else
    {
        sexe="F";
    }
    if(document.getElementById('R2').checked)
    {
        cinAcco=document.getElementById('S1').value;
        lienFam=document.getElementById('S2').value
    }
    var globale="cin est: "+cin+" nom est: "+nom+" prenom est: "
    +prenom+" date est: "+date+" sexe est: "+sexe+" CIN de l'accompagnateur est: "
    +cinAcco+" lien familial est: "+lienFam+" group sanguin est: "+groups+" maladies est: "+maladies;
    alert(globale);
    
    $.ajax('controleur',{
        type:'get',
        url:'controleur',
        data:'globale',
        dataType:'text',
        success:'alert("bien valider");',
        error:'alert("error");',
        timeout:'10000'
    });
}
function F2()
{
    if(document.getElementById('R1').checked)
    {
        document.getElementById('D1').style.display='none';
    }
    if(document.getElementById('R2').checked)
    {
        document.getElementById('D1').style.display='block';
    }
    
}