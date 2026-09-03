using System;
using System.Collections.Generic;
using System.Text;
using GameProtocol;
using Habby.Guild.Data;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public static class GameUtils
{
	private static StringBuilder sb;

	private const long k = 1000L;

	private const long m = 1000000L;

	private const long b = 1000000000L;

	private const long t = 1000000000000L;

	private const float fk = 1000f;

	private const float fm = 1000000f;

	private const float fb = 1E+09f;

	private const float ft = 1E+12f;

	private static DelegateBridge __Hotfix0_SetHeadFrameEffect;

	private static DelegateBridge __Hotfix0_CheckPosIsInside;

	private static DelegateBridge __Hotfix0_Clone;

	private static DelegateBridge __Hotfix0_ToLanguage;

	private static DelegateBridge __Hotfix0_CheckGuid;

	private static DelegateBridge __Hotfix0_IsLanguageKeyContains;

	private static DelegateBridge __Hotfix0_ToLanguageUpdate;

	private static DelegateBridge __Hotfix0_ToCountDown;

	private static DelegateBridge __Hotfix0_ToCountDownNum;

	private static DelegateBridge __Hotfix0_SetVirtual;

	private static DelegateBridge __Hotfix0_SetCanvasGroup;

	private static DelegateBridge __Hotfix1_SetCanvasGroup;

	private static DelegateBridge __Hotfix0_Divide;

	private static DelegateBridge __Hotfix1_Divide;

	private static DelegateBridge __Hotfix2_Divide;

	private static DelegateBridge __Hotfix3_Divide;

	private static DelegateBridge __Hotfix4_Divide;

	private static DelegateBridge __Hotfix5_Divide;

	private static DelegateBridge __Hotfix0_DivideDouble;

	private static DelegateBridge __Hotfix1_DivideDouble;

	private static DelegateBridge __Hotfix0_ToTenThousandFloat;

	private static DelegateBridge __Hotfix0_Divide1000;

	private static DelegateBridge __Hotfix1_Divide1000;

	private static DelegateBridge __Hotfix0_ToInt;

	private static DelegateBridge __Hotfix0_ParseReward;

	private static DelegateBridge __Hotfix0_GetRewardData;

	private static DelegateBridge __Hotfix1_GetRewardData;

	private static DelegateBridge __Hotfix2_GetRewardData;

	private static DelegateBridge __Hotfix0_ToIntArray;

	private static DelegateBridge __Hotfix0_ShowReward;

	private static DelegateBridge __Hotfix1_ShowReward;

	private static DelegateBridge __Hotfix0_ShowRewardWithLevelUp;

	private static DelegateBridge __Hotfix1_ShowRewardWithLevelUp;

	private static DelegateBridge __Hotfix0_IsPassDay;

	private static DelegateBridge __Hotfix0_ToAbbreviated;

	private static DelegateBridge __Hotfix0_ToAbbreviatedSweep;

	private static DelegateBridge __Hotfix1_ToAbbreviated;

	private static DelegateBridge __Hotfix2_ToAbbreviated;

	private static DelegateBridge __Hotfix0_GetDayLeftTime;

	private static DelegateBridge __Hotfix0_IsSameDay;

	private static DelegateBridge __Hotfix0_ConvertImChatMsgStatus;

	private static DelegateBridge __Hotfix0_CalculateRemainingTime;

	private static DelegateBridge __Hotfix0_SetItemName;

	private static DelegateBridge __Hotfix1_SetItemName;

	private static DelegateBridge __Hotfix0_RoundToInt;

	private static DelegateBridge __Hotfix0_ToAbbreviatedFloatTow;

	private static DelegateBridge __Hotfix1_ToAbbreviatedFloatTow;

	private static DelegateBridge __Hotfix0_ParseQualityArgs;

	private static DelegateBridge __Hotfix0_UseProp;

	private static DelegateBridge __Hotfix0_ClearProp;

	private static DelegateBridge __Hotfix1_UseProp;

	private static DelegateBridge __Hotfix0_HavePropCount;

	private static DelegateBridge __Hotfix1_HavePropCount;

	private static DelegateBridge __Hotfix0_GetPropSprite;

	private static DelegateBridge __Hotfix0_GetPropName;

	private static DelegateBridge __Hotfix0_GetRandom;

	private static DelegateBridge __Hotfix0_RandomReachProb;

	private static DelegateBridge __Hotfix0_GetColor;

	private static DelegateBridge __Hotfix0_GetColorValue;

	private static DelegateBridge __Hotfix0_CombineSameDrop;

	private static DelegateBridge __Hotfix0_ToNewPlay125WeaponType;

	private static DelegateBridge __Hotfix0_GetBezierCurveWithThreePoints;

	private static DelegateBridge __Hotfix0_GetTextEndPosition;

	private static DelegateBridge __Hotfix0_SetAllChildsActive;

	private static DelegateBridge __Hotfix0_ChapterToId;

	private static DelegateBridge __Hotfix1_ChapterToId;

	private static DelegateBridge __Hotfix0_IdToChapter;

	private static DelegateBridge __Hotfix0_RewardsString;

	private static DelegateBridge __Hotfix0_ToKAndM;

	private static DelegateBridge __Hotfix1_ToKAndM;

	private static DelegateBridge __Hotfix2_ToKAndM;

	private static DelegateBridge __Hotfix3_ToKAndM;

	private static DelegateBridge __Hotfix0_DropListToRewardList;

	private static DelegateBridge __Hotfix1_DropListToRewardList;

	private static DelegateBridge __Hotfix0_GetRadiusEntity;

	private static DelegateBridge __Hotfix0_SetWeaponColor;

	private static DelegateBridge __Hotfix1_SetWeaponColor;

	private static DelegateBridge __Hotfix0_SetWeaponSurroundingFx;

	public static GameObject SetHeadFrameEffect(this Image img, int headFrameId, float? width = null, int addLayer = 3)
	{
		return null;
	}

	public static bool CheckPosIsInside(this Vector3 pos, RectTransform rectTransform)
	{
		return false;
	}

	public static List<int> Clone(this List<int> key)
	{
		return null;
	}

	public static string ToLanguage(this string key, params object[] args)
	{
		return null;
	}

	public static void CheckGuid(this Transform trans, int guidSystem, int lastIndex)
	{
	}

	public static bool IsLanguageKeyContains(this string key)
	{
		return false;
	}

	public static string ToLanguageUpdate(this string value)
	{
		return null;
	}

	public static string ToCountDown(this long time)
	{
		return null;
	}

	public static string ToCountDownNum(this long time)
	{
		return null;
	}

	public static void SetVirtual(this GameObject gameObject, bool active)
	{
	}

	public static void SetCanvasGroup(this CanvasGroup canvasGroup, bool active)
	{
	}

	public static void SetCanvasGroup(this CanvasGroup canvasGroup, bool active, bool blocksRaycasts)
	{
	}

	public static float Divide(this int first, int second)
	{
		return 0f;
	}

	public static float Divide(this int first, float second)
	{
		return 0f;
	}

	public static float Divide(this ulong first, ulong second)
	{
		return 0f;
	}

	public static float Divide(this float first, int second)
	{
		return 0f;
	}

	public static float Divide(this float first, float second)
	{
		return 0f;
	}

	public static float Divide(this long first, long second)
	{
		return 0f;
	}

	public static double DivideDouble(this int first, int second)
	{
		return 0.0;
	}

	public static double DivideDouble(this long first, long second)
	{
		return 0.0;
	}

	public static float ToTenThousandFloat(this int number)
	{
		return 0f;
	}

	public static float Divide1000(this int first)
	{
		return 0f;
	}

	public static float Divide1000(this long first)
	{
		return 0f;
	}

	public static int[] ToInt(this string[] strings)
	{
		return null;
	}

	public static (List<Drop_DropModel.DropData>, int, int) ParseReward(this CRewardItem[] items)
	{
		return default;
	}

	public static List<Drop_DropModel.DropData> GetRewardData(this List<List<int>> rewards)
	{
		return null;
	}

	public static List<Drop_DropModel.DropData> GetRewardData(this int[][] rewards)
	{
		return null;
	}

	public static Drop_DropModel.DropData GetRewardData(this CRewardItem item)
	{
		return null;
	}

	public static int[][] ToIntArray(this string[] rewards)
	{
		return null;
	}

	public static void ShowReward(this List<Drop_DropModel.DropData> dropList, Action close = null, int addGold = 0, int addDiamond = 0)
	{
	}

	public static void ShowReward(this CRewardItem[] rewardItem, Action close = null, bool showAddGold = true, bool showAddDiamond = true)
	{
	}

	public static void ShowRewardWithLevelUp(this List<Drop_DropModel.DropData> dropList, int oldLevel, int newLevel, Action close = null, int addGold = 0, int addDiamond = 0)
	{
	}

	public static void ShowRewardWithLevelUp(this CRewardItem[] rewardItem, int oldLevel, int newLevel, Action close = null, bool showAddGold = true, bool showAddDiamond = true)
	{
	}

	public static bool IsPassDay(this long compareTime)
	{
		return false;
	}

	public static string ToAbbreviated(this int number)
	{
		return null;
	}

	public static string ToAbbreviatedSweep(this int number)
	{
		return null;
	}

	public static string ToAbbreviated(this long number)
	{
		return null;
	}

	public static string ToAbbreviated(this ulong number)
	{
		return null;
	}

	public static long GetDayLeftTime(this long nowTime)
	{
		return 0L;
	}

	public static bool IsSameDay(this long time1, long time2)
	{
		return false;
	}

	public static void ConvertImChatMsgStatus(IMMessageStatus messageState, ChatMsgDataChat cmdc)
	{
	}

	public static string CalculateRemainingTime(long banTimestamp)
	{
		return null;
	}

	public static void SetItemName(this Text _text, int _type, int _id, bool _isChangeColor = false, int count = 0)
	{
	}

	public static string SetItemName(int _type, int _id)
	{
		return null;
	}

	public static int RoundToInt(this float num)
	{
		return 0;
	}

	public static float ToAbbreviatedFloatTow(this float num)
	{
		return 0f;
	}

	public static float ToAbbreviatedFloatTow(this double num)
	{
		return 0f;
	}

	public static string[] ParseQualityArgs(this string[] args, string qualityName)
	{
		return null;
	}

	public static void UseProp(this int propID, int count)
	{
	}

	public static void ClearProp(this int propID)
	{
	}

	public static void UseProp(this Drop_DropModel.DropData prop)
	{
	}

	public static ulong HavePropCount(this Drop_DropModel.DropData prop)
	{
		return 0uL;
	}

	public static int HavePropCount(this int propID)
	{
		return 0;
	}

	public static Sprite GetPropSprite(this Drop_DropModel.DropData prop)
	{
		return null;
	}

	public static string GetPropName(this Drop_DropModel.DropData prop)
	{
		return null;
	}

	public static T GetRandom<T>(this IList<T> list)
	{
		return default;
	}

	public static bool RandomReachProb(this int num, int minRandomNum = 0, int maxRandomNum = 100)
	{
		return false;
	}

	public static Color GetColor(this int quality)
	{
		return default;
	}

	public static string GetColorValue(this int quality)
	{
		return null;
	}

	public static List<Drop_DropModel.DropData> CombineSameDrop(this List<Drop_DropModel.DropData> list)
	{
		return null;
	}

	public static NewPlay125WeaponType ToNewPlay125WeaponType(this int weaponID)
	{
		return NewPlay125WeaponType.None;
	}

	public static Vector3[] GetBezierCurveWithThreePoints(Vector3 point_1, Vector3 point_2, Vector3 point_3, int vertexCount)
	{
		return null;
	}

	public static Vector3 GetTextEndPosition(this Text targetText)
	{
		return default;
	}

	public static void SetAllChildsActive(this Transform parent, bool isShow)
	{
	}

	public static int ChapterToId(this int chapter, GameMode mode)
	{
		return 0;
	}

	public static int ChapterToId(this int chapter)
	{
		return 0;
	}

	public static int IdToChapter(this int id)
	{
		return 0;
	}

	public static string RewardsString(this uint[][] rewards)
	{
		return null;
	}

	public static string ToKAndM(this int i)
	{
		return null;
	}

	public static string ToKAndM(this uint i)
	{
		return null;
	}

	public static string ToKAndM(this long i)
	{
		return null;
	}

	public static string ToKAndM(this ulong i)
	{
		return null;
	}

	public static string DropListToRewardList(this List<Drop_DropModel.DropData> dropList)
	{
		return null;
	}

	public static string DropListToRewardList(this List<LocalSave.EquipOne> dropList)
	{
		return null;
	}

	public static List<EntityBase> GetRadiusEntity(this List<EntityBase> entityList, Vector3 originPos, float radius)
	{
		return null;
	}

	public static void SetWeaponColor(this GameObject weaponObject, int colorID)
	{
	}

	public static void SetWeaponColor(this GameObject weaponObject, string colorTex)
	{
	}

	public static void SetWeaponSurroundingFx(this GameObject weaponObject, int colorID, int layer, int index = 0)
	{
	}
}
