
using System.Collections;
using System.Collections.Generic;
namespace PSPUtil 
{
	
	public class EquipConfigData : IConfig 
	{
		
		public string name;

		public int sheet;

		public string icon;

		public string modelId;

		public string dropIcon;

		public int job;

		public bool hasScabbard;

		public bool isFashion;

		public int equipLevel;

		public int equipPosition;

		public int goldCost;

		public int attack;

		public int defense;

		public string description;

		public string randAttack;

		public string randDefense;

		public EquipConfigData(int id1, string name1, int sheet1, string icon1, string modelId1, string dropIcon1, int job1, bool hasScabbard1, int useLevel1, bool isFashion1, int equipLevel1, int equipPosition1, int goldCost1, int attack1, int defense1, string description1, string randAttack1, string randDefense1) 
		{
			
			id=id1;

			name=name1;

			sheet=sheet1;

			icon=icon1;

			modelId=modelId1;

			dropIcon=dropIcon1;

			job=job1;

			hasScabbard=hasScabbard1;

			useLevel=useLevel1;

			isFashion=isFashion1;

			equipLevel=equipLevel1;

			equipPosition=equipPosition1;

			goldCost=goldCost1;

			attack=attack1;

			defense=defense1;

			description=description1;

			randAttack=randAttack1;

			randDefense=randDefense1;

		}
	}

	public partial class GameData 
	{
		
		public static List<EquipConfigData> EquipConfig = new List<EquipConfigData>() 
		{
			
			new EquipConfigData(13, "刺客忍者铠甲", 1, "yifulevel1", "wardrobe/Assassin_Samurai", "models/armor/leatherpile", 4, false, 1, true, 1, 7, 100, 0, 4, "初级忍者铠甲", "", ""),

			new EquipConfigData(14, "刺客忍者手套", 1, "shoutaolevel1", "wardrobe/Assassin_Samurai", "models/armor/leatherpile", 4, false, 1, true, 1, 4, 100, 0, 2, "初级忍者手套", "", ""),

			new EquipConfigData(15, "刺客忍者头盔", 1, "maozilevel1", "wardrobe/Assassin_Samurai", "models/armor/leatherpile", 4, false, 1, true, 1, 1, 100, 0, 2, "初级忍者头盔", "", ""),

			new EquipConfigData(16, "刺客忍者鞋子", 1, "xiezilevel1", "wardrobe/Assassin_Samurai", "models/armor/leatherpile", 4, false, 1, true, 1, 3, 100, 0, 2, "忍者鞋子", "", ""),

			new EquipConfigData(23, "忍者刀", 1, "WuQi_bishou1", "models/weapons/Assassin_Samurai_weapon", "models/armor/leatherpile", 13, true, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(17, "刺客忍者裤子", 1, "kuzilevel1", "wardrobe/Assassin_Samurai", "models/armor/leatherpile", 4, false, 1, true, 1, 2, 100, 0, 2, "忍者的裤子", "", ""),

			new EquipConfigData(18, "刺客巨人铠甲", 1, "yifulevel2", "wardrobe/Assassin_Giant", "models/armor/leatherpile", 4, false, 1, false, 1, 7, 100, 0, 16, "巨人铠甲", "", ""),

			new EquipConfigData(19, "刺客巨人手套", 1, "shoutaolevel2", "wardrobe/Assassin_Giant", "models/armor/leatherpile", 4, false, 1, false, 1, 4, 100, 0, 6, "巨人手套", "", ""),

			new EquipConfigData(20, "刺客巨人头盔", 1, "maozilevel2", "wardrobe/Assassin_Giant", "models/armor/leatherpile", 4, false, 1, false, 1, 1, 100, 0, 8, "巨人头盔", "", ""),

			new EquipConfigData(21, "刺客巨人鞋子", 1, "xiezilevel2", "wardrobe/Assassin_Giant", "models/armor/leatherpile", 4, false, 1, false, 1, 3, 100, 0, 6, "巨人鞋子", "", ""),

			new EquipConfigData(22, "刺客巨人裤子", 1, "kuzilevel2", "wardrobe/Assassin_Giant", "models/armor/leatherpile", 4, false, 1, false, 1, 2, 100, 0, 8, "巨人裤子", "", ""),

			new EquipConfigData(24, "古结云大剑", 1, "WuQi_jujian1", "models/weapons/axe03", "models/weapons/axe03", 13, false, 1, false, 1, 8, 100, 20, 0, "用铁和木材制成的大剑。上面使用过的痕迹很明显。", "", ""),

			new EquipConfigData(25, "结云大剑", 1, "WuQi_jujian2", "models/weapons/axe03_02", "models/weapons/axe03", 13, false, 1, false, 1, 8, 100, 40, 0, "附近的猎人很常用的大剑。有着稳定的性能。", "", ""),

			new EquipConfigData(26, "烂枪", 1, "WuQi_daqiang1", "models/weapons/Armourer_rugby_gun01", "models/weapons/axe03", 13, false, 1, false, 1, 8, 100, 15, 0, "破烂枪", "", ""),

			new EquipConfigData(27, "烂枪", 1, "WuQi_daqiang1", "models/weapons/Armourer_rugby_gun01", "models/weapons/axe03", 13, false, 1, false, 1, 8, 100, 15, 0, "破烂枪", "", ""),

			new EquipConfigData(28, "枪械师蝙蝠铠甲", 1, "yifulevel1", "wardrobe/Armourer_bat", "models/armor/leatherpile", 2, false, 1, false, 1, 7, 100, 0, 16, "巨人铠甲", "", ""),

			new EquipConfigData(29, "枪械师蝙蝠手套", 1, "shoutaolevel1", "wardrobe/Armourer_bat", "models/armor/leatherpile", 2, false, 1, false, 1, 4, 100, 0, 6, "巨人手套", "", ""),

			new EquipConfigData(30, "枪械师蝙蝠头盔", 1, "maozilevel1", "wardrobe/Armourer_bat", "models/armor/leatherpile", 2, false, 1, false, 1, 1, 100, 0, 8, "巨人头盔", "", ""),

			new EquipConfigData(31, "枪械师蝙蝠鞋子", 1, "xiezilevel1", "wardrobe/Armourer_bat", "models/armor/leatherpile", 2, false, 1, false, 1, 3, 100, 0, 6, "巨人鞋子", "", ""),

			new EquipConfigData(32, "枪械师蝙蝠裤子", 1, "kuzilevel1", "wardrobe/Armourer_bat", "models/armor/leatherpile", 2, false, 1, false, 1, 2, 100, 0, 8, "巨人裤子", "", ""),

			new EquipConfigData(33, "枪械师部落铠甲", 1, "yifulevel2", "wardrobe/Armourer_buluo", "models/armor/leatherpile", 2, false, 1, false, 1, 7, 100, 0, 16, "巨人铠甲", "", ""),

			new EquipConfigData(34, "枪械师部落手套", 1, "shoutaolevel2", "wardrobe/Armourer_buluo", "models/armor/leatherpile", 2, false, 1, false, 1, 4, 100, 0, 6, "巨人手套", "", ""),

			new EquipConfigData(35, "枪械师部落头盔", 1, "maozilevel2", "wardrobe/Armourer_buluo", "models/armor/leatherpile", 2, false, 1, false, 1, 1, 100, 0, 8, "巨人头盔", "", ""),

			new EquipConfigData(36, "枪械师部落鞋子", 1, "xiezilevel2", "wardrobe/Armourer_buluo", "models/armor/leatherpile", 2, false, 1, false, 1, 3, 100, 0, 6, "巨人鞋子", "", ""),

			new EquipConfigData(37, "枪械师部落裤子", 1, "kuzilevel2", "wardrobe/Armourer_buluo", "models/armor/leatherpile", 2, false, 1, false, 1, 2, 100, 0, 8, "巨人裤子", "", ""),

			new EquipConfigData(38, "枪械师橄榄球铠甲", 1, "yifulevel3", "wardrobe/Armourer_rugby", "models/armor/leatherpile", 2, false, 1, false, 1, 7, 100, 0, 16, "巨人铠甲", "", ""),

			new EquipConfigData(39, "枪械师橄榄球手套", 1, "shoutaolevel3", "wardrobe/Armourer_rugby", "models/armor/leatherpile", 2, false, 1, false, 1, 4, 100, 0, 6, "巨人手套", "", ""),

			new EquipConfigData(40, "枪械师橄榄球头盔", 1, "maozilevel3", "wardrobe/Armourer_rugby", "models/armor/leatherpile", 2, false, 1, false, 1, 1, 100, 0, 8, "巨人头盔", "", ""),

			new EquipConfigData(41, "枪械师橄榄球鞋子", 1, "xiezilevel3", "wardrobe/Armourer_rugby", "models/armor/leatherpile", 2, false, 1, false, 1, 3, 100, 0, 6, "巨人鞋子", "", ""),

			new EquipConfigData(42, "枪械师橄榄球裤子", 1, "kuzilevel3", "wardrobe/Armourer_rugby", "models/armor/leatherpile", 2, false, 1, false, 1, 2, 100, 0, 8, "巨人裤子", "", ""),

			new EquipConfigData(43, "枪械师武士铠甲", 1, "yifulevel4", "wardrobe/Armourer_samurai", "models/armor/leatherpile", 2, false, 1, false, 1, 7, 100, 0, 16, "巨人铠甲", "", ""),

			new EquipConfigData(44, "枪械师武士手套", 1, "shoutaolevel4", "wardrobe/Armourer_samurai", "models/armor/leatherpile", 2, false, 1, false, 1, 4, 100, 0, 6, "巨人手套", "", ""),

			new EquipConfigData(45, "枪械师武士头盔", 1, "maozilevel4", "wardrobe/Armourer_samurai", "models/armor/leatherpile", 2, false, 1, false, 1, 1, 100, 0, 8, "巨人头盔", "", ""),

			new EquipConfigData(46, "枪械师武士鞋子", 1, "xiezilevel4", "wardrobe/Armourer_samurai", "models/armor/leatherpile", 2, false, 1, false, 1, 3, 100, 0, 6, "巨人鞋子", "", ""),

			new EquipConfigData(47, "枪械师武士裤子", 1, "kuzilevel4", "wardrobe/Armourer_samurai", "models/armor/leatherpile", 2, false, 1, false, 1, 2, 100, 0, 8, "巨人裤子", "", ""),

			new EquipConfigData(48, "枪械师纸片铠甲", 1, "yifulevel5", "wardrobe/Armourer_zhipian", "models/armor/leatherpile", 2, false, 1, false, 1, 7, 100, 0, 16, "巨人铠甲", "", ""),

			new EquipConfigData(49, "枪械师纸片手套", 1, "shoutaolevel5", "wardrobe/Armourer_zhipian", "models/armor/leatherpile", 2, false, 1, false, 1, 4, 100, 0, 6, "巨人手套", "", ""),

			new EquipConfigData(50, "枪械师纸片头盔", 1, "maozilevel5", "wardrobe/Armourer_zhipian", "models/armor/leatherpile", 2, false, 1, false, 1, 1, 100, 0, 8, "巨人头盔", "", ""),

			new EquipConfigData(51, "枪械师纸片鞋子", 1, "xiezilevel5", "wardrobe/Armourer_zhipian", "models/armor/leatherpile", 2, false, 1, false, 1, 3, 100, 0, 6, "巨人鞋子", "", ""),

			new EquipConfigData(52, "枪械师纸片裤子", 1, "kuzilevel5", "wardrobe/Armourer_zhipian", "models/armor/leatherpile", 2, false, 1, false, 1, 2, 100, 0, 8, "巨人裤子", "", ""),

			new EquipConfigData(53, "刺客部落铠甲", 1, "yifulevel2", "wardrobe/Assassin_buluo", "models/armor/leatherpile", 4, false, 1, false, 1, 7, 100, 0, 16, "巨人铠甲", "", ""),

			new EquipConfigData(54, "刺客部落手套", 1, "shoutaolevel2", "wardrobe/Assassin_buluo", "models/armor/leatherpile", 4, false, 1, false, 1, 4, 100, 0, 6, "巨人手套", "", ""),

			new EquipConfigData(55, "刺客部落头盔", 1, "maozilevel2", "wardrobe/Assassin_buluo", "models/armor/leatherpile", 4, false, 1, false, 1, 1, 100, 0, 8, "巨人头盔", "", ""),

			new EquipConfigData(56, "刺客部落鞋子", 1, "xiezilevel2", "wardrobe/Assassin_buluo", "models/armor/leatherpile", 4, false, 1, false, 1, 3, 100, 0, 6, "巨人鞋子", "", ""),

			new EquipConfigData(57, "刺客部落裤子", 1, "kuzilevel2", "wardrobe/Assassin_buluo", "models/armor/leatherpile", 4, false, 1, false, 1, 2, 100, 0, 8, "巨人裤子", "", ""),

			new EquipConfigData(58, "刺客卡牌铠甲", 1, "yifulevel3", "wardrobe/Assassin_kapai", "models/armor/leatherpile", 4, false, 1, false, 1, 7, 100, 0, 16, "巨人铠甲", "", ""),

			new EquipConfigData(59, "刺客卡牌手套", 1, "shoutaolevel3", "wardrobe/Assassin_kapai", "models/armor/leatherpile", 4, false, 1, false, 1, 4, 100, 0, 6, "巨人手套", "", ""),

			new EquipConfigData(60, "刺客卡牌头盔", 1, "maozilevel3", "wardrobe/Assassin_kapai", "models/armor/leatherpile", 4, false, 1, false, 1, 1, 100, 0, 8, "巨人头盔", "", ""),

			new EquipConfigData(61, "刺客卡牌鞋子", 1, "xiezilevel3", "wardrobe/Assassin_kapai", "models/armor/leatherpile", 4, false, 1, false, 1, 3, 100, 0, 6, "巨人鞋子", "", ""),

			new EquipConfigData(62, "刺客卡牌裤子", 1, "kuzilevel3", "wardrobe/Assassin_kapai", "models/armor/leatherpile", 4, false, 1, false, 1, 2, 100, 0, 8, "巨人裤子", "", ""),

			new EquipConfigData(63, "刺客樱花铠甲", 1, "yifulevel4", "wardrobe/Assassin_sakura", "models/armor/leatherpile", 4, false, 1, false, 1, 7, 100, 0, 16, "巨人铠甲", "", ""),

			new EquipConfigData(64, "刺客樱花手套", 1, "shoutaolevel4", "wardrobe/Assassin_sakura", "models/armor/leatherpile", 4, false, 1, false, 1, 4, 100, 0, 6, "巨人手套", "", ""),

			new EquipConfigData(65, "刺客樱花头盔", 1, "maozilevel4", "wardrobe/Assassin_sakura", "models/armor/leatherpile", 4, false, 1, false, 1, 1, 100, 0, 8, "巨人头盔", "", ""),

			new EquipConfigData(66, "刺客樱花鞋子", 1, "xiezilevel4", "wardrobe/Assassin_sakura", "models/armor/leatherpile", 4, false, 1, false, 1, 3, 100, 0, 6, "巨人鞋子", "", ""),

			new EquipConfigData(67, "刺客樱花裤子", 1, "kuzilevel4", "wardrobe/Assassin_sakura", "models/armor/leatherpile", 4, false, 1, false, 1, 2, 100, 0, 8, "巨人裤子", "", ""),

			new EquipConfigData(68, "斩神甲", 1, "yifulevel1", "wardrobe/Warrior_buluo", "models/armor/leatherpile", 1, false, 1, false, 1, 7, 100, 0, 0, "用魔神的骨肉打造的铠甲,但似乎有魔咒封印", "", ""),

			new EquipConfigData(69, "斩神手套", 1, "shoutaolevel1", "wardrobe/Warrior_buluo", "models/armor/leatherpile", 1, false, 1, false, 1, 4, 100, 0, 0, "魔神的双手炼制的手套", "", ""),

			new EquipConfigData(70, "斩神头盔", 1, "maozilevel1", "wardrobe/Warrior_buluo", "models/armor/leatherpile", 1, false, 1, false, 1, 1, 100, 0, 0, "魔神巨大头骨打造", "", ""),

			new EquipConfigData(71, "斩神靴", 1, "xiezilevel1", "wardrobe/Warrior_buluo", "models/armor/leatherpile", 1, false, 1, false, 1, 3, 100, 0, 0, "魔神的双足炼制", "", ""),

			new EquipConfigData(72, "斩神绑腿", 1, "kuzilevel1", "wardrobe/Warrior_buluo", "models/armor/leatherpile", 1, false, 1, false, 1, 2, 100, 0, 0, "魔神的腿骨打造", "", ""),

			new EquipConfigData(73, "瀛洲甲", 1, "yifulevel2", "wardrobe/Warrior_samurai", "models/armor/leatherpile", 1, false, 1, false, 1, 7, 100, 0, 1, "瀛洲天工所锻造的护甲", "", "[0, 4]"),

			new EquipConfigData(74, "瀛洲手套", 1, "shoutaolevel2", "wardrobe/Warrior_samurai", "models/armor/leatherpile", 1, false, 1, false, 1, 4, 100, 0, 1, "瀛洲天工所锻造的手甲", "", "[0, 4]"),

			new EquipConfigData(75, "瀛洲盔", 1, "maozilevel2", "wardrobe/Warrior_samurai", "models/armor/leatherpile", 1, false, 1, false, 1, 1, 100, 0, 1, "瀛洲天工淬炼的头盔", "", "[0, 4]"),

			new EquipConfigData(76, "瀛洲靴", 1, "xiezilevel2", "wardrobe/Warrior_samurai", "models/armor/leatherpile", 1, false, 1, false, 1, 3, 100, 0, 1, "瀛洲天工制作的靴子", "", "[0, 4]"),

			new EquipConfigData(77, "瀛洲下身甲", 1, "kuzilevel2", "wardrobe/Warrior_samurai", "models/armor/leatherpile", 1, false, 1, false, 1, 2, 100, 0, 1, "瀛洲天工制作的腿甲", "", "[0, 4]"),

			new EquipConfigData(78, "战士犀牛铠甲", 1, "yifulevel3", "wardrobe/Warrior_blackrhinoceros", "models/armor/leatherpile", 1, false, 1, false, 1, 7, 100, 0, 0, "巨人铠甲", "", ""),

			new EquipConfigData(79, "战士犀牛手套", 1, "shoutaolevel3", "wardrobe/Warrior_blackrhinoceros", "models/armor/leatherpile", 1, false, 1, false, 1, 4, 100, 0, 0, "巨人手套", "", ""),

			new EquipConfigData(80, "战士犀牛头盔", 1, "maozilevel3", "wardrobe/Warrior_blackrhinoceros", "models/armor/leatherpile", 1, false, 1, false, 1, 1, 100, 0, 0, "巨人头盔", "", ""),

			new EquipConfigData(81, "战士犀牛鞋子", 1, "xiezilevel3", "wardrobe/Warrior_blackrhinoceros", "models/armor/leatherpile", 1, false, 1, false, 1, 3, 100, 0, 0, "巨人鞋子", "", ""),

			new EquipConfigData(82, "战士犀牛裤子", 1, "kuzilevel3", "wardrobe/Warrior_blackrhinoceros", "models/armor/leatherpile", 1, false, 1, false, 1, 2, 100, 0, 0, "巨人裤子", "", ""),

			new EquipConfigData(83, "刺客巨人刀", 1, "WuQi_bishou2", "models/weapons/Assassin_Giant_weapon", "models/armor/leatherpile", 13, true, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(84, "枪械师机枪", 1, "WuQi_daqiang2", "models/weapons/Armourer_rugby_weapon", "models/armor/leatherpile", 2, false, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(85, "战士武士刀", 1, "WuQi_jujian2", "models/weapons/Warrior_samurai_weapon", "models/armor/leatherpile", 13, true, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(86, "蝙蝠枪", 1, "WuQi_daqiang1", "models/weapons/Armourer_bat_weapon", "models/armor/leatherpile", 2, false, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(87, "部落枪", 1, "WuQi_daqiang2", "models/weapons/Armourer_buluo_weapon", "models/armor/leatherpile", 2, false, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(88, "刺客枪", 1, "WuQi_daqiang3", "models/weapons/Armourer_samurai_weapon", "models/armor/leatherpile", 2, false, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(89, "纸片枪", 1, "WuQi_daqiang4", "models/weapons/Armourer_zhipianzhanshi_weapon", "models/armor/leatherpile", 2, false, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(90, "刺客便装刀", 1, "WuQi_bishou1", "models/weapons/Assassin_bianzhuang_weapon", "models/armor/leatherpile", 4, false, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(91, "刺客部落刀", 1, "WuQi_bishou2", "models/weapons/Assassin_buluo_weapon", "models/armor/leatherpile", 4, true, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(92, "刺客巨人刀", 1, "WuQi_bishou3", "models/weapons/Assassin_Giant_weapon", "models/armor/leatherpile", 4, true, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(93, "刺客卡牌刀", 1, "WuQi_bishou4", "models/weapons/Assassin_kapai_weapon", "models/armor/leatherpile", 4, true, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(94, "刺客毛毛刀", 1, "WuQi_bishou5", "models/weapons/Assassin_maomao_weapon", "models/armor/leatherpile", 4, true, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(95, "刺客忍者刀", 1, "WuQi_bishou6", "models/weapons/Assassin_sakura_weapon", "models/armor/leatherpile", 4, true, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(96, "刺客大忍者刀", 1, "WuQi_bishou6", "models/weapons/Assassin_Samurai_weapon", "models/armor/leatherpile", 4, true, 1, false, 1, 8, 100, 21, 0, "刺客初级刀", "", ""),

			new EquipConfigData(97, "斩神刀", 1, "WuQi_jujian1", "models/weapons/Warrior_bianzhuang_weapon", "models/armor/leatherpile", 1, false, 1, false, 1, 8, 100, 1, 0, "传说曾经杀死过一只上古神灵的刀,但强大力量已被封印", "", ""),

			new EquipConfigData(98, "战士黑犀牛刀", 1, "WuQi_jujian2", "models/weapons/Warrior_blackrhinoceros_weapon", "models/armor/leatherpile", 1, true, 1, false, 1, 8, 100, 0, 0, "刺客初级刀", "", ""),

			new EquipConfigData(99, "战士部落刀", 1, "WuQi_jujian3", "models/weapons/Warrior_buluo_weapon", "models/armor/leatherpile", 1, false, 1, false, 1, 8, 100, 0, 0, "远古部落打造的神兵", "", ""),

			new EquipConfigData(100, "战士机械刀", 1, "WuQi_jujian4", "models/weapons/Warrior_jixiekaijia_weapon", "models/armor/leatherpile", 1, false, 1, false, 1, 8, 100, 0, 0, "刺客初级刀", "", ""),

			new EquipConfigData(101, "瀛洲刀", 1, "WuQi_jujian5", "models/weapons/Warrior_samurai_weapon", "models/armor/leatherpile", 1, true, 1, false, 1, 8, 100, 1, 0, "海外瀛洲所出产的兵器", "[0, 20]", ""),

			new EquipConfigData(102, "战士便装铠甲", 1, "yifulevel4", "wardrobe/Warrior_bianzhuang", "models/armor/leatherpile", 1, false, 1, false, 1, 7, 100, 0, 0, "巨人铠甲", "", ""),

			new EquipConfigData(103, "战士便装手套", 1, "shoutaolevel4", "wardrobe/Warrior_bianzhuang", "models/armor/leatherpile", 1, false, 1, false, 1, 4, 100, 0, 0, "巨人手套", "", ""),

			new EquipConfigData(104, "战士便装头盔", 1, "maozilevel4", "wardrobe/Warrior_bianzhuang", "models/armor/leatherpile", 1, false, 1, false, 1, 1, 100, 0, 0, "巨人头盔", "", ""),

			new EquipConfigData(105, "战士便装鞋子", 1, "xiezilevel4", "wardrobe/Warrior_bianzhuang", "models/armor/leatherpile", 1, false, 1, false, 1, 3, 100, 0, 0, "巨人鞋子", "", ""),

			new EquipConfigData(106, "战士便装裤子", 1, "kuzilevel4", "wardrobe/Warrior_bianzhuang", "models/armor/leatherpile", 1, false, 1, false, 1, 2, 100, 0, 0, "巨人裤子", "", ""),

			new EquipConfigData(107, "战士机械铠甲", 1, "yifulevel5", "wardrobe/Warrior_jixiekaijia", "models/armor/leatherpile", 1, false, 1, false, 1, 7, 100, 0, 0, "巨人铠甲", "", ""),

			new EquipConfigData(108, "战士机械手套", 1, "shoutaolevel5", "wardrobe/Warrior_jixiekaijia", "models/armor/leatherpile", 1, false, 1, false, 1, 4, 100, 0, 0, "巨人手套", "", ""),

			new EquipConfigData(109, "战士机械头盔", 1, "maozilevel5", "wardrobe/Warrior_jixiekaijia", "models/armor/leatherpile", 1, false, 1, false, 1, 1, 100, 0, 0, "巨人头盔", "", ""),

			new EquipConfigData(110, "战士机械鞋子", 1, "xiezilevel5", "wardrobe/Warrior_jixiekaijia", "models/armor/leatherpile", 1, false, 1, false, 1, 3, 100, 0, 0, "巨人鞋子", "", ""),

			new EquipConfigData(111, "战士机械裤子", 1, "kuzilevel5", "wardrobe/Warrior_jixiekaijia", "models/armor/leatherpile", 1, false, 1, false, 1, 2, 100, 0, 0, "巨人裤子", "", ""),

		};

	}
}
