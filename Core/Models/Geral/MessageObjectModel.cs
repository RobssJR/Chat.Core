using Core.Enums;

namespace Core.Models.Geral
{
    public class MessageObjectModel<T>
    {
        public T Message { get; set; }
        public TypeMessage Type { get; set; }
    }
}
