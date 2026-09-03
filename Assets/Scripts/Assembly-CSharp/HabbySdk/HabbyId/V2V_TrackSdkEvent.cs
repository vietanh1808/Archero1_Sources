namespace HabbySdk.HabbyId
{
	public class V2V_TrackSdkEvent : HIDEvent
	{
		public SdkEventName eventName;

		public SdkEventBindStatus bindStatus;

		public SdkEventValidationCodePopupReason validationCodePopupReason;

		public SdkEventName popupSource;
	}
}
