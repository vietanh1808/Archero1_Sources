using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingDebugActivityCacheCleanCtrl : MonoBehaviour
{
	public ButtonCtrl Btn_Clear;

	public Dropdown Dp_Activity;

	private Dictionary<string, CleanActType> cleanData;

	private void Awake()
	{
	}
}
