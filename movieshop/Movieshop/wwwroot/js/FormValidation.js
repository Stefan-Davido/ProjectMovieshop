
$(function () {
    $("form[name='moviecreate']").validate({
        success: "valid",
        onkeyup: true,
        focusInvalid: true,
        errorClass: "error",
        highlight: function (element, errorClass) {
            $(element).fadeOut(function () {
                $(element).fadeIn();
                $(element).addClass(errorClass);
            });
        },
        rules: {
            Title: {
                required: true,
                minlength: 2,
            },
            Realised: "required",
            TimeLast: {
                required: true,
                number: true,
                digits: true,
                min: 10
            },
            GenreId: {
                required: true,
                min: 1
            },
            ProducerId: {
                required: true,
                min: 1
            },
            ProductionId: {
                required: true,
                min: 1
            },
            CategoryId: {
                required: true,
                min: 1
            },
            ActersId: {
                required: true,
                min: 1
            },
            Price: {
                required: true,
                number: true,
                digits: true
            },
            Awards: {
                required: true,
                number: true,
                digits: true
            },
            YearsToWatch: {
                required: true,
                number: true,
                min: 1
            },
            Language: "required",
            Country: "required",
            Description: "required",
            Rating: "required"
        },
        messages: {
            Title: {
                required: "Please Enter Title!",
                //minlength: jquery.validator.format("At least {0} charachters required")
            },
            Realised: "Please enter Date of Realised!",
            TimeLast: {
                required: "Please enter the Length of movie!",
                number: "Please enter only numbers!",
                digits: "Only digits is allowed!",
                //min: jquery.validator.format("At least {0} number required")
            },
            GenreId: {
                required: "Please enter the Genre of the movie!",
                min: "PLease select one publisher from the dropdown!"
            },
            ProducerId: {
                required: "Please enter the Producer of the movie!",
                min: "PLease select one Producer from the dropdown!"
            },
            ProductionId: {
                required: "Please enter the Production of the movie!",
                min: "PLease select one Production from the dropdown!"
            },
            CategoryId: {
                required: "Please enter the Category of the movie!",
                min: "PLease select one Category from the dropdown!"
            },
            ActersId: {
                required: "Please enter the Actor!",
                min: "PLease select one Actor from the dropdown!"
            },
            Price: {
                required: "Please enter the Price of the movie!",
                number: "Please enter only numbers!",
                digits: "Only digits are allowed"
            },
            Awards: {
                required: "Please enter the Award/s of the movie!",
                number: "Please enter only numbers!",
                digits: "Only digits are allowed"
            },
            YearsToWatch: {
                required: "Please enter the allowed years to wacth this movie!",
                number: "Please enter only numbers",
                //min: jquery.validator.format("At least {0} number required")
            },
            Language: "Please enter the language of the movie!",
            Country: "Please enter the Country!",
            Description: "Please enter the Description!",
            Rating: "Please enter the Rating of the movie!"
        },
        submitHandler: function (form) {
            form.submit();
        }
    });
});