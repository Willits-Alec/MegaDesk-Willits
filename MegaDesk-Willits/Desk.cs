using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Willits
{
   public enum DeskTopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public class Desk
    {
        public int width { get; set; }

        public int depth { get; set; }

        public int NumberOfDrawers { get; set; }

        public DeskTopMaterial SurfaceMaterial { get; set; }
    }
}
