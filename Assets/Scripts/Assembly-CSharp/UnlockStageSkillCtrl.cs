using DG.Tweening;
using UnityEngine;

public class UnlockStageSkillCtrl : MonoBehaviour
{
	public GameObject child;

	public GameObject copyitem;

	public DxxText Text_SkillContent;

	private const int LineCount = 5;

	private const float WidthOne = 145f;

	private const float HeightOne = 145f;

	private GameMode m_emMode;

	private LocalUnityObjctPool mPool;

	private void Awake()
	{
	}

	public void Init(Sequence seq, int stage, GameMode mode)
	{
	}

	public void DeInit()
	{
	}

	public int GetUnlockSkillCount(int stage)
	{
		return 0;
	}
}
