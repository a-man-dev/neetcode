public class ListNode {
    public int Key;
    public ListNode Next;

    public ListNode(int key) {
        Key = key;
        Next = null;
    }
}

public class MyHashSet {

    private ListNode[] set;

    public MyHashSet() {
        set = new ListNode[10_000];
        for (var i = 0; i < set.Length; i++) {
            set[i] = new ListNode(0); // dummy node
        }
    }
    
    public void Add(int key) {
        var cursor = set[key % set.Length];
        while (cursor.Next != null) {
            if (cursor.Next.Key == key) {
                return;
            }
            cursor = cursor.Next;
        }
        cursor.Next = new ListNode(key);
    }
    
    public void Remove(int key) {
        var cursor = set[key % set.Length];
        while (cursor.Next != null) {
            if (cursor.Next.Key == key) {
                cursor.Next = cursor.Next.Next;
                return;
            }
            cursor = cursor.Next;
        } 
    }
    
    public bool Contains(int key) {
        var cursor = set[key % set.Length];
        while (cursor.Next != null) {
            if (cursor.Next.Key == key) {
                return true;
            }
            cursor = cursor.Next;
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