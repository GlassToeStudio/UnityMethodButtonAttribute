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
    private void DoAThirdThing()
    {
        Debug.Log("That third thing be did.");
    }

#if UNITY_EDITOR
    [MethodButton("DoAThing", "DoAnotherThing", "DoAThirdThing")]
    [SerializeField] private bool editorFoldout;
#endif
}
