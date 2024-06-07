/**
 * Created by CreaPeak on 22.02.2017.
 */

$body       = $("body");
$loader_div = $('.loader-div');
/* loading div fonksiyonu */

$(window).load(function() {
    $loader_div.removeClass("loading");
});

$(document).ready(function () {

    $(document).on('change','.form-control',function () {
        var thisParent = $(this).parents('.form-group');
        if(thisParent.hasClass('fill-it')){
            thisParent.removeClass('fill-it');
        }
    });

    $('a[href="#"]').attr('href', 'javascript:;');

    $(".dropdown").hover(
        function() {
            $('.dropdown-menu', this).not('.in .dropdown-menu').stop(true,true).fadeIn(300);
            $(this).toggleClass('open');
        },
        function() {
            $('.dropdown-menu', this).not('.in .dropdown-menu').stop(true,true).fadeOut(300);
            $(this).toggleClass('open');
        }
    );

    // Tooltip
    $('[data-toggle="tooltip"]').tooltip();

    var mainSlider  = $('.main-slider');
    if(mainSlider.length > 0){
        mainSlider.slick({
            dots: true,
            infinite: true,
            speed: 300,
            slidesToShow: 1
        });
    }else{ /* slider yok */ }

    var capaignSlider  = $('.campaign-slider');
    if(capaignSlider.length > 0){
        capaignSlider.slick({
            dots: true,
            infinite: true,
            speed: 300,
            slidesToShow: 1
        });
    }else{ /* slider yok */ }


    var gallerySlider  = $('.gallery-slider');
    if(gallerySlider.length > 0){
        gallerySlider.slick({
            dots: true,
            speed: 300,
            slidesToShow: 4,
            slidesToScroll: 4,
            responsive: [
                {
                    breakpoint: 1024,
                    settings: {
                        slidesToShow: 3,
                        slidesToScroll: 3,
                        dots: true
                    }
                },
                {
                    breakpoint: 600,
                    settings: {
                        slidesToShow: 2,
                        slidesToScroll: 2
                    }
                },
                {
                    breakpoint: 480,
                    settings: {
                        slidesToShow: 1,
                        slidesToScroll: 1
                    }
                }
                // You can unslick at a given breakpoint now by adding:
                // settings: "unslick"
                // instead of a settings object
            ]
        });
    }else{ /* slider yok */ }

    /* FancyBox init */
    $("a.fancy-it").fancybox({
        'transitionIn'	:	'none',
        'transitionOut'	:	'none',
        'speedIn'		:	600,
        'speedOut'		:	200
    });

    var cats_count      = $('.cats-slider .cats-slide-item').length;
    var slidesBPoints   = [5,3,2];
    var slidesCount     = [];
    for(var c = 0; c < slidesBPoints.length; c++){
        if(cats_count < slidesBPoints[c]){ slidesCount[c] = cats_count;}
        else{ slidesCount[c] = slidesBPoints[c] }
    }
    var catsSlider      = $('.cats-slider');
    if(catsSlider.length > 0){
        catsSlider.slick({
            dots: false,
            arrows: true,
            speed: 300,
            infinite: false,
            slidesToShow: slidesCount[0],
            slidesToScroll: slidesCount[0],
            responsive: [
                {
                    breakpoint: 1024,
                    settings: {
                        slidesToShow: slidesCount[1],
                        slidesToScroll: slidesCount[1]
                    }
                },
                {
                    breakpoint: 600,
                    settings: {
                        slidesToShow: slidesCount[2],
                        slidesToScroll: slidesCount[2]
                    }
                },
                {
                    breakpoint: 480,
                    settings: {
                        slidesToShow: 1,
                        slidesToScroll: 1
                    }
                }
                // You can unslick at a given breakpoint now by adding:
                // settings: "unslick"
                // instead of a settings object
            ]
        });
    }else{ /* slider yok */ }


    /* Aktif Kategori focus */
    var urlPath1    = window.location.href;
    var urlPath     = '/'+urlPath1.replace(adres,'');
    var menuItem    = $('.cats-slider .cats-slide-item');

    if (urlPath) {
        var arr = urlPath.split('/'); // parçala -> /menu/menuId
        menuItem.each(function () {
            var dKey = $(this).data('key'); // Aktif menuID
            var currentItem = $(this); // Aktif item
            if (dKey == arr[3]) {
                var thisIndis = $('.cats-slider .cats-slide-item[data-key="'+dKey+'"]').index(); // Aktif slide
                $('.cats-slider').slick('slickGoTo', thisIndis, true);
                currentItem.addClass('active');
            }
        });
    }


    $(document).on('click', '.select-location-btn', function (e) {
        e.preventDefault();
        var thisVal = $('.select-location').val();
        if(typeof thisVal !== "undefined" && !isNaN(thisVal) && thisVal != '' && thisVal > 0){
            $.post(adres + 'restPost',{set_selected_restaurant:1,rest_code:thisVal},function(data){
                var data = $.parseJSON(data);
                if(data.status_code == 100){
                    window.location.href = adres;
                } else {
                    return false;
                }
            });
        } else{
            return false;
        }
    });

    $(document).on('click', '.select-menu-btn', function (e) {
        e.preventDefault();
        var thisVal = $('.select-menu').val();
        if(thisVal !== ""){
            window.location.href = adres+'category/'+thisVal;
        } else{
            return false;
        }
    });

    $(document).on('change', '.lang-select select', function () {
        var thisItem = $(this);
        var lang_id = thisItem.val();
        if(lang_id != '' && lang_id > 0){
            $.post(adres + 'restPost',{change_lang: 1,id: lang_id},function(data){
                var data = $.parseJSON(data);
                if(data.status_code == 100){
                    window.location.reload();
                } else {
                    return false;
                }
            });
        } else{
            return false;
        }
    });

    $(document).on('click','.link-set',function (e) {
        e.preventDefault(); e.stopPropagation();
        var thisBtn = $(this);
        var prd_sef = thisBtn.attr('data-product');
        var menu_sef = thisBtn.attr('data-menu');
        if(prd_sef != "" && menu_sef != ""){
            $.post(adres + 'restPost',{load_dish_modal: 1, product_sef: prd_sef, menu_sef: menu_sef},function(data){
                if(data){
                    $('#dish-modal-container').html(data);
                    $('#dish-modal-container #newOrderModal').modal('toggle');
                }
            });
        }
    });

    if($('.new-cats-list').length > 0){
        /* desktop version */
        var activeSef   = $('.new-cats-list ul').attr('data-active'),
            ulItems     = $('.new-cats-list ul li');

        ulItems.each(function () {
            var thisItem = $(this);
            if(thisItem.attr('data-key') === activeSef){
                ulItems.removeClass('active');
                thisItem.addClass('active');
            }
        });

        scrollToElementD();

        /* mobile version */
        $('.new-cats-list .option-side .form-control').val(activeSef);

        $(document).on('change','.new-cats-list .option-side .form-control', function () {
            var thisValue   = $(this).val(),
                thisHref    = $(this).find('option[value='+thisValue+']').attr('data-href');
            window.location.href = thisHref;
        });
    }



    /* end ready */
});


function scrollToElementD(){
    var topPos      = $('.new-cats-list ul li.active').index();
    var liHeight    = $('.new-cats-list ul li').height() - 1;
    $('.new-cats-list ul').scrollTop(topPos*liHeight);
}

function PostForm(id) {
    $('#' + id).submit(function (e) {
        e.preventDefault();
    });
    var form = $("#" + id);
    form.find('button[type=submit]').attr('disabled','disabled');
    form.find('input[type=submit]').attr('disabled','disabled');
    var hata = 0;
    var email_hata = 0;
    $("#" + id + " .required").each(function () {
        if($(this).val() == ''){
            $(this).parents('.form-group').addClass('fill-it');
            hata++;
        }
    });
    if (hata > 0) {
        swal({
            type: "error",
            title: swg_msg_array.danger_btn,
            text: swg_msg_array.fill_required_title,
            showCancelButton: true,
            showConfirmButton: false,
            cancelButtonText: swg_msg_array.close_btn,
            closeOnCancel: true,
            allowOutsideClick: true

        });
        form.find('button[type=submit]').removeAttr('disabled');
        form.find('input[type=submit]').removeAttr('disabled');
        return false;
    }
    if(hata == 0 && email_hata > 0){
        swal({
            type: "error",
            title: swg_msg_array.danger_btn,
            text: swg_msg_array.email_msg_title,
            showCancelButton: true,
            showConfirmButton: false,
            cancelButtonText: swg_msg_array.close_btn,
            closeOnCancel: true,
            allowOutsideClick: true

        });
        form.find('button[type=submit]').removeAttr('disabled');
        form.find('input[type=submit]').removeAttr('disabled');
        return false;
    }

    var x = $('#' + id).serialize();
    $.post(adres + 'restPost', x, function (data, a, b) {
        var a = data.split('@@');
        var durum = a[0];
        var mesaj = a[1];
        if (durum == 'success') {
            swal({
                type: "success",
                title: swg_msg_array.success_btn,
                text: mesaj,
                showCancelButton: true,
                showConfirmButton: false,
                cancelButtonText: swg_msg_array.close_btn,
                closeOnCancel: true,
                allowOutsideClick: true

            }, setTimeout(function () {
                window.location.reload();
            }, 1000));

        } else {
            swal({
                type: "error",
                title: swg_msg_array.danger_btn,
                text: mesaj,
                showCancelButton: true,
                showConfirmButton: false,
                cancelButtonText: swg_msg_array.close_btn,
                closeOnCancel: true,
                allowOutsideClick: true
            });
            form.find('button[type=submit]').removeAttr('disabled');
            form.find('input[type=submit]').removeAttr('disabled');
            return false;
        }
    });
}

/* Mouse Click events */
function mouseClickEvents(event,el) {
    // 1 - left button
    // 2 - middle button (scroll button)
    // 3 - right button
    var thisBtn = $(el);
    var thisDataProduct = $(el).parents(".product-el-inner").find(".url4seo");
    if(event.which === 2 || (event.which === 1 && event.ctrlKey)){
        // not left button click
        event.preventDefault(); event.stopPropagation();
        window.open(thisDataProduct.attr("href"),'_blank');
    }else if(event.which === 1){
        var prd_sef = thisBtn.attr('data-product');
        var menu_sef = thisBtn.attr('data-menu');
        if(prd_sef != "" && menu_sef != ""){
            $.post(adres + 'restPost',{load_dish_modal: 1, product_sef: prd_sef, menu_sef: menu_sef},function(data){
                if(data){
                    $('#dish-modal-container').html(data);
                    $('#dish-modal-container #newOrderModal').modal('toggle');
                }
            });
        }
    }
}