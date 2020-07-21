var strUtil = function () {
    var loop = awef.loop;
    function replAll(str, f, r) {
        return str.split(f).join(r);
    }

    function setLinks(str, owner) {
        var fxwords = [];
        var cons = ['dataCon', 'dinnersInlCrudCon', 'dinnersCrudCon', 'gridUtils' ];

        var res = '';
        for (var i = 0; i < str.length; i++) {
            var handled = false;
            loop(cons, function (con) {
                if (isNextStr(str, i, con)) {
                    var endi = indexOfAny(str, [' ', ',', '/n', '/r', ';', '<', '('], i + con.length);
                    if (endi < 0) endi = str.length;
                    var fname = str.substring(i, endi);
                    
                    res += '<a href="#" class="funcLink" data-name="' + fname + '">' + fname + '</a>';
                    //i += con.length;
                    i = endi -1;
                    handled = true;
                    return false;
                }
            });
            
            if (handled) continue;

            loop(fxwords, function(word) {
                if (isNextStr(str, i, word)) {
                    var endi = i + word.length; 
                    var fname = str.substring(i, endi);
                    res += '<a href="#" class="funcLink" data-name="' + fname + '">' + fname + '</a>';
                    i = endi;
                }
            });

            res += str[i];
        }

        return res;
    }

    function isNextStr(source, startIndex, nextStr) {
        if (source.length >= startIndex + nextStr.length) {
            return source.substr(startIndex, nextStr.length) === nextStr;
        }

        return false;
    }

    function indexOfAny(str, chars, startAtIndx) {
        var index = -1;

        for (var i = startAtIndx; i < str.length; i++) {
            var match = aweq.where(chars, function (c) {
                return c === str[i];
            });

            if (match.length) {
                index = i;
                break;
            }
        }

        return index;
    }

    return {
        getFuncCode: function(name) {
            var str = eval(name).toString();
            var lines = str.split('\n');
            var line0 = lines.shift();
            lines = strUtil.remStartSpace(lines);
            lines.unshift(line0);
            str = lines.join('\n');

            str = strUtil.sanitize(str);
            str = setLinks(str, name);
            return str;
        },
        getCode: function(name) {
            var si = source.indexOf('begin' + name);
            var ei = source.indexOf('end' + name);

            var str = strUtil.fromTo(source, si, ei);
            var lines = str.split('\n');
            lines.shift();
            lines.pop();

            lines = strUtil.remStartSpace(lines);

            str = lines.join('\n');

            str = strUtil.sanitize(str);
            str = setLinks(str);

            return str;
        },
        indexOfAny: indexOfAny,
        fromTo: function (str, fromi, toi) {
            return str.substring(fromi, toi);
        },
        sanitize: function(str) {
            str = replAll(str, '\r', '');
            str = replAll(str, '&', '&amp;');
            str = replAll(str, '\"', '&quot;');
            str = replAll(str, '\'', '&#39;');
            str = replAll(str, '<', '&lt;');
            str = replAll(str, '>', '&gt;');
            str = replAll(str, '\n', '<br/>');
            return str;
        },
        wrapCode: function(str, path) {
            var res = "<pre class='lang-java prettyprint'>" + str + "</pre>";

            if (awef.isNotNull(path)) {                
                res = "<div class='codePath'>" + path + "</div>" + res;
            }

            res = "<div class='codeWrap'>" + res + "</div>";

            return res;
        },
        parseStrToCode: function(str, path) {
            str = strUtil.sanitize(str);
            return strUtil.wrapCode(str, path);
        },
        remStartSpace: function(lines) {
            var res = lines;
            var minws = null;
            awef.loop(res, function (line) {
                if (line.length === 0
                    || line.length === 1 && line[0].charCodeAt() === 13) return true;

                var lmin = 0;
                awef.loop(line, function (ch) {
                    if (ch === ' ') lmin++;
                    else return false;
                });

                if (awef.isNull(minws) || lmin < minws) minws = lmin;
            });


            if (awef.isNotNull(minws)) {
                for (var i = 0; i < res.length; i++) {
                    var line = res[i];
                    if (line.length !== 0) {
                        res[i] = line.substring(minws);
                    }
                }
            }

            return res;
        }
    };
}();