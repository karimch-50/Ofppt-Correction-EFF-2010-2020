var nom=document.getElementById('i1').value;
var prenom;
var L1;
var L2;
$.ajax({
    type:'post',
    dataType:'html',
    url:'localhost......',
    data:'le nom est:'+nom+'le prenom est:'+prenom,
    success: function(){
        alert('bien envoyer!!');
    },
    error: function(){
        alert('error');
    }
});
