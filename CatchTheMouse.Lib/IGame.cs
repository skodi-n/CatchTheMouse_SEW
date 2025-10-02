namespace CatchTheMouse.Lib
{
    public interface IGame
    {
        Player Cat { get; }
        bool IsGameOver { get; }
        Player Mouse { get; }
    }
}