using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SailingTalentUIPanel : MonoBehaviour, ICampUILifeCycle
{
	[SerializeField]
	private SailingTalentPersonalUIPanel _personalUIPanel;

	[SerializeField]
	private GameObject _level;

	[SerializeField]
	private ButtonCtrl _info;

	[SerializeField]
	private DxxText _title;

	[SerializeField]
	private DxxText _levelText;

	[SerializeField]
	private RedNodeCtrl _personalTabRed;

	[SerializeField]
	private SailingTalentTip _sailingTalentTip;

	[SerializeField]
	private ButtonCtrl _mask;

	[SerializeField]
	private Image _imgMilitaryRank;

	[SerializeField]
	private DxxText _textMilitaryRank;

	[SerializeField]
	private DxxText _textPower;

	[SerializeField]
	private DxxText _text34106;

	[SerializeField]
	private DxxText _text34107;

	private SailingTalentManager SailingTalentManager => null;

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnOpen()
	{
	}

	private void RefreshTitle()
	{
	}

	public void OnClose()
	{
	}

	public void RefreshText()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshShow()
	{
	}

	public void RefreshRed()
	{
	}

	private void ClickInfo()
	{
	}

	private (string, string) GetPersonalTipStr()
	{
		return default;
	}
}
