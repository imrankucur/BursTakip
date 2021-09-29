using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class IletisimBilgileri : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=MDEV01;Initial Catalog=BursTakip;Integrated Security=True;");
    protected void Page_Load(object sender, EventArgs e)
    {
        


        con.Open();

        SqlCommand SehirCek = new SqlCommand("Select * from SehirPlaka ", con);
        SehirCek.ExecuteNonQuery();
        SqlDataReader rd = SehirCek.ExecuteReader();

        while (rd.Read())
        {
            ListItem item = new ListItem();

            item.Text = rd["SehirAdi"].ToString();
            item.Value = rd["PlakaId"].ToString();
            Ddl_Aileikametili.Items.Add(item);




        }
        con.Close();
        rd.Close();

        SqlParameter QueryId = new SqlParameter();
        QueryId.ParameterName = "@QueryId";
        QueryId.Value = Convert.ToInt32(Request.QueryString["id"]);
        con.Open();
        SqlCommand doldur = new SqlCommand("select Aileikametili,Aileikametilcesi,Aileikametadresi,CepTelefonu,Eposta,BabaCepTelefonu,AnneCepTelefonu,BirinciKisiAd,BirinciKisiSoyad,BirinciKisiKurum,BirinciKisiUnvan,BirinciKisiTelefon,ikinciKisiAd,ikinciKisiSoyad,ikinciKisiKurum,ikinciKisiUnvan,ikinciKisiTelefon from IletisimBilgileri where KimlikId=@QueryId", con);
        doldur.Parameters.Add(QueryId);
        SqlDataReader read;
        read = doldur.ExecuteReader();


        if (!Page.IsPostBack)
        {
            Btn_IletisimGuncelle.Visible = false;
            while (read.Read())
            {
                Btn_Aileileri.Enabled = true;
                Btn_iletisimKaydet.Visible = false; Btn_IletisimGuncelle.Visible = true;
                Ddl_Aileikametili.SelectedValue = read["Aileikametili"].ToString();
                Txt_Gecici.Text = read["Aileikametilcesi"].ToString();
                Txt_Aileikametadresi.Text = read["Aileikametadresi"].ToString();
                Txt_CepTelefonu.Text = read["CepTelefonu"].ToString();
                Txt_Eposta.Text = read["Eposta"].ToString();
                Txt_BabaCepTelefonu.Text = read["BabaCepTelefonu"].ToString();
                Txt_AnneCepTelefonu.Text = read["AnneCepTelefonu"].ToString();
                Txt_BirinciKisiAd.Text = read["BirinciKisiAd"].ToString();
                Txt_BirinciKisiSoyad.Text= read["BirinciKisiSoyad"].ToString();
                Txt_BirinciKisiKurum.Text = read["BirinciKisiKurum"].ToString();
                Txt_BirinciKisiUnvan.Text = read["BirinciKisiUnvan"].ToString();
                Txt_BirinciKisiTelefon.Text = read["BirinciKisiTelefon"].ToString();
                Txt_ikinciKisiAd.Text = read["ikinciKisiAd"].ToString();
                Txt_ikinciKisiSoyad.Text = read["ikinciKisiSoyad"].ToString();
                Txt_ikinciKisiKurum.Text = read["ikinciKisiKurum"].ToString();
                Txt_ikinciKisiUnvan.Text = read["ikinciKisiUnvan"].ToString();
                Txt_ikinciKisiTelefon.Text = read["ikinciKisiTelefon"].ToString();



            }
            
            read.Close();
            
            SqlCommand ilce = new SqlCommand("Select * from ilcetablo", con);
            ilce.ExecuteNonQuery();
            SqlDataReader dr = ilce.ExecuteReader();
            

            while (dr.Read())
            {
                ListItem item = new ListItem();

                item.Text = dr["ilceAd"].ToString();
                item.Value = dr["ilceId"].ToString();
                string ilcebag = dr["ilcebag"].ToString();

                if (ilcebag == Ddl_Aileikametili.SelectedValue)

                {
                    Ddl_Aileikametilcesi.Items.Add(item);
                }




            }


            Ddl_Aileikametilcesi.SelectedValue = Txt_Gecici.Text;
        }


        con.Close();






    }

    protected void Ddl_Aileikametilçesi_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Ddl_Aileikametili_SelectedIndexChanged(object sender, EventArgs e)
    {
        Ddl_Aileikametilcesi.Items.Clear();
       
        con.Open();
        SqlCommand ilcecek = new SqlCommand("Select * from ilcetablo", con);
        ilcecek.ExecuteNonQuery();
        SqlDataReader rd = ilcecek.ExecuteReader();

        while (rd.Read())
        {
            ListItem item = new ListItem();

            item.Text = rd["ilceAd"].ToString();
            item.Value = rd["ilceId"].ToString();
            string ilcebag = rd["ilcebag"].ToString();

            if (ilcebag == Ddl_Aileikametili.SelectedItem.Value)
            {
                Ddl_Aileikametilcesi.Items.Add(item);
            }




        }
        con.Close();
        rd.Close();


    }

  

    protected void Txt_CepTelefonu_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Btn_EgitimGeri_Click(object sender, EventArgs e)
    {
        int KimlikId = Convert.ToInt32(Request.QueryString["id"]);
        Response.Redirect("EgitimBilgileri.aspx?id=" + KimlikId);
    }

 

    protected void Btn_Aileileri_Click(object sender, EventArgs e)
    {
        int KimlikId = Convert.ToInt32(Request.QueryString["id"]);
        Response.Redirect("AileBilgileri.aspx?id=" + KimlikId);
    }

    protected void Btn_IletisimGuncelle_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlParameter QueryId = new SqlParameter();
        QueryId.ParameterName = "@QueryId";
        QueryId.Value = Convert.ToInt32(Request.QueryString["id"]);

        SqlCommand guncelle = new SqlCommand("update IletisimBilgileri set Aileikametili=@Aileikametili,Aileikametilcesi=@Aileikametilcesi,Aileikametadresi=@Aileikametadresi,CepTelefonu=@CepTelefonu,Eposta=@Eposta,BabaCepTelefonu=@BabaCepTelefonu,AnneCepTelefonu=@AnneCepTelefonu,BirinciKisiAd=@BirinciKisiAd,BirinciKisiSoyad=@BirinciKisiSoyad,BirinciKisiKurum=@BirinciKisiKurum,BirinciKisiUnvan=@BirinciKisiUnvan,BirinciKisiTelefon=@BirinciKisiTelefon,ikinciKisiAd=@ikinciKisiAd,ikinciKisiSoyad=@ikinciKisiSoyad,ikinciKisiKurum=@ikinciKisiKurum,ikinciKisiUnvan=@ikinciKisiUnvan,ikinciKisiTelefon=@ikinciKisiTelefon where KimlikId=@QueryId", con);

        guncelle.Parameters.Add(QueryId);
        guncelle.Parameters.AddWithValue("@Aileikametili", Ddl_Aileikametili.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@Aileikametilcesi", Ddl_Aileikametilcesi.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@Aileikametadresi", Txt_Aileikametadresi.Text);
        guncelle.Parameters.AddWithValue("@CepTelefonu", Txt_CepTelefonu.Text);
        guncelle.Parameters.AddWithValue("@Eposta", Txt_Eposta.Text);
        guncelle.Parameters.AddWithValue("@BabaCepTelefonu", Txt_BabaCepTelefonu.Text);
        guncelle.Parameters.AddWithValue("@AnneCepTelefonu", Txt_AnneCepTelefonu.Text);
        guncelle.Parameters.AddWithValue("@BirinciKisiAd", Txt_BirinciKisiAd.Text);
        guncelle.Parameters.AddWithValue("@BirinciKisiSoyad", Txt_BirinciKisiSoyad.Text);
        guncelle.Parameters.AddWithValue("@BirinciKisiKurum", Txt_BirinciKisiKurum.Text);
        guncelle.Parameters.AddWithValue("@BirinciKisiUnvan", Txt_BirinciKisiUnvan.Text);
        guncelle.Parameters.AddWithValue("@BirinciKisiTelefon", Txt_BabaCepTelefonu.Text);
        guncelle.Parameters.AddWithValue("@ikinciKisiAd", Txt_ikinciKisiAd.Text);
        guncelle.Parameters.AddWithValue("@ikinciKisiSoyad", Txt_ikinciKisiSoyad.Text);
        guncelle.Parameters.AddWithValue("@ikinciKisiKurum", Txt_ikinciKisiKurum.Text);
        guncelle.Parameters.AddWithValue("@ikinciKisiUnvan", Txt_ikinciKisiUnvan.Text);
        guncelle.Parameters.AddWithValue("@ikinciKisiTelefon", Txt_ikinciKisiTelefon.Text);
      
        guncelle.ExecuteNonQuery();
        con.Close();
    }

    protected void Btn_iletisimKaydet_Click(object sender, EventArgs e)
    {
        Btn_iletisimKaydet.Visible = false;
        Btn_IletisimGuncelle.Visible = true;
        Btn_Aileileri.Enabled = true;
        SqlKomutları vericekiletisim = new SqlKomutları();


        vericekiletisim.Ekleiletisim(Convert.ToInt32(Ddl_Aileikametili.SelectedItem.Value), Convert.ToInt32(Ddl_Aileikametilcesi.SelectedItem.Value), Txt_Aileikametadresi.Text, Txt_CepTelefonu.Text, Txt_Eposta.Text, Txt_BabaCepTelefonu.Text, Txt_AnneCepTelefonu.Text, Txt_BirinciKisiAd.Text, Txt_BirinciKisiSoyad.Text, Txt_BirinciKisiKurum.Text, Txt_BirinciKisiUnvan.Text, Txt_BirinciKisiTelefon.Text, Txt_ikinciKisiAd.Text, Txt_ikinciKisiSoyad.Text, Txt_ikinciKisiKurum.Text, Txt_ikinciKisiUnvan.Text, Txt_ikinciKisiTelefon.Text, Convert.ToInt32(Request.QueryString["id"]));

        
    }
}