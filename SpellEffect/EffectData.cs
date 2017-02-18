using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellEffect
{
    public class EffectData
    {
        public int index;
        public byte[] full_buffer;
        public string full_HexByte;
        public byte[] current_buffer;
        public string current_HexByte;
        public int Id_row;
        public string effectBase;
        public SpellTargetType targets;
        public Int16 id;
        public int duration;
        public int delay;
        public int random;
        public int group;
        public int modificator;
        public bool trigger;
        public bool hidden;
        public string rawZone;
        public SpellShapeEnum zoneShape;
        public UInt32 zoneSize;
        public UInt32 zoneMinSize;
        public Int16 value;
        public Int16 dicenum;
        public Int16 diceface;
    }
}
