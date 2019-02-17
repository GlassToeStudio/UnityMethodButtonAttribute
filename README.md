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

    internal void ExampleInternalMethod()
    {
        Debug.Log("Invoking: ExampleClass.ExampleInternalMethod");
    }
    public void ExamplePublicMethod()
    {
        Debug.Log("Invoking: ExampleClass.ExamplePublicMethod");
    }
    private void ExamplePrivateMethod()
    {
        Debug.Log("Invoking: ExampleClass.ExamplePrivateMethod");
    }
    protected void ExampleProtectedMethod()
    {
        Debug.Log("Invoking: ExampleClass.ExampleProtectedMethod");
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
    [MethodButton("ExampleInternalMethod", "ExamplePublicMethod", "ExamplePrivateMethod", "ExampleProtectedMethod")]
    [SerializeField] private bool editorFoldout;
#endif
}
```


