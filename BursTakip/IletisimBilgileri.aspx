<%@ Page Title="" Language="C#" MasterPageFile="~/KimlikPage.master" AutoEventWireup="true" CodeFile="IletisimBilgileri.aspx.cs" Inherits="IletisimBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="Tasarim.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Begin Page Content -->
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
    <asp:Label Text="İLETİŞİM BİLGİLERİ" runat="server" CssClass="m-0 font-weight-bold text-primary" Font-Size="xx-large" Height="40px" text-align="center" />
    <div class="container-fluid">
        <asp:Button ID="Btn_EgitimGeri" runat="server" OnClick="Btn_EgitimGeri_Click" Width="100px" Height="35px" Text="Eğitim" CssClass="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm" Font-Size="larger" />
        <asp:Button ID="Btn_Aileileri" runat="server" Enabled="false" OnClick="Btn_Aileileri_Click" Text="Aile" Width="100px" Height="35px" CssClass="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm" Font-Size="larger" />
        <div class="card shadow">
            <div class="d-sm-flex align-items-center justify-content-between ">
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
                    <asp:Label ID="Label1" runat="server" Text="Aile İkamet İli:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_Aileikametili" runat="server" Width="155px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil" OnSelectedIndexChanged="Ddl_Aileikametili_SelectedIndexChanged" AutoPostBack="true">
                    </asp:DropDownList>

                    <asp:Label ID="Label2" runat="server" Text="Aile İkamet İlçesi:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_Aileikametilcesi" runat="server" OnSelectedIndexChanged="Ddl_Aileikametilçesi_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px">
                    </asp:DropDownList>
                    <asp:Label ID="Label3" runat="server" Text="Aile İkamet Adresi:" CssClass="DizaynStil"></asp:Label>

                    &nbsp;
            <asp:TextBox ID="Txt_Aileikametadresi" runat="server" TextMode="Phone" Width="200px" Height="35px" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
                    <asp:Label ID="Label4" runat="server" Text="Cep Telefonu:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_CepTelefonu" CssClass="form-control bg-light border-0 small DizaynStil" runat="server" OnTextChanged="Txt_CepTelefonu_TextChanged" Width="155px" Height="35px"></asp:TextBox>

                    <asp:Label ID="Label5" runat="server" Text="E-Posta Adresi:" CssClass="DizaynStil"></asp:Label>
                    &nbsp;&nbsp;<asp:TextBox ID="Txt_Eposta" runat="server" TextMode="Email" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px" required></asp:TextBox>
                    <asp:Label ID="Label6" runat="server" Text="Baba Cep Telefonu:" CssClass="DizaynStil"></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="Txt_BabaCepTelefonu" runat="server" MaxLength="10" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px"></asp:TextBox>
                    <asp:Label ID="Label7" runat="server" Text="Anne Cep Telefonu:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AnneCepTelefonu" runat="server" MaxLength="10" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px"></asp:TextBox>
                    <br />
                    <asp:Button ID="Btn_iletisimKaydet" runat="server" OnClick="Btn_iletisimKaydet_Click" Text="Kaydet" Height="30px" Width="175px" CssClass="btn btn-success btn-icon-split DizaynStil" />

                    <asp:Button ID="Btn_IletisimGuncelle" runat="server" OnClick="Btn_IletisimGuncelle_Click" Text="Güncelle" Height="30px" Width="175px" CssClass="btn btn-success btn-icon-split DizaynStil" />
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                    <br />
                </div>

                <div class="col-lg-3 col-md-6">
                    <br />
                    <asp:Label ID="Label9" runat="server" Text="HAKKINIZDA BİLGİ ALINABİLECEK KİŞİLER" Font-Bold="true" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label10" runat="server" Text="Birinci Kişi Ad:" CssClass="DizaynStil"></asp:Label>

                    <asp:TextBox ID="Txt_BirinciKisiAd" runat="server" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px"></asp:TextBox>
                    <asp:Label ID="Label11" runat="server" Text="Birinci Kişi Soyad:" CssClass="DizaynStil"></asp:Label>

                    <asp:TextBox ID="Txt_BirinciKisiSoyad" runat="server" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px"></asp:TextBox>

                    <asp:Label ID="Label12" runat="server" Text="Birinci Kişi Kurum:" CssClass="DizaynStil"></asp:Label>

                    <asp:TextBox ID="Txt_BirinciKisiKurum" runat="server" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px"></asp:TextBox>
                    <asp:Label ID="Label13" runat="server" Text="Birinci Kişi Ünvanı:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_BirinciKisiUnvan" runat="server" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px"></asp:TextBox>


                    <asp:Label ID="Label14" runat="server" Text="Birinci Kişi Telefon:" CssClass="DizaynStil"></asp:Label>
                    &nbsp;
        <asp:TextBox ID="Txt_BirinciKisiTelefon" runat="server" MaxLength="10" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px"></asp:TextBox>
                </div>
                <div class="col-lg-3 col-md-6">
                    <br />
                    <br />
                    <br />

                    <asp:Label ID="Label16" runat="server" Text="İkinci Kişi Ad:" CssClass="DizaynStil"></asp:Label>
                    <asp:TextBox ID="Txt_ikinciKisiAd" runat="server" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px"></asp:TextBox>
                    <asp:Label ID="Label17" runat="server" Text="İkinci Kişi Soyad:" CssClass="DizaynStil"></asp:Label>
                    &nbsp;&nbsp;
        <asp:TextBox ID="Txt_ikinciKisiSoyad" runat="server" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px"></asp:TextBox>
                    <asp:Label ID="Label18" runat="server" Text="İkinci Kişi Kurum:" CssClass="DizaynStil"></asp:Label>
                    <asp:TextBox ID="Txt_ikinciKisiKurum" runat="server" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px"></asp:TextBox>
                    <asp:Label ID="Label19" runat="server" Text="İkinci Kişi Ünvanı:" CssClass="DizaynStil"></asp:Label>
                    <asp:TextBox ID="Txt_ikinciKisiUnvan" runat="server" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px"></asp:TextBox>
                    <asp:Label ID="Label20" runat="server" Text="İkinci Kişi Telefon:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_ikinciKisiTelefon" runat="server" MaxLength="10" CssClass="form-control bg-light border-0 small DizaynStil" Width="155px" Height="35px"></asp:TextBox>
                    <br />
                    &nbsp;<asp:TextBox ID="Txt_Gecici" runat="server" Visible="False"></asp:TextBox>
                </div>
                <div class="col-lg-3 col-md-6"></div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#ContentPlaceHolder1_Txt_CepTelefonu').mask('(999) 999-9999');
            $('#ContentPlaceHolder1_Txt_BabaCepTelefonu').mask('(999) 999-9999');
            $('#ContentPlaceHolder1_Txt_AnneCepTelefonu').mask('(999) 999-9999');
            $('#ContentPlaceHolder1_Txt_BirinciKisiTelefon').mask('(999) 999-9999');
            $('#ContentPlaceHolder1_Txt_ikinciKisiTelefon').mask('(999) 999-9999');
        });
    </script>

</asp:Content>

