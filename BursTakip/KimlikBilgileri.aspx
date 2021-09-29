<%@ Page Title="" Language="C#" MasterPageFile="~/KimlikPage.master" AutoEventWireup="true" CodeFile="KimlikBilgileri.aspx.cs" Inherits="_KimlikBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="Tasarim.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp<asp:Label Text="KİMLİK BİLGİLERİ" runat="server" CssClass="m-0 font-weight-bold text-primary" Font-Size="xx-large" Height="40px" />
    <div class="container-fluid">
        <asp:Button ID="Btn_Egitimileri" Enabled="false" runat="server" Height="35px" OnClick="Button1_Click6" Text="Eğitim" Width="100px" CssClass="btn btn-primary btn-icon-split" />
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
                    <asp:Label ID="Label1" runat="server" Text="Ad:" CssClass="DizaynStil" ></asp:Label>
                    <asp:TextBox ID="Txt_Ad" runat="server" CssClass="form-control bg-light border-0 small DizaynStil" Width="180px" Height="35px" required></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text="Soyad:" CssClass="DizaynStil"></asp:Label>
                    <asp:TextBox ID="Txt_Soyad" runat="server" CssClass="form-control bg-light border-0 small DizaynStil" Width="180px" Height="35px" required></asp:TextBox>
                    <asp:Label ID="Label10" runat="server" Text="TC Kimlik No:" CssClass="DizaynStil"></asp:Label>
                    <asp:TextBox ID="Txt_TcKimlik" runat="server" CssClass="form-control bg-light border-0 small DizaynStil" Width="180px" Height="35px"></asp:TextBox>
                    <asp:Label ID="Label3" runat="server" Text="Doğum Tarihi:" CssClass="DizaynStil"></asp:Label>
            <br />
                    <asp:TextBox ID="Txt_DogumTarihi" runat="server" Width="180px" Height="35px" TextMode="Date" CssClass="form-control bg-light border-0 small DizaynStil" OnTextChanged="Txt_DogumTarihi_TextChanged"></asp:TextBox>
                    <asp:Label ID="Label11" runat="server" Text="Doğum Yeri:" CssClass="DizaynStil"></asp:Label>
                    &nbsp;&nbsp; <asp:RequiredFieldValidator ID="reqDogumYeri" runat="server" ControlToValidate="Ddl_DogumYeri" InitialValue="-1" ErrorMessage="Lütfen seçim yapınız." SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    <br />
                    <asp:DropDownList ID="Ddl_DogumYeri" runat="server" Width="180px" Height="35px" CssClass="form-control bg-light border-0 small DizaynStil" OnSelectedIndexChanged="Ddl_DogumYeri_SelectedIndexChanged">
                        <asp:ListItem Value="-1">SEÇİNİZ</asp:ListItem>
                    </asp:DropDownList> 
                    <asp:Label ID="Label5" runat="server" Text="Nüfus Kayıt İli:" CssClass="DizaynStil"></asp:Label>
                    &nbsp;&nbsp; 
                    <br />
                    <asp:DropDownList ID="Ddl_NufusKayitili" runat="server" Width="180px" Height="35px" CssClass="form-control bg-light border-0 small DizaynStil" >
                        <asp:ListItem Value="-1">SEÇİNİZ</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:Button ID="Btn_KimlikKaydet" runat="server" OnClick="Button1_Click" CssClass="btn btn-success btn-icon-split DizaynStil" Text="KAYDET" Width="175px" Font-Bold="True" Height="30px" />
                    <asp:Button ID="Btn_KimlikGuncelle" runat="server" Font-Bold="True" Width="180px" Height="35px" OnClick="Button2_Click1" Text="Güncelle" Visible="False" CssClass="btn btn-success btn-icon-split DizaynStil" />
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                    <br />
                </div>
                <div class="col-lg-3 col-md-6">
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Uyruk:" CssClass="DizaynStil"></asp:Label>
                    &nbsp;&nbsp; <asp:RequiredFieldValidator ID="reqUyruk" runat="server" ControlToValidate="Ddl_Uyruk" InitialValue="-1" ErrorMessage="Lütfen seçim yapınız." SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>

                    <asp:DropDownList ID="Ddl_Uyruk" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="180px" Height="35px" CssClass="form-control bg-light border-0 small DizaynStil">
                        <asp:ListItem Value="-1">SEÇİNİZ</asp:ListItem>
                        <asp:ListItem Value="0">T.C.</asp:ListItem>
                        <asp:ListItem Value="1">Yabancı</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label7" runat="server" Text="Cinsiyet:" CssClass="DizaynStil"></asp:Label>
                    &nbsp;&nbsp; <asp:RequiredFieldValidator ID="reqCinsiyet" runat="server" ControlToValidate="Ddl_Cinsiyet" InitialValue="-1" ErrorMessage="Lütfen seçim yapınız." SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    <br />
                    <asp:DropDownList ID="Ddl_Cinsiyet" runat="server" Width="180px" Height="35px" CssClass="form-control bg-light border-0 small DizaynStil">
                        <asp:ListItem Value="-1">SEÇİNİZ</asp:ListItem>
                        <asp:ListItem Value="0">Erkek</asp:ListItem>
                        <asp:ListItem Value="1">Kadın</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label8" runat="server" Text="Medeni Hal:" CssClass="DizaynStil"></asp:Label>
                    <asp:DropDownList ID="Ddl_MedeniHal" runat="server" Width="180px" Height="35px" OnSelectedIndexChanged="Ddl_MedeniHal_SelectedIndexChanged" CssClass="form-control bg-light border-0 small DizaynStil">
                        <asp:ListItem Value="-1">SEÇİNİZ</asp:ListItem>
                        <asp:ListItem Value="0">Bekar</asp:ListItem>
                        <asp:ListItem Value="1">Evli</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label9" runat="server" Text="Engel Durumu:" CssClass="DizaynStil"></asp:Label>
                    <asp:DropDownList ID="Ddl_EngelDurumu" runat="server" Width="180px" Height="35px" OnSelectedIndexChanged="Ddl_EngelDurumu_SelectedIndexChanged" CssClass="form-control bg-light border-0 small DizaynStil">
                        <asp:ListItem Value="-1">SEÇİNİZ</asp:ListItem>
                        <asp:ListItem Value="0">Yok</asp:ListItem>
                        <asp:ListItem Value="1">Var</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-3 col-md-6"></div>
                <div class="col-lg-3 col-md-6"></div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#ContentPlaceHolder1_Txt_TcKimlik').mask('99999999999');
        });
    </script>
    </asp:Content>
