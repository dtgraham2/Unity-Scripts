using UnityEngine;
using UnityEditor;
using System.IO;

public class DialogueParser : MonoBehaviour
{
    public TextAsset textFile;     // drop your file here in inspector

    void Start()
    {
        string text = textFile.text;  //this is the content as string
        string[] splitArray = text.Split(char.Parse("*"));
        Debug.Log(splitArray[0]);
        Debug.Log(splitArray[1]);
        Debug.Log(splitArray[2]);
    }
}