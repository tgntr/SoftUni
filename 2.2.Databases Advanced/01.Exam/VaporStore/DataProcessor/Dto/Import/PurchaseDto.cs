using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace VaporStore.DataProcessor.Dto.Import
{
    [XmlType("Purchase")]
    public class PurchaseDto
    {
        [Required]
        public string Type { get; set; }

        [Required]
        [RegularExpression(@"^[0-9A-Z]{4}[-][0-9A-Z]{4}[-][0-9A-Z]{4}$")]
        public string Key { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{4}[ ][0-9]{4}[ ][0-9]{4}[ ][0-9]{4}$")]
        public string Card { get; set; }

        [Required]
        [XmlAttribute("title")]
        public string Game { get; set; }
    }
}
