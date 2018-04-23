#coding:utf8
#导出地图数据为服务器可用的json形式

import os
import struct
import math 
import json
import codecs

def toInt(byte):
	return struct.unpack('@I', byte)[0]

def toShort(byte):
	return struct.unpack('@H', byte)[0]	



def readNodeData(gid, graph, width, height, jcon):
	length = toInt(graph[:4])
	print "node length ", length, length*8+4, len(graph)
	print "eachNode size", (len(graph)-4)/length
	print 'width * height', length, width, height, width*height

	start = 4
	mapdata = []
	mapHeight = []
	readMap = ''
	for i in xrange(0, length):
		pen = toInt(graph[start:start+4])
		start += 4
		flag = toInt(graph[start:start+4])
		start += 4


		x = toInt(graph[start:start+4])
		start+=4
		y = toInt(graph[start:start+4])
		start+=4
		z = toInt(graph[start:start+4])
		start+=4
		
		gridFlags = toShort(graph[start:start+2])
		start+=2
			
		#mapdata.append([x/1000.0, y/1000.0, z/1000.0, flag&0x1])
		mapHeight.append(y/1000.0)
		walk = 1-flag&0x1
		mapdata.append(str(walk))
		
		if i % width == 0:
			readMap += '\n'
		if width <= 200 or i%width >= width-200:
			if walk == 1:
				readMap += '1'
			else:
				readMap += '0'  	
	
	mapdata = ','.join(mapdata)
	out = {"id":gid, "width":width, "height":height, 
            "center":jcon["center"], 
            #"playerStart":playerStart["playerStart"], 
            "mapHeight":mapHeight, "mapdata":mapdata, 
            'changePoint':[],
    }
	return out, readMap






def exportMapData(dir):
	print 'export', dir
	mapId = int(dir)
	fullDir = os.path.join('rawMapData', dir)
	p1 = os.path.join(fullDir, "graph0_extra.binary")
	p2 = os.path.join(fullDir, "graph0.json")
	fn = os.path.join(fullDir, "playerStart"+str(mapId)+".json")
	co = open(fn).read()
	playerStart = json.loads(co)

	#地图上每个点的信息 是否可以通过
	graph = open(p1, 'rb').read()

	#地图基本信息 包括地图中心点位置 以及尺寸大小
	jcon = json.loads(open(p2).read())

	
	
	unclampedSize = jcon["unclampedSize"]
	print 'mapSize', unclampedSize
	#print jcon
	width = unclampedSize["x"]
	height = unclampedSize["y"]

	out, readMap = readNodeData(mapId, graph, width, height, jcon)
	out.update(playerStart)
	
	res = json.dumps([out])
	#供服务器使用的数据
	f = open(os.path.join(fullDir, "MapSourceConfig.xml"), 'w')
	f.write(res)
	f.close()

	#供测试 查看地图数据导出是否正确
	f = open(os.path.join(fullDir, "map.txt"), 'w')
	f.write(readMap)
	f.close()
	return out


allMap = os.listdir('rawMapData')
allList = []
for d in allMap:
	name = os.path.join('rawMapData', d)
	if os.path.isdir(name):
		allList.append(exportMapData(d))

path = u'地图'
fullPath = os.path.join(path, "MapSourceConfig.xml")
#.encode('gbk')

wout = json.dumps(allList)
f = open(fullPath, 'w')
f.write(wout)
f.close()


