using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class taskbar : MonoBehaviour
{
    public Slider taskBar;

    public void SetValue(float timer)
    {
        taskBar.value = timer;
    }
    

}
