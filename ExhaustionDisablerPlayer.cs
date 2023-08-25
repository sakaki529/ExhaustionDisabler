using Terraria;
using Terraria.ModLoader;
using ThoriumMod;

namespace ExhaustionDisabler
{
    internal class ExhaustionDisablerPlayer : ModPlayer
    {
        private void DoDisable()
        {
            ThoriumPlayer thoriumPlayer = Player.GetModPlayer<ThoriumPlayer>();
            thoriumPlayer.throwerExhaustion = 0;
            thoriumPlayer.throwerExhaustionMax = 0;
            thoriumPlayer.throwerExhaustionPenalty = false;
        }
        public override void PreUpdate()
        {
            DoDisable();
        }
    }
}
