namespace CatchTheMouse.Lib
{
    public interface IMouse
    {
        bool IsVisible { get; }

        Position Move();

        Position Position { get; }
    }
}