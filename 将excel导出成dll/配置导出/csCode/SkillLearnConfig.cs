
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class SkillLearnConfigData : IConfig 
	{
		
		public int skillId;

		public int restrictLevel;

		public int addLevel;

		public int skillPoint;

		public string itemIds;

		public string preSkills;

		public bool canDemotion;

		public string skillDescript;

		public SkillLearnConfigData(int id1, int skillId1, int restrictLevel1, int addLevel1, int skillPoint1, string itemIds1, string preSkills1, bool canDemotion1, string skillDescript1) 
		{
			
			id=id1;

			skillId=skillId1;

			restrictLevel=restrictLevel1;

			addLevel=addLevel1;

			skillPoint=skillPoint1;

			itemIds=itemIds1;

			preSkills=preSkills1;

			canDemotion=canDemotion1;

			skillDescript=skillDescript1;

		}
		
		public override string ToString()
		{
			return "     主键ID- "+id+"     所属技能ID- "+skillId+"     需要等级- "+restrictLevel+"     每个多少级升级一次- "+addLevel+"     需要技能点数- "+skillPoint+"     需要道具ID- "+itemIds+"     前置技能- "+preSkills+"     是否允许降级- "+canDemotion+"     技能描述- "+skillDescript;
		}

	}

	public partial class GameData 
	{
		
		public static List<SkillLearnConfigData> SkillLearnConfig = new List<SkillLearnConfigData>() 
		{
			
			new SkillLearnConfigData(1, 3, 2, 2, 0, "", "", false, ""),

			new SkillLearnConfigData(2, 4, 4, 1, 0, "", "", false, ""),

			new SkillLearnConfigData(3, 5, 8, 4, 0, "", "", false, ""),

			new SkillLearnConfigData(4, 6, 10, 8, 0, "", "", false, ""),

			new SkillLearnConfigData(5, 143, 20, 1, 0, "", "", false, ""),

		};

	}
}
