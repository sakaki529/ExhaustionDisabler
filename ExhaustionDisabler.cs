using Terraria.ModLoader;

namespace ExhaustionDisabler
{
    class ExhaustionDisabler : Mod
	{
        internal static ExhaustionDisabler Instance;
        public ExhaustionDisabler()
		{
            Instance = this;
        }
        public override void Unload()
        {
            Instance = null;
        }
    }
}
