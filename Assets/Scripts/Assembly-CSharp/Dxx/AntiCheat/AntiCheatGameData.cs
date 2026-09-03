using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

namespace Dxx.AntiCheat
{
	public class AntiCheatGameData
	{
		public ObscuredBool IsOpponentAttrCheating;

		public ObscuredBool IsEntityColliderDisabled;

		public List<ObscuredLong> hitList;

		public List<ObscuredLong> hpList;

		public ObscuredString HpExceptionInfo;

		public ObscuredLong CurHP;

		public ObscuredInt PauseCount;

		public PvpHeroAttrVO HeroAttrVOAfterPvp;

		public PvpHeroAttrVO HeroAttrVOAtTheBeginning;

		public PvpHeroAttrVO HeroAttrVOBeforePvp;

		public PvpHeroAttrVO HeroAttrVOMatchTouching;

		public ObscuredBool PassDoor;

		public ObscuredBool IsFullHP;

		public ObscuredFloat PvpGameDuration;

		public SortedDictionary<ObscuredInt, ObscuredInt> MsgDict;

		public ObscuredInt[] MatchTouchingSkillIds { get; set; }

		public ObscuredInt[] BeginningSkillIds { get; set; }

		public ObscuredInt[] SkillIdsBeforePvp { get; set; }

		public ObscuredInt[] SkillIdsAfterPvp { get; set; }

		public PvpHeroVO HeroVOBeforePvpStarted { get; set; }

		public ObscuredInt[] SlotinPvpSkillIdsBeforePvpStarted { get; set; }

		public ObscuredInt[] SlotinPvpSkillIdsAfterPvpFinished { get; set; }

		public bool IsIllegalCurHp => false;

		public void Init()
		{
		}

		public void RandomizeCryptoKeyInPvp()
		{
		}

		public void ClearPvpRecordData()
		{
		}

		public void UpdateMsgDict(ObscuredInt key)
		{
		}

		public void IncreasePauseCount()
		{
		}

		public long GetTotalHit()
		{
			return 0L;
		}

		public long GetHitCount()
		{
			return 0L;
		}

		public long GetTotalHp()
		{
			return 0L;
		}

		public void PrintMethodLog(string methodName)
		{
		}

		public string PrintMsgDictInfo()
		{
			return null;
		}
	}
}
