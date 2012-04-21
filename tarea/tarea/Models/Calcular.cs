using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace tarea.Models
{
    public class Calcular
    {
        [Required (ErrorMessage="Este dato es necesario")]
        public int a { set; get; }
        [Required(ErrorMessage = "Este dato es necesario")]
        public int b { set; get; }

    }
}