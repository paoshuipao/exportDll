
using System;
using System.Collections;
using System.Collections.Generic;
namespace ChuMeng {
	public class CharAttribute {
		public enum CharAttributeEnum { 
			FIGHTING_WILL= 1000, //斗志
			PHYSIQUE= 1001, //筋骨
			CONSTITUTION= 1002, //体魄
			GAIL= 1003, //身法
			PRECISE= 1004, //精准
			BLOCK= 1005, //格挡
			BLOCK_MAX= 1006, //格挡值上限
			HP= 2000, //血量
			HP_MAX= 2001, //
			MP= 2002, //法力
			MP_MAX= 2003, //
			EXP= 2004, //当前经验
			EXP_MAX= 2005, //升级到下一级的经验
			LEVEL= 2006, //等级
			SILVER_COIN= 2007, //非绑银
			SILVER_TICKET= 2008, //绑定银票
			GOLD_COIN= 2009, //绑金币
			GOLD_TICKET= 2010, //绑定金票
			REPUTATION= 2011, //声望币
			ICON= 2012, //头像
			NAME= 2013, //名称
			JOB= 2014, //职业
			TITLE= 2015, //称号
			POWER= 2016, //体力
			POWER_MAX= 2017, //最大体力
			ENERGY= 2018, //活力
			ENERGY_MAX= 2019, //最大活力
			GUILD_ID= 2020, //公会ID
			GUILD_NAME= 2021, //公会名称
			X= 2022, //X轴坐标
			Y= 2023, //
			Z= 2024, //
			HELMET= 2025, //头盔
			COAT= 2026, //衣服(怪物,玩家的外观)
			TROUSERS= 2027, //裤子
			BRACER= 2028, //护腕
			SHOES= 2029, //鞋子
			WEAPON= 2030, //武器
			CLOTH= 2031, //服装
			CLOTH_HIDE= 2032, //时装是否隐藏
			BASE_ID= 2033, //基础ID(NPC,传送点,采集物等)
			TEAM_ID= 2034, //组队ID
			VIP_INFO= 2035, //vip信息
			VIP_LEVEL= 2036, //VIP等级
			MOVE_SPEED= 2037, //移动速度
			ATTACK= 2038, //攻击力
			DEFENSE= 2039, //防御力
			CRITICAL= 2040, //会心
			CRITICAL_DEFENSE= 2041, //会心防御
			HIT= 2042, //命中
			DODGE= 2043, //闪避
			ANTI_WATER= 2044, //水抗
			ANTI_FIRE= 2045, //火抗
			ANTI_WIND= 2046, //风抗
			ANTI_SOIL= 2047, //土抗
			WATER_ATK= 2048, //水攻
			FIRE_ATK= 2049, //火攻
			WIND_ATK= 2050, //风攻
			SOIL_ATK= 2051, //土攻
			FIGHT_MODE= 2052, //战斗模式
			HATRED= 2053, //仇恨值 
			PACK_SIZE= 2054, //背包最大格子数
			STORAGE_SIZE= 2055, //仓库的大小
			PLAYER_BASIC_CAPACITY= 2056, //角色基础战斗力加成
			PLAYER_GEM_CAPACITY= 2057, //角色宝石战斗力加成
			PLAYER_HOROSCOPE_CAPACITY= 2058, //角色星座战斗力加成
			PLAYER_EQUIP_CAPACITY= 2059, //角色装备战斗力加成
			PLAYER_PET_CAPACITY= 2060, //角色宠物战斗力加成
			PLAYER_ACHIEVEMENT_CAPACITY= 2061, //角色成就战斗力加成
			PLAYER_GUILD_CAPACITY= 2062, //角色公会战斗力加成
			PLAYER_SKILL_CAPACITY= 2063, //角色技能战斗力加成
			PLAYER_MENTALITY_CAPACITY= 2064, //角色元神战斗力加成
			FIGHT_TOTAL_CAPACITY= 2065, //角色总战斗力
			SERVER_ID= 3000, //服务器ID标识
			CREATE_TIME= 3003, //创建时间
			LOGIN_TIME= 3004, //登陆时间
			LOGOUT_TIME= 3005, //登出时间
			FORBID_LOGIN= 3006, //禁止登陆信息. (格式: 封禁状态_封禁起始时间(单位:秒)_封禁时长(单位:秒) )
			FORBID_CHAT= 3007, //禁止聊天信息. (格式: 封禁状态_封禁起始时间(单位:秒)_封禁时长(单位:秒) )
			LOGIN_COUNT= 3008, //登陆次数
			LOGIN_DAYS= 3009, //连续登陆天数
			TOTAL_LOGIN_DAYS= 3010, //总共登陆的天数
			ONLINE_TIMES= 3011, //共在线时间. 单位:秒
			TOTAL_ONLINE_TIMES= 3012, //总共在线时间. 单位:秒

		}
		
		public static Dictionary<CharAttributeEnum, string> keyToCN = new Dictionary<CharAttributeEnum, string>() {
			{CharAttributeEnum.FIGHTING_WILL, "斗志"},
			{CharAttributeEnum.PHYSIQUE, "筋骨"},
			{CharAttributeEnum.CONSTITUTION, "体魄"},
			{CharAttributeEnum.GAIL, "身法"},
			{CharAttributeEnum.PRECISE, "精准"},
			{CharAttributeEnum.BLOCK, "格挡"},
			{CharAttributeEnum.BLOCK_MAX, "格挡值上限"},
			{CharAttributeEnum.HP, "血量"},
			{CharAttributeEnum.HP_MAX, ""},
			{CharAttributeEnum.MP, "法力"},
			{CharAttributeEnum.MP_MAX, ""},
			{CharAttributeEnum.EXP, "当前经验"},
			{CharAttributeEnum.EXP_MAX, "升级到下一级的经验"},
			{CharAttributeEnum.LEVEL, "等级"},
			{CharAttributeEnum.SILVER_COIN, "非绑银"},
			{CharAttributeEnum.SILVER_TICKET, "绑定银票"},
			{CharAttributeEnum.GOLD_COIN, "绑金币"},
			{CharAttributeEnum.GOLD_TICKET, "绑定金票"},
			{CharAttributeEnum.REPUTATION, "声望币"},
			{CharAttributeEnum.ICON, "头像"},
			{CharAttributeEnum.NAME, "名称"},
			{CharAttributeEnum.JOB, "职业"},
			{CharAttributeEnum.TITLE, "称号"},
			{CharAttributeEnum.POWER, "体力"},
			{CharAttributeEnum.POWER_MAX, "最大体力"},
			{CharAttributeEnum.ENERGY, "活力"},
			{CharAttributeEnum.ENERGY_MAX, "最大活力"},
			{CharAttributeEnum.GUILD_ID, "公会ID"},
			{CharAttributeEnum.GUILD_NAME, "公会名称"},
			{CharAttributeEnum.X, "X轴坐标"},
			{CharAttributeEnum.Y, ""},
			{CharAttributeEnum.Z, ""},
			{CharAttributeEnum.HELMET, "头盔"},
			{CharAttributeEnum.COAT, "衣服(怪物,玩家的外观)"},
			{CharAttributeEnum.TROUSERS, "裤子"},
			{CharAttributeEnum.BRACER, "护腕"},
			{CharAttributeEnum.SHOES, "鞋子"},
			{CharAttributeEnum.WEAPON, "武器"},
			{CharAttributeEnum.CLOTH, "服装"},
			{CharAttributeEnum.CLOTH_HIDE, "时装是否隐藏"},
			{CharAttributeEnum.BASE_ID, "基础ID(NPC,传送点,采集物等)"},
			{CharAttributeEnum.TEAM_ID, "组队ID"},
			{CharAttributeEnum.VIP_INFO, "vip信息"},
			{CharAttributeEnum.VIP_LEVEL, "VIP等级"},
			{CharAttributeEnum.MOVE_SPEED, "移动速度"},
			{CharAttributeEnum.ATTACK, "攻击力"},
			{CharAttributeEnum.DEFENSE, "防御力"},
			{CharAttributeEnum.CRITICAL, "会心"},
			{CharAttributeEnum.CRITICAL_DEFENSE, "会心防御"},
			{CharAttributeEnum.HIT, "命中"},
			{CharAttributeEnum.DODGE, "闪避"},
			{CharAttributeEnum.ANTI_WATER, "水抗"},
			{CharAttributeEnum.ANTI_FIRE, "火抗"},
			{CharAttributeEnum.ANTI_WIND, "风抗"},
			{CharAttributeEnum.ANTI_SOIL, "土抗"},
			{CharAttributeEnum.WATER_ATK, "水攻"},
			{CharAttributeEnum.FIRE_ATK, "火攻"},
			{CharAttributeEnum.WIND_ATK, "风攻"},
			{CharAttributeEnum.SOIL_ATK, "土攻"},
			{CharAttributeEnum.FIGHT_MODE, "战斗模式"},
			{CharAttributeEnum.HATRED, "仇恨值 "},
			{CharAttributeEnum.PACK_SIZE, "背包最大格子数"},
			{CharAttributeEnum.STORAGE_SIZE, "仓库的大小"},
			{CharAttributeEnum.PLAYER_BASIC_CAPACITY, "角色基础战斗力加成"},
			{CharAttributeEnum.PLAYER_GEM_CAPACITY, "角色宝石战斗力加成"},
			{CharAttributeEnum.PLAYER_HOROSCOPE_CAPACITY, "角色星座战斗力加成"},
			{CharAttributeEnum.PLAYER_EQUIP_CAPACITY, "角色装备战斗力加成"},
			{CharAttributeEnum.PLAYER_PET_CAPACITY, "角色宠物战斗力加成"},
			{CharAttributeEnum.PLAYER_ACHIEVEMENT_CAPACITY, "角色成就战斗力加成"},
			{CharAttributeEnum.PLAYER_GUILD_CAPACITY, "角色公会战斗力加成"},
			{CharAttributeEnum.PLAYER_SKILL_CAPACITY, "角色技能战斗力加成"},
			{CharAttributeEnum.PLAYER_MENTALITY_CAPACITY, "角色元神战斗力加成"},
			{CharAttributeEnum.FIGHT_TOTAL_CAPACITY, "角色总战斗力"},
			{CharAttributeEnum.SERVER_ID, "服务器ID标识"},
			{CharAttributeEnum.CREATE_TIME, "创建时间"},
			{CharAttributeEnum.LOGIN_TIME, "登陆时间"},
			{CharAttributeEnum.LOGOUT_TIME, "登出时间"},
			{CharAttributeEnum.FORBID_LOGIN, "禁止登陆信息. (格式: 封禁状态_封禁起始时间(单位:秒)_封禁时长(单位:秒) )"},
			{CharAttributeEnum.FORBID_CHAT, "禁止聊天信息. (格式: 封禁状态_封禁起始时间(单位:秒)_封禁时长(单位:秒) )"},
			{CharAttributeEnum.LOGIN_COUNT, "登陆次数"},
			{CharAttributeEnum.LOGIN_DAYS, "连续登陆天数"},
			{CharAttributeEnum.TOTAL_LOGIN_DAYS, "总共登陆的天数"},
			{CharAttributeEnum.ONLINE_TIMES, "共在线时间. 单位:秒"},
			{CharAttributeEnum.TOTAL_ONLINE_TIMES, "总共在线时间. 单位:秒"},
		
		};
	}
	
}
