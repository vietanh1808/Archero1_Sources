using DG.Tweening;
using UnityEngine;

public class BattleMatchDefenceTime_ConditionCtrl : MonoBehaviour
{
	public DxxText Text_Time;

	public DxxText Text_Me_Name;

	public DxxText Text_Me_Score;

	public DxxText Text_Other_Name;

	public DxxText Text_Other_Score;

	public RectTransform Progress_BG;

	public RectTransform Progress_Me;

	public RectTransform Progress_Other;

	public RectTransform Progress_Light;

	public BattleMatchDefenceTime_InfoCtrl mInfoCtrl;

	private float allwidth;

	private float height;

	private int score_me;

	private int score_other;

	private Transform t_name;

	private Sequence seq_name;

	private void Awake()
	{
	}

	public void SetTime(int time)
	{
	}

	public void SetMeName(string name)
	{
	}

	public void SetMeScore(int value)
	{
	}

	public void SetOtherName(string name)
	{
	}

	public void SetOtherScore(int value)
	{
	}

	public bool isWin()
	{
		return false;
	}

	private void update_progress()
	{
	}

	private void KillSeq()
	{
	}

	public void ShowInfo(string eventname, object body)
	{
	}
}
