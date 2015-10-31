using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PCIClasificadoMvc4App.Models
{
    public class ClasificadoMetaData
    {
        [Display(Name = "Mensaje")]
        public String clasificadoTexto;
        [Display(Name = "Desde")]
        public String publicacionFI;
        [Display(Name = "Hasta")]
        public String publicacionFF;

    }
    [MetadataType(typeof(ClasificadoMetaData))]
    public partial class Clasificado 
    {
    }
}