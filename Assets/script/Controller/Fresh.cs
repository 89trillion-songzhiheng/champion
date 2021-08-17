using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

/// <summary> MyMethod is a method in the MyClass class.
/// 赛季刷新
/// </summary>
public class Fresh : MonoBehaviour
{
    public Text countNumber; //分数
    public Button freshButton; //刷新按钮
    public Card card; //卡片实例
    public Add addCount; //Add类实例
    
    private int countNum; //分数整型
    private int impairments;  //与奖励最低分的差值

    void Start()
    {
        freshButton.onClick.AddListener(ResetButton);
    }

    /// <summary> MyMethod is a method in the MyClass class.
    /// 按钮刷新
    /// </summary>
    private void ResetButton()
    {
        //赛季刷新重置按钮
        for (int i = 0; i < card.cardCount; i++)
        {
            card.cardList[i].btnObject.SetActive(true);
            card.cardList[i].bougObject.SetActive(false);
            card.cardList[i].buyButton.enabled = false;
        }

        countNum = int.Parse(countNumber.text);
        ResetCount();
    }
    
    /// <summary> MyMethod is a method in the MyClass class.
    /// 分数刷新
    /// </summary>
    private void ResetCount()
    {
        //4000以上，领取奖励
        if (countNum > card.lowNumber)
        { 
            countNum = card.lowNumber + (countNum - card.lowNumber) / 2;;
            countNumber.text = countNum.ToString();
        }
        
        impairments = countNum - card.lowNumber;
        
        if (impairments >= 0)
        {
            addCount.Change(impairments);
        }
    }
}
