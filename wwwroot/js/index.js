$(function () {
    var theForm = $("#theForm");

    theForm.hide();

    var buyButton = $("#buyButton");

    buyButton.on("click", function () {
        alert("MBuying Item");
    });


    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });



    var $loginToggle = $(".loginToggle");
    var $popupForm = $(".popup-form")

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(300);
    });



});