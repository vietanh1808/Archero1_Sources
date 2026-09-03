using Habby;

public class ATTManager : CInstance<ATTManager>
{
	public bool CheckAndPopup()
	{
		return false;
	}

	public void PopupSystem()
	{
	}

	public void PopupInfo()
	{
	}

	private void ATTCallback(ATTStatus status)
	{
	}

	private void OnIdfaGranted()
	{
	}

	public bool ShouldExpose()
	{
		return false;
	}

	public bool HasGranted()
	{
		return false;
	}

	private void ReportTGA(ATTStatus status, ATTStatus realStatus, string idfa)
	{
	}
}
