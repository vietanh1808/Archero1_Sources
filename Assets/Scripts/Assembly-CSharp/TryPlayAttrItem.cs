using System;
using UnityEngine;
using UnityEngine.UI;

public class TryPlayAttrItem : MonoBehaviour
{
	public Transform starParent;

	public DxxText selectTxt;

	public DxxText attrTex;

	public DxxText defaultText;

	public DxxImage starIcon;

	public DxxImage skillIcon;

	public DxxImage skillBoxIcon;

	public ButtonCtrl btnSelect;

	public GameObject go_Selected;

	public ScrollRect scroll;

	public RectTransform rectAtt;

	public int starLevel;

	private LocalUnityObjctPool _pool;

	private bool _isInit;

	public void Open(int starLevel, int skillID, string skillDesc, Action<int> selectCallBack)
	{
	}

	private void RefreshScroll()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshSelectStatus(int selectStar)
	{
	}

	public void RefreshStar()
	{
	}
}
