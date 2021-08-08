using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class TextObject : MonoBehaviour
{
    public TextObjectData Books;
    protected GameObject[] PagesText = null;
    protected string[] bookData = null;
    void Start()
    {
        this.PagesText = GameObject.FindGameObjectsWithTag("Text");
        this.bookData = Books.BookData;
    }

}
