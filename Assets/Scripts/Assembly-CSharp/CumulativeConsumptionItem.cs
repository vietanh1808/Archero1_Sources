using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CumulativeConsumptionItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btnReceive;

	[SerializeField]
	private Image imgCheck;

	[SerializeField]
	private DxxText txtContent;

	[SerializeField]
	private DxxText txtBtnReceive;

	[SerializeField]
	private DxxText txtProgress;

	[SerializeField]
	private RectTransform rewardContentRoot;

	private List<PropOneEquip> list;

	private ushort id;

	private static DelegateBridge __Hotfix0_get_sourceName;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Receive;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge _c__Hotfix0_ctor;

	private string sourceName => null;

	private void Awake()
	{
	}

	private void Receive()
	{
	}

	public void SetData(CumulativeConsumptionData.CCItem data, LocalUnityObjctPool pool)
	{
	}
}
