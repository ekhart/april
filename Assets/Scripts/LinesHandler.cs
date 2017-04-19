using UnityEngine;
 
public class LinesHandler : MonoBehaviour
{
    public Color c1 = Color.yellow;
    public Color c2 = Color.red;
 
    private GameObject lineGO;
    private LineRenderer lineRenderer;
    private int i = 0;
 
    void Start()
    {
        lineGO = new GameObject("Line");
        lineRenderer = lineGO.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Mobile/Particles/Additive"));
        lineRenderer.SetColors(c1, c2);
        lineRenderer.SetWidth(0.1f, 0);
        lineRenderer.numPositions = 0;
    }
     
    void Update()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
 
            if (touch.phase == TouchPhase.Moved)
            {
                lineRenderer.numPositions = i+1;
                var position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
                lineRenderer.SetPosition(i, Camera.main.ScreenToWorldPoint(position));
                i++;
                 
                var boxCollider = lineGO.AddComponent<BoxCollider>();
                boxCollider.transform.position = lineRenderer.transform.position;
                boxCollider.size = new Vector3(0.1f, 0.1f, 0.1f);
            }
             
            if (touch.phase == TouchPhase.Ended)
            {
                lineRenderer.numPositions = 0;
                i = 0;
                 
                var boxColliders = lineGO.GetComponents<BoxCollider>();
                foreach(var collider in boxColliders)
                {
                    Destroy(collider);
                }
            }
        }
    }
}