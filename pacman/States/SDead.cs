using Microsoft.Xna.Framework;
using System;

namespace Pacman
{
    class SDead : IState
    {
        public void Enter(Ghost aGhost)
        {
            throw new NotImplementedException();
        }

        public void Execute(Ghost aGhost)
        {
            throw new NotImplementedException();
        }

        public void ExecuteGraphics(Ghost aGhost)
        {
            throw new NotImplementedException();
        }

        public void Exit(Ghost aGhost)
        {
            throw new NotImplementedException();
        }

        public Vector2? FindPath(Ghost aGhost)
        {
            return aGhost.GoToPosition((int)aGhost.SpawnPosition.X / Tile.Size, (int)aGhost.SpawnPosition.Y / Tile.Size);
        }
    }
}
