using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    // This class will hold any static information that is used all over the place.
    public static class Engine
    {
        // Set a default character size for tiles
        public static int CharacterSize { get; set; } = 14;
        // Hold the current blocked map, this is used for collision detection and only updated on creating a new map.
        public static int[,] BlockedMap { get; set; }
    }
}
