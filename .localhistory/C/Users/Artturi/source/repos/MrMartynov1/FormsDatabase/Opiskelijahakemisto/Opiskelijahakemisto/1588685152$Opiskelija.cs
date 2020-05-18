using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelijahakemisto
{
    public class Opiskelija
    {
        public int OpID { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Hlotunnus { get; set; }
        public string Yritys { get; set; }
        public string Thnimike { get; set; }
        public string Sposti { get; set; }
        public string Osoite { get; set; }
        public string Kaupunki { get; set; }
        public int Postnum { get; set; }
        public string Maa { get; set; }
        public string Puh { get; set; }
        public string Puh2 { get; set; }
        public string Site { get; set; }
        public string Muuta { get; set; }

        public string OpListInfo
        {
            get
            {
                return $"{ Sukunimi } { Etunimi }, { Kaupunki } ({ OpID }) ";
            }
        }

        public string OpAllInfo
        {
            get
            {
                return $"{OpID}";
            }
        }

    }

    public class Kurssi
    {
        public int KurssiID { get; set; }
        public string Nimi { get; set; }
    }

    public class Koe
    {
        public int KoeID { get; set; }
        public string Koenimi { get; set; }
        public string Kieli { get; set; }
        public int Vaikeus { get; set; }
        public int KurssiID { get; set; }
        public string Opettaja { get; set; }
        public int Prosenttitavoite { get; set; }
        public string Pvm { get; set; }
    }

    public class Vastaukset
    {
        public int Id { get; set; }
        public int Opiskelija { get; set; }
        public int ProsenttiMaara { get; set; }
        public int Koe { get; set; }
    }
}
