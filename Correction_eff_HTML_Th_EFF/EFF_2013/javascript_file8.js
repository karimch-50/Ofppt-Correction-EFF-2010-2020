function f1()
{
    var T1 = document.getElementById('T1').value;
    if(isNaN(T1))
        document.getElementById('L1').innerHTML ="Error";

    var SalaireB=T1*4.83;;
    var Prime_R=SalaireB*0.13;
    var Retune_Retrait=((SalaireB+Prime_R)*0.06);
    var Retune_metual=((SalaireB+Prime_R)*0.025);
    var salaireAnn=((SalaireB+Prime_R)-Retune_Retrait-Retune_metual)*12;
    var IR=0;
    if(salaireAnn<=28000.00)
        IR=salaireAnn/12;
    else if(salaireAnn<=40000.00)
        IR=(salaireAnn-3360)/12;
    else if(salaireAnn<=50000.00)
        IR=(salaireAnn-8160-(salaireAnn-40000)*0.24)/12;
    else if(salaireAnn<=60000.00)
        IR=(salaireAnn-13160-(salaireAnn-50000)*0.34)/12;
    else if(salaireAnn<=150000.00)
        IR=(salaireAnn-15560-(salaireAnn-60000)*0.38)/12;
    else 
        IR=(salaireAnn-18560-(salaireAnn-150000)*0.4)/12;

    document.getElementById('T2').value=SalaireB;
    document.getElementById('T3').value=Prime_R;
    document.getElementById('T4').value=Retune_Retrait;
    document.getElementById('T5').value=Retune_metual;
    document.getElementById('T7').value=Math.round(IR);;
    document.getElementById('T6').value=Math.round(SalaireB+Prime_R-Math.round(IR));
}