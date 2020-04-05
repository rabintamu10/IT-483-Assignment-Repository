$(document).ready(function () {
	var emailPattern = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b/;
    var valid = true;
	$("#submit").click(function (event) {
        var Tex = $("input:text");
        Tex.each(function () {
            if (this.value.trim() == "") {
                $(this).next().text("This field is required.");
                valid = false;
            }
            
            else if (this.id == "nights") {
                 if (isNaN(this.value.trim())) {
                    $(this).next().text("This field must be numeric.");
                    valid = false;
                 }
                else{
                    $(this).next().text("");

                }
            }
            
            else if (this.id == 'email') {
                if (!emailPattern.test(this.value.trim())) {
                    $(this).next().text("Must be a valid email address");
                    valid = false;
                }
                else{
                    $(this).next().text("");

                }
            }
            else{
                $(this).next().text("");

            }
        })
        
        if ($("span").text() == ""){
            valid = true;
            }

        if (valid == false){
            event.preventDefault();
        }
        $("#arrival_date").focus();
    })
});
