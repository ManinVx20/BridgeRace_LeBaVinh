using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectColorType
{
    Default,
    Red,
    Green,
    Blue,
    Yellow,
    Cyan,
    Magenta
}

public interface IHasColor
{
    ObjectColorType ColorType { get; set; }

    void ChangeObjectColorType(ObjectColorType type);
}
