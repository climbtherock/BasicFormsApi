using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LDSFormsApp.Data.Entities
{
    public class AgendaItem
    {
        [Column(nameof(AgendaItem) + nameof(Id))]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Description { get; set; }

        public int MeetingId { get; set; }

        public Meeting Meeting { get; set; }
    }
}
