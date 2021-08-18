# champion

**整体框架**
1.奖励卡片预质体类生成卡片，并对相关内容进行初始化
2.设置按钮的点击事件，并根据点击事件，设置相应
3.根据当前分数，设置可领取奖励的范围
 
 **目录结构**           
├── Controller  
│   ├── Add.cs //添加分数  
│   ├── Add.cs.meta  
│   ├── Card.cs //添加卡片分数  
│   ├── Card.cs.meta  
│   ├── Check.cs //查看当前可领取奖励位置  
│   ├── Check.cs.meta  
│   ├── Fresh.cs //赛季刷新  
│   └── Fresh.cs.meta  
├── Controller.meta  
├── View  
│   ├── PrefabCard.cs //奖励卡片预质体实体类  
│   └── PrefabCard.cs.meta  
└── View.meta  

**界面要求**
  Hierarchy
   1.Canvas
     1).OperatePanel:放置3个按钮。
        (1) Check:查看按钮，定位当前可领取最大奖励位置
        (2) Add: 添加分数
        (3) Fresh: 赛季刷新
     2).Scroll View:展示卡片
  Prefab
   1.card:奖励卡片的预质体
   
**流程图**

![image](https://github.com/89trillion-songzhiheng/champion/blob/main/Picture/NewChamp.png)
