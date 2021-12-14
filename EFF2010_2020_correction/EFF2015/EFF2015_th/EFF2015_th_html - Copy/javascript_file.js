function F1()
{
    var A=0;
    if(document.getElementById('1').checked==true 
    || document.getElementById('2').checked==true
    || document.getElementById('3').checked==true
    || document.getElementById('4').checked==true
    || document.getElementById('5').checked==true
    || document.getElementById('6').checked==true)
    {
        if(document.getElementById('1').checked)
        {
            A+=(parseFloat(document.getElementById('T1').value)*2.75)
        }
        if(document.getElementById('2').checked)
        {
            A+=(parseFloat(document.getElementById('T2').value)*1.8)
        }
        if(document.getElementById('3').checked)
        {
            A+=parseFloat(document.getElementById('T3').value)*0.4
        }
        if(document.getElementById('4').checked)
        {
            A+=parseFloat(document.getElementById('T4').value)*116 
        }
        if(document.getElementById('5').checked)
        {
            A+=parseFloat(document.getElementById('T5').value)*80
        }
        if(document.getElementById('6').checked)
        {
            A+=parseFloat(document.getElementById('T6').value)*140 
        }
        document.getElementById('T7').value=A;
    }
    else
    {
        alert("erreur!!");
    }
    
}