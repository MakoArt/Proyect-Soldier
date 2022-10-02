using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy Instance;


    private void Awake()
    {
        if (DontDestroy.Instance == null)
        {
            DontDestroy.Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(DontDestroy.Instance);
        }
    }
}
