﻿$(function () {
    var ajaxFormSubmit = function () {
        var $form = $(this);

        var options = {
            url : $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };

        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-otf-target"));
            $target.replaceWith(data);
        });

        return false;

    };

    var submitAutocompleteForm = function (event, ui) {
        var $input = $(this);





        var options = {
            source: $input.attr("data-otf-Autocomplete"),
            select: submitAutocompleteForm
        };
  

    };

    var createAutocomplete = function () {
        var $input = $(this);

        var options = {
            source: $input.attr("data-otf-Autocomplete"),
            select: submitAutocompleteForm
        };
        $input.autocomplete(options);

    };

        $("form[data-otf-ajax='true']").submit(ajaxFormSubmit);
        $("input[data-otf-Autocomplete]").each(createAutocomplete);
 });