using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "StoryData", menuName = "Scriptabl eObject/Story Data", order = int.MaxValue)]
public class ChocesOBJ : ScriptableObject
{
    [TextArea]
    public List<string> story = new List<string>();
}
