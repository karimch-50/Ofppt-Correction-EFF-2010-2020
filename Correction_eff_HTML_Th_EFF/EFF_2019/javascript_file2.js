function f1()
{
    var d1 = new Date();
    var d2 = new Date(document.getElementById('date1').value);  
    if((d1.getFullYear()-d2.getFullYear())>9)
    {
        alert('nice');
    }
    else
    {
        alert('3eyaan')
    }
}

function f2()
{
    if(document.getElementById('R1').checked)
    {
        //alert('Radio1');
        document.getElementById('label').style.display="none";
        document.getElementById('fieldset1').style.display="none";
    }
}
function f3()
{
    if(document.getElementById('R2').checked)
    {
        //alert('Radio2');
        document.getElementById('label').style.display="block";
        document.getElementById('fieldset1').style.display="block";
    }
}

function f4()
{
    var cin=document.getElementById('T1').value;
    var Nom=document.getElementById('T2').value;
    var Prenom=document.getElementById('T3').value;
    var Date=document.getElementById('T4').value;
    var sexe='';
    if(document.getElementById('R1').checked)
        sexe='H';

    if(document.getElementById('R2').checked)
        sexe='F';
    var cin_accom=document.getElementById('S1').value;
    var lien_f=document.getElementById('S2').value;
    var group_s=document.getElementById('S3').value;
    var malidie=document.getElementById('textarea').value;

    $ajax({
        type:'post',
        dataType:'html',
        url:'controler',
        data:'cin: '+cin+' Nom: '+Nom+' Prenom: '+Prenom+' Date: '+Date+' sexe: '+sexe+' cin_accom: '+cin_accom+' lien_f: '+lien_f+' group_s:'+group_s+' malidie:'+malidie,
        success:function(){
            alert('bien envoyer');
        },
        error:function(){
            alert('Error!!');
        }
    });
}
