
var N1 = Math.round(Math.random()*100);
var N2 = Math.round(Math.random()*100);
function f1()
{
    var prenom = document.getElementById('T1').value;
    var nom= document.getElementById('T2').value;
    var Telephone= document.getElementById('T3').value;
    var T4= document.getElementById('T4').value;
    var Texteria= document.getElementById('TA1').value;
    var select = document.getElementById('S1').value;
    var S="";
    if(document.getElementById('R1').checked==false && document.getElementById('R2').checked==false && document.getElementById('R3').checked==false)
    {
        alert('selectionner chi haja!!');
    }
    else
    {
        if(document.getElementById('R1').checked)
        {
            S="Madame";
        }
        else if(document.getElementById('R2').checked)
        {
            S="Mademoiselle";
        }
        else
        {
            S="Monsieur";
        }

    if(prenom==""||nom==""||Telephone=="") 
    {
        alert('Vous douvez remplire tout les champs!!');
    }
    else
    {
        if(isNaN(Telephone))
        {
            alert('vous douvez entrer une nombre');
        }
        else
        {
            if(T4==(N1+N2))
            {
                alert(" "+S+"    "+prenom+"  "+nom+" "+Telephone+"   "+Texteria+"    "+select);
            }
        }
    }
    }
}
function f2()
{
    document.getElementById('L1').innerHTML=N1.toString();
    document.getElementById('L2').innerHTML=N2.toString();
}

function f3()
{
    document.getElementById('T1').value="";
    document.getElementById('T2').value="";
    document.getElementById('T3').value="";
    document.getElementById('T4').value="";
    document.getElementById('T5').value="";
    document.getElementById('S1').value="";
}
