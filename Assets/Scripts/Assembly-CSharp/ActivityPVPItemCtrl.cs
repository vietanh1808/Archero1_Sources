using System.Collections.Generic;
using UnityEngine;
using XLua;

public class ActivityPVPItemCtrl : MonoBehaviour
{
	public GameObject itemparent;

	public GameObject itemone;

	private List<ActivityPVPOneCtrl> mlist;

	private LocalUnityObjctPool mPool;

	private int oneWidth;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_freshUI;

	private static DelegateBridge __Hotfix0_ShowRewardSimple;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(List<PVPActManager.ExchangeData> data)
	{
	}

	public void freshUI()
	{
	}

	public void ShowRewardSimple()
	{
	}
}
