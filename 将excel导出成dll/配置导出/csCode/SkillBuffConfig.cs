
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class SkillBuffConfigData : IConfig 
	{
		
		public string skillId;

		public int buffId;

		public SkillBuffConfigData(int id1, string skillId1, int buffId1) 
		{
			
			id=id1;

			skillId=skillId1;

			buffId=buffId1;

		}
		
		public override string ToString()
		{
			return "     主键ID- "+id+"     技能组合- "+skillId+"     技能等级- "+buffId;
		}

	}

	public partial class GameData 
	{
		
		public static List<SkillBuffConfigData> SkillBuffConfig = new List<SkillBuffConfigData>() 
		{
			
			new SkillBuffConfigData(1, "[[3,3]]", 147),

		};

	}
}
