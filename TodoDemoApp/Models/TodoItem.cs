using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoDemoApp.Models
{
    public class TodoItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Item { get; set; }

        public bool IsComplete { get; set; }

        [ForeignKey("PId")]
        public Person Person { get; set; }

        public long PId { get; set; }

    }
}
