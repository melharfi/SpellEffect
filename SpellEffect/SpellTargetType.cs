using System;
namespace SpellEffect
{
    [Flags]
    public enum SpellTargetType
    {
        NONE = 0,
        SELF = 1,
        ALLY_1 = 2,
        ALLY_2 = 4,
        ALLY_SUMMONS = 8,
        ALLY_STATIC_SUMMONS = 16,
        ALLY_3 = 32,
        ALLY_4 = 64,
        ALLY_5 = 128,
        ALLY_ALL = 254,
        ENNEMY_1 = 256,
        ENNEMY_2 = 512,
        ENNEMY_SUMMONS = 1024,
        ENNEMY_STATIC_SUMMONS = 2048,
        ENNEMY_3 = 4096,
        ENNEMY_4 = 8192,
        ENNEMY_5 = 16384,
        ENEMY_ALL = 32512,
        ALL = 32767,
        ALL_SUMMONS = 3096,
        ONLY_SELF = 32768
    }
}
