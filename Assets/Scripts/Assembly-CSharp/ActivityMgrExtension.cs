using GameProtocol;

public static class ActivityMgrExtension
{
	public static ActivityMgr.Status GetStatus(this CActivityExchangeData data)
	{
		return ActivityMgr.Status.Received;
	}
}
