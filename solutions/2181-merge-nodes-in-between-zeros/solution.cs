/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeNodes(ListNode head) {
        ListNode currNode = head;
        // dopoki bieżący node nie jest null i next nie jest null wykonujemy operacje
        while(currNode !=null && currNode.next != null){
            // jesli next.val jest rózna od zera to dodajmy do biezacej next val i jako next dajemy next.next 
            // sprawia do ze poniekad jestemy ciagle w jednym nodzie i iterujemy po next'ach
            if(currNode.next.val !=0){
                currNode.val += currNode.next.val;
                currNode.next = currNode.next.next;
            }else{
                currNode = currNode.next;
            }

            if(currNode.next !=null && currNode.next.val == 0 && currNode.next.next == null){
                currNode.next = null;
            }
        }
        return head;
    }
}