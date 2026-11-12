public class MyHashSet {
    private ListNode[] Data;

    public MyHashSet() {
        Data = new ListNode[10_000];
        for (int i = 0; i < Data.Length; i++) {
            Data[i] = new ListNode(0); // Dummy head
        }
    }
    
    public void Add(int key) {
        ListNode cur = Data[key % Data.Length];
        while (cur.Next != null) {
            if (cur.Next.Key == key) {
                return;
            }
            cur = cur.Next;
        }
        cur.Next = new ListNode(key);
    }
    
    public void Remove(int key) {
        ListNode cur = Data[key % Data.Length];
        while (cur.Next != null) {
            if (cur.Next.Key == key) {
                cur.Next = cur.Next.Next;
                return;
            }
            cur = cur.Next;
        }
    }
    
    public bool Contains(int key) {
        var cur = Data[key % Data.Length];
        while (cur.Next != null) {
            if (cur.Next.Key == key) {
                return true;
            }
            cur = cur.Next;
        }
        return false;
    }
}

public class ListNode {
    public int Key { get; set; }

    public ListNode Next { get; set; }

    public ListNode(int key) {
        Key = key;
    }
}
/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */