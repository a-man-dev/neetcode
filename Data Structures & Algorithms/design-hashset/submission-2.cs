public class MyHashSet {

    private List<int>[] data = new List<int>[10_000];

    public MyHashSet() {
        
    }
    
    public void Add(int key) {
       var index = key % 10_000;
       
       if (data[index] == null) {
            data[index] = [key];
        }
        else if (!data[index].Contains(key)) {
            data[index].Add(key);
        }   
    }
    
    public void Remove(int key) {
        var index = key % 10_000;
        if (data[index] != null) {
            data[index].Remove(key);
        }
    }
    
    public bool Contains(int key) {
        var index = key % 10_000;
        return data[index] != null && data[index].Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */