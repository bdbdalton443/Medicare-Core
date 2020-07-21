/* eslint-disable */
var storg = function () {
    var prefix = "awed.";
    var version = 1;
    var storage = sessionStorage || {};
    return {
        init: function (v) {
            version = v || 1;
            // remove storage keys from older versions; current value is "awe.oldversion"
            try {
                for (var key in storage) {
                    if (key.indexOf(prefix) === 0) {
                        if (key.indexOf(prefix + version) !== 0) {
                            storage.removeItem(key);
                        }
                    }
                }
            } catch (err) {
                /*empty*/
            }
        },
        getOrAddAndRun: function (key, loadFunc, onGetFunc) {
            if (!onGetFunc) onGetFunc = function (res) { return res; }
            key = prefix + version + key;
            if (storage[key]) {
                var itms = JSON.parse(storage[key]);
                return onGetFunc(itms);

            } else {
                return loadFunc().then(function (items) {
                    storage[key] = JSON.stringify(items);
                    return onGetFunc(items);
                });
            }
        }
    };
}();

//export {storg};