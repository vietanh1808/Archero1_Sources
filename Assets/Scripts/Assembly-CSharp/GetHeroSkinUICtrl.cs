using Dxx.Util;
using UnityEngine.UI;

public class GetHeroSkinUICtrl : MediatorCtrlBase
{
	public Button OkBtn;

	public DxxText btnText;

	public DxxText title;

	public DxxText skinName;

	public DxxText tips;

	public DxxImage skinImage;

	private SequencePool m_seqpool;

	public DxxText taptoclose;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}
}
