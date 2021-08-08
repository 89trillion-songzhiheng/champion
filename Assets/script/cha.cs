using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/**
 * 定位可领取奖励
 */
public class cha : MonoBehaviour
{
    //查看按钮
    public Button butt;

    //content
    public GameObject sv;
   // content
    public GameObject gg;

    //存储当前奖励可领取个数
    private float yy;

    private int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        butt.onClick.AddListener(suo);
    }
    
    public void suo()
    {
        while (i < 9){
            if (gg.transform.Find("card"+i+"/Button").GetComponent<Button>().enabled == true)
            {
                yy = i;
                i++;
            }
            else
            {
                i = 1;
                break;
            }
            
        }
        
        sv.transform.position =new Vector3(sv.transform.position.x, 1800-(yy*400), sv.transform.position.z);
        Debug.Log(-yy+"___________");
        Debug.Log(sv.transform.position+"++++++++++++");
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
