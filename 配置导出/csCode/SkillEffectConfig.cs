
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class SkillEffectConfigData : IConfig 
	{
		
		public int skillId;

		public int skillLevel;

		public string name;

		public int damageRatio;

		public int mp;

		public SkillEffectConfigData(int id1, int skillId1, int skillLevel1, string name1, int damageRatio1, int mp1) 
		{
			
			id=id1;

			skillId=skillId1;

			skillLevel=skillLevel1;

			name=name1;

			damageRatio=damageRatio1;

			mp=mp1;

		}
	}

	public partial class GameData 
	{
		
		public static List<SkillEffectConfigData> SkillEffectConfig = new List<SkillEffectConfigData>() 
		{
			
			new SkillEffectConfigData(3001, 3, 1, "冲击技能", 120, 20),

			new SkillEffectConfigData(3002, 3, 2, "冲击技能", 130, 30),

			new SkillEffectConfigData(3003, 3, 3, "冲击技能", 140, 40),

			new SkillEffectConfigData(3004, 3, 4, "冲击技能", 150, 50),

			new SkillEffectConfigData(3005, 3, 5, "冲击技能", 160, 60),

			new SkillEffectConfigData(3006, 3, 6, "冲击技能", 170, 70),

			new SkillEffectConfigData(3007, 3, 7, "冲击技能", 180, 80),

			new SkillEffectConfigData(3008, 3, 8, "冲击技能", 190, 90),

			new SkillEffectConfigData(3009, 3, 9, "冲击技能", 200, 100),

			new SkillEffectConfigData(3010, 3, 10, "冲击技能", 210, 110),

			new SkillEffectConfigData(4001, 4, 1, "重劈", 75, 50),

			new SkillEffectConfigData(4002, 4, 2, "重劈", 80, 60),

			new SkillEffectConfigData(4003, 4, 3, "重劈", 85, 70),

			new SkillEffectConfigData(4004, 4, 4, "重劈", 90, 80),

			new SkillEffectConfigData(4005, 4, 5, "重劈", 95, 90),

			new SkillEffectConfigData(4006, 4, 6, "重劈", 100, 100),

			new SkillEffectConfigData(4007, 4, 7, "重劈", 105, 110),

			new SkillEffectConfigData(4008, 4, 8, "重劈", 110, 120),

			new SkillEffectConfigData(4009, 4, 9, "重劈", 115, 130),

			new SkillEffectConfigData(4010, 4, 10, "重劈", 120, 140),

			new SkillEffectConfigData(5001, 5, 1, "回旋", 100, 30),

			new SkillEffectConfigData(5002, 5, 2, "回旋", 120, 40),

			new SkillEffectConfigData(5003, 5, 3, "回旋", 140, 50),

			new SkillEffectConfigData(5004, 5, 4, "回旋", 160, 60),

			new SkillEffectConfigData(5005, 5, 5, "回旋", 180, 70),

			new SkillEffectConfigData(5006, 5, 6, "回旋", 200, 80),

			new SkillEffectConfigData(5007, 5, 7, "回旋", 220, 90),

			new SkillEffectConfigData(5008, 5, 8, "回旋", 240, 100),

			new SkillEffectConfigData(5009, 5, 9, "回旋", 260, 110),

			new SkillEffectConfigData(5010, 5, 10, "回旋", 280, 120),

			new SkillEffectConfigData(6001, 6, 1, "直线地震", 150, 30),

			new SkillEffectConfigData(6002, 6, 2, "直线地震", 175, 40),

			new SkillEffectConfigData(6003, 6, 3, "直线地震", 200, 50),

			new SkillEffectConfigData(6004, 6, 4, "直线地震", 225, 60),

			new SkillEffectConfigData(6005, 6, 5, "直线地震", 250, 70),

			new SkillEffectConfigData(6006, 6, 6, "直线地震", 275, 80),

			new SkillEffectConfigData(6007, 6, 7, "直线地震", 300, 90),

			new SkillEffectConfigData(6008, 6, 8, "直线地震", 325, 100),

			new SkillEffectConfigData(6009, 6, 9, "直线地震", 350, 110),

			new SkillEffectConfigData(6010, 6, 10, "直线地震", 375, 120),

			new SkillEffectConfigData(116001, 116, 1, "忍者自爆术", 300, 0),

			new SkillEffectConfigData(13701, 137, 1, "星球爆炸", 300, 0),

			new SkillEffectConfigData(14301, 143, 1, "炼狱", 150, 250),

			new SkillEffectConfigData(14801, 148, 1, "电系武器伤害", 0, 0),

		};

	}
}
