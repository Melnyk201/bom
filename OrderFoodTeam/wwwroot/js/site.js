$('.first').click(function () {
    function storeColor(aBtn) {
        var originalColor = $(aBtn).data("originalcolor");
        if (!originalColor) {
            originalColor = window.getComputedStyle(aBtn).backgroundColor;
            $(aBtn).data("originalcolor", originalColor);
        }
        return originalColor;
    }
    function resetColor(aBtn) {
        var originalColor = storeColor(aBtn);
        $(aBtn).css('background-color', originalColor);
    }
    function setColor(aBtn) {
        storeColor(aBtn);
        var newColor = $(aBtn).data("backcolor");
        $(aBtn).css('background-color', newColor);
    }

    $(".first a").each(function () {
        resetColor(this);
    });
    setColor($(this).find("a")[0]);
});