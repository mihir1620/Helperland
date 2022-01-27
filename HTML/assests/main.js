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

function transformArrow(arrow){
  arrow.classList.toggle('rotate-arrow');
}

function customer_faq(){
  document.getElementById('faq-customer').style="display:block;margin-top:40px";
  document.getElementById('faq-pro').style="display:none";
  document.getElementById('cust').style="background-color: #1d7a8c;color:white";
  document.getElementById('pro').style="background-color: #f6f6f6;color:#4F4F4F;transition: ease-in 0.3s;";
}

function pro_faq(){
  document.getElementById('faq-customer').style="display:none";
  document.getElementById('faq-pro').style="display:block;margin-top:40px";
  document.getElementById('pro').style="background-color: #1d7a8c;color:white";
  document.getElementById('cust').style="background-color: #f6f6f6;color:#4F4F4F;transition:  ease-in 0.3s;";
}

$(document).ready(function() {
$('#example').DataTable();
} );


function show1(){

  document.getElementById('service-tab-1').style="background-color: #1d7a8c;color:white";
  document.getElementById('set-up-img').src="./assests/images/setup-service-white.png";
  document.getElementById('set-p-text').style="color:white";

  document.getElementById('service-tab-2').style="background-color: #f3f3f3;";
  document.getElementById('schedule-img').src="./assests/images/schedule.png";
  document.getElementById('schedule-p-text').style="color:#4f4f4f";

  document.getElementById('service-tab-3').style="background-color: #f3f3f3;color:#4f4f4f";
  document.getElementById('your-detail-img').src="./assests/images/details.png";
  document.getElementById('detail-p-text').style="color:#4f4f4f";

  document.getElementById('service-tab-4').style="background-color: #f3f3f3;color:#4f4f4f";
  document.getElementById('payment-img').src="./assests/images/payment.png";
  document.getElementById('payment-p-text').style="color:#4f4f4f";

  document.getElementById('div1').style="display:flex;";
  document.getElementById('div2').style.display="none";
  document.getElementById('div3').style.display="none";
  document.getElementById('div4').style.display="none";
}

function show2(){
  document.getElementById('service-tab-2').style="background-color: #1d7a8c;color:white";
  document.getElementById('schedule-img').src="./assests/images/schedule-white.png";
  document.getElementById('schedule-p-text').style="color:white";

  document.getElementById('service-tab-3').style="background-color: #f3f3f3;";
  document.getElementById('your-detail-img').src="./assests/images/details.png";
  document.getElementById('detail-p-text').style="color:#4f4f4f";

  document.getElementById('service-tab-4').style="background-color: #f3f3f3;color:#4f4f4f";
  document.getElementById('payment-img').src="./assests/images/payment.png";
  document.getElementById('payment-p-text').style="color:#4f4f4f";
  document.getElementById('div1').style.display="none";
  document.getElementById('div2').style.display="block";
  document.getElementById('div3').style.display="none";
  document.getElementById('div4').style.display="none";
}

function show3(){
  document.getElementById('service-tab-3').style="background-color: #1d7a8c;color:white";
  document.getElementById('your-detail-img').src="./assests/images/details-white.png";
  document.getElementById('detail-p-text').style="color:white";
  document.getElementById('service-tab-4').style="background-color: #f3f3f3;";
  document.getElementById('payment-img').src="./assests/images/payment.png";
  document.getElementById('payment-p-text').style="color:#4f4f4f";
  document.getElementById('div1').style.display="none";
  document.getElementById('div2').style.display="none";
  document.getElementById('div3').style.display="flex";
  document.getElementById('div4').style.display="none";
}

function show4(){
  document.getElementById('service-tab-4').style="background-color: #1d7a8c;color:white";
  document.getElementById('payment-img').src="./assests/images/payment-white.png";
  document.getElementById('payment-p-text').style="color:white";
  document.getElementById('div1').style.display="none";
  document.getElementById('div2').style.display="none";
  document.getElementById('div3').style.display="none";
  document.getElementById('div4').style.display="flex";
}

function displayAddForm(){
  document.getElementById('addAdd').style.display="none";
  document.getElementById('AddForm').style.display="block";
}

function cancelAdd(){
  document.getElementById('addAdd').style.display="block";
  document.getElementById('AddForm').style.display="none";
}
// $(document).ready(function(){
//   var date_input=$('input[name="date"]'); 
//   var container=$('.bootstrap-iso form').length>0 ? $('.bootstrap-iso form').parent() : "body";
//   var options={
//     format: 'mm/dd/yyyy',
//     container: container,
//     todayHighlight: true,
//     autoclose: true,
//   };
//   date_input.datepicker(options);
// })
