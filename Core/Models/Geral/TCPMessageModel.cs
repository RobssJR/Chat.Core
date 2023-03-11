using System;
using Core.Enums;
using Core.Models.Geral;

namespace Core.Models
{
    public class TCPMessageModel<T>
    {
        public DateTime Time { get; set; }
        public T Message { get; set; }
        public TypeMessage Type { get; set; }
    }
}
