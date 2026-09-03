using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TableTool;
using UnityEngine;
using UnityEngine.Events;

namespace Dxx.Util
{
	public static class Utils
	{
		public enum PriceDiscountType
		{
			PERCENT_OFF = 0,
			DIVIDER = 1
		}

		public enum WallType
		{
			up = 0,
			down = 1,
			left = 2,
			right = 3
		}

		public static readonly Regex s_HrefRegex;

		public static readonly Regex s_LinkRegex;

		private static Vector3 GetDirection_dir;

		private static float getAngle_angle;

		private static StringBuilder mStringBudier;

		private static StringBuilder mFormatStringBudier;

		private static object mFormatLock;

		private static StringBuilder mFormatStringBudierThread;

		private static object mFormatThreadLock;

		private static float timestamp_offset;

		private static long timestamp_ret;

		private static DateTime dtStart;

		private static StringBuilder stringGetSecond3String;

		private static StringBuilder stringGetSecond2String;

		private static char[] purchaseNumbers;

		public static List<int> UintAryToIntList(this uint[] ary)
		{
			return null;
		}

		public static int CheckVectorSide(Vector3 a, Vector3 b)
		{
			return 0;
		}

		public static int CheckVectorSide2(this Vector3 a, Vector3 b)
		{
			return 0;
		}

		public static bool IsFloatEqual(float a, float b)
		{
			return false;
		}

		public static List<string> GetListDifference(List<string> list1, List<string> list2)
		{
			return null;
		}

		public static float getAngle(Vector2 dir)
		{
			return 0f;
		}

		public static float getAngle(Vector3 dir)
		{
			return 0f;
		}

		public static Vector3 GetViewport(float x, float y)
		{
			return default;
		}

		public static bool IsOutOfUICamera(Vector3 worldPos)
		{
			return false;
		}

		public static Vector3 World2Screen(Vector3 worldpos)
		{
			return default;
		}

		public static List<UnityAction> GetPersistentListeners(this UnityEvent unityEvent)
		{
			return null;
		}

		public static string ReplaceBreakingSpace(this string str)
		{
			return null;
		}

		public static Vector3 GetDirection(float angle)
		{
			return default;
		}

		public static float getAngle(float x, float y)
		{
			return 0f;
		}

		public static float GetFloat1(float f)
		{
			return 0f;
		}

		public static float GetFloat2(float f)
		{
			return 0f;
		}

		public static float GetFloat3(float f)
		{
			return 0f;
		}

		public static int Ceil(float value)
		{
			return 0;
		}

		public static int Floor(float value)
		{
			return 0;
		}

		public static string GetString(params object[] args)
		{
			return null;
		}

		public static string FormatString(string format, params object[] args)
		{
			return null;
		}

		public static string FormatStringForData(string format, params object[] args)
		{
			return null;
		}

		public static string FormatStringThread(string format, params object[] args)
		{
			return null;
		}

		public static float ExcuteReboundWall(float angle, Vector3 pos, GameObject o)
		{
			return 0f;
		}

		public static float ExcuteReboundWallRedLine(Transform transform, Collider o)
		{
			return 0f;
		}

		public static float ExcuteReboundWallSkill(float angle, Vector3 position, SphereCollider s, Collider o)
		{
			return 0f;
		}

		public static Vector3 ExcuteReboundWallSide(float angle, Vector3 position, SphereCollider s, Collider o)
		{
			return default;
		}

		public static float ExcuteReboundWallSkill(float angle, Vector3 position, Collider o)
		{
			return 0f;
		}

		public static float ExcuteReboundWall(Vector3 position, float angle, Collider o, float offsetdir)
		{
			return 0f;
		}

		public static Vector3 ExcuteReboundWallSide(Vector3 position, float angle, Collider o, float offsetdir)
		{
			return default;
		}

		public static long GetTimeStamp()
		{
			return 0L;
		}

		public static bool IsElementBullet(Weapon_weapon data, EElementType type)
		{
			return false;
		}

		public static long GetCurrentMilliSecond()
		{
			return 0L;
		}

		public static long GetLocalTime()
		{
			return 0L;
		}

		public static DateTime GetCurrentDataTime()
		{
			return default;
		}

		public static TimeSpan GetTimeGoDays(double d)
		{
			return default;
		}

		public static string GetTimeGo(double d)
		{
			return null;
		}

		public static string NormalizeTimpstamp0(long timpStamp)
		{
			return null;
		}

		public static bool isInVersion(string a, string b)
		{
			return false;
		}

		public static string GetSecond3String(long second)
		{
			return null;
		}

		public static string GetSecond2String(int second)
		{
			return null;
		}

		public static TimeSpan GetTime(long second)
		{
			return default;
		}

		public static DateTime ConvertIntDateTime(double d)
		{
			return default;
		}

		public static double ConvertDateTimeInt(DateTime time)
		{
			return 0.0;
		}

		public static long DateTimeToUnixTimestamp(DateTime dateTime, bool milliseconds = true)
		{
			return 0L;
		}

		public static DateTime UnixTimestampToDateTime(DateTime target, long timestamp)
		{
			return default;
		}

		public static DateTime GetDateTime(long timestamp)
		{
			return default;
		}

		public static long GetTimeStamp(DateTime dateTime)
		{
			return 0L;
		}

		public static bool GetTimePassDay(long ptime, long timeEndToday)
		{
			return false;
		}

		public static string CutString(string str, int maxlength)
		{
			return null;
		}

		public static float GetBulletAngle(int current, int count, float allangle)
		{
			return 0f;
		}

		public static void ClearEvents(this object ctrl)
		{
		}

		public static string GenerateUUID()
		{
			return null;
		}

		public static string ToHexString(byte[] bytes)
		{
			return null;
		}

		public static byte[] StringToByteArray(string hex)
		{
			return null;
		}

		public static string ByteArrayToString(byte[] bytes)
		{
			return null;
		}

		public static bool TryJsonConvert<T>(string json, out T data) where T : new()
		{
			data = default;
			return false;
		}

		public static bool TryParseFloat(string str, out float value)
		{
			value = default;
			return false;
		}

		public static float ParseFloat(string str)
		{
			return 0f;
		}

		public static int ParseInt(string str)
		{
			return 0;
		}

		public static long ParseLong(string str)
		{
			return 0L;
		}

		public static ulong ParseUlong(string str)
		{
			return 0uL;
		}

		public static bool TryParseInt(string str, out int value)
		{
			value = default;
			return false;
		}

		public static bool TryParseLong(string str, out long value)
		{
			value = default;
			return false;
		}

		public static bool TryParseUlong(string str, out ulong value)
		{
			value = default;
			return false;
		}

		public static T DeserializeObject<T>(string json)
		{
			return default;
		}

		public static int GetPassDay(long time1, long time2)
		{
			return 0;
		}

		public static float GetPrice(string value)
		{
			return 0f;
		}

		public static string CalculateOldPrice(string priceString, int discount, PriceDiscountType discountType)
		{
			return null;
		}

		public static string GetMutiPrice(string value, int multiple)
		{
			return null;
		}

		private static bool isPurchaseNumber(char value)
		{
			return false;
		}

		private static (string, bool) GetPurchaseNumberSymbol(string value)
		{
			return default;
		}

		private static (int, int) GetPurchaseNumberSymbolIndex(string value)
		{
			return default;
		}

		public static T GetCondition<T>(int value)
		{
			return default;
		}

		public static bool IsNumeric(string Value)
		{
			return false;
		}

		public static bool ContainProperty(this object instance, string propertyName)
		{
			return false;
		}

		public static TResout GetObjectPropertyValue<T, TResout>(T t, string propertyname) where TResout : struct
		{
			return default;
		}

		public static TResout[] GetObjectPropertyValues<T, TResout>(T t, string propertyname)
		{
			return null;
		}

		public static bool IsNullOrEmpty<T>(this IList<T> list)
		{
			return false;
		}

		public static IEnumerable<TSource> Duplicates<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selecter)
		{
			return null;
		}

		public static IEnumerable<TSource> Duplicates<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		public static bool IsMultiple<T>(this IEnumerable<T> source)
		{
			return false;
		}

		public static bool HasDuplicateValue(this int[] arr)
		{
			return false;
		}

		public static void PrintDuplicateInfo(this int[] arr)
		{
		}

		public static bool JudgeCoorPosFan(Vector3 origin, Vector3 point, float rotation, float angleRange)
		{
			return false;
		}

		public static bool IsInCross(Vector3 target, Vector3 tower, float crossWide)
		{
			return false;
		}

		public static string GetFileNameWithExtension(string fullFileName)
		{
			return null;
		}

		public static string GetFileNameWithoutExtension(string fullFileName)
		{
			return null;
		}

		public static string GetFilePath(string fullFileName)
		{
			return null;
		}

		public static string FormatBytes(long bytes)
		{
			return null;
		}

		public static bool HaveDiskspace(long diskSize)
		{
			return false;
		}

		public static float GetFlySwordCreateInterval(EntityBase sendFlySwordEntity, float originInterval, float exponent, float max, Func<float, float> calcDelayResult = null)
		{
			return 0f;
		}

		public static (Vector3, float) GetFlySwordCreatePosData(EntityBase sendFlySwordEntity, EntityBase sendFlySwordTarget)
		{
			return default;
		}

		public static (Vector3, float) GetFlySwordCreatePosData(Vector3 sendFlySwordEntityPos, Vector3 sendFlySwordTargetPos)
		{
			return default;
		}

		public static EntityPartBodyBase CallOneInternal(EntityBase entity, int partID, float partBodyLastTime, int createPosRange, int createPosCount, int inheritParentAttack, int inheritParentAttackSpeed)
		{
			return null;
		}

		public static string GetWeaponPathByNode(int nWeaponNode, int weaponHandId)
		{
			return null;
		}

		public static IList<int> CheckSkillCount(this IList<int> skillList, int needSkillCount = 9)
		{
			return null;
		}

		public static IList<T> CheckSkillCount<T>(this IList<T> skillList, int needSkillCount = 9)
		{
			return null;
		}

		public static void RestartPar(this ParticleSystem particleSystem)
		{
		}

		public static T GetValueByIndex<T>(this T[] array, int index)
		{
			return default;
		}

		public static Vector3 GetMapWallPosFromCenter(WallType wallType)
		{
			return default;
		}
	}
}
