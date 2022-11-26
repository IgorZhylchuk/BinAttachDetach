using BinAttachmentApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BinAttachment.Models
{
    public class BinAttachmentModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(12)]
        [MaxLength(12)]
        public string BinNumber { get; set; }
        public string BinStatus { get; set; }
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
       // [ForeignKey("MachineModel")]
        //public int MachineModelId { get; set; }
        public string MachineName { get; set; }
        public MachineModel Machine { get; set; }


    }
}
