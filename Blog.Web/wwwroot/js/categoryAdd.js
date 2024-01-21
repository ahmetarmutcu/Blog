$(document).ready(function () {
    $("#btnSave").click(function (event) {
        event.preventDefault();
        var addUrl = app.Urls.categoryAddUrl;
        var redirectUrl = app.Urls.articleAddUrl;

        var categoryAddDto = {
            Name: $("input[id=categoryName]").val()
        }
        var jsonData = JSON.stringify(categoryAddDto);

        $.ajax({
            url: addUrl,
            type: "POST",
            contentType: "application/json; charset=utf-8",
            datatype:"json",
            data: jsonData,
            success: function (data) {
                setTimeout(function () {
                    window.location.href = redirectUrl;
                },1500);
            },
            error: function () {
                toastr.error("Bir hata oluştu", "Hata");
            }
        });
    });
});