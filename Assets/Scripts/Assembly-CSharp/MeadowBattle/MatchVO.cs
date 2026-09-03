using System;
using Newtonsoft.Json;
using UnityEngine;

namespace MeadowBattle
{
	[Serializable]
	public class MatchVO
	{
		public bool isAI;

		public ulong userId;

		public string nickName;

		public int headIcon;

		public int headFrameId;

		[SerializeField]
		public ServerMonsterVO[] layout;

		[JsonIgnore]
		public bool HasBonusMonster;

		public int score;
	}
}
