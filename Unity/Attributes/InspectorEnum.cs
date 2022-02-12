using System;
using UnityEngine;

public class InspectorEnum : PropertyAttribute
{
    public Type propType;
    public InspectorEnum(Type aType)
    {
        propType = aType;
    }
}
