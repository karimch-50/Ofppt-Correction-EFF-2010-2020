function f1()
{
    var T1 = document.getElementById('T1').value;
    var T2 = document.getElementById('T2').value;
    var T3 = document.getElementById('T3').value;
    var R1 = document.getElementById('R1');
    var R2 = document.getElementById('R2');
    var R3 = document.getElementById('R3');
    var R4 = document.getElementById('R4');
    //var S1 = document.getElementById('S1').value;
    var CK1 = document.getElementById('CK1');
    var CK2 = document.getElementById('CK2');
    var CK3 = document.getElementById('CK3');
    var CK4 = document.getElementById('CK4');
    var CK5 = document.getElementById('CK5');
    var CK6 = document.getElementById('CK6');
    var sexe="";
    var Nationaliter="";
    var Message="";
    var Interet="";
    var cpt=0;

    if(R1.checked)
        sexe="Il";
    if(R2.checked)
        sexe="Elle"; 
    if(R3.checked)
        Nationaliter="Marocaine"; 
    if(R4.checked)
        Nationaliter="Etrangere";  

    if(CK1.checked)
    {
        cpt++;
        Interet+=" Lecture,";
    }
    if(CK2.checked)
    {
        cpt++;
        Interet+=" Cenema,";
    }
    if(CK3.checked)
    {
        cpt++;
        Interet+=" Sport,";
    }
    if(CK4.checked)
    {
        cpt++;
        Interet+="Theatre,";
    }
    if(CK5.checked)
    {
        cpt++;
        Interet+="Voyage,";
    }
    if(CK6.checked)
    {
        cpt++;
        Interet+="et Sciences.";
    }

    if(cpt<2)
        Message=T1+" "+T2+", age "+T3+" ans. "+sexe+" est "+Nationaliter+".Son interet est:"+Interet;
    else
        Message=T1+" "+T2+", age "+T3+" ans. "+sexe+" est "+Nationaliter+".Ses interets Sont:"+Interet;

    document.getElementById('L1').innerText=Message.toString();
}