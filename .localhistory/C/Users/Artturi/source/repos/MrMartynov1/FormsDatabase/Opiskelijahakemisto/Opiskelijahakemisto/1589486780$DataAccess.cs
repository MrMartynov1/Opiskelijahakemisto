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


        public Opiskelija GetOpiskelijaById(int opid)
        {
            List<Opiskelija> op = null;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                op = connection.Query<Opiskelija>("dbo.Opiskelija_By_OpID @OpID", new { OpID = opid }).ToList();

            }
            return op.First();
        }

        public Opiskelija GetNextOp(int currentOpid)
        {
            List<Opiskelija> op = null;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var output = connection.Query("dbo.Opiskelija_Next @OpID", new { OpID = currentOpid}).ToArray();
                
                if (output.Count() > 0)
                {
                    var asd = ((object[])((System.Collections.Generic.IDictionary<string, object>)output[0]).Values)[0];
                    op = connection.Query<Opiskelija>("dbo.Opiskelija_By_OpID @OpID", new { OpID = asd }).ToList();
                }
                else
                {
                    op = connection.Query<Opiskelija>("dbo.Opiskelija_By_OpID @OpID", new { OpID = currentOpid }).ToList();
                }
   
            }
            return op.First();
        }

        public Opiskelija GetPrevOp(int currentOpid)
        {
            List<Opiskelija> op = null;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var output = connection.Query("dbo.Opiskelija_Prev @OpID", new { OpID = currentOpid }).ToArray();

                if (output.Count() > 0)
                {
                    var asd = ((object[])((System.Collections.Generic.IDictionary<string, object>)output[0]).Values)[0];
                    op = connection.Query<Opiskelija>("dbo.Opiskelija_By_OpID @OpID", new { OpID = asd }).ToList();
                }
                else
                {
                    op = connection.Query<Opiskelija>("dbo.Opiskelija_By_OpID @OpID", new { OpID = currentOpid }).ToList();
                }

            }
            return op.First();
        }

        public void LisaaOpiskelija (int opid, string etunimi, string sukunimi, string hlotunnus, string yritys, string thnimike, string sposti, string osoite, string kaupunki, int postnum, string maa, string puh, string puh2, string site, string muuta)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                List<Opiskelija> opiskelijat = new List<Opiskelija>();

                opiskelijat.Add(new Opiskelija { OpID = opid, Etunimi = etunimi, Sukunimi = sukunimi, Hlotunnus = hlotunnus, Yritys = yritys, Thnimike = thnimike, Sposti = sposti, Osoite = osoite, Kaupunki = kaupunki, Postnum = postnum, Maa = maa, Puh = puh, Puh2 = puh2, Site = site, Muuta = muuta });

                //var output = connection.ExecuteReader("dbo.Koulutus_Insert @OpID, @Etunimi, @Sukunimi, @Hlotunnus, @Yritys, @Thnimike, @Sposti, @Osoite, @Kaupunki, @Postnum, @Maa, @Puh, @Puh2, @Site, @Muuta", opiskelijat);
                var result = connection.Query("exec dbo.Koulutus_Insert @OpID, @Etunimi, @Sukunimi, @Hlotunnus, @Yritys, @Thnimike, @Sposti, @Osoite, @Kaupunki, @Postnum, @Maa, @Puh, @Puh2, @Site, @Muuta", new { OpID = opid, Etunimi = etunimi, Sukunimi = sukunimi, Hlotunnus = hlotunnus, Yritys = yritys, Thnimike = thnimike, Sposti = sposti, Osoite = osoite, Kaupunki = kaupunki, Postnum = postnum, Maa = maa, Puh = puh, Puh2 = puh2, Site = site, Muuta = muuta }), direction: ParameterDirection.ReturnValue;

                var narf = result;
                //var asd = ((object[])((System.Collections.Generic.IDictionary<string, object>)output[0]).Values)[0];
                //return output;
            }
       
        }

        public void LisaaKurssi(int krid, string krnimi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                List<Kurssi> kurssit = new List<Kurssi>();

                kurssit.Add(new Kurssi { KurssiID = krid, Nimi = krnimi });

                connection.Execute("dbo.Koulutus_Insert @KurssiID, @Nimi", kurssit);
            }
        }

        public void LisaaKoe(int koeid, string koenimi, string kieli, int vaikeus, int krid, string ope, int pto, string pvm)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                List<Koe> kokeet = new List<Koe>();

                kokeet.Add(new Koe { KoeID = koeid, Koenimi = koenimi, Kieli = kieli, Vaikeus = vaikeus, KurssiID = krid, Opettaja = ope, Prosenttitavoite = pto, Pvm = pvm });

                connection.Execute("dbo.Koulutus_Insert @KoeID, @Koenimi, @Kieli, @Vaikeus, @KurssiID, @Opettaja, @Prosenttitavoite, @Pvm", kokeet);
            }
        }

        public void LisaaTulos(int vtid, int opid, int pso, int koeid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                List<Vastaukset> tulokset = new List<Vastaukset>();

                tulokset.Add(new Vastaukset { Id = vtid, Opiskelija = opid, ProsenttiMaara = pso, Koe = koeid });

                connection.Execute("dbo.Koulutus_Insert @Id, @Opiskelija, @ProsenttiMaara, @Koe", tulokset);
            }
        }

        //

        public void PaivitaOpiskelija(int opid, string etunimi, string sukunimi, string hlotunnus, string yritys, string thnimike, string sposti, string osoite, string kaupunki, int postnum, string maa, string puh, string puh2, string site, string muuta)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                List<Opiskelija> opiskelijat = new List<Opiskelija>();
                connection.Execute("dbo.Opiskelija_Update @OpID, @Etunimi, @Sukunimi, @Hlotunnus, @Yritys, @Thnimike, @Sposti, @Osoite, @Kaupunki, @Postnum, @Maa, @Puh, @Puh2, @Site, @Muuta", new { OpID = opid, Etunimi = etunimi, Sukunimi = sukunimi, Hlotunnus = hlotunnus, Yritys = yritys, Thnimike = thnimike, Sposti = sposti, Osoite = osoite, Kaupunki = kaupunki, Postnum = postnum, Maa = maa, Puh = puh, Puh2 = puh2, Site = site, Muuta = muuta });
            }
        }

        public void PaivitaKurssi(int krid, string krnimi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                List<Kurssi> kurssit = new List<Kurssi>();
                connection.Execute("dbo.Kurssi_Update @OpID, @Etunimi, @Sukunimi, @Hlotunnus, @Yritys, @Thnimike, @Sposti, @Osoite, @Kaupunki, @Postnum, @Maa, @Puh, @Puh2, @Site, @Muuta", new { KurssiID = krid, Nimi = krnimi });
                
            }
        }

        public void PaivitaKoe(int koeid, string koenimi, string kieli, int vaikeus, int krid, string ope, int pto, string pvm)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                //List<Koe> kokeet = new List<Koe>();
                /*connection.Execute("dbo.Koe_Update @KoeID, @Koenimi, @Kieli, @Vaikeus, @Opettaja, @Prosenttitavoite",
                new { KoeID = 2, Koenimi = "koenimi", Kieli = "kieli", Vaikeus = 1, Opettaja = "ope", Prosenttitavoite = 1});
                */
                connection.Execute("dbo.Koe_Update @KoeID, @Koenimi, @Kieli, @Vaikeus, @Opettaja, @Prosenttitavoite, @Pvm",
                new { KoeID = koeid, Koenimi = koenimi, Kieli = kieli, Vaikeus = vaikeus, Opettaja = ope, Prosenttitavoite = pto, Pvm = pvm });
                

            }
        }

        public void PaivitaTulos(int vtid, int opid, int pso, int koeid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                List<Vastaukset> tulokset = new List<Vastaukset>();
                connection.Execute("dbo.Koe_Update @Id, @Opiskelija, @Prosenttimaara, @Koe", new { Id = vtid, Opiskelija = opid, ProsenttiMaara = pso, Koe = koeid });
            }
        }

        //

        public void PoistaOpiskelija(int opid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                List<Opiskelija> opiskelijat = new List<Opiskelija>();
                connection.Execute("dbo.Opiskelija_Delete @OpID", new { OpID = opid });

            }
        }

        public void PoistaKurssi(int krid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                List<Kurssi> kurssit = new List<Kurssi>();
                connection.Execute("dbo.Kurssi_Delete @KurssiID", new { KurssiID = krid });

            }
        }

        public void PoistaKoe(int koeid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                List<Koe> kokeet = new List<Koe>();
                connection.Execute("dbo.Koe_Delete @KoeID", new { KoeID = koeid });

            }
        }

        //public void PoistaTulos(int opid)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
        //    {
        //        List<Opiskelija> opiskelijat = new List<Opiskelija>();
        //        connection.Execute("dbo.Opiskelija_Delete @OpID", new { OpID = opid });

        //    }
        //}

    }
}
