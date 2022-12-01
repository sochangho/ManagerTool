using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public abstract class ModelsBuilder
{
    public MultiColumnHeaderState.Column[] _columns;

    abstract public MultiColumnHeaderState.Column[] ColumnsSet();
}
