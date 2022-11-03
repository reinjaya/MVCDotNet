﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebAPI.Modes
{
    public class Departement
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DivisionId { get; set; }

        [ForeignKey("DivisionId")]
        [JsonIgnore]
        public Division? Division { get; set; }
    }
}
