namespace SignalR.Api
{
    public interface IChatClint
    {
        Task ReceiveMessage(string message);
    }
}
