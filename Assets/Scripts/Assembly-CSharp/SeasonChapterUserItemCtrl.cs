using UnityEngine;
using UnityEngine.UI;

public class SeasonChapterUserItemCtrl : ItemRender
{
	[SerializeField]
	private Image m_imgIcon;

	[SerializeField]
	private Image m_imgFrame;

	[SerializeField]
	private DxxText m_textName;

	[SerializeField]
	private DxxText m_textStage;

	[SerializeField]
	private ButtonCtrl m_btn;

	private GuildMemberHeadInfo m_data;

	private GameObject _headFrameEffect;

	private RectTransform _scrollViewRect;

	protected override void OnInit()
	{
	}

	protected override void OnUpdateData()
	{
	}

	private void UpdateUI()
	{
	}

	private void Update()
	{
	}
}
