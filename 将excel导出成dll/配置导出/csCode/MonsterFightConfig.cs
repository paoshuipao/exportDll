
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class MonsterFightConfigData : IConfig 
	{
		
		public string name;

		public int baseSkill;

		public string textureReplace;

		public string model;

		public string spawnParticle;

		public string LogicTemplate;

		public bool attachToMaster;

		public int attackRange;

		public int level;

		public int warnRange;

		public string drop;

		public string skillList;

		public int exp;

		public int moveSpeed;

		public int hp;

		public int attack;

		public int criticalHit;

		public int defense;

		public int dodge;

		public int waterAttack;

		public int fireAttack;

		public int windAttack;

		public int soilAttack;

		public int antiWater;

		public int antiFire;

		public int antiWind;

		public int antiSoil;

		public MonsterFightConfigData(int id1, string name1, int baseSkill1, string textureReplace1, string model1, string spawnParticle1, string LogicTemplate1, bool attachToMaster1, int attackRange1, int level1, int warnRange1, string drop1, string skillList1, int exp1, int moveSpeed1, int hp1, int attack1, int criticalHit1, int defense1, int dodge1, int waterAttack1, int fireAttack1, int windAttack1, int soilAttack1, int antiWater1, int antiFire1, int antiWind1, int antiSoil1) 
		{
			
			id=id1;

			name=name1;

			baseSkill=baseSkill1;

			textureReplace=textureReplace1;

			model=model1;

			spawnParticle=spawnParticle1;

			LogicTemplate=LogicTemplate1;

			attachToMaster=attachToMaster1;

			attackRange=attackRange1;

			level=level1;

			warnRange=warnRange1;

			drop=drop1;

			skillList=skillList1;

			exp=exp1;

			moveSpeed=moveSpeed1;

			hp=hp1;

			attack=attack1;

			criticalHit=criticalHit1;

			defense=defense1;

			dodge=dodge1;

			waterAttack=waterAttack1;

			fireAttack=fireAttack1;

			windAttack=windAttack1;

			soilAttack=soilAttack1;

			antiWater=antiWater1;

			antiFire=antiFire1;

			antiWind=antiWind1;

			antiSoil=antiSoil1;

		}
		
		public override string ToString()
		{
			return "     主键ID- "+id+"     名字- "+name+"     基础技能- "+baseSkill+"     替换默认纹理(用于怪物变体)- "+textureReplace+"     模型- "+model+"     出生时粒子效果- "+spawnParticle+"     逻辑模版- "+LogicTemplate+"     是否附着到主人身上- "+attachToMaster+"     攻击距离- "+attackRange+"     怪物等级- "+level+"     警戒范围- "+warnRange+"     掉落- "+drop+"     技能触发列表- "+skillList+"     经验- "+exp+"     移动速度- "+moveSpeed+"     生命值- "+hp+"     攻击- "+attack+"     暴击率- "+criticalHit+"     防御- "+defense+"     闪避 - "+dodge+"     水攻- "+waterAttack+"     火攻- "+fireAttack+"     风攻- "+windAttack+"     土攻- "+soilAttack+"     抗水- "+antiWater+"     抗火- "+antiFire+"     抗风- "+antiWind+"     抗土- "+antiSoil;
		}

	}

	public partial class GameData 
	{
		
		public static List<MonsterFightConfigData> MonsterFightConfig = new List<MonsterFightConfigData>() 
		{
			
			new MonsterFightConfigData(4, "布鲁特", 19, "", "models/ballute", "", "NpcAI", false, 3, 5, 20, "4_0.2_10|101_0.1", "", 200, 20, 20, 6, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(18, "花野猪", 19, "", "models/BPyezhu", "", "NpcAI", false, 3, 5, 20, "4_0.2_10|101_0.1", "[{\"id\":24, \"level\":1, \"chance\":25}, {\"id\":25, \"level\":1, \"chance\":25}]", 250, 30, 40, 12, 40, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(113, "喷弹草", 27, "", "models/Chpendancao", "", "NpcAI", false, 8, 5, 20, "4_0.2_10|101_0.1", "", 200, 10, 12, 15, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(6, "小树桩精灵", 19, "models/xiaoshuguai_01_a", "models/xiaoshuguai", "", "NpcAI", false, 3, 10, 20, "4_0.2_20|101_0.2", "", 600, 40, 75, 20, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(8, "拳击兔", 104, "models/liumangtu_01_a", "models/liumangtu", "", "NpcAI", false, 3, 10, 20, "4_0.2_25|101_0.2", "", 800, 40, 30, 25, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(103, "地精弓箭手", 26, "", "models/Chdijinggongshou", "", "NpcAI", false, 8, 10, 20, "4_0.2_20|101_0.2", "", 1000, 20, 45, 30, 5, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(10, "硬壳蜗牛", 19, "", "models/yingkewoniu", "", "NpcAI", false, 3, 15, 20, "4_0.2_40|101_0.3", "", 1200, 15, 150, 20, 5, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(119, "绿翼幻彩蛾", 18, "", "models/Bphuancaifeie", "", "NpcAI", false, 8, 15, 20, "4_0.2_40|101_0.3", "", 2000, 50, 60, 38, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(306, "地精盗贼", 19, "", "models/Chdijingdaozei", "", "NpcAI", false, 3, 15, 20, "4_0.2_40|101_0.4", "", 2000, 30, 120, 28, 5, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(11, "叮不理虎斑", 19, "models/dingbuli_01_a", "models/dingbuli", "", "NpcAI", false, 3, 20, 20, "4_0.2_60|101_0.3", "", 2000, 20, 100, 40, 40, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(13, "萌芽", 12, "", "models/jifazhongzi", "", "NpcAI", false, 5, 20, 20, "4_0.2_60|101_0.3", "", 3000, 30, 150, 50, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(15, "酷儿", 105, "", "models/kuer", "", "NpcAI", false, 2, 20, 20, "4_0.2_60|101_0.3", "", 4000, 20, 200, 40, 20, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1004, "布鲁特精英", 19, "models/ballute_01_a", "models/ballute", "", "NpcAI", false, 3, 10, 20, "1000_0.3", "", 800, 20, 80, 12, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1018, "花野猪精英", 19, "models/BPyezhu_01_b", "models/BPyezhu", "", "NpcAI", false, 3, 10, 20, "1001_0.3", "[{\"id\":24, \"level\":1, \"chance\":25}, {\"id\":25, \"level\":1, \"chance\":25}]", 1000, 30, 160, 16, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1113, "喷弹草精英", 27, "models/CHpengdancao_01_b", "models/Chpendancao", "", "NpcAI", false, 8, 10, 20, "1000_0.3", "", 800, 10, 48, 20, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1006, "树桩精英A", 19, "models/xiaoshuguai_01_b", "models/xiaoshuguai", "", "NpcAI", false, 3, 15, 20, "1001_0.3", "", 2400, 40, 160, 20, 5, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(10061, "树桩精英B", 19, "models/xiaoshuguai_01_c", "models/xiaoshuguai", "", "NpcAI", false, 3, 15, 20, "1000_0.3", "", 2800, 40, 160, 20, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(10062, "树桩精英C", 19, "models/xiaoshuguai_01_d", "models/xiaoshuguai", "", "NpcAI", false, 3, 15, 20, "1001_0.3", "", 2800, 40, 200, 20, 5, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1008, "拳击兔精英A", 104, "models/liumangtu_01_b", "models/liumangtu", "", "NpcAI", false, 3, 15, 20, "1000_0.3", "", 3200, 40, 120, 35, 25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(10081, "拳击兔精英B", 104, "models/liumangtu_01_c", "models/liumangtu", "", "NpcAI", false, 3, 15, 20, "1001_0.3", "", 3200, 40, 100, 35, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(10082, "拳击兔精英C", 104, "models/liumangtu_01_d", "models/liumangtu", "", "NpcAI", false, 3, 15, 20, "1000_0.3", "", 3200, 40, 80, 35, 50, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(10083, "拳击兔精英D", 104, "models/liumangtu_01_e", "models/liumangtu", "", "NpcAI", false, 4, 15, 20, "1001_0.3", "", 3500, 50, 180, 30, 20, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1119, "绿翼幻彩蛾精英A", 18, "models/BPhuancaifeie_01_b", "models/Bphuancaifeie", "", "NpcAI", false, 8, 20, 20, "1000_0.3", "", 8000, 50, 250, 48, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(11191, "绿翼幻彩蛾精英B", 18, "models/BPhuancaifeie_01_c", "models/Bphuancaifeie", "", "NpcAI", false, 8, 20, 20, "1001_0.3", "", 8000, 50, 250, 50, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1011, "叮不理虎斑精英", 19, "models/dingbuli_01_b", "models/dingbuli", "", "NpcAI", false, 3, 25, 20, "1000_0.3", "", 7200, 20, 300, 60, 20, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1013, "萌芽精英", 12, "models/jifazhongzi_01_b", "models/jifazhongzi", "", "NpcAI", false, 5, 25, 20, "1001_0.3", "", 8800, 30, 350, 70, 10, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(5, "魔王魂", 107, "", "models/Corrupted_Merc", "", "BossAI", false, 6, 10, 20, "1000_1_20|4_1_500|4_1_500", "[{\"id\":106, \"level\":1, \"chance\":25}]", 2000, 20, 400, 40, 50, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(2113, "喷弹草魔神", 108, "models/CHpengdancao_01_b", "models/Chpendancao", "", "NpcAI", false, 12, 25, 20, "1000_0.5_20|4_0.5_200|4_0.5_200", "", 6000, 10, 800, 80, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(2013, "萌芽魔神", 109, "", "models/jifazhongzi", "", "NpcAI", false, 6, 25, 20, "1001_0.5_20|4_0.5_200|4_0.5_200", "", 6000, 20, 600, 40, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(2103, "地精弓箭手魔神", 110, "", "models/Chdijinggongshou", "", "NpcAI", false, 12, 25, 20, "1001_0.5_10|4_0.5_200|4_0.5_200|1000_0.5_10", "", 6000, 30, 800, 80, 5, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(3113, "喷弹草之母", 112, "models/CHpengdancao_01_b", "models/Chpendancao", "", "SummonAI", false, 30, 30, 40, "1002_0.5_5|1003_0.5_5|1005_0.1_20", "", 10000, 0, 2000, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(2010, "硬壳蜗牛精英", 19, "", "models/yingkewoniu", "", "NpcAI", false, 3, 30, 20, "4_0.3_200|101_0.5_3", "", 10000, 15, 800, 60, 5, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(7, "喷弹草(召唤)", 113, "", "models/Chpendancao", "", "NpcAI", false, 8, 30, 20, "4_0.2_50|101_0.1", "", 1000, 10, 100, 40, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(2009, "魔王魂(强)", 115, "", "models/Corrupted_Merc", "", "BossAI", false, 10, 30, 20, "1002_0.5_10|1003_0.5_10|4_1_3000", "[{\"id\":114, \"level\":1, \"chance\":50}]", 10000, 40, 3000, 80, 50, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(20, "闪烁忍者", 19, "", "models/xiaomoguguai", "", "ShanShuoAI", false, 3, 35, 40, "4_0.2_150|101_0.1|1002_0.1_1|1003_0.1_1", "[{\"id\":117, \"level\":1, \"chance\":100, \"ignore\":true}]", 5000, 30, 400, 70, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(21, "自爆忍者", 19, "", "models/lvsepaopaoguai", "", "NpcAI", false, 3, 35, 20, "4_0.2_150|101_0.1|1002_0.1_1|1003_0.1_1", "[{\"id\":116, \"level\":1, \"chance\":0,\"death\":true}]", 5000, 20, 400, 70, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1022, "天皇", 119, "", "models/huanlingjingguai", "", "NpcAI", false, 5, 35, 20, "4_1_1000|101_1|1002_0.5_1|1003_0.5_1", "[{\"id\":118, \"level\":1, \"chance\":50}]", 10000, 20, 3000, 90, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(23, "幽冥使者", 19, "", "models/Chdijingdaozei", "", "ShanShuoAI", false, 3, 40, 20, "4_0.2_200|101_0.2|1002_0.1_1|1003_0.1_1", "[{\"id\":120, \"level\":1, \"chance\":100, \"ignore\":true}]", 6000, 30, 400, 70, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(24, "幽冥巨蚊", 121, "", "models/Bpjuwen", "", "NpcAI", false, 7, 40, 20, "4_0.2_200|101_0.2|1002_0.1_1|1003_0.1_1", "", 6000, 20, 600, 70, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1025, "幽冥王者", 122, "", "models/Chxiaobianfu", "", "ShanShuoAI", false, 10, 40, 20, "4_1_1000|101_1_2|1002_0.5_1|1003_0.5_1", "[{\"id\":123, \"level\":1, \"chance\":100, \"ignore\":true}]", 12000, 20, 4000, 100, 60, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(26, "狼穴巫师", 124, "", "models/alchemist_construct", "", "NpcAI", false, 8, 45, 20, "4_0.2_250|101_0.2|1002_0.1_1|1003_0.1_1", "", 7000, 20, 500, 150, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(27, "苍狼", 19, "", "models/Chxiaolang", "", "LangAI", false, 3, 45, 20, "4_0.2_250|101_0.2|1002_0.1_1|1003_0.1_1", "[{\"id\":125, \"level\":1, \"chance\":100, \"ignore\":true}]", 7000, 20, 700, 120, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1028, "狼王", 127, "", "models/Chxiaolang", "", "ShanShuoAI", false, 6, 45, 20, "4_1_1000|101_1_2|1002_0.5_1|1003_0.5_1", "[{\"id\":126, \"level\":1, \"chance\":100, \"ignore\":true}]", 15000, 40, 4000, 200, 40, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(29, "翠花蛇", 0, "", "models/cuihuashe", "", "SnakeAI", false, 6, 50, 20, "4_0.2_250|101_0.2|1005_0.1_1|1006_0.1_1", "[{\"id\":128, \"level\":1, \"chance\":100, \"ignore\":true}]", 8000, 20, 800, 150, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(30, "灰鼠", 19, "", "models/fengkuanglishu", "", "RateAI", false, 3, 50, 20, "4_0.2_250|101_0.2|1005_0.1_1|1006_0.1_1", "[{\"id\":130, \"level\":1, \"chance\":0, \"death\":true}]", 8000, 30, 400, 120, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1031, "鼠王", 127, "", "models/fengkuanglishu", "", "RateKingAI", false, 6, 50, 20, "4_0.2_250|101_0.2|1005_0.1_1|1006_0.1_1", "", 12000, 30, 1300, 150, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(32, "螃蟹", 131, "", "models/TgmianhuatangbaobaoBianyi", "", "NpcAI", false, 3, 50, 20, "4_0.2_400|101_0.2|1008_0.2_1", "", 10000, 30, 600, 120, 20, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(33, "音波蝙蝠", 132, "", "models/Chxiaobianfu", "", "NpcAI", false, 6, 55, 20, "4_0.3_400|101_0.2|1009_0.2_1", "", 10000, 20, 700, 140, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(34, "嗜血狼", 19, "", "models/Chxiaolang", "", "ShiXueWolfAI", false, 3, 55, 20, "4_0.3_400|101_0.2|1009_0.2_1", "[{\"id\":133, \"level\":1, \"chance\":100, \"ignore\":true}]", 10000, 20, 700, 120, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(35, "爆裂法师", 134, "", "models/alchemist_construct", "", "NpcAI", false, 8, 55, 20, "4_0.3_400|101_0.2|1009_0.2_1", "", 10000, 20, 700, 250, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(36, "宝箱", 19, "", "models/chest_rare", "", "ChestAI", false, 8, 55, 20, "", "[{\"id\":135, \"level\":1, \"chance\":0,\"death\":true,\"bossId\":2011}]", 10000, 20, 50, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(2011, "宝箱魔王", 115, "", "models/Corrupted_Merc", "", "BossAI", false, 10, 55, 20, "1009_0.5_5|1008_0.5_5|4_1_3000|200_0.1_1|201_0.1_1|202_0.1_1|203_0.1_1|204_0.1_1|205_0.1_1", "[{\"id\":114, \"level\":1, \"chance\":50}]", 20000, 30, 10000, 250, 50, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1035, "爆裂法师精英", 134, "", "models/alchemist_construct", "", "NpcAI", false, 8, 55, 20, "4_0.3_400|101_0.2|1009_0.2_1|300_0.5_1", "", 10000, 20, 3000, 250, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1034, "嗜血狼精英", 19, "", "models/Chxiaolang", "", "ShiXueWolfAI", false, 3, 55, 20, "4_0.3_400|101_0.2|1009_0.2_1|301_0.5_1", "[{\"id\":133, \"level\":1, \"chance\":100, \"ignore\":true}]", 10000, 20, 2800, 120, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(1033, "音波蝙蝠精英", 132, "", "models/Chxiaobianfu", "", "NpcAI", false, 6, 55, 20, "4_0.3_400|101_0.2|1009_0.2_1|302_0.5_1", "", 10000, 20, 2800, 140, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(37, "布鲁特法师", 136, "models/ballute_01_b", "models/ballute", "", "NpcAI", false, 7, 60, 20, "4_0.3_400|101_0.2|1009_0.2_1", "", 10000, 20, 600, 120, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(38, "爆炸星球", 19, "", "models/trapanimation", "particles/playerskills/shocktrap/beam", "PetAI", false, 4, 60, 20, "", "", 0, 20, 99999, 120, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(39, "地精弓箭手法师", 138, "", "models/Chdijinggongshou", "", "NpcAI", false, 8, 60, 20, "4_0.3_400|101_0.2|1009_0.2_1", "", 10000, 20, 600, 200, 20, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(2040, "地精弓箭手王者", 139, "", "models/Chdijinggongshou", "", "NpcAI", false, 8, 60, 20, "4_0.3_1000|1009_0.5_5", "", 20000, 20, 2800, 150, 40, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(41, "小树桩精灵冲击者", 140, "models/xiaoshuguai_01_a", "models/xiaoshuguai", "", "NpcAI", false, 8, 65, 20, "4_0.3_400|101_0.2|1009_0.2_1", "", 10000, 40, 600, 150, 10, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(42, "拳击兔暴击者", 19, "models/liumangtu_01_a", "models/liumangtu", "", "RabbitAI", false, 3, 65, 20, "4_0.3_400|101_0.2|300_0.2_1", "", 10000, 20, 600, 150, 30, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(43, "地精盗贼暴击者", 19, "", "models/Chdijingdaozei", "", "ThiefAI", false, 3, 65, 20, "4_0.3_400|101_0.2|301_0.2_1", "", 10000, 30, 600, 150, 5, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(2044, "炼狱宝箱魔王", 115, "", "models/Corrupted_Merc", "", "BossAI", false, 10, 70, 20, "1009_0.5_5|1008_0.5_5|4_1_3000|200_0.1_1|201_0.1_1|202_0.1_1|203_0.1_1|204_0.1_1|205_0.1_1|401_1_1", "[{\"id\":114, \"level\":1, \"chance\":50}]", 20000, 30, 10000, 250, 50, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(45, "绿翼幻彩蛾-神庙", 144, "", "models/Bphuancaifeie", "", "NpcAI", false, 8, 75, 20, "4_0.2_400|101_0.3|300_0.1_1", "", 20000, 50, 600, 150, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(46, "叮不理虎斑-神庙", 19, "models/dingbuli_01_a", "models/dingbuli", "", "NpcAI", false, 3, 75, 20, "4_0.2_400|101_0.3|301_0.1_1", "[{\"id\":145, \"level\":1, \"chance\":50}]", 20000, 20, 600, 100, 40, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(47, "萌芽-神庙", 146, "", "models/jifazhongzi", "", "NpcAI", false, 5, 75, 20, "4_0.2_400|101_0.3|302_0.1_1", "", 20000, 30, 800, 150, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(2048, "宝箱苍冥狼魔王", 19, "", "models/Chxiaolang", "", "BossAI", false, 5, 20, 20, "6_1_1_1", "", 2000, 30, 350, 20, 50, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0),

			new MonsterFightConfigData(2049, "绿翼幻彩蛾魔神", 18, "", "models/Bphuancaifeie", "", "BossAI", false, 8, 25, 20, "1002_1_1|1003_1_1|1004_1_1", "", 2000, 1000, 400, 40, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),

		};

	}
}
