const toTop = document.querySelector(".to-top");

window.addEventListener("scroll", () => {
  if (window.pageYOffset > 100) {
    toTop.classList.add("active");
  } else {
    toTop.classList.remove("active");
  }
})


$(window).scroll(function(){
    $('nav').toggleClass('scrolled',$(this).scrollTop()>60);
});


$(document).ready(function() {
$('#example').DataTable();
} );

function show1(){

  document.getElementById('div1').style="display:flex;";
  document.getElementById('div2').style.display="none";
  document.getElementById('div3').style.display="none";
  document.getElementById('div4').style.display="none";
}

function show2(){
  document.getElementById('div1').style.display="none";
  document.getElementById('div2').style.display="block";
  document.getElementById('div3').style.display="none";
  document.getElementById('div4').style.display="none";
}

function show3(){
  document.getElementById('div1').style.display="none";
  document.getElementById('div2').style.display="none";
  document.getElementById('div3').style.display="flex";
  document.getElementById('div4').style.display="none";
}

function show4(){
  document.getElementById('div1').style.display="none";
  document.getElementById('div2').style.display="none";
  document.getElementById('div3').style.display="none";
  document.getElementById('div4').style.display="flex";
}

$('#datepicker').datepicker({  
});  

// function services(){
//   document.getElementById('ser_1')
// }