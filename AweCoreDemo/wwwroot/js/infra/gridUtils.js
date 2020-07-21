/* eslint-disable */
//import * as jQuery from 'jquery';
//import { awe, awem, utils, aweui } from '../aweui/all.js';

var gridUtils = function ($) {    
    var nul = null;
    function isNull(val) {
        return val === nul || val === undefined;
    }

    function getPopupName(action, gridId) {
        return action + gridId;
    }

    function inlineDeleteFormatForGrid(gridId, key, nofocus, text) {
        if (!text) text = aweui.dict.Cancel;

        var popupName = getPopupName("delete", gridId);

        return deleteFormat(popupName, key, null, "o-glh", nofocus)
        + aweui.btn({ cont: text, cls: 'o-glcanb awe-nonselect o-gl o-glbtn' });
    }

    function deleteFormat(popupName, key, deleteContent, btnClass, nofocus) {
        if (!key) key = 'Id';
        btnClass = (btnClass || '') + ' delbtn';
        if (isNull(deleteContent)) {
            deleteContent = '<span class="ico-crud ico-del"></span>';
        }

        var tabindex = nofocus ? 'tabindex="-1"' : '';
        var onclick = 'onclick="awe.open(\'' + popupName + '\', { params:{ id: \'.(' + key + ')\' } }, event)"';

        return aweui.btn({ cont: deleteContent, cls: btnClass, attr: tabindex + ' ' + onclick });
    }

    function initDeletePopupForGrid(opt) {
        var delFunc = opt.reload ? utils.refreshGrid(opt.gridId) : utils.itemDeleted(opt.gridId);
        var delConfirmFunc = utils.delConfirmLoad(opt.gridId);

        aweui.initPopupForm({
            id: 'delete' + opt.gridId,
            url: opt.url,
            dataFunc: opt.dataFunc,
            postFunc: opt.postFunc,
            height: 200,
            success: delFunc,
            onLoad: delConfirmFunc,
            modal: true
        });
    }

    function initCrudPopupsForGrid(opt) {
        var gid = opt.gridId;
        var createFunc, editFunc;
        createFunc = editFunc = utils.refreshGrid(gid);
        
        if (!opt.reload) {
            createFunc = utils.itemCreatedUi(gid);
            editFunc = utils.itemEditedUi(gid);
        }

        aweui.initPopupForm({
            id: 'create' + gid,
            url: opt.createUrl,
            setCont: opt.createCont,
            postFunc: opt.createPost,
            height: 200,
            success: createFunc,
            closeOnSuccess: false,
            modal: true
        });

        aweui.initPopupForm({
            id: 'edit' + gid,
            url: opt.editUrl,
            setCont: opt.editCont,
            postFunc: opt.editPost,
            height: 200,
            success: editFunc,
            closeOnSuccess: false,
            modal: true
        });

        initDeletePopupForGrid({
            gridId: gid,
            dataFunc: opt.deleteDataFunc,
            postFunc: opt.deletePostFunc
        });
    }

    return {
        initCrudPopupsForGrid: initCrudPopupsForGrid,
        initDeletePopupForGrid: initDeletePopupForGrid,
        inlineDeleteFormatForGrid: inlineDeleteFormatForGrid,
        inlineEditFormat: function (nofocus) {
            var tabindex = nofocus ? 'tabindex="-1"' : '';
            return '<button type="button" class="awe-btn o-gledtb awe-nonselect o-glh o-glbtn" ' + tabindex + ' >Edit</button>' +
                '<button type="button" class="awe-btn o-glsvb awe-nonselect o-gl o-glbtn">Save</button>';
        },
        moveBtn: '<button type="button" class="awe-movebtn awe-btn" tabindex="-1"><i class="awe-icon"></i></button>',

        editFormatForGrid: function (opt) {
            var popupName = 'edit' + opt.gridId;
            var key = opt.key || 'id';

            var click = 'awe.open(\'' + popupName + '\', { params: { id: .(' + key + ') } }, event)';

            var btn = '<button type="button" onclick="' + click + '" ' +
                'class="awe-btn awe-nonselect editbtn">' +
                '<span class="ico-crud ico-edit"></span></button>';

            return btn;
        }
    };
}(jQuery);

//export {gridUtils};