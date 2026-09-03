using TCPPacket;
using TableTool;
using UnityEngine;

public class CreatePartBodyCommand : BaseCommand
{
	public Vector3 position;

	public Goods_goods.GoodData[] attrs;

	public int partId;

	public int aliveTime;

	public int[] skillArray;

	public int weaponId;

	public int[] elementDebuffs;

	public float deltaBodyScale;

	public float parentAttackSpeed;

	public int[] parentSkillIds;

	public override CommandType GetType()
	{
		return CommandType.Move;
	}

	public override void Clear()
	{
	}

	public override void InitByTcpPacket(TcpPacketBase packet)
	{
	}

	public override TcpPacketBase ToPacket(int guid)
	{
		return null;
	}
}
