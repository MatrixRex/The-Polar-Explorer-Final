using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

	public static int woodCount;


    public int woodNeededForFire = 5;
    public Text woodCountText;



    public static bool canMakeFire;
    private void Start()
    {
        woodCountText.text = "5";
        woodCount = 5;
    }

    private void Update()
    {

        //woodCountText.text = woodCount.ToString();
        
        if(woodCount == woodNeededForFire)
        {
            canMakeFire = true;
        }
        else
        {
            canMakeFire = false;
        }
    }

}
