using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// SqlKomutları için özet açıklama
/// </summary>


public class SqlKomutları
{
    SqlConnection con = new SqlConnection("Data Source=MDEV01;Initial Catalog=BursTakip;Integrated Security=True;");



    public void EkleKimlik(string Ad, string Soyad, string TCKimlikNo, string DogumTarihi, int DogumYeri, int NufusKayitili, bool Uyruk, bool Cinsiyet, bool MedeniHali, bool EngelDurumu)
    {


        con.Open();
        SqlCommand ekKimlik = new SqlCommand("insert into KimlikBilgileri (Ad,Soyad,TCKimlikNo,DogumTarihi,DogumYeri,NufusKayitili,Uyruk,Cinsiyet,MedeniHali,EngelDurumu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", con);
        ekKimlik.Parameters.AddWithValue("@p1", Ad);
        ekKimlik.Parameters.AddWithValue("@p2", Soyad);
        ekKimlik.Parameters.AddWithValue("@p3", TCKimlikNo);
        ekKimlik.Parameters.AddWithValue("@p4", DogumTarihi);
        ekKimlik.Parameters.AddWithValue("@p5", DogumYeri);
        ekKimlik.Parameters.AddWithValue("@p6", NufusKayitili);
        ekKimlik.Parameters.AddWithValue("@p7", Uyruk);
        ekKimlik.Parameters.AddWithValue("@p8", Cinsiyet);
        ekKimlik.Parameters.AddWithValue("@p9", MedeniHali);
        ekKimlik.Parameters.AddWithValue("@p10", EngelDurumu);
        ekKimlik.ExecuteNonQuery();
        con.Close();



    }

    public void EkleEgitim(int MezunLise, int Universite, int Fakulte, int Bolum, int Sinifi, int GirisYili, int YerlestirmePuanTuru, int YerlestirmePuani, int YerlestirmeTurkiyeSirasi, int KimlikId)
    {
        con.Open();


        SqlCommand ekEgitim = new SqlCommand("insert into EgitimBilgileri (MezunLise,Universite,Fakulte,Bolum,Sinifi,GirisYili,YerlestirmePuanTuru,YerlestirmePuani,YerlestirmeTurkiyeSirasi,KimlikId) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", con);

        ekEgitim.Parameters.AddWithValue("@p1", MezunLise);
        ekEgitim.Parameters.AddWithValue("@p2", Universite);
        ekEgitim.Parameters.AddWithValue("@p3", Fakulte);
        ekEgitim.Parameters.AddWithValue("@p4", Bolum);
        ekEgitim.Parameters.AddWithValue("@p5", Sinifi);
        ekEgitim.Parameters.AddWithValue("@p6", GirisYili);
        ekEgitim.Parameters.AddWithValue("@p7", YerlestirmePuanTuru);
        if (YerlestirmePuani == -2)
        {
            ekEgitim.Parameters.AddWithValue("@p8", DBNull.Value);

        }
        else
        {
            ekEgitim.Parameters.AddWithValue("@p8", YerlestirmePuani);

        }

        if (YerlestirmeTurkiyeSirasi == -2)
        {
            ekEgitim.Parameters.AddWithValue("@p9", DBNull.Value);

        }
        else
        {
            ekEgitim.Parameters.AddWithValue("@p9", YerlestirmeTurkiyeSirasi);

        }
        ekEgitim.Parameters.AddWithValue("@p10", KimlikId);

        ekEgitim.ExecuteNonQuery();

        con.Close();
    }



    public void Ekleiletisim(int Aileikametili, int Aileikametilcesi, string Aileikametadresi, string CepTelefonu, string Eposta, string BabaCepTelefonu, string AnneCepTelefonu, string BirinciKisiAd, string BirinciKisiSoyad, string BirinciKisiKurum, string BirinciKisiUnvan, string BirinciKisiTelefon, string ikinciKisiAd, string ikinciKisiSoyad, string ikinciKisiKurum, string ikinciKisiUnvan, string ikinciKisiTelefon, int KimlikId)
    {
        con.Open();


        SqlCommand ekiletisim = new SqlCommand("insert into IletisimBilgileri(Aileikametili,Aileikametilcesi,Aileikametadresi,CepTelefonu,Eposta,BabaCepTelefonu,AnneCepTelefonu,BirinciKisiAd,BirinciKisiSoyad,BirinciKisiKurum,BirinciKisiUnvan,BirinciKisiTelefon,ikinciKisiAd,ikinciKisiSoyad,ikinciKisiKurum,ikinciKisiUnvan,ikinciKisiTelefon,KimlikId) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18)", con);

        ekiletisim.Parameters.AddWithValue("@p1", Aileikametili);
        ekiletisim.Parameters.AddWithValue("@p2", Aileikametilcesi);
        ekiletisim.Parameters.AddWithValue("@p3", Aileikametadresi);
        ekiletisim.Parameters.AddWithValue("@p4", CepTelefonu);
        ekiletisim.Parameters.AddWithValue("@p5", Eposta);
        ekiletisim.Parameters.AddWithValue("@p6", BabaCepTelefonu);
        ekiletisim.Parameters.AddWithValue("@p7", AnneCepTelefonu);
        ekiletisim.Parameters.AddWithValue("@p8", BirinciKisiAd);
        ekiletisim.Parameters.AddWithValue("@p9", BirinciKisiSoyad);
        ekiletisim.Parameters.AddWithValue("@p10", BirinciKisiKurum);
        ekiletisim.Parameters.AddWithValue("@p11", BirinciKisiUnvan);
        ekiletisim.Parameters.AddWithValue("@p12", BirinciKisiTelefon);
        ekiletisim.Parameters.AddWithValue("@p13", ikinciKisiAd);
        ekiletisim.Parameters.AddWithValue("@p14", ikinciKisiSoyad);
        ekiletisim.Parameters.AddWithValue("@p15", ikinciKisiKurum);
        ekiletisim.Parameters.AddWithValue("@p16", ikinciKisiUnvan);
        ekiletisim.Parameters.AddWithValue("@p17", ikinciKisiTelefon);
        ekiletisim.Parameters.AddWithValue("@p18", KimlikId);

        ekiletisim.ExecuteNonQuery();

        con.Close();



    }

    public void EkleAile(int BabaHayattaMi, int BabaGecimdenSorumluMu, string BabaAd, string BabaSoyad, string BabaTC, string BabaDogumTarihi, int BabaEmekliMi, string BabaisyeriAdi, string BabaGorevi, string BabaiseGirisTarihi, int BabaEngelliMi, int AnneHayattaMi, int AnneGecimdenSorumluMu, string AnneAd, string AnneSoyad, string AnneTC, string AnneDogumTarihi, int AnneEmekliMi, string AnneisyeriAdi, string AnneGorevi, string AnneiseGirisTarihi, int AnneEngelliMi, int KimlikId)
    {
        if (BabaHayattaMi == 1 && AnneHayattaMi == 1)
        {
            con.Open();


            SqlCommand ekiletisim = new SqlCommand("insert into AileBilgileri (BabaHayattaMi,BabaGecimdenSorumluMu,BabaAd,BabaSoyad,BabaTC,BabaDogumTarihi,BabaEmekliMi,BabaisyeriAdi,BabaGorevi,BabaiseGirisTarihi,BabaEngelliMi,AnneHayattaMi,AnneGecimdenSorumluMu,AnneAd,AnneSoyad,AnneTC,AnneDogumTarihi,AnneEmekliMi,AnneisyeriAdi,AnneGorevi,AnneiseGirisTarihi,AnneEngelliMi,KimlikId) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23)", con);

            ekiletisim.Parameters.AddWithValue("@p1", BabaHayattaMi);
            ekiletisim.Parameters.AddWithValue("@p2", BabaGecimdenSorumluMu);
            ekiletisim.Parameters.AddWithValue("@p3", BabaAd);
            ekiletisim.Parameters.AddWithValue("@p4", BabaSoyad);
            ekiletisim.Parameters.AddWithValue("@p5", BabaTC);
            ekiletisim.Parameters.AddWithValue("@p6", BabaDogumTarihi);
            ekiletisim.Parameters.AddWithValue("@p7", BabaEmekliMi);
            ekiletisim.Parameters.AddWithValue("@p8", BabaisyeriAdi);
            ekiletisim.Parameters.AddWithValue("@p9", BabaGorevi);
            ekiletisim.Parameters.AddWithValue("@p10", BabaiseGirisTarihi);
            ekiletisim.Parameters.AddWithValue("@p11", BabaEngelliMi);
            ekiletisim.Parameters.AddWithValue("@p12", AnneHayattaMi);
            ekiletisim.Parameters.AddWithValue("@p13", AnneGecimdenSorumluMu);
            ekiletisim.Parameters.AddWithValue("@p14", AnneAd);
            ekiletisim.Parameters.AddWithValue("@p15", AnneSoyad);
            ekiletisim.Parameters.AddWithValue("@p16", AnneTC);
            ekiletisim.Parameters.AddWithValue("@p17", AnneDogumTarihi);
            ekiletisim.Parameters.AddWithValue("@p18", AnneEmekliMi);
            ekiletisim.Parameters.AddWithValue("@p19", AnneisyeriAdi);
            ekiletisim.Parameters.AddWithValue("@p20", AnneGorevi);
            ekiletisim.Parameters.AddWithValue("@p21", AnneiseGirisTarihi);
            ekiletisim.Parameters.AddWithValue("@p22", AnneEngelliMi);
            ekiletisim.Parameters.AddWithValue("@p23", KimlikId);





            ekiletisim.ExecuteNonQuery();

            con.Close();
        }
        else if (BabaHayattaMi == 1 && AnneHayattaMi == 0)
        {
            con.Open();
            SqlCommand ekiletisim = new SqlCommand("insert into AileBilgileri (BabaHayattaMi,BabaGecimdenSorumluMu,BabaAd,BabaSoyad,BabaTC,BabaDogumTarihi,BabaEmekliMi,BabaisyeriAdi,BabaGorevi,BabaiseGirisTarihi,BabaEngelliMi,AnneHayattaMi,AnneGecimdenSorumluMu,AnneAd,AnneSoyad,AnneTC,AnneDogumTarihi,AnneEmekliMi,AnneisyeriAdi,AnneGorevi,AnneiseGirisTarihi,AnneEngelliMi,KimlikId) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,@p13)", con);

            ekiletisim.Parameters.AddWithValue("@p1", BabaHayattaMi);
            ekiletisim.Parameters.AddWithValue("@p2", BabaGecimdenSorumluMu);
            ekiletisim.Parameters.AddWithValue("@p3", BabaAd);
            ekiletisim.Parameters.AddWithValue("@p4", BabaSoyad);
            ekiletisim.Parameters.AddWithValue("@p5", BabaTC);
            ekiletisim.Parameters.AddWithValue("@p6", BabaDogumTarihi);
            ekiletisim.Parameters.AddWithValue("@p7", BabaEmekliMi);
            ekiletisim.Parameters.AddWithValue("@p8", BabaisyeriAdi);
            ekiletisim.Parameters.AddWithValue("@p9", BabaGorevi);
            ekiletisim.Parameters.AddWithValue("@p10", BabaiseGirisTarihi);
            ekiletisim.Parameters.AddWithValue("@p11", BabaEngelliMi);
            ekiletisim.Parameters.AddWithValue("@p12", AnneHayattaMi);
            ekiletisim.Parameters.AddWithValue("@p13", KimlikId);


            ekiletisim.ExecuteNonQuery();

            con.Close();
        }
        else if (BabaHayattaMi == 0 && AnneHayattaMi == 1)
        {
            con.Open();


            SqlCommand ekiletisim = new SqlCommand("insert into AileBilgileri (BabaHayattaMi,BabaGecimdenSorumluMu,BabaAd,BabaSoyad,BabaTC,BabaDogumTarihi,BabaEmekliMi,BabaisyeriAdi,BabaGorevi,BabaiseGirisTarihi,BabaEngelliMi,AnneHayattaMi,AnneGecimdenSorumluMu,AnneAd,AnneSoyad,AnneTC,AnneDogumTarihi,AnneEmekliMi,AnneisyeriAdi,AnneGorevi,AnneiseGirisTarihi,AnneEngelliMi,KimlikId) values (@p1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23)", con);

            ekiletisim.Parameters.AddWithValue("@p1", BabaHayattaMi);
            ekiletisim.Parameters.AddWithValue("@p12", AnneHayattaMi);
            ekiletisim.Parameters.AddWithValue("@p13", AnneGecimdenSorumluMu);
            ekiletisim.Parameters.AddWithValue("@p14", AnneAd);
            ekiletisim.Parameters.AddWithValue("@p15", AnneSoyad);
            ekiletisim.Parameters.AddWithValue("@p16", AnneTC);
            ekiletisim.Parameters.AddWithValue("@p17", AnneDogumTarihi);
            ekiletisim.Parameters.AddWithValue("@p18", AnneEmekliMi);
            ekiletisim.Parameters.AddWithValue("@p19", AnneisyeriAdi);
            ekiletisim.Parameters.AddWithValue("@p20", AnneGorevi);
            ekiletisim.Parameters.AddWithValue("@p21", AnneiseGirisTarihi);
            ekiletisim.Parameters.AddWithValue("@p22", AnneEngelliMi);
            ekiletisim.Parameters.AddWithValue("@p23", KimlikId);

            ekiletisim.ExecuteNonQuery();

            con.Close();
        }
        else
        {
            con.Open();


            SqlCommand ekiletisim = new SqlCommand("insert into AileBilgileri (BabaHayattaMi,BabaGecimdenSorumluMu,BabaAd,BabaSoyad,BabaTC,BabaDogumTarihi,BabaEmekliMi,BabaisyeriAdi,BabaGorevi,BabaiseGirisTarihi,BabaEngelliMi,AnneHayattaMi,AnneGecimdenSorumluMu,AnneAd,AnneSoyad,AnneTC,AnneDogumTarihi,AnneEmekliMi,AnneisyeriAdi,AnneGorevi,AnneiseGirisTarihi,AnneEngelliMi,KimlikId) values (@p1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,@p12,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,@p13)", con);

            ekiletisim.Parameters.AddWithValue("@p1", BabaHayattaMi);

            ekiletisim.Parameters.AddWithValue("@p12", AnneHayattaMi);
            ekiletisim.Parameters.AddWithValue("@p13", KimlikId);


            ekiletisim.ExecuteNonQuery();

            con.Close();
        }


    }
    public void EkleDigerAile(int SehitGaziCocuguMu, int SehitGazi, int AnneBabaBosanmisMi, int KardesSayisi, int KimlikId)
    {

        if (SehitGaziCocuguMu == 1)
        {
            con.Open();
            SqlCommand ekDigerAile = new SqlCommand("insert into DigerAileBilgileri (SehitGaziCocuguMu,SehitGazi,AnneBabaBosanmisMi,KardesSayisi,KimlikId) values(@p1,@p2,@p3,@p4,@p5)", con);

            ekDigerAile.Parameters.AddWithValue("@p1", SehitGaziCocuguMu);
            ekDigerAile.Parameters.AddWithValue("@p2", SehitGazi);
            ekDigerAile.Parameters.AddWithValue("@p3", AnneBabaBosanmisMi);
            ekDigerAile.Parameters.AddWithValue("@p4", KardesSayisi);
            ekDigerAile.Parameters.AddWithValue("@p5", KimlikId);
            ekDigerAile.ExecuteNonQuery();
            con.Close();
        }
        else
        {
            con.Open();
            SqlCommand ekDigerAile = new SqlCommand("insert into DigerAileBilgileri (SehitGaziCocuguMu,SehitGazi,AnneBabaBosanmisMi,KardesSayisi,KimlikId) values(@p1,NULL,@p3,@p4,@p5)", con);

            ekDigerAile.Parameters.AddWithValue("@p1", SehitGaziCocuguMu);

            ekDigerAile.Parameters.AddWithValue("@p3", AnneBabaBosanmisMi);
            ekDigerAile.Parameters.AddWithValue("@p4", KardesSayisi);
            ekDigerAile.Parameters.AddWithValue("@p5", KimlikId);
            ekDigerAile.ExecuteNonQuery();
            con.Close();
        }


    }

    public void EkleGelirBorc(int BabaAylikGelir, int BabaNafakaTutari, int BabadanKalanOlumAyligi, int AileDigerAylikGeliri, int BabaToplamGelir, int AileAylikKrediOdemesi, int AnneAylikGelir, int AnneNafakaTutari, int AnnedenKalanOlumAyligi, string AileDigerAylikGelirAciklamasi, int AnneToplamGelir, int OturulanEvinDurumu, int EvKirasi, int GayrimenkulVarMi, string GayrimenkulCinsi, int KayitliAracVarMi, string AracCinsi, int KimlikId)
    {

        con.Open();
        SqlCommand ekGelirBorc = new SqlCommand("insert into GelirBorcBilgileri (BabaAylikGelir,BabaNafakaTutari,BabadanKalanOlumAyligi,AileDigerAylikGeliri,BabaToplamGelir,AileAylikKrediOdemesi,AnneAylikGelir,AnneNafakaTutari,AnnedenKalanOlumAyligi,AileDigerAylikGelirAciklamasi,AnneToplamGelir,OturulanEvinDurumu,EvKirasi,GayrimenkulVarMi,GayrimenkulCinsi,KayitliAracVarMi,AracCinsi,KimlikId) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18)", con);
        if (BabaAylikGelir == -2)
        {
            ekGelirBorc.Parameters.AddWithValue("@p1", DBNull.Value);
        }
        else
        {
            ekGelirBorc.Parameters.AddWithValue("@p1", BabaAylikGelir);
        }
        if (BabaNafakaTutari == -2)
        {
            ekGelirBorc.Parameters.AddWithValue("@p2", DBNull.Value);
        }
        else
        {
            ekGelirBorc.Parameters.AddWithValue("@p2", BabaNafakaTutari);

        }
            if (BabadanKalanOlumAyligi == -2)
            {
                ekGelirBorc.Parameters.AddWithValue("@p3", DBNull.Value);
            }
            else
            {
                ekGelirBorc.Parameters.AddWithValue("@p3", BabadanKalanOlumAyligi);
            }
            if (AileDigerAylikGeliri == -2)
            {
                ekGelirBorc.Parameters.AddWithValue("@p4", DBNull.Value);

            }
            else
            {
                ekGelirBorc.Parameters.AddWithValue("@p4", AileDigerAylikGeliri);

            }
            if (BabaToplamGelir == -2)
            {
                ekGelirBorc.Parameters.AddWithValue("@p5", DBNull.Value);

            }
            else
            {
                ekGelirBorc.Parameters.AddWithValue("@p5", BabaToplamGelir);

            }
            if (AileAylikKrediOdemesi == -2)
            {
                ekGelirBorc.Parameters.AddWithValue("@p6", DBNull.Value);

            }
            else
            {
                ekGelirBorc.Parameters.AddWithValue("@p6", AileAylikKrediOdemesi);

            }
            if (AnneAylikGelir == -2)
            {
                ekGelirBorc.Parameters.AddWithValue("@p7", DBNull.Value);

            }
            else
            {
                ekGelirBorc.Parameters.AddWithValue("@p7", AnneAylikGelir);
            }
            if (AnneNafakaTutari == -2)
            {
                ekGelirBorc.Parameters.AddWithValue("@p8", DBNull.Value);

            }
            else
            {
                ekGelirBorc.Parameters.AddWithValue("@p8", AnneNafakaTutari);

            }
            if (AnnedenKalanOlumAyligi == -2)
            {
                ekGelirBorc.Parameters.AddWithValue("@p9", DBNull.Value);

            }
            else
            {
                ekGelirBorc.Parameters.AddWithValue("@p9", AnnedenKalanOlumAyligi);

            }
            ekGelirBorc.Parameters.AddWithValue("@p10", AileDigerAylikGelirAciklamasi);
            if (AnneToplamGelir == -2)
            {
                ekGelirBorc.Parameters.AddWithValue("@p11", DBNull.Value);

            }
            else
            {
                ekGelirBorc.Parameters.AddWithValue("@p11", AnneToplamGelir);

            }
            ekGelirBorc.Parameters.AddWithValue("@p12", OturulanEvinDurumu);
            if (EvKirasi == -2)
            {
                ekGelirBorc.Parameters.AddWithValue("@p13", DBNull.Value);
            }
            else
            {
                ekGelirBorc.Parameters.AddWithValue("@p13", EvKirasi);
            }

            ekGelirBorc.Parameters.AddWithValue("@p14", GayrimenkulVarMi);
            ekGelirBorc.Parameters.AddWithValue("@p15", GayrimenkulCinsi);
            ekGelirBorc.Parameters.AddWithValue("@p16", KayitliAracVarMi);
            ekGelirBorc.Parameters.AddWithValue("@p17", AracCinsi);
            ekGelirBorc.Parameters.AddWithValue("@p18", KimlikId);

            ekGelirBorc.ExecuteNonQuery();

            con.Close();



        }
    }










