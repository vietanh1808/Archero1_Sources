using System.Collections.Generic;
using UnityEngine;

public class SettingQualityCtrl : MonoBehaviour
{
	private static Dictionary<int, string> mQualityHigh;

	private static Dictionary<int, string> mQualityLow;

	private bool bFlagship;

	public ButtonCtrl Button_Quality;

	public DxxText Text_QualityContent;

	public DxxText Text_Quality;

	private void Awake()
	{
	}

	private string GetQualityString(int qualityid)
	{
		return null;
	}

	private void UpdateShow()
	{
	}

	private void OnClickButton()
	{
	}

	public void UpdateLanguage()
	{
	}
}
