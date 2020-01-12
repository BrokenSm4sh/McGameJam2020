using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItems : MonoBehaviour
{
  
    
    [System.Serializable]
    public class ObjectsToPlace 
    {
        public GameObject objectToPlace;
        [Range(1,30)]
        public int amountPerObject;
    }

    public ObjectsToPlace[] objectsToPlace;
    // Start is called before the first frame update
    void Awake()
    {
        int i = 0;
        foreach (var obj in objectsToPlace)
        {
            i = 0;
            while(i < obj.amountPerObject)
            {
                float generatedX = Random.Range(0,10);
                float generatedZ = Random.Range(0,10);
                Vector3 generatedPosition = new Vector3(generatedX,0, generatedZ);
                if (obj.objectToPlace != null) Object.Instantiate<GameObject>(obj.objectToPlace, generatedPosition,new Quaternion());
                i++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
