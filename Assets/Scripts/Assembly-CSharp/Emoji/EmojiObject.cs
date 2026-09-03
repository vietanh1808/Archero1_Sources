using TableTool;

namespace Emoji
{
	public class EmojiObject
	{
		public int Id { get; private set; }

		public PlayerCharacter_Emotion Config { get; private set; }

		public EntityBase entity { get; protected set; }

		public EmojiObject(PlayerCharacter_Emotion pConfig, EntityBase pOwner)
		{
		}

		public EmojiObject(int pId, EntityBase pOwner)
		{
		}

		public void SetOwner(EntityBase pOwner)
		{
		}

		public void Play()
		{
		}
	}
}
