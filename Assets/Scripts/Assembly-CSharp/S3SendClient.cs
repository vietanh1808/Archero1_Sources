using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Net;
using UnityEngine;
using UnityEngine.Networking;

public class S3SendClient : MonoBehaviour
{
	public enum S3SaveType
	{
		eLocaFile = 0,
		eObb = 1
	}

	public enum S3DownloadType
	{
		eBytes = 0,
		eString = 1
	}

	public class S3SendData
	{
		public string path;

		public S3DownloadType downloadtype;

		public S3SaveType savetype;

		public SendType sendtype;

		public Action callback;

		public Action<float> ondownloading;

		public bool bCanReload { get; private set; }

		public string localtag => null;

		private string get_tag_name => null;

		public bool IsForce => false;

		public bool IsCache => false;

		public bool IsLoop => false;

		public S3SendData(string path)
		{
		}

		public void do_callback()
		{
		}

		public void do_downloading(float percent)
		{
		}

		public string get_path()
		{
			return null;
		}

		public void update_localtag(string tag)
		{
		}

		public void check_can_reload()
		{
		}

		private void clear_localtag()
		{
		}

		public void Save(DownloadHandler handler)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CsendInternal_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public S3SendClient _003C_003E4__this;

		private UnityWebRequest _003C_uwr_003E5__2;

		private string _003Ctag_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CsendInternal_003Ed__52(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const string HTTPPATH = "https://config-archero.archerosvc.com/";

	private const string HTTPPATH_PRE = "https://config-archero-pre.archerosvc.com/";

	private const string HTTPPATH_TEST = "https://config-archero-test.archerosvc.com/";

	private const string HTTPPATH_DEV = "https://config-archero-dev.archerosvc.com/";

	public const string Folder_Config = "data/config";

	public const string Folder_TiledMap = "data/tiledmap";

	public const string Folder_Excel = "data/excel";

	public static readonly string Folder_ABS;

	public const string Config_Game = "game_config.json";

	public const string Config_BattlePass = "battlePassConfigData.json";

	public const string Config_EndlessReward = "dailySeasonData.json";

	public const string Config_Maze = "MazeConfig.json";

	public const string Config_MazeLine = "MazeLine.json";

	public const string Config_PVPSeason = "pvp_season.json";

	public const string Config_PVPReward = "pvp_reward.json";

	public const string Config_FarmSeason = "farm_pvp_season.json";

	public const string Config_FarmReward = "farm_pvp_rank_reward.json";

	public const string Config_PVEDivision = "pve_season_division.json";

	public const string Config_PVERankReward = "pve_stage_rank_reward.json";

	public const string Config_PVERankWeekReward = "pve_week_rank_reward.json";

	public const string Config_SailingRankReward = "ship_battle_season_rank_reward.json";

	public const string Config_PVESeason = "pve_season.json";

	public const string Config_ChoiceBox = "game_choice_box.json";

	public const string Config_WorldCup = "worldcup_matches.json";

	public const string Config_Christmas = "activity_christmas.json";

	public const string Config_Wish = "activity_wish.json";

	public const string Config_Treasure = "game_activity_treasure.json";

	public const string Config_GrowthFund = "growthIapConfigData.json";

	public const string Config_Lattice = "game_activity_lattice.json";

	public const string Config_NewPlay120 = "daily_endless_config.json";

	public const string Config_Bingo = "game_activity_bingo_reward.json";

	public const string Config_Fishing = "activity_fishing.json";

	public const string Config_CircleTreasure = "game_activity_circle_treasure.json";

	public const string Config_GardenTreasure = "game_activity_garden_treasure.json";

	public const string Config_Mountaineering = "game_activity_hiking.json";

	public const string Config_Hunting = "game_activity_hunting.json";

	public const string Config_Act6th = "game_activity_sixth_anniversary.json";

	public const string Config_Act6thMineCar = "game_activity_minecar.json";

	public const string Config_Act7th = "game_activity_7th_anniversary.json";

	private static Dictionary<string, int> mDownloadCounts;

	private S3SendData mData;

	private bool bCheckTag;

	public static bool IsHttpFormalPre()
	{
		return false;
	}

	public static string GetHTTPPATH()
	{
		return null;
	}

	public static bool get_can_redownload(string filepath)
	{
		return false;
	}

	public static void add_count(string filepath)
	{
	}

	public static void Send(S3SendData data)
	{
	}

	private static void Log(string value, params object[] args)
	{
	}

	public void StartSend(S3SendData packet)
	{
	}

	[IteratorStateMachine(typeof(_003CsendInternal_003Ed__52))]
	private IEnumerator sendInternal()
	{
		return null;
	}

	private void KillRequest(UnityWebRequest request)
	{
	}
}
