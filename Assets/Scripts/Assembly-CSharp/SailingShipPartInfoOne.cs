using System;
using UnityEngine;

public class SailingShipPartInfoOne : MonoBehaviour
{
	public DxxImage partIcon;

	public DxxImage partBg;

	public ButtonCtrl btnPart;

	public GameObject goSelected;

	public GameObject goLevel;

	public GameObject goTime;

	public DxxText txtLevel;

	public GameObject goRed;

	private int _skinID;

	public void Init(int partID, int skinID, Sprite partImg, Sprite bgImg, Action<int> clickCallback = null, int level = 0, int maxLevel = 0, bool isHave = true, bool isShowRed = false)
	{
	}

	public void SetLevelStatus(bool isShow)
	{
	}

	public void SetSelectStatus(int skinID)
	{
	}

	public void SetLock(bool isLock)
	{
	}
}
