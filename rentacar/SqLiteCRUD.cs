using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
namespace rentacar 
{

public class DBCon 
  {

       public static SQLiteConnection BaglantiYap()
         {

                 return new SQLiteConnection(@"Data Source=RentACar.sqlite;");

         }

       public static SQLiteCommand KomutOlustur(string cmd)
         { 

              return string.IsNullOrEmpty(cmd) ? null : new SQLiteCommand(cmd, BaglantiYap());

         }

   }

    public class Nesneler_tblKullanicilar
         {
                 public Int32 KullaniciID { get; set; }
                 public String KullaniciAd { get; set; }
                 public String Sifre { get; set; }
         }

    public class Islemler_tblKullanicilar
    {

              public static string Kaydet(Nesneler_tblKullanicilar p)
                 {
                         string Mesaj="1";
                             try
                                {
                         SQLiteCommand cm = DBCon.KomutOlustur("insert into tblKullanicilar(KullaniciAd,Sifre)values (@KullaniciAd,@Sifre)");
                         cm.Parameters.AddWithValue("@KullaniciAd", p.KullaniciAd);
                         cm.Parameters.AddWithValue("@Sifre", p.Sifre);
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                                 }
                             catch(Exception hata)
                                 {
                                   Mesaj = hata.Message.ToString();
                                 }
                          return Mesaj;
                 }


              public static string Guncelle(Nesneler_tblKullanicilar p)
                 {
                         string Mesaj="1";
                             try
                                {
                         SQLiteCommand cm = DBCon.KomutOlustur("update tblKullanicilar set KullaniciAd=@KullaniciAd,Sifre=@Sifre where KullaniciID=@KullaniciID");
                         cm.Parameters.AddWithValue("@KullaniciAd", p.KullaniciAd);
                         cm.Parameters.AddWithValue("@Sifre", p.Sifre);
                         cm.Parameters.AddWithValue("@KullaniciID", p.KullaniciID);
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                                 }
                             catch(Exception hata)
                                 {
                                   Mesaj = hata.Message.ToString();
                                 }
                          return Mesaj;
                 }


              public static string Sil(int KullaniciID)
                 {
                         string Mesaj="1";
                             try
                                {
                         SQLiteCommand cm = DBCon.KomutOlustur("delete from tblKullanicilar where KullaniciID=@KullaniciID");
                         cm.Parameters.AddWithValue("@KullaniciID", KullaniciID);
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                                 }
                             catch(Exception hata)
                                 {
                                   Mesaj = hata.Message.ToString();
                                 }
                          return Mesaj;
                 }


              public static DataTable TumKayitlar()
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select * from tblKullanicilar",DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         return dt;
                 }


              public static DataTable VeriKumesi(string sql)
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter(sql, DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         return dt;
                 }


              public static double SkalarDeger(string sql)
                 {
                         SQLiteCommand cmd = new SQLiteCommand(sql, DBCon.BaglantiYap());
                         cmd.Connection.Open();
                         double sonuc=Convert.ToDouble(cmd.ExecuteScalar());
                         cmd.Connection.Close();
                         return sonuc;
                 }


              public static int SorguKayitSayi(string SQL)
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter(SQL, DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         int id=Convert.ToInt32(dt.Rows[0][0]);
                         return id;
                 }


              public static DataTable IdyeGoreKayitGetir(int KullaniciID)
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select * from tblKullanicilar where KullaniciID=@KullaniciID",DBCon.BaglantiYap());
                         da.SelectCommand.Parameters.AddWithValue("@KullaniciID",KullaniciID);
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         return dt;
                 }


              public static int SonKayitPK()
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select Max(KullaniciID) from tblKullanicilar", DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         int id=Convert.ToInt32(dt.Rows[0][0]);
                         return id;
                 }


              public static int ToplamKayitSayi()
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select count(*) from tblKullanicilar", DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         int id=Convert.ToInt32(dt.Rows[0][0]);
                         return id;
                 }


              public static string KomutIslet(string sql)
                 {
                         string Mesaj="1";
                         try
                             {
                         DBCon.BaglantiYap().Open();
                         SQLiteCommand cm =  DBCon.KomutOlustur(sql);
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                             }
                             catch(Exception hata)
                              {
                                   Mesaj = hata.Message.ToString();
                              }
                          return Mesaj;
                 }


              public static string tblKullanicilar_TumunuSil()
                 {
                         string Mesaj="1";
                         try
                             {
                         DBCon.BaglantiYap().Open();
                         SQLiteCommand cm =  DBCon.KomutOlustur("delete from tblKullanicilar");
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                             }
                             catch(Exception hata)
                              {
                                   Mesaj = hata.Message.ToString();
                              }
                          return Mesaj;
                 }


            public  static SQLiteDataReader DataReaderVeriGetir(string sql)
                 {
                         DBCon.BaglantiYap().Open();
                         SQLiteCommand cmd = DBCon.KomutOlustur(sql);
                         cmd.Connection.Open();
                         SQLiteDataReader dr = cmd.ExecuteReader();
                         return dr;
                 }


              public static Nesneler_tblKullanicilar IdyeGoreKayitGetirObject(int KullaniciID)
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select * from tblKullanicilar where KullaniciID=@KullaniciID",DBCon.BaglantiYap());
                         da.SelectCommand.Parameters.AddWithValue("@KullaniciID", KullaniciID);
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         if (dt.Rows.Count != 0)
                               {
                                    Nesneler_tblKullanicilar t = new Nesneler_tblKullanicilar();
                                    t.KullaniciID=Convert.ToInt32(dt.Rows[0]["KullaniciID"]);
                                    t.KullaniciAd=Convert.ToString(dt.Rows[0]["KullaniciAd"]);
                                    t.Sifre=Convert.ToString(dt.Rows[0]["Sifre"]);
                                    return t;
                               }
                         else { return null; }
                 }


    }


    public class Nesneler_MusteriTablosu
         {
                 public Int32 MusteriID { get; set; }
                 public String TcKimlikNo { get; set; }
                 public String Ad { get; set; }
                 public String Soyad { get; set; }
                 public String Cinsiyet { get; set; }
                 public String DogumTarihi { get; set; }
                 public String DogumYeri { get; set; }
                 public String Telefon { get; set; }
                 public String CepTelefonu { get; set; }
                 public String Mail { get; set; }
                 public String Adres { get; set; }
         }

    public class Islemler_MusteriTablosu
    {

              public static string Kaydet(Nesneler_MusteriTablosu p)
                 {
                         string Mesaj="1";
                             try
                                {
                         SQLiteCommand cm = DBCon.KomutOlustur("insert into MusteriTablosu(TcKimlikNo,Ad,Soyad,Cinsiyet,DogumTarihi,DogumYeri,Telefon,CepTelefonu,Mail,Adres)values (@TcKimlikNo,@Ad,@Soyad,@Cinsiyet,@DogumTarihi,@DogumYeri,@Telefon,@CepTelefonu,@Mail,@Adres)");
                         cm.Parameters.AddWithValue("@TcKimlikNo", p.TcKimlikNo);
                         cm.Parameters.AddWithValue("@Ad", p.Ad);
                         cm.Parameters.AddWithValue("@Soyad", p.Soyad);
                         cm.Parameters.AddWithValue("@Cinsiyet", p.Cinsiyet);
                         cm.Parameters.AddWithValue("@DogumTarihi", p.DogumTarihi);
                         cm.Parameters.AddWithValue("@DogumYeri", p.DogumYeri);
                         cm.Parameters.AddWithValue("@Telefon", p.Telefon);
                         cm.Parameters.AddWithValue("@CepTelefonu", p.CepTelefonu);
                         cm.Parameters.AddWithValue("@Mail", p.Mail);
                         cm.Parameters.AddWithValue("@Adres", p.Adres);
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                                 }
                             catch(Exception hata)
                                 {
                                   Mesaj = hata.Message.ToString();
                                 }
                          return Mesaj;
                 }


              public static string Guncelle(Nesneler_MusteriTablosu p)
                 {
                         string Mesaj="1";
                             try
                                {
                         SQLiteCommand cm = DBCon.KomutOlustur("update MusteriTablosu set TcKimlikNo=@TcKimlikNo,Ad=@Ad,Soyad=@Soyad,Cinsiyet=@Cinsiyet,DogumTarihi=@DogumTarihi,DogumYeri=@DogumYeri,Telefon=@Telefon,CepTelefonu=@CepTelefonu,Mail=@Mail,Adres=@Adres where MusteriID=@MusteriID");
                         cm.Parameters.AddWithValue("@TcKimlikNo", p.TcKimlikNo);
                         cm.Parameters.AddWithValue("@Ad", p.Ad);
                         cm.Parameters.AddWithValue("@Soyad", p.Soyad);
                         cm.Parameters.AddWithValue("@Cinsiyet", p.Cinsiyet);
                         cm.Parameters.AddWithValue("@DogumTarihi", p.DogumTarihi);
                         cm.Parameters.AddWithValue("@DogumYeri", p.DogumYeri);
                         cm.Parameters.AddWithValue("@Telefon", p.Telefon);
                         cm.Parameters.AddWithValue("@CepTelefonu", p.CepTelefonu);
                         cm.Parameters.AddWithValue("@Mail", p.Mail);
                         cm.Parameters.AddWithValue("@Adres", p.Adres);
                         cm.Parameters.AddWithValue("@MusteriID", p.MusteriID);
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                                 }
                             catch(Exception hata)
                                 {
                                   Mesaj = hata.Message.ToString();
                                 }
                          return Mesaj;
                 }


              public static string Sil(int MusteriID)
                 {
                         string Mesaj="1";
                             try
                                {
                         SQLiteCommand cm = DBCon.KomutOlustur("delete from MusteriTablosu where MusteriID=@MusteriID");
                         cm.Parameters.AddWithValue("@MusteriID", MusteriID);
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                                 }
                             catch(Exception hata)
                                 {
                                   Mesaj = hata.Message.ToString();
                                 }
                          return Mesaj;
                 }


              public static DataTable TumKayitlar()
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select * from MusteriTablosu",DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         return dt;
                 }


              public static DataTable VeriKumesi(string sql)
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter(sql, DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         return dt;
                 }


              public static double SkalarDeger(string sql)
                 {
                         SQLiteCommand cmd = new SQLiteCommand(sql, DBCon.BaglantiYap());
                         cmd.Connection.Open();
                         double sonuc=Convert.ToDouble(cmd.ExecuteScalar());
                         cmd.Connection.Close();
                         return sonuc;
                 }


              public static int SorguKayitSayi(string SQL)
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter(SQL, DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         int id=Convert.ToInt32(dt.Rows[0][0]);
                         return id;
                 }


              public static DataTable IdyeGoreKayitGetir(int MusteriID)
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select * from MusteriTablosu where MusteriID=@MusteriID",DBCon.BaglantiYap());
                         da.SelectCommand.Parameters.AddWithValue("@MusteriID",MusteriID);
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         return dt;
                 }


              public static int SonKayitPK()
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select Max(MusteriID) from MusteriTablosu", DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         int id=Convert.ToInt32(dt.Rows[0][0]);
                         return id;
                 }


              public static int ToplamKayitSayi()
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select count(*) from MusteriTablosu", DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         int id=Convert.ToInt32(dt.Rows[0][0]);
                         return id;
                 }


              public static string KomutIslet(string sql)
                 {
                         string Mesaj="1";
                         try
                             {
                         DBCon.BaglantiYap().Open();
                         SQLiteCommand cm =  DBCon.KomutOlustur(sql);
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                             }
                             catch(Exception hata)
                              {
                                   Mesaj = hata.Message.ToString();
                              }
                          return Mesaj;
                 }


              public static string MusteriTablosu_TumunuSil()
                 {
                         string Mesaj="1";
                         try
                             {
                         DBCon.BaglantiYap().Open();
                         SQLiteCommand cm =  DBCon.KomutOlustur("delete from MusteriTablosu");
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                             }
                             catch(Exception hata)
                              {
                                   Mesaj = hata.Message.ToString();
                              }
                          return Mesaj;
                 }


            public  static SQLiteDataReader DataReaderVeriGetir(string sql)
                 {
                         DBCon.BaglantiYap().Open();
                         SQLiteCommand cmd = DBCon.KomutOlustur(sql);
                         cmd.Connection.Open();
                         SQLiteDataReader dr = cmd.ExecuteReader();
                         return dr;
                 }


              public static Nesneler_MusteriTablosu IdyeGoreKayitGetirObject(int MusteriID)
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select * from MusteriTablosu where MusteriID=@MusteriID",DBCon.BaglantiYap());
                         da.SelectCommand.Parameters.AddWithValue("@MusteriID", MusteriID);
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         if (dt.Rows.Count != 0)
                               {
                                    Nesneler_MusteriTablosu m = new Nesneler_MusteriTablosu();
                                    m.MusteriID=Convert.ToInt32(dt.Rows[0]["MusteriID"]);
                                    m.TcKimlikNo=Convert.ToString(dt.Rows[0]["TcKimlikNo"]);
                                    m.Ad=Convert.ToString(dt.Rows[0]["Ad"]);
                                    m.Soyad=Convert.ToString(dt.Rows[0]["Soyad"]);
                                    m.Cinsiyet=Convert.ToString(dt.Rows[0]["Cinsiyet"]);
                                    m.DogumTarihi=Convert.ToString(dt.Rows[0]["DogumTarihi"]);
                                    m.DogumYeri=Convert.ToString(dt.Rows[0]["DogumYeri"]);
                                    m.Telefon=Convert.ToString(dt.Rows[0]["Telefon"]);
                                    m.CepTelefonu=Convert.ToString(dt.Rows[0]["CepTelefonu"]);
                                    m.Mail=Convert.ToString(dt.Rows[0]["Mail"]);
                                    m.Adres=Convert.ToString(dt.Rows[0]["Adres"]);
                                    return m;
                               }
                         else { return null; }
                 }


    }


    public class Nesneler_AracTablosu
         {
                 public Int32 AracID { get; set; }
                 public String Plaka { get; set; }
                 public String Marka { get; set; }
                 public String Tip { get; set; }
                 public String Model { get; set; }
                 public String Renk { get; set; }
                 public String Gunluk { get; set; }
                 public String Haftalik { get; set; }
                 public String Aylik { get; set; }
                
         }

    public class Islemler_AracTablosu
    {

              public static string Kaydet(Nesneler_AracTablosu p)
                 {
                         string Mesaj="1";
                             try
                                {
                         SQLiteCommand cm = DBCon.KomutOlustur("insert into AracTablosu(Plaka,Marka,Tip,Model,Renk,Gunluk,Haftalik,Aylik,)values (@Plaka,@Marka,@Tip,@Model,@Renk,@Gunluk,@Haftalik,@Aylik,@)");
                         cm.Parameters.AddWithValue("@Plaka", p.Plaka);
                         cm.Parameters.AddWithValue("@Marka", p.Marka);
                         cm.Parameters.AddWithValue("@Tip", p.Tip);
                         cm.Parameters.AddWithValue("@Model", p.Model);
                         cm.Parameters.AddWithValue("@Renk", p.Renk);
                         cm.Parameters.AddWithValue("@Gunluk", p.Gunluk);
                         cm.Parameters.AddWithValue("@Haftalik", p.Haftalik);
                         cm.Parameters.AddWithValue("@Aylik", p.Aylik);
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                                 }
                             catch(Exception hata)
                                 {
                                   Mesaj = hata.Message.ToString();
                                 }
                          return Mesaj;
                 }


              public static string Guncelle(Nesneler_AracTablosu p)
                 {
                         string Mesaj="1";
                             try
                                {
                         SQLiteCommand cm = DBCon.KomutOlustur("update AracTablosu set Plaka=@Plaka,Marka=@Marka,Tip=@Tip,Model=@Model,Renk=@Renk,Gunluk=@Gunluk,Haftalik=@Haftalik,Aylik=@Aylik,=@ where AracID=@AracID");
                         cm.Parameters.AddWithValue("@Plaka", p.Plaka);
                         cm.Parameters.AddWithValue("@Marka", p.Marka);
                         cm.Parameters.AddWithValue("@Tip", p.Tip);
                         cm.Parameters.AddWithValue("@Model", p.Model);
                         cm.Parameters.AddWithValue("@Renk", p.Renk);
                         cm.Parameters.AddWithValue("@Gunluk", p.Gunluk);
                         cm.Parameters.AddWithValue("@Haftalik", p.Haftalik);
                         cm.Parameters.AddWithValue("@Aylik", p.Aylik);
                         cm.Parameters.AddWithValue("@AracID", p.AracID);
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                                 }
                             catch(Exception hata)
                                 {
                                   Mesaj = hata.Message.ToString();
                                 }
                          return Mesaj;
                 }


              public static string Sil(int AracID)
                 {
                         string Mesaj="1";
                             try
                                {
                         SQLiteCommand cm = DBCon.KomutOlustur("delete from AracTablosu where AracID=@AracID");
                         cm.Parameters.AddWithValue("@AracID", AracID);
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                                 }
                             catch(Exception hata)
                                 {
                                   Mesaj = hata.Message.ToString();
                                 }
                          return Mesaj;
                 }


              public static DataTable TumKayitlar()
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select * from AracTablosu",DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         return dt;
                 }


              public static DataTable VeriKumesi(string sql)
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter(sql, DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         return dt;
                 }


              public static double SkalarDeger(string sql)
                 {
                         SQLiteCommand cmd = new SQLiteCommand(sql, DBCon.BaglantiYap());
                         cmd.Connection.Open();
                         double sonuc=Convert.ToDouble(cmd.ExecuteScalar());
                         cmd.Connection.Close();
                         return sonuc;
                 }


              public static int SorguKayitSayi(string SQL)
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter(SQL, DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         int id=Convert.ToInt32(dt.Rows[0][0]);
                         return id;
                 }


              public static DataTable IdyeGoreKayitGetir(int AracID)
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select * from AracTablosu where AracID=@AracID",DBCon.BaglantiYap());
                         da.SelectCommand.Parameters.AddWithValue("@AracID",AracID);
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         return dt;
                 }


              public static int SonKayitPK()
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select Max(AracID) from AracTablosu", DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         int id=Convert.ToInt32(dt.Rows[0][0]);
                         return id;
                 }


              public static int ToplamKayitSayi()
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select count(*) from AracTablosu", DBCon.BaglantiYap());
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         int id=Convert.ToInt32(dt.Rows[0][0]);
                         return id;
                 }


              public static string KomutIslet(string sql)
                 {
                         string Mesaj="1";
                         try
                             {
                         DBCon.BaglantiYap().Open();
                         SQLiteCommand cm =  DBCon.KomutOlustur(sql);
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                             }
                             catch(Exception hata)
                              {
                                   Mesaj = hata.Message.ToString();
                              }
                          return Mesaj;
                 }


              public static string AracTablosu_TumunuSil()
                 {
                         string Mesaj="1";
                         try
                             {
                         DBCon.BaglantiYap().Open();
                         SQLiteCommand cm =  DBCon.KomutOlustur("delete from AracTablosu");
                         cm.Connection.Open();
                         cm.ExecuteNonQuery();
                         cm.Connection.Close();
                             }
                             catch(Exception hata)
                              {
                                   Mesaj = hata.Message.ToString();
                              }
                          return Mesaj;
                 }


        /*    public  static SQLiteDataReader DataReaderVeriGetir(string sql)
                 {
                         DBCon.BaglantiYap().Open();
                         SQLiteCommand cmd = DBCon.KomutOlustur(sql);
                         cmd.Connection.Open();
                         SQLiteDataReader dr = cmd.ExecuteReader();
                         return dr;
                 }*/


              public static Nesneler_AracTablosu IdyeGoreKayitGetirObject(int AracID)
                 {
                         SQLiteDataAdapter da = new SQLiteDataAdapter("select * from AracTablosu where AracID=@AracID",DBCon.BaglantiYap());
                         da.SelectCommand.Parameters.AddWithValue("@AracID", AracID);
                         DataTable dt = new DataTable();
                         da.Fill(dt);
                         if (dt.Rows.Count != 0)
                               {
                                    Nesneler_AracTablosu a = new Nesneler_AracTablosu();
                                    a.AracID=Convert.ToInt32(dt.Rows[0]["AracID"]);
                                    a.Plaka=Convert.ToString(dt.Rows[0]["Plaka"]);
                                    a.Marka=Convert.ToString(dt.Rows[0]["Marka"]);
                                    a.Tip=Convert.ToString(dt.Rows[0]["Tip"]);
                                    a.Model=Convert.ToString(dt.Rows[0]["Model"]);
                                    a.Renk=Convert.ToString(dt.Rows[0]["Renk"]);
                                    a.Gunluk=Convert.ToString(dt.Rows[0]["Gunluk"]);
                                    a.Haftalik=Convert.ToString(dt.Rows[0]["Haftalik"]);
                                    a.Aylik=Convert.ToString(dt.Rows[0]["Aylik"]);
                                    return a;
                               }
                         else { return null; }
                 }


    }


}