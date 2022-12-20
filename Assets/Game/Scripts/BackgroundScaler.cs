using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScaler : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startScale;  
    void Start()
    {
        //Pego a escala global do valor inicial(x,y,z) dentro do atributo transform q td object tem
        startScale = transform.localScale;

        //Pega a metade da largura da camera e multiplica por dois
        float height = Camera.main.orthographicSize*2;
        //Normaliza a altura pela nova largura
        float width = height*Screen.width/Screen.height;

        //Atribui isso ao localScale
        transform.localScale = new Vector3(width, height, startScale.z);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
