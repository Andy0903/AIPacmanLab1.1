using System;
using Microsoft.Xna.Framework;

namespace Pacman
{
    class SScared : IState
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
            return aGhost.AvoidPosition(aGhost.Player.Position);
        }

        private void Collision(Ghost aGhost)
        {

        }
    }
}
