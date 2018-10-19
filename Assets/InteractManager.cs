using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractManager : MonoBehaviour {

    //public float rayDistance;

    public Text ItemName;
    public Text ShowInfo;

    public GameObject fireObject,fireAnimation,firepit;


    //int layerMask = 1<<9;

    //RaycastHit hit;

    bool hit;
    Collider col;
    string msg;


    void Start () {
		
	}

	void Update () {
        //layerMask = ~layerMask;
        //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward));
        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out hit, rayDistance, layerMask))
        //{
        //    ItemName.text = hit.transform.tag;
        //    ItemName.transform.parent.gameObject.SetActive(true);
        //    //Debug.Log(hit.transform.tag);
        //}
        //else
        //{
        //    ItemName.text = "";
        //    ItemName.transform.parent.gameObject.SetActive(false);
        //}

        if (hit)
        {
            ShowInfo.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(ShowMsg());
                //Destroy(col.gameObject);
            }
        }
        else
        {
            ShowInfo.gameObject.SetActive(false);
           
        }

    }
    
    IEnumerator ShowMsg()
    {
        if(col.tag =="Wood")
        {
            msg = "Collected wood";
            GameManager.woodCount++;
            Destroy(col.gameObject);
        }

        if (col.tag == "Fire")
        {
            if (!GameManager.canMakeFire)
            {
                msg = "I need more wood";
            }
            else
            {
                fireAnimation.SetActive(true);
                fireObject.SetActive(true);
                firepit.SetActive(false);
                GameManager.woodCount = -5;
            }
            
        }

        ItemName.text =msg ;
        ItemName.transform.parent.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);
        ItemName.transform.parent.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        col = other;
        if (other.gameObject.layer == 9)
        {
            hit = true;
        }
        else
        {
            hit = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        hit = false;
    }
}
