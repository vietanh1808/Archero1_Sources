using UnityEngine;
using UnityEngine.UI;

public class EndlessRewardGetUICtrl : MediatorCtrlBase
{
	public DxxText titleText;

	public DxxText descText;

	public DxxText rewardText;

	public DxxText okText;

	public GameObject tempItem;

	public GameObject content;

	public ScrollRect scrollRect;

	private EndlessRewardData rewardData;

	private int season;

	private long pre;

	private long next;

	private long space;

	private int preDiamond;

	private int nextDiamond;

	private int spaceDiamond;

	public void OnButttonOK()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void initUI()
	{
	}
}
