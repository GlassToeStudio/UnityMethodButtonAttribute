using UnityEngine;

public class MethodButtonTest : MonoBehaviour
{
    public int SomeInt;
    public bool SomeBool;

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

#if UNITY_EDITOR
    [MethodButton("DoAThing", "DoAnotherThing", "DoAThirdThing")]
    [SerializeField] private bool editorFoldout;
#endif
}
