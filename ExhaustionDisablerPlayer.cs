using Terraria;
using Terraria.ModLoader;
using ThoriumMod;

namespace ExhaustionDisabler
{
    internal class ExhaustionDisablerPlayer : ModPlayer
    {
        public override void PreUpdate()//v1.6.1.n~
        {
            ThoriumPlayer thoriumPlayer = player.GetModPlayer<ThoriumPlayer>();
            thoriumPlayer.throwerExhaustion = 0;
            thoriumPlayer.throwerExhaustionMax = 0;
            thoriumPlayer.throwerExhaustionPenalty = false;
        }
        /*public override void PreUpdate()//v1.6.0.n~
        {
            ThoriumPlayer thoriumPlayer = player.GetModPlayer<ThoriumPlayer>();
            thoriumPlayer.throwerOveruse = 0;
        }*/
    }
}