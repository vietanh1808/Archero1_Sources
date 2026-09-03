namespace Habby.AssetExpress
{
	public enum PatchResult : uint
	{
		Unknown = 0u,
		Success = 1u,
		ResourceNotExist = 2u,
		InCompleteResouceInfo = 3u,
		MissingBundles = 4u,
		IOException = 5u,
		PartiallySuccess = 6u
	}
}
