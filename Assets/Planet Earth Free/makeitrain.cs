using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeitrain : MonoBehaviour {

    [Tooltip("How quick your bool needs to be enlarged")]
    public float enlargeFactor = 0.001f;

    public struct Scale
    {
        public Vector3 vec;
        public void SetCoordinate(Vector3 newVec) {
            vec = newVec;
        }
    }
    // Start is called before the first frame update
    Scale coordinate = new Scale();

    void Start()
    {
        coordinate.SetCoordinate(transform.localScale);
    }

    // Update is called once per frame
    void Update()
    {
        coordinate.vec += new Vector3(enlargeFactor, enlargeFactor, enlargeFactor);
        transform.localScale = coordinate.vec;
    }
}
