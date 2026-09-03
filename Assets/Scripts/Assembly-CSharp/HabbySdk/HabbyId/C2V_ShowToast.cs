namespace HabbySdk.HabbyId
{
	public class C2V_ShowToast : HIDEvent
	{
		public bool isGreen;

		public string desc;

		private LocalizationManager LocalizationManager => null;

		public C2V_ShowToast(bool isGreen, int id, params object[] args)
		{
		}
	}
}
