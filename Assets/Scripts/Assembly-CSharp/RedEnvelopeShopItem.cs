using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class RedEnvelopeShopItem : MonoBehaviour
{
	public Transform child;

	private PropOneEquip mEquip;

	public DxxText nameTex;

	public DxxText limitTex;

	public DxxText priceTex;

	public Image priceImg;

	public GameObject maskObj;

	public ButtonCtrl clickBtn;

	public GameObject critObj;

	public DxxText critText;

	public DxxText critValue;

	private CRedpacketExchangeData mData;

	private static DelegateBridge __Hotfix0_InitEquip;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_RefreshData;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void InitEquip(Drop_DropModel.DropData data)
	{
	}

	public void Init(CRedpacketExchangeData data)
	{
	}

	public void RefreshData()
	{
	}

	private void Click(int count)
	{
	}
}
