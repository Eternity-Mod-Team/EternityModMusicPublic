using Terraria.ModLoader;

namespace EternityModMusic
{
    public class EternityModMusic : Mod
	{
		public static EternityModMusic Instance;

		internal Mod Eternity = null;

		public EternityModMusic() => Instance = this;

        public override void Load()
        {
            Eternity = null;
            ModLoader.TryGetMod("EternityMod", out Eternity);
        }

        public override void Unload()
        {
            Instance = null;
            Eternity = null;
        }
    }
}