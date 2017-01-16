$(document).ready(function () {
    $("#saveresutlForm").validate({
        rules: {
            RegistrationNo: {
                required: true,
                maxlength: 6,
                minlength:6

},

            SubjectId: "required",
            Score: {
                required: true,
                number: true,
                range: [0, 100]
            }

        },
        messages: {
            RegistrationNo: {
                required: "Please enter  Registration no",
                maxlength: "Registration no must be exact 6 character long",
                minlength: "Registration no must be exact 6 character long"
            } ,
            SubjectId: "Please select a subject",
            Score: {
                required: "Please Enter the score",
                number: "plseae Enter numeric figure only",
                range:"Score must be between 0 and 100"
}
        }
    });
});