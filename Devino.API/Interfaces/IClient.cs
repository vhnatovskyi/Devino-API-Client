using Devino.API.Models;

namespace Devino.API.Interfaces
{
    public interface IClient
    {
        Response SendMessage(IMessage message);
    }
}
