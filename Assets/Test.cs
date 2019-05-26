using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Threading.Tasks;

public class AList
{
    public int b;
}


public class Test : MonoBehaviour
{
    private List<AList> _aList = new List<AList>();
    // Start is called before the first frame update
    void Start() {
        for (int i = 0; i < 5; i++) {
            AList a = new AList();
            a.b = i;
            _aList.Add(a);
        }

        Debug.Log("普通");
        var f = _aList.Where(x => x.b > 3)
            .Select(x => x.b + 5);
        //_aList.ForEach(x => x.b = 0);
        if (_aList.Any()) {

        }
        foreach (var a in f) {
            Debug.Log(a);
        }
    }


}
