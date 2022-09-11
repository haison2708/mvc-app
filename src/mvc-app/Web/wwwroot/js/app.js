function showCategories(e) {
    $(`#${e}`).siblings(`#ul-${e}`).slideToggle(400);
}

function submitProductId(id) {
    $(`#form-${id}`).submit();
}

function updateCart() {
    var form = $('#form-order');
    form.attr('action', 'ShoppingCart/UpdateCart');
    form.attr("method", "post");
    form.submit();
}

function showOrderDetails(id) {
    var content = $(`#order-${id}`).parent().parent().next()
    if (content.css('display') == 'none')
        content.css('display', '')
    else
        content.css('display', 'none') 
}

$("#pro-qty").on("change", function () {
    $("#qty-submit").val($("#pro-qty").val());
})