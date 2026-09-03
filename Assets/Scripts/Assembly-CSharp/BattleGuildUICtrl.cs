using UnityEngine;

public class BattleGuildUICtrl : BattleLevelUICtrl
{
	[SerializeField]
	private Transform WaveParent;

	protected override Transform GetDailyWaveParent => null;
}
