window.addEventListener('DOMContentLoaded', event => {
    $(".editButton").click(function () {
        var Id = $(this).data("id");
        var data = {
            id: Id
        }
        function getData() {
            return $.ajax({
                url: '/Index1?handler=GetResult',
                type: "POST",
                data: JSON.stringify(data),
                dataType: 'json',
                contentType: "application/json",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader("XSRF-TOKEN",
                        $('input:hidden[name="__RequestVerificationToken"]').val());
                },
               
            });
        }
        getData().done(function (response) {
            var data = response;
            console.log(response.prId);
            $('#TransactionId').text(response.prTransaction);
            $('#MSSIDN').text(response.prMsisdn);
            $('#CreditCard').text(response.creditcard);
            $('#Status').text(response.prStatus);
            $('#CS').text(response.prCsStatus);
            $('#SV').text(response.prSvStatus);
            $('#UsdAmount').text(response.usdAmount);
            $('#LbpAmount').text(response.lbpAmount);
            $('#Datetime').text(response.prDate);

        }).fail(function () {
            console.log('error');
        });

       


    });
    

});