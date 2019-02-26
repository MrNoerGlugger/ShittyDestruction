using Terraria.ModLoader;

namespace ShittyDestruction
{
	class ShittyDestruction : Mod
	{
		public ShittyDestruction()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
