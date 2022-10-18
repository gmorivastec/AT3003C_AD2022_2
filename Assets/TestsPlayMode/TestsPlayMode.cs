using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestsPlayMode
{

    private CartaLoader[] cartas;

    public TestsPlayMode(){
        cartas = GameObject.FindObjectsOfType<CartaLoader>();
    }
    // hay situaciones / valores que sólo se pueden comprobar en ejecución
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
