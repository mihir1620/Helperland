const toTop = document.querySelector(".to-top");

window.addEventListener("scroll", () => {
    if (window.pageYOffset > 100) {
        toTop.classList.add("active");
    } else {
        toTop.classList.remove("active");
    }
})


$(window).scroll(function () {
    $('nav').toggleClass('scrolled', $(this).scrollTop() > 60);
});

function transformArrow(arrow) {
    arrow.classList.toggle('rotate-arrow');
}

function customer_faq() {
    document.getElementById('faq-customer').style = "display:block;margin-top:40px";
    document.getElementById('faq-pro').style = "display:none";
    document.getElementById('cust').style = "background-color: #1d7a8c;color:white";
    document.getElementById('pro').style = "background-color: #f6f6f6;color:#4F4F4F;transition: ease-in 0.3s;";
}

function pro_faq() {
    document.getElementById('faq-customer').style = "display:none";
    document.getElementById('faq-pro').style = "display:block;margin-top:40px";
    document.getElementById('pro').style = "background-color: #1d7a8c;color:white";
    document.getElementById('cust').style = "background-color: #f6f6f6;color:#4F4F4F;transition:  ease-in 0.3s;";
}




function show1() {

    document.getElementById('service-tab-1').style = "background-color: #1d7a8c;color:white";
    document.getElementById('set-up-img').src = "../images/setup-service-white.png";
    document.getElementById('set-p-text').style = "color:white";

    document.getElementById('service-tab-2').style = "background-color: #f3f3f3;";
    document.getElementById('schedule-img').src = "../images/schedule.png";
    document.getElementById('schedule-p-text').style = "color:#4f4f4f";

    document.getElementById('service-tab-3').style = "background-color: #f3f3f3;color:#4f4f4f";
    document.getElementById('your-detail-img').src = "../images/details.png";
    document.getElementById('detail-p-text').style = "color:#4f4f4f";

    document.getElementById('service-tab-4').style = "background-color: #f3f3f3;color:#4f4f4f";
    document.getElementById('payment-img').src = "../images/payment.png";
    document.getElementById('payment-p-text').style = "color:#4f4f4f";

    document.getElementById('div1').style = "display:flex;";
    document.getElementById('div2').style.display = "none";
    document.getElementById('div3').style.display = "none";
    document.getElementById('div4').style.display = "none";
}

function show2() {
    document.getElementById('service-tab-2').style = "background-color: #1d7a8c;color:white";
    document.getElementById('schedule-img').src = "../images/schedule-white.png";
    document.getElementById('schedule-p-text').style = "color:white";

    document.getElementById('service-tab-3').style = "background-color: #f3f3f3;";
    document.getElementById('your-detail-img').src = "../images/details.png";
    document.getElementById('detail-p-text').style = "color:#4f4f4f";

    document.getElementById('service-tab-4').style = "background-color: #f3f3f3;color:#4f4f4f";
    document.getElementById('payment-img').src = "../images/payment.png";
    document.getElementById('payment-p-text').style = "color:#4f4f4f";
    document.getElementById('div1').style.display = "none";
    document.getElementById('div2').style.display = "block";
    document.getElementById('div3').style.display = "none";
    document.getElementById('div4').style.display = "none";
}

function show3() {
    document.getElementById('service-tab-3').style = "background-color: #1d7a8c;color:white";
    document.getElementById('your-detail-img').src = "../images/details-white.png";
    document.getElementById('detail-p-text').style = "color:white";
    document.getElementById('service-tab-4').style = "background-color: #f3f3f3;";
    document.getElementById('payment-img').src = "../images/payment.png";
    document.getElementById('payment-p-text').style = "color:#4f4f4f";
    document.getElementById('div1').style.display = "none";
    document.getElementById('div2').style.display = "none";
    document.getElementById('div3').style.display = "flex";
    document.getElementById('div4').style.display = "none";
}

function show4() {
    document.getElementById('service-tab-4').style = "background-color: #1d7a8c;color:white";
    document.getElementById('payment-img').src = "../images/payment-white.png";
    document.getElementById('payment-p-text').style = "color:white";
    document.getElementById('div1').style.display = "none";
    document.getElementById('div2').style.display = "none";
    document.getElementById('div3').style.display = "none";
    document.getElementById('div4').style.display = "flex";
}

var chk1 = document.getElementById("mycheckbox1");
var chk2 = document.getElementById("mycheckbox2");
var chk3 = document.getElementById("mycheckbox3");
var chk4 = document.getElementById("mycheckbox4");
var chk5 = document.getElementById("mycheckbox5");

function cabinet() {
    if (chk1.checked) {
        document.getElementById("cabinetimg").src ="../images/1-green.png";
    }
    else {
        document.getElementById("cabinetimg").src = "../images/service_1.png";
    }
}

function fridge() {
    if (chk2.checked) {
        document.getElementById("fridgeimg").src = "../images/2-green.png";
    }
    else {
        document.getElementById("fridgeimg").src = "../images/service_2.png";
    }
}

function oven() {
    if (chk3.checked) {
        document.getElementById("ovenimg").src = "../images/3-green.png";
    }
    else {
        document.getElementById("ovenimg").src = "../images/service_3.png";
    }
}

function laundry() {
    if (chk4.checked) {
        document.getElementById("laundryimg").src = "../images/4-green.png";
    }
    else {
        document.getElementById("laundryimg").src = "../images/service_4.png";
    }
}

function windows() {
    if (chk5.checked) {
        document.getElementById("windowimg").src = "../images/5-green.png";
    }
    else {
        document.getElementById("windowimg").src = "../images/service_5.png";
    }
}

function displayAddForm() {
    document.getElementById('addAdd').style.display = "none";
    document.getElementById('AddForm').style.display = "block";
}

function cancelAdd() {
    document.getElementById('addAdd').style.display = "block";
    document.getElementById('AddForm').style.display = "none";
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

//$(document).ready(function () {
//    $('#example').DataTable();
//});