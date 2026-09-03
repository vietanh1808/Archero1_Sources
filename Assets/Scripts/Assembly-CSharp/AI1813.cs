using Dxx.Util;
using UnityEngine;

public class AI1813 : AI1801
{
	private class WeaponWeight
	{
		public int id;

		public int weight;

		public WeaponWeight(string str)
		{
		}
	}

	private float m_fTime;

	private int m_nWeaponId;

	private int m_nBaseHp;

	private int m_nStep;

	private bool m_bReverse;

	private bool m_bIsWaveRoom;

	private bool m_bTriggerInWaveRoom;

	private GameObject m_recoverLifeEffect;

	private SequencePool mSeqPool;

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private void OnAttackPre()
	{
	}

	private void InitHp(EntityPartBody1813 part, int nSkinId, int nHeroId)
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	private void PlayRecoverLifeEffect()
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	protected override void OnAttackSpeedUpdate(int value)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnWaveRoomPlayerMove(Vector3 pos)
	{
	}

	private void RandomWeapon(int nSkinId, int nHeroId)
	{
	}

	protected override ActionBase GetAttackAction()
	{
		return null;
	}
}
