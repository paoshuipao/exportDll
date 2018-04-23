
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class SkillConfigData : IConfig 
	{
		
		public string name;

		public int job;

		public int sheet;

		public string icon;

		public string template;

		public string animationName;

		public int animationTime;

		public string introduce;

		public string effectSound;

		public string hitSound;

		public SkillConfigData(int id1, string name1, int job1, int sheet1, string icon1, string template1, string animationName1, int animationTime1, string introduce1, string effectSound1, string hitSound1) 
		{
			
			id=id1;

			name=name1;

			job=job1;

			sheet=sheet1;

			icon=icon1;

			template=template1;

			animationName=animationName1;

			animationTime=animationTime1;

			introduce=introduce1;

			effectSound=effectSound1;

			hitSound=hitSound1;

		}
	}

	public partial class GameData 
	{
		
		public static List<SkillConfigData> SkillConfig = new List<SkillConfigData>() 
		{
			
			new SkillConfigData(1, "普通近战攻击", -1, 0, "", "singleAttack", "attack", 800, "普通近战攻击", "", ""),

			new SkillConfigData(2, "普通远程攻击", -1, 0, "", "bowAndArrow", "attack", 1000, "普通远程攻击", "", ""),

			new SkillConfigData(28, "战士普通攻击", -1, 0, "", "singleAttack", "", 1000, "", "", ""),

			new SkillConfigData(7, "枪械师普通攻击", -1, 14, "", "bowAndArrow", "rslash_1", 1000, "", "", ""),

			new SkillConfigData(29, "炼金术师普通攻击", -1, 0, "", "singleAttack", "", 1000, "", "", ""),

			new SkillConfigData(30, "潜杀者普通攻击", -1, 0, "", "singleAttack", "", 1000, "", "", ""),

			new SkillConfigData(3, "冲击技能", 1, 14, "skill_bighit", "bombSkill", "rslash_1", 1000, "发动全力猛烈向前一冲", "dash", "criticalhit1"),

			new SkillConfigData(4, "重劈", 1, 14, "skill_dualwield", "JumpSkill", "run2", 4000, "跳起之后，向下雷霆一击", "shockhit", "criticalhit2"),

			new SkillConfigData(5, "回旋", 1, 14, "skill_chainvortex", "chains", "special_xuanlongsha", 3000, "快速旋转，带动空气杀人", "chainswing", "criticalhit3"),

			new SkillConfigData(6, "直线地震", 1, 14, "skill_seismicburst", "burst", "special_liedijue", 1000, "在自己前方召唤出地泉，攻击敌人", "slashing_swing", "slamshockwave"),

			new SkillConfigData(8, "弹射技能", 2, 14, "skill_ricochet", "ricochet", "rslash_1", 1000, "", "", ""),

			new SkillConfigData(9, "飞镖", 2, 14, "skill_needlearc", "needles", "rslash_1", 1000, "", "", ""),

			new SkillConfigData(10, "爆裂新星", 2, 14, "skill_explosiveshot", "explosive", "special_longpao", 1000, "", "", ""),

			new SkillConfigData(11, "火焰陷阱", 2, 14, "skill_flametrap", "flametrap", "rslash_1", 1000, "", "", ""),

			new SkillConfigData(12, "火焰陷阱火", -1, 0, "", "flame", "attack", 1000, "", "", ""),

			new SkillConfigData(13, "陷阱生成技能", -1, 0, "", "flametrapspawn", "", 1000, "", "", ""),

			new SkillConfigData(14, "疯狂攻击", 4, 14, "skill_slash", "whirlinggust", "rslash_1", 1000, "", "", ""),

			new SkillConfigData(15, "炼狱", 4, 14, "skill_quake", "quake", "rslash_1", 1000, "", "quake1", "slamshockwave"),

			new SkillConfigData(16, "霜盾", 4, 14, "skill_frostshield", "frostshield", "rslash_1", 1000, "", "", ""),

			new SkillConfigData(17, "火焰哨兵", 4, 14, "skill_embersentry", "embersentry", "rslash_1", 1000, "", "", ""),

			new SkillConfigData(18, "哨兵激光", -1, 0, "", "beam", "attack", 2000, "", "", ""),

			new SkillConfigData(19, "怪物单体攻击技能", -1, 0, "", "monsterSingle", "attack", 1000, "", "", ""),

			new SkillConfigData(20, "流氓兔连击", -1, 0, "", "liumangtuLianJi", "attack1", 1000, "", "", ""),

			new SkillConfigData(21, "流氓兔跳跃攻击", -1, 0, "", "liumangtuJump", "attack2", 1000, "", "", ""),

			new SkillConfigData(22, "树桩滚动", -1, 0, "", "treeRotate", "attack1", 1000, "", "", ""),

			new SkillConfigData(23, "树桩跳跃", -1, 0, "", "treeJump", "attack2", 1000, "", "", ""),

			new SkillConfigData(24, "野猪震地", -1, 0, "", "pigQuake", "attack1", 1000, "", "", ""),

			new SkillConfigData(25, "野猪冲撞", -1, 0, "", "pigRush", "attack2", 1000, "", "", ""),

			new SkillConfigData(26, "地精远程攻击", -1, 0, "", "bowAndArrow", "attack", 1000, "", "", ""),

			new SkillConfigData(27, "喷弹草攻击", -1, 0, "", "grassArrow", "attack", 1000, "", "", ""),

			new SkillConfigData(100, "火炬之光怪物普通攻击", -1, 0, "", "monsterSingle", "attack1", 1000, "", "", ""),

			new SkillConfigData(101, "喷弹草攻击", -1, 0, "", "grassArrow", "attack", 1000, "", "", ""),

			new SkillConfigData(102, "喷弹草攻击", -1, 0, "", "grassArrow", "attack", 1000, "", "", ""),

			new SkillConfigData(103, "使用药水", -1, 0, "icon_potion_health_small", "useDrug", "rslash_1", 1000, "", "", ""),

			new SkillConfigData(104, "拳击兔攻击技能", -1, 0, "", "monsterSingle", "attack", 800, "", "", ""),

			new SkillConfigData(105, "酷儿冲跳", -1, 0, "", "kuerRushJump", "attack", 1000, "", "", ""),

			new SkillConfigData(106, "魔王炼狱", -1, 14, "skill_quake", "quake", "special_fan", 2000, "", "quake1", "slamshockwave"),

			new SkillConfigData(107, "魔王单体攻击技能", -1, 0, "", "SmallBossSingle", "attack1", 2000, "", "quake3", "criticalhit3"),

			new SkillConfigData(108, "喷弹草腐蚀攻击", -1, 0, "", "grassFushiArrow", "attack", 3000, "", "spiderspit1", "hugeimp1"),

			new SkillConfigData(109, "火焰陷阱火持续伤害", -1, 0, "", "flameHP", "attack", 2000, "", "loopfirelarge1", "fireimp1"),

			new SkillConfigData(110, "地精远程攻击冰冻", -1, 0, "", "bowAndArrowFrozen", "attack", 1000, "", "arrowhailwarmup", "arrowhailimpact"),

			new SkillConfigData(111, "玩家跳跃", -1, 0, "", "jump", "rslash_1", 3000, "", "quake1", "criticalhit1"),

			new SkillConfigData(112, "母巢召唤喷弹草", -1, 0, "", "penDanCaoSummon", "attack", 2000, "", "summon3", ""),

			new SkillConfigData(113, "小喷弹草腐蚀攻击", -1, 0, "", "grassFushiArrow2", "attack", 1000, "小喷弹草腐蚀攻击", "spiderspit1", "hugeimp1"),

			new SkillConfigData(114, "魔王炼狱击退", -1, 14, "skill_quake", "quake2", "special_fan", 1500, "", "quake1", "slamshockwave"),

			new SkillConfigData(115, "魔王单体攻击技能2", -1, 0, "", "mowangSingle", "attack1", 2000, "", "quake3", "criticalhit3"),

			new SkillConfigData(116, "忍者自爆术", -1, 0, "", "electricShock", "attack", 500, "", "emberlightningblast1", "emberbolthit"),

			new SkillConfigData(117, "忍者闪烁术", -1, 0, "", "ShanShuo", "attack", 2000, "", "palaceTeleport", "palaceTeleport"),

			new SkillConfigData(118, "忍者反弹术", -1, 0, "", "FanTan", "attack", 1000, "", "fireattack3", "loopfirelarge1"),

			new SkillConfigData(119, "天皇单体攻击", -1, 0, "", "TianHuangSingle", "attack", 1000, "", "fireattack3", "firegethit1"),

			new SkillConfigData(120, "鬼魂化", -1, 0, "", "Ghost", "attack", 1000, "", "emberlightningblast1", "emberbolthit"),

			new SkillConfigData(121, "巨蚊冲刺", -1, 0, "", "WenZiRush", "attack", 1000, "", "dash", "criticalhit1"),

			new SkillConfigData(122, "幽冥雷", -1, 0, "", "YouMingLight", "attack", 1000, "", "quake3", "slamshockwave"),

			new SkillConfigData(123, "幽冥闪避", -1, 0, "", "YouMingShanBi", "attack", 1000, "", "emberlightningblast1", "slamshockwave"),

			new SkillConfigData(124, "神罚", -1, 0, "", "ShenFa", "attack1", 1000, "", "quake3", "slamshockwave"),

			new SkillConfigData(125, "群狼攻击", -1, 0, "", "TianShenZhenFa", "attack", 1000, "降幅近的天神召集到一起", "palaceTeleport", "slamshockwave"),

			new SkillConfigData(126, "狼王召唤", -1, 0, "", "LangWangZhaoHuan", "attack", 1000, "召唤出一批狼崽", "summon3", "slamshockwave"),

			new SkillConfigData(127, "狼王单体攻击技能", -1, 0, "", "SmallBossSingle", "attack", 1000, "", "shockhit", "criticalhit3"),

			new SkillConfigData(128, "翠花蛇灼烧buff", -1, 0, "", "CuiHuaSheFire", "attack", 1000, "", "fireattack3", "criticalhit3"),

			new SkillConfigData(129, "灼烧Buff造成伤害", -1, 0, "", "CuiHuaFireDamage", "attack", 1000, "", "fireattack3", "criticalhit3"),

			new SkillConfigData(130, "灰鼠复活", -1, 0, "", "HuiShuRelive", "attack", 1000, "", "summon3", "summon3"),

			new SkillConfigData(131, "掠夺金币", -1, 0, "", "GoldStealSingle", "attack", 1000, "", "", "hugeimp1"),

			new SkillConfigData(132, "音波冲击", -1, 0, "", "SoundWave", "attack", 1000, "音波冲击", "arrowhailwarmup", "arrowhailimpact"),

			new SkillConfigData(133, "嗜血", -1, 0, "", "ShiXue", "attack", 1000, "", "shockhit", "shockhit"),

			new SkillConfigData(134, "爆裂", -1, 0, "", "BaoLie", "attack1", 3000, "", "shockhit", "slamshockwave"),

			new SkillConfigData(135, "宝箱召唤boss", -1, 0, "", "ChestSummon", "attack", 1000, "", "summon3", ""),

			new SkillConfigData(136, "布鲁特火焰哨兵", -1, 14, "skill_embersentry", "embersentry", "attack", 1000, "", "", ""),

			new SkillConfigData(137, "星球爆炸", -1, 0, "", "BaoLie2", "attack", 1000, "", "shockhit", "slamshockwave"),

			new SkillConfigData(138, "远程轰击击晕", -1, 0, "", "bowAndArrowStun", "attack", 1000, "", "arrowhailwarmup", "arrowhailimpact"),

			new SkillConfigData(139, "多重子弹轰击", -1, 0, "", "MultiBowAndArrow", "attack", 1500, "", "arrowhailwarmup", "arrowhailimpact"),

			new SkillConfigData(140, "冲击波", -1, 0, "", "BowAndArrowKnockBack", "attack", 1500, "", "arrowhailwarmup", "arrowhailimpact"),

			new SkillConfigData(141, "兔子冲刺", -1, 0, "", "RabbitRush", "attack", 1000, "", "dash", "criticalhit1"),

			new SkillConfigData(142, "盗贼暴击", -1, 0, "", "DaoZeiCritical", "attack", 1000, "", "", "shockhit"),

			new SkillConfigData(143, "炼狱击退", -1, 14, "skill_quake", "quake3", "rslash_1", 1500, "", "quake1", "slamshockwave"),

			new SkillConfigData(144, "哨兵激光-致盲", -1, 0, "", "beam2", "attack", 2000, "", "emberlightningblast1", "emberbolthit"),

			new SkillConfigData(145, "怪物单体攻击技能-沉默", -1, 0, "", "monsterSingle2", "attack", 1000, "", "", ""),

			new SkillConfigData(146, "火焰陷阱火-减速", -1, 0, "", "flame2", "attack", 1000, "", "", ""),

			new SkillConfigData(147, "武器电Buff", -1, 0, "", "weaponEle", "attack", 1000, "", "emberbolthit", "emberbolthit"),

			new SkillConfigData(148, "电系武器减速", -1, 0, "", "electricShock2", "attack", 500, "", "emberlightningblast1", "emberbolthit"),

			new SkillConfigData(149, "投掷普通炸弹", -1, 0, "", "bombSkill", "rslash_1", 1000, "投掷普通炸弹", "fireattack3", "firegethit1"),

		};

	}
}
