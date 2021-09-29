using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _KimlikBilgileri : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection("Data Source=MDEV01;Initial Catalog=BursTakip;Integrated Security=True;");
    public void Temizle()
    {
        Txt_Ad.Text = "";
        Txt_DogumTarihi.Text = "";
        Txt_Soyad.Text = "";
        Txt_TcKimlik.Text = "";
        Ddl_Cinsiyet.Text = "";
    }
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

            Ddl_DogumYeri.Items.Add(item);

        }

        con.Close();
        rd.Close();
        con.Open();
        SqlCommand SehirCek2 = new SqlCommand("Select * from SehirPlaka ", con);
        SehirCek2.ExecuteNonQuery();
        SqlDataReader dr = SehirCek2.ExecuteReader();

        while (dr.Read())
        {
            ListItem item = new ListItem();

            item.Text = dr["SehirAdi"].ToString();
            item.Value = dr["PlakaId"].ToString();


            Ddl_NufusKayitili.Items.Add(item);
        }

        con.Close();
        dr.Close();

        SqlParameter QueryId = new SqlParameter();
        QueryId.ParameterName = "@QueryId";
        QueryId.Value = Convert.ToInt32(Request.QueryString["id"]);
        if (Request.QueryString["id"] != null)
        {

            con.Open();
            SqlCommand doldur = new SqlCommand("select Ad,Soyad,TCKimlikNo,DogumTarihi,DogumYeri,NufusKayitili,Uyruk,Cinsiyet,MedeniHali,EngelDurumu from KimlikBilgileri where KimlikId=@QueryId", con);
            doldur.Parameters.Add(QueryId);
            SqlDataReader read;
            read = doldur.ExecuteReader();

            if (!Page.IsPostBack)
            {
                Btn_Egitimileri.Enabled = true;
                while (read.Read())
                {
                    Btn_KimlikKaydet.Visible = false; Btn_KimlikGuncelle.Visible = true;
                    Txt_Ad.Text = read["Ad"].ToString();
                    Txt_Soyad.Text = read["Soyad"].ToString();
                    Txt_TcKimlik.Text = read["TCKimlikNo"].ToString();
                    Txt_DogumTarihi.Text = read["DogumTarihi"].ToString();
                    Ddl_DogumYeri.SelectedValue = read["DogumYeri"].ToString();
                    Ddl_NufusKayitili.SelectedValue = read["NufusKayitili"].ToString();
                    Ddl_Uyruk.SelectedValue = read["Uyruk"].ToString();
                    Ddl_Cinsiyet.SelectedValue = read["Cinsiyet"].ToString();
                    Ddl_MedeniHal.SelectedValue = read["MedeniHali"].ToString();
                    Ddl_EngelDurumu.SelectedValue = read["EngelDurumu"].ToString();
                }
            }
            con.Close();

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Btn_Egitimileri.Enabled = true;
        Btn_KimlikKaydet.Visible = false;
        Btn_KimlikGuncelle.Visible = true;
        SqlKomutları VeriCekKimlik = new SqlKomutları();
        VeriCekKimlik.EkleKimlik(Txt_Ad.Text, Txt_Soyad.Text, Txt_TcKimlik.Text, Txt_DogumTarihi.Text, Convert.ToInt32(Ddl_DogumYeri.SelectedItem.Value), Convert.ToInt32(Ddl_NufusKayitili.SelectedItem.Value), Convert.ToBoolean(Ddl_Uyruk.SelectedIndex), Convert.ToBoolean(Ddl_Cinsiyet.SelectedIndex), Convert.ToBoolean(Ddl_MedeniHal.SelectedIndex), Convert.ToBoolean(Ddl_EngelDurumu.SelectedIndex));

    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Ddl_MedeniHal_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Ddl_EngelDurumu_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click6(object sender, EventArgs e)
    {
        Btn_KimlikGuncelle.Visible = true;
        Btn_KimlikKaydet.Visible = false;
        string KimlikId = "0";
        SqlConnection con = new SqlConnection("Data Source=MDEV01;Initial Catalog=BursTakip;Integrated Security=True;");
        con.Open();
        SqlCommand KimlikCek = new SqlCommand("select KimlikId from KimlikBilgileri", con);
        SqlDataReader rd;
        rd = KimlikCek.ExecuteReader();
        while (rd.Read())
        {
            KimlikId = rd["KimlikId"].ToString();
        }
        con.Close();

        Response.Redirect("EgitimBilgileri.aspx?id=" + KimlikId);
    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=MDEV01;Initial Catalog=BursTakip;Integrated Security=True;");
        con.Open();
        SqlParameter QueryId = new SqlParameter();
        QueryId.ParameterName = "@QueryId";
        QueryId.Value = Convert.ToInt32(Request.QueryString["id"]);

        SqlCommand guncelle = new SqlCommand("update KimlikBilgileri set Ad=@Ad,Soyad=@Soyad,TCKimlikNo=@TCKimlikNo,DogumTarihi=@DogumTarihi,DogumYeri=@DogumYeri,NufusKayitili=@NufusKayitili,Uyruk=@Uyruk,Cinsiyet=@Cinsiyet,MedeniHali=@MedeniHali,EngelDurumu=@EngelDurumu where KimlikId=@QueryId", con);

        guncelle.Parameters.Add(QueryId);
        guncelle.Parameters.AddWithValue("@Ad", Txt_Ad.Text);
        guncelle.Parameters.AddWithValue("@Soyad", Txt_Soyad.Text);
        guncelle.Parameters.AddWithValue("@TCKimlikNo", Txt_TcKimlik.Text);
        guncelle.Parameters.AddWithValue("@DogumTarihi", Txt_DogumTarihi.Text);
        guncelle.Parameters.AddWithValue("@DogumYeri", Ddl_DogumYeri.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@NufusKayitili", Ddl_NufusKayitili.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@Uyruk", Ddl_Uyruk.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@Cinsiyet", Ddl_Cinsiyet.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@MedeniHali", Ddl_MedeniHal.SelectedItem.Value);
        guncelle.Parameters.AddWithValue("@EngelDurumu", Ddl_EngelDurumu.SelectedItem.Value);
        guncelle.ExecuteNonQuery();
        con.Close();



    }

    protected void Ddl_DogumYeri_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Txt_DogumTarihi_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        string KimlikId = "0";
        SqlConnection con = new SqlConnection("Data Source=MDEV01;Initial Catalog=BursTakip;Integrated Security=True;");
        con.Open();
        SqlCommand KimlikCek = new SqlCommand("select KimlikId from KimlikBilgileri", con);
        SqlDataReader rd;
        rd = KimlikCek.ExecuteReader();
        while (rd.Read())
        {
            KimlikId = rd["KimlikId"].ToString();
        }
        con.Close();

        Response.Redirect("GelirBorcBilgileri.aspx?id=" + KimlikId);
    }

}