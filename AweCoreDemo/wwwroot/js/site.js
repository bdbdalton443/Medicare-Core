/* eslint-disable */
//import * as jQuery from 'jquery';
//import { sideMenu } from './sidemenu';
//import { awef, awe, aweui, utils } from './aweui/all.js';
//import { storg } from './storg.js';

var site = function ($) {
    var encode = awef.encode;
    var menu;
    function documentReady() {
        var root = document.root || './';

        storg.init(document.ver);
        setupSideMenu();
        setupFmwPicker();

        layPage();
        $(window).on('resize', layPage);

        handleAnchors();

        $('#btnLogo').click(function (e) {
            if ($(window).width() < 1050) {
                e.preventDefault();
                $('#btnMenuToggle').click();
            }
        });

        $('#btnMenuToggle').click(function () {
            menuToggle($('#demoMenu').is(':visible'));
        });

        site.parseCode && site.parseCode();

        handleTabs();

        $('#chTheme').change(function () {
            var theme = $('#chTheme').val();
            $('#aweStyle').attr('href', root + "/css/themes/" + theme + "/AwesomeMvc.css?v=" + document.ver);
            $('body').attr('class', theme);
            Cookies && Cookies.set('awedemset2', theme, { expires: 30 });
        });

        signalrSync.init();

        $(document).on('aweload', 'table.awe-ajaxlist', wrapLists);

        var lastw = 0;
        function layPage() {
            var ww = $(window).width();

            $("#main").css("min-height", ($(window).height() - 120) + "px");
            $('#maincont').css("min-height", $(window).height() - ($('#header').outerHeight() + 110));
            if (lastw !== ww) {
                menuToggle(ww < 1050);
            }

            lastw = ww;
            menu.setHeight();
        }
    }

    function setupFmwPicker() {
        var lastw = 1001;
        function setFmwPicker(ww) {
            awe.destroy($('#ddlFmw').data('o'));
            var cfg = {
                id: 'ddlFmw',
                dataFunc: function () {
                    return [
                        { c: 'aweui (Angular, React, Vue)', k: 'https://aweui.aspnetawesome.com' },
                        { c: 'ASP.net Core/MVC', k: 'https://demo.aspnetawesome.com' },
                        { c: 'ASP.net Web-Forms', k: 'https://demowf.aspnetawesome.com' }
                    ];
                }
            };

            if (ww > 1000) {
                cfg.buttongroup = true;
            } else {
                cfg.odropdown =
                {
                    inLabel: 'for: ',
                    openOnHover: true
                }
            }

            aweui.radioList(cfg);

            lastw = ww;
        }

        setFmwPicker($(window).width());
        $(window).on('resize', function () {
            var ww = $(window).width();

            if (lastw > 1000 && ww < 1000 || lastw < 1000 && ww > 1000) {
                setFmwPicker(ww);
            }
        });

        $('#ddlFmw').on('change', function () {
            window.location.href = $(this).val();
        });
    }

    function setupSideMenu() {
        var px;
        $(window).on('mousemove', function (e) {
            px = e.pageX;
        });

        menu = sideMenu.build({
            id: 'Menu',
            src: 'msearch',
            keyupf: srckup,
            isSelected: function (item) {
                return item.Action == document.action && item.Controller == document.controller;
            },
            getHeight: function () {
                return $(window).height() - $('#header').height() - 70;
            },
            scrollSync: true,
            cancelSync: function () {
                return px < $('#Menu').outerWidth() + 20;
            }
        });

        function srckup() {
        }
    }

    var tabid = 0;
    function handleTabs() {
        $('.tabs').each(function (i, item) {
            var tabs = $(item);
            if (!tabs.data('tabsh')) {
                tabs.data('tabsh', 1);

                var id = 'mytab' + tabid++;
                tabs.attr('id', id).addClass('awe-tabs');
                tabs.children().wrapAll('<div class="awe-tabscontent"/>').addClass('awe-tab');

                $('<div class="awe-tabsbar"></div>').prependTo(tabs);
                awe.tabs({ i: id });
            }
        });
    }

    function getAnchorName(a) {
        var name = a.data('name');
        if (!name) name = $.trim(a.html()).replace(/ /g, '-').replace(/\(|\)|:|\.|\;|\\|\/|\?|,/g, '');
        name = name.replace('&lt', '').replace('&gt', '');
        return name;
    }

    function handleAnchors() {
        var anchor = window.location.hash.replace('#', '').replace(/\(|\)|:|\.|\;|\\|\/|\?|,/g, '');
        $('h3,h2').each(function (_, e) {
            var a = $(e);
            if (!a.data('ah')) {
                a.data('ah', 1);
                var name = a.data('name');
                var url = a.data('u') || '';
                if (!name) name = $.trim(a.html()).replace(/ /g, '-').replace(/\(|\)|:|\.|\;|\\|\/|\?|,/g, '');
                name = name.replace('&lt', '').replace('&gt', '').replace('\'', '');
                a.append("<a class='anchor' name='" + name + "' href='" + url + "#" + name + "' tabIndex='-1'>&nbsp;<i class='ico-link'></i></a>");

                if (name === anchor) {
                    window.location.href = "#" + name;
                    awe.flash(a);
                }
            }
        });
    }

    // wrap ajaxlists for horizontal scrolling on small screens
    function wrapLists() {
        $('table.awe-ajaxlist:not([wrapped])').each(function () {
            var columns = $(this).find('thead th').length;
            var mw = $(this).data('mw');
            if (columns || mw) {
                mw = mw || columns * 120;

                $(this).wrap('<div style="width:100%; overflow:auto;"></div>')
                    .wrap('<div style="min-width:' + mw + 'px;padding-bottom:2px;"></div>')
                    .attr('wrapped', 'wrapped');
            }
        });
    }

    function menuToggle(hide) {
        var page = $('#demoPage').show();
        var menu = $('#demoMenu').css('width', '').css('position', '');

        if (hide) {
            menu.hide();
            page.css('margin-left', "0");
            $('#btnMenuToggle').show().removeClass('on');
            $('body').trigger('domlay');
        } else {
            menu.show();

            page.css('margin-left', "14.5em");

            if (page.width() < 200) {
                page.hide();
                menu.css('width', '100%');
                menu.css('position', 'static');
            }

            $('#btnMenuToggle').addClass('on');

            $('body').trigger('domlay');
        }
    }

    function slide(popup) {
        var o = popup.data('o');
        var maxtop = $(window).height();
        var div = popup.closest('.o-pmc');

        o.p.nolay = 1;

        div.css('transform', 'translateY(' + maxtop + 'px)');

        setTimeout(function () {
            div.css('transition', '.5s');
            div.css('transform', 'translateY(0)');
            setTimeout(function () {
                o.p.nolay = 0;
                div.css('transition', '');
                div.css('transform', '');
                o.cx.api.lay();
            }, 500);
        }, 30);
    }


    return {
        documentReady: documentReady,
        getAnchorName: getAnchorName,
        handleAnchors: handleAnchors,
        handleTabs: handleTabs,
        slide: slide,
        getFormattedTime: function () {
            var d = new Date();
            return ('0' + d.getHours()).slice(-2) + ":" + ('0' + d.getMinutes()).slice(-2) + ":" + ('0' + d.getSeconds()).slice(-2);
        },
        getThemes: function () {
            return $.map(["wui", "mui", "bts", "met", "gui", "gui3", "start", "black-cab"], function (v) { return { k: v, c: v } });
        },
        parseCode: function () {
            $('pre').addClass('prettyprint');

            // show code 
            $('.code').each(function (i, el) {
                var codediv = $(el);
                if (!codediv.data('h')) {
                    codediv.data('h', 1);

                    var scbtn = $('<span class="shcode">show code</span>')
                        .click(function () {
                            var btn = $(this);
                            btn.toggleClass("hideCode showCode");
                            var parent = $(this).parent();
                            var div = parent.next();

                            div.find('.srccode').each(function () {
                                var d = $(this);
                                if (d.data('handled')) return;
                                d.data('handled', 1);
                                var name = d.data('name');

                                var backbtn = $('<button class="awe-btn backbtn" type="button">go back</button>').click(setMain);

                                d.append(strUtil.wrapCode(''));

                                var main = d.find('pre');

                                function setMain() {
                                    var code = strUtil.getCode(name);
                                    main.html(code).removeClass('prettyprinted');
                                    site.prettyPrint();
                                    backbtn.hide();
                                }

                                d.find('.codeWrap').prepend(backbtn);
                                setMain();
                            });

                            if (div.closest('.cbl').length) {
                                aweui.initPopup({
                                    id: 'showCode',
                                    setCont: function (sp, o) {
                                        o.scon.html(div);
                                        div.show();
                                    },
                                    close: function () {
                                        parent.after(div.hide());
                                    },
                                    modal: true,
                                    width: 900,
                                    outClickClose: true
                                });

                                awe.open('showCode');
                            }
                            else if (btn.hasClass("hideCode")) {
                                btn.html("hide code");
                                div.fadeIn();
                            } else {
                                btn.html("show code");
                                div.fadeOut();
                            }
                        });

                    var wrp = $('<div/>').append(scbtn);
                    codediv.wrap('<div/>')
                        .parent()
                        .hide()
                        .before(wrp);
                }
            });
        },
        prettyPrint: function () {
            try {
                PR && PR.prettyPrint();
            } catch (ex) {
                //ignore
            }
        },
        getDownloads: function () {
            return [
                { k: "https://www.aspnetawesome.com/Download/MvcCoreDemoApp", c: "Main Demo - ASP.net Core (this demo)" },
                { k: "https://www.aspnetawesome.com/Download/MinSetupCoreDemo", c: "Min Setup Demo - ASP.net Core (Template Project)" },
                { k: "https://www.aspnetawesome.com/Download/RazorPagesDemo", c: "Razor Pages Demo" },
                { k: "https://www.aspnetawesome.com/Download/ProDinner", c: "ProDinner demo (EFCore, SQL Server DB, and more)" },
                { k: "https://www.aspnetawesome.com/Download/AweMySql", c: "ASP.net Core/aweui + MySql demo (EFCore)" },
                { k: "https://www.aspnetawesome.com/Download/MvcTrial", c: "Trial version binaries for ASP.net Core, MVC 5/4/3" },
                { k: "", c: "MVC5", cs: "citm", nv: 1 },
                { k: "https://www.aspnetawesome.com/Download/MvcDemoApp", c: "Main Demo - MVC 5 (this demo)" },
                { k: "https://www.aspnetawesome.com/Download/MvcMinSetupDemo", c: "Min Setup Demo - MVC 5 (Template Project)" },
                { k: "https://www.aspnetawesome.com/Download/SimpleDemo", c: "Simple Demo MVC5" },
                { k: "https://www.aspnetawesome.com/Download/VBnetDemo", c: "VB.net Demo" },
                { k: "", c: "", cs: "o-litm", nv: 1 },
                { k: "", c: "See other live demos:", cs: "citm", nv: 1 },
                { k: "https://prodinner.aspnetawesome.com", c: "ProDinner demo live" },
                { k: "https://angular.aspnetawesome.com", c: "Angular aweui demo" }
            ];
        },
        loadWhenSeen: function (el, url, indx, callback) {
            var started = 0;
            if (!loadIfVis()) {
                $(window).on('scroll resize', loadIfVis);
            }

            function loadIfVis() {
                if (el.offset().top + el.outerHeight() < $(window).height() + $(window).scrollTop() + 300) {
                    if (started) return 1;
                    started = 1;

                    $(window).off('scroll resize', loadIfVis);
                    $.get(url, { v: indx }, function (res) {
                        callback(res);
                    });

                    return 1;
                }
            }
        },
        getSideMenuData: function (url) {
            var storageKey = awe.ppk + "_menuNodes";
            if (sessionStorage && sessionStorage[storageKey]) {
                return JSON.parse(sessionStorage[storageKey]);
            } else {
                return $.get(url).then(function (items) {
                    sessionStorage[storageKey] = JSON.stringify(items);
                    return items;
                });
            }
        },
        getCaretWord: function (el) {
            // textarea autocomplete 
            function getWordAtPos(s, pos) {
                var preText = s.substring(0, pos);
                if (preText.indexOf(" ") > 0 || preText.indexOf("\n") > 0) {
                    var words = preText.split(" ");
                    words = words[words.length - 1].split("\n");
                    return words[words.length - 1]; // return last word
                }
                else {
                    return preText;
                }
            }

            function getCaretPos(ctrl) {
                var caretPos = 0;
                if (document.selection) {
                    ctrl.focus();
                    var sel = document.selection.createRange();
                    sel.moveStart('character', -ctrl.value.length);
                    caretPos = sel.text.length;
                }
                else if (ctrl.selectionStart || ctrl.selectionStart === '0') {
                    caretPos = ctrl.selectionStart;
                }

                return caretPos;
            }

            var pos = getCaretPos(el);
            return getWordAtPos(el.value, pos);
        },
        replaceInTexarea: function (t, text, word) {
            if (t.setSelectionRange) {
                var sS = t.selectionStart - word.length;
                var sE = t.selectionEnd;
                t.value = t.value.substring(0, sS) + text + t.value.substr(sE);
                t.setSelectionRange(sS + text.length, sS + text.length);
                t.focus();
            }
            else if (t.createTextRange) {
                document.selection.createRange().text = text;
            }
        },
        gitCaption: function (item) {
            return '<img class="cthumb" src="' + encode(item.avatar) + '&s=40" />' + encode(item.c);
        },
        gitItem: function (item) {
            var res = "<div class='content'>" + '<div class="title">' + encode(item.c) + '<img class="thumb" src="' + encode(item.avatar) + '&s=40" />' + '</div>';
            if (item.desc) res += '<p class="desc">' + encode(item.desc) + '</p>';
            res += '</div>';
            return res;
        },
        gitRepoSearch: function (o, info) {
            var term = info.term;
            var c = info.cache;
            c.termsUsed = c.termsUsed || {};
            c.nrterms = c.nrterms || []; // no result terms

            if (c.termsUsed[term]) return [];
            c.termsUsed[term] = 1;

            var nores = 0;
            // don't search terms that contain nrterms
            $.each(c.nrterms, function (i, val) {
                if (term.indexOf(val) >= 0) {
                    nores = 1;
                    return false;
                }
            });

            if (nores) {
                return [];
            }

            return $.get('https://api.github.com/search/repositories', { q: term })
                .then(function (data) {
                    if (!data || !data.items.length) {
                        c.nrterms.push(term);
                    }

                    return $.map(data.items, function (item) { return { k: item.id, c: item.full_name, avatar: item.owner.avatar_url, desc: item.description }; });
                })
                .fail(function () { c.termsUsed[term] = 0; });
        },
    };
}(jQuery);

//export {site};