using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class SeasonChapter : MonoBehaviour
{
	public class HeadData
	{
		public int headId;

		public int headFrameId;
	}

	[SerializeField]
	private GameObject mArrow;

	[SerializeField]
	private RectTransform mChapterContainer;

	[SerializeField]
	private RectTransform mHeadContainer;

	[SerializeField]
	private DxxText mTextChapterIndex;

	[SerializeField]
	private DxxText mTextChapterProgress;

	[SerializeField]
	private MeshLayerHelper mBgRipple;

	private GameObject mHeadPrefab;

	private int m_nLayer;

	private List<GuildMemberHeadInfo> mheadDatas;

	private int m_nStageId;

	private PVEStage_stagechapter mData;

	private bool _isHard;

	public void Init(int stage, int layer, bool isHard = false)
	{
	}

	public void UpdateUI()
	{
	}

	private void OnClickHeadIcon()
	{
	}
}
