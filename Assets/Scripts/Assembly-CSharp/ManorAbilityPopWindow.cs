using UnityEngine;
using XLua;

public class ManorAbilityPopWindow : MonoBehaviour
{
	public DxxText Text_Desc;

	public ButtonCtrl Button_Use;

	public DxxText Text_Use;

	public DxxText Text_Count;

	public DxxText Text_Tips;

	private int buildId;

	private int abiId;

	private int type;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonUse;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Awake()
	{
	}

	public void init(int buildId, int abi)
	{
	}

	private void onButtonUse()
	{
	}
}
