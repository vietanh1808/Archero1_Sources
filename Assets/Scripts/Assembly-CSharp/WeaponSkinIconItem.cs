using UnityEngine;
using UnityEngine.UI;

public class WeaponSkinIconItem : MonoBehaviour
{
	public Button clickBtn;

	public DxxImage bgImg;

	public DxxText defultTex;

	public DxxImage IconImg;

	public GameObject selectObj;

	public GameObject maskObj;

	public GameObject redObj;

	public DxxText skinLv;

	public GameObject skinLvObj;

	[HideInInspector]
	public int SkinId;

	public GameObject defultObj;

	public void InitIcon(int weaponType, int skinId)
	{
	}

	public void Select(bool isSelect)
	{
	}

	public void RefreshMask()
	{
	}

	public void RefreshRed()
	{
	}

	public void RefreshLv()
	{
	}
}
