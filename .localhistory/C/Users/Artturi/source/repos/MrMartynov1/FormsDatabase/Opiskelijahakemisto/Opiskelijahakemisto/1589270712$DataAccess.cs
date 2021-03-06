﻿using System;
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
                var output = connection.Query<Koe>("dbo.Koe_By_Koenimi @Koenimi", new { Koenimi = koenimi }).ToList();
                return output;
            }
        }

        public List<Vastaukset> HaeTulos(int koeid, int opid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                using (var multi = connection.QueryMultiple("dbo.Vastaukset_By_Koe_And_Opiskelija @Koe, @Opiskelija", new { Koe = koeid, Opiskelija = opid }))
                {
                    var output = multi.Read<Vastaukset>().ToList();
                    return output;
                }
            }
        }

        //public MaxIdOp maxOp(int maxopid)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
        //    {
        //        var output = connection.Query<MaxIdOp>("dbo.Koe_By_Koenimi @MaxOpID", new { OpID = maxopid });
        //        return output;
        //    }
        //}

        //public MaxIdKr maxKr()
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
        //    {
        //        var output = connection.Query<Koe>("dbo.Koe_By_Koenimi @Koenimi", new { Koenimi = koenimi }).ToList();
        //        return output;
        //    }
        //}

        //public MaxIdKoe maxKo()
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
        //    {
        //        var output = connection.Query<Koe>("dbo.Koe_By_Koenimi @Koenimi", new { Koenimi = koenimi }).ToList();
        //        return output;
        //    }
        //}

        //public MaxIdV maxV()
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
        //    {
        //        var output = connection.Query<Koe>("dbo.Koe_By_Koenimi @Koenimi", new { Koenimi = koenimi }).ToList();
        //        return output;
        //    }
        //}

        //public List<Opiskelija> asdasd(string sukunimi)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
        //    {
        //        var idMensaje = dbConn.Query<MaxIdOp>("select MAX(id) AS id from MensajeTablon");
        //        return idMensaje;
        //    }
        //}


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
