$(function () {
    $('#productTable').dataTable({
        "processing": true,
        "serverSide": true,
        "filter": true,
        "ajax": {
            "url": "/Product/GetProducts",
            "type": "POST",
            "datatype": "json"
        },
        //"columnDefs": [{
        //    "targets": [0],
        //    "visible": false,
        //    "searchable": false
        //}],
        "columns": [
            { "data": "id", "name": "ID", "autoWidth": true },
            { "data": "name", "name": "Name", "autoWidth": true },
        ]
    });
});