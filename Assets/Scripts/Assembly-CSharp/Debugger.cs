using System;
using System.Diagnostics;

public class Debugger
{
	public enum Tag
	{
		eHTTP = 0,
		ePurchase = 1,
		eTest = 2,
		eGameCenterLogin = 3,
		eGooglePlay = 4,
		eTips = 5,
		eBugly = 6,
		eHighECPM = 7,
		eWebView = 8,
		eObb = 9,
		eDeepLink = 10,
		eBattlePass = 11,
		eS3 = 12,
		eGuide = 13,
		eKey = 14,
		eSystemEvent = 15,
		ePopWindow = 16,
		eGaming = 17,
		eUI = 18,
		eCommonData = 19,
		eEquip = 20,
		eMD5 = 21,
		eAdjust = 22,
		eScrollRect = 23,
		eBuff = 24
	}

	public static bool _debug;

	public static bool _openDebug;

	public const string Battle_Start = "战斗-开始";

	public const string Battle_End = "战斗-结束";

	public const string Battle_CharLevelUp = "战斗-冒险等级提升";

	public const string Battle_Black_Buy = "战斗-神秘商店购买";

	public const string Battle_BlackAd_Get = "战斗-广告神秘商店获得";

	public const string Battle_Reborn = "战斗-使用复活";

	public const string Battle_FirstGold_Get = "战斗-初始金币转盘获得";

	public const string Battle_Angel = "战斗-天使房 选择";

	public const string Battle_Demon = "战斗-恶魔房 选择";

	public const string Battle_Boss_Turn = "战斗-Boss转盘 获得";

	public const string Battle_Pass_Chapter = "战斗-通过章节";

	public const string Battle_LevelUp_LearnSkill = "战斗-升级技能学习";

	public const string Main_Change_Page = "主页-切换页签";

	public const string Main_StageList_Choose = "主页-进行章节选择";

	public const string Main_LayerBox_Get = "主页-获得关卡宝箱";

	public const string Main_Key_Buy = "主页-购买体力";

	public const string Main_Key_Ad = "主页-看广告得体力";

	public const string Main_Key_Not_Enough = "主页-战斗体力不够";

	public const string Main_Key_Trust_Not_Enough = "主页-体力-信用值不够";

	public const string Main_Key_Trust_Use = "主页-体力-信用值使用";

	public const string Main_Key_Unlogin_Not_Enough = "主页-体力-未登录 体力不够";

	public const string Main_Mail_Get = "主页-获得邮件";

	public const string Main_Harvest_Get = "主页-收获挂机";

	public const string Main_Gold_to_Shop = "主页-金币跳转商店";

	public const string Main_Diamond_to_Shop = "主页-钻石跳转商店";

	public const string Main_Shop_Buy_Discount = "主页-商店-购买章节礼包";

	public const string Main_Shop_Open_NormalBox = "主页-商店-打开普通宝箱";

	public const string Main_Shop_Open_LargeBox = "主页-商店-打开高级宝箱";

	public const string Main_Shop_Buy_Diamond = "主页-商店-购买钻石";

	public const string Main_Shop_Buy_StarDiamond = "主页-商店-购买星钻";

	public const string Main_Shop_Buy_Gold = "主页-商店-购买金币";

	public const string Main_Char_Wear_Equip = "主页-装备-穿装备";

	public const string Main_Char_Unwear_Equip = "主页-装备-卸装备";

	public const string Main_Char_LevelUp_Equip = "主页-装备-升级装备";

	public const string Main_Char_Combine_Begin = "主页-装备-开始合成";

	public const string Main_Char_Combine_Combining = "主页-装备-成功合成";

	public const string Main_Char_Sort = "主页-装备-排序";

	public const string Main_Card_LevelUp = "主页-天赋-升级";

	public const string Main_Setting_Sound = "主页-设置-音效";

	public const string Main_Setting_Music = "主页-设置-音乐";

	public const string Main_Setting_Quality = "主页-设置-画质";

	public const string Main_Setting_Language_Choose = "主页-设置-选择多语言";

	public const string Main_Setting_Change_Server = "主页-设置-切换服务器";

	public const string Main_Shop_Open_DiamondLarge10 = "主页-商店-打开黑曜石十连抽宝箱";

	public const string Equip_BreakDown_Success = "装备-分解-分解成功";

	public const string Main_EquipBuy = "主页-智能推荐-购买装备";

	public const string Pve_Season = "赛季";

	public static bool bDebug => false;

	public static bool bOpenDebug => false;

	private static string Format(Tag tag, string value, params object[] args)
	{
		return null;
	}

	private static string Format(string value, params object[] args)
	{
		return null;
	}

	[Conditional("EnableLog")]
	public static void Log(string value)
	{
	}

	[Conditional("EnableLog")]
	public static void LogBigMap(string value)
	{
	}

	[Conditional("EnableLog")]
	public static void Log(string value, params object[] args)
	{
	}

	[Conditional("EnableLog")]
	public static void LogFormat(string value, params object[] args)
	{
	}

	[Conditional("EnableLog")]
	public static void Log(Tag tag, string value)
	{
	}

	[Conditional("EnableLog")]
	public static void Log(Tag tag, string value, params object[] args)
	{
	}

	[Conditional("EnableLog")]
	public static void Log(EntityBase entity, string value)
	{
	}

	[Conditional("EnableLog")]
	public static void LogStep(string step, string info)
	{
	}

	[Conditional("EnableLog")]
	public static void LogStep(string step)
	{
	}

	[Conditional("EnableLog")]
	public static void LogStepOpen(string name)
	{
	}

	[Conditional("EnableLog")]
	public static void LogStepClose(string name)
	{
	}

	[Conditional("EnableLog")]
	public static void LogEquipGet(string value)
	{
	}

	[Conditional("EnableLog")]
	public static void LogBullet(BulletBase bullet, string value)
	{
	}

	[Conditional("EnableLog")]
	public static void LogError(string error, params object[] args)
	{
	}

	[Conditional("EnableLog")]
	public static void LogError(short? code)
	{
	}

	[Conditional("EnableLog")]
	public static void LogErrorFormat(string value, params object[] args)
	{
	}

	[Conditional("EnableLog")]
	public static void LogError(Exception e)
	{
	}

	[Conditional("EnableLog")]
	public static void LogWarning(string error, params object[] args)
	{
	}

	[Conditional("EnableLog")]
	public static void LogWarningFormat(string error, params object[] args)
	{
	}

	[Conditional("EnableLog")]
	public static void LogException(Exception e)
	{
	}

	[Conditional("EnableLog")]
	public static void LogDiamond(string log)
	{
	}

	[Conditional("EnableLog")]
	public static void LogStarDiamond(string log)
	{
	}

	[Conditional("EnableLog")]
	public static void LogStarDiamond(string format, params object[] args)
	{
	}

	[Conditional("EnableLog")]
	public static void LogPveSeason(string log)
	{
	}

	[Conditional("EnableLog")]
	public static void NSLog(string log)
	{
	}
}
