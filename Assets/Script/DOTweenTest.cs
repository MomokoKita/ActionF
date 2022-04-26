using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; //DOTween

public class DOTweenTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOLocalMove(new Vector3(0, 0, -10f), 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
