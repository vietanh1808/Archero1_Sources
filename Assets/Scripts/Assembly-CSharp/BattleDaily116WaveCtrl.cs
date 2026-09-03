using UnityEngine;

public class BattleDaily116WaveCtrl : BattleDailyWaveCtrl
{
	[SerializeField]
	private GameObject copyitem;

	[SerializeField]
	private RectTransform m_iconContainer;

	private LocalUnityObjctPool mPool;

	protected override void OnInit()
	{
	}

	public override void Deinit()
	{
	}

	public void AddBuff(int id)
	{
	}
}
