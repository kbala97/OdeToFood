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
            var $newhtml = $(data);
            $target.replaceWith($newhtml);
            $newhtml.effect("highlight");
        });

        return false;

    };

    var getPage = function () {
        var $a = $(this);
        var options = {
            url: $a.attr("href"),
            data: $("form").serialize(),
            type: "get"
        };

        $.ajax(options).done(function (data) {
            //var $target = $a.parents("div.pagedList").attr("data-otf-target");
            //var $target = $($a.parents("div.pagedlist").attr("data-otf-target"));
            var $target = $("#restaurantList");

            $target.replaceWith(data);

        });

        return false;

    };

    var submitAutocompleteForm = function (event, ui) {
        var $input = $(this);
        $input.val(ui.item.label);
        var $form = $input.parents("form:first")
        $form.submit();
  
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
    $(".main-content").on("click", ".pagedList a", getPage);
 });