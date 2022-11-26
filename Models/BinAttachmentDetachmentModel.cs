using BinAttachment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinAttachmentApp.Models
{
    public class BinAttachmentDetachmentModel
    {
        public int Id { get; set; }
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public int MachineModelId { get; set; }
       // public MachineModel Machine { get; set; }
        
        public string  BinNumber { get; set; }
        public BinAttachmentModel Bin { get; set; }
    }
}
