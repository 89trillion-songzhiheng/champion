using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

/// <summary> MyMethod is a method in the MyClass class.
/// 卡片生成类
/// </summary>
public class Card : MonoBehaviour
{
    public List<PrefabCard> cardList; //存放卡片链表
    public Text coinNumber; //金币数量
    public GameObject content; //卡片父类
    public int cardCount = 0;  //获得生成卡片数量
    public int getNumber = 200; //计算可领取奖励分数
    public int lowNumber = 4000; //可领取奖励的最低段位分
    public PrefabCard prefabCard; //卡片预制件

    private int highNumber = 6000; //可领取奖励的最高段位分

    void Start()
    {
        cardCount = (highNumber - lowNumber)/200 + 1;
        InitCard();
    }

    /// <summary> MyMethod is a method in the MyClass class.
    /// 初始化卡片
    /// </summary>
    private void InitCard()
    {
        for (int i = 0; i < cardCount; i++)
        {
            PrefabCard  preCard = Instantiate(prefabCard, content.transform);
            preCard.bougObject.SetActive(false);
            preCard.buyButton.enabled = false;
            preCard.buyButton.onClick.AddListener(() => {Buy(preCard);});
            
            if (i % 5 == 0)
            {
                preCard.countImage.SetActive(true);
                preCard.countNumber.text = (lowNumber + i / 5 * 1000).ToString();
            }
            else
            {
                preCard.countImage.SetActive(false);
                preCard.rankText.text = (lowNumber + getNumber * i).ToString();
            }
            cardList.Add(preCard);
        }
    }
    
    /// <summary> MyMethod is a method in the MyClass class.
    /// 点击领取按钮，添加金币
    /// </summary>
    private void Buy(PrefabCard preCad)
    {
        coinNumber.text = (int.Parse(coinNumber.text) + 100).ToString();
        preCad.bougObject.SetActive(true);
        preCad.btnObject.SetActive(false);
    }
}
