using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Footman>(out Footman footman))
        {
            footman.GetComponent<Animator>().SetTrigger("PathDone");
            
            Destroy(footman.gameObject, 1f);
        }
        
    }
}
