using Terraria.ModLoader;

namespace EternityModMusic
{
    public class EternityModMusic : Mod
	{
		internal static EternityModMusic Instance;

		internal Mod Eternity = null;

        public override void Load()
        {
            Instance = this;
            ModLoader.TryGetMod("EternityMod", out Eternity);
        }

        public override void Unload()
        {
            Instance = null;
            Eternity = null;
        }
    }
}
