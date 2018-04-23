
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
