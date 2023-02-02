using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{

    public GameObject diamond;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DropDiamond", 2.0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DropDiamond() {
        Instantiate(diamond);
    }

}
