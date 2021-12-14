function f1()
{
    var anneeF = document.getElementById('S1').value;
    var MoyG = document.getElementById('T1').value;
    var Nbr_Abs = document.getElementById('T2').value;
    var Decision="";
    if(MoyG=="" || anneeF=="" || Nbr_Abs=="")
        alert('Vous douvez remplire tout les champs!!');
    else
    {
        if(MoyG<0 || MoyG>20)
            alert('le Moyenne generale doit etre entre 0 est 20!!');
        else
        {
            if(MoyG>=10)
                Decision="Admis";
            else
            {
                if(anneeF=="1er annee")
                {
                    if(MoyG>=9 && MoyG<10 && Nbr_Abs<30)
                        Decision="Rachete";
                    if(MoyG>=9 && MoyG<10 && Nbr_Abs>=30 && document.getElementById('CK1').checked==false)
                        Decision="Redouble";
                    if(MoyG>=9 && MoyG<10 && Nbr_Abs>=30 && document.getElementById('CK1').checked==true)
                        Decision="Elemine";
                    if(MoyG<9 && document.getElementById('CK1').checked==false)
                        Decision="Redouble";
                    if(MoyG<9 && document.getElementById('CK1').checked==true)
                        Decision="Elemine";
                }
                if(anneeF=="2eme annee")
                {
                    if(MoyG>=9.5 && MoyG<10 && Nbr_Abs<30)
                        Decision="Admis avec bonus";
                    if(MoyG>=9.5 && MoyG<10 && Nbr_Abs>=30 && document.getElementById('CK1').checked==false)
                        Decision="Redouble";
                    if(MoyG>=9.5 && MoyG<10 && Nbr_Abs>=30 && document.getElementById('CK1').checked==true)
                        Decision="Elemine";
                    if(MoyG<9.5 && document.getElementById('CK1').checked==false)
                        Decision="Redouble";
                    if(MoyG<9.5 && document.getElementById('CK1').checked==true)
                        Decision="Elemine";
                }
            }
        }
    }
    document.getElementById('T3').value=""+Decision;
}
