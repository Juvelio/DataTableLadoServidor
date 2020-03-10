$("#btnBuscar").on("click", function (event) {
    event.preventDefault();
    var Cip = $("#txtCip").val();
    var ApPaterno = $("#txtApPaterno").val();
    var ApMaterno = $("#txtApMAterno").val();
    var Nombres = $("#txtNombresBuscar").val();
    var Dni = $("#txtDNI").val();

    $(".box-body").show();
    ListarPersonalDinamico(Cip, ApPaterno, ApMaterno, Nombres, Dni);
});

function ListarPersonalDinamico(Cip, Paterno, Materno, Nombres, Dni) {
    $('#tbl_ResultadoBusqueda').DataTable({
        "bDestroy": true,
        "language": {
            "url": "Plugins/DataTables/Idioma/Spanish.json"
        },
        "bProcessing": true,
        "bServerSide": true,
        "sAjaxSource": "ListarPersonal.ashx",

        "sServerMethod": 'POST',
        "fnServerParams": function (aoData) {
            aoData.push(
                { "name": "Cip", "value": Cip },
                { "name": "Paterno", "value": Paterno },
                { "name": "Materno", "value": Materno },
                { "name": "Nombres", "value": Nombres },
                { "name": "Dni", "value": Dni }
            );
        },
        columns: [
            { 'data': 'Fila', "className": "text-center" },
            { 'data': 'MASPE_CARNE', "className": "text-center" },
            { 'data': 'tGrad.TGRAD_DES' },
            { 'data': 'tSitua.TSITUA_DESL', "className": "text-center" },
            {
                data: null, render: function (data, type, row) {
                    return data.MASPE_PATER + ' ' + data.MASPE_MATER + ', ' + data.MASPE_NOMB;
                }
            }
            //{ "defaultContent": '<button type="button" value="Cargar" title="Ver" class="btn btn-primary btn-sm btn-Cargar"><i class="fa fa-check-square-o" aria-hidden="true"></i></button>', "className": "text-center", "bSort": false }

        ]
    });
}