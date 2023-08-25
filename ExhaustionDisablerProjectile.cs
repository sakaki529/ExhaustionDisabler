using Terraria;
using Terraria.ModLoader;

namespace ExhaustionDisabler
{
    internal class ExhaustionDisablerProjectile : GlobalProjectile
    {
        public override bool PreAI(Projectile projectile)
        {
            return base.PreAI(projectile);
        }
    }
}