using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LessonsBasic
{
 public class FirstLessonScript : MonoBehaviour
 {
     /// Comment yani herhangi bir þey yazabilirsiniz Bu 3 Slash içerisinde ilk defa /// koyunca alttaki gibi hazýr summary geliyor. Orada istediðinizi yazabilirsiniz.
     /// <summary>
     /// C# Variables
     /// </summary>
     // Start is called before the first frame update

     public int tamSayi = 1; //integar
     [SerializeField] int tamSayi2 = 100; //integar
     float ondalikliSayi = 0.25f;
     float ondalikliSayi2 = 5.2532324f;
     bool dogru = true;
     bool yanlis = false;
     [SerializeField]private Vector3 ucFloat = new Vector3(1, 2, 3);

     void Start()
     {
        
     }

     // Update is called once per frame
     void Update()
     {
        
     }
 }
}
