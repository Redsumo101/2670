using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu]
public class StringListData : ScriptableObject
{
    public List<string> stringlist;
    private string returnValue;

    private int i;

    private void OnEnable()
    {
        i = 0;
    }

    public void GetNextString()
    {
        returnValue = stringlist[i];
        i++;
    }

    public void SetTextUiToValue(Text obj)
    {
        obj.text = returnValue;
    }
}
