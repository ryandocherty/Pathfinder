using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using System.IO;

namespace Pathfinder
{
    class AiBotSimple : AiBotRandom
    {
       public AiBotSimple(int x, int y) : base(x,y)
        {

        }
       protected override void ChooseNextGridLocation(Level level, Player plr)
       {
           if (plr.GridPosition.X > GridPosition.X)
           {
               Coord2 newPos;
               newPos = GridPosition;
               
               
               if (level.ValidPosition(newPos) == false)
               {
                   newPos.X -= 1;
                   SetNextGridPosition(newPos, level);
               }
               else
               {
                   newPos.X += 1;
                   SetNextGridPosition(newPos, level);
               }
           }


           if (plr.GridPosition.X < GridPosition.X)
           {
               Coord2 newPos;
               newPos = GridPosition;

               if (level.ValidPosition(newPos) == false)
               {
                   newPos.X += 1;
                   SetNextGridPosition(newPos, level);
               }

               else
               {
                   newPos.X -= 1;
                   SetNextGridPosition(newPos, level);
               }
           }


           if (plr.GridPosition.Y > GridPosition.Y)
           {
               Coord2 newPos;
               newPos = GridPosition;
               
               if (level.ValidPosition(newPos) == false)
               {
                   newPos.Y -= 1;
                   SetNextGridPosition(newPos, level);
               }

               else
               {
                   newPos.Y += 1;
                   SetNextGridPosition(newPos, level);
               }
           }


           if (plr.GridPosition.Y < GridPosition.Y)
           {
               Coord2 newPos;
               newPos = GridPosition;
               
               if (level.ValidPosition(newPos) == false)
               {
                   newPos.Y += 1;
                   SetNextGridPosition(newPos, level);
               }

               else
               {
                   newPos.Y -= 1;
                   SetNextGridPosition(newPos, level);
               }
           }
       }
    }
}
