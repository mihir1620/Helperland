const toTop = document.querySelector(".to-top");
var hrs = document.getElementById("total_hours");

$(document).ready(function () {
    $('#example').DataTable();
});


$('#loadDashboard').load('/Customer/DashboardTable');
$('#loadServiceHistoryTable').load('/Customer/ServiceHistoryTable');
$('#loadNewServices').load('/ServiceProvider/NewServiceTable');
$('#loadSpadd').load('/ServiceProvider/SpAddress');
$('#loadSppasswd').load('/ServiceProvider/SpPassword');

window.addEventListener("scroll", () => {
    if (window.pageYOffset > 100) {
        toTop.classList.add("active");
    }
    else {
        toTop.classList.remove("active");
    }
})


$(window).scroll(function () {
    $('nav').toggleClass('scrolled', $(this).scrollTop() > 60);
});

window.setTimeout(function () {
    $(".alert1").fadeTo(300, 0).slideUp(300, function () {
        $(this).remove();
    });
}, 3000);

window.setTimeout(function () {
    $(".bookalert").fadeTo(500, 0).slideUp(500, function () {
        $(this).remove();
    });
}, 5000);


function transformArrow(arrow) {
    arrow.classList.toggle('rotate-arrow');
}

var chk1 = document.getElementById("mycheckbox1");
var chk2 = document.getElementById("mycheckbox2");
var chk3 = document.getElementById("mycheckbox3");
var chk4 = document.getElementById("mycheckbox4");
var chk5 = document.getElementById("mycheckbox5");
/*var rs = parseInt(document.getElementById("total").innerHTML);*/


function cabinet() {

    if (chk1.checked)
    {
        document.getElementById("cabinetimg").src = "../images/1-green.png";
        document.getElementById("1_extra").style = "display:block !important";
        document.getElementById("1_extra1").style = "display:block !important";
    }
    else
    {
        document.getElementById("cabinetimg").src = "../images/service_1.png";
        document.getElementById("1_extra").style = "display:none !important";
        document.getElementById("1_extra1").style = "display:none !important";

    }
}

function fridge() {

    if (chk2.checked) {
        document.getElementById("fridgeimg").src = "../images/2-green.png";
        document.getElementById("2_extra").style = "display:block !important";
        document.getElementById("2_extra2").style = "display:block !important";
    }
    else {
        document.getElementById("fridgeimg").src = "../images/service_2.png";
        document.getElementById("2_extra").style = "display:none !important";
        document.getElementById("2_extra2").style = "display:none !important";
    }
}

function oven() {

    if (chk3.checked) {
        document.getElementById("ovenimg").src = "../images/3-green.png";
        document.getElementById("3_extra").style = "display:block !important";
        document.getElementById("3_extra3").style = "display:block !important";
    }
    else {
        document.getElementById("ovenimg").src = "../images/service_3.png";
        document.getElementById("3_extra").style = "display:none !important";
        document.getElementById("3_extra3").style = "display:none !important";
    }
}

function laundry() {

    if (chk4.checked) {
        document.getElementById("laundryimg").src = "../images/4-green.png";
        document.getElementById("4_extra").style = "display:block !important";
        document.getElementById("4_extra4").style = "display:block !important";
    }
    else {
        document.getElementById("laundryimg").src = "../images/service_4.png";
        document.getElementById("4_extra").style = "display:none !important";
        document.getElementById("4_extra4").style = "display:none !important";
    }
}

function windows() {

    if (chk5.checked) {
        document.getElementById("windowimg").src = "../images/5-green.png";
        document.getElementById("5_extra").style = "display:block !important";
        document.getElementById("5_extra5").style = "display:block !important";
    }
    else {
        document.getElementById("windowimg").src = "../images/service_5.png";
        document.getElementById("5_extra").style = "display:none !important";
        document.getElementById("5_extra5").style = "display:none !important";
    }
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
 
   

    $('#div1').show();
    $('#div2').hide();
    $('#div3').hide();
    $('#div4').hide();
    //document.getElementById('div1').style = "display:flex;";
    //document.getElementById('div2').style.display = "none";
    //document.getElementById('div3').style.display = "none";
    //document.getElementById('div4').style.display = "none";
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

    $('#div1').hide();
    $('#div2').show();
    $('#div3').hide();
    $('#div4').hide();
    //document.getElementById("service-tab-1").disabled = true;
    //document.getElementById("service-tab-2").disabled = false;
    //document.getElementById("service-tab-3").disabled = true;
    //document.getElementById("service-tab-4").disabled = true;
    //document.getElementById('div1').style.display = "none";
    //document.getElementById('div2').style.display = "block";
    //document.getElementById('div3').style.display = "none";
    //document.getElementById('div4').style.display = "none";
}

function show3() {
    document.getElementById('service-tab-3').style = "background-color: #1d7a8c;color:white";
    document.getElementById('your-detail-img').src = "../images/details-white.png";
    document.getElementById('detail-p-text').style = "color:white";
    document.getElementById('service-tab-4').style = "background-color: #f3f3f3;";
    document.getElementById('payment-img').src = "../images/payment.png";
    document.getElementById('payment-p-text').style = "color:#4f4f4f";

    $('#div1').hide();
    $('#div2').hide();
    $('#div3').show();
    $('#div4').hide();
    //document.getElementById("service-tab-1").disabled = true;
    //document.getElementById("service-tab-2").disabled = true;
    //document.getElementById("service-tab-3").disabled = false;
    //document.getElementById("service-tab-4").disabled = true;
    //document.getElementById('div1').style.display = "none";
    //document.getElementById('div2').style.display = "none";
    //document.getElementById('div3').style.display = "flex";
    //document.getElementById('div4').style.display = "none";
    $("#address_div").load('/Service/Details');
}

function show4() {
    document.getElementById('service-tab-4').style = "background-color: #1d7a8c;color:white";
    document.getElementById('payment-img').src = "../images/payment-white.png";
    document.getElementById('payment-p-text').style = "color:white";

    $('#div1').hide();
    $('#div2').hide();
    $('#div3').hide();
    $('#div4').show();
    //document.getElementById("service-tab-1").disabled = true;
    //document.getElementById("service-tab-2").disabled = true;
    //document.getElementById("service-tab-3").disabled = true;
    //document.getElementById("service-tab-4").disabled = false;
    //document.getElementById('div1').style.display = "none";
    //document.getElementById('div2').style.display = "none";
    //document.getElementById('div3').style.display = "none";
    //document.getElementById('div4').style.display = "flex";
}

function completedSchedule() {
    alert("Schedule and Plan Submitted Successfully Please move to next tab to further booking");
}

function displayAddForm() {
    document.getElementById('addAdd').style.display = "none";
    document.getElementById('AddForm').style.display = "block";
}

function cancelAdd() {
    document.getElementById('addAdd').style.display = "block";
    document.getElementById('AddForm').style.display = "none";
}

function S_Date() {
    var x = document.getElementById("datepicker").value;
    document.getElementById("date").innerHTML = x;
    document.getElementById("date1").innerHTML = x;
}
function Time() {
    var x = document.getElementById("scheduled_time").value;
    document.getElementById("time").innerHTML = x;
    document.getElementById("time1").innerHTML = x;
}

function Hours() {
    h1 = hrs.value;
    document.getElementById("basic_hours").innerHTML = h1 + " Hrs";
    document.getElementById("basic_hours1").innerHTML = h1 + " Hrs";
    document.getElementById("total_time").innerHTML = h1 + " Hrs";
    document.getElementById("total_time1").innerHTML = h1 + " Hrs";
   
    price = h1 * 20;
    document.getElementById("total").innerHTML = (price) + "₹";
}

var countInput = document.getElementById('count');
var checkboxes = document.querySelectorAll('input[type="checkbox"][id^="mycheckbox"]');
for (var i = 0; i < checkboxes.length; i++) {
    checkboxes[i].onchange = countCheckboxes;
}

function countCheckboxes() {
    var count = 0;
    for (var i = 0; i < checkboxes.length; i++) {
        if (checkboxes[i].checked)
            count++;
    }
    countInput.value = count;

    h1 = hrs.value;
    var extra_hrs = parseInt(h1) + (parseInt(countInput.value)*0.5);
    document.getElementById("total_time").innerHTML = extra_hrs + " Hrs";

    var p = countInput.value * 10;
    document.getElementById("sub_total").innerHTML = (p) + "₹";
    document.getElementById("sub_total1").innerHTML = (p) + "₹";

    total_pay = (h1*20) + p;
    document.getElementById("total").innerHTML = total_pay + "₹";
    document.getElementById("total1").innerHTML = total_pay + "₹";
}
countCheckboxes();

function myFunction() {
    //if (document.getElementById('postalcode').value != null) {
        document.getElementById('address').innerHTML = '<label class="row address"> <span class="col-lg-1"> <input type="radio" name="radio" checked> </span> <span class="col-lg-11"> <span class="row"> <b>Address</b>: ' + street.value + '  ' + house_no.value + '  ' + postalcode.value + '  ' + city.value + '</span> <span class="row"> <b>Phone number</b>:' + MobileNo.value + '</span> </span> </label>'

    //}
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


function myDetails() {

    $('#mydetails').show();
    $('#myaddress').hide();
    $('#mypassword').hide();
    document.getElementById("my-details-p").style = "color:#1d7a8c;font-weight:bold";
    document.getElementById("my-password-p").style = "color:#646464;font-weight:normal";
    document.getElementById("my-address-p").style = "color:#646464;font-weight:normal";
    
    //document.getElementById("myaddress").style = "display:none";
    //document.getElementById("mypassword").style = "display:none";
    //document.getElementById("mydetails").style = "display:block";
}

function myAddress() {

    $('#mypassword').hide();
    $('#mydetails').hide();
    $('#myaddress').show();
    $("#loadAdd").load('/Customer/User_Address');
    $("#loadAddPopup").load('/Customer/AddressPopup');
    document.getElementById("my-address-p").style = "color:#1d7a8c;font-weight:bold";
    document.getElementById("my-password-p").style = "color:#646464;font-weight:normal";
    document.getElementById("my-details-p").style = "color:#646464;font-weight:normal";
}

function myPassword() {
    $('#mypassword').show();
    $('#myaddress').hide();
    $('#mydetails').hide();
    $("#loadpasswd").load('/Customer/User_pswd');
    document.getElementById("my-password-p").style = "color:#1d7a8c;font-weight:bold";
    document.getElementById("my-address-p").style = "color:#646464;font-weight:normal";
    document.getElementById("my-details-p").style = "color:#646464;font-weight:normal";
}

function spDetails() {
    $('#spdetails').show();
    $('#sppassword').hide();
    $('#spaddress').hide();
    document.getElementById("sp-details-p").style = "color:#1d7a8c;font-weight:bold";
    document.getElementById("sp-password-p").style = "color:#646464;font-weight:normal";
    document.getElementById("sp-address-p").style = "color:#646464;font-weight:normal";

    //document.getElementById("myaddress").style = "display:none";
    //document.getElementById("mypassword").style = "display:none";
    //document.getElementById("mydetails").style = "display:block";
}

function spPassword() {
    $('#sppassword').show();
    $('#spdetails').hide();
    $('#spaddress').hide();
    //$("#loadpasswd").load('/Customer/User_pswd');
    document.getElementById("sp-password-p").style = "color:#1d7a8c;font-weight:bold";
    document.getElementById("sp-details-p").style = "color:#646464;font-weight:normal";
    document.getElementById("sp-address-p").style = "color:#646464;font-weight:normal";
}

function spAddress() {
    $('#spaddress').show();
    $('#spdetails').hide();
    $('#sppassword').hide();
    //$("#loadpasswd").load('/Customer/User_pswd');
    document.getElementById("sp-address-p").style = "color:#1d7a8c;font-weight:bold";
    document.getElementById("sp-details-p").style = "color:#646464;font-weight:normal";
    document.getElementById("sp-password-p").style = "color:#646464;font-weight:normal";
}
//$("#loadDashboard").load('/Customer/DashboardTable');

function changeToCar() {
    document.getElementById("spAvatar").src = "../images/avatar-car.png";
}
function changeToShip() {
    document.getElementById("spAvatar").src = "../images/avatar-ship.png";
}
function changeToMale() {
    document.getElementById("spAvatar").src = "../images/avatar-male.png";
}
function changeToFemale() {
    document.getElementById("spAvatar").src = "../images/avatar-female.png";
}
function changeToIron() {
    document.getElementById("spAvatar").src = "../images/avatar-iron.png";
}
function changeToHat() {
    document.getElementById("spAvatar").src = "../images/avatar-hat.png";
}