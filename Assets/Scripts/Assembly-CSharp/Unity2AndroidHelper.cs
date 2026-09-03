using UnityEngine;

public class Unity2AndroidHelper : CInstance<Unity2AndroidHelper>
{
	private AndroidJavaClass jc;

	private AndroidJavaObject jo;

	public bool is_debug_mode()
	{
		return false;
	}

	public bool is_gp_avalible()
	{
		return false;
	}

	public bool is_obb_avalible()
	{
		return false;
	}

	public void restartApplication()
	{
	}

	public bool isPad()
	{
		return false;
	}

	public bool isReportTest()
	{
		return false;
	}

	public bool isDebugMode()
	{
		return false;
	}

	public bool isTestServer()
	{
		return false;
	}
}
