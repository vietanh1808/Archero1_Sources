using System.Collections.Generic;

namespace NewPlay125
{
	public class SingleWaveVO
	{
		private const string LOG_TAG = "[SingleWaveVO]";

		public string[] WaveIDs;

		public string[] WaveIDs1;

		public int[] Several;

		public int[] Nest;

		public int[] NestNum;

		public int TotalCnt;

		public int MinCnt;

		public int MaxCnt;

		public float Interval;

		public int RoomId;

		public List<SingleWaveGoodVO> goodsList;

		public RoomGenerateBase.RoomType roomType;

		private WavesVO wavesVO;

		private int curGoodCount;

		private ActionBasic eventFinishDelayAction;

		private ActionBasic generateMonsterAction;

		private bool initialized;

		private bool isWaveGoodsCreated;

		public bool IsWaveGoodsCreated => false;

		public SingleWaveVO(WavesVO _wavesVO)
		{
		}

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		private void initRoomType()
		{
		}

		private void initNestNum()
		{
		}

		public int GetNestId()
		{
			return 0;
		}

		public int GetMaxType()
		{
			return 0;
		}

		public bool IsEventWave()
		{
			return false;
		}

		public bool IsBossWave()
		{
			return false;
		}

		public bool IsNormalWave()
		{
			return false;
		}
	}
}
