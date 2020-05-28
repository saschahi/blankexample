using Terraria.ModLoader;

namespace blankexample
{
	public class blankexample : Mod
	{
		TwitchInput input = new TwitchInput();
		public static Mod ProjectT;

		public override void Load()
		{
			ProjectT = ModLoader.GetMod("ProjectT");
			input = new TwitchInput();
		}

		public override void Unload()
		{
			input = null;
		}
	}
}