function f1()
{
    var ValeurE=0;
    var CK1= document.getElementById('CK1');
    var CK2= document.getElementById('CK2');
    var CK3= document.getElementById('CK3');
    var CK4= document.getElementById('CK4');
    var CK5= document.getElementById('CK5');
    var CK6= document.getElementById('CK6');
    var T1 = document.getElementById('T1').value;
    var T2 = document.getElementById('T2').value;
    var T3 = document.getElementById('T3').value;
    var T4 = document.getElementById('T4').value;
    var T5 = document.getElementById('T5').value;
    var T6 = document.getElementById('T6').value;

    if(CK1.checked==false && CK2.checked==false && CK3.checked==false && CK4.checked==false && CK5.checked==false && CK6.checked==false)
        alert('Error');

    if(CK1.checked)
        ValeurE+=T1*2.75;
    if(CK2.checked)
        ValeurE+=T2*1.8;
    if(CK3.checked)
        ValeurE+=T3*0.4;
    if(CK4.checked)
        ValeurE+=T4*116;
    if(CK5.checked)
        ValeurE+=T5*80;
    if(CK6.checked)
        ValeurE+=T6*140;

    document.getElementById('T7').value=""+ValeurE;
}