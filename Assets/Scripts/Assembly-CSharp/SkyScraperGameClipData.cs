using System;

public class SkyScraperGameClipData : ViewCellData
{
	public ViewCellData boxData;

	public float hight;

	public Action<float, float, float, float> OnPlayClip;

	public bool isClipComplete;

	public void PlayClip(float downTime, float stayTime, float upTime, float starTime)
	{
	}
}
