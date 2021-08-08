using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

/**
 * 赛季刷新
 */
public class fresh : MonoBehaviour
{
    
    
    //刷新按钮
    public Button but;

    //分数
    public Text txt;

    private string s;

    private int i;

    private int c;

    //content
    public GameObject gg;
    
    // public GameObject gm;
    private int ii = 1;

    private int jj = 1;
    
    int sa = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        but.onClick.AddListener(sf);
        
    }

    public void sf()
    {
        sa = 1;
        //赛季刷新重置按钮
        while (sa<9)
        {
            gg.transform.Find("card" + sa + "/Button").gameObject.SetActive(true);
            gg.transform.Find("card" + sa + "/Text 1").gameObject.SetActive(false);
            sa++;
        }
        s = txt.text;
        i = int.Parse(s);
        //判断是否达到4000以上，方便领取奖励
        if (i > 4000)
        {
            i = 4000 + (i-4000)/2;;
            txt.text = i.ToString();
        }
        c = i - 4000;
        if (c>0)
        {
            jj = 1;
            ii = 1;
            chan(c);
        }
        
    }

    public void chan(int c )
    {
        //获取当前可领取个数
        int aa = c / 200;
        //计算分数
        int ajj = 200;
        
        
            while (ii <= aa)
            {
                //判断是否为1000的倍数，若是则跳过
                if (ajj%1000 !=0 )
                {
                    gg.transform.Find("card" + jj + "/Button").gameObject.GetComponent<Button>().enabled = true;
                    ajj += 200;
                    jj++;
                }else
                {
                    ajj += 200;
                }
                ii++;
            }

            //未达到领取条件的卡片设为按钮无效
            if (jj - 8 <=0)
            {
                gg.transform.Find("card" + jj + "/Button").gameObject.GetComponent<Button>().enabled = false;
                jj++;
            }
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
