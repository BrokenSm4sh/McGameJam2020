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
        List<KeyValuePair<float,float>> positions = new List<KeyValuePair<float,float>>();
        float generatedX;
        float generatedZ;
        int i = 0;
        int noLuck = 0;
        foreach (var obj in objectsToPlace)
        {
            i = 0;
            while(i < obj.amountPerObject)
            {
                KeyValuePair<float, float> currentPos;
                noLuck = 0;
                do
                {
                     generatedX = Random.Range(0, 1000);
                     generatedZ = Random.Range(0, 1000);
                    currentPos = new KeyValuePair<float, float>(generatedX, generatedZ);
                    noLuck++;
                } while (!NotInRange(currentPos, positions) || noLuck < 255);

                // if (noLuck == 255)
                // {
                //     Debug.Log("no luck :(");
                //     continue;
                // }
                positions.Add(currentPos);
                Vector3 generatedPosition = new Vector3(generatedX,0, generatedZ);
                if (obj.objectToPlace != null) Object.Instantiate<GameObject>(obj.objectToPlace, generatedPosition,new Quaternion()).SetActive(true);
                i++;
            }
        }
    }

    private bool NotInRange(KeyValuePair<float, float> currentPos, List<KeyValuePair<float, float>> positions)
    {
        foreach (var position in positions)
        {
            if (Mathf.Abs(position.Key - currentPos.Key) < 10 ||
                Mathf.Abs(position.Value - currentPos.Value) < 10)
            {
                return false;
            }
        }

        return true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
