﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Analisis
    {
        [Key]
        public int AnalisisId { get; set; }
        public DateTime Fecha { get; set; }
        public int PersonaId { get; set; }
        public int Balance { get; set; }
        public virtual List<AnalisisDetalle> Detalle { get; set; }

        public Analisis()
        {
            this.AnalisisId = 0;
            this.Fecha = DateTime.Now;
            this.PersonaId = 0;
            this.Balance = 0;
            this.Detalle = new List<AnalisisDetalle>();
        }

        public void AgregarDetalle(int Id, int AnalisisId, int TipoId, string Descripcion, int Precio, string Resultado)
        {
            this.Detalle.Add(new AnalisisDetalle(Id, AnalisisId, TipoId, Descripcion, Precio, Resultado));
        }

    }
}
