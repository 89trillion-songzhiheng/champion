using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

/// <summary> MyMethod is a method in the MyClass class.
/// 定位可领取奖励
/// </summary>
public class Check : MonoBehaviour
{
    public Card card; //卡片对象
    public Button checkButton; //查看按钮
    public GameObject content; //content
    public Text countNumber ; //当前分数
    
    private int high = 262; //每张卡片移动的高度

    void Start()
    {
        checkButton.onClick.AddListener(Locking);
    }
    
    /// <summary> MyMethod is a method in the MyClass class.
    /// 根据当前分数，判断可领取的最高奖励，并定位
    /// </summary>
    private void Locking()
    {
        //可领取奖励索引
        int cardInd = 0;
        
        cardInd = (int.Parse(countNumber.text) - card.lowNumber) / 200;

        //定位目前可领取的最高奖励
        if (cardInd >= 0)
        { 
            //滑动窗口（0，0，0）位置一直定位在第二个卡片，因此在第一个卡片的高度230上进行计算
            content.transform.position = new Vector3(content.transform.position.x, 
                230 - (high * cardInd)  , content.transform.position.z);
        }
    }
}
