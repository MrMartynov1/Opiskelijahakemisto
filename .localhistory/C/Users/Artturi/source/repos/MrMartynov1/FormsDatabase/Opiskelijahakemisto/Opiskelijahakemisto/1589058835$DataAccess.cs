using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Opiskelijahakemisto
{
    public class DataAccess
    {
        public List<Opiskelija> HaeOpiskelijat(string sukunimi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var output = connection.Query<Opiskelija>("dbo.Opiskelija_By_LastName @Sukunimi", new { Sukunimi = sukunimi }).ToList();
                return output;
            }
        }

        public List<Kurssi> HaeKurssi(string nimi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var output = connection.Query<Kurssi>("dbo.Kurssi_By_Nimi @Nimi", new { Nimi = nimi }).ToList();
                return output;
            }
        }

        public List<Koe> HaeKoe(string koenimi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var output = connection.Query<Koe>("dbo.Opiskelija_By_LastName @Sukunimi", new { Sukunimi = koenimi }).ToList();
                return output;
            }
        }

        /*
        public void LisaaOpiskelija (int opid, string etunimi, string sukunimi, string hlotunnus, string yritys, string thnimike, string sposti, string osoite, string kaupunki, int postnum, string maa, string puh, string puh2, string site, string muuta)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                List<Opiskelija> opiskelijat = new List<Opiskelija>();

                opiskelijat.Add(new Opiskelija { OpID = opid, Etunimi = etunimi, Sukunimi = sukunimi, Hlotunnus = hlotunnus, Yritys = yritys, Thnimike = thnimike, Sposti = sposti, Osoite = osoite, Kaupunki = kaupunki, Postnum = postnum, Maa = maa, Puh = puh, Puh2 = puh2, Site = site, Muuta = muuta });

                connection.Execute("dbo.Koulutus_Insert @OpID, @Etunimi, @Sukunimi, @Hlotunnus, @Yritys, @Thnimike, @Sposti, @Osoite, @Kaupunki, @Postnum, @Maa, @Puh, @Puh2, @Site, @Muuta", opiskelijat);
            }
        }

        /*
        public void PaivitaOpiskelija(int opid, string etunimi, string sukunimi, string hlotunnus, string yritys, string thnimike, string sposti, string osoite, string kaupunki, int postnum, string maa, string puh, string puh2, string site, string muuta)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                //List<Opiskelija> opiskelijat = new List<Opiskelija>();
                //
                //opiskelijat.Insert(new Opiskelija { OpID = opid, Etunimi = etunimi, Sukunimi = sukunimi, Hlotunnus = hlotunnus, Yritys = yritys, Thnimike = thnimike, Sposti = sposti, Osoite = osoite, Kaupunki = kaupunki, Postnum = postnum, Maa = maa, Puh = puh, Puh2 = puh2, Site = site, Muuta = muuta });
                //connection.Execute("dbo.Koulutus_Insert @OpID, @Etunimi, @Sukunimi, @Hlotunnus, @Yritys, @Thnimike, @Sposti, @Osoite, @Kaupunki, @Postnum, @Maa, @Puh, @Puh2, @Site, @Muuta", opiskelijat);
                //PROBABLY WONT WORK THIS WAY
            }
        }
        */
    }
}
