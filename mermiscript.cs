using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermiscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       transform.eulerAngles = new Vector3(90,0,0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,5f,0)*5f*Time.deltaTime);
        if(transform.position.z > 100f){
            Destroy(this.gameObject);
        }
    }
}
