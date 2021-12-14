function F1()
{
    var NomC = document.getElementById('TT1').value;
    var Adresse = document.getElementById('TT2').value;
    var Numcartbancaire = document.getElementById('TT3').value;
    if(NomC==""||Adresse=="")
    {
        alert("tu doit remplire touts les textbox");
    }
    else
    {
        if(document.getElementById('T1').value==""
        &&document.getElementById('T2').value==""
        &&document.getElementById('T3').value==""
        &&document.getElementById('T4').value==""
        )
        {
            alert("il faut demender un pizza");
        }
    }
    var sum=0;
    if(document.getElementById('T1').value!="")
    {
        sum+=document.getElementById('T1').value*80;
    }
    if(document.getElementById('T2').value!="")
    {
        sum+=document.getElementById('T2').value*75;
    }
    if(document.getElementById('T3').value!="")
    {
        sum+=document.getElementById('T3').value*100;
    }
    if(document.getElementById('T4').value!="")
    {
        sum+=document.getElementById('T4').value*120;
    }
    document.getElementById('Ttt3').value=sum;
}
function F2()
{
    if(document.getElementById('R2').checked)
    {
        document.getElementById('TT3').disabled=true;
    }
}
function F3()
{
    if(document.getElementById('R1').checked)
    {
        document.getElementById('TT3').disabled=false;
    }
}