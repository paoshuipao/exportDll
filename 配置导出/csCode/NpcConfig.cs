
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class NpcConfigData : IConfig 
	{
		
		public string name;

		public string textureReplace;

		public string model;

		public string LogicTemplate;

		public int AniSpeed;

		public NpcConfigData(int id1, string name1, string textureReplace1, string model1, string LogicTemplate1, int AniSpeed1) 
		{
			
			id=id1;

			name=name1;

			textureReplace=textureReplace1;

			model=model1;

			LogicTemplate=LogicTemplate1;

			AniSpeed=AniSpeed1;

		}
	}

	public partial class GameData 
	{
		
		public static List<NpcConfigData> NpcConfig = new List<NpcConfigData>() 
		{
			
			new NpcConfigData(20001, "巨牙子", "", "models/npcs/mage", "QuestNpcAI", 100),

			new NpcConfigData(20002, "灭婆", "", "models/npcs/gemcutter", "QuestNpcAI", 100),

			new NpcConfigData(20003, "至若", "", "models/npcs/sage", "QuestNpcAI", 100),

			new NpcConfigData(20004, "东湖", "", "models/npcs/brink", "QuestNpcAI", 100),

			new NpcConfigData(20005, "秦情", "", "models/npcs/female", "QuestNpcAI", 100),

			new NpcConfigData(20006, "万山", "", "models/npcs/gambler", "QuestNpcAI", 100),

			new NpcConfigData(20007, "阿牛", "", "models/npcs/boy", "QuestNpcAI", 100),

			new NpcConfigData(20008, "至若", "", "models/npcs/sage", "FollowNpcAI", 100),

			new NpcConfigData(20009, "东湖", "", "models/npcs/brink", "FollowNpcAI", 100),

		};

	}
}
