public class MyHashSet {

    private int[] values;

    public MyHashSet() {
       values = new int[1_000_001];
       Array.Fill(values, -1);
    }
    
    public void Add(int key) {
        if (values[key] != key) {
            values[key] = key;
        }
    }
    
    public void Remove(int key) {
        if (values[key] == key) {
            values[key] = -1;
        }
    }
    
    public bool Contains(int key) {
        if (values[key] == key) {
            return true;
        }
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */