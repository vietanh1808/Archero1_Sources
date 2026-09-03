using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace TCPPacket.ProtoBuf
{
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerInfo : IMessage<PlayerInfo>, IMessage, IEquatable<PlayerInfo>, IDeepCloneable<PlayerInfo>
	{
		private static readonly MessageParser<PlayerInfo> _parser;

		private UnknownFieldSet _unknownFields;

		public const int CharacterIdFieldNumber = 1;

		private int characterId_;

		public const int SkinIdFieldNumber = 2;

		private int skinId_;

		public const int CharacterLevelFieldNumber = 3;

		private int characterLevel_;

		public const int EquipsFieldNumber = 4;

		private static readonly FieldCodec<EquipItem> _repeated_equips_codec;

		private readonly RepeatedField<EquipItem> equips_;

		public const int CardsFieldNumber = 5;

		private static readonly FieldCodec<CardItem> _repeated_cards_codec;

		private readonly RepeatedField<CardItem> cards_;

		public const int RunAttrsFieldNumber = 6;

		private static readonly FieldCodec<string> _repeated_runAttrs_codec;

		private readonly RepeatedField<string> runAttrs_;

		public const int EggsFieldNumber = 7;

		private static readonly MapField<uint, EggItem>.Codec _map_eggs_codec;

		private readonly MapField<uint, EggItem> eggs_;

		public const int UnlockTrainsFieldNumber = 8;

		private static readonly FieldCodec<GoodItem> _repeated_unlockTrains_codec;

		private readonly RepeatedField<GoodItem> unlockTrains_;

		public const int AllHeroUnlockTrainsFieldNumber = 9;

		private static readonly FieldCodec<GoodItem> _repeated_allHeroUnlockTrains_codec;

		private readonly RepeatedField<GoodItem> allHeroUnlockTrains_;

		public const int HeroUnlocksFieldNumber = 10;

		private static readonly FieldCodec<LockEffectData> _repeated_heroUnlocks_codec;

		private readonly RepeatedField<LockEffectData> heroUnlocks_;

		public const int AllHeroUnlocksFieldNumber = 11;

		private static readonly FieldCodec<LockEffectData> _repeated_allHeroUnlocks_codec;

		private readonly RepeatedField<LockEffectData> allHeroUnlocks_;

		public const int StarFieldNumber = 12;

		private int star_;

		public const int WeaponSkinIdFieldNumber = 13;

		private int weaponSkinId_;

		public const int RelicsFieldNumber = 14;

		private static readonly FieldCodec<EquipItem> _repeated_relics_codec;

		private readonly RepeatedField<EquipItem> relics_;

		public const int MainWingFieldNumber = 15;

		private WingItem mainWing_;

		public const int AssistWingsFieldNumber = 16;

		private static readonly FieldCodec<WingItem> _repeated_assistWings_codec;

		private readonly RepeatedField<WingItem> assistWings_;

		public const int DisplayWingFieldNumber = 17;

		private WingItem displayWing_;

		public const int ArtifactItemDatasFieldNumber = 18;

		private static readonly FieldCodec<ArtifactItemData> _repeated_artifactItemDatas_codec;

		private readonly RepeatedField<ArtifactItemData> artifactItemDatas_;

		public const int TotalIapCashFieldNumber = 19;

		private int totalIapCash_;

		public const int ColorIdFieldNumber = 20;

		private int colorId_;

		public const int WeaponSkinLvFieldNumber = 21;

		private int weaponSkinLv_;

		public const int RefineSkillsFieldNumber = 22;

		private static readonly FieldCodec<int> _repeated_refineSkills_codec;

		private readonly RepeatedField<int> refineSkills_;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerInfo> Parser => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CharacterId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CharacterLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EquipItem> Equips => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CardItem> Cards => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> RunAttrs => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, EggItem> Eggs => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GoodItem> UnlockTrains => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GoodItem> AllHeroUnlockTrains => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LockEffectData> HeroUnlocks => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LockEffectData> AllHeroUnlocks => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Star
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponSkinId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EquipItem> Relics => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WingItem MainWing
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WingItem> AssistWings => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WingItem DisplayWing
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArtifactItemData> ArtifactItemDatas => null;

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalIapCash
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ColorId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponSkinLv
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RefineSkills => null;

		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
		{
			return null;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerInfo()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerInfo(PlayerInfo other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerInfo other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return null;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerInfo other)
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
