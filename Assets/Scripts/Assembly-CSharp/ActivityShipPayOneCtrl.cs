using GameProtocol;
using TableTool;
using UnityEngine;
using XLua;

public class ActivityShipPayOneCtrl : MonoBehaviour
{
	public Transform child;

	public PropOneEquip mEquip;

	public CRewardItem mData;

	private string sourceName;

	private string rewardId;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_InitEquip;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(CRewardItem data, string sourceName, string rewardId)
	{
	}

	private void InitEquip(Drop_DropModel.DropData data)
	{
	}
}
