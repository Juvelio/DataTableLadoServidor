<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="TablaDinamica.aspx.cs" Inherits="CapaPresentacion.TablaDinamica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
    <link href="Plugins/DataTables/DataTables-1.10.20/css/dataTables.bootstrap.min.css" rel="stylesheet" />
    <link href="Plugins/DataTables/Responsive-2.2.3/css/responsive.bootstrap.min.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="container">

        <!-- Main component for a primary marketing message or call to action -->
        <%--<div class="jumbotron">
            <h1>Navbar example</h1>
            <p>This example is a quick exercise to illustrate how the default, static and fixed to top navbar work. It includes the responsive CSS and HTML, so it also adapts to your viewport and device.</p>
            <p>To see the difference between static and fixed top navbars, just scroll.</p>
            <p>
                <a class="btn btn-lg btn-primary" href="../../components/#navbar" role="button">View navbar docs &raquo;</a>
            </p>
        </div>--%>
        <div class="row">
            <div class="col-md-2 col-sm-4 col-xs-6">
                <div class="form-group-btn">
                    <div class="gro">
                        <label>CIP:</label>
                    </div>
                    <input type="text" maxlength="8" id="txtCip" class="form-control" placeholder="Cip..." onkeypress="return event.charCode >= 48 && event.charCode <= 57" onblur="ponerCeros(this)">
                </div>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6">
                <div class="form-group-btn">
                    <label>Ap. Paterno</label>
                    <input type="text" id="txtApPaterno" class="form-control" placeholder="Apellido Paterno..." onkeypress="return soloLetras(event)">
                </div>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6">
                <label>Ap. Materno</label>
                <span class="input-group-btn">

                    <input type="text" id="txtApMAterno" class="form-control" placeholder="Apellido Materno..." onkeypress="return soloLetras(event)">
                </span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6">
                <label>Nombres</label>
                <span class="input-group-btn">

                    <input type="text" id="txtNombresBuscar" class="form-control" placeholder="Nombres..." onkeypress="return soloLetras(event)">
                </span>
            </div>
            <div class="col-md-2 col-sm-4 col-xs-6">
                <label>DNI:</label>
                <span class="input-group-btn">

                    <input type="text" maxlength="8" id="txtDNI" class="form-control" placeholder="Dni..." onkeypress="return event.charCode >= 48 && event.charCode <= 57" onblur="ponerCeros(this)">
                </span>
            </div>

            <div class="col-md-2 col-sm-4 col-xs-6">
                <label>&nbsp;</label>

                <div class="form-group">
                    <%--<asp:LinkButton ID="lbtnBuscar" runat="server" CssClass="btn btn-primary btn-sm">Buscar &nbsp;<span class="glyphicon glyphicon-search" aria-hidden="true"></span></asp:LinkButton>--%>
                    <button id="btnBuscar" class="btn btn-primary form-control btn-sm">Buscar &nbsp;<span class="glyphicon glyphicon-search" aria-hidden="true"></span></button>
                </div>
            </div>
        </div>



        <div class="box-body" style="display:none">
            <table id="tbl_ResultadoBusqueda" class="table table-striped table-bordered" style="width: 100%">
                <thead>
                    <tr>
                        <th>N°</th>
                        <th>CIP</th>
                        <th>Grado</th>
                        <th>Situacion</th>
                        <th>Apellidos y Nombres</th>
                    </tr>
                </thead>
                <tbody>
                    <!-- DATA POR MEDIO DE AJAX-->
                </tbody>
            </table>
        </div>

    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentFooder" runat="server">
    <script src="Plugins/DataTables/DataTables-1.10.20/js/jquery.dataTables.min.js"></script>
    <script src="Plugins/DataTables/DataTables-1.10.20/js/dataTables.bootstrap.min.js"></script>
    <script src="Plugins/DataTables/Responsive-2.2.3/js/dataTables.responsive.min.js"></script>
    <script src="Plugins/DataTables/Responsive-2.2.3/js/responsive.bootstrap.min.js"></script>

    <script src="Js/ListarPersonal.js"></script>
</asp:Content>
