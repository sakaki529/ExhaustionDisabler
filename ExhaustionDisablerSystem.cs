using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.UI;

namespace ExhaustionDisabler
{
    public class ExhaustionDisablerSystem : ModSystem
	{
        private const string LayerName = "ThoriumMod: Thrower Exhaustion Bar";
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            for (int i = 0; i < layers.Count; i++)
            {
                if (layers[i].Name == LayerName)
                    layers[i].Active = false;
            }
        }
    }
}
