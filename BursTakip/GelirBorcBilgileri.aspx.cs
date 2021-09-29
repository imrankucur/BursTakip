using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class GelirBorcBilgileri : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=MDEV01;Initial Catalog=BursTakip;Integrated Security=True;");
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlParameter QueryId = new SqlParameter();
        QueryId.ParameterName = "@QueryId";
        QueryId.Value = Convert.ToInt32(Request.QueryString["id"]);
        con.Open();
        SqlCommand doldur = new SqlCommand("select BabaAylikGelir,BabaNafakaTutari,BabadanKalanOlumAyligi,AileDigerAylikGeliri,BabaToplamGelir,AileAylikKrediOdemesi,AnneAylikGelir,AnneNafakaTutari,AnnedenKalanOlumAyligi,AileDigerAylikGelirAciklamasi,AnneToplamGelir,OturulanEvinDurumu,EvKirasi,GayrimenkulVarMi,GayrimenkulCinsi,KayitliAracVarMi,AracCinsi from GelirBorcBilgileri where KimlikId=@QueryId", con);
        doldur.Parameters.Add(QueryId);
        SqlDataReader read;
        read = doldur.ExecuteReader();


        if (!Page.IsPostBack)
        {
            
            while (read.Read())
            {
                Txt_BabaAylikGelir.Text = read["BabaAylikGelir"].ToString();
                Txt_BabaNafakaTutari.Text = read["BabaNafakaTutari"].ToString();
                Txt_BabaOlumAyligi.Text = read["BabadanKalanOlumAyligi"].ToString();
                Txt_AileDigerAylikGeliri.Text = read["AileDigerAylikGeliri"].ToString();
                Txt_BabaToplamGelir.Text = read["BabaToplamGelir"].ToString();
                Txt_AileAylikKrediOdemesi.Text = read["AileAylikKrediOdemesi"].ToString();
                Txt_AnneAylikGelir.Text = read["AnneAylikGelir"].ToString();
                Txt_AnneNafakaTutari.Text = read["AnneNafakaTutari"].ToString();
                Txt_AnneKalanOlumAyligi.Text = read["AnnedenKalanOlumAyligi"].ToString();
                Txt_AileDigerGelirAciklama.Text = read["AileDigerAylikGelirAciklamasi"].ToString();
                Txt_AnneToplamGelir.Text = read["AnneToplamGelir"].ToString();
                Ddl_OturulanEvinDurumu.SelectedValue = read["OturulanEvinDurumu"].ToString();
                Txt_EvKirasi.Text = read["EvKirasi"].ToString();
                Ddl_GayrimenkulVarMi.SelectedValue = read["GayrimenkulVarMi"].ToString();
                Txt_GayrimenkulCinsi.Text = read["GayrimenkulCinsi"].ToString();
                Ddl_KayitliAracVarMi.SelectedValue = read["KayitliAracVarMi"].ToString();
                Txt_AracCinsi.Text = read["AracCinsi"].ToString();


            }
        }


        con.Close();








    }

    protected void Btn_AileGeri_Click(object sender, EventArgs e)
    {
        int KimlikId = Convert.ToInt32(Request.QueryString["id"]);
        Response.Redirect("AileBilgileri.aspx?id=" + KimlikId);
    }

    protected void Btn_GelirBorcKaydet_Click(object sender, EventArgs e)
    {
        
       
        SqlKomutları VeriCek_GelirBorc = new SqlKomutları();
        VeriCek_GelirBorc.EkleGelirBorc(!string.IsNullOrEmpty(Txt_BabaAylikGelir.Text) ? Convert.ToInt32(Txt_BabaAylikGelir.Text) : -2, !string.IsNullOrEmpty(Txt_BabaNafakaTutari.Text) ? Convert.ToInt32(Txt_BabaNafakaTutari.Text) : -2, !string.IsNullOrEmpty(Txt_BabaOlumAyligi.Text) ? Convert.ToInt32(Txt_BabaOlumAyligi.Text) : -2, !string.IsNullOrEmpty(Txt_AileDigerAylikGeliri.Text) ? Convert.ToInt32(Txt_AileDigerAylikGeliri.Text) : -2, !string.IsNullOrEmpty(Txt_BabaToplamGelir.Text) ? Convert.ToInt32(Txt_BabaToplamGelir.Text) : -2, !string.IsNullOrEmpty(Txt_AileAylikKrediOdemesi.Text) ? Convert.ToInt32(Txt_AileAylikKrediOdemesi.Text) : -2, !string.IsNullOrEmpty(Txt_AnneAylikGelir.Text) ? Convert.ToInt32(Txt_AnneAylikGelir.Text) : -2, !string.IsNullOrEmpty(Txt_AnneNafakaTutari.Text) ? Convert.ToInt32(Txt_AnneNafakaTutari.Text) : -2, !string.IsNullOrEmpty(Txt_AnneKalanOlumAyligi.Text) ? Convert.ToInt32(Txt_AnneKalanOlumAyligi.Text) : -2, Txt_AileDigerGelirAciklama.Text, !string.IsNullOrEmpty(Txt_AnneToplamGelir.Text) ? Convert.ToInt32(Txt_AnneToplamGelir.Text) : -2, Convert.ToInt32(Ddl_OturulanEvinDurumu.SelectedItem.Value), !string.IsNullOrEmpty(Txt_EvKirasi.Text) ? Convert.ToInt32(Txt_EvKirasi.Text) : -2, Convert.ToInt32(Ddl_GayrimenkulVarMi.SelectedItem.Value), Txt_GayrimenkulCinsi.Text, Convert.ToInt32(Ddl_KayitliAracVarMi.SelectedItem.Value), Txt_AracCinsi.Text, Convert.ToInt32(Request.QueryString["id"])); ;
    }

    protected void Ddl_GayrimenkulVarMi_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Convert.ToInt32(Ddl_GayrimenkulVarMi.SelectedItem.Value) == 0)
        {
            Txt_GayrimenkulCinsi.Enabled = false;
            Txt_GayrimenkulCinsi.Text = "";
        }
        else { Txt_GayrimenkulCinsi.Enabled = true; }
    }

    protected void Ddl_KayitliAracVarMi_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Convert.ToInt32(Ddl_KayitliAracVarMi.SelectedItem.Value) == 0)
        {
            Txt_AracCinsi.Enabled = false;
            Txt_AracCinsi.Text = "";
        }
        else { Txt_AracCinsi.Enabled = true; }
    }

    protected void Ddl_OturulanEvinDurumu_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Convert.ToInt32(Ddl_OturulanEvinDurumu.SelectedItem.Value) == 1)
        {
            Txt_EvKirasi.Enabled = false;
            Txt_EvKirasi.Text = "";
        }
        else { Txt_EvKirasi.Enabled = true; }
    }

    protected void Btn_GelirBorcGuncelle_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlParameter QueryId = new SqlParameter();
        QueryId.ParameterName = "@QueryId";
        QueryId.Value = Convert.ToInt32(Request.QueryString["id"]);

        SqlCommand guncelle = new SqlCommand("update GelirBorcBilgileri set BabaAylikGelir=@BabaAylikGelir,BabaNafakaTutari=@BabaNafakaTutari,BabadanKalanOlumAyligi=@BabadanKalanOlumAyligi,AileDigerAylikGeliri=@AileDigerAylikGeliri,BabaToplamGelir=@BabaToplamGelir,AileAylikKrediOdemesi=@AileAylikKrediOdemesi,AnneAylikGelir=@AnneAylikGelir,AnneNafakaTutari=@AnneNafakaTutari,AnnedenKalanOlumAyligi=@AnnedenKalanOlumAyligi,AileDigerAylikGelirAciklamasi=@AileDigerAylikGelirAciklamasi,AnneToplamGelir=@AnneToplamGelir,OturulanEvinDurumu=@OturulanEvinDurumu,EvKirasi=@EvKirasi,GayrimenkulVarMi=@GayrimenkulVarMi,GayrimenkulCinsi=@GayrimenkulCinsi,KayitliAracVarMi=@KayitliAracVarMi,AracCinsi=@AracCinsi  where KimlikId=@QueryId", con);

        guncelle.Parameters.Add(QueryId);
        if (!string.IsNullOrEmpty(Txt_BabaAylikGelir.Text))
        {
            guncelle.Parameters.AddWithValue("@BabaAylikGelir", Txt_BabaAylikGelir.Text);
        }
        else
        {
            guncelle.Parameters.AddWithValue("@BabaAylikGelir", DBNull.Value);
        }
        if (!string.IsNullOrEmpty(Txt_BabaNafakaTutari.Text))
        {
            guncelle.Parameters.AddWithValue("@BabaNafakaTutari", Txt_BabaNafakaTutari.Text);
        }
        else
        {
            guncelle.Parameters.AddWithValue("@BabaNafakaTutari", DBNull.Value);
        }
        if (!string.IsNullOrEmpty(Txt_BabaOlumAyligi.Text))
        {
            guncelle.Parameters.AddWithValue("@BabadanKalanOlumAyligi", Txt_BabaOlumAyligi.Text);
        }
        else
        {
            guncelle.Parameters.AddWithValue("@BabadanKalanOlumAyligi", DBNull.Value);
        }
        if (!string.IsNullOrEmpty(Txt_AileDigerAylikGeliri.Text))
        {
            guncelle.Parameters.AddWithValue("@AileDigerAylikGeliri", Txt_AileDigerAylikGeliri.Text);
        }
        else
        {
            guncelle.Parameters.AddWithValue("@AileDigerAylikGeliri", DBNull.Value);
        }
        if (!string.IsNullOrEmpty(Txt_BabaToplamGelir.Text))
        {
            guncelle.Parameters.AddWithValue("@BabaToplamGelir", Txt_BabaToplamGelir.Text);
        }
        else
        {
            guncelle.Parameters.AddWithValue("@BabaToplamGelir", DBNull.Value);
        }
        if (!string.IsNullOrEmpty(Txt_AileAylikKrediOdemesi.Text))
        {
            guncelle.Parameters.AddWithValue("@AileAylikKrediOdemesi", Txt_AileAylikKrediOdemesi.Text);
        }
        else
        {
            guncelle.Parameters.AddWithValue("@AileAylikKrediOdemesi", DBNull.Value);
        }
        if (!string.IsNullOrEmpty(Txt_AnneAylikGelir.Text))
        {
            guncelle.Parameters.AddWithValue("@AnneAylikGelir", Txt_AnneAylikGelir.Text);
        }
        else
        {
            guncelle.Parameters.AddWithValue("@AnneAylikGelir", DBNull.Value);
        }
        if (!string.IsNullOrEmpty(Txt_AnneNafakaTutari.Text))
        {
            guncelle.Parameters.AddWithValue("@AnneNafakaTutari", Txt_AnneNafakaTutari.Text);
        }
        else
        {
            guncelle.Parameters.AddWithValue("@AnneNafakaTutari", DBNull.Value);
        }
        if (!string.IsNullOrEmpty(Txt_AnneKalanOlumAyligi.Text))
        {
            guncelle.Parameters.AddWithValue("@AnnedenKalanOlumAyligi", Txt_AnneKalanOlumAyligi.Text);
        }
        else
        {
            guncelle.Parameters.AddWithValue("@AnnedenKalanOlumAyligi", DBNull.Value);
        }

        guncelle.Parameters.AddWithValue("@AileDigerAylikGelirAciklamasi", Txt_AileDigerGelirAciklama.Text);

        if (!string.IsNullOrEmpty(Txt_AnneToplamGelir.Text))
        {
            guncelle.Parameters.AddWithValue("@AnneToplamGelir", Txt_AnneToplamGelir.Text);
        }
        else
        {
            guncelle.Parameters.AddWithValue("@AnneToplamGelir", DBNull.Value);
        }

        guncelle.Parameters.AddWithValue("@OturulanEvinDurumu", Ddl_OturulanEvinDurumu.SelectedItem.Value);

        if (!string.IsNullOrEmpty(Txt_EvKirasi.Text))
        {
            guncelle.Parameters.AddWithValue("@EvKirasi", Txt_EvKirasi.Text);
        }
        else
        {
            guncelle.Parameters.AddWithValue("@EvKirasi", DBNull.Value);
        }
        guncelle.Parameters.AddWithValue("@GayrimenkulVarMi", Ddl_GayrimenkulVarMi.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@GayrimenkulCinsi", Txt_GayrimenkulCinsi.Text);
        guncelle.Parameters.AddWithValue("@KayitliAracVarMi", Ddl_KayitliAracVarMi.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@AracCinsi", Txt_AracCinsi.Text);
        guncelle.ExecuteNonQuery();

        con.Close();
    }
}