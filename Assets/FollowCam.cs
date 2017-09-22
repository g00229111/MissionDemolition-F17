using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    static public FollowCam S;

    public bool _____________;

    public GameObject poi;
    public float camZ;

    private void Awake()
    {
        S = this;
        camZ = this.transform.position.z;
    }




}
