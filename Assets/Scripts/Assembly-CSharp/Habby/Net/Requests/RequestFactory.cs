using Habby.Model;

namespace Habby.Net.Requests
{
	public class RequestFactory
	{
		private const string NextSaveCount = "request_savecount";

		private static int k_SaveCount;

		private static MailListRequest m_MailListRequest;

		private static ClientData m_ClientData;

		public static string DeviceId => null;

		public static string SocialId { get; set; }

		public static ulong UserId { get; set; }

		public static ulong URawId { get; set; }

		public static string AppVersion { get; set; }

		public static string SystemLanguage { get; set; }

		public static string AppBundle { get; set; }

		public static string DeviceModel { get; set; }

		public static string OSVersion { get; set; }

		public static string AdvertismentId { get; set; }

		public static string TGADistinctId { get; set; }

		public static string TGADeviceId { get; set; }

		public static string k_AppLanguage => null;

		public static AppUpgradeRequest CreateUpgradeRequest(string appLanguage)
		{
			return null;
		}

		public static UserRequest CreateUserRequest(UserData usrData)
		{
			return null;
		}

		public static MailListRequest CreateMailListRequest()
		{
			return null;
		}

		public static MailReadedRequest CreateMailReadedRequest(string mailId, int mailScope, UserData data)
		{
			return null;
		}

		public static MailRewardRequest CreateMailRewardRequest(string mailId, int mailScope, UserData data)
		{
			return null;
		}

		public static PacksListRequest CreatePacksListRequest()
		{
			return null;
		}

		public static GiftcodeMailCreateRequest CreateGiftcodeMailCreateRequest(string giftcode)
		{
			return null;
		}

		public static CooperationRequest CreateCooperationMatchRequest()
		{
			return null;
		}

		public static void SetCooperationRequest<T>(T pReq) where T : Request
		{
		}

		public static ClientData CreateClientData()
		{
			return null;
		}

		public static GiftcodeClientData CreateGiftcodeClientData()
		{
			return null;
		}

		public static string GetInfo()
		{
			return null;
		}
	}
}
