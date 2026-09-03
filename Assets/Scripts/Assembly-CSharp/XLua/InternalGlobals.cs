using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Dxx.Net;
using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua.LuaDLL;

namespace XLua
{
	internal class InternalGlobals
	{
		private delegate List<int> __GEN_DELEGATE0(uint[] ary);

		private delegate List<UnityAction> __GEN_DELEGATE1(UnityEvent unityEvent);

		private delegate string __GEN_DELEGATE2(string str);

		private delegate bool __GEN_DELEGATE3(int[] arr);

		private delegate void __GEN_DELEGATE4(int[] arr);

		private delegate IList<int> __GEN_DELEGATE5(IList<int> skillList, int needSkillCount);

		private delegate bool __GEN_DELEGATE6(string str, out float value);

		private delegate float __GEN_DELEGATE7(string str);

		private delegate int __GEN_DELEGATE8(string str);

		private delegate long __GEN_DELEGATE9(string str);

		private delegate ulong __GEN_DELEGATE10(string str);

		private delegate string __GEN_DELEGATE11(Color32 color);

		private delegate Color __GEN_DELEGATE12(string hex);

		private delegate string __GEN_DELEGATE13(int num);

		private delegate float __GEN_DELEGATE14(Text text);

		private delegate float __GEN_DELEGATE15(Text text);

		private delegate IEnumerator __GEN_DELEGATE16(Animation animation, string clipName, bool useTimeScale, Action onComplete);

		private delegate void __GEN_DELEGATE17(GraphicRaycaster gRaycaster);

		private delegate string __GEN_DELEGATE18(Goods_goods.GoodData prop);

		private delegate string __GEN_DELEGATE19(Goods_goods.GoodData prop);

		private delegate string __GEN_DELEGATE20(Goods_goods.GoodData prop);

		private delegate bool __GEN_DELEGATE21(EntityBase entity, out Vector3 viewPos);

		private delegate NetBox __GEN_DELEGATE22(CProtocolBase packet, SendType sendtype);

		private delegate void __GEN_DELEGATE23(Text text, float minFontSize, float maxFontSize, float stepSize);

		private delegate void __GEN_DELEGATE24(Image img, bool selected, Color selectColor, bool isInMask);

		private delegate GameObject __GEN_DELEGATE25(Image img, int headFrameId, float? width, int addLayer);

		private delegate string __GEN_DELEGATE26(string key, object[] args);

		private delegate bool __GEN_DELEGATE27(string key);

		private delegate string __GEN_DELEGATE28(string value);

		private delegate string __GEN_DELEGATE29(long time);

		private delegate string __GEN_DELEGATE30(long time);

		private delegate void __GEN_DELEGATE31(CanvasGroup canvasGroup, bool active);

		private delegate void __GEN_DELEGATE32(CanvasGroup canvasGroup, bool active, bool blocksRaycasts);

		private delegate float __GEN_DELEGATE33(int first, int second);

		private delegate float __GEN_DELEGATE34(int first, float second);

		private delegate float __GEN_DELEGATE35(ulong first, ulong second);

		private delegate float __GEN_DELEGATE36(float first, int second);

		private delegate float __GEN_DELEGATE37(float first, float second);

		private delegate float __GEN_DELEGATE38(long first, long second);

		private delegate double __GEN_DELEGATE39(int first, int second);

		private delegate double __GEN_DELEGATE40(long first, long second);

		private delegate float __GEN_DELEGATE41(int number);

		private delegate float __GEN_DELEGATE42(int first);

		private delegate float __GEN_DELEGATE43(long first);

		private delegate int[] __GEN_DELEGATE44(string[] strings);

		private delegate(List<Drop_DropModel.DropData>, int, int) __GEN_DELEGATE45(CRewardItem[] items);

		private delegate List<Drop_DropModel.DropData> __GEN_DELEGATE46(List<List<int>> rewards);

		private delegate List<Drop_DropModel.DropData> __GEN_DELEGATE47(int[][] rewards);

		private delegate Drop_DropModel.DropData __GEN_DELEGATE48(CRewardItem item);

		private delegate int[][] __GEN_DELEGATE49(string[] rewards);

		private delegate void __GEN_DELEGATE50(List<Drop_DropModel.DropData> dropList, Action close, int addGold, int addDiamond);

		private delegate void __GEN_DELEGATE51(CRewardItem[] rewardItem, Action close, bool showAddGold, bool showAddDiamond);

		private delegate void __GEN_DELEGATE52(List<Drop_DropModel.DropData> dropList, int oldLevel, int newLevel, Action close, int addGold, int addDiamond);

		private delegate void __GEN_DELEGATE53(CRewardItem[] rewardItem, int oldLevel, int newLevel, Action close, bool showAddGold, bool showAddDiamond);

		private delegate bool __GEN_DELEGATE54(long compareTime);

		private delegate string __GEN_DELEGATE55(int number);

		private delegate string __GEN_DELEGATE56(int number);

		private delegate string __GEN_DELEGATE57(long number);

		private delegate string __GEN_DELEGATE58(ulong number);

		private delegate long __GEN_DELEGATE59(long nowTime);

		private delegate bool __GEN_DELEGATE60(long time1, long time2);

		private delegate void __GEN_DELEGATE61(Text _text, int _type, int _id, bool _isChangeColor, int count);

		private delegate int __GEN_DELEGATE62(float num);

		private delegate float __GEN_DELEGATE63(float num);

		private delegate float __GEN_DELEGATE64(double num);

		private delegate string[] __GEN_DELEGATE65(string[] args, string qualityName);

		private delegate void __GEN_DELEGATE66(int propID, int count);

		private delegate void __GEN_DELEGATE67(int propID);

		private delegate int __GEN_DELEGATE68(int propID);

		private delegate bool __GEN_DELEGATE69(int num, int minRandomNum, int maxRandomNum);

		private delegate Color __GEN_DELEGATE70(int quality);

		private delegate string __GEN_DELEGATE71(int quality);

		private delegate List<Drop_DropModel.DropData> __GEN_DELEGATE72(List<Drop_DropModel.DropData> list);

		private delegate NewPlay125WeaponType __GEN_DELEGATE73(int weaponID);

		private delegate Vector3 __GEN_DELEGATE74(Text targetText);

		private delegate int __GEN_DELEGATE75(int chapter, GameMode mode);

		private delegate int __GEN_DELEGATE76(int chapter);

		private delegate int __GEN_DELEGATE77(int id);

		private delegate string __GEN_DELEGATE78(uint[][] rewards);

		private delegate string __GEN_DELEGATE79(int i);

		private delegate string __GEN_DELEGATE80(uint i);

		private delegate string __GEN_DELEGATE81(long i);

		private delegate string __GEN_DELEGATE82(ulong i);

		private delegate string __GEN_DELEGATE83(List<Drop_DropModel.DropData> dropList);

		private delegate string __GEN_DELEGATE84(List<LocalSave.EquipOne> dropList);

		private delegate List<EntityBase> __GEN_DELEGATE85(List<EntityBase> entityList, Vector3 originPos, float radius);

		internal delegate bool TryArrayGet(Type type, IntPtr L, ObjectTranslator translator, object obj, int index);

		internal delegate bool TryArraySet(Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx);

		internal static TryArrayGet genTryArrayGetPtr;

		internal static TryArraySet genTryArraySetPtr;

		internal static ObjectTranslatorPool objectTranslatorPool;

		internal static int LUA_REGISTRYINDEX;

		internal static Dictionary<string, string> supportOp;

		internal static Dictionary<Type, IEnumerable<MethodInfo>> extensionMethodMap;

		internal static lua_CSFunction LazyReflectionWrap;

		static InternalGlobals()
		{
		}
	}
}
