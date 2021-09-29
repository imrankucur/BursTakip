<%@ Page Title="" Language="C#" MasterPageFile="~/KimlikPage.master" AutoEventWireup="true" CodeFile="AileBilgileri.aspx.cs" Inherits="AileBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="Tasarim.css" rel="stylesheet" />  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Begin Page Content -->
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:label text="AİLE BİLGİLERİ" runat="server" CssClass="m-0 font-weight-bold text-primary" font-size="xx-large" height="40px" text-align="center" />
 
    <div class="container-fluid">
        <asp:Button ID="Btn_iletisimGeri" runat="server" OnClick="Btn_iletisimGeri_Click" Text="İletişim" Width="100px" Height="35px" CssClass="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm" Font-Size="larger" />
        <asp:Button ID="Btn_GelirBorcileri" enabled="false" runat="server" OnClick="Btn_GelirBorcileri_Click" Text="Gelir&amp;Borç" Width="100px" Height="35px" CssClass="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm" Font-Size="large" />

        <div class="card shadow">
            <!-- Page Heading -->
            <div class="d-sm-flex align-items-center justify-content-between">
                <h1 class="h3 mb-0 text-gray-800"></h1>
            </div>
            <div class="row">
                <!-- Area Chart -->
                <div class="col-lg-3 col-md-6">
                    <!-- Card Header - Dropdown -->
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
                    <asp:Label ID="Label3" runat="server" Text="Baba Hayatta Mı?:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_BabaHayattaMi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil" AutoPostBack="True" OnSelectedIndexChanged="Ddl_BabaHayattaMi_SelectedIndexChanged">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Hayır</asp:ListItem>
                        <asp:ListItem Value="1">Evet</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label4" runat="server" Text="Baba Geçimden Sorumlu Mu?:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_BabaGecimdenSorumluMu" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Hayır</asp:ListItem>
                        <asp:ListItem Value="1">Evet</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label5" runat="server" Text="Baba Ad:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_BabaAd" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label13" runat="server" Text="Baba Soyad:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_BabaSoyad" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label6" runat="server" Text="Baba T.C. Kimlik No:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_BabaTC" runat="server" MaxLength="11" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label7" runat="server" Text="Baba Doğum Tarihi:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_BabaDogumTarihi" runat="server" TextMode="Date" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label8" runat="server" Text="Baba Emekli Mi?:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_BabaEmekliMi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Hayır</asp:ListItem>
                        <asp:ListItem Value="1">Evet</asp:ListItem>
                    </asp:DropDownList>

                    <asp:Label ID="Label14" runat="server" Text="Baba İşyeri Adı:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_BabaisyeriAdi" runat="server" MaxLength="50" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label15" runat="server" Text="Baba Görevi:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_BabaGorevi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label16" runat="server" Text="Baba İşe Giriş Tarihi:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_BabaiseGirisTarihi" runat="server" OnTextChanged="Txt_BabaiseGirisTarihi_TextChanged" TextMode="Date" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label17" runat="server" Text="Baba Engelli Mi?" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_BabaEngelliMi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Hayır</asp:ListItem>
                        <asp:ListItem Value="1">Evet</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:Button ID="Btn_AileBilgileriKaydet" runat="server" OnClick="Btn_AileBilgileriKaydet_Click" Text="Kaydet" Height="30px" Width="175px" CssClass="btn btn-success btn-icon-split DizaynStil"/>
                    <asp:Button ID="Btn_AileBilgileriGuncelle" Visible="false" runat="server" OnClick="Btn_AileBilgileriGuncelle_Click" Text="Güncelle" Height="30px" Width="175px" CssClass="btn btn-success btn-icon-split DizaynStil" />


                    <br />
&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                    <br />


                </div>
                <!-- Card Body -->

                <div class="col-lg-3 col-md-6">

                    <br />

                    <asp:Label ID="Label19" runat="server" Text="Anne Hayatta Mı?" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_AnneHayattaMi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil" AutoPostBack="True" OnSelectedIndexChanged="Ddl_AnneHayattaMi_SelectedIndexChanged">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Hayır</asp:ListItem>
                        <asp:ListItem Value="1">Evet</asp:ListItem>
                    </asp:DropDownList>


                    <asp:Label ID="Label20" runat="server" Text="Anne Geçimden Sorumlu Mu?" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_AnneGecimdenSorumluMu" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Hayır</asp:ListItem>
                        <asp:ListItem Value="1">Evet</asp:ListItem>
                    </asp:DropDownList>



                    <asp:Label ID="Label21" runat="server" Text="Anne Ad:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AnneAd" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label22" runat="server" Text="Anne Soyad:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AnneSoyad" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label23" runat="server" Text="Anne T.C. Kimlik No:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AnneTC" runat="server" MaxLength="11" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label24" runat="server" Text="Anne Doğum Tarihi" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AnneDogumTarihi" runat="server" TextMode="Date" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label25" runat="server" Text="Anne Emekli Mi?" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_AnneEmekliMi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Hayır</asp:ListItem>
                        <asp:ListItem Value="1">Evet</asp:ListItem>
                    </asp:DropDownList>

                    <asp:Label ID="Label26" runat="server" Text="Anne İşyeri Adı:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AnneisyeriAdi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label27" runat="server" Text="Anne Görevi:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AnneGorevi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label28" runat="server" Text="Anne İşe Giriş Tarihi:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:TextBox ID="Txt_AnneiseGirisTarihi" runat="server" TextMode="Date" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>

                    <asp:Label ID="Label29" runat="server" Text="Anne Engelli Mi?" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_AnneEngelliMi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Hayır</asp:ListItem>
                        <asp:ListItem Value="1">Evet</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="col-lg-3 col-md-6">

                    <br />

                    <asp:Label ID="Label31" runat="server" Text="Şehit-Gazi Çocuğu Mu?:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_SehitGaziCocuguMu" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil" AutoPostBack="True" OnSelectedIndexChanged="Ddl_SehitGaziCocuguMu_SelectedIndexChanged">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Hayır</asp:ListItem>
                        <asp:ListItem Value="1">Evet</asp:ListItem>
                    </asp:DropDownList>

                    <asp:Label ID="Label33" runat="server" Text="Şehit-Gazi:" CssClass="DizaynStil"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Ddl_SehitGazi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Şehit</asp:ListItem>
                        <asp:ListItem Value="1">Gazi</asp:ListItem>
                    </asp:DropDownList>

                    <asp:Label ID="Label34" runat="server" Text="Anne-Baba Boşanmış Mı?:" CssClass="DizaynStil"></asp:Label>
                    <br />

                    <asp:DropDownList ID="Ddl_AnneBabaBosanmisMi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                        <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="0">Hayır</asp:ListItem>
                        <asp:ListItem Value="1">Evet</asp:ListItem>
                    </asp:DropDownList>


                    <asp:Label ID="Label32" runat="server" Text="Kardeş Sayısı:" CssClass="DizaynStil"></asp:Label>
                    <br />

                    <asp:DropDownList ID="Ddl_KardesSayisi" runat="server" Width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                    </asp:DropDownList>






                </div>
                <div class="col-lg-3 col-md-6"></div>

            </div>

        </div>

    </div>






    </div>
                        

                        <!-- Pie Chart -->

    </div>



                </div>
                
     <script type="text/javascript">
        $(document).ready(function () {
            $('#ContentPlaceHolder1_Txt_BabaTC').mask('99999999999');
            $('#ContentPlaceHolder1_Txt_AnneTC').mask('99999999999');
        });
    </script>
</asp:Content>

