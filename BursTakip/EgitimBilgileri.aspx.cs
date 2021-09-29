using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class EgitimBilgileri : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=MDEV01;Initial Catalog=BursTakip;Integrated Security=True;");
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 1998; i <= 2023; i++)
        {
            ListItem item = new ListItem();
            item.Value = i.ToString();

            Ddl_GirisYili.Items.Add(item);
        }
        con.Open();

        SqlCommand UniCek = new SqlCommand("Select * from UniversiteList", con);
        UniCek.ExecuteNonQuery();
        SqlDataReader rd = UniCek.ExecuteReader();

        while (rd.Read())
        {
            ListItem item = new ListItem();

            item.Text = rd["UniAdi"].ToString();
            item.Value = rd["UniId"].ToString();

            Ddl_Universite.Items.Add(item);

        }
        con.Close();
        rd.Close();


        SqlParameter QueryId = new SqlParameter();
        QueryId.ParameterName = "@QueryId";
        QueryId.Value = Convert.ToInt32(Request.QueryString["id"]);
        con.Open();
        SqlCommand doldur = new SqlCommand("select MezunLise,Universite,Fakulte,Bolum,Sinifi,GirisYili,YerlestirmePuanTuru,YerlestirmePuani,YerlestirmeTurkiyeSirasi from EgitimBilgileri where KimlikId=@QueryId", con);
        doldur.Parameters.Add(QueryId);
        SqlDataReader read;
        read = doldur.ExecuteReader();


        if (!Page.IsPostBack)
        {

            while (read.Read())
            {
                Button2.Enabled = true;
                Btn_EgitimKaydet.Visible = false; Btn_EgitimGuncelle.Visible = true;
                Ddl_MezunLise.SelectedValue = read["MezunLise"].ToString();
                Ddl_Universite.SelectedValue = read["Universite"].ToString();
                Ddl_Fakulte.SelectedValue = read["Fakulte"].ToString();
                Ddl_Bolum.SelectedValue = read["Bolum"].ToString();
                Ddl_Sinifi.SelectedValue = read["Sinifi"].ToString();
                Ddl_GirisYili.SelectedValue = read["GirisYili"].ToString();
                Ddl_PuanTuru.SelectedValue = read["YerlestirmePuanTuru"].ToString();
                Txt_YerlestirmePuani.Text = read["YerlestirmePuani"].ToString();
                Txt_YerlestirmeSirasi.Text = read["YerlestirmeTurkiyeSirasi"].ToString();


            }
        }


        con.Close();









    }



    protected void Btn_SiradakiSayfaEgitim_Click(object sender, EventArgs e)
    {
        SqlKomutları VeriCek_Egitim = new SqlKomutları();

        VeriCek_Egitim.EkleEgitim(Convert.ToInt32(Ddl_MezunLise.SelectedItem.Value), Convert.ToInt32(Ddl_Universite.SelectedItem.Value), Convert.ToInt32(Ddl_Fakulte.SelectedItem.Value), Convert.ToInt32(Ddl_Bolum.SelectedItem.Value), Convert.ToInt32(Ddl_Sinifi.SelectedItem.Value), Convert.ToInt32(Ddl_GirisYili.SelectedItem.Value), Convert.ToInt32(Ddl_PuanTuru.SelectedItem.Value), Convert.ToInt32(Txt_YerlestirmePuani.Text), Convert.ToInt32(Txt_YerlestirmeSirasi.Text), Convert.ToInt32(Request.QueryString["id"]));




    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("KimlikBilgileri.aspx");
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

        string KimlikId = Request.QueryString["id"];

        Response.Redirect("KimlikBilgileri.aspx?id=" + KimlikId);



    }

    protected void Btn_EgitimKaydet_Click(object sender, EventArgs e)
    {
        Button2.Enabled = true;
        Btn_EgitimKaydet.Visible = false;
        Btn_EgitimGuncelle.Visible = true;
        SqlKomutları VeriCek_Egitim = new SqlKomutları();

        VeriCek_Egitim.EkleEgitim(Convert.ToInt32(Ddl_MezunLise.SelectedItem.Value), Convert.ToInt32(Ddl_Universite.SelectedItem.Value), Convert.ToInt32(Ddl_Fakulte.SelectedItem.Value), Convert.ToInt32(Ddl_Bolum.SelectedItem.Value), Convert.ToInt32(Ddl_Sinifi.SelectedItem.Value), Convert.ToInt32(Ddl_GirisYili.SelectedItem.Value), Convert.ToInt32(Ddl_PuanTuru.SelectedItem.Value), !string.IsNullOrEmpty(Txt_YerlestirmePuani.Text) ? Convert.ToInt32(Txt_YerlestirmePuani.Text) : -2, !string.IsNullOrEmpty(Txt_YerlestirmeSirasi.Text) ? Convert.ToInt32(Txt_YerlestirmeSirasi.Text) : -2, Convert.ToInt32(Request.QueryString["id"]));

    }

    protected void Btn_EgitimGuncelle_Click(object sender, EventArgs e)
    {

        con.Open();
        SqlParameter QueryId = new SqlParameter();
        QueryId.ParameterName = "@QueryId";
        QueryId.Value = Convert.ToInt32(Request.QueryString["id"]);

        SqlCommand guncelle = new SqlCommand("update EgitimBilgileri set MezunLise=@MezunLise,Universite=@Universite,Fakulte=@Fakulte,Bolum=@Bolum,Sinifi=@Sinifi,GirisYili=@GirisYili,YerlestirmePuanTuru=@YerlestirmePuanTuru,YerlestirmePuani=@YerlestirmePuani,YerlestirmeTurkiyeSirasi=@YerlestirmeTurkiyeSirasi where KimlikId=@QueryId", con);

        guncelle.Parameters.Add(QueryId);
        guncelle.Parameters.AddWithValue("@MezunLise", Ddl_MezunLise.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@Universite", Ddl_Universite.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@Fakulte", Ddl_Fakulte.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@Bolum", Ddl_Bolum.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@Sinifi", Ddl_Sinifi.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@GirisYili", Ddl_GirisYili.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@YerlestirmePuanTuru", Ddl_PuanTuru.SelectedItem.Value);
        if (!string.IsNullOrEmpty(Txt_YerlestirmePuani.Text))
        {
            guncelle.Parameters.AddWithValue("@YerlestirmePuani", Txt_YerlestirmePuani.Text);
        }
        else
        {
            guncelle.Parameters.AddWithValue("@YerlestirmePuani",DBNull.Value);
        }
        if (!string.IsNullOrEmpty(Txt_YerlestirmeSirasi.Text))
        {
            guncelle.Parameters.AddWithValue("@YerlestirmeTurkiyeSirasi", Txt_YerlestirmeSirasi.Text);
        }
        else
        {
            guncelle.Parameters.AddWithValue("@YerlestirmeTurkiyeSirasi", DBNull.Value);
        }
        guncelle.ExecuteNonQuery();
        con.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int KimlikId = Convert.ToInt32(Request.QueryString["id"]);
        Response.Redirect("IletisimBilgileri.aspx?id=" + KimlikId);
    }
}