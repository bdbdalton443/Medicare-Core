//import { awef, awem, utils, aweui } from '../aweui/all.js';

var formBuilder = function (opt) {
    var model = opt.model;
    var str = '';
    var funcs = [];
    var prefix = '';

    if (opt.sp) {
        var prm = utils.getParams(opt.sp);
        if (prm.__aweconid) {
            prefix = prm.__aweconid;
        }
    }

    return {
        id: function (idstr) {
            return prefix + idstr;
        },
        str: function (s) {
            str += s;
        },
        add: function (o) {
            var val = model[o.prop];
            var name = o.prop;
            var label = o.label || name;
            var id = o.id || prefix + name;
            var inpcls = o.inpcls || '';
            var inptype = 'hidden';

            var finput = function () {
                return '<input type="' + inptype + '" id="' + id + '" name="' + name + '" value="' + val + '"/>';
            };

            if (o.func === aweui.datepicker) {
                inptype = 'text';
            }

            if (awef.isNotNull(val)) {
                if (val instanceof Date) {
                    val = awem.formatDate(awem.dateFormat, val);
                } else if (val instanceof Array) {
                    val = JSON.stringify(val);
                }
            } else {
                val = '';
            }

            if (o.hidden) {
                inptype = 'hidden';
                str += finput();
            } else {
                str += '<div class="efield">';
                str += '<div class="elabel"><label>' + label + '</label></div>\n';
                str += '<div class="einput ' + inpcls + '">' +
                    finput() +
                    '<span vld-for="' + name + '"></span></div>';
                str += '</div>';
            }

            if (o.func) {
                var opt = o.opt || {};
                opt.id = id;
                funcs.push({ f: o.func, opt: opt });
            }
        },
        applyToPopup: function (o) {
            o.scon.html('<form>' + str + '</form>');
            awef.loop(funcs,
                function (fo) {
                    fo.f(fo.opt);
                });
        }
    };
};

//export { formBuilder };