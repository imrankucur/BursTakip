<%@ Page Title="" Language="C#" MasterPageFile="~/KimlikPage.master" AutoEventWireup="true" CodeFile="EgitimBilgileri.aspx.cs" Inherits="EgitimBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Tasarim.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- Begin Page Content -->
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:label text="EĞİTİM BİLGİLERİ" runat="server" CssClass="m-0 font-weight-bold text-primary" font-size="xx-large" height="40px" text-align="center"/>
                <div class="container-fluid">
                      <asp:Button ID="Btn_KimlikGeri" runat="server" OnClick="Button1_Click1" Text="Kimlik" Width="100px" Height="35px" CssClass="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm" font-size="larger" />
            <asp:Button ID="Button2" runat="server" Text="İletişim" OnClick="Button2_Click" Enabled="false" style="margin-bottom: 0px" Width="100px" Height="35px" CssClass="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm" font-size="larger" />
                    
                    <div class="card shadow">
                    <div class="d-sm-flex align-items-center justify-content-between">
                        <h1 class="h3 mb-0 text-gray-800">
                                        </h1>
                    </div>
                    <div class="row">
                        <div class="col-lg-3 col-md-6">
                                    <div class="dropdown no-arrow">
                                        <a class="dropdown-toggle" href="#" role="button" id="dropdownMenuLink"
                                            data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                        </a>
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
            <asp:Label ID="Label18" runat="server" Text="Mezun Olunan Lise:" CssClass="Label2 DizaynStil" ></asp:Label>
                            <br />  
            <asp:DropDownList ID="Ddl_MezunLise" runat="server" width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                <asp:ListItem Value="-1">SEÇİNİZ</asp:ListItem>
                <asp:ListItem Value="0">Kadir Has Anadolu Lisesi</asp:ListItem>
                <asp:ListItem Value="1">abc</asp:ListItem>
                <asp:ListItem Value="2">def</asp:ListItem>
            </asp:DropDownList>
            
            <asp:Label ID="Label19" runat="server" Text="Üniversite:" CssClass="Label2 DizaynStil"></asp:Label>
            
            <asp:DropDownList ID="Ddl_Universite" runat="server" width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                <asp:ListItem Value="-1">SEÇİNİZ</asp:ListItem>
            </asp:DropDownList>
            
            <asp:Label ID="Label20" runat="server" Text="Fakülte:" CssClass="Label2 DizaynStil" ></asp:Label>
                            <br />  
            <asp:DropDownList ID="Ddl_Fakulte" runat="server" width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                <asp:ListItem Value="-1">SEÇİNİZ</asp:ListItem>
                <asp:ListItem Value="0">Mühendislik</asp:ListItem>
            </asp:DropDownList>
           
            <asp:Label ID="Label21" runat="server" Text="Bölüm:" CssClass="Label2 DizaynStil"></asp:Label>
                            <br />  
            <asp:DropDownList ID="Ddl_Bolum" runat="server" width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                <asp:ListItem Value="-1">SEÇİNİZ</asp:ListItem>
                <asp:ListItem Value="0">Bilgisayar</asp:ListItem>
            </asp:DropDownList>
                             
            <asp:Label ID="Label22" runat="server" CssClass="Label2 DizaynStil" Text="Sınıfı:"></asp:Label>
                            <br />  
            <asp:DropDownList ID="Ddl_Sinifi" runat="server" width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                <asp:ListItem Value="-1">SEÇİNİZ</asp:ListItem>
                <asp:ListItem Value="0">Hazırlık</asp:ListItem>
                <asp:ListItem Value="1">1.Sınıf</asp:ListItem>
                <asp:ListItem Value="2">2.Sınıf</asp:ListItem>
                <asp:ListItem Value="3">3.Sınıf</asp:ListItem>
                <asp:ListItem Value="4">4.Sınıf</asp:ListItem>
                <asp:ListItem Value="5">5.Sınıf</asp:ListItem>
                <asp:ListItem Value="6">6.Sınıf</asp:ListItem>
                <asp:ListItem Value="7">Uzatma</asp:ListItem>
                <asp:ListItem Value="8">Diğer</asp:ListItem>
            </asp:DropDownList>
                            <br />  
                            <asp:Button ID="Btn_EgitimKaydet" runat="server" OnClick="Btn_EgitimKaydet_Click" Text="Kaydet" Height="30px" Width="175px" CssClass="btn btn-success btn-icon-split DizaynStil" />
                            <asp:Button ID="Btn_EgitimGuncelle" Visible="false" runat="server" OnClick="Btn_EgitimGuncelle_Click" Text="Güncelle" Height="30px" Width="175px" CssClass="btn btn-success btn-icon-split DizaynStil" /> 
                                <br />
&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                                <br />
                                </div>
                                <!-- Card Body -->
                                
                        <div class="col-lg-3 col-md-6">
                            <br />
                            <asp:Label ID="Label23" runat="server" CssClass="Label2 DizaynStil" Text="Giriş Yılı:" ></asp:Label>
                            <br />             
            <asp:DropDownList ID="Ddl_GirisYili" runat="server" width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                <asp:ListItem Value="-1">SEÇİNİZ</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label24" runat="server" CssClass="Label2 DizaynStil" Text="Yerleştirme Puan Türü:"></asp:Label>
            <asp:DropDownList ID="Ddl_PuanTuru" runat="server" width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil">
                <asp:ListItem Value="-1">SEÇİNİZ</asp:ListItem>
                <asp:ListItem Value="0">ALÜGS</asp:ListItem>
                <asp:ListItem Value="1">DGS</asp:ListItem>
                <asp:ListItem Value="2">OBP</asp:ListItem>
                <asp:ListItem Value="3">Y-DİL</asp:ListItem>
                <asp:ListItem Value="4">Y-EA</asp:ListItem>
                <asp:ListItem Value="5">Y-SAY</asp:ListItem>
                <asp:ListItem Value="6">Y-SÖZ</asp:ListItem>
                <asp:ListItem Value="7">YETENEK SINAVI</asp:ListItem>
                <asp:ListItem Value="8">Y-TYT</asp:ListItem>
            </asp:DropDownList>
            
         
            <asp:Label ID="Label25" runat="server" CssClass="Label2 DizaynStil" Text="Yerleştirme Puanı:" ></asp:Label>
                            <br />  
            <asp:TextBox ID="Txt_YerlestirmePuani" runat="server" width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
            
            
            &nbsp;<asp:Label ID="Label26" runat="server" CssClass="Label2 DizaynStil" Text="Yerleştirme Türkiye Sırası:"></asp:Label>
                            <br />  
            <asp:TextBox ID="Txt_YerlestirmeSirasi" runat="server"  width="180px" Height="35" CssClass="form-control bg-light border-0 small DizaynStil"></asp:TextBox>
            <br />
            <br />
        </div>

                          <div class="col-lg-3 col-md-6"></div>
                        <div class="col-lg-3 col-md-6"></div>
                        </div>
                            </div>
                        
                        </div>

</asp:Content>

