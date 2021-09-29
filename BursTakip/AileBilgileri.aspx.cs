using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Threading;

public partial class AileBilgileri : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=MDEV01;Initial Catalog=BursTakip;Integrated Security=True;");
    protected void Page_Load(object sender, EventArgs e)
    {

        for (int i = 1; i <= 20; i++)
        {
            ListItem item = new ListItem();
            item.Value = i.ToString();

            Ddl_KardesSayisi.Items.Add(item);
        }

        SqlParameter QueryId = new SqlParameter();
        QueryId.ParameterName = "@QueryId";
        QueryId.Value = Convert.ToInt32(Request.QueryString["id"]);
        con.Open();
        SqlCommand doldur = new SqlCommand("select BabaHayattaMi,BabaGecimdenSorumluMu,BabaAd,BabaSoyad,BabaTC,BabaDogumTarihi,BabaEmekliMi,BabaisyeriAdi,BabaGorevi,BabaiseGirisTarihi,BabaEngelliMi,AnneHayattaMi,AnneGecimdenSorumluMu,AnneAd,AnneSoyad,AnneTC,AnneDogumTarihi,AnneEmekliMi,AnneisyeriAdi,AnneGorevi,AnneiseGirisTarihi,AnneEngelliMi from AileBilgileri where KimlikId=@QueryId", con);
        doldur.Parameters.Add(QueryId);
        SqlDataReader read;
        read = doldur.ExecuteReader();


        if (!Page.IsPostBack)
        {

            while (read.Read())
            {

                Btn_AileBilgileriKaydet.Visible = false; Btn_AileBilgileriGuncelle.Visible = true;


                Ddl_BabaHayattaMi.SelectedValue = read["BabaHayattaMi"].ToString();
                Ddl_BabaGecimdenSorumluMu.SelectedValue = read["BabaGecimdenSorumluMu"].ToString();
                Txt_BabaAd.Text = read["BabaAd"].ToString();
                Txt_BabaSoyad.Text = read["BabaSoyad"].ToString();
                Txt_BabaTC.Text = read["BabaTC"].ToString();
                Txt_BabaDogumTarihi.Text = read["BabaDogumTarihi"].ToString();
                Ddl_BabaEmekliMi.SelectedValue = read["BabaEmekliMi"].ToString();
                Txt_BabaisyeriAdi.Text = read["BabaisyeriAdi"].ToString();
                Txt_BabaGorevi.Text = read["BabaGorevi"].ToString();
                Txt_BabaiseGirisTarihi.Text = read["BabaiseGirisTarihi"].ToString();
                Ddl_BabaEngelliMi.SelectedValue = read["BabaEngelliMi"].ToString();
                Ddl_AnneHayattaMi.SelectedValue = Ddl_AnneHayattaMi.SelectedValue = read["AnneHayattaMi"].ToString();
                Ddl_AnneGecimdenSorumluMu.SelectedValue = read["AnneGecimdenSorumluMu"].ToString();
                Txt_AnneAd.Text = read["AnneAd"].ToString();
                Txt_AnneSoyad.Text = read["AnneSoyad"].ToString();
                Txt_AnneTC.Text = read["AnneTC"].ToString();
                Txt_AnneDogumTarihi.Text = read["AnneDogumTarihi"].ToString();
                Ddl_AnneEmekliMi.SelectedValue = read["AnneEmekliMi"].ToString();
                Txt_AnneisyeriAdi.Text = read["AnneisyeriAdi"].ToString();
                Txt_AnneGorevi.Text = read["AnneGorevi"].ToString();
                Txt_AnneiseGirisTarihi.Text = read["AnneiseGirisTarihi"].ToString();
                Ddl_AnneEngelliMi.SelectedValue = read["AnneEngelliMi"].ToString();


            }
            if (Convert.ToInt32(Ddl_BabaHayattaMi.SelectedItem.Value) == 0)
            {
                Ddl_BabaEmekliMi.Enabled = false;
                Ddl_BabaEngelliMi.Enabled = false;
                Ddl_BabaGecimdenSorumluMu.Enabled = false;
                Txt_BabaAd.Enabled = false;
                Txt_BabaSoyad.Enabled = false;
                Txt_BabaTC.Enabled = false;
                Txt_BabaDogumTarihi.Enabled = false;
                Txt_BabaGorevi.Enabled = false;
                Txt_BabaiseGirisTarihi.Enabled = false;
                Txt_BabaisyeriAdi.Enabled = false;


            }
            if (Convert.ToInt32(Ddl_BabaHayattaMi.SelectedItem.Value) == 1)
            {
                Ddl_BabaEmekliMi.Enabled = true;
                Ddl_BabaEngelliMi.Enabled = true;
                Ddl_BabaGecimdenSorumluMu.Enabled = true;
                Txt_BabaAd.Enabled = true;
                Txt_BabaSoyad.Enabled = true;
                Txt_BabaTC.Enabled = true;
                Txt_BabaDogumTarihi.Enabled = true;
                Txt_BabaGorevi.Enabled = true;
                Txt_BabaiseGirisTarihi.Enabled = true;
                Txt_BabaisyeriAdi.Enabled = true;

            }

            if (Convert.ToInt32(Ddl_BabaHayattaMi.SelectedItem.Value) == -1)
            {
                Ddl_BabaEmekliMi.Enabled = true;
                Ddl_BabaEngelliMi.Enabled = true;
                Ddl_BabaGecimdenSorumluMu.Enabled = true;
                Txt_BabaAd.Enabled = true;
                Txt_BabaSoyad.Enabled = true;
                Txt_BabaTC.Enabled = true;
                Txt_BabaDogumTarihi.Enabled = true;
                Txt_BabaGorevi.Enabled = true;
                Txt_BabaiseGirisTarihi.Enabled = true;
                Txt_BabaisyeriAdi.Enabled = true;

            }
            if (Convert.ToInt32(Ddl_AnneHayattaMi.SelectedItem.Value) == 0)
            {
                Ddl_AnneEmekliMi.Enabled = false;
                Ddl_AnneEngelliMi.Enabled = false;
                Ddl_AnneGecimdenSorumluMu.Enabled = false;
                Txt_AnneAd.Enabled = false;
                Txt_AnneSoyad.Enabled = false;
                Txt_AnneTC.Enabled = false;
                Txt_AnneDogumTarihi.Enabled = false;
                Txt_AnneGorevi.Enabled = false;
                Txt_AnneiseGirisTarihi.Enabled = false;
                Txt_AnneisyeriAdi.Enabled = false;


            }

            if (Convert.ToInt32(Ddl_AnneHayattaMi.SelectedItem.Value) == 1)
            {
                Ddl_AnneEmekliMi.Enabled = true;
                Ddl_AnneEngelliMi.Enabled = true;
                Ddl_AnneGecimdenSorumluMu.Enabled = true;
                Txt_AnneAd.Enabled = true;
                Txt_AnneSoyad.Enabled = true;
                Txt_AnneTC.Enabled = true;
                Txt_AnneDogumTarihi.Enabled = true;
                Txt_AnneGorevi.Enabled = true;
                Txt_AnneiseGirisTarihi.Enabled = true;
                Txt_AnneisyeriAdi.Enabled = true;


            }

            if (Convert.ToInt32(Ddl_AnneHayattaMi.SelectedItem.Value) == -1)
            {
                Ddl_AnneEmekliMi.Enabled = true;
                Ddl_AnneEngelliMi.Enabled = true;
                Ddl_AnneGecimdenSorumluMu.Enabled = true;
                Txt_AnneAd.Enabled = true;
                Txt_AnneSoyad.Enabled = true;
                Txt_AnneTC.Enabled = true;
                Txt_AnneDogumTarihi.Enabled = true;
                Txt_AnneGorevi.Enabled = true;
                Txt_AnneiseGirisTarihi.Enabled = true;
                Txt_AnneisyeriAdi.Enabled = true;


            }

        }
        read.Close();
        SqlParameter QueryIdDiger = new SqlParameter();
        QueryIdDiger.ParameterName = "@QueryIdDiger";
        QueryIdDiger.Value = Convert.ToInt32(Request.QueryString["id"]);
        SqlCommand doldurDiger = new SqlCommand("select SehitGaziCocuguMu,SehitGazi,AnneBabaBosanmisMi,KardesSayisi from DigerAileBilgileri where KimlikId=@QueryIdDiger", con);
        doldurDiger.Parameters.Add(QueryIdDiger);
        SqlDataReader readDiger;
        readDiger = doldurDiger.ExecuteReader();


        if (!Page.IsPostBack)
        {

            while (readDiger.Read())
            {
                Btn_GelirBorcileri.Enabled = true;


                Ddl_SehitGaziCocuguMu.SelectedValue = readDiger["SehitGaziCocuguMu"].ToString();
                Ddl_SehitGazi.SelectedValue = readDiger["SehitGazi"].ToString();
                Ddl_AnneBabaBosanmisMi.SelectedValue = readDiger["AnneBabaBosanmisMi"].ToString();
                Ddl_KardesSayisi.SelectedValue = readDiger["KardesSayisi"].ToString();




            }
            if (Convert.ToInt32(Ddl_SehitGaziCocuguMu.SelectedItem.Value) == 0)
            {
                Ddl_SehitGazi.Enabled = false;
            }

            if (Convert.ToInt32(Ddl_SehitGaziCocuguMu.SelectedItem.Value) == 1)
            {
                Ddl_SehitGazi.Enabled = true;
            }
            if (Convert.ToInt32(Ddl_SehitGaziCocuguMu.SelectedItem.Value) == -1)
            {
                Ddl_SehitGazi.Enabled = true;
            }


        }

        con.Close();





    }

    protected void Ddl_BabaHayattaMi_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (Convert.ToInt32(Ddl_BabaHayattaMi.SelectedItem.Value) == 0)
        {
            Ddl_BabaEmekliMi.Enabled = false;
            Ddl_BabaEngelliMi.Enabled = false;
            Ddl_BabaGecimdenSorumluMu.Enabled = false;
            Txt_BabaAd.Enabled = false;
            Txt_BabaSoyad.Enabled = false;
            Txt_BabaTC.Enabled = false;
            Txt_BabaDogumTarihi.Enabled = false;
            Txt_BabaGorevi.Enabled = false;
            Txt_BabaiseGirisTarihi.Enabled = false;
            Txt_BabaisyeriAdi.Enabled = false;


        }
        if (Convert.ToInt32(Ddl_BabaHayattaMi.SelectedItem.Value) == 1)
        {
            Ddl_BabaEmekliMi.Enabled = true;
            Ddl_BabaEngelliMi.Enabled = true;
            Ddl_BabaGecimdenSorumluMu.Enabled = true;
            Txt_BabaAd.Enabled = true;
            Txt_BabaSoyad.Enabled = true;
            Txt_BabaTC.Enabled = true;
            Txt_BabaDogumTarihi.Enabled = true;
            Txt_BabaGorevi.Enabled = true;
            Txt_BabaiseGirisTarihi.Enabled = true;
            Txt_BabaisyeriAdi.Enabled = true;

        }

        if (Convert.ToInt32(Ddl_BabaHayattaMi.SelectedItem.Value) == -1)
        {
            Ddl_BabaEmekliMi.Enabled = true;
            Ddl_BabaEngelliMi.Enabled = true;
            Ddl_BabaGecimdenSorumluMu.Enabled = true;
            Txt_BabaAd.Enabled = true;
            Txt_BabaSoyad.Enabled = true;
            Txt_BabaTC.Enabled = true;
            Txt_BabaDogumTarihi.Enabled = true;
            Txt_BabaGorevi.Enabled = true;
            Txt_BabaiseGirisTarihi.Enabled = true;
            Txt_BabaisyeriAdi.Enabled = true;

        }
    }

    protected void Ddl_AnneHayattaMi_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Convert.ToInt32(Ddl_AnneHayattaMi.SelectedItem.Value) == 0)
        {
            Ddl_AnneEmekliMi.Enabled = false;
            Ddl_AnneEngelliMi.Enabled = false;
            Ddl_AnneGecimdenSorumluMu.Enabled = false;
            Txt_AnneAd.Enabled = false;
            Txt_AnneSoyad.Enabled = false;
            Txt_AnneTC.Enabled = false;
            Txt_AnneDogumTarihi.Enabled = false;
            Txt_AnneGorevi.Enabled = false;
            Txt_AnneiseGirisTarihi.Enabled = false;
            Txt_AnneisyeriAdi.Enabled = false;




        }

        if (Convert.ToInt32(Ddl_AnneHayattaMi.SelectedItem.Value) == 1)
        {
            Ddl_AnneEmekliMi.Enabled = true;
            Ddl_AnneEngelliMi.Enabled = true;
            Ddl_AnneGecimdenSorumluMu.Enabled = true;
            Txt_AnneAd.Enabled = true;
            Txt_AnneSoyad.Enabled = true;
            Txt_AnneTC.Enabled = true;
            Txt_AnneDogumTarihi.Enabled = true;
            Txt_AnneGorevi.Enabled = true;
            Txt_AnneiseGirisTarihi.Enabled = true;
            Txt_AnneisyeriAdi.Enabled = true;


        }

        if (Convert.ToInt32(Ddl_AnneHayattaMi.SelectedItem.Value) == -1)
        {
            Ddl_AnneEmekliMi.Enabled = true;
            Ddl_AnneEngelliMi.Enabled = true;
            Ddl_AnneGecimdenSorumluMu.Enabled = true;
            Txt_AnneAd.Enabled = true;
            Txt_AnneSoyad.Enabled = true;
            Txt_AnneTC.Enabled = true;
            Txt_AnneDogumTarihi.Enabled = true;
            Txt_AnneGorevi.Enabled = true;
            Txt_AnneiseGirisTarihi.Enabled = true;
            Txt_AnneisyeriAdi.Enabled = true;


        }
    }

    protected void Ddl_SehitGaziCocuguMu_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Convert.ToInt32(Ddl_SehitGaziCocuguMu.SelectedItem.Value) == 0)
        {
            Ddl_SehitGazi.Enabled = false;
        }

        if (Convert.ToInt32(Ddl_SehitGaziCocuguMu.SelectedItem.Value) == 1)
        {
            Ddl_SehitGazi.Enabled = true;
        }
        if (Convert.ToInt32(Ddl_SehitGaziCocuguMu.SelectedItem.Value) == -1)
        {
            Ddl_SehitGazi.Enabled = true;
        }
    }



    protected void Txt_BabaiseGirisTarihi_TextChanged(object sender, EventArgs e)
    {

    }



    protected void Btn_iletisimGeri_Click(object sender, EventArgs e)
    {
        int KimlikId = Convert.ToInt32(Request.QueryString["id"]);
        Response.Redirect("IletisimBilgileri.aspx?id=" + KimlikId);
    }

    protected void Btn_GelirBorcileri_Click(object sender, EventArgs e)
    {
        int KimlikId = Convert.ToInt32(Request.QueryString["id"]);
        Response.Redirect("GelirBorcBilgileri.aspx?id=" + KimlikId);
    }

    protected void Btn_AileBilgileriKaydet_Click(object sender, EventArgs e)
    {
        Btn_AileBilgileriKaydet.Visible = false;
        Btn_AileBilgileriGuncelle.Visible = true;
        Btn_GelirBorcileri.Enabled = true;
        SqlKomutları VeriCek_Aile = new SqlKomutları();

        VeriCek_Aile.EkleAile(Convert.ToInt32(Ddl_BabaHayattaMi.SelectedItem.Value), Convert.ToInt32(Ddl_BabaGecimdenSorumluMu.SelectedItem.Value), Txt_BabaAd.Text, Txt_BabaSoyad.Text, Txt_BabaTC.Text, Txt_BabaDogumTarihi.Text, Convert.ToInt32(Ddl_BabaEmekliMi.SelectedItem.Value), Txt_BabaisyeriAdi.Text, Txt_BabaGorevi.Text, Txt_BabaiseGirisTarihi.Text, Convert.ToInt32(Ddl_BabaEngelliMi.SelectedItem.Value), Convert.ToInt32(Ddl_AnneHayattaMi.SelectedItem.Value), Convert.ToInt32(Ddl_AnneGecimdenSorumluMu.SelectedItem.Value), Txt_AnneAd.Text, Txt_AnneSoyad.Text, Txt_AnneTC.Text, Txt_AnneDogumTarihi.Text, Convert.ToInt32(Ddl_AnneEmekliMi.SelectedItem.Value), Txt_AnneisyeriAdi.Text, Txt_AnneGorevi.Text, Txt_AnneiseGirisTarihi.Text, Convert.ToInt32(Ddl_AnneEngelliMi.SelectedItem.Value), Convert.ToInt32(Request.QueryString["id"]));
        VeriCek_Aile.EkleDigerAile(Convert.ToInt32(Ddl_SehitGaziCocuguMu.SelectedItem.Value), Convert.ToInt32(Ddl_SehitGazi.SelectedItem.Value), Convert.ToInt32(Ddl_AnneBabaBosanmisMi.SelectedItem.Value), Convert.ToInt32(Ddl_KardesSayisi.SelectedItem.Value), Convert.ToInt32(Request.QueryString["id"]));

    }


    protected void Btn_AileBilgileriGuncelle_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlParameter QueryId = new SqlParameter();
        QueryId.ParameterName = "@QueryId";
        QueryId.Value = Convert.ToInt32(Request.QueryString["id"]);

        SqlCommand guncelle = new SqlCommand("update AileBilgileri set BabaHayattaMi=@BabaHayattaMi,BabaGecimdenSorumluMu=@BabaGecimdenSorumluMu,BabaAd=@BabaAd,BabaSoyad=@BabaSoyad,BabaTC=@BabaTC,BabaDogumTarihi=@BabaDogumTarihi,BabaEmekliMi=@BabaEmekliMi,BabaisyeriAdi=@BabaisyeriAdi,BabaGorevi=@BabaGorevi,BabaiseGirisTarihi=@BabaiseGirisTarihi,BabaEngelliMi=@BabaEngelliMi,AnneHayattaMi=@AnneHayattaMi,AnneGecimdenSorumluMu=@AnneGecimdenSorumluMu,AnneAd=@AnneAd,AnneSoyad=@AnneSoyad,AnneTC=@AnneTC,AnneDogumTarihi=@AnneDogumTarihi,AnneEmekliMi=@AnneEmekliMi,AnneisyeriAdi=@AnneisyeriAdi,AnneGorevi=@AnneGorevi,AnneiseGirisTarihi=@AnneiseGirisTarihi,AnneEngelliMi=@AnneEngelliMi  where KimlikId=@QueryId", con);

        guncelle.Parameters.Add(QueryId);
        guncelle.Parameters.AddWithValue("@BabaHayattaMi", Ddl_BabaHayattaMi.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@BabaGecimdenSorumluMu", Ddl_BabaGecimdenSorumluMu.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@BabaAd", Txt_BabaAd.Text);
        guncelle.Parameters.AddWithValue("@BabaSoyad", Txt_BabaSoyad.Text);
        guncelle.Parameters.AddWithValue("@BabaTC", Txt_BabaTC.Text);
        guncelle.Parameters.AddWithValue("@BabaDogumTarihi", Txt_BabaDogumTarihi.Text);
        guncelle.Parameters.AddWithValue("@BabaEmekliMi", Ddl_BabaEmekliMi.Text);
        guncelle.Parameters.AddWithValue("@BabaisyeriAdi", Txt_BabaisyeriAdi.Text);
        guncelle.Parameters.AddWithValue("@BabaGorevi", Txt_BabaGorevi.Text);
        guncelle.Parameters.AddWithValue("@BabaiseGirisTarihi", Txt_BabaiseGirisTarihi.Text);
        guncelle.Parameters.AddWithValue("@BabaEngelliMi", Ddl_BabaEngelliMi.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@AnneHayattaMi", Ddl_AnneHayattaMi.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@AnneGecimdenSorumluMu", Ddl_AnneGecimdenSorumluMu.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@AnneAd", Txt_AnneAd.Text);
        guncelle.Parameters.AddWithValue("@AnneSoyad", Txt_AnneSoyad.Text);
        guncelle.Parameters.AddWithValue("@AnneTC", Txt_AnneTC.Text);
        guncelle.Parameters.AddWithValue("@AnneDogumTarihi", Txt_AnneDogumTarihi.Text);
        guncelle.Parameters.AddWithValue("@AnneEmekliMi", Ddl_AnneEmekliMi.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@AnneisyeriAdi", Txt_AnneisyeriAdi.Text);
        guncelle.Parameters.AddWithValue("@AnneGorevi", Txt_AnneGorevi.Text);
        guncelle.Parameters.AddWithValue("@AnneiseGirisTarihi", Txt_AnneiseGirisTarihi.Text);
        guncelle.Parameters.AddWithValue("@AnneEngelliMi", Ddl_AnneEngelliMi.SelectedItem.Value);


        guncelle.ExecuteNonQuery();
        SqlParameter QueryIdDiger = new SqlParameter();
        QueryIdDiger.ParameterName = "@QueryIdDiger";
        QueryIdDiger.Value = Convert.ToInt32(Request.QueryString["id"]);

        SqlCommand guncelleDiger = new SqlCommand("update DigerAileBilgileri set SehitGaziCocuguMu=@SehitGaziCocuguMu,SehitGazi=@SehitGazi,AnneBabaBosanmisMi=@AnneBabaBosanmisMi,KardesSayisi=@KardesSayisi  where KimlikId=@QueryIdDiger", con);

        guncelleDiger.Parameters.Add(QueryIdDiger);
        guncelleDiger.Parameters.AddWithValue("@SehitGaziCocuguMu", Ddl_SehitGaziCocuguMu.SelectedItem.Value);
        guncelleDiger.Parameters.AddWithValue("@SehitGazi", Ddl_SehitGazi.SelectedItem.Value);
        guncelleDiger.Parameters.AddWithValue("@AnneBabaBosanmisMi", Ddl_AnneBabaBosanmisMi.SelectedItem.Value);
        guncelleDiger.Parameters.AddWithValue("@KardesSayisi", Ddl_KardesSayisi.SelectedItem.Value);



        guncelleDiger.ExecuteNonQuery();




        con.Close();
    }
}