//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sisben.WebApps.QAML.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CNS_HOGARES_RECHAZO
    {
        public int Num_paquete { get; set; }
        public byte Est_hogar_bd { get; set; }
        public System.DateTime Fec_paquete { get; set; }
        public string Cod_dpto { get; set; }
        public string Cod_mpio { get; set; }
        public int Num_ficha { get; set; }
        public string Ide_ficha_origen { get; set; }
        public byte Ide_hogar { get; set; }
        public byte Ind_causa_rechazo { get; set; }
        public System.DateTime fec_rechazo { get; set; }
    }
}
