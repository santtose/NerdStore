using NerdStore.Core.Messages;

namespace NerdStore.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}
