using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class SkillAlone1815 : SkillAloneBase
{
	private class FallThunderVO
	{
		public Dictionary<EntityBase, int> fallDict;

		public bool IsEnemyAvailable(EntityBase enemy, int maxCount)
		{
			return false;
		}

		public void AddEnemy(EntityBase entity)
		{
		}

		public void Clear()
		{
		}
	}

	private List<FallThunderVO> fallThunderVOList;

	private const string ADD = "+";

	private const string MINUS = "-";

	private float hpPercent;

	private string attrStr;

	private float killCDTime;

	private float killRate;

	private float flashChainCDTime;

	private float flashChainRate;

	private int iceThunderBuffId;

	private int fallThunderCount;

	private float fallCDTime;

	private int maxFallCountPerEnemy;

	private int fallThunderBuffId;

	private ConditionTime killCDCondition;

	private ConditionTime flashChainCDCondition;

	private Goods_goods.GoodData attrOne;

	private bool hasAdd;

	private List<ActionBasic> fallActionList;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void clearFallThunderVO()
	{
	}

	private void onCreatePlayer()
	{
	}

	private void createIceThunder(Vector3 pos)
	{
	}

	private EntityBase getAvailableEnemy(List<EntityBase> enemies, FallThunderVO fallThunderVO)
	{
		return null;
	}

	private GameObject createFallThunderEffect(Vector3 pos)
	{
		return null;
	}

	private void createFallThunder(Vector3 pos, float radius)
	{
	}

	private void onHit(EntityBase enemy, HitStruct hs, HittedData hd)
	{
	}

	private void onKill(EntityBase enemy, Vector3 vector, HitStruct hs)
	{
	}

	private void onChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void updateAttrByHPPercent(float percent)
	{
	}

	private void updateAttr(string sign)
	{
	}

	private void parseArgs0(string[] args)
	{
	}

	private void parseArgs1(string[] args)
	{
	}

	private void parseArgs2(string[] args)
	{
	}
}
