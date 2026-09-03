using System;
using System.Collections;
using System.Collections.Generic;
using Activity;
using Activity.Anniversary;
using Activity.Anniversary.Exchange.Data;
using Activity.Bingo;
using Activity.Lattice;
using ActivityConsumeCommon;
using CampBattle;
using DG.Tweening;
using Dxx.Addressable;
using GameProtocol;
using Habby.Guild.Data;
using Spine;
using TableTool;
using Tutorial;
using UIKit;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using XLuaTest;
using homepage;
using newplay122;

namespace XLua
{
	public class DelegateBridge : DelegateBridgeBase
	{
		internal static DelegateBridge[] DelegateBridgeList;

		public static bool Gen_Flag;

		private int _oldTop;

		private Stack<int> _stack;

		public void __Gen_Delegate_Imp0()
		{
		}

		public double __Gen_Delegate_Imp1(double p0, double p1)
		{
			return 0.0;
		}

		public void __Gen_Delegate_Imp2(string p0)
		{
		}

		public void __Gen_Delegate_Imp3(double p0)
		{
		}

		public int __Gen_Delegate_Imp4(int p0)
		{
			return 0;
		}

		public Vector3 __Gen_Delegate_Imp5(Vector3 p0)
		{
			return default;
		}

		public MyStruct __Gen_Delegate_Imp6(MyStruct p0)
		{
			return default;
		}

		public MyEnum __Gen_Delegate_Imp7(MyEnum p0)
		{
			return MyEnum.E1;
		}

		public decimal __Gen_Delegate_Imp8(decimal p0)
		{
			return 0m;
		}

		public void __Gen_Delegate_Imp9(Array p0)
		{
		}

		public void __Gen_Delegate_Imp10(bool p0)
		{
		}

		public int __Gen_Delegate_Imp11(int p0, string p1, out CSCallLua.DClass p2)
		{
			p2 = null;
			return 0;
		}

		public Action __Gen_Delegate_Imp12()
		{
			return null;
		}

		public InvokeLua.ICalc __Gen_Delegate_Imp13(int p0, string[] p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp14(bool p0, uint[] p1)
		{
		}

		public void __Gen_Delegate_Imp15(object p0)
		{
		}

		public ShopOneBase __Gen_Delegate_Imp16(object p0, object p1)
		{
			return null;
		}

		public object __Gen_Delegate_Imp17(object p0, object p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp18(object p0, object p1)
		{
		}

		public void __Gen_Delegate_Imp19(object p0, int p1, bool p2)
		{
		}

		public void __Gen_Delegate_Imp20(object p0, int p1)
		{
		}

		public int __Gen_Delegate_Imp21(object p0)
		{
			return 0;
		}

		public IEnumerator __Gen_Delegate_Imp22(object p0)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp23(object p0)
		{
			return false;
		}

		public void __Gen_Delegate_Imp24(object p0, WindowID p1)
		{
		}

		public void __Gen_Delegate_Imp25(object p0, object p1, bool p2)
		{
		}

		public void __Gen_Delegate_Imp26(object p0, bool p1)
		{
		}

		public float __Gen_Delegate_Imp27(object p0)
		{
			return 0f;
		}

		public GameObject __Gen_Delegate_Imp28(object p0)
		{
			return null;
		}

		public EquipOneCtrl __Gen_Delegate_Imp29(object p0)
		{
			return null;
		}

		public int __Gen_Delegate_Imp30(object p0, object p1)
		{
			return 0;
		}

		public void __Gen_Delegate_Imp31(object p0, int p1, object p2)
		{
		}

		public void __Gen_Delegate_Imp32(object p0, object p1, int p2, int p3, int p4, object p5, float p6, float p7, object p8)
		{
		}

		public float __Gen_Delegate_Imp33(object p0, int p1, int p2)
		{
			return 0f;
		}

		public IEnumerator __Gen_Delegate_Imp34(object p0, object p1, long p2, long p3, long p4)
		{
			return null;
		}

		public IEnumerator __Gen_Delegate_Imp35(object p0, long p1, long p2)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp36(object p0, object p1)
		{
			return false;
		}

		public void __Gen_Delegate_Imp37(object p0, float p1)
		{
		}

		public void __Gen_Delegate_Imp38(object p0, CharUICtrl.UIState p1, bool p2)
		{
		}

		public Sequence __Gen_Delegate_Imp39(object p0, bool p1)
		{
			return null;
		}

		public LocalSave.EquipOne __Gen_Delegate_Imp40(object p0)
		{
			return null;
		}

		public string __Gen_Delegate_Imp41(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp42(object p0, ShowTab p1)
		{
		}

		public void __Gen_Delegate_Imp43(object p0, object p1, int p2, int p3)
		{
		}

		public void __Gen_Delegate_Imp44(object p0, Vector3 p1, object p2)
		{
		}

		public BlackItemOnectrl __Gen_Delegate_Imp45(object p0)
		{
			return null;
		}

		public IEnumerator __Gen_Delegate_Imp46(object p0, object p1)
		{
			return null;
		}

		public string __Gen_Delegate_Imp47(object p0, int p1)
		{
			return null;
		}

		public string __Gen_Delegate_Imp48(object p0, int p1, object p2, object p3)
		{
			return null;
		}

		public string __Gen_Delegate_Imp49(object p0, int p1, object p2)
		{
			return null;
		}

		public Sprite __Gen_Delegate_Imp50(int p0)
		{
			return null;
		}

		public Vector3 __Gen_Delegate_Imp51(object p0)
		{
			return default;
		}

		public void __Gen_Delegate_Imp52(object p0, int p1, int p2)
		{
		}

		public void __Gen_Delegate_Imp53(object p0, object p1, Color p2, bool p3)
		{
		}

		public void __Gen_Delegate_Imp54(object p0, object p1, object p2)
		{
		}

		public void __Gen_Delegate_Imp55(object p0, Vector2 p1)
		{
		}

		public List<CombineMaterialDataGroup> __Gen_Delegate_Imp56(object p0)
		{
			return null;
		}

		public List<LocalSave.EquipOne> __Gen_Delegate_Imp57(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp58(object p0, int p1, object p2, object p3)
		{
		}

		public bool __Gen_Delegate_Imp59(object p0, object p1, out bool p2, bool p3, bool p4)
		{
			p2 = default;
			return false;
		}

		public void __Gen_Delegate_Imp60(object p0, object p1, object p2, int p3)
		{
		}

		public CombineMaterialDataGroup __Gen_Delegate_Imp61(object p0)
		{
			return null;
		}

		public EquipCombineOne.State __Gen_Delegate_Imp62(object p0, object p1, bool p2)
		{
			return EquipCombineOne.State.Default;
		}

		public bool __Gen_Delegate_Imp63(object p0, object p1, ref CombineMaterialDataGroup p2, ref int p3)
		{
			return false;
		}

		public Dictionary<int, int> __Gen_Delegate_Imp64(object p0)
		{
			return null;
		}

		public CombineMaterialDataGroup __Gen_Delegate_Imp65(object p0, object p1)
		{
			return null;
		}

		public int __Gen_Delegate_Imp66(object p0, bool p1)
		{
			return 0;
		}

		public int __Gen_Delegate_Imp67(object p0, object p1, int p2)
		{
			return 0;
		}

		public float __Gen_Delegate_Imp68(object p0, int p1)
		{
			return 0f;
		}

		public Vector3 __Gen_Delegate_Imp69(object p0, int p1)
		{
			return default;
		}

		public int __Gen_Delegate_Imp70(object p0, object p1, object p2)
		{
			return 0;
		}

		public EquipCombineChooseOne __Gen_Delegate_Imp71(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp72(object p0, int p1, object p2, object p3, EquipCombineOne.TabName p4)
		{
		}

		public void __Gen_Delegate_Imp73(object p0, int p1, object p2, EquipCombineOne.TabName p3)
		{
		}

		public void __Gen_Delegate_Imp74(object p0, EquipCombineOne.State p1, bool p2)
		{
		}

		public RectTransform __Gen_Delegate_Imp75(object p0)
		{
			return null;
		}

		public long __Gen_Delegate_Imp76(object p0)
		{
			return 0L;
		}

		public Material __Gen_Delegate_Imp77()
		{
			return null;
		}

		public ActBossPlayManager __Gen_Delegate_Imp78()
		{
			return null;
		}

		public ASSSDataParser.BossPlayBasicData __Gen_Delegate_Imp79(object p0)
		{
			return null;
		}

		public List<BossPlayItemData> __Gen_Delegate_Imp80(object p0)
		{
			return null;
		}

		public List<string> __Gen_Delegate_Imp81(object p0, int p1, int p2, bool p3, bool p4)
		{
			return null;
		}

		public int __Gen_Delegate_Imp82(object p0, int p1)
		{
			return 0;
		}

		public bool __Gen_Delegate_Imp83(object p0, int p1)
		{
			return false;
		}

		public void __Gen_Delegate_Imp84(object p0, int p1, ref int p2, ref int p3, bool p4)
		{
		}

		public bool __Gen_Delegate_Imp85(object p0, long p1, int p2)
		{
			return false;
		}

		public Color __Gen_Delegate_Imp86(object p0, int p1)
		{
			return default;
		}

		public List<int> __Gen_Delegate_Imp87(object p0, int p1, int p2)
		{
			return null;
		}

		public void __Gen_Delegate_Imp88(object p0, int p1, int p2, int p3, object p4, object p5)
		{
		}

		public UITableViewCell __Gen_Delegate_Imp89(object p0, object p1, int p2)
		{
			return null;
		}

		public float __Gen_Delegate_Imp90(object p0, object p1, int p2)
		{
			return 0f;
		}

		public void __Gen_Delegate_Imp91(object p0, object p1, int p2)
		{
		}

		public List<string> __Gen_Delegate_Imp92(object p0, object p1)
		{
			return null;
		}

		public string __Gen_Delegate_Imp93(object p0, int p1, int p2)
		{
			return null;
		}

		public ActSevenDayManager __Gen_Delegate_Imp94()
		{
			return null;
		}

		public void __Gen_Delegate_Imp95(object p0, int p1, int p2, object p3)
		{
		}

		public SevenDayTaskData __Gen_Delegate_Imp96(object p0, int p1)
		{
			return null;
		}

		public List<SevenDayTaskData> __Gen_Delegate_Imp97(object p0, int p1)
		{
			return null;
		}

		public SevenDayTaskCountData __Gen_Delegate_Imp98(object p0, int p1)
		{
			return null;
		}

		public SevenDayBoxData __Gen_Delegate_Imp99(object p0, int p1)
		{
			return null;
		}

		public long __Gen_Delegate_Imp100(object p0, out string p1)
		{
			p1 = null;
			return 0L;
		}

		public void __Gen_Delegate_Imp101(object p0, int p1, ref int p2, ref int p3, ref bool p4, bool p5)
		{
		}

		public void __Gen_Delegate_Imp102(object p0, CleverBuyType p1)
		{
		}

		public void __Gen_Delegate_Imp103(object p0, CleverBuyType p1, object p2, object p3)
		{
		}

		public bool __Gen_Delegate_Imp104(object p0, object p1, out uint p2, out int p3)
		{
			p2 = default;
			p3 = default;
			return false;
		}

		public bool __Gen_Delegate_Imp105(object p0, CleverBuyType p1)
		{
			return false;
		}

		public void __Gen_Delegate_Imp106(object p0, CleverBuyType p1, out string p2, bool p3)
		{
			p2 = null;
		}

		public bool __Gen_Delegate_Imp107(object p0, int p1, CleverBuyType p2, out int p3, out int p4)
		{
			p3 = default;
			p4 = default;
			return false;
		}

		public bool __Gen_Delegate_Imp108(object p0, CleverBuyType p1, ref string p2)
		{
			return false;
		}

		public bool __Gen_Delegate_Imp109(object p0, ref string p1)
		{
			return false;
		}

		public List<LocalSave.EquipOne> __Gen_Delegate_Imp110(object p0, object p1, out Dictionary<int, int> p2)
		{
			p2 = null;
			return null;
		}

		public bool __Gen_Delegate_Imp111(object p0, int p1, object p2, out int p3)
		{
			p3 = default;
			return false;
		}

		public bool __Gen_Delegate_Imp112(object p0, out string p1)
		{
			p1 = null;
			return false;
		}

		public bool __Gen_Delegate_Imp113(object p0, CleverBuyType p1, object p2)
		{
			return false;
		}

		public int[] __Gen_Delegate_Imp114(object p0)
		{
			return null;
		}

		public string __Gen_Delegate_Imp115(object p0, CleverBuyType p1)
		{
			return null;
		}

		public int __Gen_Delegate_Imp116(object p0, CleverBuyType p1)
		{
			return 0;
		}

		public void __Gen_Delegate_Imp117(object p0, object p1, CleverBuyType p2)
		{
		}

		public CleverMaterialItemItemData[] __Gen_Delegate_Imp118(object p0, CleverBuyType p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp119(object p0, CleverBuyType p1, int p2)
		{
		}

		public List<Drop_DropModel.DropData>[] __Gen_Delegate_Imp120(object p0, CleverBuyType p1, object p2)
		{
			return null;
		}

		public Shop_Push __Gen_Delegate_Imp121(object p0)
		{
			return null;
		}

		public MaterialBuyCond __Gen_Delegate_Imp122(object p0, CleverBuyType p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp123(object p0, CleverBuyType p1, object p2)
		{
		}

		public PlayerPrefsMgr __Gen_Delegate_Imp124(object p0)
		{
			return null;
		}

		public PushSource __Gen_Delegate_Imp125(CleverBuyType p0)
		{
			return PushSource.equipment;
		}

		public CleverBuyType[] __Gen_Delegate_Imp126(object p0, object p1)
		{
			return null;
		}

		public CleverBuyType __Gen_Delegate_Imp127(int p0)
		{
			return CleverBuyType.none;
		}

		public CleverOnceItemItemData[] __Gen_Delegate_Imp128(object p0, CleverBuyType p1)
		{
			return null;
		}

		public long __Gen_Delegate_Imp129(object p0, CleverBuyType p1)
		{
			return 0L;
		}

		public bool __Gen_Delegate_Imp130(object p0, CleverBuyType p1, long p2, ref string p3)
		{
			return false;
		}

		public bool __Gen_Delegate_Imp131(int p0)
		{
			return false;
		}

		public Shop_PushType __Gen_Delegate_Imp132(CleverBuyType p0)
		{
			return null;
		}

		public CleverBuyType __Gen_Delegate_Imp133(object p0)
		{
			return CleverBuyType.none;
		}

		public void __Gen_Delegate_Imp134(object p0, object p1, bool p2, object p3)
		{
		}

		public CleverOnceItemItemData __Gen_Delegate_Imp135(object p0)
		{
			return null;
		}

		public List<Drop_DropModel.DropData> __Gen_Delegate_Imp136(object p0)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp137(object p0, int p1, int p2)
		{
			return false;
		}

		public List<Drop_DropModel.DropData> __Gen_Delegate_Imp138(object p0, object p1)
		{
			return null;
		}

		public Color __Gen_Delegate_Imp139(int p0)
		{
			return default;
		}

		public ushort __Gen_Delegate_Imp140(object p0)
		{
			return 0;
		}

		public LatticeRewardLevelConfig __Gen_Delegate_Imp141(object p0)
		{
			return null;
		}

		public LatticeLayerConfig __Gen_Delegate_Imp142(object p0, out bool p1)
		{
			p1 = default;
			return null;
		}

		public Drop_DropModel.DropData __Gen_Delegate_Imp143(object p0, int p1, out bool p2, out bool p3)
		{
			p2 = default;
			p3 = default;
			return null;
		}

		public Drop_DropModel.DropData __Gen_Delegate_Imp144(object p0, int p1)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp145(object p0, int p1, out int p2, out int p3)
		{
			p2 = default;
			p3 = default;
			return false;
		}

		public Drop_DropModel.DropData[] __Gen_Delegate_Imp146(object p0, bool p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp147(object p0, object p1, object p2, object p3)
		{
		}

		public bool __Gen_Delegate_Imp148(object p0, object p1, object p2, out STRespActivityLattice p3, bool p4)
		{
			p3 = null;
			return false;
		}

		public BoxOpenExchData __Gen_Delegate_Imp149(object p0, int p1)
		{
			return null;
		}

		public BoxOpenGiftData __Gen_Delegate_Imp150(object p0, int p1)
		{
			return null;
		}

		public BoxOpenGiftData __Gen_Delegate_Imp151(object p0, object p1)
		{
			return null;
		}

		public WindowID __Gen_Delegate_Imp152(object p0)
		{
			return WindowID.WindowID_Invaild;
		}

		public void __Gen_Delegate_Imp153(object p0, ActivityMgr.Event p1)
		{
		}

		public void __Gen_Delegate_Imp154(object p0, Tab p1, object p2)
		{
		}

		public Vector2 __Gen_Delegate_Imp155(object p0, int p1)
		{
			return default;
		}

		public Sequence __Gen_Delegate_Imp156(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp157(object p0, bool p1, int p2)
		{
		}

		public PropOneEquip __Gen_Delegate_Imp158(object p0, int p1)
		{
			return null;
		}

		public RewardSelectItem __Gen_Delegate_Imp159(object p0, int p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp160(object p0, GiftBoxManager.GiftBoxType p1, object p2)
		{
		}

		public GiftBoxManager __Gen_Delegate_Imp161()
		{
			return null;
		}

		public void __Gen_Delegate_Imp162(object p0, int p1, int p2, int p3, int p4)
		{
		}

		public CActivityInvestData __Gen_Delegate_Imp163(object p0, object p1)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp164(object p0, GiftBoxManager.GiftBoxType p1)
		{
			return false;
		}

		public void __Gen_Delegate_Imp165(object p0, int p1, ref int p2, ref int p3)
		{
		}

		public void __Gen_Delegate_Imp166(object p0, int p1, ref int p2, ref int p3, ref int p4)
		{
		}

		public bool __Gen_Delegate_Imp167(object p0, object p1, int p2)
		{
			return false;
		}

		public GiftBoxManager.GiftBoxData __Gen_Delegate_Imp168(object p0, int p1)
		{
			return null;
		}

		public IEnumerator __Gen_Delegate_Imp169(object p0, int p1)
		{
			return null;
		}

		public ActLoginGiftManager __Gen_Delegate_Imp170()
		{
			return null;
		}

		public List<ActLoginBasicData> __Gen_Delegate_Imp171(object p0, int p1)
		{
			return null;
		}

		public ActLoginGiftData __Gen_Delegate_Imp172(object p0, int p1)
		{
			return null;
		}

		public uint __Gen_Delegate_Imp173(object p0)
		{
			return 0u;
		}

		public bool __Gen_Delegate_Imp174(object p0, int p1, out Drop_DropModel.DropData[] p2, out int p3)
		{
			p2 = null;
			p3 = default;
			return false;
		}

		public bool __Gen_Delegate_Imp175(object p0, int p1, out Drop_DropModel.DropData p2)
		{
			p2 = null;
			return false;
		}

		public bool __Gen_Delegate_Imp176(object p0, Activity.Bingo.RewardType p1, int p2)
		{
			return false;
		}

		public void __Gen_Delegate_Imp177(object p0, object p1, int p2, object p3)
		{
		}

		public BingoCountReward[] __Gen_Delegate_Imp178(object p0)
		{
			return null;
		}

		public BingoTask[] __Gen_Delegate_Imp179(object p0)
		{
			return null;
		}

		public (bool, bool, int) __Gen_Delegate_Imp180(object p0, object p1)
		{
			return default;
		}

		public bool __Gen_Delegate_Imp181(object p0, out STRespActivityBingo p1, out List<Drop_DropModel.DropData> p2, bool p3)
		{
			p1 = null;
			p2 = null;
			return false;
		}

		public Vector2 __Gen_Delegate_Imp182(object p0, float p1, float p2)
		{
			return default;
		}

		public IEnumerator __Gen_Delegate_Imp183(object p0, int p1, object p2, object p3)
		{
			return null;
		}

		public IEnumerator __Gen_Delegate_Imp184(object p0, Vector3 p1, object p2)
		{
			return null;
		}

		public BingoCountReward __Gen_Delegate_Imp185(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp186(object p0, Tab p1)
		{
		}

		public List<Goods_goods.GoodData> __Gen_Delegate_Imp187(object p0)
		{
			return null;
		}

		public LocalSave.CharacterOne __Gen_Delegate_Imp188(object p0, int p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp189(object p0, int p1, int p2, ref int p3, ref int p4)
		{
		}

		public int __Gen_Delegate_Imp190(object p0, int p1, int p2)
		{
			return 0;
		}

		public HeroTrainData __Gen_Delegate_Imp191(object p0, int p1)
		{
			return null;
		}

		public int __Gen_Delegate_Imp192(object p0, int p1, ref int p2)
		{
			return 0;
		}

		public PlayerCharacter_Train __Gen_Delegate_Imp193(object p0, int p1)
		{
			return null;
		}

		public List<Goods_goods.GoodData> __Gen_Delegate_Imp194(object p0, int p1)
		{
			return null;
		}

		public List<HeroFragChooseData> __Gen_Delegate_Imp195(object p0)
		{
			return null;
		}

		public List<HeroFragExItemData> __Gen_Delegate_Imp196(object p0)
		{
			return null;
		}

		public List<HeroFragExItemData> __Gen_Delegate_Imp197(object p0, int p1)
		{
			return null;
		}

		public List<int> __Gen_Delegate_Imp198(object p0, int p1)
		{
			return null;
		}

		public List<string> __Gen_Delegate_Imp199(object p0, int p1)
		{
			return null;
		}

		public List<HeroAttrItem.ShowData> __Gen_Delegate_Imp200(object p0, int p1)
		{
			return null;
		}

		public List<HeroAssistAttrItem.ShowData> __Gen_Delegate_Imp201(object p0, int p1)
		{
			return null;
		}

		public List<int> __Gen_Delegate_Imp202(object p0)
		{
			return null;
		}

		public List<string> __Gen_Delegate_Imp203(object p0, int p1, bool p2)
		{
			return null;
		}

		public HeroTrainLevelDropData __Gen_Delegate_Imp204(object p0, int p1)
		{
			return null;
		}

		public List<HeroTrainLevelDropData> __Gen_Delegate_Imp205(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp206(object p0, int p1, int p2, int p3)
		{
		}

		public GameObject __Gen_Delegate_Imp207(object p0, object p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp208(object p0, int p1, object p2, int p3, object p4)
		{
		}

		public ChainGiftData __Gen_Delegate_Imp209(object p0)
		{
			return null;
		}

		public ChainGiftRewardData __Gen_Delegate_Imp210(object p0)
		{
			return null;
		}

		public (List<Drop_DropModel.DropData>, int, int) __Gen_Delegate_Imp211(object p0, object p1)
		{
			return default;
		}

		public (bool, bool) __Gen_Delegate_Imp212(object p0, int p1)
		{
			return default;
		}

		public ChainGiftConfigData __Gen_Delegate_Imp213(object p0)
		{
			return null;
		}

		public ChainGiftRewardConfigData __Gen_Delegate_Imp214(object p0)
		{
			return null;
		}

		public List<ChainGiftRewardItemData> __Gen_Delegate_Imp215(object p0)
		{
			return null;
		}

		public ChainGiftRewardItemConfigData __Gen_Delegate_Imp216(object p0)
		{
			return null;
		}

		public ChainGiftManager __Gen_Delegate_Imp217(object p0)
		{
			return null;
		}

		public ChainGiftBuyType __Gen_Delegate_Imp218(object p0)
		{
			return ChainGiftBuyType.None;
		}

		public ChainGiftRewardItemData __Gen_Delegate_Imp219(object p0)
		{
			return null;
		}

		public List<string> __Gen_Delegate_Imp220(object p0)
		{
			return null;
		}

		public ChainGiftConfigData __Gen_Delegate_Imp221(int p0, long p1, long p2, int p3, int p4)
		{
			return null;
		}

		public void __Gen_Delegate_Imp222(object p0, int p1, float p2, float p3)
		{
		}

		public void __Gen_Delegate_Imp223(object p0, int p1, float p2)
		{
		}

		public void __Gen_Delegate_Imp224(object p0, object p1, int p2, bool p3, bool p4)
		{
		}

		public void __Gen_Delegate_Imp225(object p0, int p1, bool p2, bool p3)
		{
		}

		public ActivityRefluxGiftManger __Gen_Delegate_Imp226()
		{
			return null;
		}

		public bool __Gen_Delegate_Imp227(object p0, out long p1)
		{
			p1 = default;
			return false;
		}

		public ActivityRefluxRewardItemJsonData[] __Gen_Delegate_Imp228(object p0)
		{
			return null;
		}

		public IEnumerator __Gen_Delegate_Imp229(object p0, long p1)
		{
			return null;
		}

		public ActivityRefluxRewardItemJsonData __Gen_Delegate_Imp230(object p0)
		{
			return null;
		}

		public TreasureProgressPop __Gen_Delegate_Imp231(object p0)
		{
			return null;
		}

		public TreasureCoinPanel __Gen_Delegate_Imp232(object p0)
		{
			return null;
		}

		public TreasureSelectPanel __Gen_Delegate_Imp233(object p0)
		{
			return null;
		}

		public TreasurePanel __Gen_Delegate_Imp234(object p0)
		{
			return null;
		}

		public PanelBase __Gen_Delegate_Imp235(object p0)
		{
			return null;
		}

		public ActivityMgr.Event __Gen_Delegate_Imp236(object p0)
		{
			return ActivityMgr.Event.None_CheckIn;
		}

		public ulong __Gen_Delegate_Imp237(object p0)
		{
			return 0uL;
		}

		public void __Gen_Delegate_Imp238(object p0, uint p1)
		{
		}

		public void __Gen_Delegate_Imp239(object p0, long p1)
		{
		}

		public List<CumulativeConsumptionData.CCItem> __Gen_Delegate_Imp240(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp241(object p0, ushort p1, object p2)
		{
		}

		public void __Gen_Delegate_Imp242(object p0, int p1, object p2, object p3, object p4, int p5)
		{
		}

		public void __Gen_Delegate_Imp243(object p0, object p1, ActivityTreasureData.RewardType p2)
		{
		}

		public string __Gen_Delegate_Imp244(object p0, ActivityTreasureData.RewardType p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp245(object p0, bool p1, object p2, object p3)
		{
		}

		public string __Gen_Delegate_Imp246(object p0, bool p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp247(object p0, int p1, ushort p2, object p3, object p4)
		{
		}

		public void __Gen_Delegate_Imp248(object p0, bool p1, bool p2)
		{
		}

		public void __Gen_Delegate_Imp249(object p0, ActivityMgr.Status p1)
		{
		}

		public ActivityTreasureData __Gen_Delegate_Imp250(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp251(object p0, bool p1, int p2, object p3)
		{
		}

		public bool __Gen_Delegate_Imp252(object p0, ushort p1)
		{
			return false;
		}

		public void __Gen_Delegate_Imp253(object p0, ushort p1, bool p2, ushort p3, object p4)
		{
		}

		public bool __Gen_Delegate_Imp254(object p0, ushort p1, ushort p2)
		{
			return false;
		}

		public (int, int, int) __Gen_Delegate_Imp255(object p0)
		{
			return default;
		}

		public bool __Gen_Delegate_Imp256(object p0, ushort p1, ushort p2, bool p3)
		{
			return false;
		}

		public int __Gen_Delegate_Imp257(object p0, ushort p1)
		{
			return 0;
		}

		public void __Gen_Delegate_Imp258(object p0, object p1, ushort p2, ushort p3, bool p4)
		{
		}

		public CActivityCommonData __Gen_Delegate_Imp259(object p0, ushort p1)
		{
			return null;
		}

		public BPItemStruct[] __Gen_Delegate_Imp260(object p0, ushort p1)
		{
			return null;
		}

		public BPItemStruct __Gen_Delegate_Imp261(object p0, ushort p1, int p2)
		{
			return null;
		}

		public void __Gen_Delegate_Imp262(object p0, ushort p1, out Drop_DropModel.DropData[] p2, out Drop_DropModel.DropData[] p3)
		{
			p2 = null;
			p3 = null;
		}

		public void __Gen_Delegate_Imp263(object p0, object p1, ushort p2, object p3)
		{
		}

		public void __Gen_Delegate_Imp264(object p0, int p1, ushort p2, int p3)
		{
		}

		public void __Gen_Delegate_Imp265(object p0, object p1, int p2, ushort p3, int p4)
		{
		}

		public int __Gen_Delegate_Imp266()
		{
			return 0;
		}

		public long __Gen_Delegate_Imp267()
		{
			return 0L;
		}

		public CRespActivityExchange __Gen_Delegate_Imp268(object p0)
		{
			return null;
		}

		public CActivityExchangeData __Gen_Delegate_Imp269(object p0, int p1)
		{
			return null;
		}

		public ActivityBPData __Gen_Delegate_Imp270(object p0)
		{
			return null;
		}

		public ActivityTurnData __Gen_Delegate_Imp271(object p0)
		{
			return null;
		}

		public ActivityExchangeData __Gen_Delegate_Imp272(object p0)
		{
			return null;
		}

		public CumulativeConsumptionData __Gen_Delegate_Imp273(object p0)
		{
			return null;
		}

		public ActivityCustomSelectionData __Gen_Delegate_Imp274(object p0)
		{
			return null;
		}

		public Drop_DropModel.DropData[] __Gen_Delegate_Imp275(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp276(ref List<Drop_DropModel.DropData> p0, object p1)
		{
		}

		public TreasureConfig __Gen_Delegate_Imp277(object p0)
		{
			return null;
		}

		public STRespActivityTreasure __Gen_Delegate_Imp278(object p0)
		{
			return null;
		}

		public TreasureRewardData __Gen_Delegate_Imp279(object p0)
		{
			return null;
		}

		public TreasureActivityData __Gen_Delegate_Imp280(object p0)
		{
			return null;
		}

		public int[][] __Gen_Delegate_Imp281(object p0)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp282(object p0, out int[][] p1, out int[][] p2, out int[][] p3, out int[] p4)
		{
			p1 = null;
			p2 = null;
			p3 = null;
			p4 = null;
			return false;
		}

		public bool __Gen_Delegate_Imp283(object p0, bool p1)
		{
			return false;
		}

		public bool __Gen_Delegate_Imp284(object p0, ActivityTreasureData.RewardType p1, int p2)
		{
			return false;
		}

		public string __Gen_Delegate_Imp285(object p0, bool p1, int p2)
		{
			return null;
		}

		public void __Gen_Delegate_Imp286(object p0, object p1, object p2, bool p3)
		{
		}

		public void __Gen_Delegate_Imp287(object p0, ActivityTreasurePurchaseType p1, object p2)
		{
		}

		public void __Gen_Delegate_Imp288(object p0, object p1, ActivityTreasurePurchaseType p2, object p3)
		{
		}

		public void __Gen_Delegate_Imp289(object p0, int p1, ActivityTreasureData.RewardType p2, object p3, object p4)
		{
		}

		public void __Gen_Delegate_Imp290(object p0, object p1, int p2, ActivityTreasureData.RewardType p3, object p4)
		{
		}

		public bool __Gen_Delegate_Imp291(object p0, out STRespActivityTreasure p1, out List<Drop_DropModel.DropData> p2)
		{
			p1 = null;
			p2 = null;
			return false;
		}

		public TreasureIapItemData[] __Gen_Delegate_Imp292(object p0)
		{
			return null;
		}

		public TreasureIapItemData __Gen_Delegate_Imp293(object p0, object p1)
		{
			return null;
		}

		public STRespActivityCommonTurn __Gen_Delegate_Imp294(object p0)
		{
			return null;
		}

		public ActivityTurnData.BoxReward[] __Gen_Delegate_Imp295(object p0)
		{
			return null;
		}

		public int __Gen_Delegate_Imp296(object p0, out ActivityTurnData.CostType p1, out long p2, out int p3)
		{
			p1 = default;
			p2 = default;
			p3 = default;
			return 0;
		}

		public bool __Gen_Delegate_Imp297(object p0, out ActivityTurnData.CostType p1, out long p2, out int p3)
		{
			p1 = default;
			p2 = default;
			p3 = default;
			return false;
		}

		public void __Gen_Delegate_Imp298(object p0, object p1, ActivityTurnData.CostType p2, long p3)
		{
		}

		public List<PVPActManager.ExchangeData> __Gen_Delegate_Imp299(object p0)
		{
			return null;
		}

		public PVPActManager.ExchangeData __Gen_Delegate_Imp300(object p0, int p1)
		{
			return null;
		}

		public List<CRewardItem> __Gen_Delegate_Imp301(object p0)
		{
			return null;
		}

		public Act4thBoxManager __Gen_Delegate_Imp302()
		{
			return null;
		}

		public void __Gen_Delegate_Imp303(object p0, int p1, int p2, int p3, int p4, int p5, int p6, object p7)
		{
		}

		public Act4thBoxManager.BoxRewardConfig __Gen_Delegate_Imp304(object p0, int p1)
		{
			return null;
		}

		public Act4thBoxManager.BoxTaskData __Gen_Delegate_Imp305(object p0, int p1)
		{
			return null;
		}

		public Act4thBoxManager.QueueData __Gen_Delegate_Imp306(object p0, int p1)
		{
			return null;
		}

		public int[][] __Gen_Delegate_Imp307(object p0, int p1, int p2)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp308(object p0, int p1, out bool p2, out Drop_DropModel.DropData[] p3)
		{
			p2 = default;
			p3 = null;
			return false;
		}

		public JigsawState __Gen_Delegate_Imp309(object p0, int p1)
		{
			return JigsawState.Uncompleted;
		}

		public Drop_DropModel.DropData[] __Gen_Delegate_Imp310(object p0, int p1)
		{
			return null;
		}

		public STActivityAnniversaryTask __Gen_Delegate_Imp311(object p0, int p1)
		{
			return null;
		}

		public JigsawRewardConfig __Gen_Delegate_Imp312(object p0, int p1, out JigsawState p2, out Drop_DropModel.DropData[] p3)
		{
			p2 = default;
			p3 = null;
			return null;
		}

		public long __Gen_Delegate_Imp313(object p0, int p1)
		{
			return 0L;
		}

		public STActivityAnniversaryAward __Gen_Delegate_Imp314(object p0)
		{
			return null;
		}

		public STActivityAnniversaryAward __Gen_Delegate_Imp315(object p0, int p1)
		{
			return null;
		}

		public int[] __Gen_Delegate_Imp316(object p0, int p1, int p2)
		{
			return null;
		}

		public STActivityAnniversaryTask __Gen_Delegate_Imp317(object p0, int p1, int p2)
		{
			return null;
		}

		public LayerData __Gen_Delegate_Imp318(object p0, int p1)
		{
			return null;
		}

		public Tower_Defense_TDlevel __Gen_Delegate_Imp319(object p0, int p1)
		{
			return null;
		}

		public Tower_Defense_DefenseTower __Gen_Delegate_Imp320(object p0, int p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp321(object p0, object p1, int p2, int p3, object p4)
		{
		}

		public void __Gen_Delegate_Imp322(object p0, TowerDefenseBattleRequestType p1, int p2, int p3, bool p4, int p5, int p6, object p7, object p8)
		{
		}

		public void __Gen_Delegate_Imp323(object p0, object p1, TowerDefenseBattleRequestType p2, int p3, int p4, bool p5, int p6, int p7, object p8, object p9)
		{
		}

		public bool __Gen_Delegate_Imp324(object p0, out STRespActivityAnniversary p1)
		{
			p1 = null;
			return false;
		}

		public ActivityAnniversaryMgr __Gen_Delegate_Imp325(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp326(object p0, TabAnni p1)
		{
		}

		public JigsawTaskPopPanel __Gen_Delegate_Imp327(object p0)
		{
			return null;
		}

		public TDPopPanel __Gen_Delegate_Imp328(object p0)
		{
			return null;
		}

		public TDRewardPop __Gen_Delegate_Imp329(object p0)
		{
			return null;
		}

		public InfoPopPanel __Gen_Delegate_Imp330(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp331(object p0, object p1, ConsumeTab p2, object p3)
		{
		}

		public STActivityAnniversaryTask __Gen_Delegate_Imp332(object p0)
		{
			return null;
		}

		public Sprite __Gen_Delegate_Imp333(object p0, object p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp334(object p0, int p1, object p2, float p3, object p4)
		{
		}

		public bool __Gen_Delegate_Imp335(int p0, Vector2Int p1)
		{
			return false;
		}

		public void __Gen_Delegate_Imp336(object p0, Vector3 p1, Vector2 p2, int p3, int p4)
		{
		}

		public ExchangeManager __Gen_Delegate_Imp337(object p0)
		{
			return null;
		}

		public ExchangeData __Gen_Delegate_Imp338(object p0)
		{
			return null;
		}

		public ExchangeRewardData __Gen_Delegate_Imp339(object p0)
		{
			return null;
		}

		public int __Gen_Delegate_Imp340(object p0, int p1, bool p2)
		{
			return 0;
		}

		public ExchangeConfigData __Gen_Delegate_Imp341(object p0)
		{
			return null;
		}

		public ExchangeRewardConfigData __Gen_Delegate_Imp342(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp343(object p0, ExchangeThemeType p1)
		{
		}

		public Func<int, bool> __Gen_Delegate_Imp344(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp345(object p0, Color p1)
		{
		}

		public ExchangeRewardItemConfigData __Gen_Delegate_Imp346(object p0)
		{
			return null;
		}

		public ExchangeThemeType __Gen_Delegate_Imp347(object p0)
		{
			return ExchangeThemeType.None;
		}

		public ExchangeRewardItemData __Gen_Delegate_Imp348(object p0)
		{
			return null;
		}

		public ExchangeRewardItemConfigData __Gen_Delegate_Imp349(int p0, int p1, int p2, int p3, object p4)
		{
			return null;
		}

		public DailyBackData __Gen_Delegate_Imp350(object p0)
		{
			return null;
		}

		public DailyBackRewardData __Gen_Delegate_Imp351(object p0)
		{
			return null;
		}

		public SendRequestTime __Gen_Delegate_Imp352(object p0)
		{
			return SendRequestTime.None;
		}

		public CReqResourceFindBack __Gen_Delegate_Imp353(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp354(object p0, object p1, object p2, TimeRequest p3)
		{
		}

		public List<DailyBackTabItemConfigData> __Gen_Delegate_Imp355(long p0, object p1)
		{
			return null;
		}

		public List<string> __Gen_Delegate_Imp356(int p0, object p1)
		{
			return null;
		}

		public int __Gen_Delegate_Imp357(object p0, CurrencyType p1)
		{
			return 0;
		}

		public void __Gen_Delegate_Imp358(object p0, bool p1, object p2)
		{
		}

		public ToggleButton __Gen_Delegate_Imp359(object p0)
		{
			return null;
		}

		public DailyBackManager __Gen_Delegate_Imp360(object p0)
		{
			return null;
		}

		public LocalSave __Gen_Delegate_Imp361(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp362(object p0, ushort p1, object p2, object p3, uint p4)
		{
		}

		public TDMapPreview __Gen_Delegate_Imp363(object p0)
		{
			return null;
		}

		public RoomGenerateBase.Room __Gen_Delegate_Imp364(object p0, object p1)
		{
			return null;
		}

		public GameObject __Gen_Delegate_Imp365(object p0, int p1)
		{
			return null;
		}

		public string __Gen_Delegate_Imp366(object p0, object p1)
		{
			return null;
		}

		public TDWeekRewardVO __Gen_Delegate_Imp367(object p0)
		{
			return null;
		}

		public List<TDWeekRewardVO> __Gen_Delegate_Imp368(object p0)
		{
			return null;
		}

		public long __Gen_Delegate_Imp369(object p0, long p1)
		{
			return 0L;
		}

		public (string, string) __Gen_Delegate_Imp370(object p0)
		{
			return default;
		}

		public TDMapPreviewController __Gen_Delegate_Imp371(object p0)
		{
			return null;
		}

		public DailyTDServerController __Gen_Delegate_Imp372(object p0)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp373(object p0, NewPlay122Manager.TutorialEnum p1)
		{
			return false;
		}

		public void __Gen_Delegate_Imp374(object p0, MainShopTab p1, object p2)
		{
		}

		public bool __Gen_Delegate_Imp375(object p0, MainShopTab p1)
		{
			return false;
		}

		public MainShopTab __Gen_Delegate_Imp376(object p0, object p1)
		{
			return MainShopTab.GiftPack;
		}

		public bool __Gen_Delegate_Imp377(object p0, object p1, bool p2, int p3)
		{
			return false;
		}

		public ThemeSupplyBoxHero __Gen_Delegate_Imp378(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp379(object p0, object p1, out List<Drop_DropModel.DropData> p2, out List<RewardSelectionDisplayConfig> p3, out Drop_DropModel.DropData p4)
		{
			p2 = null;
			p3 = null;
			p4 = null;
		}

		public bool __Gen_Delegate_Imp380()
		{
			return false;
		}

		public string __Gen_Delegate_Imp381(object p0, ushort p1)
		{
			return null;
		}

		public ShopItemBoxEquipS __Gen_Delegate_Imp382(object p0)
		{
			return null;
		}

		public PermanentPrivilegeUIPanel __Gen_Delegate_Imp383(object p0)
		{
			return null;
		}

		public DiamondPrivilegeUIPanel __Gen_Delegate_Imp384(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp385(object p0, PrivilegeTabType p1)
		{
		}

		public void __Gen_Delegate_Imp386(object p0, object p1, object p2, bool p3, ShopStageDiscount_TabCtrl.TabName p4, object p5)
		{
		}

		public void __Gen_Delegate_Imp387(object p0, object p1, int p2, bool p3)
		{
		}

		public PuzzleManager __Gen_Delegate_Imp388(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp389(object p0, bool p1, int p2, object p3, object p4, object p5)
		{
		}

		public void __Gen_Delegate_Imp390(object p0, bool p1, int p2, object p3, object p4)
		{
		}

		public PuzzleData __Gen_Delegate_Imp391(object p0)
		{
			return null;
		}

		public PuzzleTaskData __Gen_Delegate_Imp392(object p0)
		{
			return null;
		}

		public PuzzleChestData __Gen_Delegate_Imp393(object p0)
		{
			return null;
		}

		public STReqActivityPuzzle __Gen_Delegate_Imp394(object p0)
		{
			return null;
		}

		public PuzzleConfigData __Gen_Delegate_Imp395(object p0)
		{
			return null;
		}

		public PuzzleTaskItemConfigData __Gen_Delegate_Imp396(object p0)
		{
			return null;
		}

		public JigsawState __Gen_Delegate_Imp397(object p0)
		{
			return JigsawState.Uncompleted;
		}

		public PuzzleTaskItemData __Gen_Delegate_Imp398(object p0)
		{
			return null;
		}

		public PuzzleChestItemConfigData __Gen_Delegate_Imp399(object p0)
		{
			return null;
		}

		public PuzzleChestItemData __Gen_Delegate_Imp400(object p0)
		{
			return null;
		}

		public string __Gen_Delegate_Imp401(int p0, int p1)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp402(int p0, int p1, object p2, object p3)
		{
			return false;
		}

		public void __Gen_Delegate_Imp403(object p0, int p1, object p2, object p3, int p4, int p5, int p6, int p7, int p8, int p9)
		{
		}

		public GameObject __Gen_Delegate_Imp404(object p0, int p1, float? p2, int p3)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp405(Vector3 p0, object p1)
		{
			return false;
		}

		public string __Gen_Delegate_Imp406(object p0, object[] p1)
		{
			return null;
		}

		public string __Gen_Delegate_Imp407(long p0)
		{
			return null;
		}

		public float __Gen_Delegate_Imp408(int p0, int p1)
		{
			return 0f;
		}

		public float __Gen_Delegate_Imp409(int p0, float p1)
		{
			return 0f;
		}

		public float __Gen_Delegate_Imp410(ulong p0, ulong p1)
		{
			return 0f;
		}

		public float __Gen_Delegate_Imp411(float p0, int p1)
		{
			return 0f;
		}

		public float __Gen_Delegate_Imp412(float p0, float p1)
		{
			return 0f;
		}

		public float __Gen_Delegate_Imp413(long p0, long p1)
		{
			return 0f;
		}

		public double __Gen_Delegate_Imp414(int p0, int p1)
		{
			return 0.0;
		}

		public double __Gen_Delegate_Imp415(long p0, long p1)
		{
			return 0.0;
		}

		public float __Gen_Delegate_Imp416(int p0)
		{
			return 0f;
		}

		public float __Gen_Delegate_Imp417(long p0)
		{
			return 0f;
		}

		public (List<Drop_DropModel.DropData>, int, int) __Gen_Delegate_Imp418(object p0)
		{
			return default;
		}

		public Drop_DropModel.DropData __Gen_Delegate_Imp419(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp420(object p0, object p1, bool p2, bool p3)
		{
		}

		public void __Gen_Delegate_Imp421(object p0, int p1, int p2, object p3, int p4, int p5)
		{
		}

		public void __Gen_Delegate_Imp422(object p0, int p1, int p2, object p3, bool p4, bool p5)
		{
		}

		public bool __Gen_Delegate_Imp423(long p0)
		{
			return false;
		}

		public string __Gen_Delegate_Imp424(int p0)
		{
			return null;
		}

		public string __Gen_Delegate_Imp425(ulong p0)
		{
			return null;
		}

		public long __Gen_Delegate_Imp426(long p0)
		{
			return 0L;
		}

		public bool __Gen_Delegate_Imp427(long p0, long p1)
		{
			return false;
		}

		public void __Gen_Delegate_Imp428(IMMessageStatus p0, object p1)
		{
		}

		public void __Gen_Delegate_Imp429(object p0, int p1, int p2, bool p3, int p4)
		{
		}

		public int __Gen_Delegate_Imp430(float p0)
		{
			return 0;
		}

		public float __Gen_Delegate_Imp431(float p0)
		{
			return 0f;
		}

		public float __Gen_Delegate_Imp432(double p0)
		{
			return 0f;
		}

		public string[] __Gen_Delegate_Imp433(object p0, object p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp434(int p0, int p1)
		{
		}

		public void __Gen_Delegate_Imp435(int p0)
		{
		}

		public Sprite __Gen_Delegate_Imp436(object p0)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp437(int p0, int p1, int p2)
		{
			return false;
		}

		public NewPlay125WeaponType __Gen_Delegate_Imp438(int p0)
		{
			return NewPlay125WeaponType.None;
		}

		public Vector3[] __Gen_Delegate_Imp439(Vector3 p0, Vector3 p1, Vector3 p2, int p3)
		{
			return null;
		}

		public int __Gen_Delegate_Imp440(int p0, GameMode p1)
		{
			return 0;
		}

		public string __Gen_Delegate_Imp441(uint p0)
		{
			return null;
		}

		public List<EntityBase> __Gen_Delegate_Imp442(object p0, Vector3 p1, float p2)
		{
			return null;
		}

		public SLG_NobilityLevel[] __Gen_Delegate_Imp443(object p0)
		{
			return null;
		}

		public CampBPManager __Gen_Delegate_Imp444()
		{
			return null;
		}

		public void __Gen_Delegate_Imp445(object p0, int p1, int p2, int p3, object p4)
		{
		}

		public void __Gen_Delegate_Imp446(object p0, FunctionalModule p1, object p2, long p3, object p4, object p5)
		{
		}

		public void __Gen_Delegate_Imp447(object p0, object p1, float p2)
		{
		}

		public void __Gen_Delegate_Imp448(object p0, CurrencyType p1, int p2, int p3)
		{
		}

		public void __Gen_Delegate_Imp449(object p0, float p1, float p2)
		{
		}

		public Vector2Int __Gen_Delegate_Imp450(object p0, Vector2Int p1)
		{
			return default;
		}

		public Vector2 __Gen_Delegate_Imp451(object p0, int p1, Vector3Int p2)
		{
			return default;
		}

		public void __Gen_Delegate_Imp452(object p0, LayerName p1, int p2, int p3, int p4, int p5)
		{
		}

		public void __Gen_Delegate_Imp453(object p0, LayerName p1, bool p2)
		{
		}

		public int __Gen_Delegate_Imp454(object p0, int p1, int p2, int p3)
		{
			return 0;
		}

		public bool __Gen_Delegate_Imp455(object p0, int p1, int p2, int p3)
		{
			return false;
		}

		public (bool, int, int) __Gen_Delegate_Imp456(object p0, int p1, int p2, int p3)
		{
			return default;
		}

		public Tile __Gen_Delegate_Imp457(object p0, int p1)
		{
			return null;
		}

		public Vector2Int __Gen_Delegate_Imp458(object p0, int p1, int p2, int p3)
		{
			return default;
		}

		public CampID __Gen_Delegate_Imp459(object p0, int p1, int p2)
		{
			return CampID.Unknown;
		}

		public HashSet<CampID> __Gen_Delegate_Imp460(object p0, int p1, int p2, int p3)
		{
			return null;
		}

		public HashSet<CampID> __Gen_Delegate_Imp461(object p0, int p1, int p2)
		{
			return null;
		}

		public List<(int, int)> __Gen_Delegate_Imp462(object p0, int p1, int p2, int p3)
		{
			return null;
		}

		public Vector2Int __Gen_Delegate_Imp463(object p0, int p1)
		{
			return default;
		}

		public Vector2Int __Gen_Delegate_Imp464(object p0, int p1, int p2)
		{
			return default;
		}

		public List<int> __Gen_Delegate_Imp465(object p0, int p1, int p2, int p3, int p4)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp466(object p0, int p1, int p2, bool p3)
		{
			return false;
		}

		public bool __Gen_Delegate_Imp467(object p0, TileAnchor p1, int p2, int p3, bool p4)
		{
			return false;
		}

		public bool __Gen_Delegate_Imp468(object p0, int p1, int p2, bool p3, int p4)
		{
			return false;
		}

		public CampTileData __Gen_Delegate_Imp469(object p0, int p1, int p2)
		{
			return null;
		}

		public void __Gen_Delegate_Imp470(object p0, int p1, long p2)
		{
		}

		public Vector2 __Gen_Delegate_Imp471(object p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return default;
		}

		public float __Gen_Delegate_Imp472(object p0, Vector2 p1)
		{
			return 0f;
		}

		public Vector2Int __Gen_Delegate_Imp473(object p0)
		{
			return default;
		}

		public List<TownSkinEffectData> __Gen_Delegate_Imp474(object p0, int p1, int p2)
		{
			return null;
		}

		public void __Gen_Delegate_Imp475(object p0, int p1, int p2, ulong p3)
		{
		}

		public List<TileMarkData> __Gen_Delegate_Imp476(object p0)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp477(object p0, BuildingType p1)
		{
			return false;
		}

		public long __Gen_Delegate_Imp478(object p0, int p1, int p2)
		{
			return 0L;
		}

		public string __Gen_Delegate_Imp479(object p0, int p1, int p2, int p3)
		{
			return null;
		}

		public SLG_EventReminder __Gen_Delegate_Imp480(object p0)
		{
			return null;
		}

		public Dictionary<CurrencyType, int> __Gen_Delegate_Imp481(object p0)
		{
			return null;
		}

		public Dictionary<(int, int), int> __Gen_Delegate_Imp482(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp483(object p0, int p1, int p2, object p3, object p4)
		{
		}

		public ASSSDataParser.CampBasicData __Gen_Delegate_Imp484(object p0)
		{
			return null;
		}

		public (long, long) __Gen_Delegate_Imp485(object p0)
		{
			return default;
		}

		public CampSeasonStage __Gen_Delegate_Imp486(object p0)
		{
			return CampSeasonStage.Unknown;
		}

		public CampPreCallData __Gen_Delegate_Imp487(object p0, int p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp488(object p0, int p1, int p2, object p3, object p4, int p5, int p6)
		{
		}

		public List<CampRankItemData> __Gen_Delegate_Imp489(object p0, int p1, int p2)
		{
			return null;
		}

		public List<CampRankItemData> __Gen_Delegate_Imp490(object p0, int p1)
		{
			return null;
		}

		public CampRankItemData __Gen_Delegate_Imp491(object p0, int p1)
		{
			return null;
		}

		public CampRankItemData __Gen_Delegate_Imp492(object p0, int p1, int p2)
		{
			return null;
		}

		public List<string> __Gen_Delegate_Imp493(object p0, int p1, int p2, int p3, int p4, int p5)
		{
			return null;
		}

		public int __Gen_Delegate_Imp494(object p0, int p1, int p2, int p3, int p4, int p5)
		{
			return 0;
		}

		public List<(CurrencyType, int)> __Gen_Delegate_Imp495(object p0, int p1)
		{
			return null;
		}

		public int __Gen_Delegate_Imp496(object p0, CurrencyType p1, int p2)
		{
			return 0;
		}

		public CampID __Gen_Delegate_Imp497(object p0)
		{
			return CampID.Unknown;
		}

		public void __Gen_Delegate_Imp498(object p0, CurrencyType p1, int p2)
		{
		}

		public bool __Gen_Delegate_Imp499(object p0, CurrencyType p1, int p2)
		{
			return false;
		}

		public List<((int, int), CampTileModelData, LocalSave.CharacterOne)> __Gen_Delegate_Imp500(object p0)
		{
			return null;
		}

		public LocalSave.CharacterOne __Gen_Delegate_Imp501(object p0, int p1, int p2)
		{
			return null;
		}

		public (int, int) __Gen_Delegate_Imp502(object p0, int p1)
		{
			return default;
		}

		public CCampRank[] __Gen_Delegate_Imp503(object p0)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp504(object p0, ulong p1)
		{
			return false;
		}

		public List<CampBuffItemData> __Gen_Delegate_Imp505(object p0)
		{
			return null;
		}

		public List<CampBuffItemData> __Gen_Delegate_Imp506(object p0, int p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp507(object p0, ulong p1, object p2)
		{
		}

		public CampTicketItemData __Gen_Delegate_Imp508(object p0, ulong p1)
		{
			return null;
		}

		public List<Drop_DropModel.DropData> __Gen_Delegate_Imp509(object p0, int p1, int p2)
		{
			return null;
		}

		public CampAttribute __Gen_Delegate_Imp510(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp511(object p0, int p1, int p2, ulong p3, object p4)
		{
		}

		public List<CampTeamPrivilegeItemData> __Gen_Delegate_Imp512(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp513(object p0, LayerName p1)
		{
		}

		public void __Gen_Delegate_Imp514(object p0, int p1, int p2, int p3, int p4, int p5)
		{
		}

		public bool __Gen_Delegate_Imp515(object p0, Vector3 p1, Vector3Int p2)
		{
			return false;
		}

		public void __Gen_Delegate_Imp516(object p0, CurrencyType p1, int p2, CampTownAtt p3)
		{
		}

		public void __Gen_Delegate_Imp517(object p0, CurrencyType p1, int p2, int p3, CampTownAtt p4)
		{
		}

		public GameObject __Gen_Delegate_Imp518(object p0, object p1, int p2, int p3, int p4)
		{
			return null;
		}

		public CampTileData __Gen_Delegate_Imp519(int p0, int p1, long p2, int p3)
		{
			return null;
		}

		public void __Gen_Delegate_Imp520(object p0, int p1, long p2, int p3)
		{
		}

		public RoundMeta __Gen_Delegate_Imp521(object p0, int p1)
		{
			return null;
		}

		public SLGStage_stagechapter __Gen_Delegate_Imp522(object p0, int p1, int p2, int p3)
		{
			return null;
		}

		public void __Gen_Delegate_Imp523(object p0, bool p1, uint p2, uint p3, uint p4, uint p5, object p6, object p7)
		{
		}

		public List<Vector2Int> __Gen_Delegate_Imp524(object p0, int p1)
		{
			return null;
		}

		public string[] __Gen_Delegate_Imp525(object p0)
		{
			return null;
		}

		public CampAchievementData __Gen_Delegate_Imp526(object p0)
		{
			return null;
		}

		public CCampSeasonAchieve __Gen_Delegate_Imp527(object p0)
		{
			return null;
		}

		public CampAchievementItemStatus __Gen_Delegate_Imp528(object p0)
		{
			return CampAchievementItemStatus.None;
		}

		public List<CampAchievementItemData> __Gen_Delegate_Imp529(object p0)
		{
			return null;
		}

		public SLG_SLGAchieveReward __Gen_Delegate_Imp530(object p0)
		{
			return null;
		}

		public CampAchievementItemConfigData __Gen_Delegate_Imp531(object p0)
		{
			return null;
		}

		public CampAchievementItemData __Gen_Delegate_Imp532(object p0)
		{
			return null;
		}

		public SLG_SLGAchieve __Gen_Delegate_Imp533(object p0)
		{
			return null;
		}

		public CampAchievementConfigData __Gen_Delegate_Imp534(int p0, object p1)
		{
			return null;
		}

		public CampAchievementItemConfigData __Gen_Delegate_Imp535(int p0, int p1, int p2)
		{
			return null;
		}

		public CampAchievementManager __Gen_Delegate_Imp536(object p0)
		{
			return null;
		}

		public CampNormalGiftData __Gen_Delegate_Imp537(object p0)
		{
			return null;
		}

		public CampTimingGiftData __Gen_Delegate_Imp538(object p0)
		{
			return null;
		}

		public CCampSeasonGift __Gen_Delegate_Imp539(object p0)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp540(object p0, long p1)
		{
			return false;
		}

		public CampNormalGiftData __Gen_Delegate_Imp541(object p0, CampGiftType p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp542(object p0, CampGiftType p1, int p2, int p3)
		{
		}

		public CampTimingGiftThemeType __Gen_Delegate_Imp543(object p0, int p1)
		{
			return CampTimingGiftThemeType.None;
		}

		public void __Gen_Delegate_Imp544(object p0, int p1, CampGiftType p2, object p3, object p4)
		{
		}

		public CampGiftType __Gen_Delegate_Imp545(object p0)
		{
			return CampGiftType.None;
		}

		public List<CampNormalGiftItemData> __Gen_Delegate_Imp546(object p0)
		{
			return null;
		}

		public List<CampTimingGiftItemData> __Gen_Delegate_Imp547(object p0)
		{
			return null;
		}

		public CampNormalGiftItemConfigData __Gen_Delegate_Imp548(object p0)
		{
			return null;
		}

		public CampNormalGiftItemData __Gen_Delegate_Imp549(object p0)
		{
			return null;
		}

		public CampTimingGiftItemConfigData __Gen_Delegate_Imp550(object p0)
		{
			return null;
		}

		public CampTimingGiftItemData __Gen_Delegate_Imp551(object p0)
		{
			return null;
		}

		public CampNormalGiftConfigData __Gen_Delegate_Imp552(object p0, CampGiftType p1)
		{
			return null;
		}

		public CampTimingGiftConfigData __Gen_Delegate_Imp553(object p0, CampGiftType p1)
		{
			return null;
		}

		public CampGiftBuyConfigData __Gen_Delegate_Imp554(object p0)
		{
			return null;
		}

		public CampTimingGiftConfigData __Gen_Delegate_Imp555(object p0, object p1)
		{
			return null;
		}

		public CampGiftManager __Gen_Delegate_Imp556(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp557(object p0, CampGiftType p1, object p2)
		{
		}

		public void __Gen_Delegate_Imp558(object p0, CampTimingGiftThemeType p1)
		{
		}

		public void __Gen_Delegate_Imp559(object p0, object p1, CampTimingGiftThemeType p2)
		{
		}

		public CampTimingGiftThemeType __Gen_Delegate_Imp560(object p0)
		{
			return CampTimingGiftThemeType.None;
		}

		public CampShopData __Gen_Delegate_Imp561(object p0)
		{
			return null;
		}

		public CReqCampSeasonStore __Gen_Delegate_Imp562(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp563(object p0, object p1, object p2, int p3, int p4)
		{
		}

		public List<CampShopItemData> __Gen_Delegate_Imp564(object p0, CurrencyType p1)
		{
			return null;
		}

		public List<CampShopItemData> __Gen_Delegate_Imp565(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp566(object p0, CurrencyType p1, int p2, int p3, int p4)
		{
		}

		public CampShopConfigData __Gen_Delegate_Imp567(object p0, object p1)
		{
			return null;
		}

		public CampShopItemConfigData __Gen_Delegate_Imp568(object p0)
		{
			return null;
		}

		public CurrencyType __Gen_Delegate_Imp569(object p0)
		{
			return CurrencyType.None;
		}

		public CampShopItemResetType __Gen_Delegate_Imp570(object p0)
		{
			return CampShopItemResetType.Season;
		}

		public CampShopItemData __Gen_Delegate_Imp571(object p0)
		{
			return null;
		}

		public CampShopItemConfigData __Gen_Delegate_Imp572(int p0, int p1, int p2, CurrencyType p3, int p4, int p5, int p6, int p7, object p8)
		{
			return null;
		}

		public List<CampShopItemConfigData> __Gen_Delegate_Imp573(object p0, bool p1)
		{
			return null;
		}

		public CampShopItemConfigData __Gen_Delegate_Imp574(object p0, bool p1)
		{
			return null;
		}

		public List<CampShopItemConfigData> __Gen_Delegate_Imp575(bool p0)
		{
			return null;
		}

		public CampShopManager __Gen_Delegate_Imp576(object p0)
		{
			return null;
		}

		public UITableViewCellAlignment __Gen_Delegate_Imp577(object p0, object p1)
		{
			return UITableViewCellAlignment.RightOrTop;
		}

		public CampTalentPersonalData __Gen_Delegate_Imp578(object p0)
		{
			return null;
		}

		public CampTalentPersonalProgressData __Gen_Delegate_Imp579(object p0)
		{
			return null;
		}

		public CampTalentTeamData __Gen_Delegate_Imp580(object p0)
		{
			return null;
		}

		public CampTalentTeamProgressData __Gen_Delegate_Imp581(object p0)
		{
			return null;
		}

		public CampTalentTeamTaskData __Gen_Delegate_Imp582(object p0)
		{
			return null;
		}

		public CampTalentTeamTaskProgressData __Gen_Delegate_Imp583(object p0)
		{
			return null;
		}

		public CReqCampTalent __Gen_Delegate_Imp584(object p0)
		{
			return null;
		}

		public List<CampTalentPersonalProgressItemData> __Gen_Delegate_Imp585(object p0)
		{
			return null;
		}

		public List<CampTalentTeamProgressItemData> __Gen_Delegate_Imp586(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp587(object p0, object p1, int p2, int p3, int p4)
		{
		}

		public CampTalentPersonalProgressItemData __Gen_Delegate_Imp588(object p0, int p1, int p2)
		{
			return null;
		}

		public CampTalentPersonalProgressItemData __Gen_Delegate_Imp589(object p0, int p1)
		{
			return null;
		}

		public CampTalentPersonalProgressItemConfigData __Gen_Delegate_Imp590(object p0)
		{
			return null;
		}

		public SLG_Talent __Gen_Delegate_Imp591(object p0)
		{
			return null;
		}

		public (int, int) __Gen_Delegate_Imp592(object p0)
		{
			return default;
		}

		public CampTalentLineDir __Gen_Delegate_Imp593(object p0)
		{
			return CampTalentLineDir.None;
		}

		public CampTalentPersonalProgressItemData __Gen_Delegate_Imp594(object p0)
		{
			return null;
		}

		public CampTalentPersonalConfigData __Gen_Delegate_Imp595(int p0)
		{
			return null;
		}

		public CampTalentProgressConfigData __Gen_Delegate_Imp596(object p0)
		{
			return null;
		}

		public CampTalentPersonalProgressItemConfigData __Gen_Delegate_Imp597(int p0, CampTalentLineDir p1, object p2)
		{
			return null;
		}

		public List<CampTalentTeamTaskProgressItemData> __Gen_Delegate_Imp598(object p0)
		{
			return null;
		}

		public CampTalentTeamTaskProgressItemConfigData __Gen_Delegate_Imp599(object p0)
		{
			return null;
		}

		public CampTalentTeamTaskStatus __Gen_Delegate_Imp600(object p0)
		{
			return CampTalentTeamTaskStatus.None;
		}

		public CampTalentTeamTaskProgressItemData __Gen_Delegate_Imp601(object p0)
		{
			return null;
		}

		public CampTalentTeamProgressItemConfigData __Gen_Delegate_Imp602(object p0)
		{
			return null;
		}

		public SLG_CampTalent __Gen_Delegate_Imp603(object p0)
		{
			return null;
		}

		public CampTalentTeamProgressItemData __Gen_Delegate_Imp604(object p0)
		{
			return null;
		}

		public CampTalentTeamConfigData __Gen_Delegate_Imp605(int p0)
		{
			return null;
		}

		public CampTalentTeamTaskConfigData __Gen_Delegate_Imp606(int p0, int p1)
		{
			return null;
		}

		public CampTalentTeamTaskProgressConfigData __Gen_Delegate_Imp607(object p0)
		{
			return null;
		}

		public CampTalentTeamTaskProgressItemConfigData __Gen_Delegate_Imp608(int p0, int p1, object p2)
		{
			return null;
		}

		public CampTalentTeamProgressConfigData __Gen_Delegate_Imp609(object p0)
		{
			return null;
		}

		public CampTalentPersonalConfigData __Gen_Delegate_Imp610(object p0)
		{
			return null;
		}

		public CampTalentTeamProgressConfigData __Gen_Delegate_Imp611()
		{
			return null;
		}

		public CampTalentTeamTaskProgressConfigData __Gen_Delegate_Imp612()
		{
			return null;
		}

		public CampTalentLineDir __Gen_Delegate_Imp613(int p0, bool p1)
		{
			return CampTalentLineDir.None;
		}

		public void __Gen_Delegate_Imp614(object p0, CampTalentLineDir p1, CampTalentLineDir p2)
		{
		}

		public CampTalentManager __Gen_Delegate_Imp615(object p0)
		{
			return null;
		}

		public CampManager __Gen_Delegate_Imp616(object p0)
		{
			return null;
		}

		public (float, float) __Gen_Delegate_Imp617(object p0, float p1)
		{
			return default;
		}

		public (float, float) __Gen_Delegate_Imp618(object p0)
		{
			return default;
		}

		public (float, float) __Gen_Delegate_Imp619(object p0, bool p1)
		{
			return default;
		}

		public float __Gen_Delegate_Imp620(object p0, CampTileArrowType p1, bool p2, CampTileType p3, CampTileResourceType p4)
		{
			return 0f;
		}

		public (float, float) __Gen_Delegate_Imp621(object p0, CampTileArrowType p1, bool p2, CampTileType p3, CampTileResourceType p4)
		{
			return default;
		}

		public float __Gen_Delegate_Imp622(object p0, CampTileArrowType p1)
		{
			return 0f;
		}

		public float __Gen_Delegate_Imp623(object p0, CampTileType p1, CampTileResourceType p2)
		{
			return 0f;
		}

		public Dictionary<int, CampTileModelData> __Gen_Delegate_Imp624(object p0)
		{
			return null;
		}

		public CampTileModelData __Gen_Delegate_Imp625(object p0, int p1, int p2)
		{
			return null;
		}

		public CampTileModelData __Gen_Delegate_Imp626(object p0, (int, int) p1)
		{
			return null;
		}

		public CampTileModelData __Gen_Delegate_Imp627(object p0, int p1)
		{
			return null;
		}

		public CampTileOutputResourceType __Gen_Delegate_Imp628(object p0, CampTileResourceType p1)
		{
			return CampTileOutputResourceType.None;
		}

		public (float, float) __Gen_Delegate_Imp629(object p0, int p1, int p2)
		{
			return default;
		}

		public (CurrencyType, bool) __Gen_Delegate_Imp630(object p0, int p1, int p2)
		{
			return default;
		}

		public (CurrencyType, bool) __Gen_Delegate_Imp631(object p0, CampTileResourceType p1)
		{
			return default;
		}

		public (CurrencyType, bool) __Gen_Delegate_Imp632(object p0, CurrencyType p1)
		{
			return default;
		}

		public (CampTileOutputResourceType, float) __Gen_Delegate_Imp633(object p0, CampTileResourceType p1, int p2, int p3)
		{
			return default;
		}

		public void __Gen_Delegate_Imp634(object p0, CampTileType p1, object p2, object p3)
		{
		}

		public List<CampTileArrowDamageData> __Gen_Delegate_Imp635(object p0, object p1, int p2, int p3, int p4, CampTileType p5, CampTileResourceType p6)
		{
			return null;
		}

		public void __Gen_Delegate_Imp636(object p0, (int, int) p1, CampID p2, bool p3, object p4, int p5, int p6, object p7, object p8, object p9, long p10)
		{
		}

		public void __Gen_Delegate_Imp637(object p0, CampID p1, bool p2, int p3, int p4)
		{
		}

		public (BattleType, int) __Gen_Delegate_Imp638(object p0, int p1, int p2, CampID p3)
		{
			return default;
		}

		public HeroDispatchStatus __Gen_Delegate_Imp639(object p0, int p1)
		{
			return HeroDispatchStatus.None;
		}

		public void __Gen_Delegate_Imp640(object p0, object p1, int p2, object p3, CampID p4, int p5, bool p6, int p7, (int, int) p8, bool p9, object p10, CampTileOccupyAttackType p11, int p12, int p13, int p14, object p15, int p16, object p17, object p18)
		{
		}

		public List<CampTileReturnArrowData> __Gen_Delegate_Imp641(object p0, int p1, bool p2)
		{
			return null;
		}

		public void __Gen_Delegate_Imp642(object p0, object p1, int p2, object p3, CampTileOccupyAttackType p4, int p5, int p6, CampID p7, int p8)
		{
		}

		public CampTileBattleStatus __Gen_Delegate_Imp643(object p0, int p1, int p2, bool p3)
		{
			return CampTileBattleStatus.None;
		}

		public CampTileStatus __Gen_Delegate_Imp644(object p0, int p1, int p2)
		{
			return CampTileStatus.None;
		}

		public string __Gen_Delegate_Imp645(object p0, CampTileType p1, CampTileResourceType p2)
		{
			return null;
		}

		public string __Gen_Delegate_Imp646(object p0, CampTileResourceType p1)
		{
			return null;
		}

		public List<CampTileArrowDamageData> __Gen_Delegate_Imp647(object p0, CampTileArrowType p1, (int, int) p2, (int, int) p3, int p4, CampTileType p5, CampTileResourceType p6)
		{
			return null;
		}

		public (int, int) __Gen_Delegate_Imp648(object p0, CampTileArrowType p1, (int, int) p2, CampTileType p3, CampTileResourceType p4)
		{
			return default;
		}

		public void __Gen_Delegate_Imp649(object p0, int p1, int p2, CampTileType p3, object p4, object p5)
		{
		}

		public void __Gen_Delegate_Imp650(object p0, int p1, int p2, int p3, int p4, object p5, object p6)
		{
		}

		public void __Gen_Delegate_Imp651(object p0, uint p1, int p2, object p3, object p4)
		{
		}

		public void __Gen_Delegate_Imp652(object p0, int p1, (int, int) p2, object p3, object p4)
		{
		}

		public CampTileType __Gen_Delegate_Imp653(object p0, int p1)
		{
			return CampTileType.None;
		}

		public (CampTileOperationRestriction, CampTileOccupyRestriction) __Gen_Delegate_Imp654(object p0, int p1)
		{
			return default;
		}

		public CampTileOperationType __Gen_Delegate_Imp655(object p0, int p1)
		{
			return CampTileOperationType.None;
		}

		public CampTileOccupyAttackType __Gen_Delegate_Imp656(object p0, object p1)
		{
			return CampTileOccupyAttackType.None;
		}

		public CampTileResourceType __Gen_Delegate_Imp657(object p0, int p1)
		{
			return CampTileResourceType.None;
		}

		public CampTileOpenCond __Gen_Delegate_Imp658(object p0, int p1)
		{
			return CampTileOpenCond.None;
		}

		public BossBattleStatus __Gen_Delegate_Imp659(object p0, int p1)
		{
			return BossBattleStatus.None;
		}

		public CampTileManager __Gen_Delegate_Imp660(object p0)
		{
			return null;
		}

		public CampTileResourceType __Gen_Delegate_Imp661(object p0)
		{
			return CampTileResourceType.None;
		}

		public CampTileBattleStatus __Gen_Delegate_Imp662(object p0)
		{
			return CampTileBattleStatus.None;
		}

		public (CampTileOutputResourceType, float) __Gen_Delegate_Imp663(object p0)
		{
			return default;
		}

		public BossBattleStatus __Gen_Delegate_Imp664(object p0)
		{
			return BossBattleStatus.None;
		}

		public CampTileRewardStatus __Gen_Delegate_Imp665(object p0, int p1)
		{
			return CampTileRewardStatus.None;
		}

		public List<(int, List<Drop_DropModel.DropData>)> __Gen_Delegate_Imp666(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp667(object p0, int p1, object p2, object p3, object p4, long p5)
		{
		}

		public CampTileArrowType __Gen_Delegate_Imp668(object p0)
		{
			return CampTileArrowType.None;
		}

		public void __Gen_Delegate_Imp669(object p0, CampTileArrowType p1)
		{
		}

		public CampTileArrowDamageData __Gen_Delegate_Imp670(CampTileArrowType p0, bool p1, int p2, int p3)
		{
			return null;
		}

		public CampTileReturnArrowData __Gen_Delegate_Imp671(bool p0, int p1)
		{
			return null;
		}

		public CampTileBossConfigData __Gen_Delegate_Imp672(object p0, int p1, int p2, long p3)
		{
			return null;
		}

		public CampTileBossConfigData __Gen_Delegate_Imp673(object p0, object p1, object p2)
		{
			return null;
		}

		public CampTileBossConfigData __Gen_Delegate_Imp674(object p0, object p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp675(object p0, CampID p1, object p2, int p3)
		{
		}

		public CampTileModelData __Gen_Delegate_Imp676(int p0, int p1, CampTileType p2, int p3, int p4, int p5, CampTileOpenCond p6, CampTileOperationRestriction p7, CampTileOperationType p8, CampTileOccupyRestriction p9, CampTileOccupyType p10, int p11, CampTileOccupyAttackType p12, CampTileResourceType p13)
		{
			return null;
		}

		public CampTileParseData __Gen_Delegate_Imp677((int, int) p0, int p1, object p2, int p3, bool p4, int p5)
		{
			return null;
		}

		public CampTileTipData __Gen_Delegate_Imp678(object p0, object p1, object p2, object p3, object p4, object p5)
		{
			return null;
		}

		public CampTileTipData __Gen_Delegate_Imp679(object p0, object p1)
		{
			return null;
		}

		public CampTileHeroDispatchData __Gen_Delegate_Imp680(CampTileResourceType p0, (int, int) p1)
		{
			return null;
		}

		public CampTileArrowTransData __Gen_Delegate_Imp681((int, int) p0, CampTileType p1, CampID p2, object p3, int p4, CampTileResourceType p5, int p6, object p7, object p8, object p9)
		{
			return null;
		}

		public CampTileReOpenTransData __Gen_Delegate_Imp682(int p0, int p1, object p2, int p3, CampID p4, int p5, int p6, int p7, object p8, int p9, object p10, object p11, object p12)
		{
			return null;
		}

		public CampTileParseData __Gen_Delegate_Imp683(int p0, (int, int) p1, object p2)
		{
			return null;
		}

		public float __Gen_Delegate_Imp684(object p0, CampTileResourceType p1, int p2)
		{
			return 0f;
		}

		public List<int> __Gen_Delegate_Imp685(int p0, int p1, (float, float) p2)
		{
			return null;
		}

		public int __Gen_Delegate_Imp686(int p0, int p1)
		{
			return 0;
		}

		public CampKingScrambleStatus __Gen_Delegate_Imp687(object p0)
		{
			return CampKingScrambleStatus.None;
		}

		public CampTileType __Gen_Delegate_Imp688(object p0)
		{
			return CampTileType.None;
		}

		public void __Gen_Delegate_Imp689(object p0, object p1, int p2, CampID p3, object p4, CampTileBattleStatus p5)
		{
		}

		public Sequence __Gen_Delegate_Imp690(object p0, object p1, CampTileOccupyType p2)
		{
			return null;
		}

		public void __Gen_Delegate_Imp691(object p0, (CampID, int) p1, int p2, out float p3)
		{
			p3 = default;
		}

		public void __Gen_Delegate_Imp692(object p0, (CampID, int) p1, float p2)
		{
		}

		public void __Gen_Delegate_Imp693(object p0, (CampID, int) p1, (CampID, int) p2, CampID p3)
		{
		}

		public (CampID, CampID) __Gen_Delegate_Imp694(object p0)
		{
			return default;
		}

		public void __Gen_Delegate_Imp695(object p0, object p1, int p2, object p3, object p4, BossBattleStatus p5, (int, int) p6)
		{
		}

		public Sequence __Gen_Delegate_Imp696(object p0, object p1, CampID p2, CampTileOccupyType p3)
		{
			return null;
		}

		public void __Gen_Delegate_Imp697(object p0, BossBattleStatus p1)
		{
		}

		public void __Gen_Delegate_Imp698(object p0, object p1, object p2, int p3, CampTileOccupyAttackType p4, int p5, int p6, CampID p7, int p8)
		{
		}

		public CampTileMonsterProgressItem __Gen_Delegate_Imp699(object p0, int p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp700(object p0, int p1, object p2, CampTileRewardStatus p3, bool p4, (int, int) p5)
		{
		}

		public void __Gen_Delegate_Imp701(object p0, object p1, object p2, object p3, int p4, object p5)
		{
		}

		public void __Gen_Delegate_Imp702(object p0, CampID p1, ulong p2, int p3, ulong p4, int p5, object p6)
		{
		}

		public void __Gen_Delegate_Imp703(object p0, CampTileOccupyAttackType p1)
		{
		}

		public Sequence __Gen_Delegate_Imp704(object p0, int p1, int p2, Vector3 p3)
		{
			return null;
		}

		public void __Gen_Delegate_Imp705(object p0, (int, int) p1, CampTileResourceType p2)
		{
		}

		public void __Gen_Delegate_Imp706(object p0, (int, int) p1, int p2, object p3, int p4, CampTileResourceType p5)
		{
		}

		public (HeroDispatchStatus, (int, int)) __Gen_Delegate_Imp707(object p0)
		{
			return default;
		}

		public LocalSave.CharacterOne __Gen_Delegate_Imp708(object p0)
		{
			return null;
		}

		public HeroDispatchStatus __Gen_Delegate_Imp709(object p0)
		{
			return HeroDispatchStatus.None;
		}

		public List<(LocalSave.CharacterOne, int)> __Gen_Delegate_Imp710(object p0)
		{
			return null;
		}

		public CampMapManager __Gen_Delegate_Imp711(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp712(object p0, int p1, CampID p2, int p3)
		{
		}

		public void __Gen_Delegate_Imp713(object p0, int p1, int p2, CampTileType p3)
		{
		}

		public void __Gen_Delegate_Imp714(object p0, CampID p1, object p2, int p3, BossBattleStatus p4)
		{
		}

		public Sequence __Gen_Delegate_Imp715(object p0, object p1, CampID p2)
		{
			return null;
		}

		public void __Gen_Delegate_Imp716(object p0, object p1, int p2, CampID p3)
		{
		}

		public CampTileOccupyBtn __Gen_Delegate_Imp717(object p0, CampTileOccupyAttackType p1, (int, int) p2, object p3, CampID p4, int p5, bool p6, CampTileType p7, object p8, object p9, object p10)
		{
			return null;
		}

		public CampTileOccupyBtn __Gen_Delegate_Imp718(object p0, CampTileResourceType p1)
		{
			return null;
		}

		public CampTileOccupyBtn __Gen_Delegate_Imp719(object p0, CampID p1, BossBattleStatus p2, int p3, object p4, object p5, object p6)
		{
			return null;
		}

		public (BattleType, int) __Gen_Delegate_Imp720(object p0)
		{
			return default;
		}

		public BattleType __Gen_Delegate_Imp721(object p0)
		{
			return BattleType.None;
		}

		public void __Gen_Delegate_Imp722(object p0, CampTileOccupyAttackType p1, (int, int) p2, object p3, CampID p4, int p5, CampTileType p6, CampTileResourceType p7, CampID p8, int p9, object p10, object p11, object p12, object p13, object p14, object p15)
		{
		}

		public void __Gen_Delegate_Imp723(object p0, (CampTileOutputResourceType, float) p1)
		{
		}

		public void __Gen_Delegate_Imp724(object p0, CampTileOutputResourceType p1, float p2)
		{
		}

		public CampTileProgress __Gen_Delegate_Imp725(object p0, CampTileOccupyType p1, CampID p2, object p3, object p4, int p5, object p6, object p7)
		{
			return null;
		}

		public CampTileProgress __Gen_Delegate_Imp726(object p0, object p1, object p2)
		{
			return null;
		}

		public CampTileProgress __Gen_Delegate_Imp727(object p0, CampTileBattleStatus p1)
		{
			return null;
		}

		public CampTileProgress __Gen_Delegate_Imp728(object p0, BossBattleStatus p1, (int, int) p2)
		{
			return null;
		}

		public Sequence __Gen_Delegate_Imp729(object p0, object p1)
		{
			return null;
		}

		public ProgressType __Gen_Delegate_Imp730(object p0)
		{
			return ProgressType.None;
		}

		public Tweener __Gen_Delegate_Imp731(object p0, float p1)
		{
			return null;
		}

		public CReqActivityLuckyWheel __Gen_Delegate_Imp732(object p0)
		{
			return null;
		}

		public LuckyWheelData __Gen_Delegate_Imp733(object p0)
		{
			return null;
		}

		public LuckyWheelRewardData __Gen_Delegate_Imp734(object p0)
		{
			return null;
		}

		public LuckyWheelTaskData __Gen_Delegate_Imp735(object p0)
		{
			return null;
		}

		public LuckyWheelExtraRewardData __Gen_Delegate_Imp736(object p0)
		{
			return null;
		}

		public LuckyWheelConfigData __Gen_Delegate_Imp737(int p0, int p1, long p2, long p3)
		{
			return null;
		}

		public List<LuckyWheelRewardItemData> __Gen_Delegate_Imp738(object p0)
		{
			return null;
		}

		public LuckyWheelRewardItemConfigData __Gen_Delegate_Imp739(object p0)
		{
			return null;
		}

		public LuckyWheelRewardTheme __Gen_Delegate_Imp740(object p0)
		{
			return LuckyWheelRewardTheme.None;
		}

		public LuckyWheelRewardItemData __Gen_Delegate_Imp741(object p0)
		{
			return null;
		}

		public LuckyWheelRewardConfigData __Gen_Delegate_Imp742(int p0, object p1)
		{
			return null;
		}

		public List<LuckyWheelTaskItemData> __Gen_Delegate_Imp743(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp744(object p0, ulong p1)
		{
		}

		public LuckyWheelTaskItemConfigData __Gen_Delegate_Imp745(object p0)
		{
			return null;
		}

		public LuckyWheelRewardStatus __Gen_Delegate_Imp746(object p0)
		{
			return LuckyWheelRewardStatus.None;
		}

		public LuckyWheelTaskItemData __Gen_Delegate_Imp747(object p0)
		{
			return null;
		}

		public LuckyWheelTaskConfigData __Gen_Delegate_Imp748(ulong p0, object p1)
		{
			return null;
		}

		public List<LuckyWheelExtraRewardItemData> __Gen_Delegate_Imp749(object p0)
		{
			return null;
		}

		public LuckyWheelExtraRewardItemConfigData __Gen_Delegate_Imp750(object p0)
		{
			return null;
		}

		public LuckyWheelExtraRewardItemData __Gen_Delegate_Imp751(object p0)
		{
			return null;
		}

		public LuckyWheelExtraRewardConfigData __Gen_Delegate_Imp752(int p0, ulong p1, object p2)
		{
			return null;
		}

		public LuckyWheelManager __Gen_Delegate_Imp753(object p0)
		{
			return null;
		}

		public HalloweenShopData __Gen_Delegate_Imp754(object p0)
		{
			return null;
		}

		public HalloweenTaskData __Gen_Delegate_Imp755(object p0)
		{
			return null;
		}

		public HalloweenExchangeData __Gen_Delegate_Imp756(object p0)
		{
			return null;
		}

		public List<HalloweenMonsterData> __Gen_Delegate_Imp757(object p0)
		{
			return null;
		}

		public HalloweenQuickBuyData __Gen_Delegate_Imp758(object p0)
		{
			return null;
		}

		public HalloweenExchangeItemData __Gen_Delegate_Imp759(object p0, int p1)
		{
			return null;
		}

		public HalloweenMonsterData __Gen_Delegate_Imp760(object p0, int p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp761(object p0, int p1, int p2, object p3, bool p4, bool p5, int p6)
		{
		}

		public List<HalloweenComData> __Gen_Delegate_Imp762(object p0, int p1)
		{
			return null;
		}

		public HalloweenComData __Gen_Delegate_Imp763(object p0, int p1)
		{
			return null;
		}

		public HalloweenActManager __Gen_Delegate_Imp764(object p0)
		{
			return null;
		}

		public Christmas2023Data __Gen_Delegate_Imp765(object p0)
		{
			return null;
		}

		public Vault2023Data __Gen_Delegate_Imp766(object p0)
		{
			return null;
		}

		public Exchange2023Data __Gen_Delegate_Imp767(object p0)
		{
			return null;
		}

		public Gift2023Data __Gen_Delegate_Imp768(object p0)
		{
			return null;
		}

		public Challenge2023Data __Gen_Delegate_Imp769(object p0)
		{
			return null;
		}

		public STReqActivityPirateTreasure __Gen_Delegate_Imp770(object p0)
		{
			return null;
		}

		public Christmas2023ConfigData __Gen_Delegate_Imp771(object p0)
		{
			return null;
		}

		public Christmas2023ConfigData __Gen_Delegate_Imp772(int p0, long p1, long p2, long p3, long p4)
		{
			return null;
		}

		public List<Vault2023ShowRewardItemData> __Gen_Delegate_Imp773(object p0)
		{
			return null;
		}

		public List<Vault2023GameRewardItemData> __Gen_Delegate_Imp774(object p0)
		{
			return null;
		}

		public Vault2023GameShowRewardItemConfigData __Gen_Delegate_Imp775(object p0)
		{
			return null;
		}

		public List<Vault2023ShowRewardCondItemData> __Gen_Delegate_Imp776(object p0)
		{
			return null;
		}

		public Vault2023ShowRewardItemData __Gen_Delegate_Imp777(object p0)
		{
			return null;
		}

		public Vault2023ShowRewardCondItemConfigData __Gen_Delegate_Imp778(object p0)
		{
			return null;
		}

		public Vault2023ShowRewardCondItemData __Gen_Delegate_Imp779(object p0)
		{
			return null;
		}

		public Vault2023GameRewardItemConfigData __Gen_Delegate_Imp780(object p0)
		{
			return null;
		}

		public Vault2023GameRewardItemData __Gen_Delegate_Imp781(object p0)
		{
			return null;
		}

		public Vault2023ConfigData __Gen_Delegate_Imp782(long p0, long p1, int p2, int p3, object p4, object p5)
		{
			return null;
		}

		public Vault2023ShowRewardCondItemConfigData __Gen_Delegate_Imp783(int p0, object p1, object p2)
		{
			return null;
		}

		public Vault2023GameRewardItemConfigData __Gen_Delegate_Imp784(int p0, object p1)
		{
			return null;
		}

		public VaultAniData __Gen_Delegate_Imp785(int p0)
		{
			return null;
		}

		public List<Exchange2023ItemData> __Gen_Delegate_Imp786(object p0, bool p1, int p2)
		{
			return null;
		}

		public List<Exchange2023ItemData> __Gen_Delegate_Imp787(object p0, int p1)
		{
			return null;
		}

		public List<Exchange2023ItemData> __Gen_Delegate_Imp788(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp789(object p0, bool p1, int p2, int p3)
		{
		}

		public Exchange2023ConfigData __Gen_Delegate_Imp790(long p0, long p1, int p2, int p3, int p4, object p5, object p6, object p7)
		{
			return null;
		}

		public Exchange2023ItemConfigData __Gen_Delegate_Imp791(object p0)
		{
			return null;
		}

		public Exchange2023ItemData __Gen_Delegate_Imp792(object p0)
		{
			return null;
		}

		public List<Gift2023ItemData> __Gen_Delegate_Imp793(object p0)
		{
			return null;
		}

		public Gift2023ItemConfigData __Gen_Delegate_Imp794(object p0)
		{
			return null;
		}

		public Gift2023ItemData __Gen_Delegate_Imp795(object p0)
		{
			return null;
		}

		public Gift2023ConfigData __Gen_Delegate_Imp796(long p0, long p1, object p2)
		{
			return null;
		}

		public List<Challenge2023ItemData> __Gen_Delegate_Imp797(object p0)
		{
			return null;
		}

		public Challenge2023ItemConfigData __Gen_Delegate_Imp798(object p0)
		{
			return null;
		}

		public Christmas2023RewardStatus __Gen_Delegate_Imp799(object p0)
		{
			return Christmas2023RewardStatus.None;
		}

		public Challenge2023ItemData __Gen_Delegate_Imp800(object p0)
		{
			return null;
		}

		public Challenge2023ConfigData __Gen_Delegate_Imp801(long p0, long p1, object p2)
		{
			return null;
		}

		public Challenge2023ItemConfigData __Gen_Delegate_Imp802(int p0, int p1, int p2, int p3, int p4, int p5, object p6)
		{
			return null;
		}

		public Vault2023ConfigData __Gen_Delegate_Imp803(object p0, int p1)
		{
			return null;
		}

		public Exchange2023ConfigData __Gen_Delegate_Imp804(object p0)
		{
			return null;
		}

		public Gift2023ConfigData __Gen_Delegate_Imp805(object p0)
		{
			return null;
		}

		public Challenge2023ConfigData __Gen_Delegate_Imp806(object p0)
		{
			return null;
		}

		public Christmas2023Manager __Gen_Delegate_Imp807(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp808(object p0, object p1, bool p2, int p3)
		{
		}

		public Image __Gen_Delegate_Imp809(object p0)
		{
			return null;
		}

		public Image __Gen_Delegate_Imp810(object p0, int p1)
		{
			return null;
		}

		public IUILifeCycle __Gen_Delegate_Imp811(object p0)
		{
			return null;
		}

		public List<ManorTextData> __Gen_Delegate_Imp812(object p0)
		{
			return null;
		}

		public List<ManorMatDataShow> __Gen_Delegate_Imp813(object p0, int p1)
		{
			return null;
		}

		public Manor_Upgrade __Gen_Delegate_Imp814(object p0, int p1, int p2)
		{
			return null;
		}

		public List<ManorMatDataShow> __Gen_Delegate_Imp815(object p0, int p1, int p2)
		{
			return null;
		}

		public List<ManorTextData> __Gen_Delegate_Imp816(object p0, int p1, int p2, int p3)
		{
			return null;
		}

		public List<ManorTextData> __Gen_Delegate_Imp817(object p0, int p1, int p2)
		{
			return null;
		}

		public ManorData __Gen_Delegate_Imp818(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp819(object p0, int p1, ulong p2, int p3, bool p4, object p5)
		{
		}

		public void __Gen_Delegate_Imp820(object p0, int p1, ulong p2, int p3, object p4)
		{
		}

		public void __Gen_Delegate_Imp821(object p0, int p1, int p2, ushort p3, object p4, int p5)
		{
		}

		public ManorWorkerData __Gen_Delegate_Imp822(object p0, object p1, ulong p2)
		{
			return null;
		}

		public ManorWorkerData __Gen_Delegate_Imp823(object p0, object p1, int p2)
		{
			return null;
		}

		public ManorBuildingData __Gen_Delegate_Imp824(object p0, object p1, int p2)
		{
			return null;
		}

		public ManorBuildingData __Gen_Delegate_Imp825(object p0, int p1)
		{
			return null;
		}

		public ManorExchData __Gen_Delegate_Imp826(object p0, int p1)
		{
			return null;
		}

		public int __Gen_Delegate_Imp827(object p0, ulong p1)
		{
			return 0;
		}

		public CManorExchangeData[] __Gen_Delegate_Imp828(object p0)
		{
			return null;
		}

		public CManorExchangeData __Gen_Delegate_Imp829(object p0, int p1)
		{
			return null;
		}

		public Manor_Worker __Gen_Delegate_Imp830(object p0, int p1)
		{
			return null;
		}

		public IEnumerable<Manor_Upgrade> __Gen_Delegate_Imp831(object p0)
		{
			return null;
		}

		public IEnumerable<string[]> __Gen_Delegate_Imp832(object p0)
		{
			return null;
		}

		public IEnumerable<(Manor_Worker, int)> __Gen_Delegate_Imp833(object p0)
		{
			return null;
		}

		public List<int> __Gen_Delegate_Imp834(object p0, object p1, int p2)
		{
			return null;
		}

		public int __Gen_Delegate_Imp835(object p0, object p1, int p2, int p3)
		{
			return 0;
		}

		public ulong __Gen_Delegate_Imp836(object p0, object p1, int p2, int p3)
		{
			return 0uL;
		}

		public void __Gen_Delegate_Imp837(object p0, object p1, int p2, int p3, ulong p4)
		{
		}

		public ManorStealItemData __Gen_Delegate_Imp838(object p0, int p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp839(object p0, ManorTab p1)
		{
		}

		public Vector3 __Gen_Delegate_Imp840(object p0, CurrencyType p1)
		{
			return default;
		}

		public void __Gen_Delegate_Imp841(object p0, object p1, ulong p2)
		{
		}

		public MiningMapShowData __Gen_Delegate_Imp842(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp843(object p0, int p1, int p2, int p3, object p4, bool p5)
		{
		}

		public List<MiningBlockShowData> __Gen_Delegate_Imp844(object p0)
		{
			return null;
		}

		public Drop_DropModel.DropData __Gen_Delegate_Imp845(object p0, int p1, int p2)
		{
			return null;
		}

		public List<Drop_DropModel.DropData> __Gen_Delegate_Imp846(object p0, int p1)
		{
			return null;
		}

		public bool __Gen_Delegate_Imp847(object p0, object p1, object p2)
		{
			return false;
		}

		public void __Gen_Delegate_Imp848(object p0, MiningPropType p1)
		{
		}

		public MiningPropType __Gen_Delegate_Imp849(object p0)
		{
			return (MiningPropType)0;
		}

		public MiningBoxItemData __Gen_Delegate_Imp850(object p0, int p1)
		{
			return null;
		}

		public MiningGiftItemData __Gen_Delegate_Imp851(object p0, int p1)
		{
			return null;
		}

		public MiningQuickItemData __Gen_Delegate_Imp852(object p0, int p1)
		{
			return null;
		}

		public MiningShopItemData __Gen_Delegate_Imp853(object p0, int p1)
		{
			return null;
		}

		public List<MiningShopItemData> __Gen_Delegate_Imp854(object p0, int p1)
		{
			return null;
		}

		public MiningTaskItemData __Gen_Delegate_Imp855(object p0, int p1)
		{
			return null;
		}

		public List<MiningTaskItemData> __Gen_Delegate_Imp856(object p0)
		{
			return null;
		}

		public MiningMapData __Gen_Delegate_Imp857(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp858(object p0, float p1, float p2, float p3, float p4, object p5)
		{
		}

		public Tweener __Gen_Delegate_Imp859(object p0, float p1, float p2)
		{
			return null;
		}

		public List<SkinAbilityMaterialItemData> __Gen_Delegate_Imp860(object p0, int p1, float p2, int p3, int p4)
		{
			return null;
		}

		public List<SkinAbilityItemData> __Gen_Delegate_Imp861(object p0)
		{
			return null;
		}

		public List<SkinAbilityMaterialItemData> __Gen_Delegate_Imp862(object p0)
		{
			return null;
		}

		public SkinAbilityData __Gen_Delegate_Imp863(int p0)
		{
			return null;
		}

		public List<SkinAbilityMaterialItemData> __Gen_Delegate_Imp864(object p0, int p1)
		{
			return null;
		}

		public Goods_goods.GoodData __Gen_Delegate_Imp865(object p0)
		{
			return null;
		}

		public Goods_goods.GoodShowData __Gen_Delegate_Imp866(object p0)
		{
			return null;
		}

		public SkinAbilityItemData __Gen_Delegate_Imp867(int p0, int p1, object p2)
		{
			return null;
		}

		public SkinAbilityMaterialItemData __Gen_Delegate_Imp868(int p0, int p1, int p2)
		{
			return null;
		}

		public SkinAbilityResetData __Gen_Delegate_Imp869(int p0)
		{
			return null;
		}

		public SkinAbilityResetSuccessData __Gen_Delegate_Imp870(int p0, int p1, int p2, object p3)
		{
			return null;
		}

		public SkinAbilityResetSuccessData __Gen_Delegate_Imp871(object p0)
		{
			return null;
		}

		public SkinAbilityManager __Gen_Delegate_Imp872(object p0)
		{
			return null;
		}

		public SkinAbilityResetData __Gen_Delegate_Imp873(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp874(object p0, object p1, long p2)
		{
		}

		public SkinAbilityData __Gen_Delegate_Imp875(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp876(object p0, float p1, float p2, float p3, float p4)
		{
		}

		public ActRedEnvelopeMgr __Gen_Delegate_Imp877()
		{
			return null;
		}

		public ActRedEnvelopeMgr.ActivityTagConfig __Gen_Delegate_Imp878(object p0)
		{
			return null;
		}

		public ActRedEnvelopeMgr.RedEnvelopeRankingConfig __Gen_Delegate_Imp879(object p0, int p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp880(object p0, ushort p1, ushort p2)
		{
		}

		public List<ActRedEnvelopeGiftData> __Gen_Delegate_Imp881(object p0)
		{
			return null;
		}

		public Color __Gen_Delegate_Imp882(object p0)
		{
			return default;
		}

		public void __Gen_Delegate_Imp883(object p0, ulong p1, uint p2)
		{
		}

		public CommonShopBuyUIPanel.ShopData __Gen_Delegate_Imp884(object p0)
		{
			return null;
		}

		public ActSevenDayUIPanel __Gen_Delegate_Imp885(object p0)
		{
			return null;
		}

		public NewRechargeUIPanel __Gen_Delegate_Imp886(object p0)
		{
			return null;
		}

		public NewSingleChargeUIPanel __Gen_Delegate_Imp887(object p0)
		{
			return null;
		}

		public ReChargeDayUIPanel __Gen_Delegate_Imp888(object p0)
		{
			return null;
		}

		public ActSevenChallengeUIPanel __Gen_Delegate_Imp889(object p0)
		{
			return null;
		}

		public CarnivalShopPanel __Gen_Delegate_Imp890(object p0)
		{
			return null;
		}

		public ActSevenDayChallengeManager __Gen_Delegate_Imp891()
		{
			return null;
		}

		public STSevenAppendExchangeData[] __Gen_Delegate_Imp892(object p0)
		{
			return null;
		}

		public List<SevenDayChallengeGiftData> __Gen_Delegate_Imp893(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp894(object p0, uint p1, uint p2)
		{
		}

		public void __Gen_Delegate_Imp895(object p0, float p1, FishingRodStatus p2)
		{
		}

		public void __Gen_Delegate_Imp896(object p0, FishingFishStatus p1, float p2, float p3, FishingRodStatus p4)
		{
		}

		public FishingUpStatus __Gen_Delegate_Imp897(object p0, bool p1)
		{
			return FishingUpStatus.None;
		}

		public FishingUpStatus __Gen_Delegate_Imp898(object p0)
		{
			return FishingUpStatus.None;
		}

		public FishingManager __Gen_Delegate_Imp899(object p0)
		{
			return null;
		}

		public FishingRodData __Gen_Delegate_Imp900(object p0)
		{
			return null;
		}

		public (string, bool) __Gen_Delegate_Imp901(object p0)
		{
			return default;
		}

		public Spine.AnimationState __Gen_Delegate_Imp902(object p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp903(object p0, (string, bool) p1, object p2)
		{
		}

		public FishingS3ConfigData __Gen_Delegate_Imp904(object p0)
		{
			return null;
		}

		public FishingData __Gen_Delegate_Imp905(object p0)
		{
			return null;
		}

		public FishingSceneData __Gen_Delegate_Imp906(object p0)
		{
			return null;
		}

		public FishingRankingData __Gen_Delegate_Imp907(object p0)
		{
			return null;
		}

		public FishingRankingRewardData __Gen_Delegate_Imp908(object p0)
		{
			return null;
		}

		public FishingBestiaryData __Gen_Delegate_Imp909(object p0)
		{
			return null;
		}

		public FishingRodBestiaryData __Gen_Delegate_Imp910(object p0)
		{
			return null;
		}

		public FishingLureData __Gen_Delegate_Imp911(object p0)
		{
			return null;
		}

		public FishingGiftData __Gen_Delegate_Imp912(object p0)
		{
			return null;
		}

		public FishingTaskData __Gen_Delegate_Imp913(object p0)
		{
			return null;
		}

		public FishingShopData __Gen_Delegate_Imp914(object p0)
		{
			return null;
		}

		public CReqGameFishing __Gen_Delegate_Imp915(object p0)
		{
			return null;
		}

		public (bool, bool) __Gen_Delegate_Imp916(object p0)
		{
			return default;
		}

		public (string, bool) __Gen_Delegate_Imp917(object p0, FishingRodAniStatus p1)
		{
			return default;
		}

		public (string, bool) __Gen_Delegate_Imp918(object p0, FishingFishAniStatus p1)
		{
			return default;
		}

		public string __Gen_Delegate_Imp919(object p0, FishingRodType p1)
		{
			return null;
		}

		public void __Gen_Delegate_Imp920(object p0, int p1, uint p2, int p3, int p4, object p5, object p6)
		{
		}

		public void __Gen_Delegate_Imp921(object p0, int p1, int p2, uint p3, int p4, object p5, object p6)
		{
		}

		public void __Gen_Delegate_Imp922(object p0, int p1, int p2, FishingResult p3, object p4)
		{
		}

		public FishingConfigData __Gen_Delegate_Imp923(int p0, long p1, long p2, long p3, long p4, long p5)
		{
			return null;
		}

		public FishingSceneConfigData __Gen_Delegate_Imp924(int p0)
		{
			return null;
		}

		public FishingRodType __Gen_Delegate_Imp925(object p0)
		{
			return FishingRodType.None;
		}

		public FishingRodType __Gen_Delegate_Imp926(object p0, int p1)
		{
			return FishingRodType.None;
		}

		public FishingRodConfigData __Gen_Delegate_Imp927(object p0)
		{
			return null;
		}

		public List<FishingConfigRankConfigData> __Gen_Delegate_Imp928(object p0)
		{
			return null;
		}

		public FishingRankingItemData __Gen_Delegate_Imp929(object p0, int p1)
		{
			return null;
		}

		public FishingRankingItemData __Gen_Delegate_Imp930(object p0)
		{
			return null;
		}

		public List<FishingRankingItemData> __Gen_Delegate_Imp931(object p0)
		{
			return null;
		}

		public List<FishingRankingSeasonItemData> __Gen_Delegate_Imp932(object p0)
		{
			return null;
		}

		public FishingRankingConfigData __Gen_Delegate_Imp933(int p0, object p1, object p2, object p3, object p4)
		{
			return null;
		}

		public FishingRankingSeasonItemConfigData __Gen_Delegate_Imp934(object p0)
		{
			return null;
		}

		public FishingRankingSeasonItemData __Gen_Delegate_Imp935(object p0)
		{
			return null;
		}

		public FishingRankingSeasonItemConfigData __Gen_Delegate_Imp936(object p0, object p1)
		{
			return null;
		}

		public FishingRankingItemConfigData __Gen_Delegate_Imp937(object p0)
		{
			return null;
		}

		public FishingConfigRankConfigData __Gen_Delegate_Imp938(object p0, int p1)
		{
			return null;
		}

		public FishingRankingItemConfigData __Gen_Delegate_Imp939(ulong p0, int p1, long p2, object p3, int p4, int p5, long p6, int p7, object p8, int p9)
		{
			return null;
		}

		public FishingRankingDetailData __Gen_Delegate_Imp940(object p0)
		{
			return null;
		}

		public List<FishingBestiaryBoxItemData> __Gen_Delegate_Imp941(object p0)
		{
			return null;
		}

		public FishingBestiarySceneItemData __Gen_Delegate_Imp942(object p0, int p1)
		{
			return null;
		}

		public FishingBestiaryConfigData __Gen_Delegate_Imp943(ulong p0, int p1, object p2)
		{
			return null;
		}

		public FishingBestiaryBoxItemConfigData __Gen_Delegate_Imp944(object p0)
		{
			return null;
		}

		public FishingRewardStatus __Gen_Delegate_Imp945(object p0)
		{
			return FishingRewardStatus.None;
		}

		public FishingBestiaryBoxItemData __Gen_Delegate_Imp946(object p0)
		{
			return null;
		}

		public FishingBestiaryBoxItemConfigData __Gen_Delegate_Imp947(int p0, int p1, object p2)
		{
			return null;
		}

		public FishingBestiarySceneItemConfigData __Gen_Delegate_Imp948(object p0)
		{
			return null;
		}

		public List<FishingBestiaryItemData> __Gen_Delegate_Imp949(object p0)
		{
			return null;
		}

		public FishingBestiarySceneItemData __Gen_Delegate_Imp950(object p0)
		{
			return null;
		}

		public FishingBestiarySceneItemConfigData __Gen_Delegate_Imp951(int p0, object p1)
		{
			return null;
		}

		public FishingBestiaryItemConfigData __Gen_Delegate_Imp952(object p0)
		{
			return null;
		}

		public List<FishingBestiaryFishItemData> __Gen_Delegate_Imp953(object p0)
		{
			return null;
		}

		public FishingBestiaryItemData __Gen_Delegate_Imp954(object p0)
		{
			return null;
		}

		public FishingBestiaryItemConfigData __Gen_Delegate_Imp955(int p0, object p1)
		{
			return null;
		}

		public FishingBestiaryFishItemConfigData __Gen_Delegate_Imp956(object p0)
		{
			return null;
		}

		public FishingFishType __Gen_Delegate_Imp957(object p0)
		{
			return FishingFishType.None;
		}

		public FishingBestiaryFishItemData __Gen_Delegate_Imp958(object p0)
		{
			return null;
		}

		public FishingBestiaryFishItemConfigData __Gen_Delegate_Imp959(int p0, bool p1)
		{
			return null;
		}

		public FishingLureConfigData __Gen_Delegate_Imp960(int p0)
		{
			return null;
		}

		public List<FishingGiftItemData> __Gen_Delegate_Imp961(object p0)
		{
			return null;
		}

		public FishingGiftItemConfigData __Gen_Delegate_Imp962(object p0)
		{
			return null;
		}

		public FishingGiftItemData __Gen_Delegate_Imp963(object p0)
		{
			return null;
		}

		public FishingGiftConfigData __Gen_Delegate_Imp964(object p0)
		{
			return null;
		}

		public List<FishingTaskItemData> __Gen_Delegate_Imp965(object p0)
		{
			return null;
		}

		public FishingTaskItemConfigData __Gen_Delegate_Imp966(object p0)
		{
			return null;
		}

		public FishingTaskItemData __Gen_Delegate_Imp967(object p0)
		{
			return null;
		}

		public FishingTaskConfigData __Gen_Delegate_Imp968(object p0)
		{
			return null;
		}

		public List<FishingShopCurrencyItemData> __Gen_Delegate_Imp969(object p0, int p1)
		{
			return null;
		}

		public List<FishingShopItemData> __Gen_Delegate_Imp970(object p0, int p1)
		{
			return null;
		}

		public List<FishingShopItemData> __Gen_Delegate_Imp971(object p0)
		{
			return null;
		}

		public FishingShopConfigData __Gen_Delegate_Imp972(object p0, object p1)
		{
			return null;
		}

		public FishingShopItemConfigData __Gen_Delegate_Imp973(object p0)
		{
			return null;
		}

		public List<FishingShopGoodsItemData> __Gen_Delegate_Imp974(object p0)
		{
			return null;
		}

		public FishingShopItemData __Gen_Delegate_Imp975(object p0)
		{
			return null;
		}

		public FishingShopItemConfigData __Gen_Delegate_Imp976(int p0, object p1)
		{
			return null;
		}

		public FishingShopGoodsItemConfigData __Gen_Delegate_Imp977(object p0)
		{
			return null;
		}

		public FishingShopGoodsItemData __Gen_Delegate_Imp978(object p0)
		{
			return null;
		}

		public FishingShopGoodsItemConfigData __Gen_Delegate_Imp979(int p0, int p1, int p2, int p3, int p4, int p5, int p6, object p7, object p8)
		{
			return null;
		}

		public FishingShopCurrencyItemConfigData __Gen_Delegate_Imp980(object p0)
		{
			return null;
		}

		public FishingShopCurrencyItemData __Gen_Delegate_Imp981(object p0)
		{
			return null;
		}

		public FishingShopCurrencyItemConfigData __Gen_Delegate_Imp982(int p0)
		{
			return null;
		}

		public FishingResult __Gen_Delegate_Imp983(object p0)
		{
			return FishingResult.None;
		}

		public void __Gen_Delegate_Imp984(object p0, FishingResult p1)
		{
		}

		public List<FishingResultItemData> __Gen_Delegate_Imp985(object p0)
		{
			return null;
		}

		public Action __Gen_Delegate_Imp986(object p0)
		{
			return null;
		}

		public FishingResultData __Gen_Delegate_Imp987(FishingResult p0, object p1, object p2)
		{
			return null;
		}

		public FishingResultItemData __Gen_Delegate_Imp988(object p0, int p1)
		{
			return null;
		}

		public FishingConfigFishBaseConfigData __Gen_Delegate_Imp989(object p0)
		{
			return null;
		}

		public FishingConfigFishConfigData __Gen_Delegate_Imp990(object p0)
		{
			return null;
		}

		public FishingConfigFishRodConfigData __Gen_Delegate_Imp991(object p0)
		{
			return null;
		}

		public FishingConfigFishMoveConfigData __Gen_Delegate_Imp992(object p0)
		{
			return null;
		}

		public FishingAniData __Gen_Delegate_Imp993(int p0, int p1, int p2)
		{
			return null;
		}

		public FishingConfigTimeConfigData __Gen_Delegate_Imp994(object p0, int p1)
		{
			return null;
		}

		public FishingConfigFishBaseConfigData __Gen_Delegate_Imp995(object p0, int p1)
		{
			return null;
		}

		public FishingConfigFishConfigData __Gen_Delegate_Imp996(object p0, int p1)
		{
			return null;
		}

		public FishingConfigFishRodConfigData __Gen_Delegate_Imp997(object p0, int p1)
		{
			return null;
		}

		public FishingConfigFishMoveConfigData __Gen_Delegate_Imp998(object p0, int p1)
		{
			return null;
		}

		public FishingConfigFishUnlockConfigData __Gen_Delegate_Imp999(object p0, int p1)
		{
			return null;
		}

		public List<FishingConfigFishUnlockConfigData> __Gen_Delegate_Imp1000(object p0)
		{
			return null;
		}

		public FishingConfigSkillConfigData __Gen_Delegate_Imp1001(object p0, int p1)
		{
			return null;
		}

		public FishingRankingConfigData __Gen_Delegate_Imp1002(int p0, object p1)
		{
			return null;
		}

		public FishingRankingRewardConfigData __Gen_Delegate_Imp1003(int p0, int p1)
		{
			return null;
		}

		public FishingBestiaryConfigData __Gen_Delegate_Imp1004(object p0, uint p1)
		{
			return null;
		}

		public FishingRodBestiaryConfigData __Gen_Delegate_Imp1005()
		{
			return null;
		}

		public FishingLureConfigData __Gen_Delegate_Imp1006(int p0, int p1)
		{
			return null;
		}

		public FishingGiftConfigData __Gen_Delegate_Imp1007(object p0, object p1)
		{
			return null;
		}

		public FishingTaskConfigData __Gen_Delegate_Imp1008(object p0, object p1)
		{
			return null;
		}

		public GridLayoutGroup __Gen_Delegate_Imp1009(object p0)
		{
			return null;
		}

		public FishingFishAniStatus __Gen_Delegate_Imp1010(object p0, FishingFishStatus p1)
		{
			return FishingFishAniStatus.None;
		}

		public void __Gen_Delegate_Imp1011(object p0, FishingResult p1, int p2)
		{
		}

		public Fishing_Fish __Gen_Delegate_Imp1012(object p0)
		{
			return null;
		}

		public Fishing_FishBase __Gen_Delegate_Imp1013(object p0)
		{
			return null;
		}

		public Fishing_FishMove __Gen_Delegate_Imp1014(object p0)
		{
			return null;
		}

		public Fishing_FishRod __Gen_Delegate_Imp1015(object p0)
		{
			return null;
		}

		public Fishing_FishUnlock __Gen_Delegate_Imp1016(object p0)
		{
			return null;
		}

		public CampTownSkinData __Gen_Delegate_Imp1017(object p0)
		{
			return null;
		}

		public CampTownSkinItemData __Gen_Delegate_Imp1018(object p0)
		{
			return null;
		}

		public List<CampTownSkinItemData> __Gen_Delegate_Imp1019(object p0)
		{
			return null;
		}

		public CampTownSkinConfigData __Gen_Delegate_Imp1020(int p0, object p1, object p2)
		{
			return null;
		}

		public CampTownSkinItemConfigData __Gen_Delegate_Imp1021(object p0)
		{
			return null;
		}

		public CampTownSkinLockType __Gen_Delegate_Imp1022(object p0)
		{
			return CampTownSkinLockType.None;
		}

		public List<CampTownSkinAttributeItemData> __Gen_Delegate_Imp1023(object p0)
		{
			return null;
		}

		public CampTownSkinItemConfigData __Gen_Delegate_Imp1024(int p0)
		{
			return null;
		}

		public CampTownSkinAttributeItemConfigData __Gen_Delegate_Imp1025(object p0)
		{
			return null;
		}

		public CampTownSkinAttributeItemData __Gen_Delegate_Imp1026(object p0)
		{
			return null;
		}

		public CampTownSkinManager __Gen_Delegate_Imp1027(object p0)
		{
			return null;
		}

		public SLG_SLGskin __Gen_Delegate_Imp1028(object p0)
		{
			return null;
		}

		public Vector3 __Gen_Delegate_Imp1029(object p0, Vector3 p1, Vector3 p2)
		{
			return default;
		}

		public int __Gen_Delegate_Imp1030(object p0, int p1, out double p2, ref string p3)
		{
			p2 = default;
			return 0;
		}

		public int __Gen_Delegate_Imp1031(object p0, int p1, out double p2, ref string p3, object p4)
		{
			p2 = default;
			return 0;
		}

		public GameObject __Gen_Delegate_Imp1032(StructTest p0, int p1, object p2)
		{
			return null;
		}

		public string __Gen_Delegate_Imp1033(StructTest p0)
		{
			return null;
		}

		public void __Gen_Delegate_Imp1034(StructTest p0, object p1)
		{
		}

		static DelegateBridge()
		{
		}

		public override Delegate GetDelegateByType(Type type)
		{
			return null;
		}

		public DelegateBridge(int reference, LuaEnv luaenv)
			: base(0, null)
		{
		}

		public void PCall(IntPtr L, int nArgs, int nResults, int errFunc)
		{
		}

		public void InvokeSessionStart()
		{
		}

		public void Invoke(int nRet)
		{
		}

		public void InvokeSessionEnd()
		{
		}

		public TResult InvokeSessionEndWithResult<TResult>()
		{
			return default;
		}

		public void InParam<T>(T p)
		{
		}

		public void InParams<T>(T[] ps)
		{
		}

		public void OutParam<TResult>(int pos, out TResult ret)
		{
			ret = default;
		}

		public void Action()
		{
		}

		public void Action<T1>(T1 p1)
		{
		}

		public void Action<T1, T2>(T1 p1, T2 p2)
		{
		}

		public void Action<T1, T2, T3>(T1 p1, T2 p2, T3 p3)
		{
		}

		public void Action<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4)
		{
		}

		public TResult Func<TResult>()
		{
			return default;
		}

		public TResult Func<T1, TResult>(T1 p1)
		{
			return default;
		}

		public TResult Func<T1, T2, TResult>(T1 p1, T2 p2)
		{
			return default;
		}

		public TResult Func<T1, T2, T3, TResult>(T1 p1, T2 p2, T3 p3)
		{
			return default;
		}

		public TResult Func<T1, T2, T3, T4, TResult>(T1 p1, T2 p2, T3 p3, T4 p4)
		{
			return default;
		}
	}
}
