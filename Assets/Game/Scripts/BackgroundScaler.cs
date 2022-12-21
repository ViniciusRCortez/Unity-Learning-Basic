using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScaler : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startScale;

    public enum ScaleTypes 
    {
        x,
        y,
        all
    }  

    public ScaleTypes scaleType = ScaleTypes.all; 
    void Start()
    {        
        FitToScreen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FitToScreen()
    {
        //Pego a escala global do valor inicial(x,y,z) dentro do atributo transform q td object tem
        startScale = transform.localScale;

        //Pega a metade da largura da camera e multiplica por dois
        float height = Camera.main.orthographicSize*2;
        //Normaliza a altura pela nova largura
        float width = height*Screen.width/Screen.height;

        float newWidth;
        float newHeight;
        
        //Escolha da logica de qual dimensão aplicar scale 
        newWidth = ( scaleType == ScaleTypes.x || scaleType == ScaleTypes.all ) ? width : startScale.x;
        newHeight = ( scaleType == ScaleTypes.y || scaleType == ScaleTypes.all ) ? height : startScale.y;

        //Atribui isso ao localScale
        transform.localScale = new Vector3(newWidth, newHeight, startScale.z);
    }
}
