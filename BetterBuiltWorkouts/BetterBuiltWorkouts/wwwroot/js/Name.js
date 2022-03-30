jQuery.validator.addMethod("name", function (value, element, param) {
    if (value == '') return false;
    var nameToCheck = value;
    var maxLength = Number(param);

    if (nameToCheck.length < maxLength) {
        return true;
    }
    else {
        return false;
    }
});

jQuery.validator.unobtrusive.adapters.addSingleVal("name", "maxLength");