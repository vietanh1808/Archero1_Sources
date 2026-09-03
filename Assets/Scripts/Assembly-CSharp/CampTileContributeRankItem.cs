using System;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileContributeRankItem : MonoBehaviour
{
	[SerializeField]
	private DxxText rankText;

	[SerializeField]
	private DxxText scoreText;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private RectTransform progress;

	[SerializeField]
	private Image progressImg;

	[SerializeField]
	private Image campImg;

	[SerializeField]
	private ButtonCtrl chestBtn;

	[SerializeField]
	private Image chestIcon;

	private bool isInit;

	private float progressOriginWidth;

	private CampID campID;

	private ulong score;

	private int rank;

	private ulong maxScore;

	private Color[] rankColor;

	private Color[] campColor;

	private Action<int> chestClick;

	private int rankIconStyle;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshProgress;

	private static DelegateBridge __Hotfix0_ClickChestBtn;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(CampID campID, ulong score, int rank, ulong maxScore, int rankIconStyle, Action<int> chestClick)
	{
	}

	public void Init()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshText()
	{
	}

	public void RefreshProgress()
	{
	}

	private void ClickChestBtn()
	{
	}
}
