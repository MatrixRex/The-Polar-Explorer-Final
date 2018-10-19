using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderAnimation : MonoBehaviour {


    public Slider slider;

    public float animationSpeed;
    public float incriment;

    float val=0;

    private void Start()
    {
        
        val = 0;
        StartCoroutine(Incriment());
    }

    IEnumerator Incriment()
    {
        while(val<100)
        {
            yield return new WaitForSecondsRealtime(animationSpeed);
            val += incriment;
            slider.value = val;
        }

        gameObject.SetActive(false);
        val = 0;
    }
}
