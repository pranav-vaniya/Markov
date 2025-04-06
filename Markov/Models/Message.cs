using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov.Models
{
    public class Message
    {
        public int Sender { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime Time { get; set; } = DateTime.Now;
    }
}
