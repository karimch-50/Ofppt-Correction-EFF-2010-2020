function f1()
{
    var NomC = document.getElementById('TT1').value;
    var Adresse = document.getElementById('TT2').value;
    var NbrCartB = document.getElementById('T1').value;
    var T1= document.getElementById('TTT1').value;
    var T2= document.getElementById('TTT2').value;
    var T3= document.getElementById('TTT3').value;
    var T4= document.getElementById('TTT4').value;
    var MontantT=0

    if(NomC=="" || Adresse=="" || (document.getElementById('R2').checked && NbrCartB==""))
        alert("Remplire toute les champs SVP!!");   
    else
    {
        if(T1!=""|| T2!=""|| T3!=""|| T4!="")
            MontantT=T1*80+T2*75+T3*100+T4*120;
        else
            alert('prend un pizza SVP!!')

        document.getElementById('T2').value=""+MontantT;
    }
}
function f2() 
{
    if(document.getElementById('R1').checked)
        document.getElementById("T1").disabled = true;
    if(document.getElementById('R2').checked)
        document.getElementById("T1").disabled = false;
}
