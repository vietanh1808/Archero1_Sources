using UnityEngine;

public class SkillAlone1517 : SkillAloneBase
{
	private class ArgsVO
	{
		public string name;

		public float lastTimestamp;

		public float factor;

		public int debuffId;

		public float fireRate;

		public float triggerTimeInterval;

		public int moveTimeInterval;

		public string toString()
		{
			return null;
		}
	}

	private const int SEA_HORSE_BULLET_ID = 1504;

	private const int MAP_SEA_HORSE_BULLET_ID = 1509;

	private SkillMoveBuff moveSkill;

	private ArgsVO moveArgsVO;

	private ArgsVO mapArgsVO;

	protected string TimerName => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void OnAttack()
	{
	}

	private void onTimer()
	{
	}

	private bool canCreateBullet(ArgsVO argsVO)
	{
		return false;
	}

	private void createMovBullet(EntityBase entity)
	{
	}

	private void createMapBullet(EntityBase m_Entity, Vector3 pos, Vector3 dir)
	{
	}

	private void syncMovBullet(EntityBase entity)
	{
	}

	private void syncMapBullet(EntityBase entity, Vector3 pos, Vector3 dir)
	{
	}

	private Vector3 getHorizontalBulletPos()
	{
		return default;
	}

	private void setBulletAttributes(BulletBase bulletBase, ArgsVO argsVO)
	{
	}
}
