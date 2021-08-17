using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary> MyMethod is a method in the MyClass class.
/// 卡片预质体实体类
/// </summary>
public class PrefabCard : MonoBehaviour
{
    public GameObject card; //卡片对象
    public Image coinImage; //硬币图像
    public Text coinNumber; //硬币数量
    public Button buyButton; //购买按钮
    public GameObject btnObject; //购买按钮对象
    public Text btnText; //按钮文字
    public Text bought; //显示已购买
    public GameObject bougObject; //显示已购买
    public GameObject countImage; //段位显示图片
    public Text countNumber; //显示大段位分数
    public Text rankText; //领取奖励所需的分数
    
}
