public class MyHashMap {

    private ListNode[] Data { get; set; }

    public MyHashMap() {
        Data = new ListNode[10_000];
        for (var i = 0; i < Data.Length; i++) {
            Data[i] = new ListNode();
        }
    }
    
    public void Put(int key, int value) {
        var current = Data[key % Data.Length];

        while (current.Next != null) {
            if (current.Next.Key == key) {
                current.Next.Value = value;
                return;
            }
            current = current.Next;
        }

        current.Next = new ListNode(key, value);
    }
    
    public int Get(int key) {
        var current = Data[key % Data.Length];

        while (current.Next != null) {
            if (current.Next.Key == key) {
                return current.Next.Value;
            }
            current = current.Next;
        }

        return -1;
    }
    
    public void Remove(int key) {
        var current = Data[key % Data.Length];

        while (current.Next != null) {
            if (current.Next.Key == key) {
                current.Next = current.Next.Next;
                return;
            }
            current = current.Next;
        }
    }
}

public class ListNode {
    public int Key { get; set; }
    public int Value { get; set; }
    public ListNode Next { get; set; }

    public ListNode(int key, int value) {
        Key = key;
        Value = value;
    }

    public ListNode() {

    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */