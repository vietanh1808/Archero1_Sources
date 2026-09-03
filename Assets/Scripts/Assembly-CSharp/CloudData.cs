using System;

public class CloudData
{
	public WindowID CloudingMaskWindowID { get; set; }

	public string TipText { get; set; }

	public Action OpenCloudActionAfterNotify { get; set; }

	public static CloudData Create(WindowID cloudingMaskWindowID = WindowID.WindowID_Invaild, string tipText = "", Action openCloudActionAfterNotify = null)
	{
		return null;
	}
}
