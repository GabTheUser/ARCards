using UnityEngine;

public class ObjectsScript : MonoBehaviour
{
    public GameObject infoObj;
    public Material pickColors, startColor;
    public float maxFlashTime;
    public float flashTime;
    public Component[] mesh;
    Rotater rotaterScr;
    // Start is called before the first frame update
    void Start()
    {
        rotaterScr = FindObjectOfType<Rotater>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flashTime > 0)
        {
            flashTime -= Time.deltaTime;
        }
        else
        {         
            mesh = GetComponentsInChildren<MeshRenderer>();
            foreach (MeshRenderer meshR in mesh)
            {
                if (meshR.gameObject.name != "Text")
                    meshR.material = startColor;
            }
        }
    }
    void OnMouseDrag()
    {
            Debug.LogWarning("Mouse down");
            // rotating flag
            rotaterScr._isRotating = true;

        // store mouse
        rotaterScr._mouseReference = Input.mousePosition;
    }

    void OnMouseUp()
    {
            Debug.LogWarning("Mouse up");
        // rotating flag
        rotaterScr._isRotating = false;
    }
}
