using UnityEngine;
using XLua;

public class BattleTowerDefense2023UpgradeButton : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private DxxImage imgIcon;

	[SerializeField]
	private DxxText txtPrice;

	[SerializeField]
	private DxxText txtUpgrade;

	[SerializeField]
	private RectTransform rt;

	private bool shown;

	private int instanceId;

	private bool rightHanded;

	private static DelegateBridge __Hotfix0_get_min;

	private static DelegateBridge __Hotfix0_get_max;

	private static DelegateBridge __Hotfix0_get_end;

	private static DelegateBridge __Hotfix0_get_start;

	private static DelegateBridge __Hotfix0_get__speed;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_OnClick;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_SetHand;

	private static DelegateBridge __Hotfix0_CloseInstant;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_UpdateState;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge _c__Hotfix0_ctor;

	private float min => 0f;

	private float max => 0f;

	private float end => 0f;

	private float start => 0f;

	private float _speed => 0f;

	private void Awake()
	{
	}

	private void OnClick()
	{
	}

	public void Open(int instanceId)
	{
	}

	public void SetHand(bool rightHanded)
	{
	}

	public void CloseInstant()
	{
	}

	public void Close()
	{
	}

	public void UpdateState()
	{
	}

	private void Update()
	{
	}
}
