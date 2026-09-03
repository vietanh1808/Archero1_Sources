using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class PropOneBase : MonoBehaviour
{
	public ButtonCtrl mButton;

	public Image Image_BG;

	public Image Image_Icon;

	public DxxText Text_Value;

	public DxxText Text_Content;

	public DxxText Text_Level;

	public Image Image_Type;

	public Image Image_QualityGold;

	public Image Image_Choice;

	public GameObject LimitedTime;

	public Image clock;

	public DxxText days;

	public GameObject timeLimitIcon;

	private DxxText Text_Button;

	protected PropOneEquip.Transfer data;

	public Action<PropOneBase, object> OnClickEvent;

	public Action<PropOneBase, object> OnLongPressEvent;

	public bool m_bDetailShowNum;

	protected string rewardChoiceSource;

	private void Awake()
	{
	}

	protected virtual void OnAwake()
	{
	}

	public void SetButtonEnable(bool value)
	{
	}

	private void Init(PropOneEquip.Transfer data)
	{
	}

	public PropType getType()
	{
		return PropType.eAsk;
	}

	public int getId()
	{
		return 0;
	}

	public long GetDays()
	{
		return 0L;
	}

	public long getCount()
	{
		return 0L;
	}

	public void changeCount(int count)
	{
	}

	public void InitCurrency(int id, long count)
	{
	}

	public void InitRandomRefine(int id, int rarity, int count)
	{
	}

	public void InitEquip(int id, int count)
	{
	}

	public void InitCharacter(int id, int count)
	{
	}

	public void InitSkin(int id, int days = 0)
	{
	}

	public void InitHero(int id, int days = 0)
	{
	}

	public void InitHead(int id)
	{
	}

	public void InitHeadFrame(int id)
	{
	}

	public void InitAsk(int id)
	{
	}

	public void InitChoiceBox(int id)
	{
	}

	public void InitWeaponSkin(int id)
	{
	}

	public void InitCampTownSkin(int id)
	{
	}

	public void InitPet(int id)
	{
	}

	public void InitWing(int id)
	{
	}

	public void InitArtifact(int id)
	{
	}

	public void InitSailingShipPartSkin(int id)
	{
	}

	public void InitWeaponColorSkin(int id)
	{
	}

	public void InitProp(int[] data)
	{
	}

	public void InitProp(string data)
	{
	}

	public void InitProp(string data, bool bDetailShowNum)
	{
	}

	public void InitSelection(string data, string sourceName, string rewardId, bool overrideCallback = true)
	{
	}

	public void InitSelection(Drop_DropModel.DropData dropData, string sourceName, string rewardId, bool overrideCallback = true)
	{
	}

	public void InitMultiSelection(Drop_DropModel.DropData dropData, string sourceName, string rewardId, Action<PropOneBase, object> callback = null, bool overrideCallback = true)
	{
	}

	private void OnDisable()
	{
	}

	public void InitGuildBox((int, int) values)
	{
	}

	public void InitProp(Drop_DropModel.DropData data)
	{
	}

	protected virtual void OnInit()
	{
	}

	private void OnClickBase()
	{
	}

	private void OnLongPress()
	{
	}

	protected virtual void OnClicked()
	{
	}

	protected virtual void OnLongPressed()
	{
	}

	public virtual void clickShowPropDesc()
	{
	}

	public void SetTextValue(string pStr)
	{
	}

	private void OnDestroy()
	{
	}

	private void DeInit()
	{
	}

	protected virtual void OnDeInit()
	{
	}
}
