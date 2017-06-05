using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace rentacar
{
    class engine
    {
        public bool GirisKontrol(string KullaniciAd, string Sifre)
        {
            string yol = "Data Source=RentACar.sqlite";
            SQLiteConnection con = new SQLiteConnection(yol);
            con.Open();
            string sql = "select * from tblKullanicilar where KullaniciAd=@KullaniciAd and Sifre =@Sifre";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
            adp.SelectCommand.Parameters.AddWithValue("@Sifre", Sifre);
            DataTable dt = new DataTable();
            adp.Fill(dt);  // gelen kayıtları data table içinde tutar
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
        SQLiteConnection baglanti()
        {
            SQLiteConnection baglan = new SQLiteConnection();
            baglan.ConnectionString = "Data Source=RentACar.sqlite";
            baglan.Open();
            return baglan;

        }
        public void KisiKaydet(string TcKimlikNo, string Ad,string Soyad, string Cinsiyet, string DogumTarihi,string DogumYeri, string Telefon,string CepTelefonu,string Mail, string Adres,string EhliyetNo,string EhliyetTarihi,string EhliyetVerilenYer)
        {
            string sql = "insert into MusteriTablosu(TcKimlikNo,Ad,Soyad,Cinsiyet,DogumTarihi,DogumYeri,Telefon,CepTelefonu,Mail,Adres,EhliyetNo,EhliyetTarihi,EhliyetVerilenYer)";
            sql += "values(@TcKimlikNo,@Ad,@Soyad,@Cinsiyet,@DogumTarihi,@DogumYeri,@Telefon,@CepTelefonu,@Mail,@Adres,@EhliyetNo,@EhliyetTarihi,@EhliyetVerilenYer)";
            SQLiteCommand komut = new SQLiteCommand(sql, baglanti());
            komut.Parameters.AddWithValue("@TcKimlikNo", TcKimlikNo);
            komut.Parameters.AddWithValue("@Ad", Ad);
            komut.Parameters.AddWithValue("@Soyad", Soyad);
            komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
            komut.Parameters.AddWithValue("@DogumTarihi",DogumTarihi);
            komut.Parameters.AddWithValue("@DogumYeri", DogumYeri);
            komut.Parameters.AddWithValue("@Telefon", Telefon);
            komut.Parameters.AddWithValue("@CepTelefonu", CepTelefonu);
            komut.Parameters.AddWithValue("@Mail", Mail);
            komut.Parameters.AddWithValue("@Adres", Adres);
            komut.Parameters.AddWithValue("@EhliyetNo", EhliyetNo);
            komut.Parameters.AddWithValue("@EhliyetTarihi", EhliyetTarihi);
            komut.Parameters.AddWithValue("@EhliyetVerilenYer", EhliyetVerilenYer);
            komut.ExecuteNonQuery();
            baglanti().Close();
        }
        public void AracKaydet(string Plaka, string Marka, string Tip, string Model, string Renk, string Gunluk, string Haftalik, string Aylik)
        {
            string sql = "insert into AracTablosu(Plaka,Marka,Tip,Model,Renk,Gunluk,Haftalik,Aylik)";
            sql += "values(@Plaka,@Marka,@Tip,@Model,@Renk,@Gunluk,@Haftalik,@Aylik)";
            SQLiteCommand komut = new SQLiteCommand(sql, baglanti());
            komut.Parameters.AddWithValue("@Plaka", Plaka);
            komut.Parameters.AddWithValue("@Marka", Marka);
            komut.Parameters.AddWithValue("@Tip", Tip);
            komut.Parameters.AddWithValue("@Model", Model);
            komut.Parameters.AddWithValue("@Renk", Renk);
            komut.Parameters.AddWithValue("@Gunluk", Gunluk);
            komut.Parameters.AddWithValue("@Haftalik", Haftalik);
            komut.Parameters.AddWithValue("@Aylik", Aylik);
            komut.ExecuteNonQuery();
            baglanti().Close();
        }
        public void KisiSil(string TcKimlikNo)
        {
            string sql = " delete from MusteriTablosu Where TcKimlikNo =@TcKimlikNo";
            SQLiteCommand komut = new SQLiteCommand(sql, baglanti());
            komut.Parameters.AddWithValue("@TcKimlikNo", TcKimlikNo);
            komut.ExecuteNonQuery();
            baglanti().Close();

        }
        public void AracSil(string Plaka)
        {
            string sql = " delete from AracTablosu Where Plaka =@Plaka";
            SQLiteCommand komut = new SQLiteCommand(sql, baglanti());
            komut.Parameters.AddWithValue("@Plaka", Plaka);
            komut.ExecuteNonQuery();
            baglanti().Close();

        }
        public void KisiDuzelt(string TcKimlikNo, string Ad, string Soyad,string Cinsiyet, string DogumTarihi, string DogumYeri, string Telefon, string CepTelefonu, string Mail,string Adres,int MusteriID)
        {
            // Kisileri düzeneme Metodu 
            string sql = "Update  MusteriTablosu set TcKimlikNo=@TcKimlikNo,Ad=@Ad,Soyad=@Soyad,Cinsiyet=@Cinsiyet,DogumTarihi=@DogumTarihi,DogumYeri=@DogumYeri,Telefon=@Telefon,CepTelefonu=@CepTelefonu, Mail=@Mail,Adres=@Adres where MusteriID=@MusteriID "; 

            SQLiteCommand komut = new SQLiteCommand(sql, baglanti());
            komut.Parameters.AddWithValue("@TcKimlikNo", TcKimlikNo);
            komut.Parameters.AddWithValue("@Ad", Ad);
            komut.Parameters.AddWithValue("@Soyad", Soyad);
            komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
            komut.Parameters.AddWithValue("@DogumTarihi", DogumTarihi);
            komut.Parameters.AddWithValue("@DogumYeri", DogumYeri);
            komut.Parameters.AddWithValue("@Telefon", Telefon);
            komut.Parameters.AddWithValue("@CepTelefonu", CepTelefonu);
            komut.Parameters.AddWithValue("@Mail", Mail);
            komut.Parameters.AddWithValue("@Adres", Adres);
            komut.Parameters.AddWithValue("@MusteriID", MusteriID);
            komut.ExecuteNonQuery();
            baglanti().Close();

        }
        public DataTable KisiBul(string TcKimlikNo)
        {
            string sql = "select * From MusteriTablosu Where TcKimlikNo=@TcKimlikNo";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, baglanti());
            adp.SelectCommand.Parameters.AddWithValue("@TcKimlikNo", TcKimlikNo);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            baglanti().Close();
            return dt;
        }
        public DataTable TumKisiler()
        {
            string sql = "select * from MusteriTablosu order by TcKimlikNo";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, baglanti());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            baglanti().Close();
            return dt;
        }
        public DataTable TumAraclar()
        {
            string sql = "select * from AracTablosu order by Plaka";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, baglanti());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            baglanti().Close();
            return dt;
        }  
    }
}
