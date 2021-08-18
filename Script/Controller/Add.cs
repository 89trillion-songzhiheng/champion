using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

/// <summary> MyMethod is a method in the MyClass class.
/// 添加分数
/// </summary>
public class Add : MonoBehaviour
{
    public Button addButton; //添加分数按钮
    public Card card; //卡片实例
    public Text countNumber; //当前分数
    
    private int addNumber = 100; //点击一次按钮增加的金币数
    private int countNum;  //分数整型
    private int impairment; //与奖励最低分的差值
    private int index; //卡片实例索引 
    void Start()
    {
        addButton.onClick.AddListener(AddCount);
    }
    
    private void AddCount()
    {
        countNum = int.Parse(countNumber.text);
        countNum += addNumber;
        countNumber.text = countNum.ToString();
        impairment = countNum - card.lowNumber;
        
        if (impairment >= 0)
        {
            Change(impairment);
        }
    }
    
    /*
     * impa获取增加的分数，如果累计增加的分数达到1000的倍数，则卡片显示达到的大段位分，若不是1000的倍数，
     * 则显示领取奖励，并根据business判断可领取的奖励数
     */
    public void Change(int impa)
    {
        //可领取的奖励数
        int business = 0;
        
        if (impa % 1000 !=0) 
        {
            business = impa / card.getNumber;
            for (int i = 1; i <= business; i++)
            {
                //达到领取分数，激活按钮
                card.cardList[i].buyButton.enabled = true;
                index = i;
            }
        }
        else
        {
            card.cardList[index].buyButton.enabled = true;
            card.cardList[index].countImage.SetActive(true);
            
            card.cardList[index].countNumber.text = countNum.ToString();
            index++;
            
        }
    }
}
