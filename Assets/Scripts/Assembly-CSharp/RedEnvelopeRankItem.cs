using GameProtocol;
using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class RedEnvelopeRankItem : UITableViewCell
{
	public Image RankBg;

	public DxxText RankText;

	public HeadItem headItem;

	public DxxText nameTex;

	public DxxText tokenNum;

	public ButtonCtrl BoxBtn;

	public ButtonCtrl bgBtn;

	public Image BoxImage;

	public MedalItem medal;

	private CRedpacketRank mData;

	private ActRedEnvelopeMgr.RedEnvelopeRankingConfig rankConfig;

	public RedEnvelopRankRewardShow rewardShow;

	public Color[] rankColor;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_OpenReward;

	private static DelegateBridge __Hotfix0_GetRewards;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(CRedpacketRank playData)
	{
	}

	private void OpenReward()
	{
	}

	private string GetRewards()
	{
		return null;
	}

	public void Click()
	{
	}
}
