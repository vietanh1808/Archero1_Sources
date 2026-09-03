using UnityEngine;
using UnityEngine.UI;

public class SailingShipBattleBuffItem : MonoBehaviour
{
	[SerializeField]
	private Image skillFillMask;

	[SerializeField]
	private Image skillIcon;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private DxxText _textLayer;

	[SerializeField]
	private Animator _animator;

	private SailingShipBattleBuffItemData itemData;

	private bool isInit;

	private bool isForeverBuff;

	private bool isCDBuff;

	private SailingShipGameData ShipGameData => null;

	public SailingShipBattleBuffItemData Data => null;

	public string Key => null;

	private void Init()
	{
	}

	public void Refresh(SailingShipBattleBuffItemData itemData)
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshProgress()
	{
	}

	private void Update()
	{
	}

	private void ClickBtn()
	{
	}
}
