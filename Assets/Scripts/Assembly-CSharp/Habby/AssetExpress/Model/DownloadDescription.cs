namespace Habby.AssetExpress.Model
{
	public class DownloadDescription
	{
		public ResourceInfo ResourceInfo { get; private set; }

		public BundleFileInfo BundleFileInfo { get; private set; }

		public string ErrorMsg { get; private set; }

		public DownloadDescription(ResourceInfo resource, BundleFileInfo bundle, string errorMsg = "")
		{
		}
	}
}
