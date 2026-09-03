using UnityEngine;

public class DoubleChallengeReportItem : ViewCell
{
	private static readonly Color WinColor;

	private static readonly Color LoseColor;

	[Header("我方信息")]
	public HeadItem myHeadItem;

	public DxxText myNameTex;

	[Header("对手信息")]
	public HeadItem enemyHeadItem;

	public DxxText enemyNameTex;

	public ButtonCtrl enemyHeadBtn;

	[Header("战斗结果")]
	public DxxText resultTex;

	public DxxText scoreTex;

	public GameObject peakObj;

	public DxxText peakTex;

	private DoubleChallengeReportData reportData;

	protected override void OnInit()
	{
	}

	protected override void OnRefresh()
	{
	}

	protected override void OnRecycle()
	{
	}

	private void OnClickEnemyHead()
	{
	}
}
