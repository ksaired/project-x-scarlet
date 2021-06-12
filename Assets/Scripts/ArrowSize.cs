using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSize : MonoBehaviour
{

    public GameObject thisObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetArrowScale(float x,float y)
    {
        thisObject.transform.localScale = new Vector3(x, y, 1);
    }

}
