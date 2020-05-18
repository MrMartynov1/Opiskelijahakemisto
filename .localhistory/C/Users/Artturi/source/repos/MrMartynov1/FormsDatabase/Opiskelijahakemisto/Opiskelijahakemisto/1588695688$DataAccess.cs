using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Opiskelijahakemisto
{
    //private readonly Form1 form;
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
        
        //
        public string AvaaOpiskelija_Etunimi(string etunimi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret2 = connection.Query<Opiskelija>("dbo.Opiskelija_By_FirstName @Etunimi", new { Etunimi = etunimi }).ToString();
                return ret2;
            }
        }

        public string AvaaOpiskelija_Sukunimi(string sukunimi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret3 = connection.Query<Opiskelija>("dbo.Opiskelija_By_LastName @Sukunimi", new { Sukunimi = sukunimi }).ToString();
                return ret3;
            }
        }

        public string AvaaOpiskelija_Hlotunnus(string hlotunnus)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret4 = connection.Query<Opiskelija>("dbo.Opiskelija_By_Hlotunnus @Hlotunnus", new { Hlotunnus = hlotunnus }).ToString();
                return ret4;
            }
        }

        public string AvaaOpiskelija_Yritys(string yritys)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret5 = connection.Query<Opiskelija>("dbo.Opiskelija_By_Yritys @Yritys", new { Yritys = yritys }).ToString();
                return ret5;
            }
        }

        public string AvaaOpiskelija_Thnimike(string thnimike)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret6 = connection.Query<Opiskelija>("dbo.Opiskelija_By_Thnimike @Thnimike", new { Thnimike = thnimike }).ToString();
                return ret6;
            }
        }

        public string AvaaOpiskelija_Sposti(string sposti)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret7 = connection.Query<Opiskelija>("dbo.Opiskelija_By_Sposti @Sposti", new { Sposti = sposti }).ToString();
                return ret7;
            }
        }

        public string AvaaOpiskelija_Osoite(string osoite)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret8 = connection.Query<Opiskelija>("dbo.Opiskelija_By_Osoite @Osoite", new { Osoite = osoite }).ToString();
                return ret8;
            }
        }

        public string AvaaOpiskelija_Kaupunki(string kaupunki)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret9 = connection.Query<Opiskelija>("dbo.Opiskelija_By_Kaupunki @Kaupunki", new { Kaupunki = kaupunki }).ToString();
                return ret9;
            }
        }

        public int AvaaOpiskelija_Postnum(int postnum)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret10 = connection.Query<Opiskelija>("dbo.Opiskelija_By_Postnum @Postnum", new { Postnum = postnum }).ToString();
                int reti10 = int.Parse(ret10);
                return reti10;
            }
        }

        public string AvaaOpiskelija_Maa(string maa)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret11 = connection.Query<Opiskelija>("dbo.Opiskelija_By_Maa @Maa", new { Maa = maa }).ToString();
                return ret11;
            }
        }

        public string AvaaOpiskelija_Puh(string puh)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret12 = connection.Query<Opiskelija>("dbo.Opiskelija_By_Puh @Puh", new { Puh = puh }).ToString();
                return ret12;
            }
        }

        public string AvaaOpiskelija_Puh2(string puh2)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret13 = connection.Query<Opiskelija>("dbo.Opiskelija_By_Puh2 @Puh2", new { Puh2 = puh2 }).ToString();
                return ret13;
            }
        }

        public string AvaaOpiskelija_Site(string site)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret14 = connection.Query<Opiskelija>("dbo.Opiskelija_By_Site @Site", new { Site = site }).ToString();
                return ret14;
            }
        }

        public string AvaaOpiskelija_Muuta(string muuta)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var ret15 = connection.Query<Opiskelija>("dbo.Opiskelija_By_Muuta @Muuta", new { Muuta = muuta }).ToString();
                return ret15;
            }
        }
        //

        public Array AvaaOpiskelija(int opid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                var output = connection.Query<Opiskelija>("dbo.Opiskelija_By_OpID @OpID", new { OpID = opid }).ToArray();
                return output;
            }
        }
        
        public void LisaaOpiskelija (int opid, string etunimi, string sukunimi, string hlotunnus, string yritys, string thnimike, string sposti, string osoite, string kaupunki, int postnum, string maa, string puh, string puh2, string site, string muuta)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                List<Opiskelija> opiskelijat = new List<Opiskelija>();

                opiskelijat.Add(new Opiskelija { OpID = opid, Etunimi = etunimi, Sukunimi = sukunimi, Hlotunnus = hlotunnus, Yritys = yritys, Thnimike = thnimike, Sposti = sposti, Osoite = osoite, Kaupunki = kaupunki, Postnum = postnum, Maa = maa, Puh = puh, Puh2 = puh2, Site = site, Muuta = muuta });

                connection.Execute("dbo.Koulutus_Insert @OpID, @Etunimi, @Sukunimi, @Hlotunnus, @Yritys, @Thnimike, @Sposti, @Osoite, @Kaupunki, @Postnum, @Maa, @Puh, @Puh2, @Site, @Muuta", opiskelijat);
            }
        }

        public void PaivitaOpiskelija(int opid, string etunimi, string sukunimi, string hlotunnus, string yritys, string thnimike, string sposti, string osoite, string kaupunki, int postnum, string maa, string puh, string puh2, string site, string muuta)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connecc.ConnValue("KoulutusTK")))
            {
                List<Opiskelija> opiskelijat = new List<Opiskelija>();

                //opiskelijat.Insert(new Opiskelija { OpID = opid, Etunimi = etunimi, Sukunimi = sukunimi, Hlotunnus = hlotunnus, Yritys = yritys, Thnimike = thnimike, Sposti = sposti, Osoite = osoite, Kaupunki = kaupunki, Postnum = postnum, Maa = maa, Puh = puh, Puh2 = puh2, Site = site, Muuta = muuta });
                //connection.Execute("dbo.Koulutus_Insert @OpID, @Etunimi, @Sukunimi, @Hlotunnus, @Yritys, @Thnimike, @Sposti, @Osoite, @Kaupunki, @Postnum, @Maa, @Puh, @Puh2, @Site, @Muuta", opiskelijat);
            }
        }

        /*
        SOMETHING LIKE THIS BUT "WHERE NAME"-PART REPLACED WITH OPID

        public Person SomeMethod(string fName)
        {
            var con = ConfigurationManager.ConnectionStrings["Yourconnection"].ToString();

            Person matchingPerson = new Person();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Employees where FirstName=@fName";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Fname", fName);           
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {    
                        matchingPerson.firstName = oReader["FirstName"].ToString();
                        matchingPerson.lastName = oReader["LastName"].ToString();                       
                    }

                    myConnection.Close();
                }               
            }
            return matchingPerson;
        }
        */
    }
}
