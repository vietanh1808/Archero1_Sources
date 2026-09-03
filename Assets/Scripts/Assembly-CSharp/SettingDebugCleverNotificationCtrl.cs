using UnityEngine;
using UnityEngine.UI;

public class SettingDebugCleverNotificationCtrl : MonoBehaviour
{
	private enum DebugMode
	{
		eNormal = 0,
		eFirst = 1,
		eStage = 2,
		eEquip = 3,
		eGold = 4,
		eEquipDouble = 5,
		eGem = 6,
		eScroll = 7,
		eStone = 8,
		eFragment = 9,
		eCookie = 10,
		eRune = 11,
		eBraceletNecklace = 12,
		eBook = 13,
		eFragmentNew = 14,
		eGemNew = 15
	}

	public DxxText ShowInfo;

	public DxxText StateInfo;

	public InputField inputId;

	public ButtonCtrl btnNextId;

	public ButtonCtrl btnPush;

	public ButtonCtrl ResetBtn;

	public ButtonCtrl DebugFirstBtn;

	public ButtonCtrl DebugStageBtn;

	public ButtonCtrl DebugEquipBtn;

	public ButtonCtrl DebugGoldBtn;

	public ButtonCtrl DebugEquipDoubleBtn;

	public ButtonCtrl DebugGemBtn;

	public ButtonCtrl DebugScrollBtn;

	public ButtonCtrl DebugStoneBtn;

	public ButtonCtrl DebugFragmentBtn;

	public ButtonCtrl DebugCookieBtn;

	public ButtonCtrl DebugBraceletNecklaceBtn;

	public ButtonCtrl DebugRuneBtn;

	public ButtonCtrl DebugBookBtn;

	public ButtonCtrl DebugFragmentNewBtn;

	public ButtonCtrl DebugGemNewBtn;

	public ButtonCtrl DebugLogBtn;

	public ButtonCtrl DebugOpenBtn;

	[SerializeField]
	private ButtonCtrl MemoryOpenBtn;

	[SerializeField]
	private Image MemoryOpenImg;

	[SerializeField]
	private DxxText MemoryOpenStr;

	public string ShowInfoStr;

	public string StateInfoStr;

	public DxxText DebugLogStr;

	public DxxText DebugOpenStr;

	private void Awake()
	{
	}

	private void OnPushClick()
	{
	}

	private void OnNextIdClick()
	{
	}

	public void UpdateUI()
	{
	}

	public void OnResetClick()
	{
	}

	public void OnFirstClick()
	{
	}

	public void OnStageClick()
	{
	}

	public void OnEquipClick()
	{
	}

	public void OnGoldClick()
	{
	}

	public void OnEquipDoubleClick()
	{
	}

	public void OnGemClick()
	{
	}

	public void OnScrollClick()
	{
	}

	public void OnStoneClick()
	{
	}

	public void OnFragmentClick()
	{
	}

	public void OnCookieClick()
	{
	}

	public void OnRuneClick()
	{
	}

	private void OnBraceletNecklaceClick()
	{
	}

	private void OnBookClick()
	{
	}

	private void OnFragmentNewClick()
	{
	}

	private void OnGemNewClick()
	{
	}

	public void OnDebugLogClick()
	{
	}

	public void OnDebugOpenClick()
	{
	}

	public void OnMemoryOpenBtnClick()
	{
	}

	private void SetDebugState(DebugMode mode)
	{
	}
}
