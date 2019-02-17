# Unity MethodButton Attribute 

Add this attribute to your class to create buttons in the inspector for selected methods. No need for a custom editor.

<p align="center">
  <br>
  <img src="https://github.com/GlassToeStudio/UnityMethodButtonAttribute/blob/master/Images/MethodButtonAttribute.gif">
</p>

# Usage:
```cs
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public int ExampleInt;
    public bool ExampleBool;

    public void DoAThing()
    {
        Debug.Log("That thing be did.");
    }
    public void DoAnotherThing()
    {
        Debug.Log("That other thing be did.");
    }
    public void DoAThirdThing()
    {
        Debug.Log("That third thing be did.");
    }


    /* Add these four lines of code to your class.
     * Edit, add/remove, method names to the attribute.
     * Names must match the method name passed into the attribute.
     * 
     * The bool "editorFoldout" is used not only as the property that Unity will use to find the attribute,
     * but also as the bool for the foldout in the editor.
     * 
     * The #if UNITY_EDITOR preprocessor directive is so that this code is not compiled into the finished build.
     * So no need to remvoe it prior to building.
     */

#if UNITY_EDITOR
    [MethodButton("DoAThing", "DoAnotherThing", "DoAThirdThing")]
    [SerializeField] private bool editorFoldout; 
#endif
}

```


