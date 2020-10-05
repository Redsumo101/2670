using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
  public Vector3 value;

  public void SetValueFromVector3(Vector3 obj)
  {
    value = obj;
  }

  public void SetValueFromValue(Transform obj)
  {
    value = obj.position;
  }  
  
  public void SetValueFromRotation(Transform obj)
  {
    value = obj.eulerAngles;
  }

  public void SetPositionFromData(Transform obj)
  {
    obj.position = value;
  }
  
}
