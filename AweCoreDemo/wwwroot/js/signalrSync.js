var signalrSync = function () {
    function regGridSync() {
        function init() {
            if ($('.awe-grid[data-syncg]').length) {
                initSync();
            }
        }

        $(document).ajaxComplete(init);
        init();
    }

    function initSync() {
    if (document.isync) return;
    document.isync = 1;
    var root = document.root;

    $.ajax(root + '/js/signalr.js',
        {
            dataType: "script",
            cache: true,
            success: function () {
                init();
            }
        });

    function init() {
        var connection = new signalR.HubConnectionBuilder().withUrl(root + "/syncHub").build();

        connection.start().then(function () {
            $(document)
                .on('itemdelete', function (e) {
                    send(e, 'del');
                })
                .on('aweinlinesave itemedit', '.awe-row', function (e) {
                    send(e, '');
                });
        }).catch(function (err) {
            return console.error(err.toString());
        });

        connection.on("ReceiveMessage", function (key, act, group) {
            updateGrids(key, act, group);
        });

        function updateGrids(key, act, group, senderg) {
            $('.awe-grid[data-syncg="' + group + '"]').each(function (i, el) {
                if (senderg && $(el).is(senderg)) return;
                updateRow($(el), key, act);
            });
        }

        function send(e, act) {
            var key = $(e.target).data('k').toString();
            var grid = $(e.target).closest('.awe-grid');
            var group = grid.data('syncg');
            updateGrids(key, act, group, grid);            
            trysend(function () {
                connection.invoke("Send", key, act, group);
            });
        }

        function trysend(action, attempts) {
            attempts = attempts || 0;
            try {
                action();
            } catch (err) {
                if (attempts < 1) {
                    $.connection.start();
                    setTimeout(function () {
                        trysend(action, attempts + 1);
                    }, 300);
                }
            }
        }

        function updateRow(g, key, act) {
            var gid = g.attr('id');
            var row = g.find('.awe-row[data-k="' + key + '"]');
            if (row.length && !row.hasClass('o-glrow')) {
                if (act === 'del')
                    utils.delRow(row);
                else
                    utils.itemEdited(gid, 1, 1)({ id: key });
            }
        }
    }
}

    return {
        init: regGridSync
    };
}();