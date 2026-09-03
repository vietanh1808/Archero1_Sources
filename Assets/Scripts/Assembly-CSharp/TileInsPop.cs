using System;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class TileInsPop : MonoBehaviour
{
	public static Action<int, int> ClickBtnCallBack;

	public ButtonCtrl Button_Look;

	public ButtonCtrl Button_Town;

	public ButtonCtrl Button_Flag;

	public RectTransform TopRect;

	public HeadItem headItem;

	public Image Image_Battle;

	public DxxText Text_Name;

	public DxxText Text_Cursor;

	public Sprite Occupy;

	public Sprite Occupied;

	private TileClickData data;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonLook;

	private static DelegateBridge __Hotfix0_onButtonTown;

	private static DelegateBridge __Hotfix0_onButtonFlag;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Awake()
	{
	}

	public void init(TileClickData tcd)
	{
	}

	private void onButtonLook()
	{
	}

	private void onButtonTown()
	{
	}

	private void onButtonFlag()
	{
	}
}
