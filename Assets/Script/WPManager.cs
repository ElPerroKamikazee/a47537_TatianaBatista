using UnityEngine;

[System.Serializable]
public struct Link {
    // Our two possible choices of single or bi direction
    public enum direction { UNI, BI };
    // Nodes
    public GameObject node1;
    public GameObject node2;
    // Direction UNI or BI
    public direction dir;
}

public class WPManager : MonoBehaviour {

    
    public GameObject[] waypoints;
   
    public Link[] links;
    public Graph graph = new Graph();

    
    void Start() {

        
        if (waypoints.Length > 0) {
            
            foreach (GameObject wp in waypoints) {
                graph.AddNode(wp);
            }

            
            foreach (Link l in links) {
                graph.AddEdge(l.node1, l.node2);
                if (l.dir == Link.direction.BI)
                    graph.AddEdge(l.node2, l.node1);
            }
        }
    }

    
    void Update() {

        
        graph.debugDraw();
    }
}
