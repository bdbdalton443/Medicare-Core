//import { awef } from '../aweui/all.js';

var modelState = function (o) {
    return function () {
        var errors = {};
        return {
            model: o,
            errors: errors,
            addError: function(name, msg) {
                if (awef.isNull(errors[name])) {
                    errors[name] = [msg];
                } else {
                    errors[name].push(msg);
                }
            },
            isValid: function() {
                return !Object.keys(errors).length;
            }
        };
    }();
};

var awevld = function(ms) {
    var o = ms.model;
    return {
        req: function(name, alias) {
            if (awef.isNull(o[name]) || o[name].length === 0) {
                ms.addError(name, (alias || name) + ' is required');
            }
        }
    };
};

//export { modelState, awevld };