using System;
using UnityEngine;
using UnityEngine.UI;

public class AdHarvestBoostPopup : MonoBehaviour
{
	public Transform iconAnchor;

	public DxxText textTitle;

	public DxxText textCurrentLevel;

	public DxxText textCurrentBoostName;

	public DxxText textCurrentBoostValue;

	public DxxText textDesc;

	public Image imageNextIcon;

	public DxxText textNextLevel;

	public DxxText textNextBoost;

	public DxxText textNextBoostValue;

	public DxxText textActivate;

	public ButtonCtrl buttonActivate;

	[SerializeField]
	private RedNodeCtrl redCtrl;

	public DxxText harvestLevel;

	public Action onAfterClose;

	protected RectTransform icon;

	protected Transform iconParent;

	protected int iconParentPos;

	private Func<bool> isRed;

	public void Init()
	{
	}

	public void Open(RectTransform icon)
	{
	}

	public void OnClose()
	{
	}

	private void RefreshRed()
	{
	}

	public void SetRedFunc(Func<bool> isRed)
	{
	}
}
