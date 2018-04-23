#coding:utf8
'''
怪物经验每5级翻翻
杀死对应等级怪物数量 8只升级
5级之间线性插值 升级所需经验

5级别才能升一次武器等级
'''
def cal():
    initExp = 2000
    nextExp = 4000
    start = 0
    for i in xrange(0, 51):
        if i % 5 == 0:
            initExp = nextExp
            nextExp *= 2
            start = i
        diff = i-start
        curExp = initExp+(nextExp-initExp)*diff/5
        print curExp

#cal()
            

def cal2():
    initExp = 250
    nextExp = 500
    start = 0
    for i in xrange(0, 51):
        if i % 5 == 0:
            initExp = nextExp
            nextExp *= 2
            start = i
        diff = i-start
        curExp = initExp+(nextExp-initExp)*diff/5
        print curExp

cal2()
