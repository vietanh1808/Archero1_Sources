using UnityEngine;
using UnityEngine.UI;

public class CountDownCtrl : MonoBehaviour
{
	public GameObject child;

	public Image Image_Fill;

	public DxxText Text_Time;

	public Image Image_Arrow;

	private bool bShow;

	private string timestring;

	public void Show(bool show)
	{
	}

	public void Refresh(long time, float percent)
	{
	}

	public void BattlePassRefresh(float percent)
	{
	}

	public string GetTimeString()
	{
		return null;
	}
}
