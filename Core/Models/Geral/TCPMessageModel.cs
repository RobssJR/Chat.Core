using System;
using Core.Models.Geral;

namespace Core.Models
{
    public class TCPMessageModel<T>
    {
        public DateTime Time { get; set; }
        public MessageObjectModel<T> ObjectMessage { get; set; }
    }
}
