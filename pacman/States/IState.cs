using Microsoft.Xna.Framework;

namespace Pacman
{
    interface IState
    {
        void Enter(Ghost aGhost);
        Vector2? FindPath(Ghost aGhost);
        void Execute(Ghost aGhost);
        void ExecuteGraphics(Ghost aGhost);
        void Exit(Ghost aGhost);
    }
}
