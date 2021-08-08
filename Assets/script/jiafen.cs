using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * 添加分数
 */
public class jiafen : MonoBehaviour
{
    //添加分数按钮
    public Button but;
    //当前分数
    public Text txt;

    private string s;

    private int i;

    private int c;

    private int jj = 1;

    private int ii = 1;
    //content
    public GameObject gbg;
    // Start is called before the first frame update
    void Start()
    {
        
        but.onClick.AddListener(add);
    }

    public void add()
    {
        s = txt.text;
        i = int.Parse(s);
        i += 100;
        txt.text = i.ToString();
        c = i - 4000;
        if (c>0)
        {
            jj = 1;
            ii = 1;
            change(c);
        }
    }
    
    public void change(int c)
    {
        int ajj = 200;
        int aa = c / 200;
        int cc = c % 200;
        while (ii <= aa)
        {   
            if (ajj%1000 !=0 ) 
            {   //达到领取分数，激活按钮
                gbg.transform.Find("card" + jj + "/Button").GetComponent<Button>().enabled = true;
                ajj += 200;
                jj++;
            }
            else
            {
                ajj += 200;
            }
            ii++;
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
