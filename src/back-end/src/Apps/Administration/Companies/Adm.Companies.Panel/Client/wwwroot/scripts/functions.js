var updateHtml = function (val, type, id) {
    $("[" + type + "=" + id + "]").html(val);
    //return "test";
    //return JSON.stringify($(".child-form-fragment").find("input").attr("class"));
}