$(document).ready(function () {
    $("#contact-form").validate({
        errorPlacement: function (label, element) {
            label.addClass('error');
            label.insertAfter(element);
        },
        wrapper: 'span',
        rules: {
            name: {
                required: true,
                minlength: 2,
                maxlength: 20
            },
            email: {
                required: true,
                email: true
            },
            subject: {
                required: false,
                maxlength: 100
            },
            message: {
                required: true,
                maxlength: 1000
            }
        },
        messages: {
            name: {
                required: "This field is required.",
                minlength: "Name must be at least 2 letter.",
                maxlength: "Name must be no more than 20 letters."
            },
            email: {
                required: "This field is required.",
                email: "Please enter a valid email address."
            },
            subject: {
                maxlength: "Name must be no more than 100 letters."
            },
            message: {
                required: "This field is required.",
                maxlength: "Name must be no more than 500 letters."
            }
        }
    });
});

$('#contact-form-button').on('click', function () {
    $("#contact-form").valid();
});