using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

/**
 * 更改购买状态
 */
public class buy : MonoBehaviour
{
    //领取按钮
    public Button but;


   
    //按钮
    public GameObject gg;
    //文本框显示已购买
    public GameObject gm;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    
        gg.SetActive(true);
        gm.SetActive(false);
        but.onClick.AddListener(chan);

        
    }

    public void chan()
    {
        
        gg.SetActive(false);
        gm.SetActive(true);
       

    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
