using System.Collections;
using System.Collections.Generic;
using MixedReality.Toolkit.UX;
using UnityEngine;

public class CreateDialog : MonoBehaviour
{
    public DialogPool dialogPool;

    public void GenerateDialog()
    {
        dialogPool.Get();


    }
}
