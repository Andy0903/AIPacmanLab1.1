using Microsoft.Xna.Framework;
using System;

namespace Pacman
{
    class SAlive : IState
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
           return aGhost.GoToPosition(aGhost.Player.Column, aGhost.Player.Row);
        }
    }
}
