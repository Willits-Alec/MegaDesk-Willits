using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Willits
{
   public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public class Desk
    {

        public static short MIN_WIDTH = 24;
        public static short MAX_WIDTH = 96;
        public static short MIN_DEPTH = 12;
        public static short MAX_DEPTH = 48;
        public static short MIN_HIGHT = 00;
        public static short MAX_HIGHT = 00;


        public int width { get; set; }
        public int depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DesktopMaterial SurfaceMaterial { get; set; }
    }
}
