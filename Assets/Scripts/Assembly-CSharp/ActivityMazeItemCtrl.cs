using System.Collections.Generic;
using UnityEngine;
using XLua;

public class ActivityMazeItemCtrl : MonoBehaviour
{
	public GameObject itemparent;

	public GameObject itemone;

	private List<ActivityMazeOneCtrl> mlist;

	private LocalUnityObjctPool mPool;

	private int oneWidth;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_freshUI;

	private static DelegateBridge __Hotfix0_ShowRewardSimple;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(List<MazeActManager.ExchangeData> data)
	{
	}

	public void freshUI()
	{
	}

	public void ShowRewardSimple()
	{
	}
}
