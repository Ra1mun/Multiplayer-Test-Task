﻿using UnityEngine;
using System.Collections.Generic;

public static class ListExtension
{
    public static T GetRandomItem<T>(this List<T> list)
    {
        var index = Random.Range(0, list.Count);
        return list[index];
    } 
}
