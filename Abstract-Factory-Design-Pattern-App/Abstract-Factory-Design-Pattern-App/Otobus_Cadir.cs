﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern_App
{
    public class Otobus_Cadir:SoyutFabrika
    {
        public string Lokasyon;
        public DateTime GidisTarih;
        public DateTime DonusTarih;
        public Otobus_Cadir(string Lokasyon,DateTime GidisTarih,DateTime DonusTarih)
        {
            this.Lokasyon = Lokasyon;       
            this.GidisTarih = GidisTarih;
            this.DonusTarih = DonusTarih;
        }
        public override IUlasim GetUlasim()
        {
            return new Otobus(this.Lokasyon, this.GidisTarih, this.DonusTarih);
        }
        public override IKonaklama GetKonaklama()
        {
            return new Cadir(this.GidisTarih, this.DonusTarih);
        }
    }
}
