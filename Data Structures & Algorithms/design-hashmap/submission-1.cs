public class ListNode {
    public int key;
    public int value;
    public ListNode next;

    public ListNode(int key = -1, int val = -1, ListNode next = null) {
        this.key = key;
        this.value = val;
        this.next = next;
    }
}
public class MyHashMap {
    private ListNode[] map;

    public MyHashMap() {
        map = new ListNode[10_000];
        for (var i = 0; i < map.Length; i++) {
            map[i] = new ListNode();
        }    
    }

    public int Hash(int key) {
        return key % map.Length;
    }
    
    public void Put(int key, int value) {
        var cur = map[Hash(key)];

        while (cur.next != null) {
            if (cur.next.key == key) {
                cur.next.value = value;
                return;
            }
            cur = cur.next;
        }

        cur.next = new ListNode(key, value);
    }
    
    public int Get(int key) {
        var cur = map[Hash(key)];

        while (cur.next != null) {
            if (cur.next.key == key) {
                return cur.next.value;
            }
            cur = cur.next;
        }

        return -1;
    }
    
    public void Remove(int key) {
        var cur = map[Hash(key)];

        while (cur.next != null) {
            if (cur.next.key == key) {
                cur.next = cur.next.next;
                return;
            }
            cur = cur.next;
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */