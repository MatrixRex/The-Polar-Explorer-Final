using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICode : MonoBehaviour {

    public GameObject pressE,restin;

	void Update ()
    {
		if(Input.GetMouseButton(0))
        {
            pressE.SetActive(true);
        }
        else
        {
            pressE.SetActive(false);
        }

        if(Input.GetMouseButton(1))
        {
            restin.SetActive(true);
        }

    }
}
