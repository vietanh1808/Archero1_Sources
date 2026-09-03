using System;
using UnityEngine;

public class WeaponSkinBottomPart : MonoBehaviour
{
	public ButtonCtrl buttonLeft;

	public ButtonCtrl buttonRight;

	[SerializeField]
	private ButtonCtrl buttonGet;

	[SerializeField]
	private ButtonCtrl buttonUsed;

	[SerializeField]
	private ButtonCtrl buttonEnhance;

	public DxxText leftDes;

	public DxxText rightDes;

	[SerializeField]
	private DxxText getDes;

	[SerializeField]
	private DxxText usedDes;

	[SerializeField]
	private DxxText enhanceDes;

	public DxxText descTex;

	public ButtonCtrl backBtn;

	private Vector2 leftPos;

	private Vector2 rightPos;

	private Vector2 centerPos;

	public Action<int, int> UseCallBack;

	public Action<int, int, int, string> BuyCallBack;

	private int _curSkinID;

	public void InitButtons(int weaponType, int skinid)
	{
	}

	private bool GetSkinUsed(int weaponType, int skinid)
	{
		return false;
	}

	private void OnBtnEnhanceClicked()
	{
	}
}
