using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    
    public static float     bottomY = -20f;
    
    void Start()
    {
        
    }

	public void AppleDestroyed() {                                           
        GameObject[] tAppleArray=GameObject.FindGameObjectsWithTag("Apple"); 
        foreach ( GameObject tGO in tAppleArray ) {
            Destroy( tGO );
        }
    }
    
    void Update()
    {
        if ( transform.position.y < bottomY ) {
            Destroy( this.gameObject );                                     
            
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>(); 
            apScript.AppleDestroyed();            
        }
    }
}
