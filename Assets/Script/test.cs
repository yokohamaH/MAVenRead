using UnityEngine;

public class TestObject : MonoBehaviour
{
    public void TestA()
    {
        Debug.LogFormat( "Test A" );
    }

    private void TestB()
    {
        Debug.LogFormat( "Test B" );
    }

    protected void TestC()
    {
        Debug.LogFormat( "Test C" );
    }

    internal void TestD()
    {
        Debug.LogFormat( "Test D" );
    }

}
