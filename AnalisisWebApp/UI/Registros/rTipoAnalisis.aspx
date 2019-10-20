<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rTipoAnalisis.aspx.cs" Inherits="AnalisisWebApp.UI.Registros.rTipoAnalisis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 </br>
    <div class="form-row justify-content-center">
        <aside class="col-sm-4">
            <div class="card text-white bg-dark mb-3">
                <div class="card-header text-uppercase text-center">Tipo de Analisis</div>
                <article class="card-body">
                    <form>
                        <div class="col-md-4 col-md-offset-3">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label1" runat="server" Text="TipoId"></asp:Label>
                                    <asp:Button class="btn btn-info btn-sm" ID="BuscarButton" runat="server" Text="Buscar" />
                                    <asp:TextBox class="form-control" ID="TipoIdTextBox" type="number" Text="0" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-md-offset-3">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label2" runat="server" Text="Descripcion"></asp:Label>
                                    <asp:TextBox class="form-control" ID="DescripcionTextBox" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-md-offset-3">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label4" runat="server" Text="Precio"></asp:Label>
                                    <asp:TextBox class="form-control" ID="PrecioTextBox" type="number" Text="0" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-md-offset-3">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label3" runat="server" Text="Realizados"></asp:Label>
                                    <asp:TextBox class="form-control" ID="RealizadosTextBox" type="number" Text="0" runat="server" ReadOnly="True" BackColor="#3399FF"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="panel-footer">
                            <div class="text-center">
                                <div class="form-group" style="display: inline-block">
                                    <asp:Button class="btn btn-primary" ID="nuevoButton" runat="server" Text="Nuevo" />
                                    <asp:Button class="btn btn-success" ID="guardarButton" runat="server" Text="Guardar"/>
                                    <asp:Button class="btn btn-danger" ID="eliminarutton" runat="server" Text="Eliminar"/>
                                </div>
                            </div>
                        </div>
                    </form>
                </article>
            </div>
    </div>
</asp:Content>
