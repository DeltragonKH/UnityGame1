using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chutemurro : MonoBehaviour
{
    public float maxY;
    public float minY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(transform.position.y > maxY)
        {
            Destroy(this.gameObject);
        }
     if(transform.position.y < minY)
        {
            Destroy(this.gameObject);
        }
    }
}
