using MediatR;

namespace NerdStore.Core.Messages
{
    public abstract class Event : Message, INotification // interface de marcação pra dizer que é uma classe de notificacao de evento
    {
        public DateTime Timestamp { get; private set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
