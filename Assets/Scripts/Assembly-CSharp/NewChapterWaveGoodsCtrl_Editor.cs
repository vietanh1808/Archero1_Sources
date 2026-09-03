using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class NewChapterWaveGoodsCtrl_Editor
{
	private class GoodsWeight
	{
		public int id;

		public int weight;

		public int maxCount;

		public GoodsWeight(int id, int weight, int maxCount)
		{
		}
	}

	private class GoodsPos
	{
		public int tileId;

		public Vector2Int pos;

		public GoodsPos(int x, int y, int id)
		{
		}
	}

	public const string FirstRoomTmx = "firstroom";

	public const string EmptyRoomTmx = "emptyroom";

	private List<string> CullingMapIds;

	private Dictionary<int, int> bossShieldWaves;

	private XmlDocument xmlDoc;

	private XmlNodeList xmlNodes;

	public void Init(string mapStr)
	{
	}

	public void InitByPath(string path)
	{
	}

	public void clear()
	{
	}

	public List<SingleWaveGoodVO> GetSingleWaves(string waveId, string[] waveIDs, string[] WaveIDs1, int[] Several, int[] Nest)
	{
		return null;
	}

	private int[] GetMonsters(int nest, int spareNest, int maxType, int posCount)
	{
		return null;
	}

	private List<GoodsWeight> RandomMonster(int nestID, int maxType)
	{
		return null;
	}

	protected string RandomId(string[] ids, XRandom random)
	{
		return null;
	}

	private void AddUsedTmx(string tmxid)
	{
	}

	public int[,] GetTileDataById(string id)
	{
		return null;
	}

	public XmlNode GetMapNodeById(string id)
	{
		return null;
	}

	private bool CanRandomTmx(string roomid)
	{
		return false;
	}
}
