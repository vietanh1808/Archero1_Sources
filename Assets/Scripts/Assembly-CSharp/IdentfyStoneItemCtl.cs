using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class IdentfyStoneItemCtl : MonoBehaviour
{
	public DxxText noStoneText;

	public GameObject noStoneObject;

	[Header("有石头")]
	public GameObject haveStone;

	public Image stone;

	public ButtonCtrl seachBtn;

	public ButtonCtrl buyBtn;

	public Text numberText;

	public DxxText purchasedText;

	public GameObject purchasedObject;

	public GameObject buyObject;

	private bool inited;

	public int Index { get; private set; }

	public IdentfyItem itemData { get; private set; }

	public Gambling_StoneConfig itemConfig { get; private set; }

	public void Init()
	{
	}

	public void SetData(int pIndex, IdentfyItem pData)
	{
	}

	public void RefData()
	{
	}

	private int GetPrice()
	{
		return 0;
	}

	private bool IsEnoughDiamond()
	{
		return false;
	}

	public void OnLanguageChange()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	private void OnSeachClick()
	{
	}

	private void OnBuyClick()
	{
	}
}
