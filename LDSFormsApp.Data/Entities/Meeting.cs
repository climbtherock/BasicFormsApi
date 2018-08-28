using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LDSFormsApp.Data.Entities
{
    public class Meeting
    {
        [Column(nameof(Meeting) + nameof(Id))]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Objective { get; set; }

        public DateTime Date { get; set; }

        public string Comments { get; set; }

        public ICollection<AgendaItem> AgendaItems { get; set; }
    }
}
