//import * as jQuery from 'jquery';
//import { awef, awe, awem, utils } from './aweui/all.js';

var sideMenu = function ($) {
    var loop = awef.loop;
    var isSelected, getHeight, cancelSync;
    var menu;
    var grid;

    function build(opt) {
        var sctrl;
        var gapi;
        var cont;
        var lastClicked;

        var gid = opt.id;
        grid = $('#' + gid);

        isSelected = opt.isSelected || function (item) { return false; };

        getHeight = opt.getHeight || function () {
            return $(window).height() - 20;
        };

        cancelSync = opt.cancelSync || function () { };

        function init() {
            gapi = grid.data('api');
            cont = grid.find('.awe-content');
            lastClicked = -1;

            sctrl = initMenuSeach();

            setHeight();

            grid.one('awerender', function () {
                scrollToSel();
            });

            var skey = gid + 'menust';
            var st = sessionStorage && sessionStorage.getItem(skey);
            if (st) {
                cont.scrollTop(st);
            }

            cont.on('scroll', function (e) {
                sessionStorage && sessionStorage.setItem(skey, cont.scrollTop());
            });
        }

        function initMenuSeach() {
            var txt = $('#' + opt.src);

            function onenter(e, item) {
                e.preventDefault();
                
                if (item.length) {                    
                    item[0].click();
                }

                txt.data('noaf', 1);
                txt.focus();
            }

            function topFunc() {
                $(window).scrollTop($(window).scrollTop() - 10);
            }

            function botFunc() {
                if ((cont.offset().top + cont.height() + 50) > ($(window).scrollTop() + $(window).height())) {
                    $(window).scrollTop($(window).scrollTop() + 10);
                }
            }

            sctrl = awem.slist(cont, { sel: '.awe-row', enter: onenter, fcls: 'awe-selected', sc: 'n', topf: topFunc, botf: botFunc });

            grid.on('click', 'a', function (e) {
                lastClicked = $(e.target).data('k');
            });

            var keyHandled;
            
            var go = grid.data('o');
            
            // using awe.bind instead of .on so that if grid is destroyed the events will unbind
            awe.bind(go, txt, 'keydown', function (e) {
                if (sctrl.keyh(e)) {
                    keyHandled = 1;
                }
            });

            awe.bind(go, txt, 'keyup', function () {
                if (!keyHandled) {
                    opt.keyupf && opt.keyupf();
                    gapi.load();
                    sctrl.autofocus();
                }

                keyHandled = 0;
            });

            awe.bind(go, txt, 'focusin', function () {
                // can't send event data, jquerybug
                if (!txt.data('noaf')) {
                    sctrl.autofocus();
                }

                txt.data('noaf', 0);
            });

            awe.bind(go, txt, 'blur', function () {
                if (txt.data('brf')) {
                    sctrl.remf();
                }
            });

            return sctrl;
        }

        function scrollToSel() {
            var menuc = cont;
            var sel = menuc.find('.selected');
            if (sel.length) {
                sctrl.scrollTo(menuc.find('.selected'));
            } else {
                sctrl.scrollTo(menuc.find('.awe-row'));
            }
        }

        function setHeight() {
            if (!grid.length) return;
            if ($(window).width() <= 767) {
                awem.setgh(grid, 0);
                return;
            }

            var gridh = getHeight();
            awem.setgh(grid, gridh);
        }

        menu = {
            setHeight: setHeight,
            getLastClicked: function () {
                return lastClicked;
            },
            selectById: function (id) {
                var sel = gapi.select(id);
                if (sel.length) {
                    sel = sel[0];
                    sctrl.focus(sel);

                    sctrl.scrollToFocused();
                }

                // show parent when scroll to the first page item
                if (id === 'p0') {
                    var prev = $(sel).prev();
                    if (prev.length)
                        sctrl.scrollTo(prev);
                }
            }
        };

        if (opt.scrollSync) {
            $(window)
                .on('scroll resize',
                    function (e) {
                        if ($(':focus').is('input') || $(window).width() < 1000) return;

                        if (cancelSync()) return;

                        var top = $(document).scrollTop() + 20;

                        $('h2').each(function (i) {
                            var ht = $(this).offset().top;
                            if (ht > top) {
                                var res = i;
                                if (i > 0 && ht > top + $(window).height() * .7) {
                                    res--;
                                }

                                var lix = menu.getLastClicked();
                                if (lix > 0) {
                                    // if last clicked h2 is about the same height
                                    var lh2 = $('h2').eq(lix).offset().top;

                                    if (lh2 > ht - 3 && lh2 < ht + 3) {
                                        res = lix;
                                    }
                                }

                                menu.selectById('p' + res);
                                return false;
                            }
                        });
                    });

            grid.find('a').click(function () {
                var k = $(this).data('k');
                awe.flash($('h2').eq(k));
            });
        }
        
        init();
        
        // in case of awem.rebuildAll
        grid.on('aweinit', init);

        return menu;
    }

    var lnodes = null;
    function getMenuGridFunc(nodesOrXhr, grido) {

        function addParentsTo(res, node, all) {
            if (node.ParentId) {
                var isFound;
                loop(res, function (o) {
                    if (o.Id === node.ParentId) {
                        isFound = true;
                        return false;
                    }
                });

                if (!isFound) {
                    var parent = $.grep(all, function (o) { return o.Id === node.ParentId; })[0];
                    res.push(parent);
                    addParentsTo(res, parent, all);
                }
            }
        }

        function equals(a, b) {
            return new RegExp("^" + a + "$", "i").test(b);
        }

        function buildMenuGridModel(gp) {
            gp.paging = false;
            var search = (gp.search || '').trim();

            // find selected
            var selectedItems = $.grep(lnodes, function (o) {
                o.Selected = '';
                return isSelected(o);
            });

            if (selectedItems.length > 1) {
                var anch = window.location.hash.substr(0);

                var anchsli = $.grep(selectedItems, function (o) {
                    return equals(anch, o.Anchor);
                });

                if (anchsli.length) {
                    selectedItems = anchsli.slice(0);
                }
            }

            if (selectedItems.length) {
                selectedItems[0].Selected = "selected";
                loop(selectedItems, function (item) {
                    addParentsTo(selectedItems, item, lnodes);
                });
            }

            loop(selectedItems, function (o) {
                o.IsNodeSelected = true;
            });

            var words = search.split(" ");

            var regs = $.map(words, function (w) {
                return new RegExp(w, "i");
            });

            var regsl = regs.length;

            var result = $.grep(lnodes, function (node) {
                var matches = 0;
                var s = node.Keywords + ' ' + node.Name;

                loop(regs, function (reg) {
                    reg.test(s) && matches++;
                });

                return regsl === matches && (!node.NoMenu || search);
            });

            var searchResult = result.slice(0);

            loop(searchResult, function (o) {
                addParentsTo(result, o, lnodes);
            });

            var rootNodes = $.grep(result, function (o) { return !o.ParentId; });

            var getChildren = function (node, nodeLevel) {
                return $.grep(result, function (o) { return o.ParentId === node.Id; });
            };

            function makeHeader(info) {
                var isNodeSelected = info.NodeItem.IsNodeSelected;
                var collapsed = !search && !isNodeSelected && info.NodeItem.Collapsed;
                return {
                    Item: info.NodeItem,
                    Collapsed: collapsed,
                    IgnorePersistence: search || isNodeSelected
                };
            }

            return utils.gridModelBuilder({
                key: "Id",
                gp: gp,
                items: rootNodes,
                getChildren: getChildren,
                defaultKeySort: utils.Sort.None,
                makeHeader: makeHeader
            });
        }

        return function (sgp) {
            var gp = utils.getGridParams(sgp);

            if (lnodes) {

                return buildMenuGridModel(gp);
            }

            return $.when(nodesOrXhr).then(function (res) {
                lnodes = res;
                if (lnodes) {
                    return buildMenuGridModel(gp);
                }
            });
        };
    }

    function menutree(o) {
        o.alt = 0; // no alt row css
        var api = o.api;
        // render row
        api.itmf = function (opt) {
            var content = '';
            var itm = opt.itm;
            if (opt.ceb) content += api.ceb();
            content += itm.Name;

            if (opt.ceb) {
                opt.clss += ' mnitm awe-ceb';
            } else {
                opt.clss += ' mnitm ';
            }

            if (itm.Page) opt.clss += ' pmnitem';

            var attr = opt.attr;
            attr += ' class="' + opt.clss + '"';
            var style = opt.style || '';

            if (opt.ind) {
                style += 'padding-left:' + opt.ind / 2 + 'em;';
            }

            style && (attr += ' style="' + style + '"');

            return itm.Url ?
                '<a href="' + itm.Url + '" ' + attr + ' >' + content + '</a>' :
                '<div ' + attr + '>' + content + '</div>';
        };
    }

    return {
        build: build,
        getMenuGridFunc: getMenuGridFunc,
        menutree: menutree
    };
}(jQuery);

//export { sideMenu };