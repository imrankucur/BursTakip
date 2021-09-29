<%@ Page Title="" Language="C#" MasterPageFile="~/KimlikPage.master" AutoEventWireup="true" CodeFile="GelirBorcBilgileri.aspx.cs" Inherits="GelirBorcBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="Tasarim.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row" style="background-color: white">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label Text="GELİR&BORÇ BİLGİLERİ" runat="server" CssClass="m-0 font-weight-bold text-primary" Font-Size="xx-large" Height="40px" text-align="center" />
    </div>
    <div class="container-fluid">
        <asp:Button ID="Btn_AileGeri" runat="server" OnClick="Btn_AileGeri_Click" Text="Aile" Width="100px" Height="35px" class="Label2" CssClass="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm" Font-Size="larger" />
        <div class="card shadow">
            <div class="d-sm-flex align-items-center justify-content-between">
                <h1 class="h3 mb-0 text-gray-800"></h1>
            </div>
            <div class="row">
                <div class="col-lg-3 col-md-6">
                    <div class="dropdown no-arrow">
                        <a class="dropdown-toggle" href="#" role="button" id="dropdownMenuLink"
                            data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></a>
                        <div class="dropdown-menu dropdown-menu-right shadow animated--fade-in"
                            aria-labelledby="dropdownMenuLink">
                            <div class="dropdown-header">Dropdown Header:</div>
                            <a class="dropdown-item" href="#">Action</a>
                            <a class="dropdown-item" href="#">Another action</a>
                            <div class="dropdown-divider"></div>
                            <a class="dropdown-item" href="#">Something else here</a>
                        </div>
                    </div>
                    <br />
                    <asp:Label ID="Label19" runat="server" Text="Baba Aylık Gelir:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_BabaAylikGelir" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text="Baba Nafaka Tutarı:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_BabaNafakaTutari" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <asp:Label ID="Label3" runat="server" Text="Babadan Kalan Ölüm Aylığı:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_BabaOlumAyligi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <asp:Label ID="Label4" runat="server" Text="Aile Diğer Aylık Geliri:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AileDigerAylikGeliri" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <asp:Label ID="Label5" runat="server" Text="Baba Toplam Gelir:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_BabaToplamGelir" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <asp:Label ID="Label6" runat="server" Text="Aile Aylık Kredi Ödemesi:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AileAylikKrediOdemesi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <br />
                    <asp:Button ID="Btn_GelirBorcKaydet" runat="server" OnClick="Btn_GelirBorcKaydet_Click" Text="Kaydet" Height="30px" Width="175px" CssClass="btn btn-success btn-icon-split DizaynStil" />
                    <asp:Button ID="Btn_GelirBorcGuncelle" runat="server" OnClick="Btn_GelirBorcGuncelle_Click" Text="Güncelle" Height="30px" Width="175px" CssClass="btn btn-success btn-icon-split DizaynStil"/>
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                    <br />
                </div>
                <div class="col-lg-3 col-md-6">
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Anne Aylık Gelir:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AnneAylikGelir" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <asp:Label ID="Label8" runat="server" Text="Anne Nafaka Tutarı:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AnneNafakaTutari" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <asp:Label ID="Label18" runat="server" Text="Anneden Kalan Ölüm Aylığı:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AnneKalanOlumAyligi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <asp:Label ID="Label20" runat="server" Text="Aile Diğer Aylık Gelir Açıklaması:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AileDigerGelirAciklama" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <asp:Label ID="Label11" runat="server" Text="Anne Toplam Gelir:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AnneToplamGelir" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <br />
                </div>
                <div class="col-lg-3 col-md-6">
                    <br />
                    <asp:Label ID="Label12" runat="server" Text="Oturulan Evin Durumu:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_OturulanEvinDurumu" runat="server" AutoPostBack="True" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil" OnSelectedIndexChanged="Ddl_OturulanEvinDurumu_SelectedIndexChanged">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Kira</asp:ListItem>
                        <asp:ListItem Value="1">Kendinin</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label13" runat="server" Text="Ev Kirası:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_EvKirasi" runat="server" TextMode="Number" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <asp:Label ID="Label14" runat="server" Text="Gayrimenkul Var Mı?:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_GayrimenkulVarMi" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Ddl_GayrimenkulVarMi_SelectedIndexChanged" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Yok</asp:ListItem>
                        <asp:ListItem Value="1">Var</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label15" runat="server" Text="Gayrimenkul Cinsi:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_GayrimenkulCinsi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <asp:Label ID="Label16" runat="server" Text="Kayıtlı Araç Var Mı?:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_KayitliAracVarMi" runat="server" AutoPostBack="True" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil" OnSelectedIndexChanged="Ddl_KayitliAracVarMi_SelectedIndexChanged">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Yok</asp:ListItem>
                        <asp:ListItem Value="1">Var</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label17" runat="server" Text="Araç Cinsi:" CssClass="DizaynStil"></asp:Label>
                    &nbsp;
            <asp:TextBox ID="Txt_AracCinsi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

