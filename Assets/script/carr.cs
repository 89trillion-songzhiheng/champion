using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * 初始化卡片
 */
public class carr : MonoBehaviour
{

    public Text txt;

    private int b;

    private int c;
    
    int ii = 1;
    int jj = 1;
    private int kk = 0;
    private string bb;

   public  GameObject gbg;
    // Start is called before the first frame update
    void Start()
    {
        
        int i = 1;
        st(i);
    }

    public void st(int i)
    {
        while (i < 9){
                gbg.transform.Find("card"+i+"/Button").GetComponent<Button>().enabled = false;
                i++;
            }

        {
            
        }
    }

  
    void Update()
    {
 
    }
}
