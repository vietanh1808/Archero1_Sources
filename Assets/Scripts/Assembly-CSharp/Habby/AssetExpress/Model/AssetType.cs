using System;

namespace Habby.AssetExpress.Model
{
	[Serializable]
	public enum AssetType
	{
		Unknown = 0,
		Root = 1,
		Text = 2,
		Bin = 3,
		Prefab = 4,
		Texture = 5,
		Lua = 6
	}
}
