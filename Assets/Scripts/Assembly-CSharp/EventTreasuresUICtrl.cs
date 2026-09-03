using UnityEngine;
using UnityEngine.UI;

public class EventTreasuresUICtrl : MediatorCtrlBase, AdsRequestHelper.AdsCallback
{
	[SerializeField]
	private DxxText Text_Title;

	[SerializeField]
	private DxxText Text_Content;

	[SerializeField]
	private DxxText Text_Ad;

	[SerializeField]
	private DxxText Text_Exchange;

	[SerializeField]
	private DxxText Text_Hp;

	[SerializeField]
	private DxxText Text_Get;

	[SerializeField]
	private DxxText Text_Price;

	[SerializeField]
	private Image Image_Ad;

	[SerializeField]
	private ButtonCtrl Button_Close;

	[SerializeField]
	private ButtonCtrl Button_Exchange;

	[SerializeField]
	private ButtonCtrl Button_Diamond;

	[SerializeField]
	private ButtonCtrl Button_Ad;

	[SerializeField]
	private Image Image_Icon;

	[SerializeField]
	private DxxText Text_Skill_Name;

	[SerializeField]
	private DxxText Text_Skill_Desc;

	[SerializeField]
	private DxxText Text_Tips_1;

	[SerializeField]
	private DxxText Text_Tips_2;

	[SerializeField]
	private Image[] Img_Stars;

	private int m_nSkillId;

	private bool IsFreeAd => false;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RandomSkill()
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

	public void onRequest(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onLoad(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onFail(AdsRequestHelper.AdsDriver sender, string msg)
	{
	}

	public void onOpen(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClose(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClick(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	private void onRewardWrapper(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onReward(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	private void onRewardInternal()
	{
	}

	private void onRewardInterval()
	{
	}

	private void AddTreasuresSkill()
	{
	}
}
