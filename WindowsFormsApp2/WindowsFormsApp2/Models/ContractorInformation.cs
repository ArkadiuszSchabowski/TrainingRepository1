﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
    public class ContractorInformation
    {
        public string Kontrahent { get; set; }
        public string Kraj { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Trasa { get; set; }

        public int Kod_Kreskowy { get; set; }
    }
}
