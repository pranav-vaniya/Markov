using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov.Models
{
    public class Conversation
    {
        public List<Message> Messages { get; set; } = new List<Message>();
    }
}
