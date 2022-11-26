using BinAttachment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BinAttachmentApp.Models
{
    public class ProcessModel
    {
       // [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MachineModel> Machines { get; set; }
    }
    public class MachineModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProcessModelId { get; set; }
        public ProcessModel Process { get; set; }
        public ICollection<BinAttachmentModel> Bins { get; set; }
    }
}
